/*
 * This file is part of RNG Reporter
 * Copyright (C) 2012 by Bill Young, Mike Suleski, and Andrew Ringer
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */


using Microsoft.Win32;
using RNGReporter.Objects;
using RNGReporter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Version = RNGReporter.Objects.Version;
using System.Threading;

namespace RNGReporter
{
    public partial class MainForm : Form
    {
        public const int VersionNumber = 77446;
        private bool completeIVs;
        private EncounterMod currentMod;
        private ComboBoxItem[] cuteCharm;

        private List<Frame> frames;
        private uint[] parentA;
        private uint[] parentB;
        private uint[] rngIVs;
        private bool rngIVsOnly;
        private bool szWarned;
        private int targetFrameIndex;
        private TimeFinder3rd timeFinder3rd;
        private TimeFinder4th timeFinder4th;
        private TimeFinder5th timeFinder5th;
        private GameCube timeFinderGameCube;
        private PIDToIVs pidToIVs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add smart comboBox items
            // Would be nice if we left these in the Designer file
            // But Visual Studio seems to like deleting them without warning
            comboBoxMethod.Items.AddRange(new object[]
                {
                    new ComboBoxItem("Method 1", FrameType.Method1),
                    new ComboBoxItem("Method 1 Reverse PID", FrameType.Method1Reverse),
                    new ComboBoxItem("Method 2（GEN3）", FrameType.Method2),
                    new ComboBoxItem("Method 4（GEN3）", FrameType.Method4),
                    new ComboBoxItem("Method H-1（GEN3）", FrameType.MethodH1),
                    new ComboBoxItem("Method H-2（GEN3）", FrameType.MethodH2),
                    new ComboBoxItem("Method H-4（GEN3）", FrameType.MethodH4),
                    new ComboBoxItem("Method J（钻石珍珠白金）", FrameType.MethodJ),
                    new ComboBoxItem("Method K（心金魂银）", FrameType.MethodK),
                    new ComboBoxItem("GEN5个体值（普通的Seed）",
                                     FrameType.Method5Standard),
                    new ComboBoxItem("GEN5个体值（C装置Seed）", FrameType.Method5CGear),
                    new ComboBoxItem("GEN5 PIDRNG", FrameType.Method5Natures),
                    new ComboBoxItem("连锁异色", FrameType.ChainedShiny),
                    new ComboBoxItem("GEN4蛋PID（普通的）", FrameType.Gen4Normal),
                    new ComboBoxItem("GEN4蛋PID（异国）",
                                     FrameType.Gen4International),
                    new ComboBoxItem("孵蛋（绿宝石 普通遗传）", FrameType.Bred),
                    new ComboBoxItem("孵蛋（绿宝石 分裂遗传）", FrameType.BredSplit),
                    new ComboBoxItem("孵蛋（绿宝石 交替遗传）",
                                     FrameType.BredAlternate),
                    new ComboBoxItem("孵蛋（红蓝宝石）", FrameType.RSBredUpper),
                    new ComboBoxItem("孵蛋（钻石珍珠白金）", FrameType.DPPtBred),
                    new ComboBoxItem("孵蛋（心金魂银）", FrameType.HGSSBred),
                    new ComboBoxItem("孵蛋（黑白）", FrameType.BWBred),
                    new ComboBoxItem("孵蛋（黑白，异国）",
                                     FrameType.BWBredInternational),
                    new ComboBoxItem("神秘卡片个体值（GEN4）", FrameType.WondercardIVs),
                    new ComboBoxItem("神秘卡片（GEN5）", FrameType.Wondercard5thGen),
                    new ComboBoxItem("GLAN 神秘卡片（GEN5）",
                                     FrameType.Wondercard5thGenFixed),
                    new ComboBoxItem("圆形竞技场\\XD暗之旋风", FrameType.ColoXD),
                    new ComboBoxItem("宝可梦频道", FrameType.Channel)
                });

            cuteCharm = new[]
                {
                    new ComboBoxItem("首发♂（目标50%♀)", -1),
                    new ComboBoxItem("首发♂（目标75%♀)", -2),
                    new ComboBoxItem("首发♂（目标25%♀)", -3),
                    new ComboBoxItem("首发♂（目标12.5%♀)", -4),
                    new ComboBoxItem("首发♀（目标50%♂)", 1),
                    new ComboBoxItem("首发♀（目标75%♂)", 2),
                    new ComboBoxItem("首发♀（目标25%♂)", 3),
                    new ComboBoxItem("首发♀（目标87.5%♂)", 4)
                };

            var ability = new[]
                {
                    new ComboBoxItem("任意", -1),
                    new ComboBoxItem("特性0", 0),
                    new ComboBoxItem("特性1", 1)
                };

            currentMod = EncounterMod.Synchronize;

            try
            {
                if (Settings.Default.CPUs == 0)
                    Settings.Default.CPUs = Environment.ProcessorCount;
            }
            catch (ConfigurationErrorsException ex)
            {
                string filename = ((ConfigurationException)ex.InnerException).Filename;

                File.Delete(filename);
                Settings.Default.Reload();

                MessageBox.Show(
                    "RNG Reporter检测到一个损坏的配置文件，该文件已被删除。RNG Reporter必须重启。");

                Process.GetCurrentProcess().Kill();
            }

            comboBoxNature.Items.AddRange(Objects.Nature.NatureDropDownCollectionSearchNatures());
            ChangeLanguage((Language)Settings.Default.Language);

            showToolTipsToolStripMenuItem.Checked = Settings.Default.ShowToolTips;

            comboBoxSynchNatures.DataSource = Objects.Nature.NatureDropDownCollectionSynch();
            comboBoxAbility.DataSource = ability;

            comboBoxGender.DataSource = GenderFilter.GenderFilterCollectionMain();

            Size = Settings.Default.MySize;
            Location = Settings.Default.MyLoc;
            WindowState = Settings.Default.MyState;

            for (int i = 1; i <= Environment.ProcessorCount; i++)
                comboBoxCPUCount.Items.Add(i);

            comboBoxCPUCount.SelectedIndex = Settings.Default.CPUs - 1;
            comboBoxMethod.SelectedIndex = 0;
            comboBoxNature.SelectedIndex = 0;
            comboBoxAbility.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;

            comboBoxSynchNatures.SelectedIndex = 0;
            comboBoxEncounterType.SelectedIndex = 0;
            comboBoxEncounterSlot.SelectedIndex = 0;

            //  Set up the DoubleBufferedDataGridView to act as we would like it.
            dataGridViewValues.AutoGenerateColumns = false;
            PID.DefaultCellStyle.Format = "X8";

            /*
            RegistryKey registrySoftware = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Settings.Default.LastVersion < VersionNumber && registrySoftware != null)
            {
                //load registry
                RegistryKey registryRngReporter = registrySoftware.OpenSubKey("RNGReporter");
                if (registryRngReporter != null)
                {
                    maskedTextBoxSID.Text = (string) registryRngReporter.GetValue("sid", "0");
                    maskedTextBoxID.Text = (string) registryRngReporter.GetValue("id", "0");

                    //int lastVersion = Convert.ToInt32(registryRngReporter.GetValue("lastVersion", 0));

                    if (Settings.Default.LastVersion < VersionNumber)
                    {
                        var donationBox = new DonationBox();
                        donationBox.ShowDialog();

                        Settings.Default.LastVersion = VersionNumber;
                        Settings.Default.Save();
                    }

                    //build profile and start it
                    ushort id, sid;
                    uint vcount, timer0, gxstat, vframe;
                    ulong mac;

                    ushort.TryParse(maskedTextBoxID.Text, out id);
                    ushort.TryParse(maskedTextBoxSID.Text, out sid);
                    uint.TryParse((string) registryRngReporter.GetValue("vcount"),
                                  NumberStyles.HexNumber, null, out vcount);
                    uint.TryParse((string) registryRngReporter.GetValue("timer0"),
                                  NumberStyles.HexNumber, null, out timer0);
                    uint.TryParse((string) registryRngReporter.GetValue("gxstat"),
                                  NumberStyles.HexNumber, null, out gxstat);
                    uint.TryParse((string) registryRngReporter.GetValue("vframe"),
                                  NumberStyles.HexNumber, null, out vframe);
                    ulong.TryParse((string) registryRngReporter.GetValue("mac_address"),
                                   NumberStyles.HexNumber, null, out mac);
                    //note: the tryparse should return a 0 value if it fales, remove the redundant ? operators
                    var profile = new Profile
                                      {
                                          ID = id,
                                          SID = sid,
                                          VCount = vcount,
                                          Timer0Min = timer0,
                                          GxStat = gxstat,
                                          VFrame = vframe,
                                          MAC_Address = mac
                                      };
                    MessageBox.Show(
                        "RNG Reporter now has a new profile manager.\r\nPlease save your information in a profile.");
                    Profiles.ProfileManager.AddProfile(profile);
                    if (!Profiles.ProfileManager.Visible)
                        Profiles.ProfileManager.Show();
                }
            }*/
            maskedTextBoxSID.Text = Settings.Default.SID;
            maskedTextBoxID.Text = Settings.Default.ID;

            if (Settings.Default.LastVersion < VersionNumber)
            {
                var donationBox = new DonationBox();
                donationBox.ShowDialog();
                Settings.Default.LastVersion = VersionNumber;
            }

            if (File.Exists(Settings.Default.ProfileLocation))
                Profiles.LoadProfiles(Settings.Default.ProfileLocation);
            // used for update checks, only do it once a day
#if !DEBUG
            if ((DateTime.Now - Settings.Default.LastUpdate).Days > 0)
            {
                var checkUpdates = new Thread(CheckUpdates);
                checkUpdates.Start();
                Settings.Default.LastUpdate = DateTime.Now;
            }
#endif
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // used to force the time finder to save settings
            if (timeFinder5th != null) timeFinder5th.Close();

            Settings.Default.MyState = WindowState;
            //ComponentResourceManager test = new ComponentResourceManager();

            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.MySize = Size;
                Settings.Default.MyLoc = Location;
            }
            else
            {
                Settings.Default.MySize = RestoreBounds.Size;
                Settings.Default.MyLoc = RestoreBounds.Location;
            }

            Settings.Default.ID = maskedTextBoxID.Text;
            Settings.Default.SID = maskedTextBoxSID.Text;

            Settings.Default.Save();

            // will be used to remove old registry once transition is complete
            //DeleteOldRegistry();
        }

        //transitional registry to settings information
        private void DeleteOldRegistry()
        {
            RegistryKey registrySoftware = Registry.CurrentUser.OpenSubKey("Software", true);
            if (registrySoftware != null)
            {
                try
                {
                    registrySoftware.DeleteSubKeyTree("RNGReporter");
                }
                catch
                {
                }
            }
        }

        // we may want to only check the server once a day or something to prevent overloading it
        private static void CheckUpdates()
        {
            const string url = "http://eggmove.com/RNGReporter/version.txt";
            const string updater = "http://eggmove.com/RNGReporter/Updater.exe";

            try
            {
                var client = new WebClient();
                string versionString = client.DownloadString(url);

                char[] splitter = { ',' };
                string[] versionInfo = versionString.Split(splitter, 4);
                int latestVersion = int.Parse(versionInfo[0]);

                if (latestVersion > VersionNumber)
                {
                    DialogResult result = MessageBox.Show(
                        "Your version of RNG Reporter is outdated.  The latest version is " + versionInfo[1] + "."
                        + Environment.NewLine + Environment.NewLine + "What's new: " + versionInfo[3] +
                        Environment.NewLine + Environment.NewLine +
                        "Would you like to download and install the latest version now?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string temp = Path.GetTempFileName() + ".exe";
                        var webClient = new WebClient();
                        webClient.DownloadFile(updater, temp);
                        string location = Assembly.GetEntryAssembly().Location;
                        Process.Start(temp, string.Format("\"{0}\" \"{1}\"", location, versionInfo[2]));
                        Application.Exit();
                    }
                }
            }
            catch
            {
            }
        }

        private void dataGridViewValues_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //  Make all of the junk natures show up in a lighter color
            if (dataGridViewValues.Columns[e.ColumnIndex].Name == "Nature")
            {
                var nature = (string)e.Value;

                if (nature == Functions.NatureStrings(18) ||
                    nature == Functions.NatureStrings(6) ||
                    nature == Functions.NatureStrings(0) ||
                    nature == Functions.NatureStrings(24) ||
                    nature == Functions.NatureStrings(12) ||
                    nature == Functions.NatureStrings(9) ||
                    nature == Functions.NatureStrings(21))
                {
                    e.CellStyle.ForeColor = Color.Gray;
                }

                if ((bool)dataGridViewValues.Rows[e.RowIndex].Cells["Synchable"].Value)
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
            }

            if (dataGridViewValues.Columns[e.ColumnIndex].Name == "HP" ||
                dataGridViewValues.Columns[e.ColumnIndex].Name == "Atk" ||
                dataGridViewValues.Columns[e.ColumnIndex].Name == "Def" ||
                dataGridViewValues.Columns[e.ColumnIndex].Name == "SpA" ||
                dataGridViewValues.Columns[e.ColumnIndex].Name == "SpD" ||
                dataGridViewValues.Columns[e.ColumnIndex].Name == "Spe")
            {
                if ((string)e.Value == "30" || (string)e.Value == "31")
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }

                if ((string)e.Value == "0")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }

                if ((string)e.Value == "A" || (string)e.Value == "Ma" ||
                    (string)e.Value == "B" || (string)e.Value == "Fe")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Generate();
            dataGridViewValues.Focus();
        }

        private void Generate()
        {
            // We want to force an early garbage collection
            // Because the frame lists get very big, very fast
            if (frames != null)
            {
                frames.Clear();
                frames = null;
            }

            //  Nuke the target frame when we generate a new list.  This may
            //  end up being controversial need to be revisted, but we can
            //  do this at a later time after we get a complaint. :)
            SetTargetFrame(-1); // = 0;

            // Set up generator settings
            var generator = new FrameGenerator
            {
                FrameType = (FrameType)((ComboBoxItem)comboBoxMethod.SelectedItem).Reference,
                EncounterMod = currentMod
            };

            var offset = (uint)(checkBoxBW2.Visible && checkBoxBW2.Checked && generator.FrameType != FrameType.Method5Natures &&
                 generator.FrameType != FrameType.BWBred && generator.FrameType != FrameType.BWBredInternational ? 2 : 0);

            if (generator.FrameType == FrameType.BWBred && checkBoxBW2.Checked)
                generator.FrameType = FrameType.BW2Bred;
            if (generator.FrameType == FrameType.BWBredInternational && checkBoxBW2.Checked)
                generator.FrameType = FrameType.BW2BredInternational;
            if (currentMod == EncounterMod.Synchronize && comboBoxSynchNatures.SelectedIndex == 0)
                generator.EncounterMod = EncounterMod.None;

            if (currentMod == EncounterMod.CuteCharm)
                generator.SynchNature = (int)((ComboBoxItem)comboBoxSynchNatures.SelectedItem).Reference;
            else
                generator.SynchNature = ((Nature)comboBoxSynchNatures.SelectedItem).Number;

            generator.EncounterType = EncounterTypeCalc.EncounterString(comboBoxEncounterType.Text);
            generator.DittoUsed = checkBoxDittoParent.Checked;
            generator.MaleOnlySpecies = cbNidoBeat.Checked;
            generator.ShinyCharm = cbShinyCharm.Checked;

            // this is for PIDRNG encounter slots
            generator.isBW2 = checkBoxBW2.Visible && checkBoxBW2.Checked;

            if (generator.EncounterType == EncounterType.SafariZone || generator.EncounterType == EncounterType.BugCatchingContest && !szWarned)
            {
                var warning = new WarningSZ();
                warning.ShowDialog();
                szWarned = true;
            }

            //  Build up a FrameComparer
            List<int> encounterSlots = null;
            if (comboBoxEncounterSlot.Text != "任意" && comboBoxEncounterSlot.CheckBoxItems.Count > 0)
            {
                encounterSlots = new List<int>();
                for (int i = 0; i < comboBoxEncounterSlot.CheckBoxItems.Count; i++)
                {
                    if (comboBoxEncounterSlot.CheckBoxItems[i].Checked)
                        // We have to subtract 1 because this custom control contains a hidden item for text display
                        encounterSlots.Add(i - 1);
                }
            }

            List<uint> natures = null;
            if (comboBoxNature.Text != "任意" && comboBoxNature.CheckBoxItems.Count > 0)
            {
                natures = (from t in comboBoxNature.CheckBoxItems where t.Checked select (uint)((Nature)t.ComboBoxItem).Number).ToList();
            }

            generator.ParentA = parentA;
            generator.ParentB = parentB;
            generator.RNGIVs = rngIVs;

            FrameCompare frameCompare;
            // Create separate FrameCompares for methods that don't produce natures or IVs
            if (generator.FrameType == FrameType.Method5Standard || generator.FrameType == FrameType.Method5CGear ||
                (generator.FrameType == FrameType.WondercardIVs && generator.EncounterType != EncounterType.Manaphy) ||
                generator.FrameType == FrameType.Bred || generator.FrameType == FrameType.BredAlternate || generator.FrameType == FrameType.BredSplit ||
                generator.FrameType == FrameType.RSBredUpper ||
                generator.FrameType == FrameType.DPPtBred ||
                generator.FrameType == FrameType.HGSSBred)
            {
                frameCompare = new FrameCompare(
                    ivFilters.IVFilter,
                    null,
                    -1,
                    false,
                    false,
                    false,
                    null,
                    new NoGenderFilter());
            }
            else if (generator.FrameType == FrameType.Method5Natures)
            {
                frameCompare = new FrameCompare(
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    natures,
                    (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                    checkBoxShinyOnly.Checked,
                    checkBoxSynchOnly.Checked,
                    false,
                    encounterSlots,
                    (GenderFilter)(comboBoxGender.SelectedItem));

                generator.RNGIVs = rngIVs;
            }
            else if (generator.FrameType == FrameType.Gen4Normal || generator.FrameType == FrameType.Gen4International)
            {
                frameCompare = new FrameCompare(
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    0, CompareType.None,
                    natures,
                    (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                    checkBoxShinyOnly.Checked,
                    false,
                    false,
                    null,
                    (GenderFilter)(comboBoxGender.SelectedItem));
            }
            else if (generator.FrameType == FrameType.Method1 ||
                     generator.FrameType == FrameType.Method1Reverse ||
                     generator.FrameType == FrameType.Method2 ||
                     generator.FrameType == FrameType.Method3 ||
                     generator.FrameType == FrameType.Method4 ||
                     generator.FrameType == FrameType.ChainedShiny ||
                     generator.FrameType == FrameType.ColoXD ||
                     generator.FrameType == FrameType.Channel ||
                     generator.FrameType == FrameType.WondercardIVs)
            {
                frameCompare = new FrameCompare(
                    ivFilters.IVFilter,
                    natures,
                    (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                    checkBoxShinyOnly.Checked,
                    false,
                    false,
                    null,
                    (GenderFilter)(comboBoxGender.SelectedItem));
            }
            else if (generator.FrameType == FrameType.Wondercard5thGen || generator.FrameType == FrameType.Wondercard5thGenFixed)
            {
                frameCompare = new FrameCompare(
                    ivFilters.IVFilter,
                    natures,
                    (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                    checkBoxShinyOnly.Checked,
                    false,
                    false,
                    null,
                    (GenderFilter)(comboBoxGender.SelectedItem));
            }
            else if (generator.FrameType == FrameType.BWBred || generator.FrameType == FrameType.BWBredInternational ||
                     generator.FrameType == FrameType.BW2Bred || generator.FrameType == FrameType.BW2BredInternational)
            {
                if (parentA != null && parentB != null && rngIVs != null)
                {
                    frameCompare = new FrameCompare(
                        ivFilters.IVFilter,
                        natures,
                        (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                        checkBoxShinyOnly.Checked,
                        checkBoxSynchOnly.Checked,
                        checkBoxDreamWorld.Checked,
                        null,
                        (GenderFilter)(comboBoxGender.SelectedItem));
                }
                else
                {
                    frameCompare = new FrameCompare(
                        0, CompareType.None,
                        0, CompareType.None,
                        0, CompareType.None,
                        0, CompareType.None,
                        0, CompareType.None,
                        0, CompareType.None,
                        natures,
                        (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                        checkBoxShinyOnly.Checked,
                        checkBoxSynchOnly.Checked,
                        checkBoxDreamWorld.Checked,
                        null,
                        (GenderFilter)(comboBoxGender.SelectedItem));
                }
            }
            else
            {
                frameCompare = new FrameCompare(
                    ivFilters.IVFilter,
                    natures,
                    (int)((ComboBoxItem)comboBoxAbility.SelectedItem).Reference,
                    checkBoxShinyOnly.Checked,
                    checkBoxSynchOnly.Checked,
                    false,
                    encounterSlots,
                    (GenderFilter)(comboBoxGender.SelectedItem));
            }

            ulong seed = 0;

            if (textBoxSeed.Text != "")
            {
                if ((generator.FrameType == FrameType.BWBred ||
                     generator.FrameType == FrameType.BWBredInternational ||
                     generator.FrameType == FrameType.BW2Bred ||
                     generator.FrameType == FrameType.BW2BredInternational ||
                     generator.FrameType == FrameType.Method5Natures) &&
                    textBoxSeed.Text.Length == 8)
                {
                    MessageBox.Show("此算法要求您从“seed时间查找”窗口复制完整seed。");
                    seed = ulong.Parse(textBoxSeed.Text, NumberStyles.HexNumber);
                }
                else if (generator.FrameType == FrameType.Method5Standard && textBoxSeed.Text.Length > 8)
                {
                    seed = ulong.Parse(textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8),
                                       NumberStyles.HexNumber);
                }
                else
                {
                    seed = ulong.Parse(textBoxSeed.Text, NumberStyles.HexNumber);
                }
            }

            generator.InitialSeed = seed;

            //  Handle add seed finding activities
            labelFlipsForSeed.Text = CoinFlips.GetFlips((uint)seed, 10);

            // Handle all of the roaming Pokemon here            
            uint rRoute = 0;
            uint eRoute = 0;
            uint lRoute = 0;

            // need to tryparse out all of the route values
            if (maskedTextBoxRRoute.Text != "")
                rRoute = uint.Parse(maskedTextBoxRRoute.Text);

            if (maskedTextBoxERoute.Text != "")
                eRoute = uint.Parse(maskedTextBoxERoute.Text);

            if (maskedTextBoxLRoute.Text != "")
                lRoute = uint.Parse(maskedTextBoxLRoute.Text);

            //  We need to know two things, forced advancement and the 
            //  starting route of each of the roamers the user has
            //  shown interest in --
            HgSsRoamerInformation information = HgSsRoamers.GetHgSsRoamerInformation(
                (uint)seed,
                checkBoxRPresent.Checked,
                checkBoxEPresent.Checked,
                checkBoxLPresent.Checked,
                rRoute,
                eRoute,
                lRoute);

            //  Build our roaming monster string
            //labelRoamerRoutes.Text = "";

            string labelRoamerRoutesText = "";

            bool firstDisplay = true;

            if (checkBoxRPresent.Checked)
            {
                labelRoamerRoutesText += "R: " + information.RCurrentRoute;
                firstDisplay = false;
            }

            if (checkBoxEPresent.Checked)
            {
                if (!firstDisplay)
                    labelRoamerRoutesText += "  ";

                labelRoamerRoutesText += "E: " + information.ECurrentRoute;
                firstDisplay = false;
            }

            if (checkBoxLPresent.Checked)
            {
                if (!firstDisplay)
                    labelRoamerRoutesText += "  ";

                labelRoamerRoutesText += "L: " + information.LCurrentRoute;
                firstDisplay = false;
            }

            if (!firstDisplay)
            {
                labelRoamerRoutesText += "  ---  ";
                labelRoamerRoutesText += "游走消耗的帧数: " + information.RngCalls;
            }

            labelRoamerRoutes.Text = labelRoamerRoutesText;

            //  Handle elm here, letting it know the foced advancement
            labelElmForSeed.Text = Responses.ElmResponses((uint)seed, 10, information.RngCalls);

            if (maskedTextBoxStartingFrame.Text != "")
            {
                ulong startingFrame;
                ulong.TryParse(maskedTextBoxStartingFrame.Text, out startingFrame);
                if (startingFrame > uint.MaxValue) startingFrame = uint.MaxValue - offset;
                generator.InitialFrame = (uint)startingFrame;
                generator.InitialFrame += offset;
            }

            if (maskedTextBoxMaxFrames.Text != "")
            {
                ulong maxFrames;
                ulong.TryParse(maskedTextBoxMaxFrames.Text, out maxFrames);
                if (maxFrames > uint.MaxValue) maxFrames = uint.MaxValue;
                generator.MaxResults = (uint)maxFrames;
            }

            //  Figure out if we have something good to pass in
            //  for the ID and Secret ID to do shiny calculations.
            ushort id;
            ushort sid;

            ushort.TryParse(maskedTextBoxID.Text, out id);
            ushort.TryParse(maskedTextBoxSID.Text, out sid);

            //  This is where we actually go ahead and call our 
            //  generator for a list of IVs based on parameters
            //  that have been passed in.

            //Channel
            if (generator.FrameType == FrameType.Channel)
                id = 40122;

            frames = generator.Generate(frameCompare, id, sid);

            foreach (Frame frame in frames)
            {
                frame.DisplayPrep();
            }

            Frame.DataPropertyName = generator.FrameType == FrameType.BredSplit
                                         ? "Name"
                                         : "Number";

            HP.DataPropertyName = "DisplayHp";
            Atk.DataPropertyName = "DisplayAtk";
            Def.DataPropertyName = "DisplayDef";
            SpA.DataPropertyName = "DisplaySpa";
            SpD.DataPropertyName = "DisplaySpd";
            Spe.DataPropertyName = "DisplaySpe";
            Characteristic.Visible = false;
            PossibleShakingSpot.Visible = false;

            if (parentA != null && parentB != null && rngIVs != null)
            {
                if (generator.FrameType == FrameType.Bred ||
                    generator.FrameType == FrameType.BredSplit ||
                    generator.FrameType == FrameType.BredAlternate ||
                    generator.FrameType == FrameType.RSBredUpper ||
                    generator.FrameType == FrameType.DPPtBred ||
                    generator.FrameType == FrameType.HGSSBred)
                {
                    foreach (Frame frame in frames)
                    {
                        frame.DisplayHpAlt = (frame.DisplayHp == "A" || frame.DisplayHp == "B")
                                                 ? (frame.DisplayHp == "A"
                                                        ? Functions.NullIV(parentA[0], "A")
                                                        : Functions.NullIV(parentB[0], "B"))
                                                 : frame.DisplayHp;
                        frame.DisplayAtkAlt = (frame.DisplayAtk == "A" || frame.DisplayAtk == "B")
                                                  ? (frame.DisplayAtk == "A"
                                                         ? Functions.NullIV(parentA[1], "A")
                                                         : Functions.NullIV(parentB[1], "B"))
                                                  : frame.DisplayAtk;
                        frame.DisplayDefAlt = (frame.DisplayDef == "A" || frame.DisplayDef == "B")
                                                  ? (frame.DisplayDef == "A"
                                                         ? Functions.NullIV(parentA[2], "A")
                                                         : Functions.NullIV(parentB[2], "B"))
                                                  : frame.DisplayDef;
                        frame.DisplaySpaAlt = (frame.DisplaySpa == "A" || frame.DisplaySpa == "B")
                                                  ? (frame.DisplaySpa == "A"
                                                         ? Functions.NullIV(parentA[3], "A")
                                                         : Functions.NullIV(parentB[3], "B"))
                                                  : frame.DisplaySpa;
                        frame.DisplaySpdAlt = (frame.DisplaySpd == "A" || frame.DisplaySpd == "B")
                                                  ? (frame.DisplaySpd == "A"
                                                         ? Functions.NullIV(parentA[4], "A")
                                                         : Functions.NullIV(parentB[4], "B"))
                                                  : frame.DisplaySpd;
                        frame.DisplaySpeAlt = (frame.DisplaySpe == "A" || frame.DisplaySpe == "B")
                                                  ? (frame.DisplaySpe == "A"
                                                         ? Functions.NullIV(parentA[5], "A")
                                                         : Functions.NullIV(parentB[5], "B"))
                                                  : frame.DisplaySpe;
                    }

                    HP.DataPropertyName = "DisplayHpAlt";
                    Atk.DataPropertyName = "DisplayAtkAlt";
                    Def.DataPropertyName = "DisplayDefAlt";
                    SpA.DataPropertyName = "DisplaySpaAlt";
                    SpD.DataPropertyName = "DisplaySpdAlt";
                    Spe.DataPropertyName = "DisplaySpeAlt";
                }

                if (generator.FrameType == FrameType.BWBred ||
                    generator.FrameType == FrameType.BWBredInternational ||
                    generator.FrameType == FrameType.BWBred ||
                    generator.FrameType == FrameType.BWBredInternational)
                {
                    foreach (Frame frame in frames)
                    {
                        frame.DisplayHpAlt = string.IsNullOrEmpty(frame.DisplayHp)
                                                 ? Functions.NullIV(rngIVs[0])
                                                 : (frame.DisplayHp == "Fe"
                                                        ? Functions.NullIV(parentA[0], "Fe")
                                                        : Functions.NullIV(parentB[0], "Ma"));
                        frame.DisplayAtkAlt = string.IsNullOrEmpty(frame.DisplayAtk)
                                                  ? Functions.NullIV(rngIVs[1])
                                                  : (frame.DisplayAtk == "Fe"
                                                         ? Functions.NullIV(parentA[1], "Fe")
                                                         : Functions.NullIV(parentB[1], "Ma"));
                        frame.DisplayDefAlt = string.IsNullOrEmpty(frame.DisplayDef)
                                                  ? Functions.NullIV(rngIVs[2])
                                                  : (frame.DisplayDef == "Fe"
                                                         ? Functions.NullIV(parentA[2], "Fe")
                                                         : Functions.NullIV(parentB[2], "Ma"));
                        frame.DisplaySpaAlt = string.IsNullOrEmpty(frame.DisplaySpa)
                                                  ? Functions.NullIV(rngIVs[3])
                                                  : (frame.DisplaySpa == "Fe"
                                                         ? Functions.NullIV(parentA[3], "Fe")
                                                         : Functions.NullIV(parentB[3], "Ma"));
                        frame.DisplaySpdAlt = string.IsNullOrEmpty(frame.DisplaySpd)
                                                  ? Functions.NullIV(rngIVs[4])
                                                  : (frame.DisplaySpd == "Fe"
                                                         ? Functions.NullIV(parentA[4], "Fe")
                                                         : Functions.NullIV(parentB[4], "Ma"));
                        frame.DisplaySpeAlt = string.IsNullOrEmpty(frame.DisplaySpe)
                                                  ? Functions.NullIV(rngIVs[5])
                                                  : (frame.DisplaySpe == "Fe"
                                                         ? Functions.NullIV(parentA[5], "Fe")
                                                         : Functions.NullIV(parentB[5], "Ma"));

                        if (completeIVs)
                        {
                            var DisplayIVs = new[]
                                {
                                    uint.Parse(frame.DisplayHpAlt),
                                    uint.Parse(frame.DisplayAtkAlt),
                                    uint.Parse(frame.DisplayDefAlt),
                                    uint.Parse(frame.DisplaySpeAlt),
                                    uint.Parse(frame.DisplaySpaAlt),
                                    uint.Parse(frame.DisplaySpdAlt)
                                };

                            frame.CharacteristicIVs = DisplayIVs;
                        }

                        HP.DataPropertyName = "DisplayHpAlt";
                        Atk.DataPropertyName = "DisplayAtkAlt";
                        Def.DataPropertyName = "DisplayDefAlt";
                        SpA.DataPropertyName = "DisplaySpaAlt";
                        SpD.DataPropertyName = "DisplaySpdAlt";
                        Spe.DataPropertyName = "DisplaySpeAlt";
                    }

                    Characteristic.Visible = completeIVs;
                }

                if (generator.FrameType == FrameType.Method5Natures && rngIVsOnly)
                {
                    // make the characteristic IVs, we need to clone the array because the function moves them
                    uint[] characteristicIVs = Functions.moveSpeFromBack(rngIVs);
                    foreach (Frame frame in frames)
                    {
                        frame.CharacteristicIVs = characteristicIVs;
                    }
                    Characteristic.Visible = true;
                }
            }

            //  Hide some columns based on output type
            if (generator.FrameType == FrameType.RSBredLower)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = true;
                Time.DataPropertyName = "Time";
                Shiny.Visible = false;
                Nature.Visible = false;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = false;
                Atk.Visible = false;
                Def.Visible = false;
                SpA.Visible = false;
                SpD.Visible = false;
                Spe.Visible = false;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            //  Hide some columns based on output type
            if (generator.FrameType == FrameType.RSBredUpper)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = true;
                Time.DataPropertyName = "Time";
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            //  Hide some columns based on output type
            if (generator.FrameType == FrameType.Bred ||
                generator.FrameType == FrameType.BredSplit ||
                generator.FrameType == FrameType.BredAlternate ||
                generator.FrameType == FrameType.RSBredUpper)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = false;
                Time.Visible = true;
                Time.DataPropertyName = "Time";
                Shiny.Visible = false;
                Nature.Visible = false;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            //  Hide some columns based on output type

            if (generator.FrameType == FrameType.Method5Standard ||
                generator.FrameType == FrameType.Method5CGear)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = false;
                Time.Visible = false;
                Shiny.Visible = false;
                Nature.Visible = false;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }
            else if (generator.FrameType == FrameType.DPPtBred)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = false;
                Time.Visible = false;
                Shiny.Visible = false;
                Nature.Visible = false;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.Method5Natures)
            {
                Frame.Visible = true;
                Offset.Visible = false;

                if (generator.EncounterType != EncounterType.Stationary &&
                    generator.EncounterType != EncounterType.Gift &&
                    generator.EncounterType != EncounterType.Roamer &&
                    generator.EncounterType != EncounterType.LarvestaEgg &&
                    generator.EncounterType != EncounterType.Entralink &&
                    generator.EncounterType != EncounterType.HiddenGrotto)
                    EncounterSlot.Visible = true;
                else
                    EncounterSlot.Visible = false;


                ItemCalc.Visible = false;
                PID.Visible = true;

                if (generator.EncounterType == EncounterType.Entralink)
                {
                    Time.Visible = true;
                    Time.DataPropertyName = "EntralinkTime";
                }
                else
                {
                    Time.Visible = false;
                    Time.DataPropertyName = "Time";
                }

                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot64";

                if (generator.EncounterType == EncounterType.WildCaveSpot ||
                    generator.EncounterType == EncounterType.WildWaterSpot ||
                    generator.EncounterType == EncounterType.WildShakerGrass)
                {
                    CaveSpot.Visible = true;
                    if (generator.EncounterType == EncounterType.WildCaveSpot)
                        CaveSpot.HeaderText = "卷尘地面";
                    else if (generator.EncounterType == EncounterType.WildWaterSpot)
                        CaveSpot.HeaderText = "水纹水面";
                    else
                        CaveSpot.HeaderText = "摇动草丛";
                }
                else
                {
                    CaveSpot.Visible = false;
                }

                HP.Visible = false;
                Atk.Visible = false;
                Def.Visible = false;
                SpA.Visible = false;
                SpD.Visible = false;
                Spe.Visible = false;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            //  Hide some columns based on output type
            if (generator.FrameType == FrameType.HGSSBred)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = false;
                Time.Visible = false;
                Shiny.Visible = false;
                Nature.Visible = false;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = true;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            //  Hide some columns based on output type
            if (generator.FrameType == FrameType.WondercardIVs)
            {
                if (generator.EncounterType == EncounterType.Manaphy)
                {
                    PID.Visible = true;
                    Nature.Visible = true;
                }
                else
                {
                    PID.Visible = false;
                    Nature.Visible = false;
                }

                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;

                Time.Visible = false;
                Shiny.Visible = false;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = true;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = false;
                f125.Visible = false;
                f25.Visible = false;
                f75.Visible = false;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.Gen4Normal ||
                generator.FrameType == FrameType.Gen4International)
            {
                //  Hide IV columns
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = false;
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = true;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = false;
                Atk.Visible = false;
                Def.Visible = false;
                SpA.Visible = false;
                SpD.Visible = false;
                Spe.Visible = false;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.Method1)
            {
                //  Show ALL columns
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = true;
                Time.DataPropertyName = "Time";
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = true;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.Method1Reverse ||
                generator.FrameType == FrameType.Method2 ||
                generator.FrameType == FrameType.Method3 ||
                generator.FrameType == FrameType.Method4 ||
                generator.FrameType == FrameType.ColoXD ||
                generator.FrameType == FrameType.Channel)
            {
                //  Show ALL columns
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;

                if (generator.FrameType != FrameType.ColoXD && generator.FrameType != FrameType.Channel)
                {
                    Time.Visible = true;
                    Time.DataPropertyName = "Time";
                }
                else
                {
                    Time.Visible = false;
                }

                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.MethodJ ||
                generator.FrameType == FrameType.ChainedShiny)
            {
                //  Show ALL columns
                Frame.Visible = true;
                Offset.Visible = true;

                EncounterSlot.Visible = generator.EncounterType !=
                                        EncounterType.Stationary;

                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = false;
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;

                if (generator.FrameType == FrameType.ChainedShiny)
                {
                    Offset.Visible = false;
                    EncounterSlot.Visible = false;
                }
            }

            if (generator.FrameType == FrameType.MethodK)
            {
                Frame.Visible = true;
                Offset.Visible = true;
                Elm.Visible = true;
                EncounterSlot.Visible = generator.EncounterType !=
                                        EncounterType.Stationary;

                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = false;
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.MethodH1 ||
                generator.FrameType == FrameType.MethodH2 ||
                generator.FrameType == FrameType.MethodH4)
            {
                Frame.Visible = true;
                Offset.Visible = true;
                EncounterSlot.Visible = true;

                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = true;
                Time.DataPropertyName = "Time";
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = false;
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.Wondercard5thGen ||
                generator.FrameType == FrameType.Wondercard5thGenFixed)
            {
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = false;
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = false;
                Dream.Visible = false;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot64";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = true;
                HiddenPowerPower.Visible = true;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = false;
            }

            if (generator.FrameType == FrameType.BWBred ||
                generator.FrameType == FrameType.BWBredInternational ||
                generator.FrameType == FrameType.BW2Bred ||
                generator.FrameType == FrameType.BW2BredInternational)
            {
                //  Show ALL columns
                Frame.Visible = true;
                Offset.Visible = false;
                EncounterSlot.Visible = false;
                ItemCalc.Visible = false;
                PID.Visible = true;
                Time.Visible = false;
                Shiny.Visible = true;
                Nature.Visible = true;
                Ability.Visible = true;
                Dream.Visible = true;
                Coin.Visible = false;
                Elm.Visible = false;
                Chatot.Visible = true;
                Chatot.DataPropertyName = "Chatot64";
                CaveSpot.Visible = false;

                HP.Visible = true;
                Atk.Visible = true;
                Def.Visible = true;
                SpA.Visible = true;
                SpD.Visible = true;
                Spe.Visible = true;
                HiddenPower.Visible = false;
                HiddenPowerPower.Visible = false;

                f50.Visible = true;
                f125.Visible = true;
                f25.Visible = true;
                f75.Visible = true;

                PossibleShakingSpot.Visible = false;
                MaleOnlySpecies.Visible = true;
            }

            if (generator.FrameType == FrameType.BWBred ||
                generator.FrameType == FrameType.BWBredInternational ||
                generator.FrameType == FrameType.BW2Bred ||
                generator.FrameType == FrameType.BW2BredInternational ||
                generator.FrameType == FrameType.DPPtBred ||
                generator.FrameType == FrameType.HGSSBred ||
                generator.FrameType == FrameType.Bred ||
                generator.FrameType == FrameType.BredSplit ||
                generator.FrameType == FrameType.BredAlternate ||
                generator.FrameType == FrameType.RSBredUpper ||
                generator.FrameType == FrameType.Method5Natures)
            {
                displayParentsInSearchToolStripMenuItem.Enabled = true;

                if (generator.FrameType == FrameType.Method5Natures)
                {
                    displayParentsInSearchToolStripMenuItem.Text = "在计算结果中显示个性";
                    resetParentsToolStripMenuItem.Text = "重置个性";
                }
                else
                {
                    displayParentsInSearchToolStripMenuItem.Text = "在计算结果中显示父母";
                    resetParentsToolStripMenuItem.Text = "重置父母";
                }
            }
            else
            {
                displayParentsInSearchToolStripMenuItem.Enabled = false;
            }

            // update frame number for bw2
            if (offset > 0)
            {
                foreach (Frame frame in frames)
                {
                    frame.Number -= offset;
                }
            }

            //  Bind our returned list of frames to the grid
            dataGridViewValues.DataSource = frames;
        }

        /// <summary>
        ///     Code to allow the RMB to select an item in the grid. We want this for right clicking so we can select and lock a frame at the same time.
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void dataGridViewValues_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hti = dataGridViewValues.HitTest(e.X, e.Y);

                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    if (!((dataGridViewValues.Rows[hti.RowIndex])).Selected)
                    {
                        dataGridViewValues.ClearSelection();

                        (dataGridViewValues.Rows[hti.RowIndex]).Selected = true;
                    }
                }
            }
        }

        private void contextMenuStripGrid_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridViewValues.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
            else
            {
                //  We are going to see what method we are and
                //  disable some items if they are not really
                //  applicable to the method the user currently
                //  has selected.
                var frameType = (FrameType)((ComboBoxItem)comboBoxMethod.SelectedItem).Reference;

                //  We only want the option to calculate Poketch taps 
                //  to be availible when the user have 4th gen breeding
                //  selected as it is not applicable to other methods.
                if (frameType == FrameType.Gen4Normal ||
                    frameType == FrameType.Gen4International)
                {
                    calculatePoketechTapsToolStripMenuItem.Enabled = true;
                }
                else
                {
                    calculatePoketechTapsToolStripMenuItem.Enabled = false;
                }

                //  We only want the option to search elm responses to show
                //  up for Methods 1, K, HGSS Egg IVs, and wondercards.
                if (frameType == FrameType.Method1 ||
                    frameType == FrameType.MethodK ||
                    frameType == FrameType.HGSSBred ||
                    frameType == FrameType.WondercardIVs)
                {
                    searchElmToolStripMenuItem.Enabled = true;
                }
                else
                {
                    searchElmToolStripMenuItem.Enabled = false;
                }

                //  We only want the option to search elm responses to show
                //  up for Methods 1, K, HGSS Egg IVs, and wondercards.
                if (frameType == FrameType.Gen4Normal ||
                    frameType == FrameType.Gen4International)
                {
                    searchCoinFlipsToolStripMenuItem.Enabled = true;
                    searchNaturesToolStripMenuItem.Enabled = true;
                }
                else
                {
                    searchCoinFlipsToolStripMenuItem.Enabled = false;
                    searchNaturesToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void CenterFramesAndSetTarget(uint centerFrames)
        {
            //  Get the currently selected item so we can make sure we have something
            if (dataGridViewValues.SelectedRows[0] != null)
            {
                //  We need to clear all filters because the point of 
                //  this is to have a small list of the thing that are
                //  close by so we can find out where we are.
                ClearAllFilters();

                //  Get the currently selected frame.
                var frame = (Frame)dataGridViewValues.SelectedRows[0].DataBoundItem;

                //  Figure out what our starting frame is going to be 
                //  for the clipping, using the frame number as our
                //  bottom if it is less than the number we actually
                //  want to show.
                uint startingFrame = frame.Number < centerFrames + 1U ? 1U : frame.Number - centerFrames;
                uint selectedIndex = frame.Number < centerFrames + 1U ? frame.Number - 1U : centerFrames;
                uint maxFrames = frame.Number < centerFrames + 1U
                                     ? frame.Number - 1U + centerFrames + 1
                                     : centerFrames * 2 + 1;

                maskedTextBoxStartingFrame.Text = startingFrame.ToString();
                maskedTextBoxMaxFrames.Text = maxFrames.ToString();

                Generate();

                SetTargetFrame((int)selectedIndex);

                dataGridViewValues.FirstDisplayedScrollingRowIndex = (int)selectedIndex;
                dataGridViewValues.Rows[(int)selectedIndex].Selected = true;
            }
        }

        //  This will set up the internal target information and 
        private void SetTargetFrame(int index)
        {
            //  We need a single location to show
            targetFrameIndex = index;

            //  Currently we dont use -1 as the sentenal but we should
            if (targetFrameIndex != -1)
            {
                if (dataGridViewValues.SelectedRows[0] != null)
                {
                    var frame = (Frame)dataGridViewValues.SelectedRows[0].DataBoundItem;

                    labelTargetFrame.Text =
                        frame.Number.ToString();
                }
            }
            else
            {
                labelTargetFrame.Text = "None";
            }
        }

        private void centerTo1SecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(60);
        }

        private void centerTo2SecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(120);
        }

        private void centerTo3SecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(180);
        }

        private void centerTo5SecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(300);
        }

        private void centerTo10SecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(600);
        }

        private void centerTp1MinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterFramesAndSetTarget(3600);
        }

        private void removeCenteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllFilters();

            maskedTextBoxStartingFrame.Text = "";
            maskedTextBoxMaxFrames.Text = "";

            Generate();
        }

        private void lockFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTargetFrame(dataGridViewValues.SelectedRows[0].Index);
        }

        private void jumpFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (targetFrameIndex != -1)
            {
                dataGridViewValues.FirstDisplayedScrollingRowIndex = targetFrameIndex;
                dataGridViewValues.Rows[targetFrameIndex].Selected = true;
            }
        }

        private void calculatePoketechTapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewValues.SelectedRows[0] != null)
            {
                var frame = (Frame)dataGridViewValues.SelectedRows[0].DataBoundItem;

                var pt = new Poketech(frame.Number);
                pt.ShowDialog();
            }
        }

        private void searchElmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  First we need to collect a sequence of elm responses. This will
            //  give us our results in an array where we can easily go and search
            //  through
            var searchElm = new SearchElmV();

            if (searchElm.ShowDialog() == DialogResult.OK)
            {
                int startIndex = 0;

                if (dataGridViewValues.SelectedRows[0] != null)
                {
                    startIndex = dataGridViewValues.SelectedRows[0].Index;
                }

                //  Grab a raw list of the frames, since this is the quick way to
                //  actual search them. Using the grid itself is easier, but slow
                var frames = (List<Frame>)dataGridViewValues.DataSource;

                bool found = true;
                int nextFrame = 0;

                //  Iterate through, looking for a set of matches, need
                //  to figure out the base way to do this one cleanly.
                for (int cnt = startIndex; cnt <= frames.Count - 10; cnt++)
                {
                    found = true;

                    for (int searchCnt = 0; searchCnt <= 9; searchCnt++)
                    {
                        if (frames[cnt + searchCnt].Elm != searchElm.ReturnArray[searchCnt])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        nextFrame = cnt + 10;

                        //  We need to cheat if we are the absolute last
                        //  item found, as we cant highlight the one after                       
                        if (nextFrame >= frames.Count)
                            nextFrame = frames.Count - 1;

                        break;
                    }
                }

                if (found)
                {
                    dataGridViewValues.FirstDisplayedScrollingRowIndex = nextFrame;
                    dataGridViewValues.Rows[nextFrame].Selected = true;
                }
                else
                {
                    MessageBox.Show("输入的响应序列未找到匹配项。", "未找到匹配项",
                                    MessageBoxButtons.OK);
                }
            }
        }

        private void searchCoinFlipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchFips = new SearchFlips();

            if (searchFips.ShowDialog() == DialogResult.OK)
            {
                int startIndex = 0;

                if (dataGridViewValues.SelectedRows[0] != null)
                {
                    startIndex = dataGridViewValues.SelectedRows[0].Index;
                }

                //  Grab a raw list of the frames, since this is the quick way to
                //  actual search them. Using the grid itself is easier, but slow
                var frames = (List<Frame>)dataGridViewValues.DataSource;

                bool found = true;
                int nextFrame = 0;

                //  Iterate through, looking for a set of matches, need
                //  to figure out the base way to do this one cleanly.
                for (int cnt = startIndex; cnt <= frames.Count - 10; cnt++)
                {
                    found = true;

                    for (int searchCnt = 0; searchCnt <= 9; searchCnt++)
                    {
                        if (frames[cnt + searchCnt].Coin.Substring(0, 1) != searchFips.ReturnArray[searchCnt])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        nextFrame = cnt + 10;

                        //  We need to cheat if we are the absolute last
                        //  item found, as we cant highlight the one after                       
                        if (nextFrame >= frames.Count)
                            nextFrame = frames.Count - 1;

                        break;
                    }
                }

                if (found)
                {
                    dataGridViewValues.FirstDisplayedScrollingRowIndex = nextFrame;
                    dataGridViewValues.Rows[nextFrame].Selected = true;
                }
                else
                {
                    MessageBox.Show("输入的响应序列未找到匹配项。", "未找到匹配项",
                                    MessageBoxButtons.OK);
                }
            }
        }

        private void searchNaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchNature = new SearchNature();

            if (searchNature.ShowDialog() == DialogResult.OK)
            {
                int startIndex = 0;

                if (dataGridViewValues.SelectedRows[0] != null)
                {
                    startIndex = dataGridViewValues.SelectedRows[0].Index;
                }

                //  Grab a raw list of the frames, since this is the quick way to
                //  actual search them. Using the grid itself is easier, but slow
                var frames = (List<Frame>)dataGridViewValues.DataSource;

                bool found = true;
                int nextFrame = 0;

                //  Iterate through, looking for a set of matches, need
                //  to figure out the base way to do this one cleanly.
                for (int cnt = startIndex; cnt <= frames.Count - 3; cnt++)
                {
                    found = true;

                    for (int searchCnt = 0; searchCnt <= 2; searchCnt++)
                    {
                        if (frames[cnt + searchCnt].Nature != searchNature.ReturnArray[searchCnt])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        nextFrame = cnt + 3;

                        //  We need to cheat if we are the absolute last
                        //  item found, as we cant highlight the one after                       
                        if (nextFrame >= frames.Count)
                            nextFrame = frames.Count - 1;

                        break;
                    }
                }

                if (found)
                {
                    dataGridViewValues.FirstDisplayedScrollingRowIndex = nextFrame;
                    dataGridViewValues.Rows[nextFrame].Selected = true;
                }
                else
                {
                    MessageBox.Show("输入的响应序列未找到匹配项。", "未找到匹配项",
                                    MessageBoxButtons.OK);
                }
            }
        }

        private void outputResultsToTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Going to need to present the user with a File Dialog and 
            //  then interate through the Grid, outputting columns that
            //  are visible.

            saveFileDialogTxt.AddExtension = true;
            saveFileDialogTxt.Title = "Save Output to TXT";
            saveFileDialogTxt.Filter = "TXT Files|*.txt";
            saveFileDialogTxt.FileName = "rngreporter.txt";
            if (saveFileDialogTxt.ShowDialog() == DialogResult.OK)
            {
                //  Get the name of the file and then go ahead 
                //  and create and save the thing to the hard
                //  drive.   
                var frames = (List<Frame>)dataGridViewValues.DataSource;

                if (frames.Count > 0)
                {
                    var writer = new TXTWriter(dataGridViewValues);
                    writer.Generate(saveFileDialogTxt.FileName, frames);
                }
            }
        }

        private void buttonFindTime_Click(object sender, EventArgs e)
        {
            var btnSender = (Button)sender;
            var ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStripTimeFinder.Show(ptLowerLeft);
        }

        private void buttonFindTime5thGen_Click(object sender, EventArgs e)
        {
            if (timeFinder5th == null)
            {
                ushort.TryParse(maskedTextBoxID.Text, out ushort id);
                ushort.TryParse(maskedTextBoxSID.Text, out ushort sid);

                timeFinder5th = new TimeFinder5th(maskedTextBoxID, maskedTextBoxSID);
            }

            timeFinder5th.Show();
            timeFinder5th.RefreshParameters();
            timeFinder5th.Focus();
            timeFinder5th.BringToFront();
        }

        private void buttonFindTime4thGen_Click(object sender, EventArgs e)
        {
            if (timeFinder4th == null)
            {
                ushort.TryParse(maskedTextBoxID.Text, out ushort id);
                ushort.TryParse(maskedTextBoxSID.Text, out ushort sid);

                timeFinder4th = new TimeFinder4th(id, sid);
            }

            timeFinder4th.Show();
            timeFinder4th.Focus();
            timeFinder4th.BringToFront();
        }

        private void buttonFindTime3rdGen_Click(object sender, EventArgs e)
        {
            if (timeFinder3rd == null)
            {
                ushort.TryParse(maskedTextBoxID.Text, out ushort id);
                ushort.TryParse(maskedTextBoxSID.Text, out ushort sid);

                timeFinder3rd = new TimeFinder3rd(id, sid);
            }

            timeFinder3rd.Show();
            timeFinder3rd.Focus();
            timeFinder3rd.BringToFront();
        }

        private void buttonFindTimeGameCube_Click(object sender, EventArgs e)
        {
            if (timeFinderGameCube == null)
            {
                int.TryParse(maskedTextBoxID.Text, out int id);
                int.TryParse(maskedTextBoxSID.Text, out int sid);

                timeFinderGameCube = new GameCube(id, sid);
            }

            timeFinderGameCube.Show();
            timeFinderGameCube.Focus();
            timeFinderGameCube.BringToFront();
        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] encounterMenu;
            string previousEncounter = "野生宝可梦";
            if (comboBoxEncounterType.SelectedItem != null)
                previousEncounter = comboBoxEncounterType.SelectedItem.ToString();

            if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodK))
            {
                encounterMenu = new[]
                    {
                        "野生宝可梦",
                        "野生宝可梦（冲浪）",
                        "野生宝可梦（破旧钓竿）",
                        "野生宝可梦（好钓竿）",
                        "野生宝可梦（厉害钓竿）",
                        "定点宝可梦",
                        "捕虫大赛",
                        "狩猎地带",
                        "头锤树"
                    };

                comboBoxEncounterType.DataSource = encounterMenu;
            }
            else if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH1) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH2) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH4) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodJ))
            {
                encounterMenu = new[]
                    {
                        "野生宝可梦",
                        "野生宝可梦（冲浪）",
                        "野生宝可梦（破旧钓竿）",
                        "野生宝可梦（好钓竿）",
                        "野生宝可梦（厉害钓竿）",
                        "定点宝可梦",
                        "狩猎地带"
                    };

                comboBoxEncounterType.DataSource = encounterMenu;
            }
            else if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures))
            {
                encounterMenu = new[]
                    {
                        "野生宝可梦",
                        "野生宝可梦（虫之预感）",
                        "野生宝可梦（冲浪）",
                        "野生宝可梦（钓鱼）",
                        "野生宝可梦（摇动草丛）",
                        "野生宝可梦（水纹水面）",
                        "野生宝可梦（卷尘地面）",
                        "定点宝可梦",
                        "游走宝可梦",
                        "礼物宝可梦",
                        "连入之森宝可梦",
                        "燃烧虫的蛋",
                        "隐藏洞穴"
                    };

                comboBoxEncounterType.DataSource = encounterMenu;
            }
            else if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Standard) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5CGear))
            {
                encounterMenu = new[]
                    {
                        "野生宝可梦",
                        "定点宝可梦",
                        "游走宝可梦",
                        "礼物宝可梦"
                    };

                comboBoxEncounterType.DataSource = encounterMenu;
            }
            else if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.WondercardIVs))
            {
                encounterMenu = new[]
                    {
                        "普通神秘卡片",
                        "玛纳霏的蛋"
                    };

                comboBoxEncounterType.DataSource = encounterMenu;
            }
            else
            {
                encounterMenu = new[]
                    {
                        "野生宝可梦"
                    };
            }

            for (int i = 0; i < encounterMenu.Length; i++)
            {
                if (encounterMenu[i] == previousEncounter)
                {
                    comboBoxEncounterType.SelectedIndex = i;
                    break;
                }
            }

            if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBred) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBredInternational))
            {
                currentMod = EncounterMod.Everstone;
                buttonLead.Text = EncounterTypeCalc.StringMod(currentMod);
                buttonLead.FlatStyle = FlatStyle.Flat;
                buttonLead.TextAlign = ContentAlignment.MiddleRight;
                comboBoxSynchNatures.DataSource = Objects.Nature.NatureDropDownCollectionSynch();

                checkBoxDreamWorld.Enabled = true;
                checkBoxDittoParent.Enabled = true;
                cbNidoBeat.Enabled = true;
                cbShinyCharm.Enabled = true;
                comboBoxSynchNatures.Enabled = true;
                buttonLead.Enabled = true;
            }
            else if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH1) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH2) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH4) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodJ) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodK) ||
                     ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures))
            {
                if (currentMod == EncounterMod.Everstone)
                    currentMod = EncounterMod.Synchronize;

                buttonLead.Text = EncounterTypeCalc.StringMod(currentMod);
                buttonLead.FlatStyle = FlatStyle.Standard;
                buttonLead.TextAlign = ContentAlignment.MiddleCenter;
                checkBoxDreamWorld.Enabled = false;
                checkBoxDittoParent.Enabled = false;
                cbNidoBeat.Enabled = false;
                cbShinyCharm.Enabled = false;
                checkBoxDreamWorld.Checked = false;
                checkBoxDittoParent.Checked = false;
                cbNidoBeat.Checked = false;
                cbShinyCharm.Checked = false;
                comboBoxSynchNatures.Enabled = true;
                buttonLead.Enabled = true;
            }
            else
            {
                if (currentMod == EncounterMod.Everstone)
                {
                    currentMod = EncounterMod.Synchronize;
                    buttonLead.Text = EncounterTypeCalc.StringMod(currentMod);
                    buttonLead.FlatStyle = FlatStyle.Standard;
                    buttonLead.TextAlign = ContentAlignment.MiddleCenter;
                }

                checkBoxDreamWorld.Enabled = false;
                checkBoxDittoParent.Enabled = false;
                cbNidoBeat.Enabled = false;
                cbShinyCharm.Enabled = false;
                checkBoxDreamWorld.Checked = false;
                checkBoxDittoParent.Checked = false;
                cbNidoBeat.Checked = false;
                cbShinyCharm.Checked = false;

                comboBoxSynchNatures.Enabled = false;
                buttonLead.Enabled = false;
            }

            if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Standard) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Wondercard5thGen) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Wondercard5thGenFixed) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBred) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBredInternational))
            {
                textBoxSeed.Mask = "AAAAAAAAAAAAAAAA";
                checkBoxBW2.Visible = true;
                checkBoxMemoryLink.Visible = true;
            }
            else
            {
                if (!textBoxSeed.Text.Equals("") && textBoxSeed.Text.Length > 8)
                {
                    textBoxSeed.Text = textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8);
                }
                textBoxSeed.Mask = "AAAAAAAA";
                checkBoxBW2.Visible = false;
                checkBoxMemoryLink.Visible = false;
            }

            if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Wondercard5thGen) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Wondercard5thGenFixed) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBred) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.BWBredInternational))
            {
                buttonCalcInitialFrame.Visible = true;
                checkBoxRoamerReleased.Visible = true;
                labelCalcWarning.Visible = true;
            }
            else
            {
                buttonCalcInitialFrame.Visible = false;
                checkBoxRoamerReleased.Visible = false;
                labelCalcWarning.Visible = false;
            }

            if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Standard) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5CGear) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH1) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH2) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH4) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodJ) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodK) ||
                ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.WondercardIVs))
            {
                comboBoxEncounterType.Enabled = true;
            }
            else
            {
                comboBoxEncounterType.Enabled = false;
            }
        }

        private void buttonRoamerMap_Click(object sender, EventArgs e)
        {
            HgSsRoamerSW.Window.Show();
        }

        private void comboBoxCPUCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.CPUs = comboBoxCPUCount.SelectedIndex + 1;
        }

        private void researcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var researcher = new Researcher();
            researcher.Show();
        }

        private void iVsToPIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ivToPid = new IVtoPID_SID_SEED();

            if (maskedTextBoxID.Text != "")
                ivToPid.Tid = uint.Parse(maskedTextBoxID.Text);

            if (ivToPid.ShowDialog() == DialogResult.OK)
            {
                if (ivToPid.SeedSet)
                {
                    textBoxSeed.Text = ivToPid.ReturnSeed.ToString("X");
                }

                if (ivToPid.SidSet)
                {
                    maskedTextBoxSID.Text = ivToPid.ReturnSid.ToString();
                }
            }
        }

        private void findSIDFromChainedShiniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chainToSID = new ChainToSID();

            if (maskedTextBoxID.Text != "")
                chainToSID.DefaultId = uint.Parse(maskedTextBoxID.Text);

            if (chainToSID.ShowDialog() == DialogResult.OK)
            {
                if (chainToSID.SidSet)
                {
                    maskedTextBoxSID.Text = chainToSID.ReturnSid.ToString();
                }
            }
        }

        private void pokedexIVCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dexIvCheck = new DexIVCheck();

            dexIvCheck.Show();
        }

        private void seedToTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is a bit of a strange hack, because this window
            //  needs to be hidden before we load the seed to time
            //  form or it wont be able to be focused. 
            bool showMap = HgSsRoamerSW.Window.Map.Visible;
            HgSsRoamerSW.Window.Hide();

            var seedToTime = new SeedToTime { AutoGenerate = false, ShowMap = showMap };

            seedToTime.setDPPt();

            seedToTime.Seed = 0;

            if (textBoxSeed.Text != "")
            {
                string seedText = textBoxSeed.Text.Length > 8
                                      ? textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8)
                                      : textBoxSeed.Text;

                seedToTime.Seed = uint.Parse(seedText, NumberStyles.HexNumber);
            }

            //  Grab this from what the user had searched on
            seedToTime.Year = (uint)DateTime.Now.Year;

            seedToTime.Show();
        }

        private void seedToTimeCGearSeedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is a bit of a strange hack, because this window
            //  needs to be hidden before we load the seed to time
            //  form or it wont be able to be focused. 
            bool showMap = HgSsRoamerSW.Window.Map.Visible;
            HgSsRoamerSW.Window.Hide();

            var seedToTime = new SeedToTime { AutoGenerate = false, ShowMap = showMap };

            seedToTime.setBW();

            seedToTime.Seed = 0;

            if (textBoxSeed.Text != "")
            {
                string seedText = textBoxSeed.Text.Length > 8
                                      ? textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8)
                                      : textBoxSeed.Text;

                seedToTime.Seed = uint.Parse(seedText, NumberStyles.HexNumber);
            }

            //  Grab this from what the user had searched on
            seedToTime.Year = (uint)DateTime.Now.Year;

            seedToTime.Show();
        }

        private void tIDSIDManipulationPandorasBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pandora = new Pandora(4);
            pandora.Show();
        }

        private void tIDSIDManipulationPandorasBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pandora = new Pandora(5);
            pandora.Show();
        }

        private void findDSParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wizard = new DSIDWizard();
            wizard.Show();
        }

        private void rubyEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iii/ruby");
        }

        private void sapphireEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iii/sapphire");
        }

        private void emeraldEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iii/emerald");
        }

        private void fireRedEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iii/fire-red");
        }

        private void leafGreenEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iii/leaf-green");
        }

        private void diamondEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iv/diamond");
        }

        private void pearlEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iv/pearl");
        }

        private void platinumEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iv/platinum");
        }

        private void heartGoldEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iv/heartgold");
        }

        private void soulSilverEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-iv/soulsilver");
        }

        private void blackEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-v/black");
        }

        private void whiteEncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-v/white");
        }


        private void black2EncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-v/black-2");
        }

        private void white2EncounterTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://sites.google.com/site/pokemonslots/gen-v/white-2");
        }

        private void findSeedByIVsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var platinumSeed = new SeedFinder(0, 4);

            if (platinumSeed.ShowDialog() == DialogResult.OK)
            {
                textBoxSeed.Text = platinumSeed.ReturnSeed.ToString("X");
            }
        }

        private void findSeedByStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var platinumSeed = new SeedFinder(1, 4);

            if (platinumSeed.ShowDialog() == DialogResult.OK)
            {
                textBoxSeed.Text = platinumSeed.ReturnSeed.ToString("X");
            }
        }

        private void findSeedByIVRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var platinumSeed = new SeedFinder(2, 4);

            if (platinumSeed.ShowDialog() == DialogResult.OK)
            {
                textBoxSeed.Text = platinumSeed.ReturnSeed.ToString("X");
            }
        }

        private void simpleSeedGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var platinumSeed = new SeedFinder(3, 4);

            if (platinumSeed.ShowDialog() == DialogResult.OK)
            {
                textBoxSeed.Text = platinumSeed.ReturnSeed.ToString("X");
            }
        }

        private void simpleSeedGeneratorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var platinumSeed = new SeedFinder(3, 5);

            if (platinumSeed.ShowDialog() == DialogResult.OK)
            {
                textBoxSeed.Text = platinumSeed.ReturnSeed.ToString("X");
            }
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {
            // This is a bit of a strange hack, because this window
            //  needs to be hidden before we load the seed to time
            //  form or it wont be able to be focused. 
            bool showMap = HgSsRoamerSW.Window.Map.Visible;
            HgSsRoamerSW.Window.Hide();

            var seedToTime = new SeedToTime { sekrit = true, AutoGenerate = false, ShowMap = showMap, Seed = 0 };

            if (textBoxSeed.Text != "")
            {
                string seedText = textBoxSeed.Text.Length > 8
                                      ? textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8)
                                      : textBoxSeed.Text;

                seedToTime.Seed = uint.Parse(seedText, NumberStyles.HexNumber);
            }

            //  Grab this from what the user had searched on
            seedToTime.Year = (uint)DateTime.Now.Year;

            seedToTime.ShowDialog();
        }

        private void buttonCalcInitialFrame_Click(object sender, EventArgs e)
        {
            ulong seed = 0;
            if (textBoxSeed.Text != "")
            {
                seed = ulong.Parse(textBoxSeed.Text, NumberStyles.HexNumber);
            }

            int roamerAdvances = checkBoxRoamerReleased.Checked ? 1 : 0;
            Version version = checkBoxBW2.Checked ? Version.White2 : Version.White;
            bool memorylink = checkBoxMemoryLink.Visible && checkBoxMemoryLink.Checked;

            maskedTextBoxStartingFrame.Text =
                (Functions.initialPIDRNG(seed, version, memorylink) + roamerAdvances).ToString();
        }

        private void displayParentsInSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if we want to display A\B parents (3rd-4th gen)
            // or Male\Female parents (5th gen)

            // this is terribly bad form
            // but since there's always an entry up on the datagrid
            // This should not fail
            var frames = (List<Frame>)dataGridViewValues.DataSource;
            FrameType frameType = frames[0].FrameType;
            EncounterType encounterType = frames[0].EncounterType;

            uint seed = 0;

            if (textBoxSeed.Text != "")
            {
                if ((frameType == FrameType.BWBred ||
                     frameType == FrameType.BWBredInternational ||
                     frameType == FrameType.Method5Natures) &&
                    textBoxSeed.Text.Length == 8)
                {
                    MessageBox.Show("这个算法需要你从Time Finder窗口中复制完整的seed");
                    seed = uint.Parse(textBoxSeed.Text, NumberStyles.HexNumber);
                }
                else if (textBoxSeed.Text.Length > 8)
                {
                    seed = uint.Parse(textBoxSeed.Text.Substring(0, textBoxSeed.Text.Length - 8), NumberStyles.HexNumber);
                }
                else
                {
                    seed = uint.Parse(textBoxSeed.Text, NumberStyles.HexNumber);
                }
            }

            var subsearch = new EggParents(frameType, encounterType, seed, checkBoxBW2.Checked);
            subsearch.ShowDialog();

            if (subsearch.DialogResult == DialogResult.OK)
            {
                parentA = subsearch.ParentA;
                parentB = subsearch.ParentB;
                rngIVs = subsearch.RNGIVs;
                completeIVs = subsearch.CompleteIVs;
                rngIVsOnly = subsearch.RNGIVsOnly;

                HP.DataPropertyName = "DisplayHpAlt";
                Atk.DataPropertyName = "DisplayAtkAlt";
                Def.DataPropertyName = "DisplayDefAlt";
                SpA.DataPropertyName = "DisplaySpaAlt";
                SpD.DataPropertyName = "DisplaySpdAlt";
                Spe.DataPropertyName = "DisplaySpeAlt";

                dataGridViewValues.DataSource = frames;
                resetParentsToolStripMenuItem.Visible = true;

                Generate();
            }
        }

        private void resetParentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HP.DataPropertyName = "DisplayHp";
            Atk.DataPropertyName = "DisplayAtk";
            Def.DataPropertyName = "DisplayDef";
            SpA.DataPropertyName = "DisplaySpa";
            SpD.DataPropertyName = "DisplaySpd";
            Spe.DataPropertyName = "DisplaySpe";

            parentA = null;
            parentB = null;
            rngIVs = null;
            completeIVs = false;
            rngIVsOnly = false;

            resetParentsToolStripMenuItem.Visible = false;
            Generate();
        }

        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalToolStripMenuItem.Checked = false;
            hexToolStripMenuItem.Checked = true;
            PID.DefaultCellStyle.Format = "X8";
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalToolStripMenuItem.Checked = true;
            hexToolStripMenuItem.Checked = false;
            PID.DefaultCellStyle.Format = "";
        }

        private void donationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://www.smogon.com/forums/showthread.php?t=83057");
        }

        private void buttonLead_Click(object sender, EventArgs e)
        {
            if (currentMod == EncounterMod.Synchronize)
            {
                currentMod = EncounterMod.CuteCharm;
                comboBoxSynchNatures.DataSource = cuteCharm;
            }
            else if (currentMod == EncounterMod.CuteCharm)
            {
                currentMod = EncounterMod.SuctionCups;
                comboBoxSynchNatures.DataSource = Objects.Nature.NatureDropDownCollectionSynch();
                comboBoxSynchNatures.Enabled = false;
            }
            else if (currentMod == EncounterMod.SuctionCups)
            {
                currentMod = EncounterMod.Synchronize;
                comboBoxSynchNatures.DataSource = Objects.Nature.NatureDropDownCollectionSynch();

                if (((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH1) ||
                    ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH2) ||
                    ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodH4) ||
                    ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodJ) ||
                    ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.MethodK) ||
                    ((ComboBoxItem)comboBoxMethod.SelectedItem).Reference.Equals(FrameType.Method5Natures))
                    comboBoxSynchNatures.Enabled = true;
                else
                    comboBoxSynchNatures.Enabled = false;
            }

            buttonLead.Text = EncounterTypeCalc.StringMod(currentMod);
        }

        //todo: actually look at this return value and parse it correctly
        private bool ChangeLanguage(Language language)
        {
            var CellStyle = new DataGridViewCellStyle();
            switch (language)
            {
                case (Language.Japanese):
                    CellStyle.Font = new Font("Meiryo", 6.75F);
                    if (CellStyle.Font.Name != "Meiryo")
                    {
                        CellStyle.Font = new Font("Arial Unicode MS", 7.75F);
                        if (CellStyle.Font.Name != "Arial Unicode MS")
                        {
                            CellStyle.Font = new Font("MS Mincho", 7.75F);
                            if (CellStyle.Font.Name != "MS Mincho")
                            {
                                MessageBox.Show("Cannot display Japanese without a Japanese-supported font.",
                                                "Unsupported Language", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                                MessageBoxDefaultButton.Button1);
                                return false;
                            }
                        }
                    }

                    Settings.Default.Language = (int)Language.Japanese;
                    clearLanguageChecks();
                    日本語ToolStripMenuItem.Checked = true;
                    break;
                case (Language.German):
                    CellStyle.Font = DefaultFont;

                    Settings.Default.Language = (int)Language.German;
                    clearLanguageChecks();
                    deutschToolStripMenuItem.Checked = true;
                    break;
                case (Language.Spanish):
                    CellStyle.Font = DefaultFont;

                    Settings.Default.Language = (int)Language.Spanish;
                    clearLanguageChecks();
                    españolToolStripMenuItem.Checked = true;
                    break;
                case (Language.French):
                    CellStyle.Font = DefaultFont;

                    Settings.Default.Language = (int)Language.French;
                    clearLanguageChecks();
                    françaisToolStripMenuItem.Checked = true;
                    break;
                case (Language.Italian):
                    CellStyle.Font = DefaultFont;

                    Settings.Default.Language = (int)Language.Italian;
                    clearLanguageChecks();
                    italianoToolStripMenuItem.Checked = true;
                    break;
                case (Language.Korean):
                    CellStyle.Font = new Font("Malgun Gothic", 7.75F);

                    switch (CellStyle.Font.Name)
                    {
                        case "Malgun Gothic":
                            CellStyle.Font = new Font("Malgun Gothic", 7.75F);
                            break;
                        case "Gulim":
                            CellStyle.Font = new Font("Gulim", 8.75F);
                            break;
                        case "Arial Unicode MS":
                            CellStyle.Font = new Font("Arial Unicode MS", 7.75F);
                            break;
                        default:
                            MessageBox.Show("Cannot display Korean without a Korean-supported font.",
                                            "Unsupported Language", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                            MessageBoxDefaultButton.Button1);
                            return false;
                    }

                    Settings.Default.Language = (int)Language.Korean;
                    clearLanguageChecks();
                    한국어ToolStripMenuItem.Checked = true;
                    break;
                case (Language.SimplifiedChinese):
                    // 尝试设置字体为宋体
                    try
                    {
                        CellStyle.Font = new Font("宋体", 8.25F);
                    }
                    catch (ArgumentException) // 如果字体不存在，将抛出 ArgumentException  
                    {
                        // 如果宋体不可用，则尝试Microsoft Sans Serif
                        CellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);

                        if (CellStyle.Font.Name != "Microsoft Sans Serif")
                        {
                            // 如果Microsoft Sans Serif不可用，则尝试微软雅黑
                            CellStyle.Font = new Font("微软雅黑", 8.25F);

                            if (CellStyle.Font.Name != "微软雅黑")
                            {
                                // 如果黑体也不可用，则显示警告  
                                MessageBox.Show("如果没有中文支持的字体，则无法显示中文。",
                                                "不受支持的语言", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                                MessageBoxDefaultButton.Button1);
                                return false;
                            }
                        }
                    }

                    Settings.Default.Language = (int)Language.SimplifiedChinese;
                    clearLanguageChecks();
                    简体中文ToolStripMenuItem.Checked = true;
                    break;
                default:
                    CellStyle.Font = DefaultFont;

                    Settings.Default.Language = (int)Language.English;
                    clearLanguageChecks();
                    englishToolStripMenuItem.Checked = true;
                    break;
            }

            // The SelectedIndex resets if we change DataSource,
            // so we'll need to store old values in order to set them back
            int oldSynchIndex = comboBoxSynchNatures.SelectedIndex;

            Nature.DefaultCellStyle = CellStyle;
            Characteristic.DefaultCellStyle = CellStyle;
            HiddenPower.DefaultCellStyle = CellStyle;
            EncounterSlot.DefaultCellStyle = CellStyle;
            comboBoxNature.Font = CellStyle.Font;
            comboBoxSynchNatures.Font = CellStyle.Font;
            buttonLead.Font = CellStyle.Font;
            buttonLead.Text = EncounterTypeCalc.StringMod(currentMod);
            dataGridViewValues.Refresh();

            for (int checkBoxIndex = 1; checkBoxIndex < comboBoxNature.Items.Count; checkBoxIndex++)
            {
                comboBoxNature.CheckBoxItems[checkBoxIndex].Text =
                    (comboBoxNature.CheckBoxItems[checkBoxIndex].ComboBoxItem).ToString();
                comboBoxNature.CheckBoxItems[checkBoxIndex].Font = CellStyle.Font;
            }

            comboBoxNature.CheckBoxItems[0].Checked = true;
            comboBoxNature.CheckBoxItems[0].Checked = false;

            comboBoxEncounterSlot.CheckBoxItems[13].Font = CellStyle.Font;
            comboBoxEncounterSlot.CheckBoxItems[13].Text = Functions.encounterItems(12);
            comboBoxEncounterSlot.CheckBoxItems[0].Checked = true;
            comboBoxEncounterSlot.CheckBoxItems[0].Checked = false;

            //comboBoxNature.DataSource = RNGReporter.Objects.Nature.NatureDropDownCollection();
            if (comboBoxSynchNatures.DataSource != cuteCharm)
                comboBoxSynchNatures.DataSource = Objects.Nature.NatureDropDownCollectionSynch();

            //comboBoxNature.SelectedIndex = oldNatureIndex;
            comboBoxSynchNatures.SelectedIndex = oldSynchIndex;

            return true;
        }

        private void clearLanguageChecks()
        {
            englishToolStripMenuItem.Checked = false;
            日本語ToolStripMenuItem.Checked = false;
            deutschToolStripMenuItem.Checked = false;
            españolToolStripMenuItem.Checked = false;
            françaisToolStripMenuItem.Checked = false;
            italianoToolStripMenuItem.Checked = false;
            한국어ToolStripMenuItem.Checked = false;
            简体中文ToolStripMenuItem.Checked = false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.English);
        }

        private void 日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.Japanese);
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.German);
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.Spanish);
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.French);
        }

        private void italianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.Italian);
        }

        private void 한국어ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.Korean);
        }

        private void 简体中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Language.SimplifiedChinese);
        }

        private void dataGridViewValues_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Settings.Default.ShowToolTips)
            {
                Rectangle cellRect = dataGridViewValues.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                if (dataGridViewValues.Columns[e.ColumnIndex].Name == "Chatot")
                {
                    toolTipDataGrid.ToolTipTitle = "聒噪鸟音高";

                    toolTipDataGrid.Show("一只聒噪鸟有一个录音后的喋喋不休（不是原本的叫声）则可以用来推进帧数\r\n" +
                                         "每次在这只聒噪鸟的状态面板查看时，听到他发出你的录音（不用听完），则帧数+1。\r\n" +
                                         "每一帧的叫声音高也不同。通过倾听仔细地分辨出音高，才有可能确定当前的帧数\r\n\r\n" +
                                         "\"Low\"表示低音，\"High\"表示高音。这些括号内的数字表示可以听到音高的细微区别，这可能被训练有素的耳朵察觉到\r\n\r\n" +
                                         "L = Low, ML = Mid-Low(中低音), M = Mid(中音), MH = Mid-High(中高音), H = High"
                                         ,
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         8000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].Name == "Nature")
                {
                    toolTipDataGrid.ToolTipTitle = "性格（没搞懂这个什么意思，凑合着看吧）";

                    toolTipDataGrid.Show("加粗黑色的性格说明可以通过同步特性的宝可梦使其同步性格\r\n\r\n" +
                                         "灰色的性格则说明该性格的无同步的默认性格",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].Name == "Shiny")
                {
                    toolTipDataGrid.ToolTipTitle = "异色";

                    toolTipDataGrid.Show("如果该帧的异色列有!!!则说明该帧是异色",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].Name == "Offset")
                {
                    toolTipDataGrid.ToolTipTitle = "偶然值Occidentary";

                    toolTipDataGrid.Show("该值是对战结束后的帧数，宝可梦对战后的帧数等于偶然值+6，该值一般作用于大湿地等场景",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].Name == "EncounterSlot")
                {
                    toolTipDataGrid.ToolTipTitle = "遭遇槽位";

                    toolTipDataGrid.Show("遭遇槽位是用来确定野生战斗中会出现哪种宝可梦。\r\n" +
                                         "请使用菜单下的遭遇表来查找每个区域每个槽位会出现哪种宝可梦",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].HeaderText == "卷尘地面")
                {
                    toolTipDataGrid.ToolTipTitle = "可能的卷尘地面";

                    toolTipDataGrid.Show("每走20步，游戏就会检查当前帧是否会在洞穴中生成一个卷尘地面。\r\n" +
                                         "加载游戏时，此步数计数器将返回到其最后保存的状态",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].HeaderText == "水纹水面")
                {
                    toolTipDataGrid.ToolTipTitle = "可能的水纹水面";

                    toolTipDataGrid.Show("每走20步，游戏就会检查当前帧是否会在附近的水中产生气泡。\r\n" +
                                         "加载游戏时，此步数计数器将返回到其最后保存的状态",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].HeaderText == "摇动草丛")
                {
                    toolTipDataGrid.ToolTipTitle = "可能的摇动草丛";

                    toolTipDataGrid.Show("每走20步，游戏会检查当前帧是否会生成一个摇动草丛。\r\n" +
                                         "加载游戏时，此步数计数器将返回到其最后保存的状态",
                                         this,
                                         dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                                         dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                                         5000);
                }
                else if (dataGridViewValues.Columns[e.ColumnIndex].DataPropertyName == "EntralinkTime")
                {
                    toolTipDataGrid.ToolTipTitle = "连入之森时间";

                    toolTipDataGrid.Show(
                        "开启C-Gear会随着时间的推移推进PIDRNG。此列列出了从开启C装置的那一刻起，针对连\r\n" +
                        "装置的那一刻起，针对连入之森宝可梦，为了达到特定性格所需的最短时间。\r\n\r\n" +
                        "在连入之森中随机移动的宝可梦会影响此列表的准确性，因此必须将所有其他宝可梦移\r\n" +
                        "至Deep Clearing以最大限度地减少它们的影响。如果C装置是在继续屏幕上开启的，而不\r\n" +
                        "是在游戏内，那么这个列表也将不准确。\r\n\r\n" +
                        "如果没有其他进展（如来自聒噪鸟或随机移动的宝可梦的进展），则标记为“跳过”的帧将被跳过。",
                        this,
                        dataGridViewValues.Location.X + cellRect.X + cellRect.Size.Width,
                        dataGridViewValues.Location.Y + cellRect.Y + cellRect.Size.Height,
                        8000);
                }
                else if (e.ColumnIndex >= 0)
                {
                    toolTipDataGrid.Hide(this);
                }
            }
        }

        private void dataGridViewValues_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            toolTipDataGrid.Hide(this);
        }

        private void showToolTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.ShowToolTips = showToolTipsToolStripMenuItem.Checked;
        }

        private void adjacentSeedToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adjacentTool = new Adjacents();
            adjacentTool.Show();
        }

        private void buttonAnySlot_Click(object sender, EventArgs e)
        {
            comboBoxEncounterSlot.ClearSelection();
        }

        private void entralinkSeedSearchToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var seedEntreeSearch = new EntralinkSeedSearch();
            seedEntreeSearch.Show();
        }

        private void FocusControl(object sender, MouseEventArgs e)
        {
            ((Control)sender).Focus();
        }

        private void profilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Profiles.ProfileManager.Visible)
                Profiles.ProfileManager.Show();
        }

        private void tIDSIDManipulationPandorasBoxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var pandora = new Pandora(3);
            pandora.Show();
        }

        private void unovaLinkParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unovalink = new UnovaLinkCalibration();
            unovalink.Show();
        }

        private void hiddenGrottoEncounterTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://sites.google.com/site/pokemonslots/gen-v/hidden-grottos");
        }

        #region Filter Button Routines

        private void buttonAnyNature_Click(object sender, EventArgs e)
        {
            comboBoxNature.ClearSelection();
        }

        private void ClearAllFilters()
        {
            comboBoxNature.SelectedIndex = 0;
            checkBoxShinyOnly.Checked = false;
        }

        #endregion

        private void bitSeedToTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var thirdSeedtoTime = new thirdGenSeedToTime();
            thirdSeedtoTime.Show();
        }

        private void gameCubeRTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameCubeRTC = new GameCubeRTC();
            gameCubeRTC.Show();
        }

        private void jirachiGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jirachi = new JirachiGeneration();
            jirachi.Show();
        }

        private void pIDToIVsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pidToIVs == null)
                pidToIVs = new PIDToIVs(this);
            pidToIVs.Show();
            pidToIVs.BringToFront();
        }

        private void pokespotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(maskedTextBoxID.Text, out int id);
            int.TryParse(maskedTextBoxSID.Text, out int sid);

            var pokespot = new PokeSpot(id, sid);
            pokespot.Show();
        }

        public void changeSeed(String seed)
        {
            textBoxSeed.Text = seed;
        }

        public void changeIVs(String[] ivs)
        {
            ivFilters.changeIVs(ivs);
        }

        public void changeType(int type)
        {
            comboBoxMethod.SelectedIndex = type;
        }

        private void iVsToFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ivsToFrame = new IVstoFrame();
            ivsToFrame.Show();
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewValues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ivFilters_Load(object sender, EventArgs e)
        {

        }
    }
}
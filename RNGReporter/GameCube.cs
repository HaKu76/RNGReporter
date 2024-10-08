﻿using RNGReporter.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static RNGReporter.Objects.NatureLock;

namespace RNGReporter
{
    public partial class GameCube : Form
    {
        private readonly String[] Natures = { "勤奋", "怕寂寞", "勇敢", "固执", "顽皮", "大胆", "坦率", "悠闲", "淘气", "乐天", "胆小", "急躁", "认真", "爽朗", "天真", "内敛", "慢吞吞", "冷静", "害羞", "马虎", "温和", "温顺", "自大", "慎重", "浮躁" };
        private readonly String[] hiddenPowers = { "格斗", "飞行", "毒", "地面", "岩石", "虫", "幽灵", "钢", "火", "水", "草", "电", "超能", "冰", "龙", "恶" };
        private Thread[] searchThread;
        private BindingSource binding, bindingShadow;
        private List<DisplayList> displayList;
        private List<ShadowDisplay> shadowDisplay;
        private bool isSearching, shinyLock;
        private uint searchNumber, genderFilter, abilityFilter, k1, k2 = 0xc64e6d00;
        private ShadowType shadow;
        private NatureLock natureLock = new NatureLock(0);
        private List<uint> natureList, hiddenPowerList;
        private uint[] ivsLower, ivsUpper, shinyval;
        private byte[] low8 = new byte[0x10000];
        private bool[] flags = new bool[0x10000];
        private int natureLockIndex, cores;

        public GameCube(int TID, int SID)
        {
            InitializeComponent();
            id.Text = TID.ToString();
            sid.Text = SID.ToString();
            Reason.Visible = false;
            displayList = new List<DisplayList>();
            shadowDisplay = new List<ShadowDisplay>();
            binding = new BindingSource { DataSource = displayList };
            bindingShadow = new BindingSource { DataSource = shadowDisplay };
            abilityType.SelectedIndex = 0;
            genderType.SelectedIndex = 0;
            searchMethod.SelectedIndex = 0;
            shadowPokemon.DataSource = galeShadows();
            comboBoxShadow.DataSource = coloShadows();
            comboBoxGame.SelectedIndex = 0;
            shadowPokemon.SelectedIndex = 0;
            comboBoxShadow.SelectedIndex = 0;
            comboBoxMethodShadow.SelectedIndex = 0;
            comboBoxAbilityShadow.SelectedIndex = 0;
            comboBoxGenderShadow.SelectedIndex = 0;
            hpLogic.SelectedIndex = 0;
            atkLogic.SelectedIndex = 0;
            defLogic.SelectedIndex = 0;
            spaLogic.SelectedIndex = 0;
            spdLogic.SelectedIndex = 0;
            speLogic.SelectedIndex = 0;
            hpLogicShadow.SelectedIndex = 0;
            atkLogicShadow.SelectedIndex = 0;
            defLogicShadow.SelectedIndex = 0;
            spaLogicShadow.SelectedIndex = 0;
            spdLogicShadow.SelectedIndex = 0;
            speLogicShadow.SelectedIndex = 0;
            dataGridViewResult.DataSource = binding;
            dataGridViewResult.AutoGenerateColumns = false;
            dataGridShadow.DataSource = bindingShadow;
            dataGridShadow.AutoGenerateColumns = false;
            shinyval = new uint[8];
            cores = Environment.ProcessorCount;
            while (cores != 1 && cores != 2 && cores != 4 && cores != 8)
                cores--;

            for (uint i = 0; i < 256; i++)
            {
                uint right = 0x41c64e6d * i + 0x6073;
                ushort val = (ushort)(right >> 16);
                flags[val] = true;
                low8[val] = (byte)i;
                --val;
                flags[val] = true;
                low8[val] = (byte)i;
            }
        }

        private void GameCube_Load(object sender, EventArgs e)
        {
            comboBoxNature.Items.AddRange(Nature.NatureDropDownCollectionSearchNatures());
            comboBoxHiddenPower.Items.AddRange(addHP());
            checkBoxNatureShadow.Items.AddRange(Nature.NatureDropDownCollectionSearchNatures());
            checkBoxHPShadow.Items.AddRange(addHP());
            setComboBox();
            wshMkr.Visible = true;
            shadowPokemon.Visible = false;
            shadowCheck.Visible = false;
        }

        private void GameCube_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (searchThread != null)
            {
                for (int x = 0; x < searchThread.Length; x++)
                    searchThread[x].Abort();
                status.Text = "取消了 -等待操作...";
            }
            Hide();
        }

        #region Spread Searcher
        #region Start search
        private void search_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                status.Text = "上一个计算仍在运行";
                return;
            }

            getIVs(out ivsLower, out ivsUpper);
            shinyLock = false;

            if (ivsLower[0] > ivsUpper[0])
                MessageBox.Show("HP: Lower limit > Upper limit");
            else if (ivsLower[1] > ivsUpper[1])
                MessageBox.Show("Atk: Lower limit > Upper limit");
            else if (ivsLower[2] > ivsUpper[2])
                MessageBox.Show("Def: Lower limit > Upper limit");
            else if (ivsLower[3] > ivsUpper[3])
                MessageBox.Show("SpA: Lower limit > Upper limit");
            else if (ivsLower[4] > ivsUpper[4])
                MessageBox.Show("SpD: Lower limit > Upper limit");
            else if (ivsLower[5] > ivsUpper[5])
                MessageBox.Show("Spe: Lower limit > Upper limit");
            else
            {
                natureList = null;
                if (comboBoxNature.Text != "任意" && comboBoxNature.CheckBoxItems.Count > 0)
                    natureList = (from t in comboBoxNature.CheckBoxItems where t.Checked select (uint)((Nature)t.ComboBoxItem).Number).ToList();

                hiddenPowerList = null;
                List<uint> temp = new List<uint>();
                if (comboBoxHiddenPower.Text != "任意" && comboBoxHiddenPower.CheckBoxItems.Count > 0)
                    for (int x = 1; x <= 16; x++)
                        if (comboBoxHiddenPower.CheckBoxItems[x].Checked)
                            temp.Add((uint)(x - 1));

                if (temp.Count != 0)
                    hiddenPowerList = temp;

                abilityFilter = (uint)abilityType.SelectedIndex;
                genderFilter = (uint)genderType.SelectedIndex;

                displayList.Clear();
                binding.ResetBindings(false);
                status.Text = "计算中";
                isSearching = true;
                try
                {
                    shinyval[0] = (uint.Parse(id.Text) ^ uint.Parse(sid.Text)) >> 3;
                }
                catch
                {
                    shinyval[0] = 0;
                }
                searchNumber = (uint)searchMethod.SelectedIndex;

                dataGridViewResult.Columns[17].Visible = shadowCheck.Checked && ((searchMethod.SelectedIndex == 1 && shadowPokemon.SelectedIndex != 17) || (searchMethod.SelectedIndex == 2 && shadowPokemon.SelectedIndex != 0));

                getSearch();
            }
        }

        private void getSearch()
        {
            if (searchNumber == 0)
            {
                if (wshMkr.Checked)
                {
                    searchThread = new Thread[1];
                    searchThread[0] = new Thread(() => generateWishmkr());
                    searchThread[0].Start();
                }
                else
                    getRMethod();
            }
            else if (searchNumber == 1)
            {
                if (shadowCheck.Checked)
                    getGalesShadowMethod();
                else
                    getGalesColoMethod();
            }
            else if (searchNumber == 2)
            {
                if (shadowCheck.Checked)
                    getColoShadowMethod();
                else
                    getGalesColoMethod();
            }
            else
                getChannelMethod();
        }
        #endregion

        #region Gales Shadow Search
        private void getGalesShadowMethod()
        {
            natureLockIndex = shadowPokemon.SelectedIndex;
            shinyLock = shadowPokemon.SelectedIndex != 17;
            natureLock.changeLockGales(natureLockIndex);
            shadow = natureLock.getType();

            searchThread = new Thread[1];
            searchThread[0] = new Thread(() => generateGalesShadow());
            searchThread[0].Start();
            var update = new Thread(updateGUI);
            update.Priority = ThreadPriority.Lowest;
            update.Start();
        }

        private void generateGalesShadow()
        {
            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                    checkSeedGales(a, b, c, d, e, f);
            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private void checkSeedGales(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            long first = (hp | (atk << 5) | (def << 10)) << 16;
            long second = (spe | (spa << 5) | (spd << 10)) << 16;
            uint fullFirst;
            XdRng rng = new XdRng(0);

            long t = ((second - 0x343fd * first) - 0x259ec4) % 0x80000000;
            t = t < 0 ? t + 0x80000000 : t;
            long kmax = (0x343fabc02 - t) / 0x80000000;
            long test = t;

            uint pid1, pid2, pid, nature, seed, antipid, antiNature;
            long k;
            bool pass, antiPass;

            for (k = 0; k <= kmax; k++, test += 0x80000000)
            {
                if ((test % 0x343fd) < 0x10000)
                {
                    fullFirst = (uint)(first | (test / 0x343fd));
                    pid1 = fullFirst * 0x45C82BE5 + 0xD2F65B55; // Advances prng 3 times
                    pid2 = forwardXD(pid1);
                    pid = (pid1 & 0xFFFF0000) | (pid2 >> 16);
                    shinyval[7] = ((pid1 >> 16) ^ (pid2 >> 16)) >> 3;
                    nature = pid % 25;
                    seed = reverseXD(fullFirst);
                    pass = (natureList == null || natureList.Contains(nature));

                    antipid = getAntiPID(pid1, pid2);
                    antiNature = antipid % 25;
                    antiPass = (natureList == null || natureList.Contains(antiNature));

                    bool setPass = false, unsetPass = false, skipPass = false, nlPass = false;
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 1)
                        {
                            seed ^= 0x80000000;
                            pid ^= 0x80008000;
                            nature = pid % 25;
                            antipid ^= 0x80008000;
                            antiNature = antipid % 25;
                            pass = (natureList == null || natureList.Contains(nature));
                            antiPass = (natureList == null || natureList.Contains(antiNature));
                        }

                        switch (shadow)
                        {
                            case ShadowType.Eevee:
                                if (pass)
                                {
                                    uint tid = reverseXD(reverseXD(seed));
                                    uint sid = reverseXD(tid);
                                    shinyval[0] = ((tid >> 16) ^ (sid >> 16)) >> 3;
                                    filterSeedEevee(hp, atk, def, spa, spd, spe, pid, nature, seed);
                                }
                                break;
                            case ShadowType.NoLock:
                                if (pass)
                                    filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 0, false);
                                if (antiPass)
                                    filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 0, true);
                                break;
                            case ShadowType.FirstShadow:
                                if (!nlPass && natureLock.firstShadow(seed))
                                {
                                    nlPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 0, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 0, true);
                                }
                                break;
                            case ShadowType.SingleLock:
                                if (!nlPass && natureLock.singleNL(seed))
                                {
                                    nlPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 0, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 0, true);
                                }
                                break;
                            case ShadowType.Salamence:
                                if (!setPass && natureLock.salamenceSet(seed))
                                {
                                    setPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 1, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 1, true);
                                }
                                else if (!unsetPass && natureLock.salamenceUnset(seed))
                                {
                                    unsetPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 2, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 2, true);
                                }
                                else if (!skipPass && natureLock.salamenceShinySkip(seed))
                                {
                                    skipPass = true;
                                    filterShinySkip(hp, atk, def, spa, spd, spe, pid, nature, seed, antipid, antiNature);
                                }
                                break;
                            case ShadowType.SecondShadow:
                                if (!setPass && natureLock.secondShadowSet(seed))
                                {
                                    setPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 1, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 1, true);
                                }
                                else if (!unsetPass && natureLock.secondShadowUnset(seed))
                                {
                                    unsetPass = true;
                                    if (pass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, pid, nature, seed, 2, false);
                                    if (antiPass)
                                        filterSeedGales(hp, atk, def, spa, spd, spe, antipid, antiNature, seed, 2, true);
                                }
                                else if (!skipPass && natureLock.secondShadowShinySkip(seed))
                                {
                                    skipPass = true;
                                    filterShinySkip(hp, atk, def, spa, spd, spe, pid, nature, seed, antipid, antiNature);
                                }
                                break;
                        }
                    }
                }
            }
        }

        private uint getAntiPID(uint pid1, uint pid2)
        {
            uint anti1, anti2;

            anti1 = forwardXD(pid2);
            anti2 = forwardXD(anti1);

            while ((((anti1 >> 16) ^ (anti2 >> 16)) >> 3) == (((pid1 >> 16) ^ (pid2 >> 16)) >> 3))
            {
                pid1 = anti1;
                pid2 = anti2;
                anti1 = forwardXD(pid2);
                anti2 = forwardXD(anti1);
            }

            return (anti1 & 0xFFFF0000) | (anti2 >> 16);
        }

        private void filterSeedGales(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint pid, uint nature, uint seed, int num, bool anti)
        {
            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }

            String reason = "";
            if (num == 0)
                reason = anti ? "Pass NL (Anti-Shiny)" : "Pass NL";
            else if (num == 1)
                reason = anti ? "1st shadow set (Anti-Shiny)" : "1st shadow set";
            else
                reason = anti ? "1st shadow unset (Anti-Shiny)" : "1st shadow unset";
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, "", seed, reason, 0);
        }

        private void filterShinySkip(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint pid, uint nature, uint seed, uint antipid, uint antinature)
        {
            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            var reverse = new XdRngR(seed);
            reverse.GetNext32BitNumber();
            uint tsv = (reverse.GetNext16BitNumber() ^ reverse.GetNext16BitNumber()) >> 3;
            uint tsvtemp = (reverse.GetNext16BitNumber() ^ reverse.GetNext16BitNumber()) >> 3;
            while (tsv == tsvtemp)
            {
                tsv = tsvtemp;
                tsvtemp = (reverse.GetNext16BitNumber() ^ reverse.GetNext16BitNumber()) >> 3;
            }
            String reason = "Shiny skip (TSV: " + tsvtemp + ")";
            if (tsvtemp == shinyval[7])
            {
                reason += " (Anti-Shiny)";
                pid = antipid;
                nature = antinature;
            }

            if (natureList != null && !natureList.Contains(nature))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, "", seed, reason, 0);
        }

        private void filterSeedEevee(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint pid, uint nature, uint seed)
        {
            String shiny = "";
            if (Shiny_Check.Checked)
            {
                if (!isShiny(pid, 0))
                    return;
                shiny = "!!!";
            }

            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, shiny, seed, "", 0);
        }
        #endregion

        #region Colo Shadow Search
        private void getColoShadowMethod()
        {
            natureLockIndex = shadowPokemon.SelectedIndex;
            shinyLock = shadowPokemon.SelectedIndex != 0;
            natureLock.changeLockColo(natureLockIndex);
            shadow = natureLock.getType();

            searchThread = new Thread[1];
            searchThread[0] = new Thread(() => generateColoShadow());
            searchThread[0].Start();
            var update = new Thread(updateGUI);
            update.Priority = ThreadPriority.Lowest;
            update.Start();
        }

        private void generateColoShadow()
        {
            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                    checkSeedColo(a, b, c, d, e, f);
            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private void checkSeedColo(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            long first = (hp | (atk << 5) | (def << 10)) << 16;
            long second = (spe | (spa << 5) | (spd << 10)) << 16;
            uint fullFirst;

            long t = ((second - 0x343fd * first) - 0x259ec4) % 0x80000000;
            t = t < 0 ? t + 0x80000000 : t;
            long kmax = (0x343fabc02 - t) / 0x80000000;
            long test = t;

            uint pid1, pid2, pid, nature, seed, xorSeed, xorPID, xorNature;
            long k;
            bool pass, xorPass;

            for (k = 0; k <= kmax; k++, test += 0x80000000)
            {
                if ((test % 0x343fd) < 0x10000)
                {
                    fullFirst = (uint)(first | (test / 0x343fd));
                    pid1 = pid1 = fullFirst * 0x45C82BE5 + 0xD2F65B55; // Advances prng 3 times
                    pid2 = forwardXD(pid1);
                    pid = (pid1 & 0xFFFF0000) | (pid2 >> 16);
                    nature = pid % 25;
                    seed = reverseXD(fullFirst);
                    pass = (natureList == null || natureList.Contains(nature));

                    xorSeed = seed ^ 0x80000000;
                    xorPID = pid ^ 0x80008000;
                    xorNature = xorPID % 25;
                    xorPass = (natureList == null || natureList.Contains(xorNature));

                    if (pass && natureLock.firstShadow(seed))
                        filterSeedColo(hp, atk, def, spa, spd, spe, pid, nature, seed, 0);
                    else if (xorPass && natureLock.firstShadow(xorSeed))
                        filterSeedColo(hp, atk, def, spa, spd, spe, xorPID, xorNature, xorSeed, 0);
                }
            }
        }

        private void filterSeedColo(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint pid, uint nature, uint seed, int num)
        {
            String shiny = "";
            if (Shiny_Check.Checked)
            {
                if (!isShiny(pid, 0))
                    return;
                shiny = "!!!";
            }

            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, shiny, seed, "Pass NL", 0);
        }
        #endregion

        #region Gales/Colo search
        private void getGalesColoMethod()
        {
            searchThread = new Thread[1];
            searchThread[0] = new Thread(() => generateGalesColo());
            searchThread[0].Start();
            var update = new Thread(updateGUI);
            update.Priority = ThreadPriority.Lowest;
            update.Start();
        }

        private void generateGalesColo()
        {
            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                    checkSeed(a, b, c, d, e, f);

            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private void checkSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            uint first = (hp | (atk << 5) | (def << 10)) << 16;
            uint second = (spe | (spa << 5) | (spd << 10)) << 16;
            uint fullFirst;

            uint t = ((second - 0x343fd * first) - 0x259ec4);
            uint kmax = (uint)((0x343fabc02 - t) / 0x80000000);
            long test = t;

            uint pid, pid1, pid2, nature, seed;

            for (uint k = 0; k <= kmax; k++, test += 0x80000000)
            {
                if ((test % 0x343fd) < 0x10000)
                {
                    fullFirst = (uint)(first | (test / 0x343fd));
                    pid1 = fullFirst * 0x45C82BE5 + 0xD2F65B55; // Advances prng 3 times
                    pid2 = forwardXD(pid1);
                    pid = (pid1 & 0xFFFF0000) | (pid2 >> 16);
                    nature = pid % 25;
                    seed = reverseXD(fullFirst);
                    if (natureList == null || natureList.Contains(nature))
                        filterSeed(hp, atk, def, spa, spd, spe, pid, nature, seed);

                    pid ^= 0x80008000;
                    nature = pid % 25;
                    if (natureList == null || natureList.Contains(nature))
                        filterSeed(hp, atk, def, spa, spd, spe, pid, nature, seed ^ 0x80000000);
                }
            }
        }

        private void filterSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint pid, uint nature, uint seed)
        {
            String shiny = "";
            if (Shiny_Check.Checked)
            {
                if (!isShiny(pid, 0))
                    return;
                shiny = "!!!";
            }

            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, shiny, seed, "", 0);
        }
        #endregion

        #region Channel

        private void getChannelMethod()
        {
            uint method = 1;

            for (int x = 0; x < 6; x++)
            {
                uint temp = ivsUpper[x] - ivsLower[x] + 1;
                method *= temp;
            }

            switch (cores)
            {
                case 1:
                    if (method > 964)
                    {
                        searchThread = new Thread[1];
                        searchThread[0] = new Thread(() => generateChannel2(0, 64, 0));
                        searchThread[0].Start();
                    }
                    else
                    {
                        searchThread = new Thread[1];
                        searchThread[0] = new Thread(() => generateChannel());
                        searchThread[0].Start();
                    }
                    break;
                case 2:
                    if (method > 492)
                    {
                        searchThread = new Thread[2];
                        for (int i = 0; i < 1; i++)
                        {
                            searchThread[i] = new Thread(() => generateChannel2((uint)i * 0x40000000, 32, i));
                            searchThread[i].Start();
                            Thread.Sleep(200);
                        }
                    }
                    else
                    {
                        searchThread = new Thread[1];
                        searchThread[0] = new Thread(() => generateChannel());
                        searchThread[0].Start();
                    }
                    break;
                case 4:
                    if (method > 266)
                    {
                        searchThread = new Thread[4];
                        for (int i = 0; i < 4; i++)
                        {
                            searchThread[i] = new Thread(() => generateChannel2((uint)i * 0x20000000, 16, i));
                            searchThread[i].Start();
                            Thread.Sleep(200);
                        }
                    }
                    else
                    {
                        searchThread = new Thread[1];
                        searchThread[0] = new Thread(() => generateChannel());
                        searchThread[0].Start();
                    }
                    break;
                case 8:
                    if (method > 225)
                    {
                        searchThread = new Thread[8];
                        for (int i = 0; i < 8; i++)
                        {
                            searchThread[i] = new Thread(() => generateChannel2((uint)i * 0x10000000, 8, i));
                            searchThread[i].Start();
                            Thread.Sleep(200);
                        }
                    }
                    else
                    {
                        searchThread = new Thread[1];
                        searchThread[0] = new Thread(() => generateChannel());
                        searchThread[0].Start();
                    }
                    break;
            }
            var update = new Thread(updateGUI);
            update.Priority = ThreadPriority.Lowest;
            update.Start();
        }

        #region Search 1
        private void generateChannel()
        {
            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                    checkSeedChannel(a, b, c, d, e, f);

            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private void checkSeedChannel(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            uint first = hp << 27;

            uint test = (((spd << 27) - (0x284A930D * first)) - 0x9A974C78);
            uint kmax = (uint)((0x142549847b56cf2 - test) / 0x100000000);
            long t = test;

            var rng = new XdRngR(0);
            uint temp, pid2, pid1, pid, sid, nature;

            for (uint k = 0; k <= kmax; k++, t += 0x100000000)
            {
                if ((t % 0x284A930D) >= 0x8000000)
                    continue;

                rng.Seed = first | (uint)(t / 0x284A930D);
                temp = forwardXD(rng.Seed);
                if (temp >> 27 != atk)
                    continue;

                temp = forwardXD(temp);
                if (temp >> 27 != def)
                    continue;

                temp = forwardXD(temp);
                if (temp >> 27 != spe)
                    continue;

                temp = forwardXD(temp);
                if (temp >> 27 != spa)
                    continue;

                rng.GetNext32BitNumber(3);
                pid2 = rng.GetNext16BitNumber();
                pid1 = rng.GetNext16BitNumber();
                sid = rng.GetNext16BitNumber();
                pid = (pid1 << 16) | pid2;
                if ((pid2 > 7 ? 0 : 1) != (pid1 ^ sid ^ 40122))
                    pid ^= 0x80000000;
                nature = pid % 25;
                if (natureList == null || natureList.Contains(nature))
                {
                    shinyval[0] = (40122 ^ (sid)) >> 3;
                    filterSeedChannel(hp, atk, def, spa, spd, spe, rng.GetNext32BitNumber(), pid, nature, 0);
                }
            }
        }
        #endregion

        #region Search 2
        private void generateChannel2(uint seed, uint num1, int shinyIndex)
        {
            uint[] seedShort = new uint[13];
            uint[] seedLong = new uint[13];
            seedShort[0] = seed >> 16;
            seedLong[0] = seed;
            var rng = new XdRng(seed);

            for (int i = 0; i < 12; i++)
            {
                seedShort[i] = rng.GetNext16BitNumber();
                seedLong[i] = rng.GetNext32BitNumber();
            }

            uint pid, pid1, pid2, nature, sid;
            uint[] ivs;
            int j = 12;

            for (uint z = 0; z < 32; z++)
            {
                for (uint h = 0; h < num1; h++)
                {
                    for (uint n = 0; n < 1048576; n++, seedShort[j] = rng.GetNext16BitNumber(), seedLong[j] = rng.Seed)
                    {
                        j = ++j % 13;

                        pid1 = seedShort[j >= 11 ? j - 11 : j + 2];
                        pid2 = seedShort[j >= 10 ? j - 10 : j + 3];
                        pid = (pid1 << 16) | pid2;
                        sid = seedShort[j >= 12 ? j - 12 : j + 1];
                        if ((pid2 > 7 ? 0 : 1) != (pid1 ^ sid ^ 40122))
                            pid ^= 0x80000000;
                        nature = pid % 25;

                        if (natureList == null || natureList.Contains(nature))
                        {

                            ivs = createIVsChannel(new uint[] { seedShort[j >= 6 ? j - 6 : j + 7] >> 11,
                                                            seedShort[j >= 5 ? j - 5 : j + 8] >> 11,
                                                            seedShort[j >= 4 ? j - 4 : j + 9] >> 11,
                                                            seedShort[j >= 2 ? j - 2 : j + 11] >> 11,
                                                            seedShort[j >= 1 ? j - 1 : j + 12] >> 11,
                                                            seedShort[j >= 3 ? j - 3 : j + 10] >> 11 });
                            if (ivs != null)
                            {
                                shinyval[shinyIndex] = (40122 ^ sid) >> 3;
                                filterSeedChannel(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], seedLong[j], pid, nature, shinyIndex);
                            }
                        }

                        pid ^= 0x80008000;
                        nature = pid % 25;

                        if (natureList == null || natureList.Contains(nature))
                        {
                            ivs = createIVsChannel(new uint[] { (seedShort[j >= 6 ? j - 6 : j + 7] ^ 0x8000) >> 11,
                                                            (seedShort[j >= 5 ? j - 5 : j + 8] ^ 0x8000) >> 11,
                                                            (seedShort[j >= 4 ? j - 4 : j + 9] ^ 0x8000) >> 11,
                                                            (seedShort[j >= 2 ? j - 2 : j + 11] ^ 0x8000) >> 11,
                                                            (seedShort[j >= 1 ? j - 1 : j + 12] ^ 0x8000) >> 11,
                                                            (seedShort[j >= 3 ? j - 3 : j + 10] ^ 0x8000) >> 11 });
                            if (ivs != null)
                            {
                                shinyval[shinyIndex] = (40122 ^ (sid ^ 0x8000)) >> 3;
                                filterSeedChannel(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], seedLong[j] ^ 0x80000000, pid, nature, shinyIndex);
                            }
                        }
                    }
                }
            }
            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private uint[] createIVsChannel(uint[] iv)
        {
            for (int x = 0; x < 6; x++)
                if (iv[x] < ivsLower[x] || iv[x] > ivsUpper[x])
                    return null;
            return iv;
        }

        private void filterSeedChannel(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint seed, uint pid, uint nature, int shinyIndex)
        {
            String shiny = "";
            if (Shiny_Check.Checked)
            {
                if (!isShiny(pid, shinyIndex))
                    return;
                shiny = "!!!";
            }

            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null && !hiddenPowerList.Contains(actualHP))
                return;

            uint ability = pid & 1;
            if (abilityFilter != 0 && (ability != (abilityFilter - 1)))
                return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeed(hp, atk, def, spa, spd, spe, nature, ability, gender, actualHP, pid, shiny, seed, "", shinyIndex);
        }
        #endregion
        #endregion

        #region Reverse Method 1
        private void getRMethod()
        {
            searchThread = new Thread[1];
            searchThread[0] = new Thread(() => generateR());
            searchThread[0].Start();
            var update = new Thread(updateGUI);
            update.Priority = ThreadPriority.Lowest;
            update.Start();
        }

        private void generateR()
        {
            for (uint a = ivsLower[0]; a <= ivsUpper[0]; a++)
                for (uint b = ivsLower[1]; b <= ivsUpper[1]; b++)
                    for (uint c = ivsLower[2]; c <= ivsUpper[2]; c++)
                        for (uint d = ivsLower[3]; d <= ivsUpper[3]; d++)
                            for (uint e = ivsLower[4]; e <= ivsUpper[4]; e++)
                                for (uint f = ivsLower[5]; f <= ivsUpper[5]; f++)
                                    checkSeedR(a, b, c, d, e, f);

            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        private void checkSeedR(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            uint first = (hp | (atk << 5) | (def << 10)) << 16;
            uint second = (spe | (spa << 5) | (spd << 10)) << 16;
            checkSeedR(hp, atk, def, spa, spd, spe, first, second);
            checkSeedR(hp, atk, def, spa, spd, spe, first ^ 0x80000000, second);
        }

        private void checkSeedR(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint first, uint second)
        {
            k1 = second - first * 0x41c64e6d;
            for (uint cnt = 0; cnt < 256; ++cnt, k1 -= k2)
            {
                uint test = k1 >> 16;
                if (flags[test])
                {
                    uint fullFirst = (first | (cnt << 8) | low8[test]);
                    if ((forward(fullFirst) & 0x7FFF0000) == second)
                    {
                        uint pid2 = reverse(fullFirst);
                        uint pid1 = reverse(pid2);
                        uint pid = (pid1 & 0xFFFF0000) | (pid2 >> 16);
                        uint nature = pid % 25;
                        uint seed = reverse(pid1);
                        if (natureList == null || natureList.Contains(nature))
                            filterSeed(hp, atk, def, spa, spd, spe, pid, nature, seed);

                        pid ^= 0x80008000;
                        nature = pid % 25;
                        if (natureList == null || natureList.Contains(nature))
                            filterSeed(hp, atk, def, spa, spd, spe, pid, nature, seed ^ 0x80000000);
                    }
                }
            }
        }
        #endregion

        #region Wishmkr
        private void generateWishmkr()
        {
            shinyval[0] = 2505;
            for (uint x = 0; x <= 0xFFFF; x++)
            {
                uint pid1 = forward(x);
                uint pid2 = forward(pid1);
                uint pid = (pid1 & 0xFFFF0000) | (pid2 >> 16);
                uint nature = pid % 25;

                if (natureList == null || natureList.Contains(nature))
                {
                    uint ivs1 = forward(pid2);
                    uint ivs2 = forward(ivs1);
                    ivs1 >>= 16;
                    ivs2 >>= 16;
                    uint[] ivs = createIVs(ivs1, ivs2);
                    if (ivs != null)
                        filterSeed(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], pid, nature, x);
                }
            }
            isSearching = false;
            Invoke(new Action(() => { binding.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }
        #endregion

        private void addSeed(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, uint nature, uint ability, uint gender, uint hP, uint pid, String shiny, uint seed, String output, int shinyIndex)
        {
            displayList.Insert(0, new DisplayList
            {
                Seed = seed.ToString("X"),
                PID = pid.ToString("X"),
                Shiny = !shinyLock ? shiny == "" ? isShiny(pid, shinyIndex) ? "!!!" : "" : shiny : shiny,
                Nature = Natures[nature],
                Ability = ability,
                Hp = hp,
                Atk = atk,
                Def = def,
                SpA = spa,
                SpD = spd,
                Spe = spe,
                Hidden = hiddenPowers[hP],
                Power = calcHPPower(hp, atk, def, spa, spd, spe),
                Eighth = gender < 31 ? 'F' : 'M',
                Quarter = gender < 64 ? 'F' : 'M',
                Half = gender < 126 ? 'F' : 'M',
                Three_Fourths = gender < 191 ? 'F' : 'M',
                Reason = output
            });
        }
        #endregion

        #region Shadow Checker

        private void generateShadow_Click(object sender, EventArgs e)
        {
            getIVsShadow(out ivsLower, out ivsUpper);
            if (ivsLower[0] > ivsUpper[0])
                MessageBox.Show("HP: Lower limit > Upper limit");
            else if (ivsLower[1] > ivsUpper[1])
                MessageBox.Show("Atk: Lower limit > Upper limit");
            else if (ivsLower[2] > ivsUpper[2])
                MessageBox.Show("Def: Lower limit > Upper limit");
            else if (ivsLower[3] > ivsUpper[3])
                MessageBox.Show("SpA: Lower limit > Upper limit");
            else if (ivsLower[4] > ivsUpper[4])
                MessageBox.Show("SpD: Lower limit > Upper limit");
            else if (ivsLower[5] > ivsUpper[5])
                MessageBox.Show("Spe: Lower limit > Upper limit");
            else
            {
                if (isSearching)
                {
                    status.Text = "上一个计算仍在运行";
                    return;
                }

                natureList = null;
                if (checkBoxNatureShadow.Text != "任意" && checkBoxNatureShadow.CheckBoxItems.Count > 0)
                    natureList = (from t in checkBoxNatureShadow.CheckBoxItems where t.Checked select (uint)((Nature)t.ComboBoxItem).Number).ToList();

                hiddenPowerList = null;
                List<uint> temp = new List<uint>();
                if (checkBoxHPShadow.Text != "任意" && checkBoxHPShadow.CheckBoxItems.Count > 0)
                    for (int x = 1; x <= 16; x++)
                        if (checkBoxHPShadow.CheckBoxItems[x].Checked)
                            temp.Add((uint)(x - 1));

                if (temp.Count != 0)
                    hiddenPowerList = temp;

                uint.TryParse(maskedTextBoxStartingFrame.Text, out uint initialFrame);
                uint.TryParse(maskedTextBoxMaxFrames.Text, out uint maxFrame);
                uint.TryParse(textBoxSeed.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint seed);
                int shadowMethod = comboBoxMethodShadow.SelectedIndex;
                genderFilter = (uint)comboBoxGenderShadow.SelectedIndex;
                abilityFilter = (uint)comboBoxAbilityShadow.SelectedIndex;
                if (comboBoxGame.SelectedIndex == 0)
                    natureLock.changeLockGales(comboBoxShadow.SelectedIndex);
                else
                    natureLock.changeLockColo(comboBoxShadow.SelectedIndex);
                shadow = natureLock.getType();

                shadowDisplay.Clear();
                bindingShadow.ResetBindings(false);
                isSearching = true;
                status.Text = "计算中";

                searchThread = new Thread[1];
                searchThread[0] = new Thread(() => shadowSearch(initialFrame, maxFrame, seed, shadowMethod));
                searchThread[0].Start();
            }
        }

        private void shadowSearch(uint initialFrame, uint maxFrame, uint inSeed, int secondMethod)
        {
            var rng = new XdRng(inSeed);
            rng.GetNext32BitNumber(initialFrame == 0 ? 0 : (int)initialFrame - 1);

            uint pid, iv1, iv2, nature;
            uint[] ivs;

            switch (shadow)
            {
                case ShadowType.NoLock:

                    uint[] rand = new uint[6];
                    rand[0] = rng.Seed >> 16;

                    for (int x = 1; x < 6; x++)
                        rand[x] = rng.GetNext16BitNumber();

                    int j = 5;

                    for (uint cnt = 0; cnt < maxFrame; cnt++, rand[j] = rng.GetNext16BitNumber())
                    {
                        if (++j > 5)
                            j = 0;

                        pid = (rand[j >= 2 ? j - 2 : j + 4] << 16) | rand[j >= 1 ? j - 1 : j + 5];
                        nature = pid % 25;
                        if (natureList == null || natureList.Contains(nature))
                        {
                            ivs = createIVs(rand[j >= 5 ? j - 5 : j + 1], rand[j >= 4 ? j - 4 : j + 2]);
                            if (ivs != null)
                                filterSeedShadow(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], (int)(initialFrame + cnt), nature, pid);
                        }
                    }

                    break;
                case ShadowType.SingleLock:
                case ShadowType.FirstShadow:
                    natureLock.rand.Add(rng.Seed);
                    for (uint x = 0; x < 2999; x++)
                        natureLock.rand.Add(rng.GetNext32BitNumber());

                    for (uint cnt = 0; cnt < maxFrame; cnt++, natureLock.rand.RemoveAt(0), natureLock.rand.Add(rng.GetNext32BitNumber()))
                    {
                        natureLock.shadowCheckerFirstShadow(out pid, out iv1, out iv2);

                        nature = pid % 25;
                        if (natureList == null || natureList.Contains(nature))
                        {
                            ivs = createIVs(iv1, iv2);
                            if (ivs != null)
                                filterSeedShadow(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], (int)(cnt + initialFrame), nature, pid);
                        }
                    }
                    break;
                case ShadowType.Salamence:
                case ShadowType.SecondShadow:
                    switch (secondMethod)
                    {
                        //Set
                        case 0:
                            natureLock.rand.Add(rng.Seed);
                            for (int x = 0; x < 2999; x++)
                                natureLock.rand.Add(rng.GetNext32BitNumber());

                            for (uint cnt = 0; cnt < maxFrame; cnt++, natureLock.rand.RemoveAt(0), natureLock.rand.Add(rng.GetNext32BitNumber()))
                            {
                                natureLock.shadowCheckerSecondShadowSet(out pid, out iv1, out iv2);

                                nature = pid % 25;
                                if (natureList == null || natureList.Contains(nature))
                                {
                                    ivs = createIVs(iv1, iv2);
                                    if (ivs != null)
                                        filterSeedShadow(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], (int)(cnt + initialFrame), nature, pid);
                                }
                            }
                            break;
                        //Unset
                        case 1:
                            natureLock.rand.Add(rng.Seed);
                            for (int x = 0; x < 2999; x++)
                                natureLock.rand.Add(rng.GetNext32BitNumber());

                            for (uint cnt = 0; cnt < maxFrame; cnt++, natureLock.rand.RemoveAt(0), natureLock.rand.Add(rng.GetNext32BitNumber()))
                            {
                                natureLock.shadowCheckerSecondShadowUnset(out pid, out iv1, out iv2);

                                nature = pid % 25;
                                if (natureList == null || natureList.Contains(nature))
                                {
                                    ivs = createIVs(iv1, iv2);
                                    if (ivs != null)
                                        filterSeedShadow(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], (int)(cnt + initialFrame), nature, pid);
                                }
                            }
                            break;
                        //Shiny skip
                        case 2:
                            natureLock.rand.Add(rng.Seed);
                            for (int x = 0; x < 2999; x++)
                                natureLock.rand.Add(rng.GetNext32BitNumber());

                            for (uint cnt = 0; cnt < maxFrame; cnt++, natureLock.rand.RemoveAt(0), natureLock.rand.Add(rng.GetNext32BitNumber()))
                            {
                                natureLock.shadowCheckerSecondShinySkip(out pid, out iv1, out iv2);

                                nature = pid % 25;
                                if (natureList == null || natureList.Contains(nature))
                                {
                                    ivs = createIVs(iv1, iv2);
                                    if (ivs != null)
                                        filterSeedShadow(ivs[0], ivs[1], ivs[2], ivs[3], ivs[4], ivs[5], (int)(cnt + initialFrame), nature, pid);
                                }
                            }
                            break;
                    }
                    break;
            }
            natureLock.rand.Clear();
            isSearching = false;
            Invoke(new Action(() => { bindingShadow.ResetBindings(false); }));
            status.Invoke((MethodInvoker)(() => status.Text = "完成了 -等待操作..."));
        }

        public void filterSeedShadow(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, int frame, uint nature, uint pid)
        {
            uint actualHP = calcHP(hp, atk, def, spa, spd, spe);
            if (hiddenPowerList != null)
                if (!hiddenPowerList.Contains(actualHP))
                    return;

            uint ability = pid & 1;
            if (abilityFilter != 0)
                if (ability != (abilityFilter - 1))
                    return;

            uint gender = pid & 255;
            switch (genderFilter)
            {
                case 1:
                    if (gender < 127)
                        return;
                    break;
                case 2:
                    if (gender > 126)
                        return;
                    break;
                case 3:
                    if (gender < 191)
                        return;
                    break;
                case 4:
                    if (gender > 190)
                        return;
                    break;
                case 5:
                    if (gender < 64)
                        return;
                    break;
                case 6:
                    if (gender > 63)
                        return;
                    break;
                case 7:
                    if (gender < 31)
                        return;
                    break;
                case 8:
                    if (gender > 30)
                        return;
                    break;
            }
            addSeedShadow(hp, atk, def, spa, spd, spe, frame, nature, ability, gender, actualHP, pid);
        }

        private void addSeedShadow(uint hp, uint atk, uint def, uint spa, uint spd, uint spe, int frame, uint nature, uint ability, uint gender, uint hP, uint pid)
        {
            shadowDisplay.Add(new ShadowDisplay
            {
                Frame = frame,
                PID = pid.ToString("X"),
                Nature = Natures[nature],
                Ability = ability,
                Hp = hp,
                Atk = atk,
                Def = def,
                SpA = spa,
                SpD = spd,
                Spe = spe,
                Hidden = hiddenPowers[hP],
                Power = calcHPPower(hp, atk, def, spa, spd, spe),
                Eighth = gender < 31 ? 'F' : 'M',
                Quarter = gender < 64 ? 'F' : 'M',
                Half = gender < 126 ? 'F' : 'M',
                Three_Fourths = gender < 191 ? 'F' : 'M'
            });
        }

        #endregion

        #region Helper methods
        private void updateGUI()
        {
            try
            {
                while (isSearching)
                {
                    Invoke(new Action(() => { binding.ResetBindings(false); }));
                    Thread.Sleep(2000);
                }
            }
            finally
            {
                Invoke(new Action(() => { binding.ResetBindings(false); }));
            }
        }

        private void getIVs(out uint[] IVsLower, out uint[] IVsUpper)
        {
            IVsLower = new uint[6];
            IVsUpper = new uint[6];
            uint[] ivs = new uint[6];

            uint.TryParse(hpValue.Text, out ivs[0]);
            uint.TryParse(atkValue.Text, out ivs[1]);
            uint.TryParse(defValue.Text, out ivs[2]);
            uint.TryParse(spaValue.Text, out ivs[3]);
            uint.TryParse(spdValue.Text, out ivs[4]);
            uint.TryParse(speValue.Text, out ivs[5]);

            int[] ivsLogic = { hpLogic.SelectedIndex, atkLogic.SelectedIndex, defLogic.SelectedIndex, spaLogic.SelectedIndex, spdLogic.SelectedIndex, speLogic.SelectedIndex };

            for (int x = 0; x < 6; x++)
            {
                if (ivsLogic[x] == 0)
                {
                    IVsLower[x] = ivs[x];
                    IVsUpper[x] = ivs[x];
                }
                else if (ivsLogic[x] == 1)
                {
                    IVsLower[x] = ivs[x];
                    IVsUpper[x] = 31;
                }
                else
                {
                    IVsLower[x] = 0;
                    IVsUpper[x] = ivs[x];
                }
            }
        }

        private void getIVsShadow(out uint[] IVsLower, out uint[] IVsUpper)
        {
            IVsLower = new uint[6];
            IVsUpper = new uint[6];
            uint[] ivs = new uint[6];

            uint.TryParse(hpShadow.Text, out ivs[0]);
            uint.TryParse(atkShadow.Text, out ivs[1]);
            uint.TryParse(defShadow.Text, out ivs[2]);
            uint.TryParse(spaShadow.Text, out ivs[3]);
            uint.TryParse(spdShadow.Text, out ivs[4]);
            uint.TryParse(speShadow.Text, out ivs[5]);

            int[] ivsLogic = { hpLogicShadow.SelectedIndex, atkLogicShadow.SelectedIndex, defLogicShadow.SelectedIndex, spaLogicShadow.SelectedIndex, spdLogicShadow.SelectedIndex, speLogicShadow.SelectedIndex };

            for (int x = 0; x < 6; x++)
            {
                if (ivsLogic[x] == 0)
                {
                    IVsLower[x] = 0;
                    IVsUpper[x] = 31;
                }
                else if (ivsLogic[x] == 1)
                {
                    IVsLower[x] = ivs[x];
                    IVsUpper[x] = ivs[x];
                }
                else if (ivsLogic[x] == 2)
                {
                    IVsLower[x] = ivs[x];
                    IVsUpper[x] = 31;
                }
                else
                {
                    IVsLower[x] = 0;
                    IVsUpper[x] = ivs[x];
                }
            }
        }

        private uint[] createIVs(uint iv1, uint ivs2)
        {
            uint[] ivs = new uint[6];

            for (int x = 0; x < 3; x++)
            {
                int q = x * 5;
                uint iv = (iv1 >> q) & 31;
                if (iv >= ivsLower[x] && iv <= ivsUpper[x])
                    ivs[x] = iv;
                else
                    return null;
            }

            uint iV = (ivs2 >> 5) & 31;
            if (iV >= ivsLower[3] && iV <= ivsUpper[3])
                ivs[3] = iV;
            else
                return null;

            iV = (ivs2 >> 10) & 31;
            if (iV >= ivsLower[4] && iV <= ivsUpper[4])
                ivs[4] = iV;
            else
                return null;

            iV = ivs2 & 31;
            if (iV >= ivsLower[5] && iV <= ivsUpper[5])
                ivs[5] = iV;
            else
                return null;

            return ivs;
        }

        private uint forwardXD(uint seed) => seed * 0x343FD + 0x269EC3;

        private uint reverseXD(uint seed) => seed * 0xB9B33155 + 0xA170F641;

        private uint forward(uint seed) => seed * 0x41c64e6d + 0x6073;

        private uint reverse(uint seed) => seed * 0xeeb9eb65 + 0xa3561a1;

        private int calcHPPower(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            return (int)(30 + ((((hp >> 1) & 1) + 2 * ((atk >> 1) & 1) + 4 * ((def >> 1) & 1) + 8 * ((spe >> 1) & 1) + 16 * ((spa >> 1) & 1) + 32 * ((spd >> 1) & 1)) * 40 / 63));
        }

        private bool isShiny(uint PID, int shinyIndex)
        {
            return (((PID >> 16) ^ (PID & 0xffff)) >> 3) == shinyval[shinyIndex];
        }

        private uint calcHP(uint hp, uint atk, uint def, uint spa, uint spd, uint spe)
        {
            return ((((hp & 1) + 2 * (atk & 1) + 4 * (def & 1) + 8 * (spe & 1) + 16 * (spa & 1) + 32 * (spd & 1)) * 15) / 63);
        }
        #endregion

        #region Quick search settings

        private void hpClear_Click(object sender, EventArgs e)
        {
            hpValue.Text = "0";
            hpLogic.SelectedIndex = 1;
        }

        private void atkClear_Click(object sender, EventArgs e)
        {
            atkValue.Text = "0";
            atkLogic.SelectedIndex = 1;
        }

        private void defClear_Click(object sender, EventArgs e)
        {
            defValue.Text = "0";
            defLogic.SelectedIndex = 1;
        }

        private void spaClear_Click(object sender, EventArgs e)
        {
            spaValue.Text = "0";
            spaLogic.SelectedIndex = 1;
        }

        private void spdClear_Click(object sender, EventArgs e)
        {
            spdValue.Text = "0";
            spdLogic.SelectedIndex = 1;
        }

        private void speClear_Click(object sender, EventArgs e)
        {
            speValue.Text = "0";
            speLogic.SelectedIndex = 1;
        }

        private void hp31Quick_Click(object sender, EventArgs e)
        {
            hpValue.Text = "31";
            hpLogic.SelectedIndex = 0;
        }

        private void hp30Quick_Click(object sender, EventArgs e)
        {
            hpValue.Text = "30";
            hpLogic.SelectedIndex = 0;
        }

        private void hp30Above_Click(object sender, EventArgs e)
        {
            hpValue.Text = "30";
            hpLogic.SelectedIndex = 1;
        }

        private void atk31Quick_Click(object sender, EventArgs e)
        {
            atkValue.Text = "31";
            atkLogic.SelectedIndex = 0;
        }

        private void atk30Quick_Click(object sender, EventArgs e)
        {
            atkValue.Text = "30";
            atkLogic.SelectedIndex = 0;
        }

        private void atk30Above_Click(object sender, EventArgs e)
        {
            atkValue.Text = "30";
            atkLogic.SelectedIndex = 1;
        }

        private void def31Quick_Click(object sender, EventArgs e)
        {
            defValue.Text = "31";
            defLogic.SelectedIndex = 0;
        }

        private void def30Quick_Click(object sender, EventArgs e)
        {
            defValue.Text = "30";
            defLogic.SelectedIndex = 0;
        }

        private void def30Above_Click(object sender, EventArgs e)
        {
            defValue.Text = "30";
            defLogic.SelectedIndex = 1;
        }

        private void spa31Quick_Click(object sender, EventArgs e)
        {
            spaValue.Text = "31";
            spaLogic.SelectedIndex = 0;
        }

        private void spa30Quick_Click(object sender, EventArgs e)
        {
            spaValue.Text = "30";
            spaLogic.SelectedIndex = 0;
        }

        private void spa30Above_Click(object sender, EventArgs e)
        {
            spaValue.Text = "30";
            spaLogic.SelectedIndex = 1;
        }

        private void spd31Quick_Click(object sender, EventArgs e)
        {
            spdValue.Text = "31";
            spdLogic.SelectedIndex = 0;
        }

        private void spd30Quick_Click(object sender, EventArgs e)
        {
            spdValue.Text = "30";
            spdLogic.SelectedIndex = 0;
        }

        private void spd30Above_Click(object sender, EventArgs e)
        {
            spdValue.Text = "30";
            spdLogic.SelectedIndex = 1;
        }

        private void spe31Quick_Click(object sender, EventArgs e)
        {
            speValue.Text = "31";
            speLogic.SelectedIndex = 0;
        }

        private void spe30Quick_Click(object sender, EventArgs e)
        {
            speValue.Text = "30";
            speLogic.SelectedIndex = 0;
        }

        private void spe30Above_Click(object sender, EventArgs e)
        {
            speValue.Text = "30";
            speLogic.SelectedIndex = 1;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                isSearching = false;
                status.Text = "取消了 -等待操作...";
                for (int x = 0; x < searchThread.Length; x++)
                    searchThread[x].Abort();
                natureLock.rand.Clear();
                binding.ResetBindings(false);
            }
        }

        private void anyNature_Click(object sender, EventArgs e)
        {
            comboBoxNature.ClearSelection();
        }

        private void anyGender_Click(object sender, EventArgs e)
        {
            genderType.SelectedIndex = 0;
        }

        private void anyAbility_Click(object sender, EventArgs e)
        {
            abilityType.SelectedIndex = 0;
        }

        private void anyHiddenPower_Click(object sender, EventArgs e)
        {
            comboBoxHiddenPower.ClearSelection();
        }

        private void hpMaxShadow_Click(object sender, EventArgs e)
        {
            hpShadow.Text = "31";
            hpLogicShadow.SelectedIndex = 1;
        }

        private void hpNearMaxShadow_Click(object sender, EventArgs e)
        {
            hpShadow.Text = "30";
            hpLogicShadow.SelectedIndex = 1;
        }

        private void hpAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            hpShadow.Text = "30";
            hpLogicShadow.SelectedIndex = 2;
        }

        private void hpClearShadow_Click(object sender, EventArgs e)
        {
            hpShadow.Text = "";
            hpLogicShadow.SelectedIndex = 0;
        }

        private void atkMaxShadow_Click(object sender, EventArgs e)
        {
            atkShadow.Text = "31";
            atkLogicShadow.SelectedIndex = 1;
        }

        private void atkNearMaxShadow_Click(object sender, EventArgs e)
        {
            atkShadow.Text = "30";
            atkLogicShadow.SelectedIndex = 1;
        }

        private void atkAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            atkShadow.Text = "30";
            atkLogicShadow.SelectedIndex = 2;
        }

        private void atkClearShadow_Click(object sender, EventArgs e)
        {
            atkShadow.Text = "";
            atkLogicShadow.SelectedIndex = 0;
        }

        private void defMaxShadow_Click(object sender, EventArgs e)
        {
            defShadow.Text = "31";
            defLogicShadow.SelectedIndex = 1;
        }

        private void defNearMaxShadow_Click(object sender, EventArgs e)
        {
            defShadow.Text = "30";
            defLogicShadow.SelectedIndex = 1;
        }

        private void defAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            defShadow.Text = "30";
            defLogicShadow.SelectedIndex = 2;
        }

        private void defClearShadow_Click(object sender, EventArgs e)
        {
            defShadow.Text = "";
            defLogicShadow.SelectedIndex = 0;
        }

        private void spaMaxShadow_Click(object sender, EventArgs e)
        {
            spaShadow.Text = "31";
            spaLogicShadow.SelectedIndex = 1;
        }

        private void spaNearMaxShadow_Click(object sender, EventArgs e)
        {
            spaShadow.Text = "30";
            spaLogicShadow.SelectedIndex = 1;
        }

        private void spaAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            spaShadow.Text = "30";
            spaLogicShadow.SelectedIndex = 2;
        }

        private void spaClearShadow_Click(object sender, EventArgs e)
        {
            spaShadow.Text = "";
            spaLogicShadow.SelectedIndex = 0;
        }

        private void spdMaxShadow_Click(object sender, EventArgs e)
        {
            spdShadow.Text = "31";
            spdLogicShadow.SelectedIndex = 1;
        }

        private void spdNearMaxShadow_Click(object sender, EventArgs e)
        {
            spdShadow.Text = "30";
            spdLogicShadow.SelectedIndex = 1;
        }

        private void spdAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            spdShadow.Text = "30";
            spdLogicShadow.SelectedIndex = 2;
        }

        private void spdClearShadow_Click(object sender, EventArgs e)
        {
            spdShadow.Text = "";
            spdLogicShadow.SelectedIndex = 0;
        }

        private void speMaxShadow_Click(object sender, EventArgs e)
        {
            speShadow.Text = "31";
            speLogicShadow.SelectedIndex = 1;
        }

        private void speNearMaxShadow_Click(object sender, EventArgs e)
        {
            speShadow.Text = "30";
            speLogicShadow.SelectedIndex = 1;
        }

        private void speAlmostMaxShadow_Click(object sender, EventArgs e)
        {
            speShadow.Text = "30";
            speLogicShadow.SelectedIndex = 2;
        }

        private void speClearShadow_Click(object sender, EventArgs e)
        {
            speShadow.Text = "";
            speLogicShadow.SelectedIndex = 0;
        }

        private void anyNatureShadow_Click(object sender, EventArgs e)
        {
            checkBoxNatureShadow.ClearSelection();
        }

        private void anyGenderShadow_Click(object sender, EventArgs e)
        {
            comboBoxGenderShadow.SelectedIndex = 0;
        }

        private void anyAbilityShadow_Click(object sender, EventArgs e)
        {
            comboBoxAbilityShadow.SelectedIndex = 0;
        }

        private void anyHPShadow_Click(object sender, EventArgs e)
        {
            checkBoxHPShadow.ClearSelection();
        }
        #endregion

        #region ComboBox
        private String[] addHP()
        {
            return new String[]
            {
                "格斗",
                "飞行",
                "毒",
                "地面",
                "岩石",
                "虫",
                "幽灵",
                "钢",
                "火",
                "水",
                "草",
                "电",
                "超能",
                "冰",
                "龙",
                "恶"
            };
        }

        private String[] galeShadows()
        {
            return new String[]
            {
                "七夕青鸟",
                "阿柏怪",
                "急冻鸟",
                "天秤偶（镍暗岛）",
                "天秤偶（初始的）",
                "天秤偶（矽铍市）",
                "诅咒娃娃",
                "大针蜂",
                "巴大蝶",
                "利牙鱼",
                "吉利蛋",
                "优雅猫",
                "嘟嘟利",
                "快龙",
                "三地鼠",
                "夜巡灵",
                "电击兽",
                "伊布",
                "椰蛋树",
                "大葱鸭",
                "哥达鸭",
                "臭泥",
                "卡蒂狗",
                "溶食兽（镍暗岛）",
                "溶食兽（初始的）",
                "溶食兽（矽铍市）",
                "快拳郎",
                "飞腿郎",
                "戴鲁比（镍暗岛）",
                "戴鲁比（初始的）",
                "戴鲁比（矽铍市）",
                "引梦貘人",
                "袋兽",
                "拉普拉斯",
                "芭瓢虫",
                "大舌头",
                "洛奇亚",
                "月石",
                "熔岩蜗牛",
                "鸭嘴火兽",
                "三合一磁怪",
                "幕下力士",
                "雷电兽",
                "咩利羊（镍暗岛）",
                "咩利羊（初始的）",
                "咩利羊（矽铍市）",
                "嘎啦嘎啦",
                "大嘴娃",
                "喵喵",
                "火焰鸟",
                "魔墙人偶",
                "天然雀",
                "朝北鼻",
                "呆火驼",
                "派拉斯",
                "比比鸟",
                "榛果球",
                "凯罗斯",
                "蚊香泳士",
                "土狼犬",
                "火暴猴",
                "拉鲁拉丝",
                "烈焰马",
                "拉达",
                "钻角犀兽",
                "毒蔷薇",
                "勾魂眼",
                "暴飞龙",
                "飞天螳螂",
                "橡实果（镍暗岛）",
                "橡实果（初始的）",
                "橡实果（矽铍市）",
                "小海狮",
                "大舌贝",
                "蘑蘑菇",
                "卡比兽",
                "雪童子",
                "太阳岩",
                "烈雀",
                "海豹球（镍暗岛）",
                "海豹球（初始的）",
                "海豹球（矽铍市）",
                "圆丝蛛",
                "宝石海星",
                "大王燕",
                "小山猪",
                "蔓藤怪",
                "肯泰罗",
                "熊宝宝",
                "波克比",
                "摩鲁蛾",
                "霹雳电球",
                "六尾",
                "口呆花",
                "猫鼬斩",
                "闪电鸟"
            };
        }

        private void comboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGame.SelectedIndex == 0)
                comboBoxShadow.DataSource = galeShadows();
            else
                comboBoxShadow.DataSource = coloShadows();
            comboBoxMethodShadow.Visible = comboBoxGame.SelectedIndex == 0;
            label21.Visible = comboBoxGame.SelectedIndex == 0;
        }

        private String[] coloShadows()
        {
            return new String[]
            {
                "天蝎",
                "赫拉克罗斯",
                "幕下力士",
                "黑暗鸦",
                "圈圈熊"
            };
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void spdValue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hpValue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void searchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setComboBox()
        {
            comboBoxNature.CheckBoxItems[0].Checked = true;
            comboBoxNature.CheckBoxItems[0].Checked = false;
            comboBoxHiddenPower.CheckBoxItems[0].Checked = true;
            comboBoxHiddenPower.CheckBoxItems[0].Checked = false;
            checkBoxNatureShadow.CheckBoxItems[0].Checked = true;
            checkBoxNatureShadow.CheckBoxItems[0].Checked = false;
            checkBoxHPShadow.CheckBoxItems[0].Checked = true;
            checkBoxHPShadow.CheckBoxItems[0].Checked = false;
        }

        private void galesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (shadowCheck.Checked)
            {
                if (searchMethod.SelectedIndex == 2)
                    Shiny_Check.Visible = shadowPokemon.SelectedIndex != 0;
                else
                    Shiny_Check.Visible = shadowPokemon.SelectedIndex == 17;
            }
            else
                Shiny_Check.Visible = true;
        }

        private void shadowPokemon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (shadowCheck.Checked)
            {
                if (searchMethod.SelectedIndex == 2)
                    Shiny_Check.Visible = shadowPokemon.SelectedIndex != 0;
                else
                    Shiny_Check.Visible = shadowPokemon.SelectedIndex == 17;
            }

        }

        private void searchMethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int method = searchMethod.SelectedIndex;
            if (method == 0)
            {
                wshMkr.Visible = true;
                Shiny_Check.Visible = true;
                shadowPokemon.Visible = false;
                shadowCheck.Visible = false;
            }
            else if (method == 1)
            {
                wshMkr.Visible = false;
                Shiny_Check.Visible = true;
                if (shadowCheck.Checked && shadowPokemon.SelectedIndex != 17)
                    Shiny_Check.Visible = false;
                shadowPokemon.Visible = true;
                shadowCheck.Visible = true;
                shadowPokemon.DataSource = galeShadows();
            }
            else if (method == 2)
            {
                wshMkr.Visible = false;
                Shiny_Check.Visible = true;
                if (shadowCheck.Checked && shadowPokemon.SelectedIndex != 0)
                    Shiny_Check.Visible = false;
                shadowPokemon.Visible = true;
                shadowCheck.Visible = true;
                shadowPokemon.DataSource = coloShadows();
            }
            else
            {
                wshMkr.Visible = false;
                Shiny_Check.Visible = true;
                shadowPokemon.Visible = false;
                shadowCheck.Visible = false;
            }
        }

        private void comboBoxShadow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxGame.SelectedIndex == 0)
            {
                List<int> secondShadows = new List<int> { 0, 6, 8, 10, 22, 31, 33, 38, 50, 57, 66, 67, 75, 93 };
                if (secondShadows.Contains(comboBoxShadow.SelectedIndex))
                {
                    comboBoxMethodShadow.Visible = true;
                    label21.Visible = true;
                }
                else
                {
                    comboBoxMethodShadow.Visible = false;
                    label21.Visible = false;
                }
            }
        }
        #endregion

        #region Grid commands
        private void contextMenuStripGrid_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridViewResult.SelectedRows.Count == 0)
                e.Cancel = true;
        }

        private void copySeedToClipboard_Click(object sender, EventArgs e)
        {
            if (dataGridViewResult.SelectedRows[0] != null)
            {
                var frame = (DisplayList)dataGridViewResult.SelectedRows[0].DataBoundItem;
                Clipboard.SetText(frame.Seed.ToString());
            }
        }

        private void dataGridViewValues_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hti = dataGridViewResult.HitTest(e.X, e.Y);

                if (hti.Type == DataGridViewHitTestType.Cell)
                {
                    if (!((dataGridViewResult.Rows[hti.RowIndex])).Selected)
                    {
                        dataGridViewResult.ClearSelection();

                        (dataGridViewResult.Rows[hti.RowIndex]).Selected = true;
                    }
                }
            }
        }

        private void outputResultsToTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter file = new System.IO.StreamWriter("rngreporter.txt");
            String result = "Seed\t\t" + "PID\t\t" + "异色\t" + "性格\t" + "特性\t" + "HP\t" + "攻击\t" + "防御\t" + "通过\t" + "特防\t" + "速度\t" + "Hidden\t\t" + "Power\t" + "12.5%F\t" + "25%F\t" + "50%\t" + "75%\t" + "Reason\t\n";
            file.WriteLine(result);
            for (int x = 0; x < displayList.Count; x++)
            {
                String seed = displayList[x].Seed;
                while (seed.Length < 8)
                    seed = "0" + seed;
                String pid = displayList[x].PID;
                while (pid.Length < 8)
                    pid = "0" + pid;
                String temp = "" + seed + "\t" + pid + "\t" + displayList[x].Shiny + "\t" + displayList[x].Nature + "\t" + displayList[x].Ability + "\t" + displayList[x].Hp + "\t" + displayList[x].Atk + "\t" + displayList[x].Def + "\t" + displayList[x].SpA + "\t" + displayList[x].SpD + "\t" + displayList[x].Spe + "\t" + displayList[x].Hidden;
                if (displayList[x].Hidden.Length < 8)
                    temp += "\t";
                temp = temp + "\t" + displayList[x].Power + "\t" + displayList[x].Eighth + "\t" + displayList[x].Quarter + "\t" + displayList[x].Half + "\t" + displayList[x].Three_Fourths + "\t" + displayList[x].Reason + "\n";
                file.WriteLine(temp);
            }
            file.Close();
            MessageBox.Show("计算结果导出到带有RNGReporter.exe的文件夹");
        }

        private void dataGridViewResult_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewResult.DataSource != null && displayList != null && binding != null)
            {
                DataGridViewColumn selectedColumn = dataGridViewResult.Columns[e.ColumnIndex];

                var idisplayListComparer = new IDisplayListComparator
                { CompareType = selectedColumn.DataPropertyName };

                if (selectedColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                    idisplayListComparer.sortOrder = SortOrder.Descending;

                displayList.Sort(idisplayListComparer);

                binding.ResetBindings(false);
                selectedColumn.HeaderCell.SortGlyphDirection = idisplayListComparer.sortOrder;
            }
        }
        #endregion
    }
}
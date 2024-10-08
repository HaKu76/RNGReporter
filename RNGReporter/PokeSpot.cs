﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RNGReporter.Objects
{
    public partial class PokeSpot : Form
    {
        private readonly String[] Natures = { "勤奋", "怕寂寞", "勇敢", "固执", "顽皮", "大胆", "坦率", "悠闲", "淘气", "乐天", "胆小", "急躁", "认真", "爽朗", "天真", "内敛", "慢吞吞", "冷静", "害羞", "马虎", "温和", "温顺", "自大", "慎重", "浮躁" };
        private List<PokeSpotDisplay> displayList;
        private List<uint> natureList;
        private List<String> spotList;
        private uint[] rngList;
        private uint genderFilter, abilityFilter, shinyNum, shinyval, call1, call2, call3;
        private int j;
        private bool shinyCheck;

        public PokeSpot(int TID, int SID)
        {
            InitializeComponent();
            abilityType.SelectedIndex = 0;
            genderType.SelectedIndex = 0;
            id.Text = TID.ToString();
            sid.Text = SID.ToString();
            dataGridViewResult.AutoGenerateColumns = false;
            rngList = new uint[6];
        }

        private void PokeSpot_Load(object sender, EventArgs e)
        {
            comboBoxNature.Items.AddRange(Nature.NatureDropDownCollectionSearchNatures());
            comboBoxSpotType.Items.AddRange(addSpotTypes());
            setComboBox();
        }

        private void setComboBox()
        {
            comboBoxNature.CheckBoxItems[0].Checked = true;
            comboBoxNature.CheckBoxItems[0].Checked = false;
            comboBoxSpotType.CheckBoxItems[0].Checked = true;
            comboBoxSpotType.CheckBoxItems[0].Checked = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            displayList = new List<PokeSpotDisplay>();
            try
            {
                shinyval = (uint.Parse(id.Text) ^ uint.Parse(sid.Text)) >> 3;
            }
            catch
            {
                shinyval = 0;
            }

            uint.TryParse(textBoxSeed.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint seed);
            uint frame = 3000000;
            uint.TryParse(maxFrame.Text, out frame);

            natureList = null;
            if (comboBoxNature.Text != "任意" && comboBoxNature.CheckBoxItems.Count > 0)
                natureList = (from t in comboBoxNature.CheckBoxItems where t.Checked select (uint)((Nature)t.ComboBoxItem).Number).ToList();

            spotList = null;
            List<String> temp = new List<String>();
            if (comboBoxSpotType.Text != "任意" && comboBoxSpotType.CheckBoxItems.Count > 0)
                for (int x = 1; x < 4; x++)
                    if (comboBoxSpotType.CheckBoxItems[x].Checked)
                        temp.Add(comboBoxSpotType.CheckBoxItems[x].Text);

            if (temp.Count != 0)
                spotList = temp;
            else
                spotList = new List<String> { "常见的", "不常见的", "稀有的" };

            genderFilter = (uint)genderType.SelectedIndex;
            abilityFilter = (uint)abilityType.SelectedIndex;
            shinyCheck = Shiny_Check.Checked;

            searchPokeSpot(seed, frame);
            dataGridViewResult.DataSource = displayList;
            dataGridViewResult.AutoResizeColumns();
        }

        private void searchPokeSpot(uint seed, uint frame)
        {
            var rng = new XdRng(seed);
            rngList[0] = seed;

            for (int x = 1; x < 6; x++)
                rngList[x] = rng.GetNext32BitNumber();

            j = 5;

            for (uint x = 1; x <= frame; x++, rngList[j] = rng.GetNext32BitNumber())
            {
                j = ++j % 6;
                filterPokeSpot(x);
            }
        }

        private void filterPokeSpot(uint frame)
        {
            uint pid1 = rngList[j >= 2 ? j - 2 : j + 4] >> 16;
            uint pid2 = rngList[j >= 1 ? j - 1 : j + 5] >> 16;
            uint pid = (pid1 << 16) | pid2;

            uint nature = pid % 25;
            if (natureList != null && !natureList.Contains(nature))
                return;

            shinyNum = (pid1 ^ pid2) >> 3;
            String shiny = "";
            if (shinyCheck)
            {
                if (shinyNum != shinyval)
                    return;
                shiny = "!!!";
            }

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

            calcPokeSpot(pid, frame, nature, gender, ability, shiny);
        }

        private void comboBoxSpotType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void abilityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcPokeSpot(uint pid, uint frame, uint nature, uint gender, uint ability, String shiny)
        {
            call1 = rngList[j >= 5 ? j - 5 : j + 1] >> 16;

            if (call1 % 3 == 0)
            {
                String spotType = "";
                call2 = rngList[j >= 4 ? j - 4 : j + 2] >> 16;

                // Munchlax isn't catchable and provides a frame skip
                if (call2 % 100 < 10)
                    return;

                call3 = (rngList[j >= 3 ? j - 3 : j + 3] >> 16) % 100;
                if (call3 < 50)
                    spotType = "常见的";
                else if (call3 > 49 && call3 < 85)
                    spotType = "不常见的";
                else if (call3 > 84)
                    spotType = "稀有的";

                if (!spotList.Contains(spotType))
                    return;

                displayList.Add(new PokeSpotDisplay
                {
                    Seed = rngList[j].ToString("X"),
                    Frame = (int)frame,
                    PID = pid.ToString("X"),
                    Shiny = shiny == "" ? shinyNum == shinyval ? "!!!" : shiny : shiny,
                    Type = spotType,
                    Nature = Natures[nature],
                    Ability = (int)ability,
                    Eighth = gender < 31 ? '♀' : '♂',
                    Quarter = gender < 64 ? '♀' : '♂',
                    Half = gender < 126 ? '♀' : '♂',
                    Three_Fourths = gender < 191 ? '♀' : '♂'
                });
            }
        }

        private void anyPokeSpot_Click(object sender, EventArgs e)
        {
            comboBoxSpotType.ClearSelection();
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

        private String[] addSpotTypes()
        {
            return new String[]
                {
                    "常见的",
                    "不常见的",
                    "稀有的"
                };
        }
    }
}
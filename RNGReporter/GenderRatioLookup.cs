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


using RNGReporter.Objects;
using RNGReporter.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RNGReporter
{
    public partial class GenderRatioLookup : Form
    {
        private uint genderRatio;
        private BindingSource pokemonList;

        public GenderRatioLookup()
        {
            InitializeComponent();
        }

        public uint GenderRatio
        {
            get { return genderRatio; }
        }

        private void GenderRatioLookup_Load(object sender, EventArgs e)
        {
            comboBoxPokemon.DisplayMember = "Key";
            comboBoxPokemon.ValueMember = "Value";

            pokemonList = new BindingSource(Pokemon.PokemonCollection(), null);
            comboBoxPokemon.DataSource = pokemonList;
            comboBoxPokemon.SelectedIndex = 0;

            Settings.Default.PropertyChanged += ChangeLanguage;
            SetLanguage();
        }

        public void ChangeLanguage(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Language")
            {
                SetLanguage();
            }
        }

        public void SetLanguage()
        {
            Font font;
            switch ((Language)Settings.Default.Language)
            {
                case (Language.Japanese):
                    font = new Font("Meiryo", 7.25F);
                    if (font.Name != "Meiryo")
                    {
                        font = new Font("Arial Unicode MS", 8.25F);
                        if (font.Name != "Arial Unicode MS")
                        {
                            font = new Font("MS Mincho", 8.25F);
                        }
                    }
                    break;
                case (Language.Korean):
                    font = new Font("Malgun Gothic", 8.25F);
                    if (font.Name != "Malgun Gothic")
                    {
                        font = new Font("Gulim", 9.25F);
                        if (font.Name != "Gulim")
                        {
                            font = new Font("Arial Unicode MS", 8.25F);
                        }
                    }
                    break;
                case (Language.SimplifiedChinese):
                    font = new Font("宋体", 9F);
                    if (font.Name != "宋体")
                    {
                        font = new Font("Microsoft Sans Serif", 9F);
                        if (font.Name != "Microsoft Sans Serif")
                        {
                            font = new Font("微软雅黑", 9F);
                        }
                    }
                    break;
                default:
                    font = DefaultFont;
                    break;
            }

            comboBoxPokemon.Font = font;
            pokemonList.ResetBindings(false);
        }

        private void comboBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            genderRatio = ((Pokemon)(comboBoxPokemon.SelectedItem)).GenderRatio;

            switch (genderRatio)
            {
                case 127:
                    labelRatio.Text = "♂1：♀1";
                    break;
                case 191:
                    labelRatio.Text = "♂1：♀3";
                    break;
                case 63:
                    labelRatio.Text = "♂3：♀1";
                    break;
                case 31:
                    labelRatio.Text = "♂7：♀1";
                    break;
                case 0:
                    labelRatio.Text = "只有♂";
                    break;
                case 254:
                    labelRatio.Text = "只有♀";
                    break;
                case 255:
                    labelRatio.Text = "无性别";
                    break;
            }
        }
    }
}
﻿namespace RNGReporter.Objects
{
    partial class PokeSpot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties1 = new RNGReporter.Controls.CheckBoxProperties();
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties2 = new RNGReporter.Controls.CheckBoxProperties();
            this.L_mezapa = new System.Windows.Forms.Label();
            this.genderType = new System.Windows.Forms.ComboBox();
            this.L_sex = new System.Windows.Forms.Label();
            this.L_ability = new System.Windows.Forms.Label();
            this.abilityType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Shiny_Check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.dataGridViewResult = new RNGReporter.DoubleBufferedDataGridView();
            this.dataGridViewTextBoxColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anyPokeSpot = new RNGReporter.GlassButton();
            this.anyNature = new RNGReporter.GlassButton();
            this.anyGender = new RNGReporter.GlassButton();
            this.anyAbility = new RNGReporter.GlassButton();
            this.search = new RNGReporter.GlassButton();
            this.id = new RNGReporter.Controls.MaskedTextBox2();
            this.sid = new RNGReporter.Controls.MaskedTextBox2();
            this.maxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.comboBoxNature = new RNGReporter.Controls.CheckBoxComboBox();
            this.comboBoxSpotType = new RNGReporter.Controls.CheckBoxComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // L_mezapa
            // 
            this.L_mezapa.Location = new System.Drawing.Point(580, 48);
            this.L_mezapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_mezapa.Name = "L_mezapa";
            this.L_mezapa.Size = new System.Drawing.Size(76, 22);
            this.L_mezapa.TabIndex = 283;
            this.L_mezapa.Text = "性格";
            this.L_mezapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genderType
            // 
            this.genderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderType.FormattingEnabled = true;
            this.genderType.Items.AddRange(new object[] {
            "不考虑/无性别",
            "♂(♂1：♀1)",
            "♀(♂1：♀1)",
            "♂(♂1：♀3)",
            "♀(♂1：♀3)",
            "♂(♂3：♀1)",
            "♀(♂3：♀1)",
            "♂(♂7：♀1)",
            "♀(♂7：♀1)",
            "♂(只有♂)",
            "♀(只有♀)"});
            this.genderType.Location = new System.Drawing.Point(659, 88);
            this.genderType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderType.Name = "genderType";
            this.genderType.Size = new System.Drawing.Size(249, 23);
            this.genderType.TabIndex = 279;
            // 
            // L_sex
            // 
            this.L_sex.Location = new System.Drawing.Point(580, 86);
            this.L_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_sex.Name = "L_sex";
            this.L_sex.Size = new System.Drawing.Size(76, 22);
            this.L_sex.TabIndex = 281;
            this.L_sex.Text = "性别比例";
            this.L_sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_ability
            // 
            this.L_ability.Location = new System.Drawing.Point(580, 128);
            this.L_ability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_ability.Name = "L_ability";
            this.L_ability.Size = new System.Drawing.Size(76, 22);
            this.L_ability.TabIndex = 280;
            this.L_ability.Text = "特性";
            this.L_ability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // abilityType
            // 
            this.abilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityType.FormattingEnabled = true;
            this.abilityType.Items.AddRange(new object[] {
            "任意",
            "特性0",
            "特性1"});
            this.abilityType.Location = new System.Drawing.Point(659, 128);
            this.abilityType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abilityType.Name = "abilityType";
            this.abilityType.Size = new System.Drawing.Size(249, 23);
            this.abilityType.TabIndex = 278;
            this.abilityType.SelectedIndexChanged += new System.EventHandler(this.abilityType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(719, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 289;
            this.label2.Text = "SID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(624, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 288;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Shiny_Check
            // 
            this.Shiny_Check.AutoSize = true;
            this.Shiny_Check.Location = new System.Drawing.Point(643, 211);
            this.Shiny_Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Shiny_Check.Name = "Shiny_Check";
            this.Shiny_Check.Size = new System.Drawing.Size(74, 19);
            this.Shiny_Check.TabIndex = 287;
            this.Shiny_Check.Text = "仅异色";
            this.Shiny_Check.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 294;
            this.label3.Text = "宝可场所类型";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(55, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 300;
            this.label5.Text = "最大帧";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(76, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 302;
            this.label6.Text = "Seed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Hex = true;
            this.textBoxSeed.Location = new System.Drawing.Point(133, 151);
            this.textBoxSeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSeed.Mask = "AAAAAAAA";
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(100, 23);
            this.textBoxSeed.TabIndex = 303;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.ColumnHeadersHeight = 20;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn0,
            this.Frame,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Type,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.f125,
            this.f25,
            this.f50,
            this.f75});
            this.dataGridViewResult.Location = new System.Drawing.Point(16, 302);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 21;
            this.dataGridViewResult.RowTemplate.Height = 20;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.ShowCellErrors = false;
            this.dataGridViewResult.ShowCellToolTips = false;
            this.dataGridViewResult.ShowEditingIcon = false;
            this.dataGridViewResult.ShowRowErrors = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(979, 262);
            this.dataGridViewResult.TabIndex = 318;
            // 
            // dataGridViewTextBoxColumn0
            // 
            this.dataGridViewTextBoxColumn0.DataPropertyName = "Seed";
            this.dataGridViewTextBoxColumn0.HeaderText = "Seed";
            this.dataGridViewTextBoxColumn0.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn0.Name = "dataGridViewTextBoxColumn0";
            this.dataGridViewTextBoxColumn0.ReadOnly = true;
            this.dataGridViewTextBoxColumn0.Width = 125;
            // 
            // Frame
            // 
            this.Frame.DataPropertyName = "Frame";
            this.Frame.HeaderText = "帧数";
            this.Frame.MinimumWidth = 6;
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "PID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Shiny";
            this.dataGridViewTextBoxColumn2.HeaderText = "异色";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 25;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "类型";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nature";
            this.dataGridViewTextBoxColumn3.HeaderText = "性格";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ability";
            this.dataGridViewTextBoxColumn4.HeaderText = "特性";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 45;
            // 
            // f125
            // 
            this.f125.DataPropertyName = "Eighth";
            this.f125.HeaderText = "12.5%♀";
            this.f125.MinimumWidth = 6;
            this.f125.Name = "f125";
            this.f125.ReadOnly = true;
            this.f125.Width = 50;
            // 
            // f25
            // 
            this.f25.DataPropertyName = "Quarter";
            this.f25.HeaderText = "25%♀";
            this.f25.MinimumWidth = 6;
            this.f25.Name = "f25";
            this.f25.ReadOnly = true;
            this.f25.Width = 50;
            // 
            // f50
            // 
            this.f50.DataPropertyName = "Half";
            this.f50.HeaderText = "50%♀";
            this.f50.MinimumWidth = 6;
            this.f50.Name = "f50";
            this.f50.ReadOnly = true;
            this.f50.Width = 50;
            // 
            // f75
            // 
            this.f75.DataPropertyName = "Three_Fourths";
            this.f75.HeaderText = "75%♀";
            this.f75.MinimumWidth = 6;
            this.f75.Name = "f75";
            this.f75.ReadOnly = true;
            this.f75.Width = 50;
            // 
            // anyPokeSpot
            // 
            this.anyPokeSpot.BackColor = System.Drawing.Color.AntiqueWhite;
            this.anyPokeSpot.ForeColor = System.Drawing.Color.Black;
            this.anyPokeSpot.Location = new System.Drawing.Point(392, 49);
            this.anyPokeSpot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anyPokeSpot.Name = "anyPokeSpot";
            this.anyPokeSpot.OuterBorderColor = System.Drawing.Color.Transparent;
            this.anyPokeSpot.ShineColor = System.Drawing.SystemColors.Window;
            this.anyPokeSpot.Size = new System.Drawing.Size(60, 26);
            this.anyPokeSpot.TabIndex = 324;
            this.anyPokeSpot.Text = "任意";
            this.anyPokeSpot.Click += new System.EventHandler(this.anyPokeSpot_Click);
            // 
            // anyNature
            // 
            this.anyNature.BackColor = System.Drawing.Color.AntiqueWhite;
            this.anyNature.ForeColor = System.Drawing.Color.Black;
            this.anyNature.Location = new System.Drawing.Point(917, 48);
            this.anyNature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anyNature.Name = "anyNature";
            this.anyNature.OuterBorderColor = System.Drawing.Color.Transparent;
            this.anyNature.ShineColor = System.Drawing.SystemColors.Window;
            this.anyNature.Size = new System.Drawing.Size(60, 26);
            this.anyNature.TabIndex = 325;
            this.anyNature.Text = "任意";
            this.anyNature.Click += new System.EventHandler(this.anyNature_Click);
            // 
            // anyGender
            // 
            this.anyGender.BackColor = System.Drawing.Color.AntiqueWhite;
            this.anyGender.ForeColor = System.Drawing.Color.Black;
            this.anyGender.Location = new System.Drawing.Point(917, 86);
            this.anyGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anyGender.Name = "anyGender";
            this.anyGender.OuterBorderColor = System.Drawing.Color.Transparent;
            this.anyGender.ShineColor = System.Drawing.SystemColors.Window;
            this.anyGender.Size = new System.Drawing.Size(60, 26);
            this.anyGender.TabIndex = 326;
            this.anyGender.Text = "任意";
            this.anyGender.Click += new System.EventHandler(this.anyGender_Click);
            // 
            // anyAbility
            // 
            this.anyAbility.BackColor = System.Drawing.Color.AntiqueWhite;
            this.anyAbility.ForeColor = System.Drawing.Color.Black;
            this.anyAbility.Location = new System.Drawing.Point(917, 128);
            this.anyAbility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anyAbility.Name = "anyAbility";
            this.anyAbility.OuterBorderColor = System.Drawing.Color.Transparent;
            this.anyAbility.ShineColor = System.Drawing.SystemColors.Window;
            this.anyAbility.Size = new System.Drawing.Size(60, 26);
            this.anyAbility.TabIndex = 327;
            this.anyAbility.Text = "任意";
            this.anyAbility.Click += new System.EventHandler(this.anyAbility_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.AntiqueWhite;
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(895, 269);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.OuterBorderColor = System.Drawing.Color.Transparent;
            this.search.ShineColor = System.Drawing.SystemColors.Window;
            this.search.Size = new System.Drawing.Size(100, 26);
            this.search.TabIndex = 328;
            this.search.Text = "计算";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // id
            // 
            this.id.Hex = false;
            this.id.Location = new System.Drawing.Point(659, 182);
            this.id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id.Mask = "00000";
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 23);
            this.id.TabIndex = 332;
            this.id.Tag = "id/sid";
            this.id.Text = "0";
            this.id.ValidatingType = typeof(int);
            // 
            // sid
            // 
            this.sid.Hex = false;
            this.sid.Location = new System.Drawing.Point(779, 182);
            this.sid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sid.Mask = "00000";
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(51, 23);
            this.sid.TabIndex = 333;
            this.sid.Tag = "id/sid";
            this.sid.Text = "0";
            this.sid.ValidatingType = typeof(int);
            // 
            // maxFrame
            // 
            this.maxFrame.Hex = false;
            this.maxFrame.Location = new System.Drawing.Point(133, 182);
            this.maxFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxFrame.Mask = "0000000000";
            this.maxFrame.Name = "maxFrame";
            this.maxFrame.Size = new System.Drawing.Size(100, 23);
            this.maxFrame.TabIndex = 334;
            this.maxFrame.Text = "3000000";
            this.maxFrame.ValidatingType = typeof(int);
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.BlankText = "任意";
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxNature.CheckBoxProperties = checkBoxProperties1;
            this.comboBoxNature.DisplayMemberSingleItem = "";
            this.comboBoxNature.DropDownHeight = 300;
            this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Location = new System.Drawing.Point(659, 49);
            this.comboBoxNature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.Size = new System.Drawing.Size(249, 23);
            this.comboBoxNature.TabIndex = 335;
            // 
            // comboBoxSpotType
            // 
            this.comboBoxSpotType.BlankText = "任意";
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxSpotType.CheckBoxProperties = checkBoxProperties2;
            this.comboBoxSpotType.DisplayMemberSingleItem = "";
            this.comboBoxSpotType.DropDownHeight = 110;
            this.comboBoxSpotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpotType.FormattingEnabled = true;
            this.comboBoxSpotType.Location = new System.Drawing.Point(133, 50);
            this.comboBoxSpotType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSpotType.Name = "comboBoxSpotType";
            this.comboBoxSpotType.Size = new System.Drawing.Size(249, 23);
            this.comboBoxSpotType.TabIndex = 336;
            this.comboBoxSpotType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpotType_SelectedIndexChanged);
            // 
            // PokeSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 578);
            this.Controls.Add(this.comboBoxSpotType);
            this.Controls.Add(this.comboBoxNature);
            this.Controls.Add(this.maxFrame);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.id);
            this.Controls.Add(this.search);
            this.Controls.Add(this.anyAbility);
            this.Controls.Add(this.anyGender);
            this.Controls.Add(this.anyNature);
            this.Controls.Add(this.anyPokeSpot);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shiny_Check);
            this.Controls.Add(this.L_mezapa);
            this.Controls.Add(this.genderType);
            this.Controls.Add(this.L_sex);
            this.Controls.Add(this.L_ability);
            this.Controls.Add(this.abilityType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PokeSpot";
            this.Text = "宝可场所PokeSpot（XD暗之旋风专属）";
            this.Load += new System.EventHandler(this.PokeSpot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_mezapa;
        private System.Windows.Forms.ComboBox genderType;
        private System.Windows.Forms.Label L_sex;
        private System.Windows.Forms.Label L_ability;
        private System.Windows.Forms.ComboBox abilityType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Shiny_Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Controls.MaskedTextBox2 textBoxSeed;
        private DoubleBufferedDataGridView dataGridViewResult;
        private GlassButton anyPokeSpot;
        private GlassButton anyNature;
        private GlassButton anyGender;
        private GlassButton anyAbility;
        private GlassButton search;
        private Controls.MaskedTextBox2 id;
        private Controls.MaskedTextBox2 sid;
        private Controls.MaskedTextBox2 maxFrame;
        private Controls.CheckBoxComboBox comboBoxNature;
        private Controls.CheckBoxComboBox comboBoxSpotType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn f125;
        private System.Windows.Forms.DataGridViewTextBoxColumn f25;
        private System.Windows.Forms.DataGridViewTextBoxColumn f50;
        private System.Windows.Forms.DataGridViewTextBoxColumn f75;
    }
}
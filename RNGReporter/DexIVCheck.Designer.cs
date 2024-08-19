using RNGReporter.Controls;

namespace RNGReporter
{
    partial class DexIVCheck
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
            this.comboBoxPokemon = new RNGReporter.GlassComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBaseSpe = new System.Windows.Forms.Label();
            this.labelBaseSpD = new System.Windows.Forms.Label();
            this.labelBaseSpA = new System.Windows.Forms.Label();
            this.labelBaseDef = new System.Windows.Forms.Label();
            this.labelBaseAtk = new System.Windows.Forms.Label();
            this.labelBaseHP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCharacteristic = new RNGReporter.GlassComboBox();
            this.labelAbility1 = new System.Windows.Forms.Label();
            this.labelAbility0 = new System.Windows.Forms.Label();
            this.comboBoxNature = new RNGReporter.GlassComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonCheck = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.textBoxResults = new RNGReporter.TextBox2();
            this.maskedTextBoxLevel = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxDef = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtk = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpe = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpD = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHP = new RNGReporter.Controls.MaskedTextBox2();
            this.SuspendLayout();
            // 
            // comboBoxPokemon
            // 
            this.comboBoxPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPokemon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPokemon.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPokemon.FormattingEnabled = true;
            this.comboBoxPokemon.Location = new System.Drawing.Point(12, 23);
            this.comboBoxPokemon.Name = "comboBoxPokemon";
            this.comboBoxPokemon.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxPokemon.Size = new System.Drawing.Size(171, 20);
            this.comboBoxPokemon.TabIndex = 1;
            this.comboBoxPokemon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "宝可梦";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "HP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "攻击";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "防御";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "特攻";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "特防";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "速度";
            // 
            // labelBaseSpe
            // 
            this.labelBaseSpe.AutoSize = true;
            this.labelBaseSpe.Location = new System.Drawing.Point(414, 108);
            this.labelBaseSpe.Name = "labelBaseSpe";
            this.labelBaseSpe.Size = new System.Drawing.Size(11, 12);
            this.labelBaseSpe.TabIndex = 16;
            this.labelBaseSpe.Text = "0";
            // 
            // labelBaseSpD
            // 
            this.labelBaseSpD.AutoSize = true;
            this.labelBaseSpD.Location = new System.Drawing.Point(414, 91);
            this.labelBaseSpD.Name = "labelBaseSpD";
            this.labelBaseSpD.Size = new System.Drawing.Size(11, 12);
            this.labelBaseSpD.TabIndex = 15;
            this.labelBaseSpD.Text = "0";
            // 
            // labelBaseSpA
            // 
            this.labelBaseSpA.AutoSize = true;
            this.labelBaseSpA.Location = new System.Drawing.Point(414, 74);
            this.labelBaseSpA.Name = "labelBaseSpA";
            this.labelBaseSpA.Size = new System.Drawing.Size(11, 12);
            this.labelBaseSpA.TabIndex = 14;
            this.labelBaseSpA.Text = "0";
            // 
            // labelBaseDef
            // 
            this.labelBaseDef.AutoSize = true;
            this.labelBaseDef.Location = new System.Drawing.Point(414, 57);
            this.labelBaseDef.Name = "labelBaseDef";
            this.labelBaseDef.Size = new System.Drawing.Size(11, 12);
            this.labelBaseDef.TabIndex = 13;
            this.labelBaseDef.Text = "0";
            // 
            // labelBaseAtk
            // 
            this.labelBaseAtk.AutoSize = true;
            this.labelBaseAtk.Location = new System.Drawing.Point(414, 40);
            this.labelBaseAtk.Name = "labelBaseAtk";
            this.labelBaseAtk.Size = new System.Drawing.Size(11, 12);
            this.labelBaseAtk.TabIndex = 12;
            this.labelBaseAtk.Text = "0";
            // 
            // labelBaseHP
            // 
            this.labelBaseHP.AutoSize = true;
            this.labelBaseHP.Location = new System.Drawing.Point(414, 23);
            this.labelBaseHP.Name = "labelBaseHP";
            this.labelBaseHP.Size = new System.Drawing.Size(11, 12);
            this.labelBaseHP.TabIndex = 11;
            this.labelBaseHP.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "特性0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 60);
            this.label9.TabIndex = 18;
            this.label9.Text = "特性1\n\n以上是宝可梦的种族值和特性\n\n左侧选择对应宝可梦则可显示";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "等级";
            // 
            // comboBoxCharacteristic
            // 
            this.comboBoxCharacteristic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCharacteristic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCharacteristic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharacteristic.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCharacteristic.FormattingEnabled = true;
            this.comboBoxCharacteristic.Location = new System.Drawing.Point(12, 60);
            this.comboBoxCharacteristic.Name = "comboBoxCharacteristic";
            this.comboBoxCharacteristic.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxCharacteristic.Size = new System.Drawing.Size(171, 20);
            this.comboBoxCharacteristic.TabIndex = 5;
            // 
            // labelAbility1
            // 
            this.labelAbility1.AutoSize = true;
            this.labelAbility1.Location = new System.Drawing.Point(414, 143);
            this.labelAbility1.Name = "labelAbility1";
            this.labelAbility1.Size = new System.Drawing.Size(11, 12);
            this.labelAbility1.TabIndex = 20;
            this.labelAbility1.Text = "1";
            // 
            // labelAbility0
            // 
            this.labelAbility0.AutoSize = true;
            this.labelAbility0.Location = new System.Drawing.Point(414, 125);
            this.labelAbility0.Name = "labelAbility0";
            this.labelAbility0.Size = new System.Drawing.Size(11, 12);
            this.labelAbility0.TabIndex = 19;
            this.labelAbility0.Text = "0";
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Location = new System.Drawing.Point(189, 23);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxNature.Size = new System.Drawing.Size(121, 20);
            this.comboBoxNature.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "性格";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "个性";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "速度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "特防";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "特攻";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 12;
            this.label16.Text = "防御";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(108, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "攻击";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "HP";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonCheck.Location = new System.Drawing.Point(236, 121);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCheck.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCheck.Size = new System.Drawing.Size(75, 21);
            this.buttonCheck.TabIndex = 60;
            this.buttonCheck.Text = "计算个体";
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(441, 264);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(75, 21);
            this.buttonOk.TabIndex = 61;
            this.buttonOk.Text = "OK";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(12, 148);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(298, 114);
            this.textBoxResults.TabIndex = 63;
            // 
            // maskedTextBoxLevel
            // 
            this.maskedTextBoxLevel.Hex = false;
            this.maskedTextBoxLevel.Location = new System.Drawing.Point(12, 97);
            this.maskedTextBoxLevel.Mask = "000";
            this.maskedTextBoxLevel.Name = "maskedTextBoxLevel";
            this.maskedTextBoxLevel.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxLevel.TabIndex = 7;
            this.maskedTextBoxLevel.Tag = "level";
            this.maskedTextBoxLevel.ValidatingType = typeof(int);
            // 
            // maskedTextBoxDef
            // 
            this.maskedTextBoxDef.Hex = false;
            this.maskedTextBoxDef.Location = new System.Drawing.Point(148, 97);
            this.maskedTextBoxDef.Mask = "000";
            this.maskedTextBoxDef.Name = "maskedTextBoxDef";
            this.maskedTextBoxDef.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxDef.TabIndex = 13;
            this.maskedTextBoxDef.ValidatingType = typeof(int);
            // 
            // maskedTextBoxAtk
            // 
            this.maskedTextBoxAtk.Hex = false;
            this.maskedTextBoxAtk.Location = new System.Drawing.Point(106, 97);
            this.maskedTextBoxAtk.Mask = "000";
            this.maskedTextBoxAtk.Name = "maskedTextBoxAtk";
            this.maskedTextBoxAtk.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxAtk.TabIndex = 11;
            this.maskedTextBoxAtk.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpe
            // 
            this.maskedTextBoxSpe.Hex = false;
            this.maskedTextBoxSpe.Location = new System.Drawing.Point(274, 97);
            this.maskedTextBoxSpe.Mask = "000";
            this.maskedTextBoxSpe.Name = "maskedTextBoxSpe";
            this.maskedTextBoxSpe.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxSpe.TabIndex = 19;
            this.maskedTextBoxSpe.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpD
            // 
            this.maskedTextBoxSpD.Hex = false;
            this.maskedTextBoxSpD.Location = new System.Drawing.Point(232, 97);
            this.maskedTextBoxSpD.Mask = "000";
            this.maskedTextBoxSpD.Name = "maskedTextBoxSpD";
            this.maskedTextBoxSpD.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxSpD.TabIndex = 17;
            this.maskedTextBoxSpD.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpA
            // 
            this.maskedTextBoxSpA.Hex = false;
            this.maskedTextBoxSpA.Location = new System.Drawing.Point(190, 97);
            this.maskedTextBoxSpA.Mask = "000";
            this.maskedTextBoxSpA.Name = "maskedTextBoxSpA";
            this.maskedTextBoxSpA.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxSpA.TabIndex = 15;
            this.maskedTextBoxSpA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxHP
            // 
            this.maskedTextBoxHP.Hex = false;
            this.maskedTextBoxHP.Location = new System.Drawing.Point(64, 97);
            this.maskedTextBoxHP.Mask = "000";
            this.maskedTextBoxHP.Name = "maskedTextBoxHP";
            this.maskedTextBoxHP.Size = new System.Drawing.Size(36, 19);
            this.maskedTextBoxHP.TabIndex = 9;
            this.maskedTextBoxHP.ValidatingType = typeof(int);
            // 
            // DexIVCheck
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 296);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.labelAbility1);
            this.Controls.Add(this.labelAbility0);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelBaseSpe);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxLevel);
            this.Controls.Add(this.labelBaseSpD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelBaseHP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelBaseSpA);
            this.Controls.Add(this.comboBoxNature);
            this.Controls.Add(this.labelBaseAtk);
            this.Controls.Add(this.maskedTextBoxDef);
            this.Controls.Add(this.labelBaseDef);
            this.Controls.Add(this.maskedTextBoxAtk);
            this.Controls.Add(this.maskedTextBoxSpe);
            this.Controls.Add(this.maskedTextBoxSpD);
            this.Controls.Add(this.maskedTextBoxSpA);
            this.Controls.Add(this.maskedTextBoxHP);
            this.Controls.Add(this.comboBoxCharacteristic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DexIVCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "个体计算器/迷你图鉴";
            this.Load += new System.EventHandler(this.DexIVCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RNGReporter.GlassComboBox comboBoxPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBaseSpe;
        private System.Windows.Forms.Label labelBaseSpD;
        private System.Windows.Forms.Label labelBaseSpA;
        private System.Windows.Forms.Label labelBaseDef;
        private System.Windows.Forms.Label labelBaseAtk;
        private System.Windows.Forms.Label labelBaseHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private RNGReporter.GlassComboBox comboBoxCharacteristic;
        private MaskedTextBox2 maskedTextBoxDef;
        private MaskedTextBox2 maskedTextBoxAtk;
        private MaskedTextBox2 maskedTextBoxSpe;
        private MaskedTextBox2 maskedTextBoxSpD;
        private MaskedTextBox2 maskedTextBoxSpA;
        private MaskedTextBox2 maskedTextBoxHP;
        private RNGReporter.GlassComboBox comboBoxNature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAbility1;
        private System.Windows.Forms.Label labelAbility0;
        private MaskedTextBox2 maskedTextBoxLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private RNGReporter.GlassButton buttonCheck;
        private RNGReporter.GlassButton buttonOk;
        private RNGReporter.TextBox2 textBoxResults;
    }
}

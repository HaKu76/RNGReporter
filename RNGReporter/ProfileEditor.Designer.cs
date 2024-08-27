namespace RNGReporter
{
    partial class ProfileEditor
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
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties1 = new RNGReporter.Controls.CheckBoxProperties();
            this.checkBoxSkipLR = new System.Windows.Forms.CheckBox();
            this.btnParameters = new RNGReporter.GlassButton();
            this.comboBoxKeypresses = new RNGReporter.Controls.CheckBoxComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.textBoxTimer0Max = new RNGReporter.TextBox2();
            this.comboBoxDSType = new RNGReporter.GlassComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBoxTimer0Min = new RNGReporter.TextBox2();
            this.label53 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.checkBoxSoftReset = new System.Windows.Forms.CheckBox();
            this.comboBoxVersion = new RNGReporter.GlassComboBox();
            this.textBoxGxStat = new RNGReporter.TextBox2();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBoxVFrame = new RNGReporter.TextBox2();
            this.textBoxMAC = new RNGReporter.TextBox2();
            this.labelMACAddress = new System.Windows.Forms.Label();
            this.textBoxVCount = new RNGReporter.TextBox2();
            this.textBoxName = new RNGReporter.TextBox2();
            this.label41 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.maskedTextBoxSID = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxID = new RNGReporter.Controls.MaskedTextBox2();
            this.btnOK = new RNGReporter.GlassButton();
            this.btnCancel = new RNGReporter.GlassButton();
            this.checkBoxMemoryLink = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new RNGReporter.GlassComboBox();
            this.SuspendLayout();
            // 
            // checkBoxSkipLR
            // 
            this.checkBoxSkipLR.AutoSize = true;
            this.checkBoxSkipLR.Location = new System.Drawing.Point(508, 24);
            this.checkBoxSkipLR.Name = "checkBoxSkipLR";
            this.checkBoxSkipLR.Size = new System.Drawing.Size(162, 16);
            this.checkBoxSkipLR.TabIndex = 5;
            this.checkBoxSkipLR.Text = "跳过含L\\R按键的搜索结果";
            this.checkBoxSkipLR.UseVisualStyleBackColor = true;
            // 
            // btnParameters
            // 
            this.btnParameters.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnParameters.ForeColor = System.Drawing.Color.Black;
            this.btnParameters.Location = new System.Drawing.Point(510, 92);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnParameters.ShineColor = System.Drawing.SystemColors.Window;
            this.btnParameters.Size = new System.Drawing.Size(155, 21);
            this.btnParameters.TabIndex = 154;
            this.btnParameters.Text = "校准计算DS参数";
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // comboBoxKeypresses
            // 
            this.comboBoxKeypresses.BlankText = "任意";
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxKeypresses.CheckBoxProperties = checkBoxProperties1;
            this.comboBoxKeypresses.DisplayMemberSingleItem = "";
            this.comboBoxKeypresses.DropDownHeight = 300;
            this.comboBoxKeypresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeypresses.FormattingEnabled = true;
            this.comboBoxKeypresses.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3"});
            this.comboBoxKeypresses.Location = new System.Drawing.Point(207, 58);
            this.comboBoxKeypresses.Name = "comboBoxKeypresses";
            this.comboBoxKeypresses.Size = new System.Drawing.Size(132, 20);
            this.comboBoxKeypresses.TabIndex = 9;
            this.comboBoxKeypresses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxKeypresses_MouseClick);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(364, 80);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(41, 12);
            this.label71.TabIndex = 151;
            this.label71.Text = "DS机型";
            // 
            // textBoxTimer0Max
            // 
            this.textBoxTimer0Max.Location = new System.Drawing.Point(431, 55);
            this.textBoxTimer0Max.MaxLength = 6;
            this.textBoxTimer0Max.Name = "textBoxTimer0Max";
            this.textBoxTimer0Max.Size = new System.Drawing.Size(40, 21);
            this.textBoxTimer0Max.TabIndex = 7;
            // 
            // comboBoxDSType
            // 
            this.comboBoxDSType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDSType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDSType.FormattingEnabled = true;
            this.comboBoxDSType.Items.AddRange(new object[] {
            "DS Original\\Lite",
            "DSi\\DSi XL",
            "3DS"});
            this.comboBoxDSType.Location = new System.Drawing.Point(366, 94);
            this.comboBoxDSType.Name = "comboBoxDSType";
            this.comboBoxDSType.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxDSType.Size = new System.Drawing.Size(124, 20);
            this.comboBoxDSType.TabIndex = 11;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(363, 41);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 12);
            this.label49.TabIndex = 138;
            this.label49.Text = "最小Timer0";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTimer0Min
            // 
            this.textBoxTimer0Min.Location = new System.Drawing.Point(366, 55);
            this.textBoxTimer0Min.MaxLength = 6;
            this.textBoxTimer0Min.Name = "textBoxTimer0Min";
            this.textBoxTimer0Min.Size = new System.Drawing.Size(38, 21);
            this.textBoxTimer0Min.TabIndex = 6;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(428, 41);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(65, 12);
            this.label53.TabIndex = 144;
            this.label53.Text = "最大Timer0";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(204, 43);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 12);
            this.label51.TabIndex = 146;
            this.label51.Text = "按键";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(204, 80);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(29, 12);
            this.label50.TabIndex = 142;
            this.label50.Text = "版本";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxSoftReset
            // 
            this.checkBoxSoftReset.AutoSize = true;
            this.checkBoxSoftReset.Location = new System.Drawing.Point(495, 57);
            this.checkBoxSoftReset.Name = "checkBoxSoftReset";
            this.checkBoxSoftReset.Size = new System.Drawing.Size(60, 16);
            this.checkBoxSoftReset.TabIndex = 8;
            this.checkBoxSoftReset.Text = "软复位";
            this.checkBoxSoftReset.UseVisualStyleBackColor = true;
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersion.ForeColor = System.Drawing.Color.Black;
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Items.AddRange(new object[] {
            "Black",
            "White",
            "Black 2",
            "White 2"});
            this.comboBoxVersion.Location = new System.Drawing.Point(207, 94);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxVersion.Size = new System.Drawing.Size(132, 20);
            this.comboBoxVersion.TabIndex = 10;
            this.comboBoxVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersion_SelectedIndexChanged);
            // 
            // textBoxGxStat
            // 
            this.textBoxGxStat.Location = new System.Drawing.Point(416, 23);
            this.textBoxGxStat.MaxLength = 6;
            this.textBoxGxStat.Name = "textBoxGxStat";
            this.textBoxGxStat.Size = new System.Drawing.Size(40, 21);
            this.textBoxGxStat.TabIndex = 3;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(459, 9);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(41, 12);
            this.label48.TabIndex = 139;
            this.label48.Text = "VFrame";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(365, 7);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 12);
            this.label47.TabIndex = 137;
            this.label47.Text = "VCount";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(413, 8);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(41, 12);
            this.label46.TabIndex = 136;
            this.label46.Text = "GxStat";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxVFrame
            // 
            this.textBoxVFrame.Location = new System.Drawing.Point(462, 24);
            this.textBoxVFrame.MaxLength = 6;
            this.textBoxVFrame.Name = "textBoxVFrame";
            this.textBoxVFrame.Size = new System.Drawing.Size(40, 21);
            this.textBoxVFrame.TabIndex = 4;
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(207, 22);
            this.textBoxMAC.MaxLength = 12;
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(132, 21);
            this.textBoxMAC.TabIndex = 1;
            // 
            // labelMACAddress
            // 
            this.labelMACAddress.AutoSize = true;
            this.labelMACAddress.Location = new System.Drawing.Point(204, 8);
            this.labelMACAddress.Name = "labelMACAddress";
            this.labelMACAddress.Size = new System.Drawing.Size(71, 12);
            this.labelMACAddress.TabIndex = 130;
            this.labelMACAddress.Text = "DS MAC 地址";
            this.labelMACAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxVCount
            // 
            this.textBoxVCount.Location = new System.Drawing.Point(368, 22);
            this.textBoxVCount.MaxLength = 6;
            this.textBoxVCount.Name = "textBoxVCount";
            this.textBoxVCount.Size = new System.Drawing.Size(40, 21);
            this.textBoxVCount.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 22);
            this.textBoxName.MaxLength = 16;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 126;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(15, 25);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(53, 12);
            this.label41.TabIndex = 132;
            this.label41.Text = "存档名称";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(57, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 131;
            this.label27.Text = "SID";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(64, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 130;
            this.label31.Text = "ID";
            // 
            // maskedTextBoxSID
            // 
            this.maskedTextBoxSID.Hex = false;
            this.maskedTextBoxSID.Location = new System.Drawing.Point(88, 70);
            this.maskedTextBoxSID.Mask = "00000";
            this.maskedTextBoxSID.Name = "maskedTextBoxSID";
            this.maskedTextBoxSID.Size = new System.Drawing.Size(60, 19);
            this.maskedTextBoxSID.TabIndex = 128;
            this.maskedTextBoxSID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Hex = false;
            this.maskedTextBoxID.Location = new System.Drawing.Point(88, 46);
            this.maskedTextBoxID.Mask = "00000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(60, 19);
            this.maskedTextBoxID.TabIndex = 127;
            this.maskedTextBoxID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(46, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnOK.ShineColor = System.Drawing.SystemColors.Window;
            this.btnOK.Size = new System.Drawing.Size(155, 21);
            this.btnOK.TabIndex = 155;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(207, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Size = new System.Drawing.Size(155, 21);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxMemoryLink
            // 
            this.checkBoxMemoryLink.AutoSize = true;
            this.checkBoxMemoryLink.Location = new System.Drawing.Point(577, 57);
            this.checkBoxMemoryLink.Name = "checkBoxMemoryLink";
            this.checkBoxMemoryLink.Size = new System.Drawing.Size(72, 16);
            this.checkBoxMemoryLink.TabIndex = 157;
            this.checkBoxMemoryLink.Text = "记忆连接";
            this.checkBoxMemoryLink.UseVisualStyleBackColor = true;
            this.checkBoxMemoryLink.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 159;
            this.label1.Text = "游戏语言";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.ForeColor = System.Drawing.Color.Black;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Japanese",
            "German",
            "Spanish",
            "French",
            "Italian",
            "Korean"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(46, 94);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxLanguage.Size = new System.Drawing.Size(132, 20);
            this.comboBoxLanguage.TabIndex = 158;
            // 
            // ProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 156);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.checkBoxMemoryLink);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBoxSkipLR);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxKeypresses);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.textBoxTimer0Max);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBoxDSType);
            this.Controls.Add(this.maskedTextBoxSID);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.textBoxTimer0Min);
            this.Controls.Add(this.labelMACAddress);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.textBoxVCount);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.textBoxVFrame);
            this.Controls.Add(this.checkBoxSoftReset);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.textBoxGxStat);
            this.Controls.Add(this.label48);
            this.Name = "ProfileEditor";
            this.Text = "存档信息编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSkipLR;
        private GlassButton btnParameters;
        private Controls.CheckBoxComboBox comboBoxKeypresses;
        private System.Windows.Forms.Label label71;
        private TextBox2 textBoxTimer0Max;
        private GlassComboBox comboBoxDSType;
        private System.Windows.Forms.Label label49;
        private TextBox2 textBoxTimer0Min;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox checkBoxSoftReset;
        private GlassComboBox comboBoxVersion;
        private TextBox2 textBoxGxStat;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private TextBox2 textBoxVFrame;
        private TextBox2 textBoxMAC;
        private System.Windows.Forms.Label labelMACAddress;
        private TextBox2 textBoxVCount;
        private TextBox2 textBoxName;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private Controls.MaskedTextBox2 maskedTextBoxSID;
        private Controls.MaskedTextBox2 maskedTextBoxID;
        private GlassButton btnOK;
        private GlassButton btnCancel;
        private System.Windows.Forms.CheckBox checkBoxMemoryLink;
        private System.Windows.Forms.Label label1;
        private GlassComboBox comboBoxLanguage;
    }
}
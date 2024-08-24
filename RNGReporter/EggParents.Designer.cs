using RNGReporter.Controls;

namespace RNGReporter
{
    partial class EggParents
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
            this.labelIVRNG = new System.Windows.Forms.Label();
            this.labelParentA = new System.Windows.Forms.Label();
            this.labelParentB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk1 = new RNGReporter.GlassButton();
            this.buttonCancel1 = new RNGReporter.GlassButton();
            this.maskedTextBoxSpe_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpD_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpA_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxDef_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtk_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHP_IVRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpe_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpD_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpA_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxDef_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtk_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHP_ParentA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpe_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpD_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpA_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxDef_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtk_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHP_ParentB = new RNGReporter.Controls.MaskedTextBox2();
            this.buttonRetrieveIVs = new RNGReporter.GlassButton();
            this.SuspendLayout();
            // 
            // labelIVRNG
            // 
            this.labelIVRNG.AutoSize = true;
            this.labelIVRNG.Location = new System.Drawing.Point(7, 106);
            this.labelIVRNG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIVRNG.Name = "labelIVRNG";
            this.labelIVRNG.Size = new System.Drawing.Size(112, 15);
            this.labelIVRNG.TabIndex = 77;
            this.labelIVRNG.Text = "乱数获取的个体";
            // 
            // labelParentA
            // 
            this.labelParentA.AutoSize = true;
            this.labelParentA.Location = new System.Drawing.Point(52, 46);
            this.labelParentA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParentA.Name = "labelParentA";
            this.labelParentA.Size = new System.Drawing.Size(67, 15);
            this.labelParentA.TabIndex = 70;
            this.labelParentA.Text = "母方个体";
            // 
            // labelParentB
            // 
            this.labelParentB.AutoSize = true;
            this.labelParentB.Location = new System.Drawing.Point(52, 76);
            this.labelParentB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParentB.Name = "labelParentB";
            this.labelParentB.Size = new System.Drawing.Size(67, 15);
            this.labelParentB.TabIndex = 69;
            this.labelParentB.Text = "父方个体";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "特防";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "特攻";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "防御";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "攻击";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "HP";
            // 
            // buttonOk1
            // 
            this.buttonOk1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk1.ForeColor = System.Drawing.Color.Black;
            this.buttonOk1.Location = new System.Drawing.Point(233, 142);
            this.buttonOk1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk1.Name = "buttonOk1";
            this.buttonOk1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk1.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk1.Size = new System.Drawing.Size(100, 26);
            this.buttonOk1.TabIndex = 78;
            this.buttonOk1.Text = "确定";
            this.buttonOk1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel1
            // 
            this.buttonCancel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel1.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel1.Location = new System.Drawing.Point(343, 142);
            this.buttonCancel1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel1.Name = "buttonCancel1";
            this.buttonCancel1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel1.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel1.Size = new System.Drawing.Size(100, 26);
            this.buttonCancel1.TabIndex = 79;
            this.buttonCancel1.Text = "关闭";
            // 
            // maskedTextBoxSpe_IVRNG
            // 
            this.maskedTextBoxSpe_IVRNG.Hex = false;
            this.maskedTextBoxSpe_IVRNG.Location = new System.Drawing.Point(397, 102);
            this.maskedTextBoxSpe_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpe_IVRNG.Mask = "00";
            this.maskedTextBoxSpe_IVRNG.Name = "maskedTextBoxSpe_IVRNG";
            this.maskedTextBoxSpe_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpe_IVRNG.TabIndex = 76;
            this.maskedTextBoxSpe_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxSpD_IVRNG
            // 
            this.maskedTextBoxSpD_IVRNG.Hex = false;
            this.maskedTextBoxSpD_IVRNG.Location = new System.Drawing.Point(343, 102);
            this.maskedTextBoxSpD_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpD_IVRNG.Mask = "00";
            this.maskedTextBoxSpD_IVRNG.Name = "maskedTextBoxSpD_IVRNG";
            this.maskedTextBoxSpD_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpD_IVRNG.TabIndex = 75;
            this.maskedTextBoxSpD_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxSpA_IVRNG
            // 
            this.maskedTextBoxSpA_IVRNG.Hex = false;
            this.maskedTextBoxSpA_IVRNG.Location = new System.Drawing.Point(288, 102);
            this.maskedTextBoxSpA_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpA_IVRNG.Mask = "00";
            this.maskedTextBoxSpA_IVRNG.Name = "maskedTextBoxSpA_IVRNG";
            this.maskedTextBoxSpA_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpA_IVRNG.TabIndex = 74;
            this.maskedTextBoxSpA_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxDef_IVRNG
            // 
            this.maskedTextBoxDef_IVRNG.Hex = false;
            this.maskedTextBoxDef_IVRNG.Location = new System.Drawing.Point(233, 102);
            this.maskedTextBoxDef_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxDef_IVRNG.Mask = "00";
            this.maskedTextBoxDef_IVRNG.Name = "maskedTextBoxDef_IVRNG";
            this.maskedTextBoxDef_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxDef_IVRNG.TabIndex = 73;
            this.maskedTextBoxDef_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxAtk_IVRNG
            // 
            this.maskedTextBoxAtk_IVRNG.Hex = false;
            this.maskedTextBoxAtk_IVRNG.Location = new System.Drawing.Point(179, 102);
            this.maskedTextBoxAtk_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxAtk_IVRNG.Mask = "00";
            this.maskedTextBoxAtk_IVRNG.Name = "maskedTextBoxAtk_IVRNG";
            this.maskedTextBoxAtk_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxAtk_IVRNG.TabIndex = 72;
            this.maskedTextBoxAtk_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxHP_IVRNG
            // 
            this.maskedTextBoxHP_IVRNG.Hex = false;
            this.maskedTextBoxHP_IVRNG.Location = new System.Drawing.Point(124, 102);
            this.maskedTextBoxHP_IVRNG.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHP_IVRNG.Mask = "00";
            this.maskedTextBoxHP_IVRNG.Name = "maskedTextBoxHP_IVRNG";
            this.maskedTextBoxHP_IVRNG.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxHP_IVRNG.TabIndex = 71;
            this.maskedTextBoxHP_IVRNG.Tag = "ivs";
            // 
            // maskedTextBoxSpe_ParentA
            // 
            this.maskedTextBoxSpe_ParentA.Hex = false;
            this.maskedTextBoxSpe_ParentA.Location = new System.Drawing.Point(397, 42);
            this.maskedTextBoxSpe_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpe_ParentA.Mask = "00";
            this.maskedTextBoxSpe_ParentA.Name = "maskedTextBoxSpe_ParentA";
            this.maskedTextBoxSpe_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpe_ParentA.TabIndex = 62;
            this.maskedTextBoxSpe_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxSpD_ParentA
            // 
            this.maskedTextBoxSpD_ParentA.Hex = false;
            this.maskedTextBoxSpD_ParentA.Location = new System.Drawing.Point(343, 42);
            this.maskedTextBoxSpD_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpD_ParentA.Mask = "00";
            this.maskedTextBoxSpD_ParentA.Name = "maskedTextBoxSpD_ParentA";
            this.maskedTextBoxSpD_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpD_ParentA.TabIndex = 61;
            this.maskedTextBoxSpD_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxSpA_ParentA
            // 
            this.maskedTextBoxSpA_ParentA.Hex = false;
            this.maskedTextBoxSpA_ParentA.Location = new System.Drawing.Point(288, 42);
            this.maskedTextBoxSpA_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpA_ParentA.Mask = "00";
            this.maskedTextBoxSpA_ParentA.Name = "maskedTextBoxSpA_ParentA";
            this.maskedTextBoxSpA_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpA_ParentA.TabIndex = 60;
            this.maskedTextBoxSpA_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxDef_ParentA
            // 
            this.maskedTextBoxDef_ParentA.Hex = false;
            this.maskedTextBoxDef_ParentA.Location = new System.Drawing.Point(233, 42);
            this.maskedTextBoxDef_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxDef_ParentA.Mask = "00";
            this.maskedTextBoxDef_ParentA.Name = "maskedTextBoxDef_ParentA";
            this.maskedTextBoxDef_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxDef_ParentA.TabIndex = 59;
            this.maskedTextBoxDef_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxAtk_ParentA
            // 
            this.maskedTextBoxAtk_ParentA.Hex = false;
            this.maskedTextBoxAtk_ParentA.Location = new System.Drawing.Point(179, 42);
            this.maskedTextBoxAtk_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxAtk_ParentA.Mask = "00";
            this.maskedTextBoxAtk_ParentA.Name = "maskedTextBoxAtk_ParentA";
            this.maskedTextBoxAtk_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxAtk_ParentA.TabIndex = 58;
            this.maskedTextBoxAtk_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxHP_ParentA
            // 
            this.maskedTextBoxHP_ParentA.Hex = false;
            this.maskedTextBoxHP_ParentA.Location = new System.Drawing.Point(124, 42);
            this.maskedTextBoxHP_ParentA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHP_ParentA.Mask = "00";
            this.maskedTextBoxHP_ParentA.Name = "maskedTextBoxHP_ParentA";
            this.maskedTextBoxHP_ParentA.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxHP_ParentA.TabIndex = 57;
            this.maskedTextBoxHP_ParentA.Tag = "ivs";
            // 
            // maskedTextBoxSpe_ParentB
            // 
            this.maskedTextBoxSpe_ParentB.Hex = false;
            this.maskedTextBoxSpe_ParentB.Location = new System.Drawing.Point(397, 72);
            this.maskedTextBoxSpe_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpe_ParentB.Mask = "00";
            this.maskedTextBoxSpe_ParentB.Name = "maskedTextBoxSpe_ParentB";
            this.maskedTextBoxSpe_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpe_ParentB.TabIndex = 56;
            this.maskedTextBoxSpe_ParentB.Tag = "ivs";
            // 
            // maskedTextBoxSpD_ParentB
            // 
            this.maskedTextBoxSpD_ParentB.Hex = false;
            this.maskedTextBoxSpD_ParentB.Location = new System.Drawing.Point(343, 72);
            this.maskedTextBoxSpD_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpD_ParentB.Mask = "00";
            this.maskedTextBoxSpD_ParentB.Name = "maskedTextBoxSpD_ParentB";
            this.maskedTextBoxSpD_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpD_ParentB.TabIndex = 55;
            this.maskedTextBoxSpD_ParentB.Tag = "ivs";
            // 
            // maskedTextBoxSpA_ParentB
            // 
            this.maskedTextBoxSpA_ParentB.Hex = false;
            this.maskedTextBoxSpA_ParentB.Location = new System.Drawing.Point(288, 72);
            this.maskedTextBoxSpA_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpA_ParentB.Mask = "00";
            this.maskedTextBoxSpA_ParentB.Name = "maskedTextBoxSpA_ParentB";
            this.maskedTextBoxSpA_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxSpA_ParentB.TabIndex = 54;
            this.maskedTextBoxSpA_ParentB.Tag = "ivs";
            // 
            // maskedTextBoxDef_ParentB
            // 
            this.maskedTextBoxDef_ParentB.Hex = false;
            this.maskedTextBoxDef_ParentB.Location = new System.Drawing.Point(233, 72);
            this.maskedTextBoxDef_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxDef_ParentB.Mask = "00";
            this.maskedTextBoxDef_ParentB.Name = "maskedTextBoxDef_ParentB";
            this.maskedTextBoxDef_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxDef_ParentB.TabIndex = 53;
            this.maskedTextBoxDef_ParentB.Tag = "ivs";
            // 
            // maskedTextBoxAtk_ParentB
            // 
            this.maskedTextBoxAtk_ParentB.Hex = false;
            this.maskedTextBoxAtk_ParentB.Location = new System.Drawing.Point(179, 72);
            this.maskedTextBoxAtk_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxAtk_ParentB.Mask = "00";
            this.maskedTextBoxAtk_ParentB.Name = "maskedTextBoxAtk_ParentB";
            this.maskedTextBoxAtk_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxAtk_ParentB.TabIndex = 52;
            this.maskedTextBoxAtk_ParentB.Tag = "ivs";
            // 
            // maskedTextBoxHP_ParentB
            // 
            this.maskedTextBoxHP_ParentB.Hex = false;
            this.maskedTextBoxHP_ParentB.Location = new System.Drawing.Point(124, 72);
            this.maskedTextBoxHP_ParentB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHP_ParentB.Mask = "00";
            this.maskedTextBoxHP_ParentB.Name = "maskedTextBoxHP_ParentB";
            this.maskedTextBoxHP_ParentB.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxHP_ParentB.TabIndex = 51;
            this.maskedTextBoxHP_ParentB.Tag = "ivs";
            // 
            // buttonRetrieveIVs
            // 
            this.buttonRetrieveIVs.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonRetrieveIVs.ForeColor = System.Drawing.Color.Black;
            this.buttonRetrieveIVs.Location = new System.Drawing.Point(8, 142);
            this.buttonRetrieveIVs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRetrieveIVs.Name = "buttonRetrieveIVs";
            this.buttonRetrieveIVs.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonRetrieveIVs.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonRetrieveIVs.Size = new System.Drawing.Size(217, 26);
            this.buttonRetrieveIVs.TabIndex = 80;
            this.buttonRetrieveIVs.Text = "计算乱数获取的个体";
            this.buttonRetrieveIVs.Click += new System.EventHandler(this.buttonRetrieveIVs_Click);
            // 
            // EggParents
            // 
            this.AcceptButton = this.buttonOk1;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.buttonCancel1;
            this.ClientSize = new System.Drawing.Size(462, 183);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRetrieveIVs);
            this.Controls.Add(this.buttonCancel1);
            this.Controls.Add(this.buttonOk1);
            this.Controls.Add(this.labelIVRNG);
            this.Controls.Add(this.maskedTextBoxSpe_IVRNG);
            this.Controls.Add(this.maskedTextBoxSpD_IVRNG);
            this.Controls.Add(this.maskedTextBoxSpA_IVRNG);
            this.Controls.Add(this.maskedTextBoxDef_IVRNG);
            this.Controls.Add(this.maskedTextBoxAtk_IVRNG);
            this.Controls.Add(this.maskedTextBoxHP_IVRNG);
            this.Controls.Add(this.labelParentA);
            this.Controls.Add(this.labelParentB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxSpe_ParentA);
            this.Controls.Add(this.maskedTextBoxSpD_ParentA);
            this.Controls.Add(this.maskedTextBoxSpA_ParentA);
            this.Controls.Add(this.maskedTextBoxDef_ParentA);
            this.Controls.Add(this.maskedTextBoxAtk_ParentA);
            this.Controls.Add(this.maskedTextBoxHP_ParentA);
            this.Controls.Add(this.maskedTextBoxSpe_ParentB);
            this.Controls.Add(this.maskedTextBoxSpD_ParentB);
            this.Controls.Add(this.maskedTextBoxSpA_ParentB);
            this.Controls.Add(this.maskedTextBoxDef_ParentB);
            this.Controls.Add(this.maskedTextBoxAtk_ParentB);
            this.Controls.Add(this.maskedTextBoxHP_ParentB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(480, 230);
            this.MinimumSize = new System.Drawing.Size(470, 208);
            this.Name = "EggParents";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "显示父母个体值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIVRNG;
        private MaskedTextBox2 maskedTextBoxSpe_IVRNG;
        private MaskedTextBox2 maskedTextBoxSpD_IVRNG;
        private MaskedTextBox2 maskedTextBoxSpA_IVRNG;
        private MaskedTextBox2 maskedTextBoxDef_IVRNG;
        private MaskedTextBox2 maskedTextBoxAtk_IVRNG;
        private MaskedTextBox2 maskedTextBoxHP_IVRNG;
        private System.Windows.Forms.Label labelParentA;
        private System.Windows.Forms.Label labelParentB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaskedTextBox2 maskedTextBoxSpe_ParentA;
        private MaskedTextBox2 maskedTextBoxSpD_ParentA;
        private MaskedTextBox2 maskedTextBoxSpA_ParentA;
        private MaskedTextBox2 maskedTextBoxDef_ParentA;
        private MaskedTextBox2 maskedTextBoxAtk_ParentA;
        private MaskedTextBox2 maskedTextBoxHP_ParentA;
        private MaskedTextBox2 maskedTextBoxSpe_ParentB;
        private MaskedTextBox2 maskedTextBoxSpD_ParentB;
        private MaskedTextBox2 maskedTextBoxSpA_ParentB;
        private MaskedTextBox2 maskedTextBoxDef_ParentB;
        private MaskedTextBox2 maskedTextBoxAtk_ParentB;
        private MaskedTextBox2 maskedTextBoxHP_ParentB;
        private RNGReporter.GlassButton buttonOk1;
        private RNGReporter.GlassButton buttonCancel1;
        private RNGReporter.GlassButton buttonRetrieveIVs;
    }
}
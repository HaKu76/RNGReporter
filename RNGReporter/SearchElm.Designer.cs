﻿using RNGReporter.Controls;

namespace RNGReporter
{
    partial class SearchElm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchElm));
            this.buttonK = new RNGReporter.GlassButton();
            this.buttonE = new RNGReporter.GlassButton();
            this.buttonP = new RNGReporter.GlassButton();
            this.buttonCancel = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.labelKElm = new System.Windows.Forms.Label();
            this.labelEElm = new System.Windows.Forms.Label();
            this.labelPElm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPIrwin = new System.Windows.Forms.Label();
            this.labelEIrwin = new System.Windows.Forms.Label();
            this.labelKIrwin = new System.Windows.Forms.Label();
            this.radioButtonIrwin = new System.Windows.Forms.RadioButton();
            this.radioButtonElm = new System.Windows.Forms.RadioButton();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxResponses = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxRRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxLRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxERoute = new RNGReporter.Controls.MaskedTextBox2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonK.ForeColor = System.Drawing.Color.Black;
            this.buttonK.Location = new System.Drawing.Point(12, 22);
            this.buttonK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonK.Name = "buttonK";
            this.buttonK.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonK.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonK.Size = new System.Drawing.Size(80, 46);
            this.buttonK.TabIndex = 0;
            this.buttonK.Text = "K";
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.ForeColor = System.Drawing.Color.Black;
            this.buttonE.Location = new System.Drawing.Point(100, 22);
            this.buttonE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonE.Name = "buttonE";
            this.buttonE.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonE.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonE.Size = new System.Drawing.Size(80, 46);
            this.buttonE.TabIndex = 7;
            this.buttonE.Text = "E";
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.ForeColor = System.Drawing.Color.Black;
            this.buttonP.Location = new System.Drawing.Point(188, 22);
            this.buttonP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonP.Name = "buttonP";
            this.buttonP.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonP.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonP.Size = new System.Drawing.Size(80, 46);
            this.buttonP.TabIndex = 14;
            this.buttonP.Text = "P";
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(663, 449);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Size = new System.Drawing.Size(100, 26);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "关闭";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(555, 449);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(100, 26);
            this.buttonOk.TabIndex = 49;
            this.buttonOk.Text = "确认结果";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelKElm
            // 
            this.labelKElm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKElm.Location = new System.Drawing.Point(29, 174);
            this.labelKElm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKElm.Name = "labelKElm";
            this.labelKElm.Size = new System.Drawing.Size(696, 48);
            this.labelKElm.TabIndex = 51;
            this.labelKElm.Text = "K - I expect there are some 宝可梦 in the Kanto region that I don\'t know. There are " +
    "probably methods of evolution that I\'m not familiar with yet. I should use that " +
    "perspective and discover what I can!";
            // 
            // labelEElm
            // 
            this.labelEElm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEElm.Location = new System.Drawing.Point(29, 211);
            this.labelEElm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEElm.Name = "labelEElm";
            this.labelEElm.Size = new System.Drawing.Size(699, 35);
            this.labelEElm.TabIndex = 52;
            this.labelEElm.Text = "E - There are so many different ways that 宝可梦 evolve, aren\'t there?! Some Pokémon" +
    " don\'t even evolve until they meet certain conditions first!";
            // 
            // labelPElm
            // 
            this.labelPElm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPElm.Location = new System.Drawing.Point(29, 252);
            this.labelPElm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPElm.Name = "labelPElm";
            this.labelPElm.Size = new System.Drawing.Size(699, 26);
            this.labelPElm.TabIndex = 53;
            this.labelPElm.Text = "P - It seems that 宝可梦 that have been infected with Pokérus level up better. We\'re" +
    " not quite sure why...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 95;
            this.label3.Text = "R";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelPIrwin);
            this.groupBox1.Controls.Add(this.labelEIrwin);
            this.groupBox1.Controls.Add(this.labelKIrwin);
            this.groupBox1.Controls.Add(this.radioButtonIrwin);
            this.groupBox1.Controls.Add(this.radioButtonElm);
            this.groupBox1.Controls.Add(this.labelResults);
            this.groupBox1.Controls.Add(this.textBoxResponses);
            this.groupBox1.Controls.Add(this.buttonE);
            this.groupBox1.Controls.Add(this.buttonK);
            this.groupBox1.Controls.Add(this.labelPElm);
            this.groupBox1.Controls.Add(this.labelEElm);
            this.groupBox1.Controls.Add(this.labelKElm);
            this.groupBox1.Controls.Add(this.buttonP);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(747, 310);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电话回复序列";
            // 
            // labelPIrwin
            // 
            this.labelPIrwin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPIrwin.Location = new System.Drawing.Point(29, 252);
            this.labelPIrwin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPIrwin.Name = "labelPIrwin";
            this.labelPIrwin.Size = new System.Drawing.Size(699, 51);
            this.labelPIrwin.TabIndex = 60;
            this.labelPIrwin.Text = resources.GetString("labelPIrwin.Text");
            this.labelPIrwin.Visible = false;
            // 
            // labelEIrwin
            // 
            this.labelEIrwin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEIrwin.Location = new System.Drawing.Point(29, 211);
            this.labelEIrwin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEIrwin.Name = "labelEIrwin";
            this.labelEIrwin.Size = new System.Drawing.Size(699, 18);
            this.labelEIrwin.TabIndex = 59;
            this.labelEIrwin.Text = "E - Hearing about your escapades rocks my soul! It sure does!";
            this.labelEIrwin.Visible = false;
            // 
            // labelKIrwin
            // 
            this.labelKIrwin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKIrwin.Location = new System.Drawing.Point(29, 174);
            this.labelKIrwin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKIrwin.Name = "labelKIrwin";
            this.labelKIrwin.Size = new System.Drawing.Size(696, 31);
            this.labelKIrwin.TabIndex = 58;
            this.labelKIrwin.Text = "K - I\'m so glad you called! I was just about to call you, too! I guess we must be" +
    " a good match!";
            this.labelKIrwin.Visible = false;
            // 
            // radioButtonIrwin
            // 
            this.radioButtonIrwin.AutoSize = true;
            this.radioButtonIrwin.Location = new System.Drawing.Point(100, 144);
            this.radioButtonIrwin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonIrwin.Name = "radioButtonIrwin";
            this.radioButtonIrwin.Size = new System.Drawing.Size(68, 19);
            this.radioButtonIrwin.TabIndex = 57;
            this.radioButtonIrwin.Text = "Irwin";
            this.radioButtonIrwin.UseVisualStyleBackColor = true;
            this.radioButtonIrwin.CheckedChanged += new System.EventHandler(this.radioButtonIrwin_CheckedChanged);
            // 
            // radioButtonElm
            // 
            this.radioButtonElm.AutoSize = true;
            this.radioButtonElm.Checked = true;
            this.radioButtonElm.Location = new System.Drawing.Point(36, 144);
            this.radioButtonElm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonElm.Name = "radioButtonElm";
            this.radioButtonElm.Size = new System.Drawing.Size(52, 19);
            this.radioButtonElm.TabIndex = 56;
            this.radioButtonElm.TabStop = true;
            this.radioButtonElm.Text = "Elm";
            this.radioButtonElm.UseVisualStyleBackColor = true;
            this.radioButtonElm.CheckedChanged += new System.EventHandler(this.radioButtonElm_CheckedChanged);
            // 
            // labelResults
            // 
            this.labelResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(8, 114);
            this.labelResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(127, 15);
            this.labelResults.TabIndex = 55;
            this.labelResults.Text = "可能的结果数量：";
            // 
            // textBoxResponses
            // 
            this.textBoxResponses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponses.Location = new System.Drawing.Point(8, 75);
            this.textBoxResponses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResponses.Name = "textBoxResponses";
            this.textBoxResponses.Size = new System.Drawing.Size(729, 37);
            this.textBoxResponses.TabIndex = 54;
            this.textBoxResponses.TextChanged += new System.EventHandler(this.textBoxResponses_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBoxRRoute);
            this.groupBox2.Controls.Add(this.maskedTextBoxLRoute);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.maskedTextBoxERoute);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 332);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(745, 104);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "游走位置 (可选)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(31, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 38);
            this.label4.TabIndex = 96;
            this.label4.Text = "为了使搜索更精确，请输入任何游走宝可梦的位置。如果特定宝可梦没有游走，请留空不填。";
            // 
            // maskedTextBoxRRoute
            // 
            this.maskedTextBoxRRoute.Hex = false;
            this.maskedTextBoxRRoute.Location = new System.Drawing.Point(64, 69);
            this.maskedTextBoxRRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxRRoute.Mask = "00";
            this.maskedTextBoxRRoute.Name = "maskedTextBoxRRoute";
            this.maskedTextBoxRRoute.Size = new System.Drawing.Size(25, 23);
            this.maskedTextBoxRRoute.TabIndex = 90;
            this.maskedTextBoxRRoute.ValidatingType = typeof(int);
            this.maskedTextBoxRRoute.TextChanged += new System.EventHandler(this.maskedTextBoxRoute_TextChanged);
            // 
            // maskedTextBoxLRoute
            // 
            this.maskedTextBoxLRoute.Hex = false;
            this.maskedTextBoxLRoute.Location = new System.Drawing.Point(193, 69);
            this.maskedTextBoxLRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxLRoute.Mask = "00";
            this.maskedTextBoxLRoute.Name = "maskedTextBoxLRoute";
            this.maskedTextBoxLRoute.Size = new System.Drawing.Size(25, 23);
            this.maskedTextBoxLRoute.TabIndex = 92;
            this.maskedTextBoxLRoute.ValidatingType = typeof(int);
            this.maskedTextBoxLRoute.TextChanged += new System.EventHandler(this.maskedTextBoxRoute_TextChanged);
            // 
            // maskedTextBoxERoute
            // 
            this.maskedTextBoxERoute.Hex = false;
            this.maskedTextBoxERoute.Location = new System.Drawing.Point(128, 69);
            this.maskedTextBoxERoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxERoute.Mask = "00";
            this.maskedTextBoxERoute.Name = "maskedTextBoxERoute";
            this.maskedTextBoxERoute.Size = new System.Drawing.Size(25, 23);
            this.maskedTextBoxERoute.TabIndex = 91;
            this.maskedTextBoxERoute.ValidatingType = typeof(int);
            this.maskedTextBoxERoute.TextChanged += new System.EventHandler(this.maskedTextBoxRoute_TextChanged);
            // 
            // SearchElm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(779, 489);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchElm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Call Responses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RNGReporter.GlassButton buttonK;
        private RNGReporter.GlassButton buttonE;
        private RNGReporter.GlassButton buttonP;
        private RNGReporter.GlassButton buttonCancel;
        private RNGReporter.GlassButton buttonOk;
        private System.Windows.Forms.Label labelKElm;
        private System.Windows.Forms.Label labelEElm;
        private System.Windows.Forms.Label labelPElm;
        private MaskedTextBox2 maskedTextBoxERoute;
        private MaskedTextBox2 maskedTextBoxRRoute;
        private MaskedTextBox2 maskedTextBoxLRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResponses;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.RadioButton radioButtonElm;
        private System.Windows.Forms.RadioButton radioButtonIrwin;
        private System.Windows.Forms.Label labelPIrwin;
        private System.Windows.Forms.Label labelEIrwin;
        private System.Windows.Forms.Label labelKIrwin;
    }
}
using RNGReporter.Controls;

namespace RNGReporter
{
    partial class SearchRoamers
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
            this.buttonCancel = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxRRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxLRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxERoute = new RNGReporter.Controls.MaskedTextBox2();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(197, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "关闭";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(116, 145);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(75, 21);
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "OK";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 101;
            this.label3.Text = "雷公";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 100;
            this.label2.Text = "炎帝";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 99;
            this.label1.Text = "拉帝欧斯\\拉迪亚斯";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 44);
            this.label4.TabIndex = 102;
            this.label4.Text = "请输入所有游走宝可梦的位置，如果有游走宝可梦没在地图上，则它后面参数不填";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 35);
            this.label5.TabIndex = 103;
            this.label5.Text = "请注意，除非所有三个游走都在地图上，否则此搜索方法将无法100%定位。";
            // 
            // maskedTextBoxRRoute
            // 
            this.maskedTextBoxRRoute.Hex = false;
            this.maskedTextBoxRRoute.Location = new System.Drawing.Point(46, 104);
            this.maskedTextBoxRRoute.Mask = "00";
            this.maskedTextBoxRRoute.Name = "maskedTextBoxRRoute";
            this.maskedTextBoxRRoute.Size = new System.Drawing.Size(20, 19);
            this.maskedTextBoxRRoute.TabIndex = 96;
            this.maskedTextBoxRRoute.ValidatingType = typeof(int);
            // 
            // maskedTextBoxLRoute
            // 
            this.maskedTextBoxLRoute.Hex = false;
            this.maskedTextBoxLRoute.Location = new System.Drawing.Point(234, 104);
            this.maskedTextBoxLRoute.Mask = "00";
            this.maskedTextBoxLRoute.Name = "maskedTextBoxLRoute";
            this.maskedTextBoxLRoute.Size = new System.Drawing.Size(20, 19);
            this.maskedTextBoxLRoute.TabIndex = 98;
            this.maskedTextBoxLRoute.ValidatingType = typeof(int);
            // 
            // maskedTextBoxERoute
            // 
            this.maskedTextBoxERoute.Hex = false;
            this.maskedTextBoxERoute.Location = new System.Drawing.Point(101, 104);
            this.maskedTextBoxERoute.Mask = "00";
            this.maskedTextBoxERoute.Name = "maskedTextBoxERoute";
            this.maskedTextBoxERoute.Size = new System.Drawing.Size(20, 19);
            this.maskedTextBoxERoute.TabIndex = 97;
            this.maskedTextBoxERoute.ValidatingType = typeof(int);
            // 
            // SearchRoamers
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxRRoute);
            this.Controls.Add(this.maskedTextBoxLRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxERoute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchRoamers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通过游走神兽来反查搜索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RNGReporter.GlassButton buttonCancel;
        private RNGReporter.GlassButton buttonOk;
        private MaskedTextBox2 maskedTextBoxRRoute;
        private MaskedTextBox2 maskedTextBoxLRoute;
        private System.Windows.Forms.Label label3;
        private MaskedTextBox2 maskedTextBoxERoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
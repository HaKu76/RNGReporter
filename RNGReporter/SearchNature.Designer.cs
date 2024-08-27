namespace RNGReporter
{
    partial class SearchNature
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
            this.comboBoxNature1 = new RNGReporter.GlassComboBox();
            this.comboBoxNature2 = new RNGReporter.GlassComboBox();
            this.comboBoxNature3 = new RNGReporter.GlassComboBox();
            this.buttonCancel = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNature1
            // 
            this.comboBoxNature1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNature1.FormattingEnabled = true;
            this.comboBoxNature1.Location = new System.Drawing.Point(70, 15);
            this.comboBoxNature1.Name = "comboBoxNature1";
            this.comboBoxNature1.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxNature1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxNature1.TabIndex = 1;
            // 
            // comboBoxNature2
            // 
            this.comboBoxNature2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNature2.FormattingEnabled = true;
            this.comboBoxNature2.Location = new System.Drawing.Point(70, 40);
            this.comboBoxNature2.Name = "comboBoxNature2";
            this.comboBoxNature2.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxNature2.Size = new System.Drawing.Size(121, 20);
            this.comboBoxNature2.TabIndex = 3;
            // 
            // comboBoxNature3
            // 
            this.comboBoxNature3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNature3.FormattingEnabled = true;
            this.comboBoxNature3.Location = new System.Drawing.Point(70, 65);
            this.comboBoxNature3.Name = "comboBoxNature3";
            this.comboBoxNature3.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxNature3.Size = new System.Drawing.Size(121, 20);
            this.comboBoxNature3.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(136, 112);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "关闭";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(55, 112);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(75, 21);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "确认";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "性格1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性格2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性格3";
            // 
            // SearchNature
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(223, 144);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxNature3);
            this.Controls.Add(this.comboBoxNature2);
            this.Controls.Add(this.comboBoxNature1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchNature";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "计算性格";
            this.Load += new System.EventHandler(this.SearchNature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RNGReporter.GlassComboBox comboBoxNature1;
        private RNGReporter.GlassComboBox comboBoxNature2;
        private RNGReporter.GlassComboBox comboBoxNature3;
        private RNGReporter.GlassButton buttonCancel;
        private RNGReporter.GlassButton buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
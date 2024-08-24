namespace RNGReporter
{
    partial class thirdGenSeedToTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonGenerate = new RNGReporter.GlassButton();
            this.dataGridViewValues = new RNGReporter.DoubleBufferedDataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedToTimeSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxYear = new RNGReporter.Controls.MaskedTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 10);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "16/32位 Seed";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerate.Location = new System.Drawing.Point(425, 91);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonGenerate.Size = new System.Drawing.Size(100, 26);
            this.buttonGenerate.TabIndex = 46;
            this.buttonGenerate.Text = "计算";
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.AllowUserToResizeRows = false;
            this.dataGridViewValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Seconds});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValues.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewValues.Location = new System.Drawing.Point(16, 121);
            this.dataGridViewValues.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewValues.MultiSelect = false;
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewValues.RowHeadersVisible = false;
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValues.ShowCellErrors = false;
            this.dataGridViewValues.ShowCellToolTips = false;
            this.dataGridViewValues.ShowEditingIcon = false;
            this.dataGridViewValues.ShowRowErrors = false;
            this.dataGridViewValues.Size = new System.Drawing.Size(509, 312);
            this.dataGridViewValues.TabIndex = 45;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle6.Format = "X";
            this.Time.DefaultCellStyle = dataGridViewCellStyle6;
            this.Time.HeaderText = "时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // Seconds
            // 
            this.Seconds.DataPropertyName = "Seconds";
            this.Seconds.HeaderText = "秒数";
            this.Seconds.MinimumWidth = 6;
            this.Seconds.Name = "Seconds";
            this.Seconds.ReadOnly = true;
            this.Seconds.Width = 95;
            // 
            // seedToTimeSeed
            // 
            this.seedToTimeSeed.Hex = true;
            this.seedToTimeSeed.Location = new System.Drawing.Point(137, 8);
            this.seedToTimeSeed.Margin = new System.Windows.Forms.Padding(4);
            this.seedToTimeSeed.Mask = "AAAAAAAA";
            this.seedToTimeSeed.Name = "seedToTimeSeed";
            this.seedToTimeSeed.Size = new System.Drawing.Size(77, 23);
            this.seedToTimeSeed.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "此功能仅适用于有电时钟的红/蓝宝石";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Hex = true;
            this.maskedTextBoxYear.Location = new System.Drawing.Point(137, 38);
            this.maskedTextBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxYear.Mask = "AAAA";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(77, 23);
            this.maskedTextBoxYear.TabIndex = 48;
            this.maskedTextBoxYear.Text = "2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "年份";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "输入16位的seed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "或32位seed，用于查找最接近的16位来匹配";
            // 
            // thirdGenSeedToTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.seedToTimeSeed);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "thirdGenSeedToTime";
            this.Text = "Seed to Time（有电红/蓝宝石）";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private Controls.MaskedTextBox2 seedToTimeSeed;
        private DoubleBufferedDataGridView dataGridViewValues;
        private GlassButton buttonGenerate;
        private System.Windows.Forms.Label label1;
        private Controls.MaskedTextBox2 maskedTextBoxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seconds;
    }
}
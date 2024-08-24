using RNGReporter.Controls;

namespace RNGReporter
{
    partial class SeedToTimeEgg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFlipsForSeed = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSearchFlips = new RNGReporter.GlassButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateAdjacents = new RNGReporter.GlassButton();
            this.dataGridViewAdjacents = new RNGReporter.DoubleBufferedDataGridView();
            this.AdjacentSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlipSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.maskedTextBoxPSecond = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxPDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMSecond = new RNGReporter.Controls.MaskedTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTargetTime = new System.Windows.Forms.Label();
            this.labelTaps = new System.Windows.Forms.Label();
            this.labelFlips = new System.Windows.Forms.Label();
            this.labelSeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacents)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFlipsForSeed
            // 
            this.labelFlipsForSeed.AutoSize = true;
            this.labelFlipsForSeed.Location = new System.Drawing.Point(172, 32);
            this.labelFlipsForSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlipsForSeed.Name = "labelFlipsForSeed";
            this.labelFlipsForSeed.Size = new System.Drawing.Size(31, 15);
            this.labelFlipsForSeed.TabIndex = 41;
            this.labelFlipsForSeed.Text = "000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "投硬币获取Seed:";
            // 
            // buttonSearchFlips
            // 
            this.buttonSearchFlips.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSearchFlips.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchFlips.Location = new System.Drawing.Point(435, 158);
            this.buttonSearchFlips.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearchFlips.Name = "buttonSearchFlips";
            this.buttonSearchFlips.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearchFlips.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonSearchFlips.Size = new System.Drawing.Size(100, 27);
            this.buttonSearchFlips.TabIndex = 37;
            this.buttonSearchFlips.Text = "Search Flips";
            this.buttonSearchFlips.Click += new System.EventHandler(this.buttonSearchFlips_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Delays";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "秒数";
            // 
            // buttonGenerateAdjacents
            // 
            this.buttonGenerateAdjacents.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonGenerateAdjacents.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateAdjacents.Location = new System.Drawing.Point(543, 158);
            this.buttonGenerateAdjacents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGenerateAdjacents.Name = "buttonGenerateAdjacents";
            this.buttonGenerateAdjacents.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonGenerateAdjacents.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonGenerateAdjacents.Size = new System.Drawing.Size(100, 27);
            this.buttonGenerateAdjacents.TabIndex = 38;
            this.buttonGenerateAdjacents.Text = "计算";
            this.buttonGenerateAdjacents.Click += new System.EventHandler(this.buttonGenerateAdjacents_Click);
            // 
            // dataGridViewAdjacents
            // 
            this.dataGridViewAdjacents.AllowUserToAddRows = false;
            this.dataGridViewAdjacents.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacents.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAdjacents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdjacentSeed,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ColumnFlipSequence});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdjacents.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAdjacents.Location = new System.Drawing.Point(16, 197);
            this.dataGridViewAdjacents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewAdjacents.MultiSelect = false;
            this.dataGridViewAdjacents.Name = "dataGridViewAdjacents";
            this.dataGridViewAdjacents.ReadOnly = true;
            this.dataGridViewAdjacents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAdjacents.RowHeadersVisible = false;
            this.dataGridViewAdjacents.RowHeadersWidth = 51;
            this.dataGridViewAdjacents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdjacents.ShowCellErrors = false;
            this.dataGridViewAdjacents.ShowCellToolTips = false;
            this.dataGridViewAdjacents.ShowEditingIcon = false;
            this.dataGridViewAdjacents.ShowRowErrors = false;
            this.dataGridViewAdjacents.Size = new System.Drawing.Size(627, 166);
            this.dataGridViewAdjacents.TabIndex = 39;
            // 
            // AdjacentSeed
            // 
            this.AdjacentSeed.DataPropertyName = "Seed";
            this.AdjacentSeed.HeaderText = "Seed";
            this.AdjacentSeed.MinimumWidth = 6;
            this.AdjacentSeed.Name = "AdjacentSeed";
            this.AdjacentSeed.ReadOnly = true;
            this.AdjacentSeed.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DisplayDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DisplayTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Delay";
            this.dataGridViewTextBoxColumn3.HeaderText = "Delay";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // ColumnFlipSequence
            // 
            this.ColumnFlipSequence.DataPropertyName = "Flips";
            this.ColumnFlipSequence.HeaderText = "Flip Sequence";
            this.ColumnFlipSequence.MinimumWidth = 6;
            this.ColumnFlipSequence.Name = "ColumnFlipSequence";
            this.ColumnFlipSequence.ReadOnly = true;
            this.ColumnFlipSequence.Width = 165;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(543, 370);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Size = new System.Drawing.Size(100, 27);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(435, 370);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(100, 27);
            this.buttonOk.TabIndex = 42;
            this.buttonOk.Text = "OK";
            // 
            // maskedTextBoxPSecond
            // 
            this.maskedTextBoxPSecond.Hex = false;
            this.maskedTextBoxPSecond.Location = new System.Drawing.Point(339, 160);
            this.maskedTextBoxPSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPSecond.Mask = "0";
            this.maskedTextBoxPSecond.Name = "maskedTextBoxPSecond";
            this.maskedTextBoxPSecond.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxPSecond.TabIndex = 36;
            this.maskedTextBoxPSecond.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxMDelay
            // 
            this.maskedTextBoxMDelay.Hex = false;
            this.maskedTextBoxMDelay.Location = new System.Drawing.Point(76, 160);
            this.maskedTextBoxMDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMDelay.Mask = "00";
            this.maskedTextBoxMDelay.Name = "maskedTextBoxMDelay";
            this.maskedTextBoxMDelay.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMDelay.TabIndex = 29;
            this.maskedTextBoxMDelay.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPDelay
            // 
            this.maskedTextBoxPDelay.Hex = false;
            this.maskedTextBoxPDelay.Location = new System.Drawing.Point(137, 160);
            this.maskedTextBoxPDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPDelay.Mask = "00";
            this.maskedTextBoxPDelay.Name = "maskedTextBoxPDelay";
            this.maskedTextBoxPDelay.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxPDelay.TabIndex = 31;
            // 
            // maskedTextBoxMSecond
            // 
            this.maskedTextBoxMSecond.Hex = false;
            this.maskedTextBoxMSecond.Location = new System.Drawing.Point(276, 160);
            this.maskedTextBoxMSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMSecond.Mask = "0";
            this.maskedTextBoxMSecond.Name = "maskedTextBoxMSecond";
            this.maskedTextBoxMSecond.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMSecond.TabIndex = 34;
            this.maskedTextBoxMSecond.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "目标时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "目标Seed：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Happiness Taps:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Remaining Coin Flips:";
            // 
            // labelTargetTime
            // 
            this.labelTargetTime.AutoSize = true;
            this.labelTargetTime.Location = new System.Drawing.Point(173, 12);
            this.labelTargetTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTargetTime.Name = "labelTargetTime";
            this.labelTargetTime.Size = new System.Drawing.Size(31, 15);
            this.labelTargetTime.TabIndex = 47;
            this.labelTargetTime.Text = "000";
            // 
            // labelTaps
            // 
            this.labelTaps.AutoSize = true;
            this.labelTaps.Location = new System.Drawing.Point(173, 53);
            this.labelTaps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaps.Name = "labelTaps";
            this.labelTaps.Size = new System.Drawing.Size(31, 15);
            this.labelTaps.TabIndex = 48;
            this.labelTaps.Text = "000";
            // 
            // labelFlips
            // 
            this.labelFlips.AutoSize = true;
            this.labelFlips.Location = new System.Drawing.Point(173, 74);
            this.labelFlips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlips.Name = "labelFlips";
            this.labelFlips.Size = new System.Drawing.Size(31, 15);
            this.labelFlips.TabIndex = 49;
            this.labelFlips.Text = "000";
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Location = new System.Drawing.Point(173, 112);
            this.labelSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(31, 15);
            this.labelSeed.TabIndex = 50;
            this.labelSeed.Text = "000";
            // 
            // SeedToTimeEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 406);
            this.ControlBox = false;
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.labelFlips);
            this.Controls.Add(this.labelTaps);
            this.Controls.Add(this.labelTargetTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFlipsForSeed);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonSearchFlips);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxPSecond);
            this.Controls.Add(this.maskedTextBoxMDelay);
            this.Controls.Add(this.maskedTextBoxPDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxMSecond);
            this.Controls.Add(this.buttonGenerateAdjacents);
            this.Controls.Add(this.dataGridViewAdjacents);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SeedToTimeEgg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seed to Time";
            this.Load += new System.EventHandler(this.SeedToTimeEgg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFlipsForSeed;
        private System.Windows.Forms.Label label17;
        private RNGReporter.GlassButton buttonSearchFlips;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaskedTextBox2 maskedTextBoxPSecond;
        private MaskedTextBox2 maskedTextBoxMDelay;
        private MaskedTextBox2 maskedTextBoxPDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MaskedTextBox2 maskedTextBoxMSecond;
        private RNGReporter.GlassButton buttonGenerateAdjacents;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewAdjacents;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjacentSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlipSequence;
        private RNGReporter.GlassButton buttonCancel;
        private RNGReporter.GlassButton buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTargetTime;
        private System.Windows.Forms.Label labelTaps;
        private System.Windows.Forms.Label labelFlips;
        private System.Windows.Forms.Label labelSeed;
    }
}
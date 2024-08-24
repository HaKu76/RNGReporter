namespace RNGReporter
{
    partial class GameCubeRTC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.Label();
            this.cancel = new RNGReporter.GlassButton();
            this.buttonSearch = new RNGReporter.GlassButton();
            this.dataGridViewValues = new RNGReporter.DoubleBufferedDataGridView();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeed = new System.Windows.Forms.ToolStripMenuItem();
            this.maxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.minFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.targetSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.initialSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "在2000年1月1日00:00:00时的Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "目标seed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(277, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "最小帧";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(277, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "最大帧";
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchText.AutoSize = true;
            this.searchText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.searchText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchText.Location = new System.Drawing.Point(16, 229);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(91, 15);
            this.searchText.TabIndex = 49;
            this.searchText.Text = "等待操作...";
            this.searchText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel.Location = new System.Drawing.Point(454, 93);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel.Name = "cancel";
            this.cancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.cancel.ShineColor = System.Drawing.SystemColors.Window;
            this.cancel.Size = new System.Drawing.Size(88, 27);
            this.cancel.TabIndex = 50;
            this.cancel.Text = "取消计算";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(377, 93);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonSearch.Size = new System.Drawing.Size(69, 27);
            this.buttonSearch.TabIndex = 48;
            this.buttonSearch.Text = "计算";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.AllowUserToResizeRows = false;
            this.dataGridViewValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Frame,
            this.Seed});
            this.dataGridViewValues.ContextMenuStrip = this.contextMenuStripGrid;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValues.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewValues.Location = new System.Drawing.Point(20, 127);
            this.dataGridViewValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewValues.MultiSelect = false;
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewValues.RowHeadersVisible = false;
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValues.ShowCellErrors = false;
            this.dataGridViewValues.ShowCellToolTips = false;
            this.dataGridViewValues.ShowEditingIcon = false;
            this.dataGridViewValues.ShowRowErrors = false;
            this.dataGridViewValues.Size = new System.Drawing.Size(521, 98);
            this.dataGridViewValues.TabIndex = 46;
            this.dataGridViewValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewValues_MouseDown);
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeed});
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(199, 28);
            this.contextMenuStripGrid.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripGrid_Opening);
            // 
            // copySeed
            // 
            this.copySeed.Name = "copySeed";
            this.copySeed.Size = new System.Drawing.Size(198, 24);
            this.copySeed.Text = "复制种子到剪贴板";
            this.copySeed.Click += new System.EventHandler(this.copySeedToClipboard_Click);
            // 
            // maxFrame
            // 
            this.maxFrame.Hex = false;
            this.maxFrame.Location = new System.Drawing.Point(280, 59);
            this.maxFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxFrame.Mask = "0000000";
            this.maxFrame.Name = "maxFrame";
            this.maxFrame.Size = new System.Drawing.Size(67, 22);
            this.maxFrame.TabIndex = 25;
            this.maxFrame.Text = "1000000";
            this.maxFrame.ValidatingType = typeof(int);
            // 
            // minFrame
            // 
            this.minFrame.Hex = false;
            this.minFrame.Location = new System.Drawing.Point(280, 14);
            this.minFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minFrame.Mask = "0000000";
            this.minFrame.Name = "minFrame";
            this.minFrame.Size = new System.Drawing.Size(67, 22);
            this.minFrame.TabIndex = 24;
            this.minFrame.Text = "500000";
            this.minFrame.ValidatingType = typeof(int);
            // 
            // targetSeed
            // 
            this.targetSeed.Hex = true;
            this.targetSeed.Location = new System.Drawing.Point(20, 59);
            this.targetSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.targetSeed.Mask = "AAAAAAAA";
            this.targetSeed.Name = "targetSeed";
            this.targetSeed.Size = new System.Drawing.Size(127, 22);
            this.targetSeed.TabIndex = 9;
            // 
            // initialSeed
            // 
            this.initialSeed.Hex = true;
            this.initialSeed.Location = new System.Drawing.Point(20, 14);
            this.initialSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.initialSeed.Mask = "AAAAAAAA";
            this.initialSeed.Name = "initialSeed";
            this.initialSeed.Size = new System.Drawing.Size(127, 22);
            this.initialSeed.TabIndex = 8;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "X";
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.HeaderText = "时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
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
            // Seed
            // 
            this.Seed.DataPropertyName = "Seed";
            this.Seed.HeaderText = "Seed";
            this.Seed.MinimumWidth = 6;
            this.Seed.Name = "Seed";
            this.Seed.ReadOnly = true;
            this.Seed.Width = 125;
            // 
            // GameCubeRTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxFrame);
            this.Controls.Add(this.minFrame);
            this.Controls.Add(this.targetSeed);
            this.Controls.Add(this.initialSeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GameCubeRTC";
            this.Text = "NGC RTC 时间计算";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameCubeRTC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MaskedTextBox2 initialSeed;
        private Controls.MaskedTextBox2 targetSeed;
        private Controls.MaskedTextBox2 minFrame;
        private Controls.MaskedTextBox2 maxFrame;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem copySeed;
        private DoubleBufferedDataGridView dataGridViewValues;
        private GlassButton buttonSearch;
        private System.Windows.Forms.Label searchText;
        private GlassButton cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seed;
    }
}
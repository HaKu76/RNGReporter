using RNGReporter.Controls;

namespace RNGReporter
{
    partial class SeedToTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCancel = new RNGReporter.GlassButton();
            this.buttonOk = new RNGReporter.GlassButton();
            this.textBoxSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonGenerate = new RNGReporter.GlassButton();
            this.dataGridViewValues = new RNGReporter.DoubleBufferedDataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxLockSeconds = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAdjacents = new RNGReporter.DoubleBufferedDataGridView();
            this.AdjacentSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlipSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnElmResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoamers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGen5IVs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCGearAdjust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripAdjacents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTXTFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGenerateAdjacents = new RNGReporter.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSearch = new RNGReporter.GlassButton();
            this.labelFlipsElmsForSeed = new System.Windows.Forms.Label();
            this.labelVerificationType = new System.Windows.Forms.Label();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.radioBtnDPPt = new System.Windows.Forms.RadioButton();
            this.radioBtnHgSs = new System.Windows.Forms.RadioButton();
            this.checkBoxEPresent = new System.Windows.Forms.CheckBox();
            this.checkBoxRPresent = new System.Windows.Forms.CheckBox();
            this.checkBoxLPresent = new System.Windows.Forms.CheckBox();
            this.labelRoamerRoutes = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonRoamerMap = new RNGReporter.GlassButton();
            this.checkBoxOddEven = new System.Windows.Forms.CheckBox();
            this.radioBtnBW = new System.Windows.Forms.RadioButton();
            this.labelMAC = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelMaxFrame = new System.Windows.Forms.Label();
            this.labelMinFrame = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxRoamer = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxMaxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMinFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxERoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxRRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxLRoute = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxPSecond = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxPDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMSecond = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSeconds = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxYear = new RNGReporter.Controls.MaskedTextBox2();
            this.buttonSearchRoamers = new RNGReporter.GlassButton();
            this.comboBoxProfiles = new RNGReporter.GlassComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacents)).BeginInit();
            this.contextMenuStripAdjacents.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(779, 598);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Size = new System.Drawing.Size(100, 27);
            this.buttonCancel.TabIndex = 38;
            this.buttonCancel.Text = "关闭";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(671, 598);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonOk.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonOk.Size = new System.Drawing.Size(100, 27);
            this.buttonOk.TabIndex = 37;
            this.buttonOk.Text = "OK";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Hex = false;
            this.textBoxSeed.Location = new System.Drawing.Point(101, 24);
            this.textBoxSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSeed.Mask = "AAAAAAAA";
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(200, 22);
            this.textBoxSeed.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seed（Hex）";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 7);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "年份";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerate.Location = new System.Drawing.Point(776, 51);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonGenerate.Size = new System.Drawing.Size(100, 27);
            this.buttonGenerate.TabIndex = 14;
            this.buttonGenerate.Text = "计算";
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.AllowUserToResizeRows = false;
            this.dataGridViewValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Delay});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValues.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewValues.Location = new System.Drawing.Point(16, 147);
            this.dataGridViewValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewValues.MultiSelect = false;
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.ReadOnly = true;
            this.dataGridViewValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewValues.RowHeadersVisible = false;
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.RowTemplate.Height = 20;
            this.dataGridViewValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValues.ShowCellErrors = false;
            this.dataGridViewValues.ShowCellToolTips = false;
            this.dataGridViewValues.ShowEditingIcon = false;
            this.dataGridViewValues.ShowRowErrors = false;
            this.dataGridViewValues.Size = new System.Drawing.Size(863, 138);
            this.dataGridViewValues.TabIndex = 15;
            this.dataGridViewValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewValues_MouseDown);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "DisplayDate";
            this.Date.HeaderText = "日期";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "DisplayTime";
            this.Time.HeaderText = "时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 80;
            // 
            // Delay
            // 
            this.Delay.DataPropertyName = "Delay";
            this.Delay.HeaderText = "Delay";
            this.Delay.MinimumWidth = 6;
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            this.Delay.Width = 60;
            // 
            // checkBoxLockSeconds
            // 
            this.checkBoxLockSeconds.AutoSize = true;
            this.checkBoxLockSeconds.Location = new System.Drawing.Point(389, 28);
            this.checkBoxLockSeconds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxLockSeconds.Name = "checkBoxLockSeconds";
            this.checkBoxLockSeconds.Size = new System.Drawing.Size(18, 17);
            this.checkBoxLockSeconds.TabIndex = 4;
            this.checkBoxLockSeconds.UseVisualStyleBackColor = true;
            this.checkBoxLockSeconds.CheckedChanged += new System.EventHandler(this.checkBoxLockSeconds_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "秒数";
            // 
            // dataGridViewAdjacents
            // 
            this.dataGridViewAdjacents.AllowUserToAddRows = false;
            this.dataGridViewAdjacents.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacents.AllowUserToResizeRows = false;
            this.dataGridViewAdjacents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewAdjacents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdjacentSeed,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ColumnFlipSequence,
            this.ColumnElmResponse,
            this.ColumnRoamers,
            this.ColumnGen5IVs,
            this.ColumnCGearAdjust});
            this.dataGridViewAdjacents.ContextMenuStrip = this.contextMenuStripAdjacents;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdjacents.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewAdjacents.Location = new System.Drawing.Point(16, 373);
            this.dataGridViewAdjacents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewAdjacents.MultiSelect = false;
            this.dataGridViewAdjacents.Name = "dataGridViewAdjacents";
            this.dataGridViewAdjacents.ReadOnly = true;
            this.dataGridViewAdjacents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacents.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewAdjacents.RowHeadersVisible = false;
            this.dataGridViewAdjacents.RowHeadersWidth = 51;
            this.dataGridViewAdjacents.RowTemplate.Height = 20;
            this.dataGridViewAdjacents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdjacents.ShowCellErrors = false;
            this.dataGridViewAdjacents.ShowCellToolTips = false;
            this.dataGridViewAdjacents.ShowEditingIcon = false;
            this.dataGridViewAdjacents.ShowRowErrors = false;
            this.dataGridViewAdjacents.Size = new System.Drawing.Size(863, 217);
            this.dataGridViewAdjacents.TabIndex = 30;
            this.dataGridViewAdjacents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewAdjacents_KeyUp);
            this.dataGridViewAdjacents.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAdjacents_MouseDown);
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
            this.dataGridViewTextBoxColumn1.HeaderText = "日期";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DisplayTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "时间";
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
            this.ColumnFlipSequence.HeaderText = "掷硬币序列";
            this.ColumnFlipSequence.MinimumWidth = 6;
            this.ColumnFlipSequence.Name = "ColumnFlipSequence";
            this.ColumnFlipSequence.ReadOnly = true;
            this.ColumnFlipSequence.Width = 210;
            // 
            // ColumnElmResponse
            // 
            this.ColumnElmResponse.DataPropertyName = "ElmResponses";
            this.ColumnElmResponse.HeaderText = "打电话序列";
            this.ColumnElmResponse.MinimumWidth = 6;
            this.ColumnElmResponse.Name = "ColumnElmResponse";
            this.ColumnElmResponse.ReadOnly = true;
            this.ColumnElmResponse.Visible = false;
            this.ColumnElmResponse.Width = 225;
            // 
            // ColumnRoamers
            // 
            this.ColumnRoamers.DataPropertyName = "RoamerLocations";
            this.ColumnRoamers.HeaderText = "游走位置";
            this.ColumnRoamers.MinimumWidth = 6;
            this.ColumnRoamers.Name = "ColumnRoamers";
            this.ColumnRoamers.ReadOnly = true;
            this.ColumnRoamers.Visible = false;
            this.ColumnRoamers.Width = 125;
            // 
            // ColumnGen5IVs
            // 
            this.ColumnGen5IVs.DataPropertyName = "IVs";
            this.ColumnGen5IVs.HeaderText = "个体值（黑&白）";
            this.ColumnGen5IVs.MinimumWidth = 6;
            this.ColumnGen5IVs.Name = "ColumnGen5IVs";
            this.ColumnGen5IVs.ReadOnly = true;
            this.ColumnGen5IVs.Visible = false;
            this.ColumnGen5IVs.Width = 200;
            // 
            // ColumnCGearAdjust
            // 
            this.ColumnCGearAdjust.DataPropertyName = "CGearAdjust";
            this.ColumnCGearAdjust.HeaderText = "C-装置Seed显示";
            this.ColumnCGearAdjust.MinimumWidth = 6;
            this.ColumnCGearAdjust.Name = "ColumnCGearAdjust";
            this.ColumnCGearAdjust.ReadOnly = true;
            this.ColumnCGearAdjust.Visible = false;
            this.ColumnCGearAdjust.Width = 150;
            // 
            // contextMenuStripAdjacents
            // 
            this.contextMenuStripAdjacents.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAdjacents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.generateTXTFileToolStripMenuItem});
            this.contextMenuStripAdjacents.Name = "contextMenuStripAdjacents";
            this.contextMenuStripAdjacents.Size = new System.Drawing.Size(242, 58);
            this.contextMenuStripAdjacents.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAdjacents_Opening);
            // 
            // copySeedToClipboardToolStripMenuItem
            // 
            this.copySeedToClipboardToolStripMenuItem.Name = "copySeedToClipboardToolStripMenuItem";
            this.copySeedToClipboardToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.copySeedToClipboardToolStripMenuItem.Text = "复制Seed到剪贴板";
            this.copySeedToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySeedToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // generateTXTFileToolStripMenuItem
            // 
            this.generateTXTFileToolStripMenuItem.Name = "generateTXTFileToolStripMenuItem";
            this.generateTXTFileToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.generateTXTFileToolStripMenuItem.Text = "输出结果至TXT文本文件";
            this.generateTXTFileToolStripMenuItem.Click += new System.EventHandler(this.generateTXTFileToolStripMenuItem_Click);
            // 
            // buttonGenerateAdjacents
            // 
            this.buttonGenerateAdjacents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateAdjacents.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonGenerateAdjacents.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateAdjacents.Location = new System.Drawing.Point(776, 294);
            this.buttonGenerateAdjacents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGenerateAdjacents.Name = "buttonGenerateAdjacents";
            this.buttonGenerateAdjacents.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonGenerateAdjacents.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonGenerateAdjacents.Size = new System.Drawing.Size(100, 27);
            this.buttonGenerateAdjacents.TabIndex = 27;
            this.buttonGenerateAdjacents.Text = "计算";
            this.buttonGenerateAdjacents.Click += new System.EventHandler(this.buttonGenerateAdjacents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "秒数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Delays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "-";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(628, 294);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonSearch.Size = new System.Drawing.Size(140, 27);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "掷硬币反查";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchFlips_Click);
            // 
            // labelFlipsElmsForSeed
            // 
            this.labelFlipsElmsForSeed.AutoSize = true;
            this.labelFlipsElmsForSeed.Location = new System.Drawing.Point(224, 102);
            this.labelFlipsElmsForSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlipsElmsForSeed.Name = "labelFlipsElmsForSeed";
            this.labelFlipsElmsForSeed.Size = new System.Drawing.Size(0, 15);
            this.labelFlipsElmsForSeed.TabIndex = 18;
            // 
            // labelVerificationType
            // 
            this.labelVerificationType.Location = new System.Drawing.Point(40, 102);
            this.labelVerificationType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificationType.Name = "labelVerificationType";
            this.labelVerificationType.Size = new System.Drawing.Size(102, 15);
            this.labelVerificationType.TabIndex = 17;
            this.labelVerificationType.Text = "掷硬币序列：";
            this.labelVerificationType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioBtnDPPt
            // 
            this.radioBtnDPPt.AutoSize = true;
            this.radioBtnDPPt.Location = new System.Drawing.Point(168, 57);
            this.radioBtnDPPt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnDPPt.Name = "radioBtnDPPt";
            this.radioBtnDPPt.Size = new System.Drawing.Size(60, 19);
            this.radioBtnDPPt.TabIndex = 8;
            this.radioBtnDPPt.Text = "DPPt";
            this.radioBtnDPPt.UseVisualStyleBackColor = true;
            this.radioBtnDPPt.CheckedChanged += new System.EventHandler(this.radioBtnDPPt_CheckedChanged);
            // 
            // radioBtnHgSs
            // 
            this.radioBtnHgSs.AutoSize = true;
            this.radioBtnHgSs.Location = new System.Drawing.Point(236, 57);
            this.radioBtnHgSs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnHgSs.Name = "radioBtnHgSs";
            this.radioBtnHgSs.Size = new System.Drawing.Size(60, 19);
            this.radioBtnHgSs.TabIndex = 9;
            this.radioBtnHgSs.Text = "HGSS";
            this.radioBtnHgSs.UseVisualStyleBackColor = true;
            this.radioBtnHgSs.CheckedChanged += new System.EventHandler(this.radioBtnHgSs_CheckedChanged);
            // 
            // checkBoxEPresent
            // 
            this.checkBoxEPresent.AutoSize = true;
            this.checkBoxEPresent.Location = new System.Drawing.Point(479, 55);
            this.checkBoxEPresent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEPresent.Name = "checkBoxEPresent";
            this.checkBoxEPresent.Size = new System.Drawing.Size(59, 19);
            this.checkBoxEPresent.TabIndex = 12;
            this.checkBoxEPresent.Text = "炎帝";
            this.checkBoxEPresent.UseVisualStyleBackColor = true;
            // 
            // checkBoxRPresent
            // 
            this.checkBoxRPresent.AutoSize = true;
            this.checkBoxRPresent.Location = new System.Drawing.Point(377, 55);
            this.checkBoxRPresent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRPresent.Name = "checkBoxRPresent";
            this.checkBoxRPresent.Size = new System.Drawing.Size(59, 19);
            this.checkBoxRPresent.TabIndex = 10;
            this.checkBoxRPresent.Text = "雷公";
            this.checkBoxRPresent.UseVisualStyleBackColor = true;
            // 
            // checkBoxLPresent
            // 
            this.checkBoxLPresent.AutoSize = true;
            this.checkBoxLPresent.Location = new System.Drawing.Point(581, 55);
            this.checkBoxLPresent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxLPresent.Name = "checkBoxLPresent";
            this.checkBoxLPresent.Size = new System.Drawing.Size(157, 19);
            this.checkBoxLPresent.TabIndex = 14;
            this.checkBoxLPresent.Text = "拉帝欧斯/拉帝亚斯";
            this.checkBoxLPresent.UseVisualStyleBackColor = true;
            // 
            // labelRoamerRoutes
            // 
            this.labelRoamerRoutes.AutoSize = true;
            this.labelRoamerRoutes.Location = new System.Drawing.Point(224, 123);
            this.labelRoamerRoutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoamerRoutes.Name = "labelRoamerRoutes";
            this.labelRoamerRoutes.Size = new System.Drawing.Size(0, 15);
            this.labelRoamerRoutes.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 125);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 15);
            this.label18.TabIndex = 19;
            this.label18.Text = "游走宝可梦位置：";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRoamerMap
            // 
            this.buttonRoamerMap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonRoamerMap.ForeColor = System.Drawing.Color.Black;
            this.buttonRoamerMap.Location = new System.Drawing.Point(313, 51);
            this.buttonRoamerMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRoamerMap.Name = "buttonRoamerMap";
            this.buttonRoamerMap.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonRoamerMap.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonRoamerMap.Size = new System.Drawing.Size(60, 27);
            this.buttonRoamerMap.TabIndex = 10;
            this.buttonRoamerMap.Text = "地图";
            this.buttonRoamerMap.Click += new System.EventHandler(this.buttonRoamerMap_Click);
            // 
            // checkBoxOddEven
            // 
            this.checkBoxOddEven.AutoSize = true;
            this.checkBoxOddEven.Location = new System.Drawing.Point(51, 343);
            this.checkBoxOddEven.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxOddEven.Name = "checkBoxOddEven";
            this.checkBoxOddEven.Size = new System.Drawing.Size(266, 19);
            this.checkBoxOddEven.TabIndex = 18;
            this.checkBoxOddEven.Text = "筛选与seed的delay相同奇偶的结果";
            this.checkBoxOddEven.UseVisualStyleBackColor = true;
            // 
            // radioBtnBW
            // 
            this.radioBtnBW.AutoSize = true;
            this.radioBtnBW.Checked = true;
            this.radioBtnBW.Location = new System.Drawing.Point(16, 57);
            this.radioBtnBW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnBW.Name = "radioBtnBW";
            this.radioBtnBW.Size = new System.Drawing.Size(144, 19);
            this.radioBtnBW.TabIndex = 6;
            this.radioBtnBW.TabStop = true;
            this.radioBtnBW.Text = "BW（C装置Seed）";
            this.radioBtnBW.UseVisualStyleBackColor = true;
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.Location = new System.Drawing.Point(509, 7);
            this.labelMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(67, 15);
            this.labelMAC.TabIndex = 41;
            this.labelMAC.Text = "存档信息";
            this.labelMAC.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(16, 80);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "BW (普通Seed)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelMaxFrame
            // 
            this.labelMaxFrame.AutoSize = true;
            this.labelMaxFrame.Location = new System.Drawing.Point(547, 294);
            this.labelMaxFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxFrame.Name = "labelMaxFrame";
            this.labelMaxFrame.Size = new System.Drawing.Size(37, 15);
            this.labelMaxFrame.TabIndex = 44;
            this.labelMaxFrame.Text = "最大";
            // 
            // labelMinFrame
            // 
            this.labelMinFrame.AutoSize = true;
            this.labelMinFrame.Location = new System.Drawing.Point(480, 294);
            this.labelMinFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinFrame.Name = "labelMinFrame";
            this.labelMinFrame.Size = new System.Drawing.Size(37, 15);
            this.labelMinFrame.TabIndex = 43;
            this.labelMinFrame.Text = "最小";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 316);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "帧数";
            // 
            // checkBoxRoamer
            // 
            this.checkBoxRoamer.AutoSize = true;
            this.checkBoxRoamer.Location = new System.Drawing.Point(484, 343);
            this.checkBoxRoamer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRoamer.Name = "checkBoxRoamer";
            this.checkBoxRoamer.Size = new System.Drawing.Size(89, 19);
            this.checkBoxRoamer.TabIndex = 23;
            this.checkBoxRoamer.Text = "存在游走";
            this.checkBoxRoamer.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxMaxFrame
            // 
            this.maskedTextBoxMaxFrame.Hex = false;
            this.maskedTextBoxMaxFrame.Location = new System.Drawing.Point(547, 313);
            this.maskedTextBoxMaxFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMaxFrame.Mask = "0000";
            this.maskedTextBoxMaxFrame.Name = "maskedTextBoxMaxFrame";
            this.maskedTextBoxMaxFrame.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMaxFrame.TabIndex = 22;
            this.maskedTextBoxMaxFrame.Text = "6";
            this.maskedTextBoxMaxFrame.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxMinFrame
            // 
            this.maskedTextBoxMinFrame.Hex = false;
            this.maskedTextBoxMinFrame.Location = new System.Drawing.Point(484, 313);
            this.maskedTextBoxMinFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMinFrame.Mask = "0000";
            this.maskedTextBoxMinFrame.Name = "maskedTextBoxMinFrame";
            this.maskedTextBoxMinFrame.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMinFrame.TabIndex = 21;
            this.maskedTextBoxMinFrame.Text = "1";
            this.maskedTextBoxMinFrame.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxERoute
            // 
            this.maskedTextBoxERoute.Hex = false;
            this.maskedTextBoxERoute.Location = new System.Drawing.Point(541, 53);
            this.maskedTextBoxERoute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxERoute.Mask = "00";
            this.maskedTextBoxERoute.Name = "maskedTextBoxERoute";
            this.maskedTextBoxERoute.Size = new System.Drawing.Size(25, 22);
            this.maskedTextBoxERoute.TabIndex = 12;
            this.maskedTextBoxERoute.ValidatingType = typeof(int);
            // 
            // maskedTextBoxRRoute
            // 
            this.maskedTextBoxRRoute.Hex = false;
            this.maskedTextBoxRRoute.Location = new System.Drawing.Point(439, 53);
            this.maskedTextBoxRRoute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxRRoute.Mask = "00";
            this.maskedTextBoxRRoute.Name = "maskedTextBoxRRoute";
            this.maskedTextBoxRRoute.Size = new System.Drawing.Size(25, 22);
            this.maskedTextBoxRRoute.TabIndex = 11;
            this.maskedTextBoxRRoute.ValidatingType = typeof(int);
            // 
            // maskedTextBoxLRoute
            // 
            this.maskedTextBoxLRoute.Hex = false;
            this.maskedTextBoxLRoute.Location = new System.Drawing.Point(740, 53);
            this.maskedTextBoxLRoute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxLRoute.Mask = "00";
            this.maskedTextBoxLRoute.Name = "maskedTextBoxLRoute";
            this.maskedTextBoxLRoute.Size = new System.Drawing.Size(25, 22);
            this.maskedTextBoxLRoute.TabIndex = 13;
            this.maskedTextBoxLRoute.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPSecond
            // 
            this.maskedTextBoxPSecond.Hex = false;
            this.maskedTextBoxPSecond.Location = new System.Drawing.Point(339, 313);
            this.maskedTextBoxPSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPSecond.Mask = "0";
            this.maskedTextBoxPSecond.Name = "maskedTextBoxPSecond";
            this.maskedTextBoxPSecond.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxPSecond.TabIndex = 20;
            this.maskedTextBoxPSecond.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxMDelay
            // 
            this.maskedTextBoxMDelay.Hex = false;
            this.maskedTextBoxMDelay.Location = new System.Drawing.Point(76, 313);
            this.maskedTextBoxMDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMDelay.Mask = "0000";
            this.maskedTextBoxMDelay.Name = "maskedTextBoxMDelay";
            this.maskedTextBoxMDelay.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMDelay.TabIndex = 16;
            this.maskedTextBoxMDelay.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPDelay
            // 
            this.maskedTextBoxPDelay.Hex = false;
            this.maskedTextBoxPDelay.Location = new System.Drawing.Point(137, 313);
            this.maskedTextBoxPDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPDelay.Mask = "0000";
            this.maskedTextBoxPDelay.Name = "maskedTextBoxPDelay";
            this.maskedTextBoxPDelay.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxPDelay.TabIndex = 17;
            // 
            // maskedTextBoxMSecond
            // 
            this.maskedTextBoxMSecond.Hex = false;
            this.maskedTextBoxMSecond.Location = new System.Drawing.Point(276, 313);
            this.maskedTextBoxMSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxMSecond.Mask = "0";
            this.maskedTextBoxMSecond.Name = "maskedTextBoxMSecond";
            this.maskedTextBoxMSecond.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxMSecond.TabIndex = 19;
            this.maskedTextBoxMSecond.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxSeconds
            // 
            this.maskedTextBoxSeconds.Enabled = false;
            this.maskedTextBoxSeconds.Hex = false;
            this.maskedTextBoxSeconds.Location = new System.Drawing.Point(417, 24);
            this.maskedTextBoxSeconds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxSeconds.Mask = "00";
            this.maskedTextBoxSeconds.Name = "maskedTextBoxSeconds";
            this.maskedTextBoxSeconds.Size = new System.Drawing.Size(45, 22);
            this.maskedTextBoxSeconds.TabIndex = 2;
            this.maskedTextBoxSeconds.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Hex = false;
            this.maskedTextBoxYear.Location = new System.Drawing.Point(311, 24);
            this.maskedTextBoxYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxYear.Mask = "2\\000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(53, 22);
            this.maskedTextBoxYear.TabIndex = 1;
            // 
            // buttonSearchRoamers
            // 
            this.buttonSearchRoamers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchRoamers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSearchRoamers.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchRoamers.Location = new System.Drawing.Point(628, 328);
            this.buttonSearchRoamers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearchRoamers.Name = "buttonSearchRoamers";
            this.buttonSearchRoamers.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearchRoamers.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonSearchRoamers.Size = new System.Drawing.Size(140, 27);
            this.buttonSearchRoamers.TabIndex = 29;
            this.buttonSearchRoamers.Text = "查看游走反查";
            this.buttonSearchRoamers.Click += new System.EventHandler(this.buttonSearchRoamers_Click);
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfiles.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(513, 24);
            this.comboBoxProfiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxProfiles.MaxDropDownItems = 3;
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxProfiles.Size = new System.Drawing.Size(157, 23);
            this.comboBoxProfiles.TabIndex = 46;
            this.comboBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfiles_SelectedIndexChanged);
            // 
            // SeedToTime
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(895, 638);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxProfiles);
            this.Controls.Add(this.buttonSearchRoamers);
            this.Controls.Add(this.checkBoxRoamer);
            this.Controls.Add(this.labelMaxFrame);
            this.Controls.Add(this.labelMinFrame);
            this.Controls.Add(this.maskedTextBoxMaxFrame);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBoxMinFrame);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelMAC);
            this.Controls.Add(this.radioBtnBW);
            this.Controls.Add(this.checkBoxOddEven);
            this.Controls.Add(this.labelRoamerRoutes);
            this.Controls.Add(this.buttonRoamerMap);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkBoxRPresent);
            this.Controls.Add(this.checkBoxEPresent);
            this.Controls.Add(this.radioBtnDPPt);
            this.Controls.Add(this.maskedTextBoxERoute);
            this.Controls.Add(this.maskedTextBoxRRoute);
            this.Controls.Add(this.maskedTextBoxLRoute);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxLPresent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioBtnHgSs);
            this.Controls.Add(this.labelFlipsElmsForSeed);
            this.Controls.Add(this.labelVerificationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxPSecond);
            this.Controls.Add(this.maskedTextBoxMDelay);
            this.Controls.Add(this.maskedTextBoxPDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxMSecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxSeconds);
            this.Controls.Add(this.dataGridViewAdjacents);
            this.Controls.Add(this.buttonGenerateAdjacents);
            this.Controls.Add(this.checkBoxLockSeconds);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(861, 570);
            this.Name = "SeedToTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seed To Times / Adjacent Finder";
            this.Load += new System.EventHandler(this.SeedToTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacents)).EndInit();
            this.contextMenuStripAdjacents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RNGReporter.GlassButton buttonCancel;
        private RNGReporter.GlassButton buttonOk;
        private MaskedTextBox2 textBoxSeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private MaskedTextBox2 maskedTextBoxYear;
        private RNGReporter.GlassButton buttonGenerate;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewValues;
        private System.Windows.Forms.CheckBox checkBoxLockSeconds;
        private MaskedTextBox2 maskedTextBoxSeconds;
        private System.Windows.Forms.Label label1;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewAdjacents;
        private RNGReporter.GlassButton buttonGenerateAdjacents;
        private MaskedTextBox2 maskedTextBoxMSecond;
        private System.Windows.Forms.Label label2;
        private MaskedTextBox2 maskedTextBoxMDelay;
        private MaskedTextBox2 maskedTextBoxPDelay;
        private System.Windows.Forms.Label label5;
        private MaskedTextBox2 maskedTextBoxPSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RNGReporter.GlassButton buttonSearch;
        private System.Windows.Forms.Label labelFlipsElmsForSeed;
        private System.Windows.Forms.Label labelVerificationType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAdjacents;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateTXTFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
        private System.Windows.Forms.RadioButton radioBtnDPPt;
        private System.Windows.Forms.RadioButton radioBtnHgSs;
        private System.Windows.Forms.CheckBox checkBoxEPresent;
        private MaskedTextBox2 maskedTextBoxERoute;
        private MaskedTextBox2 maskedTextBoxRRoute;
        private MaskedTextBox2 maskedTextBoxLRoute;
        private System.Windows.Forms.CheckBox checkBoxRPresent;
        private System.Windows.Forms.CheckBox checkBoxLPresent;
        private System.Windows.Forms.Label labelRoamerRoutes;
        private System.Windows.Forms.Label label18;
        private RNGReporter.GlassButton buttonRoamerMap;
        private System.Windows.Forms.CheckBox checkBoxOddEven;
        private System.Windows.Forms.RadioButton radioBtnBW;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelMaxFrame;
        private System.Windows.Forms.Label labelMinFrame;
        private MaskedTextBox2 maskedTextBoxMaxFrame;
        private System.Windows.Forms.Label label10;
        private MaskedTextBox2 maskedTextBoxMinFrame;
        private System.Windows.Forms.CheckBox checkBoxRoamer;
        private RNGReporter.GlassButton buttonSearchRoamers;
        private GlassComboBox comboBoxProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjacentSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlipSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElmResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoamers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGen5IVs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCGearAdjust;
    }
}
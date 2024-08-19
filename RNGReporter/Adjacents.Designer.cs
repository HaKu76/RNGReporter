using RNGReporter.Controls;
using RNGReporter.Objects;

namespace RNGReporter
{
    partial class Adjacents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adjacents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties1 = new RNGReporter.Controls.CheckBoxProperties();
            this.contextMenuStripCap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateAdjacentSeedsFrame1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateAdjacentSeedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.outputCapResultsToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCapMonthDelay = new System.Windows.Forms.Label();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBoxChatot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelMaxFrame = new System.Windows.Forms.Label();
            this.labelMinFrame = new System.Windows.Forms.Label();
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.labelProfileInformation = new System.Windows.Forms.Label();
            this.comboBoxProfiles = new RNGReporter.GlassComboBox();
            this.buttonEditProfile = new RNGReporter.GlassButton();
            this.comboBoxLead = new RNGReporter.GlassComboBox();
            this.dataGridViewCapValues = new RNGReporter.DoubleBufferedDataGridView();
            this.CapSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncounterSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapAtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapSpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapSpD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapSpe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Synchable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxKeypresses = new RNGReporter.Controls.CheckBoxComboBox();
            this.comboBoxEncounterType = new RNGReporter.GlassComboBox();
            this.buttonSeedGenerate = new RNGReporter.GlassButton();
            this.comboBoxMethod = new RNGReporter.GlassComboBox();
            this.maskedTextBoxCapMaxOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxCapMinOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.contextMenuStripCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.groupBoxConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapValues)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripCap
            // 
            this.contextMenuStripCap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.generateTimesToolStripMenuItem,
            this.generateAdjacentSeedsFrame1ToolStripMenuItem,
            this.generateAdjacentSeedsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.outputCapResultsToTXTToolStripMenuItem});
            this.contextMenuStripCap.Name = "contextMenuStripCap";
            this.contextMenuStripCap.Size = new System.Drawing.Size(224, 126);
            this.contextMenuStripCap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCap_Opening);
            // 
            // copySeedToClipboardToolStripMenuItem1
            // 
            this.copySeedToClipboardToolStripMenuItem1.Name = "copySeedToClipboardToolStripMenuItem1";
            this.copySeedToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.copySeedToClipboardToolStripMenuItem1.Text = "复制Seed到剪贴板";
            this.copySeedToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.copySeedToClipboardToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(220, 6);
            // 
            // generateTimesToolStripMenuItem
            // 
            this.generateTimesToolStripMenuItem.Name = "generateTimesToolStripMenuItem";
            this.generateTimesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.generateTimesToolStripMenuItem.Text = "计算更多的时间 ...";
            // 
            // generateAdjacentSeedsFrame1ToolStripMenuItem
            // 
            this.generateAdjacentSeedsFrame1ToolStripMenuItem.Name = "generateAdjacentSeedsFrame1ToolStripMenuItem";
            this.generateAdjacentSeedsFrame1ToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.generateAdjacentSeedsFrame1ToolStripMenuItem.Text = "计算相邻的 Seeds (1帧)";
            this.generateAdjacentSeedsFrame1ToolStripMenuItem.Visible = false;
            // 
            // generateAdjacentSeedsToolStripMenuItem
            // 
            this.generateAdjacentSeedsToolStripMenuItem.Name = "generateAdjacentSeedsToolStripMenuItem";
            this.generateAdjacentSeedsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.generateAdjacentSeedsToolStripMenuItem.Text = "计算相邻的 Seeds (当前帧)";
            this.generateAdjacentSeedsToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(220, 6);
            // 
            // outputCapResultsToTXTToolStripMenuItem
            // 
            this.outputCapResultsToTXTToolStripMenuItem.Name = "outputCapResultsToTXTToolStripMenuItem";
            this.outputCapResultsToTXTToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.outputCapResultsToTXTToolStripMenuItem.Text = "输出结果至文本txt ...";
            this.outputCapResultsToTXTToolStripMenuItem.Click += new System.EventHandler(this.outputCapResultsToTXTToolStripMenuItem_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MMMMdd, yyyy     HH:mm:ss";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(409, 93);
            this.datePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(235, 21);
            this.datePicker.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 162;
            this.label2.Text = "日期\\时间";
            // 
            // labelCapMonthDelay
            // 
            this.labelCapMonthDelay.AutoSize = true;
            this.labelCapMonthDelay.Location = new System.Drawing.Point(12, 58);
            this.labelCapMonthDelay.Name = "labelCapMonthDelay";
            this.labelCapMonthDelay.Size = new System.Drawing.Size(29, 12);
            this.labelCapMonthDelay.TabIndex = 164;
            this.labelCapMonthDelay.Text = "按键";
            this.labelCapMonthDelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(196, 101);
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownSeconds.TabIndex = 169;
            this.numericUpDownSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 168;
            this.label8.Text = "秒数 +\\-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 186);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 113;
            this.label30.Text = "算法";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(197, 186);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 12);
            this.label52.TabIndex = 121;
            this.label52.Text = "相遇类型";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxChatot
            // 
            this.textBoxChatot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChatot.Location = new System.Drawing.Point(96, 374);
            this.textBoxChatot.Name = "textBoxChatot";
            this.textBoxChatot.ReadOnly = true;
            this.textBoxChatot.Size = new System.Drawing.Size(557, 21);
            this.textBoxChatot.TabIndex = 170;
            this.toolTip1.SetToolTip(this.textBoxChatot, resources.GetString("textBoxChatot.ToolTip"));
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 171;
            this.label3.Text = "聒噪鸟音高";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 173;
            this.label4.Text = "主特性";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(12, 126);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(641, 50);
            this.textBoxDescription.TabIndex = 175;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // labelMaxFrame
            // 
            this.labelMaxFrame.Location = new System.Drawing.Point(265, 106);
            this.labelMaxFrame.Name = "labelMaxFrame";
            this.labelMaxFrame.Size = new System.Drawing.Size(78, 12);
            this.labelMaxFrame.TabIndex = 107;
            this.labelMaxFrame.Text = "最大帧";
            this.labelMaxFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMinFrame
            // 
            this.labelMinFrame.Location = new System.Drawing.Point(265, 79);
            this.labelMinFrame.Name = "labelMinFrame";
            this.labelMinFrame.Size = new System.Drawing.Size(78, 12);
            this.labelMinFrame.TabIndex = 125;
            this.labelMinFrame.Text = "最小帧";
            this.labelMinFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxConfiguration
            // 
            this.groupBoxConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfiguration.Controls.Add(this.labelProfileInformation);
            this.groupBoxConfiguration.Controls.Add(this.comboBoxProfiles);
            this.groupBoxConfiguration.Controls.Add(this.buttonEditProfile);
            this.groupBoxConfiguration.Location = new System.Drawing.Point(12, 11);
            this.groupBoxConfiguration.Name = "groupBoxConfiguration";
            this.groupBoxConfiguration.Size = new System.Drawing.Size(644, 44);
            this.groupBoxConfiguration.TabIndex = 176;
            this.groupBoxConfiguration.TabStop = false;
            this.groupBoxConfiguration.Text = "基本配置";
            // 
            // labelProfileInformation
            // 
            this.labelProfileInformation.AutoSize = true;
            this.labelProfileInformation.Location = new System.Drawing.Point(131, 20);
            this.labelProfileInformation.Name = "labelProfileInformation";
            this.labelProfileInformation.Size = new System.Drawing.Size(0, 12);
            this.labelProfileInformation.TabIndex = 320;
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfiles.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(6, 18);
            this.comboBoxProfiles.MaxDropDownItems = 3;
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxProfiles.Size = new System.Drawing.Size(119, 20);
            this.comboBoxProfiles.TabIndex = 33;
            this.comboBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfiles_SelectedIndexChanged);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditProfile.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEditProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonEditProfile.Location = new System.Drawing.Point(599, 16);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonEditProfile.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonEditProfile.Size = new System.Drawing.Size(39, 21);
            this.buttonEditProfile.TabIndex = 11;
            this.buttonEditProfile.Text = "编辑";
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // comboBoxLead
            // 
            this.comboBoxLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLead.ForeColor = System.Drawing.Color.Black;
            this.comboBoxLead.FormattingEnabled = true;
            this.comboBoxLead.Location = new System.Drawing.Point(492, 182);
            this.comboBoxLead.Name = "comboBoxLead";
            this.comboBoxLead.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxLead.Size = new System.Drawing.Size(130, 20);
            this.comboBoxLead.TabIndex = 174;
            // 
            // dataGridViewCapValues
            // 
            this.dataGridViewCapValues.AllowUserToAddRows = false;
            this.dataGridViewCapValues.AllowUserToDeleteRows = false;
            this.dataGridViewCapValues.AllowUserToResizeRows = false;
            this.dataGridViewCapValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCapValues.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCapValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCapValues.ColumnHeadersHeight = 22;
            this.dataGridViewCapValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CapSeed,
            this.Timer0,
            this.SeedTime,
            this.CapOffset,
            this.PID,
            this.EncounterSlot,
            this.Shiny,
            this.Nature,
            this.Ability,
            this.CapHP,
            this.CapAtk,
            this.CapDef,
            this.CapSpA,
            this.CapSpD,
            this.CapSpe,
            this.f50,
            this.f125,
            this.f25,
            this.f75,
            this.Synchable});
            this.dataGridViewCapValues.ContextMenuStrip = this.contextMenuStripCap;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCapValues.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCapValues.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewCapValues.MultiSelect = false;
            this.dataGridViewCapValues.Name = "dataGridViewCapValues";
            this.dataGridViewCapValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCapValues.RowHeadersVisible = false;
            this.dataGridViewCapValues.RowTemplate.Height = 20;
            this.dataGridViewCapValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCapValues.ShowCellErrors = false;
            this.dataGridViewCapValues.ShowCellToolTips = false;
            this.dataGridViewCapValues.ShowEditingIcon = false;
            this.dataGridViewCapValues.ShowRowErrors = false;
            this.dataGridViewCapValues.Size = new System.Drawing.Size(641, 162);
            this.dataGridViewCapValues.TabIndex = 51;
            this.dataGridViewCapValues.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCapValues_CellFormatting);
            this.dataGridViewCapValues.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCapValues_ColumnHeaderMouseClick);
            this.dataGridViewCapValues.SelectionChanged += new System.EventHandler(this.dataGridViewCapValues_SelectionChanged);
            this.dataGridViewCapValues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCapValues_KeyDown);
            this.dataGridViewCapValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCapValues_MouseDown);
            // 
            // CapSeed
            // 
            this.CapSeed.DataPropertyName = "Seed";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.CapSeed.DefaultCellStyle = dataGridViewCellStyle2;
            this.CapSeed.FillWeight = 110F;
            this.CapSeed.HeaderText = "Seed";
            this.CapSeed.Name = "CapSeed";
            this.CapSeed.ReadOnly = true;
            this.CapSeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CapSeed.Width = 120;
            // 
            // Timer0
            // 
            this.Timer0.DataPropertyName = "Timer0";
            this.Timer0.HeaderText = "Timer0";
            this.Timer0.Name = "Timer0";
            this.Timer0.ReadOnly = true;
            this.Timer0.Width = 50;
            // 
            // SeedTime
            // 
            this.SeedTime.DataPropertyName = "TimeDate";
            this.SeedTime.HeaderText = "日期\\时间";
            this.SeedTime.Name = "SeedTime";
            this.SeedTime.ReadOnly = true;
            // 
            // CapOffset
            // 
            this.CapOffset.DataPropertyName = "Offset";
            this.CapOffset.HeaderText = "帧";
            this.CapOffset.Name = "CapOffset";
            this.CapOffset.ReadOnly = true;
            this.CapOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CapOffset.Width = 45;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "Pid";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.PID.DefaultCellStyle = dataGridViewCellStyle3;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 70;
            // 
            // EncounterSlot
            // 
            this.EncounterSlot.DataPropertyName = "EncounterSlot";
            this.EncounterSlot.FillWeight = 50F;
            this.EncounterSlot.HeaderText = "相遇槽位";
            this.EncounterSlot.Name = "EncounterSlot";
            this.EncounterSlot.ReadOnly = true;
            this.EncounterSlot.Width = 85;
            // 
            // Shiny
            // 
            this.Shiny.DataPropertyName = "ShinyDisplay";
            this.Shiny.HeaderText = "异色";
            this.Shiny.Name = "Shiny";
            this.Shiny.ReadOnly = true;
            this.Shiny.Width = 20;
            // 
            // Nature
            // 
            this.Nature.DataPropertyName = "Nature";
            this.Nature.HeaderText = "性格";
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            this.Nature.Width = 65;
            // 
            // Ability
            // 
            this.Ability.DataPropertyName = "Ability";
            this.Ability.HeaderText = "特性";
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            this.Ability.Width = 40;
            // 
            // CapHP
            // 
            this.CapHP.DataPropertyName = "Hp";
            this.CapHP.HeaderText = "HP";
            this.CapHP.Name = "CapHP";
            this.CapHP.ReadOnly = true;
            this.CapHP.Width = 30;
            // 
            // CapAtk
            // 
            this.CapAtk.DataPropertyName = "Atk";
            this.CapAtk.HeaderText = "攻击";
            this.CapAtk.Name = "CapAtk";
            this.CapAtk.ReadOnly = true;
            this.CapAtk.Width = 30;
            // 
            // CapDef
            // 
            this.CapDef.DataPropertyName = "Def";
            this.CapDef.HeaderText = "防御";
            this.CapDef.Name = "CapDef";
            this.CapDef.ReadOnly = true;
            this.CapDef.Width = 30;
            // 
            // CapSpA
            // 
            this.CapSpA.DataPropertyName = "SpA";
            this.CapSpA.HeaderText = "特攻";
            this.CapSpA.Name = "CapSpA";
            this.CapSpA.ReadOnly = true;
            this.CapSpA.Width = 30;
            // 
            // CapSpD
            // 
            this.CapSpD.DataPropertyName = "SpD";
            this.CapSpD.HeaderText = "特防";
            this.CapSpD.Name = "CapSpD";
            this.CapSpD.ReadOnly = true;
            this.CapSpD.Width = 30;
            // 
            // CapSpe
            // 
            this.CapSpe.DataPropertyName = "Spe";
            this.CapSpe.HeaderText = "速度";
            this.CapSpe.Name = "CapSpe";
            this.CapSpe.ReadOnly = true;
            this.CapSpe.Width = 30;
            // 
            // f50
            // 
            this.f50.DataPropertyName = "Female50";
            this.f50.HeaderText = "50% ♀";
            this.f50.Name = "f50";
            this.f50.ReadOnly = true;
            this.f50.Width = 50;
            // 
            // f125
            // 
            this.f125.DataPropertyName = "Female125";
            this.f125.HeaderText = "12.5%♀";
            this.f125.Name = "f125";
            this.f125.ReadOnly = true;
            this.f125.Width = 50;
            // 
            // f25
            // 
            this.f25.DataPropertyName = "Female25";
            this.f25.HeaderText = "25% ♀";
            this.f25.Name = "f25";
            this.f25.ReadOnly = true;
            this.f25.Width = 50;
            // 
            // f75
            // 
            this.f75.DataPropertyName = "Female75";
            this.f75.HeaderText = "75% ♀";
            this.f75.Name = "f75";
            this.f75.ReadOnly = true;
            this.f75.Width = 50;
            // 
            // Synchable
            // 
            this.Synchable.DataPropertyName = "Synchable";
            this.Synchable.HeaderText = "同步";
            this.Synchable.Name = "Synchable";
            this.Synchable.ReadOnly = true;
            this.Synchable.Visible = false;
            // 
            // comboBoxKeypresses
            // 
            this.comboBoxKeypresses.BlankText = "None";
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxKeypresses.CheckBoxProperties = checkBoxProperties1;
            this.comboBoxKeypresses.DisplayMemberSingleItem = "";
            this.comboBoxKeypresses.DropDownHeight = 300;
            this.comboBoxKeypresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeypresses.FormattingEnabled = true;
            this.comboBoxKeypresses.Items.AddRange(new object[] {
            "Start",
            "Select",
            "A",
            "B",
            "Right",
            "Left",
            "Up",
            "Down",
            "R",
            "L",
            "X",
            "Y"});
            this.comboBoxKeypresses.Location = new System.Drawing.Point(12, 72);
            this.comboBoxKeypresses.Name = "comboBoxKeypresses";
            this.comboBoxKeypresses.Size = new System.Drawing.Size(235, 20);
            this.comboBoxKeypresses.TabIndex = 165;
            this.comboBoxKeypresses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FocusControl);
            // 
            // comboBoxEncounterType
            // 
            this.comboBoxEncounterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncounterType.Enabled = false;
            this.comboBoxEncounterType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEncounterType.FormattingEnabled = true;
            this.comboBoxEncounterType.Location = new System.Drawing.Point(283, 182);
            this.comboBoxEncounterType.Name = "comboBoxEncounterType";
            this.comboBoxEncounterType.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxEncounterType.Size = new System.Drawing.Size(130, 20);
            this.comboBoxEncounterType.TabIndex = 122;
            // 
            // buttonSeedGenerate
            // 
            this.buttonSeedGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSeedGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonSeedGenerate.Location = new System.Drawing.Point(12, 98);
            this.buttonSeedGenerate.Name = "buttonSeedGenerate";
            this.buttonSeedGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonSeedGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonSeedGenerate.Size = new System.Drawing.Size(76, 21);
            this.buttonSeedGenerate.TabIndex = 116;
            this.buttonSeedGenerate.Text = "计算";
            this.buttonSeedGenerate.Click += new System.EventHandler(this.buttonSeedGenerate_Click);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(61, 182);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxMethod.Size = new System.Drawing.Size(130, 20);
            this.comboBoxMethod.TabIndex = 115;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // maskedTextBoxCapMaxOffset
            // 
            this.maskedTextBoxCapMaxOffset.Hex = false;
            this.maskedTextBoxCapMaxOffset.Location = new System.Drawing.Point(349, 102);
            this.maskedTextBoxCapMaxOffset.Mask = "00000";
            this.maskedTextBoxCapMaxOffset.Name = "maskedTextBoxCapMaxOffset";
            this.maskedTextBoxCapMaxOffset.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxCapMaxOffset.TabIndex = 111;
            this.maskedTextBoxCapMaxOffset.Text = "1";
            // 
            // maskedTextBoxCapMinOffset
            // 
            this.maskedTextBoxCapMinOffset.Hex = false;
            this.maskedTextBoxCapMinOffset.Location = new System.Drawing.Point(349, 77);
            this.maskedTextBoxCapMinOffset.Mask = "00000";
            this.maskedTextBoxCapMinOffset.Name = "maskedTextBoxCapMinOffset";
            this.maskedTextBoxCapMinOffset.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxCapMinOffset.TabIndex = 124;
            this.maskedTextBoxCapMinOffset.Text = "1";
            // 
            // Adjacents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.groupBoxConfiguration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxChatot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLead);
            this.Controls.Add(this.dataGridViewCapValues);
            this.Controls.Add(this.labelCapMonthDelay);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKeypresses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.buttonSeedGenerate);
            this.Controls.Add(this.comboBoxEncounterType);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.maskedTextBoxCapMaxOffset);
            this.Controls.Add(this.maskedTextBoxCapMinOffset);
            this.Controls.Add(this.labelMinFrame);
            this.Controls.Add(this.labelMaxFrame);
            this.MinimumSize = new System.Drawing.Size(676, 354);
            this.Name = "Adjacents";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "相邻Seed计算工具（GEN5）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlatinumTime_FormClosing);
            this.Load += new System.EventHandler(this.PlatinumTime_Load);
            this.contextMenuStripCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCap;
        private System.Windows.Forms.ToolStripMenuItem generateTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem outputCapResultsToTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem generateAdjacentSeedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateAdjacentSeedsFrame1ToolStripMenuItem;
        private RNGReporter.GlassButton buttonSeedGenerate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private CheckBoxComboBox comboBoxKeypresses;
        private System.Windows.Forms.Label labelCapMonthDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Label label8;
        private DoubleBufferedDataGridView dataGridViewCapValues;
        private System.Windows.Forms.Label label30;
        private RNGReporter.GlassComboBox comboBoxMethod;
        private MaskedTextBox2 maskedTextBoxCapMaxOffset;
        private System.Windows.Forms.Label label52;
        private RNGReporter.GlassComboBox comboBoxEncounterType;
        private MaskedTextBox2 maskedTextBoxCapMinOffset;
        private System.Windows.Forms.TextBox textBoxChatot;
        private System.Windows.Forms.Label label3;
        private RNGReporter.GlassComboBox comboBoxLead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelMaxFrame;
        private System.Windows.Forms.Label labelMinFrame;
        private System.Windows.Forms.GroupBox groupBoxConfiguration;
        private System.Windows.Forms.Label labelProfileInformation;
        private GlassComboBox comboBoxProfiles;
        private GlassButton buttonEditProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer0;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncounterSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapAtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapSpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapSpD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapSpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn f50;
        private System.Windows.Forms.DataGridViewTextBoxColumn f125;
        private System.Windows.Forms.DataGridViewTextBoxColumn f25;
        private System.Windows.Forms.DataGridViewTextBoxColumn f75;
        private System.Windows.Forms.DataGridViewTextBoxColumn Synchable;
    }
}
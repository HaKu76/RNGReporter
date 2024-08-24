using RNGReporter.Controls;

namespace RNGReporter
{
    partial class Pandora : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if ((disposing && components != null))
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpShiny = new System.Windows.Forms.GroupBox();
            this.cbxShinyInf = new System.Windows.Forms.CheckBox();
            this.textBoxShinyTID = new RNGReporter.Controls.MaskedTextBox2();
            this.lblShinyTrainerID = new System.Windows.Forms.Label();
            this.cbxSearchID = new System.Windows.Forms.CheckBox();
            this.btnShinyCancel = new RNGReporter.GlassButton();
            this.btnShinyGo = new RNGReporter.GlassButton();
            this.txtShinyMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.lblShinyMaxDelay = new System.Windows.Forms.Label();
            this.lblShinyMinDelay = new System.Windows.Forms.Label();
            this.txtShinyMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.textBoxShinyYear = new RNGReporter.Controls.MaskedTextBox2();
            this.lblShinyYr = new System.Windows.Forms.Label();
            this.lblShinyPID = new System.Windows.Forms.Label();
            this.textBoxShinyPID = new RNGReporter.Controls.MaskedTextBox2();
            this.grpID = new System.Windows.Forms.GroupBox();
            this.cbxIDInf = new System.Windows.Forms.CheckBox();
            this.btnIDCancel = new RNGReporter.GlassButton();
            this.btnIDGo = new RNGReporter.GlassButton();
            this.textBoxIDMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.textBoxIDMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.lblIDMaxDelay = new System.Windows.Forms.Label();
            this.lblIDMinDelay = new System.Windows.Forms.Label();
            this.textBoxIDYear = new RNGReporter.Controls.MaskedTextBox2();
            this.lblIDYr = new System.Windows.Forms.Label();
            this.textBoxDesiredSID = new RNGReporter.Controls.MaskedTextBox2();
            this.lblSecretID = new System.Windows.Forms.Label();
            this.cbxSearchSID = new System.Windows.Forms.CheckBox();
            this.textBoxDesiredTID = new RNGReporter.Controls.MaskedTextBox2();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.grpSeed = new System.Windows.Forms.GroupBox();
            this.lblSeedMaxDelay = new System.Windows.Forms.Label();
            this.lblSeedMinDelay = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSeedYr = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtSeedMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.btnSeedGo = new RNGReporter.GlassButton();
            this.txtSeedMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.txtMinute = new RNGReporter.Controls.MaskedTextBox2();
            this.txtHour = new RNGReporter.Controls.MaskedTextBox2();
            this.txtSeedYr = new RNGReporter.Controls.MaskedTextBox2();
            this.txtDay = new RNGReporter.Controls.MaskedTextBox2();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new RNGReporter.Controls.MaskedTextBox2();
            this.txtIDObtained = new RNGReporter.Controls.MaskedTextBox2();
            this.lblIDObtained = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwShiny = new System.ComponentModel.BackgroundWorker();
            this.bgwID = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwIDInf = new System.ComponentModel.BackgroundWorker();
            this.lblSimple = new System.Windows.Forms.Label();
            this.lblSeed = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpleGo = new RNGReporter.GlassButton();
            this.textBoxSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.bgwShinyInf = new System.ComponentModel.BackgroundWorker();
            this.tabGenSelect = new System.Windows.Forms.TabControl();
            this.tabXDColo = new System.Windows.Forms.TabPage();
            this.labelXDColo = new System.Windows.Forms.Label();
            this.genCancelXDColo = new RNGReporter.GlassButton();
            this.searchGenXDColo = new RNGReporter.GlassButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.XDColoMaxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label16 = new System.Windows.Forms.Label();
            this.XDColoMinFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.XDColoPID = new RNGReporter.Controls.MaskedTextBox2();
            this.XDColoPRNG = new RNGReporter.Controls.MaskedTextBox2();
            this.tabGen3FRLGE = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.genCancelFRLGE = new RNGReporter.GlassButton();
            this.genSearchFRLGE = new RNGReporter.GlassButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.genFRLGEMaxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label12 = new System.Windows.Forms.Label();
            this.genFRLGEMinFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genFRLGEPID = new RNGReporter.Controls.MaskedTextBox2();
            this.genFRLGETID = new RNGReporter.Controls.MaskedTextBox2();
            this.tabGen3RS = new System.Windows.Forms.TabPage();
            this.buttonIIICancel = new RNGReporter.GlassButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox21 = new RNGReporter.Controls.MaskedTextBox2();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkIIIClock = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textIIIMaxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textIIIMinFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.textIIIMinute = new RNGReporter.Controls.MaskedTextBox2();
            this.dateIII = new System.Windows.Forms.DateTimePicker();
            this.textIIIHour = new RNGReporter.Controls.MaskedTextBox2();
            this.buttonIIIFindFrames = new RNGReporter.GlassButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textIIISID = new RNGReporter.Controls.MaskedTextBox2();
            this.checkIIISID = new System.Windows.Forms.CheckBox();
            this.checkIIIPID = new System.Windows.Forms.CheckBox();
            this.textIIIPID = new RNGReporter.Controls.MaskedTextBox2();
            this.textIIITID = new RNGReporter.Controls.MaskedTextBox2();
            this.checkIIITID = new System.Windows.Forms.CheckBox();
            this.tabGen4 = new System.Windows.Forms.TabPage();
            this.labelBy = new System.Windows.Forms.Label();
            this.btnCredits = new RNGReporter.GlassButton();
            this.tabGen5 = new System.Windows.Forms.TabPage();
            this.buttonVFindSeedHit = new RNGReporter.GlassButton();
            this.groupVSeedFinder = new System.Windows.Forms.GroupBox();
            this.textVMinute = new RNGReporter.Controls.MaskedTextBox2();
            this.textVHour = new RNGReporter.Controls.MaskedTextBox2();
            this.labelTIDReceived = new System.Windows.Forms.Label();
            this.labelVMinute = new System.Windows.Forms.Label();
            this.textVTIDReceived = new RNGReporter.Controls.MaskedTextBox2();
            this.textVMaxSec = new RNGReporter.Controls.MaskedTextBox2();
            this.labelVHour = new System.Windows.Forms.Label();
            this.textVMinSec = new RNGReporter.Controls.MaskedTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.textVMaxFrameHit = new RNGReporter.Controls.MaskedTextBox2();
            this.dateTimeSeedSearch = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textVMinFrameHit = new RNGReporter.Controls.MaskedTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.groupVDSParams = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProfileInformation = new System.Windows.Forms.Label();
            this.comboBoxProfiles = new RNGReporter.GlassComboBox();
            this.buttonEditProfile = new RNGReporter.GlassButton();
            this.groupVSearchParams = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveExists = new System.Windows.Forms.CheckBox();
            this.checkBoxMinFrameCalc = new System.Windows.Forms.CheckBox();
            this.textVMaxFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.labelVMaxFrame = new System.Windows.Forms.Label();
            this.textVMinFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.labelVMinFrame = new System.Windows.Forms.Label();
            this.checkVMonth = new System.Windows.Forms.CheckBox();
            this.dateTimeSearch = new System.Windows.Forms.DateTimePicker();
            this.labelVDate = new System.Windows.Forms.Label();
            this.groupVPID = new System.Windows.Forms.GroupBox();
            this.textVSID = new RNGReporter.Controls.MaskedTextBox2();
            this.checkVSID = new System.Windows.Forms.CheckBox();
            this.checkVPID = new System.Windows.Forms.CheckBox();
            this.textVPID = new RNGReporter.Controls.MaskedTextBox2();
            this.labelVFrame = new System.Windows.Forms.Label();
            this.textVFrame = new RNGReporter.Controls.MaskedTextBox2();
            this.textVTID = new RNGReporter.Controls.MaskedTextBox2();
            this.checkVSeed = new System.Windows.Forms.CheckBox();
            this.textVSeed = new RNGReporter.Controls.MaskedTextBox2();
            this.checkVTID = new System.Windows.Forms.CheckBox();
            this.buttonVFindSeeds = new RNGReporter.GlassButton();
            this.buttonVCancel = new RNGReporter.GlassButton();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.dgvResults = new RNGReporter.DoubleBufferedDataGridView();
            this.clmSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitialFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmButton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpShiny.SuspendLayout();
            this.grpID.SuspendLayout();
            this.grpSeed.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tabGenSelect.SuspendLayout();
            this.tabXDColo.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabGen3FRLGE.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabGen3RS.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabGen4.SuspendLayout();
            this.tabGen5.SuspendLayout();
            this.groupVSeedFinder.SuspendLayout();
            this.groupVDSParams.SuspendLayout();
            this.groupVSearchParams.SuspendLayout();
            this.groupVPID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShiny
            // 
            this.grpShiny.Controls.Add(this.cbxShinyInf);
            this.grpShiny.Controls.Add(this.textBoxShinyTID);
            this.grpShiny.Controls.Add(this.lblShinyTrainerID);
            this.grpShiny.Controls.Add(this.cbxSearchID);
            this.grpShiny.Controls.Add(this.btnShinyCancel);
            this.grpShiny.Controls.Add(this.btnShinyGo);
            this.grpShiny.Controls.Add(this.txtShinyMaxDelay);
            this.grpShiny.Controls.Add(this.lblShinyMaxDelay);
            this.grpShiny.Controls.Add(this.lblShinyMinDelay);
            this.grpShiny.Controls.Add(this.txtShinyMinDelay);
            this.grpShiny.Controls.Add(this.textBoxShinyYear);
            this.grpShiny.Controls.Add(this.lblShinyYr);
            this.grpShiny.Controls.Add(this.lblShinyPID);
            this.grpShiny.Controls.Add(this.textBoxShinyPID);
            this.grpShiny.Location = new System.Drawing.Point(8, 48);
            this.grpShiny.Margin = new System.Windows.Forms.Padding(4);
            this.grpShiny.Name = "grpShiny";
            this.grpShiny.Padding = new System.Windows.Forms.Padding(4);
            this.grpShiny.Size = new System.Drawing.Size(244, 358);
            this.grpShiny.TabIndex = 1;
            this.grpShiny.TabStop = false;
            this.grpShiny.Text = "异色PID（迷人之躯）";
            // 
            // cbxShinyInf
            // 
            this.cbxShinyInf.AutoSize = true;
            this.cbxShinyInf.Location = new System.Drawing.Point(12, 212);
            this.cbxShinyInf.Margin = new System.Windows.Forms.Padding(4);
            this.cbxShinyInf.Name = "cbxShinyInf";
            this.cbxShinyInf.Size = new System.Drawing.Size(104, 19);
            this.cbxShinyInf.TabIndex = 7;
            this.cbxShinyInf.Text = "无限地计算";
            this.cbxShinyInf.UseVisualStyleBackColor = true;
            this.cbxShinyInf.CheckedChanged += new System.EventHandler(this.cbxShinyInf_CheckedChanged);
            // 
            // textBoxShinyTID
            // 
            this.textBoxShinyTID.Enabled = false;
            this.textBoxShinyTID.Hex = false;
            this.textBoxShinyTID.Location = new System.Drawing.Point(139, 89);
            this.textBoxShinyTID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShinyTID.Mask = "00000";
            this.textBoxShinyTID.Name = "textBoxShinyTID";
            this.textBoxShinyTID.Size = new System.Drawing.Size(48, 23);
            this.textBoxShinyTID.TabIndex = 3;
            // 
            // lblShinyTrainerID
            // 
            this.lblShinyTrainerID.AutoSize = true;
            this.lblShinyTrainerID.Enabled = false;
            this.lblShinyTrainerID.Location = new System.Drawing.Point(35, 92);
            this.lblShinyTrainerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShinyTrainerID.Name = "lblShinyTrainerID";
            this.lblShinyTrainerID.Size = new System.Drawing.Size(91, 15);
            this.lblShinyTrainerID.TabIndex = 10;
            this.lblShinyTrainerID.Text = "想要的TID：";
            this.lblShinyTrainerID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxSearchID
            // 
            this.cbxSearchID.AutoSize = true;
            this.cbxSearchID.Location = new System.Drawing.Point(12, 62);
            this.cbxSearchID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchID.Name = "cbxSearchID";
            this.cbxSearchID.Size = new System.Drawing.Size(189, 19);
            this.cbxSearchID.TabIndex = 2;
            this.cbxSearchID.Text = "搜索想要的TID（表ID）";
            this.cbxSearchID.UseVisualStyleBackColor = true;
            this.cbxSearchID.CheckedChanged += new System.EventHandler(this.cbxSearchID_CheckedChanged);
            // 
            // btnShinyCancel
            // 
            this.btnShinyCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnShinyCancel.Enabled = false;
            this.btnShinyCancel.ForeColor = System.Drawing.Color.Black;
            this.btnShinyCancel.Location = new System.Drawing.Point(15, 310);
            this.btnShinyCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnShinyCancel.Name = "btnShinyCancel";
            this.btnShinyCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnShinyCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.btnShinyCancel.Size = new System.Drawing.Size(212, 34);
            this.btnShinyCancel.TabIndex = 9;
            this.btnShinyCancel.Text = "取消计算";
            this.btnShinyCancel.Click += new System.EventHandler(this.btnShinyCancel_Click);
            // 
            // btnShinyGo
            // 
            this.btnShinyGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnShinyGo.ForeColor = System.Drawing.Color.Black;
            this.btnShinyGo.Location = new System.Drawing.Point(13, 270);
            this.btnShinyGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnShinyGo.Name = "btnShinyGo";
            this.btnShinyGo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnShinyGo.ShineColor = System.Drawing.SystemColors.Window;
            this.btnShinyGo.Size = new System.Drawing.Size(212, 34);
            this.btnShinyGo.TabIndex = 8;
            this.btnShinyGo.Text = "计算目标seed";
            this.btnShinyGo.Click += new System.EventHandler(this.btnShinyGo_Click);
            // 
            // txtShinyMaxDelay
            // 
            this.txtShinyMaxDelay.Hex = false;
            this.txtShinyMaxDelay.Location = new System.Drawing.Point(139, 180);
            this.txtShinyMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtShinyMaxDelay.Mask = "00000000";
            this.txtShinyMaxDelay.Name = "txtShinyMaxDelay";
            this.txtShinyMaxDelay.Size = new System.Drawing.Size(85, 23);
            this.txtShinyMaxDelay.TabIndex = 6;
            // 
            // lblShinyMaxDelay
            // 
            this.lblShinyMaxDelay.AutoSize = true;
            this.lblShinyMaxDelay.Location = new System.Drawing.Point(35, 184);
            this.lblShinyMaxDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShinyMaxDelay.Name = "lblShinyMaxDelay";
            this.lblShinyMaxDelay.Size = new System.Drawing.Size(92, 15);
            this.lblShinyMaxDelay.TabIndex = 6;
            this.lblShinyMaxDelay.Text = "最大Delay：";
            this.lblShinyMaxDelay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShinyMinDelay
            // 
            this.lblShinyMinDelay.AutoSize = true;
            this.lblShinyMinDelay.Location = new System.Drawing.Point(35, 152);
            this.lblShinyMinDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShinyMinDelay.Name = "lblShinyMinDelay";
            this.lblShinyMinDelay.Size = new System.Drawing.Size(92, 15);
            this.lblShinyMinDelay.TabIndex = 5;
            this.lblShinyMinDelay.Text = "最小Delay：";
            this.lblShinyMinDelay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtShinyMinDelay
            // 
            this.txtShinyMinDelay.Hex = false;
            this.txtShinyMinDelay.Location = new System.Drawing.Point(139, 149);
            this.txtShinyMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtShinyMinDelay.Mask = "00000000";
            this.txtShinyMinDelay.Name = "txtShinyMinDelay";
            this.txtShinyMinDelay.Size = new System.Drawing.Size(85, 23);
            this.txtShinyMinDelay.TabIndex = 5;
            // 
            // textBoxShinyYear
            // 
            this.textBoxShinyYear.Hex = false;
            this.textBoxShinyYear.Location = new System.Drawing.Point(139, 119);
            this.textBoxShinyYear.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShinyYear.Mask = "2\\000";
            this.textBoxShinyYear.Name = "textBoxShinyYear";
            this.textBoxShinyYear.Size = new System.Drawing.Size(45, 23);
            this.textBoxShinyYear.TabIndex = 4;
            // 
            // lblShinyYr
            // 
            this.lblShinyYr.AutoSize = true;
            this.lblShinyYr.Location = new System.Drawing.Point(75, 122);
            this.lblShinyYr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShinyYr.Name = "lblShinyYr";
            this.lblShinyYr.Size = new System.Drawing.Size(45, 15);
            this.lblShinyYr.TabIndex = 2;
            this.lblShinyYr.Text = "年份:";
            this.lblShinyYr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShinyPID
            // 
            this.lblShinyPID.AutoSize = true;
            this.lblShinyPID.Location = new System.Drawing.Point(7, 32);
            this.lblShinyPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShinyPID.Name = "lblShinyPID";
            this.lblShinyPID.Size = new System.Drawing.Size(130, 15);
            this.lblShinyPID.TabIndex = 1;
            this.lblShinyPID.Text = "想要的PID（Hex）";
            this.lblShinyPID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxShinyPID
            // 
            this.textBoxShinyPID.Hex = true;
            this.textBoxShinyPID.Location = new System.Drawing.Point(154, 29);
            this.textBoxShinyPID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShinyPID.Mask = "AAAAAAAA";
            this.textBoxShinyPID.Name = "textBoxShinyPID";
            this.textBoxShinyPID.Size = new System.Drawing.Size(85, 23);
            this.textBoxShinyPID.TabIndex = 1;
            // 
            // grpID
            // 
            this.grpID.Controls.Add(this.cbxIDInf);
            this.grpID.Controls.Add(this.btnIDCancel);
            this.grpID.Controls.Add(this.btnIDGo);
            this.grpID.Controls.Add(this.textBoxIDMaxDelay);
            this.grpID.Controls.Add(this.textBoxIDMinDelay);
            this.grpID.Controls.Add(this.lblIDMaxDelay);
            this.grpID.Controls.Add(this.lblIDMinDelay);
            this.grpID.Controls.Add(this.textBoxIDYear);
            this.grpID.Controls.Add(this.lblIDYr);
            this.grpID.Controls.Add(this.textBoxDesiredSID);
            this.grpID.Controls.Add(this.lblSecretID);
            this.grpID.Controls.Add(this.cbxSearchSID);
            this.grpID.Controls.Add(this.textBoxDesiredTID);
            this.grpID.Controls.Add(this.lblTrainerID);
            this.grpID.Location = new System.Drawing.Point(260, 48);
            this.grpID.Margin = new System.Windows.Forms.Padding(4);
            this.grpID.Name = "grpID";
            this.grpID.Padding = new System.Windows.Forms.Padding(4);
            this.grpID.Size = new System.Drawing.Size(244, 358);
            this.grpID.TabIndex = 2;
            this.grpID.TabStop = false;
            this.grpID.Text = "TID（表ID）";
            // 
            // cbxIDInf
            // 
            this.cbxIDInf.AutoSize = true;
            this.cbxIDInf.Location = new System.Drawing.Point(12, 210);
            this.cbxIDInf.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIDInf.Name = "cbxIDInf";
            this.cbxIDInf.Size = new System.Drawing.Size(104, 19);
            this.cbxIDInf.TabIndex = 16;
            this.cbxIDInf.Text = "无限地计算";
            this.cbxIDInf.UseVisualStyleBackColor = true;
            this.cbxIDInf.CheckedChanged += new System.EventHandler(this.cbxIDInf_CheckedChanged);
            // 
            // btnIDCancel
            // 
            this.btnIDCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIDCancel.Enabled = false;
            this.btnIDCancel.ForeColor = System.Drawing.Color.Black;
            this.btnIDCancel.Location = new System.Drawing.Point(12, 310);
            this.btnIDCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnIDCancel.Name = "btnIDCancel";
            this.btnIDCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnIDCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.btnIDCancel.Size = new System.Drawing.Size(212, 34);
            this.btnIDCancel.TabIndex = 18;
            this.btnIDCancel.Text = "取消计算";
            this.btnIDCancel.Click += new System.EventHandler(this.btnIDCancel_Click);
            // 
            // btnIDGo
            // 
            this.btnIDGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIDGo.ForeColor = System.Drawing.Color.Black;
            this.btnIDGo.Location = new System.Drawing.Point(12, 270);
            this.btnIDGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIDGo.Name = "btnIDGo";
            this.btnIDGo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnIDGo.ShineColor = System.Drawing.SystemColors.Window;
            this.btnIDGo.Size = new System.Drawing.Size(212, 34);
            this.btnIDGo.TabIndex = 17;
            this.btnIDGo.Text = "计算目标seed";
            this.btnIDGo.Click += new System.EventHandler(this.btnIDGo_Click);
            // 
            // textBoxIDMaxDelay
            // 
            this.textBoxIDMaxDelay.Hex = false;
            this.textBoxIDMaxDelay.Location = new System.Drawing.Point(141, 180);
            this.textBoxIDMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDMaxDelay.Mask = "00000000";
            this.textBoxIDMaxDelay.Name = "textBoxIDMaxDelay";
            this.textBoxIDMaxDelay.Size = new System.Drawing.Size(85, 23);
            this.textBoxIDMaxDelay.TabIndex = 15;
            // 
            // textBoxIDMinDelay
            // 
            this.textBoxIDMinDelay.Hex = false;
            this.textBoxIDMinDelay.Location = new System.Drawing.Point(141, 149);
            this.textBoxIDMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDMinDelay.Mask = "00000000";
            this.textBoxIDMinDelay.Name = "textBoxIDMinDelay";
            this.textBoxIDMinDelay.Size = new System.Drawing.Size(85, 23);
            this.textBoxIDMinDelay.TabIndex = 14;
            // 
            // lblIDMaxDelay
            // 
            this.lblIDMaxDelay.AutoSize = true;
            this.lblIDMaxDelay.Location = new System.Drawing.Point(37, 184);
            this.lblIDMaxDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMaxDelay.Name = "lblIDMaxDelay";
            this.lblIDMaxDelay.Size = new System.Drawing.Size(92, 15);
            this.lblIDMaxDelay.TabIndex = 13;
            this.lblIDMaxDelay.Text = "最大Delay：";
            this.lblIDMaxDelay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIDMinDelay
            // 
            this.lblIDMinDelay.AutoSize = true;
            this.lblIDMinDelay.Location = new System.Drawing.Point(37, 152);
            this.lblIDMinDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMinDelay.Name = "lblIDMinDelay";
            this.lblIDMinDelay.Size = new System.Drawing.Size(92, 15);
            this.lblIDMinDelay.TabIndex = 12;
            this.lblIDMinDelay.Text = "最小Delay：";
            this.lblIDMinDelay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIDYear
            // 
            this.textBoxIDYear.Hex = false;
            this.textBoxIDYear.Location = new System.Drawing.Point(141, 119);
            this.textBoxIDYear.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDYear.Mask = "2\\000";
            this.textBoxIDYear.Name = "textBoxIDYear";
            this.textBoxIDYear.Size = new System.Drawing.Size(64, 23);
            this.textBoxIDYear.TabIndex = 13;
            // 
            // lblIDYr
            // 
            this.lblIDYr.AutoSize = true;
            this.lblIDYr.Location = new System.Drawing.Point(76, 122);
            this.lblIDYr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDYr.Name = "lblIDYr";
            this.lblIDYr.Size = new System.Drawing.Size(52, 15);
            this.lblIDYr.TabIndex = 10;
            this.lblIDYr.Text = "年份：";
            this.lblIDYr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIDYr.Click += new System.EventHandler(this.lblIDYr_Click);
            // 
            // textBoxDesiredSID
            // 
            this.textBoxDesiredSID.Enabled = false;
            this.textBoxDesiredSID.Hex = false;
            this.textBoxDesiredSID.Location = new System.Drawing.Point(141, 89);
            this.textBoxDesiredSID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDesiredSID.Mask = "00000";
            this.textBoxDesiredSID.Name = "textBoxDesiredSID";
            this.textBoxDesiredSID.Size = new System.Drawing.Size(64, 23);
            this.textBoxDesiredSID.TabIndex = 12;
            // 
            // lblSecretID
            // 
            this.lblSecretID.AutoSize = true;
            this.lblSecretID.Enabled = false;
            this.lblSecretID.Location = new System.Drawing.Point(37, 92);
            this.lblSecretID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretID.Name = "lblSecretID";
            this.lblSecretID.Size = new System.Drawing.Size(91, 15);
            this.lblSecretID.TabIndex = 6;
            this.lblSecretID.Text = "想要的SID：";
            this.lblSecretID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxSearchSID
            // 
            this.cbxSearchSID.AutoSize = true;
            this.cbxSearchSID.Location = new System.Drawing.Point(12, 61);
            this.cbxSearchSID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchSID.Name = "cbxSearchSID";
            this.cbxSearchSID.Size = new System.Drawing.Size(189, 19);
            this.cbxSearchSID.TabIndex = 11;
            this.cbxSearchSID.Text = "搜索想要的SID（里ID）";
            this.cbxSearchSID.UseVisualStyleBackColor = true;
            this.cbxSearchSID.CheckedChanged += new System.EventHandler(this.cbxSearchSID_CheckedChanged);
            // 
            // textBoxDesiredTID
            // 
            this.textBoxDesiredTID.Hex = false;
            this.textBoxDesiredTID.Location = new System.Drawing.Point(144, 29);
            this.textBoxDesiredTID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDesiredTID.Mask = "00000";
            this.textBoxDesiredTID.Name = "textBoxDesiredTID";
            this.textBoxDesiredTID.Size = new System.Drawing.Size(61, 23);
            this.textBoxDesiredTID.TabIndex = 10;
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.Location = new System.Drawing.Point(8, 32);
            this.lblTrainerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(76, 15);
            this.lblTrainerID.TabIndex = 2;
            this.lblTrainerID.Text = "想要的TID";
            this.lblTrainerID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpSeed
            // 
            this.grpSeed.Controls.Add(this.lblSeedMaxDelay);
            this.grpSeed.Controls.Add(this.lblSeedMinDelay);
            this.grpSeed.Controls.Add(this.lblMinute);
            this.grpSeed.Controls.Add(this.lblHour);
            this.grpSeed.Controls.Add(this.lblSeedYr);
            this.grpSeed.Controls.Add(this.lblDay);
            this.grpSeed.Controls.Add(this.txtSeedMaxDelay);
            this.grpSeed.Controls.Add(this.btnSeedGo);
            this.grpSeed.Controls.Add(this.txtSeedMinDelay);
            this.grpSeed.Controls.Add(this.txtMinute);
            this.grpSeed.Controls.Add(this.txtHour);
            this.grpSeed.Controls.Add(this.txtSeedYr);
            this.grpSeed.Controls.Add(this.txtDay);
            this.grpSeed.Controls.Add(this.lblMonth);
            this.grpSeed.Controls.Add(this.txtMonth);
            this.grpSeed.Controls.Add(this.txtIDObtained);
            this.grpSeed.Controls.Add(this.lblIDObtained);
            this.grpSeed.Location = new System.Drawing.Point(519, 48);
            this.grpSeed.Margin = new System.Windows.Forms.Padding(4);
            this.grpSeed.Name = "grpSeed";
            this.grpSeed.Padding = new System.Windows.Forms.Padding(4);
            this.grpSeed.Size = new System.Drawing.Size(244, 358);
            this.grpSeed.TabIndex = 3;
            this.grpSeed.TabStop = false;
            this.grpSeed.Text = "反查seed";
            // 
            // lblSeedMaxDelay
            // 
            this.lblSeedMaxDelay.AutoSize = true;
            this.lblSeedMaxDelay.Location = new System.Drawing.Point(45, 244);
            this.lblSeedMaxDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeedMaxDelay.Name = "lblSeedMaxDelay";
            this.lblSeedMaxDelay.Size = new System.Drawing.Size(92, 15);
            this.lblSeedMaxDelay.TabIndex = 30;
            this.lblSeedMaxDelay.Text = "最大Delay：";
            // 
            // lblSeedMinDelay
            // 
            this.lblSeedMinDelay.AutoSize = true;
            this.lblSeedMinDelay.Location = new System.Drawing.Point(45, 214);
            this.lblSeedMinDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeedMinDelay.Name = "lblSeedMinDelay";
            this.lblSeedMinDelay.Size = new System.Drawing.Size(92, 15);
            this.lblSeedMinDelay.TabIndex = 29;
            this.lblSeedMinDelay.Text = "最小Delay：";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(85, 184);
            this.lblMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(52, 15);
            this.lblMinute.TabIndex = 28;
            this.lblMinute.Text = "分钟：";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(99, 152);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(37, 15);
            this.lblHour.TabIndex = 27;
            this.lblHour.Text = "时：";
            // 
            // lblSeedYr
            // 
            this.lblSeedYr.AutoSize = true;
            this.lblSeedYr.Location = new System.Drawing.Point(85, 122);
            this.lblSeedYr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeedYr.Name = "lblSeedYr";
            this.lblSeedYr.Size = new System.Drawing.Size(45, 15);
            this.lblSeedYr.TabIndex = 26;
            this.lblSeedYr.Text = "年份:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(99, 92);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 15);
            this.lblDay.TabIndex = 25;
            this.lblDay.Text = "日：";
            // 
            // txtSeedMaxDelay
            // 
            this.txtSeedMaxDelay.Hex = false;
            this.txtSeedMaxDelay.Location = new System.Drawing.Point(149, 240);
            this.txtSeedMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeedMaxDelay.Mask = "00000000";
            this.txtSeedMaxDelay.Name = "txtSeedMaxDelay";
            this.txtSeedMaxDelay.Size = new System.Drawing.Size(85, 23);
            this.txtSeedMaxDelay.TabIndex = 26;
            // 
            // btnSeedGo
            // 
            this.btnSeedGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSeedGo.ForeColor = System.Drawing.Color.Black;
            this.btnSeedGo.Location = new System.Drawing.Point(16, 270);
            this.btnSeedGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeedGo.Name = "btnSeedGo";
            this.btnSeedGo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSeedGo.ShineColor = System.Drawing.SystemColors.Window;
            this.btnSeedGo.Size = new System.Drawing.Size(212, 34);
            this.btnSeedGo.TabIndex = 27;
            this.btnSeedGo.Text = "反查目标seed";
            this.btnSeedGo.Click += new System.EventHandler(this.btnSeedGo_Click);
            // 
            // txtSeedMinDelay
            // 
            this.txtSeedMinDelay.Hex = false;
            this.txtSeedMinDelay.Location = new System.Drawing.Point(149, 210);
            this.txtSeedMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeedMinDelay.Mask = "00000000";
            this.txtSeedMinDelay.Name = "txtSeedMinDelay";
            this.txtSeedMinDelay.Size = new System.Drawing.Size(85, 23);
            this.txtSeedMinDelay.TabIndex = 25;
            // 
            // txtMinute
            // 
            this.txtMinute.Hex = false;
            this.txtMinute.Location = new System.Drawing.Point(149, 180);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinute.Mask = "00";
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(31, 23);
            this.txtMinute.TabIndex = 24;
            // 
            // txtHour
            // 
            this.txtHour.Hex = false;
            this.txtHour.Location = new System.Drawing.Point(149, 149);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtHour.Mask = "00";
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(31, 23);
            this.txtHour.TabIndex = 23;
            // 
            // txtSeedYr
            // 
            this.txtSeedYr.Hex = false;
            this.txtSeedYr.Location = new System.Drawing.Point(149, 119);
            this.txtSeedYr.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeedYr.Mask = "2\\000";
            this.txtSeedYr.Name = "txtSeedYr";
            this.txtSeedYr.Size = new System.Drawing.Size(45, 23);
            this.txtSeedYr.TabIndex = 22;
            // 
            // txtDay
            // 
            this.txtDay.Hex = false;
            this.txtDay.Location = new System.Drawing.Point(149, 89);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Mask = "00";
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(31, 23);
            this.txtDay.TabIndex = 21;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(85, 62);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(45, 15);
            this.lblMonth.TabIndex = 17;
            this.lblMonth.Text = "月份:";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMonth
            // 
            this.txtMonth.Hex = false;
            this.txtMonth.Location = new System.Drawing.Point(149, 58);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.Mask = "00";
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(31, 23);
            this.txtMonth.TabIndex = 20;
            // 
            // txtIDObtained
            // 
            this.txtIDObtained.Hex = false;
            this.txtIDObtained.Location = new System.Drawing.Point(149, 29);
            this.txtIDObtained.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDObtained.Mask = "00000";
            this.txtIDObtained.Name = "txtIDObtained";
            this.txtIDObtained.Size = new System.Drawing.Size(64, 23);
            this.txtIDObtained.TabIndex = 19;
            // 
            // lblIDObtained
            // 
            this.lblIDObtained.AutoSize = true;
            this.lblIDObtained.Location = new System.Drawing.Point(45, 32);
            this.lblIDObtained.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDObtained.Name = "lblIDObtained";
            this.lblIDObtained.Size = new System.Drawing.Size(91, 15);
            this.lblIDObtained.TabIndex = 0;
            this.lblIDObtained.Text = "击中的TID：";
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAction});
            this.StatusBar.Location = new System.Drawing.Point(0, 665);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusBar.Size = new System.Drawing.Size(824, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 5;
            // 
            // lblAction
            // 
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(81, 20);
            this.lblAction.Text = "等待操作...";
            // 
            // bgwShiny
            // 
            this.bgwShiny.WorkerReportsProgress = true;
            this.bgwShiny.WorkerSupportsCancellation = true;
            this.bgwShiny.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwShiny_DoWork);
            this.bgwShiny.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwShiny_RunWorkerCompleted);
            // 
            // bgwID
            // 
            this.bgwID.WorkerReportsProgress = true;
            this.bgwID.WorkerSupportsCancellation = true;
            this.bgwID.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwID_DoWork);
            this.bgwID.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwID_RunWorkerCompleted);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.generateTimesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStripCap";
            this.contextMenuStrip.Size = new System.Drawing.Size(253, 58);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copySeedToClipboardToolStripMenuItem1
            // 
            this.copySeedToClipboardToolStripMenuItem1.Name = "copySeedToClipboardToolStripMenuItem1";
            this.copySeedToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.copySeedToClipboardToolStripMenuItem1.Text = "复制Seed到剪贴板";
            this.copySeedToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.copySeedToClipboardToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(249, 6);
            // 
            // generateTimesToolStripMenuItem
            // 
            this.generateTimesToolStripMenuItem.Name = "generateTimesToolStripMenuItem";
            this.generateTimesToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.generateTimesToolStripMenuItem.Text = "Generate More Times ...";
            this.generateTimesToolStripMenuItem.Click += new System.EventHandler(this.generateTimesToolStripMenuItem_Click);
            // 
            // bgwIDInf
            // 
            this.bgwIDInf.WorkerReportsProgress = true;
            this.bgwIDInf.WorkerSupportsCancellation = true;
            this.bgwIDInf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIDInf_DoWork);
            this.bgwIDInf.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwIDInf_RunWorkerCompleted);
            // 
            // lblSimple
            // 
            this.lblSimple.AutoSize = true;
            this.lblSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(213)))));
            this.lblSimple.Location = new System.Drawing.Point(8, 15);
            this.lblSimple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimple.Name = "lblSimple";
            this.lblSimple.Size = new System.Drawing.Size(192, 15);
            this.lblSimple.TabIndex = 26;
            this.lblSimple.Text = "根据seed简单地计算ID/SID";
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(220, 15);
            this.lblSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(123, 15);
            this.lblSeed.TabIndex = 27;
            this.lblSeed.Text = "Seed （16进制）";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnSimpleGo);
            this.GroupBox1.Controls.Add(this.textBoxSeed);
            this.GroupBox1.Controls.Add(this.lblSeed);
            this.GroupBox1.Controls.Add(this.lblSimple);
            this.GroupBox1.Location = new System.Drawing.Point(260, 1);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(501, 39);
            this.GroupBox1.TabIndex = 30;
            this.GroupBox1.TabStop = false;
            // 
            // btnSimpleGo
            // 
            this.btnSimpleGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSimpleGo.ForeColor = System.Drawing.Color.Black;
            this.btnSimpleGo.Location = new System.Drawing.Point(436, 8);
            this.btnSimpleGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpleGo.Name = "btnSimpleGo";
            this.btnSimpleGo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSimpleGo.ShineColor = System.Drawing.SystemColors.Window;
            this.btnSimpleGo.Size = new System.Drawing.Size(51, 28);
            this.btnSimpleGo.TabIndex = 30;
            this.btnSimpleGo.Text = "Go";
            this.btnSimpleGo.Click += new System.EventHandler(this.btnSimpleGo_Click);
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Hex = true;
            this.textBoxSeed.Location = new System.Drawing.Point(341, 11);
            this.textBoxSeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeed.Mask = "AAAAAAAA";
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(85, 23);
            this.textBoxSeed.TabIndex = 29;
            // 
            // bgwShinyInf
            // 
            this.bgwShinyInf.WorkerReportsProgress = true;
            this.bgwShinyInf.WorkerSupportsCancellation = true;
            this.bgwShinyInf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwShinyInf_DoWork);
            this.bgwShinyInf.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwShinyInf_RunWorkerCompleted);
            // 
            // tabGenSelect
            // 
            this.tabGenSelect.Controls.Add(this.tabXDColo);
            this.tabGenSelect.Controls.Add(this.tabGen3FRLGE);
            this.tabGenSelect.Controls.Add(this.tabGen3RS);
            this.tabGenSelect.Controls.Add(this.tabGen4);
            this.tabGenSelect.Controls.Add(this.tabGen5);
            this.tabGenSelect.Location = new System.Drawing.Point(16, 6);
            this.tabGenSelect.Margin = new System.Windows.Forms.Padding(4);
            this.tabGenSelect.Name = "tabGenSelect";
            this.tabGenSelect.SelectedIndex = 0;
            this.tabGenSelect.Size = new System.Drawing.Size(795, 444);
            this.tabGenSelect.TabIndex = 31;
            this.tabGenSelect.SelectedIndexChanged += new System.EventHandler(this.tabGenSelect_SelectedIndexChanged);
            // 
            // tabXDColo
            // 
            this.tabXDColo.Controls.Add(this.labelXDColo);
            this.tabXDColo.Controls.Add(this.genCancelXDColo);
            this.tabXDColo.Controls.Add(this.searchGenXDColo);
            this.tabXDColo.Controls.Add(this.groupBox7);
            this.tabXDColo.Controls.Add(this.groupBox6);
            this.tabXDColo.Location = new System.Drawing.Point(4, 25);
            this.tabXDColo.Margin = new System.Windows.Forms.Padding(4);
            this.tabXDColo.Name = "tabXDColo";
            this.tabXDColo.Size = new System.Drawing.Size(787, 415);
            this.tabXDColo.TabIndex = 4;
            this.tabXDColo.Text = "XD/Colo";
            this.tabXDColo.UseVisualStyleBackColor = true;
            // 
            // labelXDColo
            // 
            this.labelXDColo.Font = new System.Drawing.Font("宋体", 10F);
            this.labelXDColo.Location = new System.Drawing.Point(4, 294);
            this.labelXDColo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXDColo.Name = "labelXDColo";
            this.labelXDColo.Size = new System.Drawing.Size(378, 35);
            this.labelXDColo.TabIndex = 123;
            this.labelXDColo.Text = "此功能只适用于XD暗之旋风和Colo竞技场。";
            // 
            // genCancelXDColo
            // 
            this.genCancelXDColo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genCancelXDColo.ForeColor = System.Drawing.Color.Black;
            this.genCancelXDColo.Location = new System.Drawing.Point(272, 254);
            this.genCancelXDColo.Margin = new System.Windows.Forms.Padding(4);
            this.genCancelXDColo.Name = "genCancelXDColo";
            this.genCancelXDColo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.genCancelXDColo.ShineColor = System.Drawing.SystemColors.Window;
            this.genCancelXDColo.Size = new System.Drawing.Size(236, 29);
            this.genCancelXDColo.TabIndex = 122;
            this.genCancelXDColo.Text = "取消计算";
            this.genCancelXDColo.Click += new System.EventHandler(this.genCancelXDColo_Click);
            // 
            // searchGenXDColo
            // 
            this.searchGenXDColo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.searchGenXDColo.ForeColor = System.Drawing.Color.Black;
            this.searchGenXDColo.Location = new System.Drawing.Point(4, 254);
            this.searchGenXDColo.Margin = new System.Windows.Forms.Padding(4);
            this.searchGenXDColo.Name = "searchGenXDColo";
            this.searchGenXDColo.OuterBorderColor = System.Drawing.Color.Transparent;
            this.searchGenXDColo.ShineColor = System.Drawing.SystemColors.Window;
            this.searchGenXDColo.Size = new System.Drawing.Size(260, 29);
            this.searchGenXDColo.TabIndex = 32;
            this.searchGenXDColo.Text = "计算目标ID帧数";
            this.searchGenXDColo.Click += new System.EventHandler(this.searchGenXDColo_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.XDColoMaxFrame);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.XDColoMinFrame);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(272, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(236, 89);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "计算参数";
            // 
            // XDColoMaxFrame
            // 
            this.XDColoMaxFrame.Hex = false;
            this.XDColoMaxFrame.Location = new System.Drawing.Point(96, 58);
            this.XDColoMaxFrame.Margin = new System.Windows.Forms.Padding(4);
            this.XDColoMaxFrame.Mask = "000000";
            this.XDColoMaxFrame.Name = "XDColoMaxFrame";
            this.XDColoMaxFrame.Size = new System.Drawing.Size(119, 23);
            this.XDColoMaxFrame.TabIndex = 7;
            this.XDColoMaxFrame.Text = "10000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 28);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "最小帧:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // XDColoMinFrame
            // 
            this.XDColoMinFrame.Hex = false;
            this.XDColoMinFrame.Location = new System.Drawing.Point(96, 28);
            this.XDColoMinFrame.Margin = new System.Windows.Forms.Padding(4);
            this.XDColoMinFrame.Mask = "000000";
            this.XDColoMinFrame.Name = "XDColoMinFrame";
            this.XDColoMinFrame.Size = new System.Drawing.Size(119, 23);
            this.XDColoMinFrame.TabIndex = 6;
            this.XDColoMinFrame.Text = "5000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "最大帧:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.XDColoPID);
            this.groupBox6.Controls.Add(this.XDColoPRNG);
            this.groupBox6.Location = new System.Drawing.Point(4, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(260, 89);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "计算条件";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "PRNG";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "PID";
            // 
            // XDColoPID
            // 
            this.XDColoPID.Hex = true;
            this.XDColoPID.Location = new System.Drawing.Point(83, 20);
            this.XDColoPID.Margin = new System.Windows.Forms.Padding(4);
            this.XDColoPID.Mask = "AAAAAAAA";
            this.XDColoPID.Name = "XDColoPID";
            this.XDColoPID.Size = new System.Drawing.Size(157, 23);
            this.XDColoPID.TabIndex = 7;
            this.toolTips.SetToolTip(this.XDColoPID, "Enter the PID you want shiny.");
            // 
            // XDColoPRNG
            // 
            this.XDColoPRNG.Hex = true;
            this.XDColoPRNG.Location = new System.Drawing.Point(83, 50);
            this.XDColoPRNG.Margin = new System.Windows.Forms.Padding(4);
            this.XDColoPRNG.Mask = "AAAAAAAA";
            this.XDColoPRNG.Name = "XDColoPRNG";
            this.XDColoPRNG.Size = new System.Drawing.Size(157, 23);
            this.XDColoPRNG.TabIndex = 3;
            this.toolTips.SetToolTip(this.XDColoPRNG, "Enter the current PRNG state.");
            // 
            // tabGen3FRLGE
            // 
            this.tabGen3FRLGE.Controls.Add(this.label11);
            this.tabGen3FRLGE.Controls.Add(this.genCancelFRLGE);
            this.tabGen3FRLGE.Controls.Add(this.genSearchFRLGE);
            this.tabGen3FRLGE.Controls.Add(this.groupBox5);
            this.tabGen3FRLGE.Controls.Add(this.groupBox2);
            this.tabGen3FRLGE.Location = new System.Drawing.Point(4, 25);
            this.tabGen3FRLGE.Margin = new System.Windows.Forms.Padding(4);
            this.tabGen3FRLGE.Name = "tabGen3FRLGE";
            this.tabGen3FRLGE.Size = new System.Drawing.Size(787, 415);
            this.tabGen3FRLGE.TabIndex = 3;
            this.tabGen3FRLGE.Text = "GEN3 火红叶绿绿宝石";
            this.tabGen3FRLGE.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(4, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(413, 35);
            this.label11.TabIndex = 122;
            this.label11.Text = "此功能只适用于火红，叶绿和绿宝石。";
            // 
            // genCancelFRLGE
            // 
            this.genCancelFRLGE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genCancelFRLGE.ForeColor = System.Drawing.Color.Black;
            this.genCancelFRLGE.Location = new System.Drawing.Point(272, 254);
            this.genCancelFRLGE.Margin = new System.Windows.Forms.Padding(4);
            this.genCancelFRLGE.Name = "genCancelFRLGE";
            this.genCancelFRLGE.OuterBorderColor = System.Drawing.Color.Transparent;
            this.genCancelFRLGE.ShineColor = System.Drawing.SystemColors.Window;
            this.genCancelFRLGE.Size = new System.Drawing.Size(236, 29);
            this.genCancelFRLGE.TabIndex = 121;
            this.genCancelFRLGE.Text = "取消计算";
            this.genCancelFRLGE.Click += new System.EventHandler(this.genCancelFRLGE_Click);
            // 
            // genSearchFRLGE
            // 
            this.genSearchFRLGE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.genSearchFRLGE.ForeColor = System.Drawing.Color.Black;
            this.genSearchFRLGE.Location = new System.Drawing.Point(4, 254);
            this.genSearchFRLGE.Margin = new System.Windows.Forms.Padding(4);
            this.genSearchFRLGE.Name = "genSearchFRLGE";
            this.genSearchFRLGE.OuterBorderColor = System.Drawing.Color.Transparent;
            this.genSearchFRLGE.ShineColor = System.Drawing.SystemColors.Window;
            this.genSearchFRLGE.Size = new System.Drawing.Size(260, 29);
            this.genSearchFRLGE.TabIndex = 31;
            this.genSearchFRLGE.Text = "计算目标ID帧数";
            this.genSearchFRLGE.Click += new System.EventHandler(this.genSearchFRLGE_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.genFRLGEMaxFrame);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.genFRLGEMinFrame);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(272, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(236, 89);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "计算参数";
            // 
            // genFRLGEMaxFrame
            // 
            this.genFRLGEMaxFrame.Hex = false;
            this.genFRLGEMaxFrame.Location = new System.Drawing.Point(96, 58);
            this.genFRLGEMaxFrame.Margin = new System.Windows.Forms.Padding(4);
            this.genFRLGEMaxFrame.Mask = "000000";
            this.genFRLGEMaxFrame.Name = "genFRLGEMaxFrame";
            this.genFRLGEMaxFrame.Size = new System.Drawing.Size(119, 23);
            this.genFRLGEMaxFrame.TabIndex = 7;
            this.genFRLGEMaxFrame.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "最小帧:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // genFRLGEMinFrame
            // 
            this.genFRLGEMinFrame.Hex = false;
            this.genFRLGEMinFrame.Location = new System.Drawing.Point(96, 28);
            this.genFRLGEMinFrame.Margin = new System.Windows.Forms.Padding(4);
            this.genFRLGEMinFrame.Mask = "000000";
            this.genFRLGEMinFrame.Name = "genFRLGEMinFrame";
            this.genFRLGEMinFrame.Size = new System.Drawing.Size(119, 23);
            this.genFRLGEMinFrame.TabIndex = 6;
            this.genFRLGEMinFrame.Text = "5000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "最大帧:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.genFRLGEPID);
            this.groupBox2.Controls.Add(this.genFRLGETID);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(260, 89);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算条件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "TID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "PID";
            // 
            // genFRLGEPID
            // 
            this.genFRLGEPID.Hex = true;
            this.genFRLGEPID.Location = new System.Drawing.Point(83, 20);
            this.genFRLGEPID.Margin = new System.Windows.Forms.Padding(4);
            this.genFRLGEPID.Mask = "AAAAAAAA";
            this.genFRLGEPID.Name = "genFRLGEPID";
            this.genFRLGEPID.Size = new System.Drawing.Size(157, 23);
            this.genFRLGEPID.TabIndex = 7;
            this.toolTips.SetToolTip(this.genFRLGEPID, "Enter the PID you want shiny.");
            // 
            // genFRLGETID
            // 
            this.genFRLGETID.Hex = false;
            this.genFRLGETID.Location = new System.Drawing.Point(83, 50);
            this.genFRLGETID.Margin = new System.Windows.Forms.Padding(4);
            this.genFRLGETID.Mask = "00000";
            this.genFRLGETID.Name = "genFRLGETID";
            this.genFRLGETID.Size = new System.Drawing.Size(157, 23);
            this.genFRLGETID.TabIndex = 3;
            this.genFRLGETID.Tag = "id/sid";
            this.toolTips.SetToolTip(this.genFRLGETID, "Enter the TID you obtained.");
            // 
            // tabGen3RS
            // 
            this.tabGen3RS.Controls.Add(this.buttonIIICancel);
            this.tabGen3RS.Controls.Add(this.groupBox4);
            this.tabGen3RS.Controls.Add(this.buttonIIIFindFrames);
            this.tabGen3RS.Controls.Add(this.groupBox3);
            this.tabGen3RS.Location = new System.Drawing.Point(4, 25);
            this.tabGen3RS.Margin = new System.Windows.Forms.Padding(4);
            this.tabGen3RS.Name = "tabGen3RS";
            this.tabGen3RS.Padding = new System.Windows.Forms.Padding(4);
            this.tabGen3RS.Size = new System.Drawing.Size(787, 415);
            this.tabGen3RS.TabIndex = 2;
            this.tabGen3RS.Text = "GEN3 红/蓝宝石";
            this.tabGen3RS.UseVisualStyleBackColor = true;
            // 
            // buttonIIICancel
            // 
            this.buttonIIICancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonIIICancel.ForeColor = System.Drawing.Color.Black;
            this.buttonIIICancel.Location = new System.Drawing.Point(276, 261);
            this.buttonIIICancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIIICancel.Name = "buttonIIICancel";
            this.buttonIIICancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonIIICancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonIIICancel.Size = new System.Drawing.Size(236, 29);
            this.buttonIIICancel.TabIndex = 120;
            this.buttonIIICancel.Text = "取消计算";
            this.buttonIIICancel.Click += new System.EventHandler(this.buttonIIICancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBox21);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.checkIIIClock);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textIIIMaxFrame);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textIIIMinFrame);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textIIIMinute);
            this.groupBox4.Controls.Add(this.dateIII);
            this.groupBox4.Controls.Add(this.textIIIHour);
            this.groupBox4.Location = new System.Drawing.Point(276, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(264, 248);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "计算参数";
            // 
            // maskedTextBox21
            // 
            this.maskedTextBox21.Enabled = false;
            this.maskedTextBox21.Hex = true;
            this.maskedTextBox21.Location = new System.Drawing.Point(131, 50);
            this.maskedTextBox21.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox21.Mask = "AAAA";
            this.maskedTextBox21.Name = "maskedTextBox21";
            this.maskedTextBox21.ReadOnly = true;
            this.maskedTextBox21.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox21.TabIndex = 123;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(20, 52);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 19);
            this.radioButton1.TabIndex = 121;
            this.radioButton1.Text = "初始Seed:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(20, 82);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 19);
            this.radioButton2.TabIndex = 122;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日期:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkIIIClock
            // 
            this.checkIIIClock.AutoSize = true;
            this.checkIIIClock.Checked = true;
            this.checkIIIClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIIIClock.Location = new System.Drawing.Point(20, 22);
            this.checkIIIClock.Margin = new System.Windows.Forms.Padding(4);
            this.checkIIIClock.Name = "checkIIIClock";
            this.checkIIIClock.Size = new System.Drawing.Size(89, 19);
            this.checkIIIClock.TabIndex = 33;
            this.checkIIIClock.Text = "电池没电";
            this.checkIIIClock.UseVisualStyleBackColor = true;
            this.checkIIIClock.CheckedChanged += new System.EventHandler(this.checkIIIClock_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "分钟:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textIIIMaxFrame
            // 
            this.textIIIMaxFrame.Hex = false;
            this.textIIIMaxFrame.Location = new System.Drawing.Point(96, 202);
            this.textIIIMaxFrame.Margin = new System.Windows.Forms.Padding(4);
            this.textIIIMaxFrame.Mask = "000000";
            this.textIIIMaxFrame.Name = "textIIIMaxFrame";
            this.textIIIMaxFrame.Size = new System.Drawing.Size(119, 23);
            this.textIIIMaxFrame.TabIndex = 7;
            this.textIIIMaxFrame.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "最小帧:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "时:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textIIIMinFrame
            // 
            this.textIIIMinFrame.Hex = false;
            this.textIIIMinFrame.Location = new System.Drawing.Point(96, 172);
            this.textIIIMinFrame.Margin = new System.Windows.Forms.Padding(4);
            this.textIIIMinFrame.Mask = "000000";
            this.textIIIMinFrame.Name = "textIIIMinFrame";
            this.textIIIMinFrame.Size = new System.Drawing.Size(119, 23);
            this.textIIIMinFrame.TabIndex = 6;
            this.textIIIMinFrame.Text = "5000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "最大帧:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textIIIMinute
            // 
            this.textIIIMinute.Enabled = false;
            this.textIIIMinute.Hex = false;
            this.textIIIMinute.Location = new System.Drawing.Point(96, 142);
            this.textIIIMinute.Margin = new System.Windows.Forms.Padding(4);
            this.textIIIMinute.Mask = "00";
            this.textIIIMinute.Name = "textIIIMinute";
            this.textIIIMinute.Size = new System.Drawing.Size(31, 23);
            this.textIIIMinute.TabIndex = 30;
            this.textIIIMinute.Text = "0";
            // 
            // dateIII
            // 
            this.dateIII.CustomFormat = "";
            this.dateIII.Enabled = false;
            this.dateIII.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIII.Location = new System.Drawing.Point(96, 80);
            this.dateIII.Margin = new System.Windows.Forms.Padding(4);
            this.dateIII.MaxDate = new System.DateTime(2038, 1, 19, 0, 0, 0, 0);
            this.dateIII.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateIII.Name = "dateIII";
            this.dateIII.Size = new System.Drawing.Size(131, 25);
            this.dateIII.TabIndex = 10;
            this.toolTips.SetToolTip(this.dateIII, "Select the date to search.");
            this.dateIII.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textIIIHour
            // 
            this.textIIIHour.Enabled = false;
            this.textIIIHour.Hex = false;
            this.textIIIHour.Location = new System.Drawing.Point(96, 110);
            this.textIIIHour.Margin = new System.Windows.Forms.Padding(4);
            this.textIIIHour.Mask = "00";
            this.textIIIHour.Name = "textIIIHour";
            this.textIIIHour.Size = new System.Drawing.Size(31, 23);
            this.textIIIHour.TabIndex = 29;
            this.textIIIHour.Text = "0";
            // 
            // buttonIIIFindFrames
            // 
            this.buttonIIIFindFrames.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonIIIFindFrames.ForeColor = System.Drawing.Color.Black;
            this.buttonIIIFindFrames.Location = new System.Drawing.Point(8, 261);
            this.buttonIIIFindFrames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIIIFindFrames.Name = "buttonIIIFindFrames";
            this.buttonIIIFindFrames.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonIIIFindFrames.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonIIIFindFrames.Size = new System.Drawing.Size(260, 29);
            this.buttonIIIFindFrames.TabIndex = 26;
            this.buttonIIIFindFrames.Text = "计算目标ID帧数";
            this.buttonIIIFindFrames.Click += new System.EventHandler(this.buttonIIIFindFrames_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textIIISID);
            this.groupBox3.Controls.Add(this.checkIIISID);
            this.groupBox3.Controls.Add(this.checkIIIPID);
            this.groupBox3.Controls.Add(this.textIIIPID);
            this.groupBox3.Controls.Add(this.textIIITID);
            this.groupBox3.Controls.Add(this.checkIIITID);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(260, 112);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计算条件";
            // 
            // textIIISID
            // 
            this.textIIISID.Enabled = false;
            this.textIIISID.Hex = false;
            this.textIIISID.Location = new System.Drawing.Point(83, 78);
            this.textIIISID.Margin = new System.Windows.Forms.Padding(4);
            this.textIIISID.Mask = "00000";
            this.textIIISID.Name = "textIIISID";
            this.textIIISID.Size = new System.Drawing.Size(157, 23);
            this.textIIISID.TabIndex = 9;
            this.textIIISID.Tag = "id/sid";
            this.toolTips.SetToolTip(this.textIIISID, "Enter TID to search for here.");
            // 
            // checkIIISID
            // 
            this.checkIIISID.AutoSize = true;
            this.checkIIISID.Location = new System.Drawing.Point(8, 80);
            this.checkIIISID.Margin = new System.Windows.Forms.Padding(4);
            this.checkIIISID.Name = "checkIIISID";
            this.checkIIISID.Size = new System.Drawing.Size(69, 19);
            this.checkIIISID.TabIndex = 8;
            this.checkIIISID.Text = "SID: ";
            this.checkIIISID.UseVisualStyleBackColor = true;
            this.checkIIISID.CheckedChanged += new System.EventHandler(this.checkIIISID_CheckedChanged);
            // 
            // checkIIIPID
            // 
            this.checkIIIPID.AutoSize = true;
            this.checkIIIPID.Location = new System.Drawing.Point(8, 22);
            this.checkIIIPID.Margin = new System.Windows.Forms.Padding(4);
            this.checkIIIPID.Name = "checkIIIPID";
            this.checkIIIPID.Size = new System.Drawing.Size(61, 19);
            this.checkIIIPID.TabIndex = 6;
            this.checkIIIPID.Text = "PID:";
            this.checkIIIPID.UseVisualStyleBackColor = true;
            this.checkIIIPID.CheckedChanged += new System.EventHandler(this.checkIIIPID_CheckedChanged);
            // 
            // textIIIPID
            // 
            this.textIIIPID.Enabled = false;
            this.textIIIPID.Hex = true;
            this.textIIIPID.Location = new System.Drawing.Point(83, 20);
            this.textIIIPID.Margin = new System.Windows.Forms.Padding(4);
            this.textIIIPID.Mask = "AAAAAAAA";
            this.textIIIPID.Name = "textIIIPID";
            this.textIIIPID.Size = new System.Drawing.Size(157, 23);
            this.textIIIPID.TabIndex = 7;
            this.toolTips.SetToolTip(this.textIIIPID, "Enter the full seed given by RNG Reporter.");
            // 
            // textIIITID
            // 
            this.textIIITID.Enabled = false;
            this.textIIITID.Hex = false;
            this.textIIITID.Location = new System.Drawing.Point(83, 50);
            this.textIIITID.Margin = new System.Windows.Forms.Padding(4);
            this.textIIITID.Mask = "00000";
            this.textIIITID.Name = "textIIITID";
            this.textIIITID.Size = new System.Drawing.Size(157, 23);
            this.textIIITID.TabIndex = 3;
            this.textIIITID.Tag = "id/sid";
            this.toolTips.SetToolTip(this.textIIITID, "Enter TID to search for here.");
            // 
            // checkIIITID
            // 
            this.checkIIITID.AutoSize = true;
            this.checkIIITID.Location = new System.Drawing.Point(8, 52);
            this.checkIIITID.Margin = new System.Windows.Forms.Padding(4);
            this.checkIIITID.Name = "checkIIITID";
            this.checkIIITID.Size = new System.Drawing.Size(69, 19);
            this.checkIIITID.TabIndex = 2;
            this.checkIIITID.Text = "TID: ";
            this.checkIIITID.UseVisualStyleBackColor = true;
            this.checkIIITID.CheckedChanged += new System.EventHandler(this.checkIIITID_CheckedChanged);
            // 
            // tabGen4
            // 
            this.tabGen4.Controls.Add(this.labelBy);
            this.tabGen4.Controls.Add(this.GroupBox1);
            this.tabGen4.Controls.Add(this.grpShiny);
            this.tabGen4.Controls.Add(this.grpID);
            this.tabGen4.Controls.Add(this.grpSeed);
            this.tabGen4.Controls.Add(this.btnCredits);
            this.tabGen4.Location = new System.Drawing.Point(4, 25);
            this.tabGen4.Margin = new System.Windows.Forms.Padding(4);
            this.tabGen4.Name = "tabGen4";
            this.tabGen4.Padding = new System.Windows.Forms.Padding(4);
            this.tabGen4.Size = new System.Drawing.Size(787, 415);
            this.tabGen4.TabIndex = 0;
            this.tabGen4.Text = "GEN4";
            this.tabGen4.UseVisualStyleBackColor = true;
            // 
            // labelBy
            // 
            this.labelBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBy.AutoSize = true;
            this.labelBy.Location = new System.Drawing.Point(19, 16);
            this.labelBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(87, 15);
            this.labelBy.TabIndex = 32;
            this.labelBy.Text = "By WildEep";
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCredits.ForeColor = System.Drawing.Color.Black;
            this.btnCredits.Location = new System.Drawing.Point(132, 8);
            this.btnCredits.Margin = new System.Windows.Forms.Padding(4);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnCredits.ShineColor = System.Drawing.SystemColors.Window;
            this.btnCredits.Size = new System.Drawing.Size(120, 34);
            this.btnCredits.TabIndex = 0;
            this.btnCredits.Text = "感谢名单";
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // tabGen5
            // 
            this.tabGen5.Controls.Add(this.buttonVFindSeedHit);
            this.tabGen5.Controls.Add(this.groupVSeedFinder);
            this.tabGen5.Controls.Add(this.groupVDSParams);
            this.tabGen5.Controls.Add(this.groupVSearchParams);
            this.tabGen5.Controls.Add(this.groupVPID);
            this.tabGen5.Controls.Add(this.buttonVFindSeeds);
            this.tabGen5.Controls.Add(this.buttonVCancel);
            this.tabGen5.Location = new System.Drawing.Point(4, 25);
            this.tabGen5.Margin = new System.Windows.Forms.Padding(4);
            this.tabGen5.Name = "tabGen5";
            this.tabGen5.Padding = new System.Windows.Forms.Padding(4);
            this.tabGen5.Size = new System.Drawing.Size(787, 415);
            this.tabGen5.TabIndex = 1;
            this.tabGen5.Text = "GEN5";
            this.tabGen5.UseVisualStyleBackColor = true;
            // 
            // buttonVFindSeedHit
            // 
            this.buttonVFindSeedHit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonVFindSeedHit.ForeColor = System.Drawing.Color.Black;
            this.buttonVFindSeedHit.Location = new System.Drawing.Point(277, 379);
            this.buttonVFindSeedHit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVFindSeedHit.Name = "buttonVFindSeedHit";
            this.buttonVFindSeedHit.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonVFindSeedHit.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonVFindSeedHit.Size = new System.Drawing.Size(253, 29);
            this.buttonVFindSeedHit.TabIndex = 15;
            this.buttonVFindSeedHit.Text = "反查击中seed";
            this.buttonVFindSeedHit.Click += new System.EventHandler(this.buttonVFindSeedHit_Click);
            // 
            // groupVSeedFinder
            // 
            this.groupVSeedFinder.Controls.Add(this.textVMinute);
            this.groupVSeedFinder.Controls.Add(this.textVHour);
            this.groupVSeedFinder.Controls.Add(this.labelTIDReceived);
            this.groupVSeedFinder.Controls.Add(this.labelVMinute);
            this.groupVSeedFinder.Controls.Add(this.textVTIDReceived);
            this.groupVSeedFinder.Controls.Add(this.textVMaxSec);
            this.groupVSeedFinder.Controls.Add(this.labelVHour);
            this.groupVSeedFinder.Controls.Add(this.textVMinSec);
            this.groupVSeedFinder.Controls.Add(this.label1);
            this.groupVSeedFinder.Controls.Add(this.textVMaxFrameHit);
            this.groupVSeedFinder.Controls.Add(this.dateTimeSeedSearch);
            this.groupVSeedFinder.Controls.Add(this.label3);
            this.groupVSeedFinder.Controls.Add(this.textVMinFrameHit);
            this.groupVSeedFinder.Controls.Add(this.label2);
            this.groupVSeedFinder.Location = new System.Drawing.Point(277, 201);
            this.groupVSeedFinder.Margin = new System.Windows.Forms.Padding(4);
            this.groupVSeedFinder.Name = "groupVSeedFinder";
            this.groupVSeedFinder.Padding = new System.Windows.Forms.Padding(4);
            this.groupVSeedFinder.Size = new System.Drawing.Size(253, 171);
            this.groupVSeedFinder.TabIndex = 24;
            this.groupVSeedFinder.TabStop = false;
            this.groupVSeedFinder.Text = "反查seed";
            // 
            // textVMinute
            // 
            this.textVMinute.Hex = false;
            this.textVMinute.Location = new System.Drawing.Point(185, 78);
            this.textVMinute.Margin = new System.Windows.Forms.Padding(4);
            this.textVMinute.Name = "textVMinute";
            this.textVMinute.Size = new System.Drawing.Size(53, 23);
            this.textVMinute.TabIndex = 10;
            this.textVMinute.Text = "0";
            this.toolTips.SetToolTip(this.textVMinute, "Enter the minute you started your game/");
            // 
            // textVHour
            // 
            this.textVHour.Hex = false;
            this.textVHour.Location = new System.Drawing.Point(56, 78);
            this.textVHour.Margin = new System.Windows.Forms.Padding(4);
            this.textVHour.Name = "textVHour";
            this.textVHour.Size = new System.Drawing.Size(57, 23);
            this.textVHour.TabIndex = 11;
            this.textVHour.Text = "0";
            this.toolTips.SetToolTip(this.textVHour, "Enter the hour that you started the game.");
            // 
            // labelTIDReceived
            // 
            this.labelTIDReceived.AutoSize = true;
            this.labelTIDReceived.Location = new System.Drawing.Point(8, 21);
            this.labelTIDReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTIDReceived.Name = "labelTIDReceived";
            this.labelTIDReceived.Size = new System.Drawing.Size(68, 15);
            this.labelTIDReceived.TabIndex = 22;
            this.labelTIDReceived.Text = "击中的ID";
            // 
            // labelVMinute
            // 
            this.labelVMinute.AutoSize = true;
            this.labelVMinute.Location = new System.Drawing.Point(127, 81);
            this.labelVMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVMinute.Name = "labelVMinute";
            this.labelVMinute.Size = new System.Drawing.Size(45, 15);
            this.labelVMinute.TabIndex = 25;
            this.labelVMinute.Text = "分钟:";
            // 
            // textVTIDReceived
            // 
            this.textVTIDReceived.Hex = false;
            this.textVTIDReceived.Location = new System.Drawing.Point(112, 18);
            this.textVTIDReceived.Margin = new System.Windows.Forms.Padding(4);
            this.textVTIDReceived.Mask = "00000";
            this.textVTIDReceived.Name = "textVTIDReceived";
            this.textVTIDReceived.Size = new System.Drawing.Size(132, 23);
            this.textVTIDReceived.TabIndex = 8;
            this.toolTips.SetToolTip(this.textVTIDReceived, "Enter the ID you received here to see what seed you hit.");
            // 
            // textVMaxSec
            // 
            this.textVMaxSec.Hex = false;
            this.textVMaxSec.Location = new System.Drawing.Point(185, 109);
            this.textVMaxSec.Margin = new System.Windows.Forms.Padding(4);
            this.textVMaxSec.Name = "textVMaxSec";
            this.textVMaxSec.Size = new System.Drawing.Size(57, 23);
            this.textVMaxSec.TabIndex = 13;
            this.textVMaxSec.Text = "59";
            // 
            // labelVHour
            // 
            this.labelVHour.AutoSize = true;
            this.labelVHour.Location = new System.Drawing.Point(8, 81);
            this.labelVHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVHour.Name = "labelVHour";
            this.labelVHour.Size = new System.Drawing.Size(37, 15);
            this.labelVHour.TabIndex = 23;
            this.labelVHour.Text = "时：";
            // 
            // textVMinSec
            // 
            this.textVMinSec.Hex = false;
            this.textVMinSec.Location = new System.Drawing.Point(119, 109);
            this.textVMinSec.Margin = new System.Windows.Forms.Padding(4);
            this.textVMinSec.Name = "textVMinSec";
            this.textVMinSec.Size = new System.Drawing.Size(57, 23);
            this.textVMinSec.TabIndex = 12;
            this.textVMinSec.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "最小/最大秒数";
            // 
            // textVMaxFrameHit
            // 
            this.textVMaxFrameHit.Hex = false;
            this.textVMaxFrameHit.Location = new System.Drawing.Point(185, 139);
            this.textVMaxFrameHit.Margin = new System.Windows.Forms.Padding(4);
            this.textVMaxFrameHit.Name = "textVMaxFrameHit";
            this.textVMaxFrameHit.Size = new System.Drawing.Size(57, 23);
            this.textVMaxFrameHit.TabIndex = 15;
            this.textVMaxFrameHit.Text = "40";
            // 
            // dateTimeSeedSearch
            // 
            this.dateTimeSeedSearch.CustomFormat = "";
            this.dateTimeSeedSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSeedSearch.Location = new System.Drawing.Point(112, 48);
            this.dateTimeSeedSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeSeedSearch.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimeSeedSearch.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeSeedSearch.Name = "dateTimeSeedSearch";
            this.dateTimeSeedSearch.Size = new System.Drawing.Size(131, 25);
            this.dateTimeSeedSearch.TabIndex = 9;
            this.dateTimeSeedSearch.Value = new System.DateTime(2011, 3, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "日期:";
            // 
            // textVMinFrameHit
            // 
            this.textVMinFrameHit.Hex = false;
            this.textVMinFrameHit.Location = new System.Drawing.Point(119, 139);
            this.textVMinFrameHit.Margin = new System.Windows.Forms.Padding(4);
            this.textVMinFrameHit.Name = "textVMinFrameHit";
            this.textVMinFrameHit.Size = new System.Drawing.Size(57, 23);
            this.textVMinFrameHit.TabIndex = 14;
            this.textVMinFrameHit.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "最小/最大帧:";
            // 
            // groupVDSParams
            // 
            this.groupVDSParams.Controls.Add(this.label4);
            this.groupVDSParams.Controls.Add(this.labelProfileInformation);
            this.groupVDSParams.Controls.Add(this.comboBoxProfiles);
            this.groupVDSParams.Controls.Add(this.buttonEditProfile);
            this.groupVDSParams.Location = new System.Drawing.Point(9, 8);
            this.groupVDSParams.Margin = new System.Windows.Forms.Padding(4);
            this.groupVDSParams.Name = "groupVDSParams";
            this.groupVDSParams.Padding = new System.Windows.Forms.Padding(4);
            this.groupVDSParams.Size = new System.Drawing.Size(765, 165);
            this.groupVDSParams.TabIndex = 23;
            this.groupVDSParams.TabStop = false;
            this.groupVDSParams.Text = "DS配置参数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 15);
            this.label4.TabIndex = 324;
            this.label4.Text = "请注意:只使用最小的Timer0。";
            // 
            // labelProfileInformation
            // 
            this.labelProfileInformation.AutoSize = true;
            this.labelProfileInformation.Location = new System.Drawing.Point(4, 54);
            this.labelProfileInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfileInformation.Name = "labelProfileInformation";
            this.labelProfileInformation.Size = new System.Drawing.Size(0, 15);
            this.labelProfileInformation.TabIndex = 323;
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfiles.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProfiles.FormattingEnabled = true;
            this.comboBoxProfiles.Location = new System.Drawing.Point(8, 22);
            this.comboBoxProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfiles.MaxDropDownItems = 3;
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxProfiles.Size = new System.Drawing.Size(157, 23);
            this.comboBoxProfiles.TabIndex = 322;
            this.comboBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfiles_SelectedIndexChanged);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEditProfile.ForeColor = System.Drawing.Color.Black;
            this.buttonEditProfile.Location = new System.Drawing.Point(175, 20);
            this.buttonEditProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonEditProfile.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonEditProfile.Size = new System.Drawing.Size(52, 26);
            this.buttonEditProfile.TabIndex = 321;
            this.buttonEditProfile.Text = "编辑";
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // groupVSearchParams
            // 
            this.groupVSearchParams.Controls.Add(this.checkBoxSaveExists);
            this.groupVSearchParams.Controls.Add(this.checkBoxMinFrameCalc);
            this.groupVSearchParams.Controls.Add(this.textVMaxFrame);
            this.groupVSearchParams.Controls.Add(this.labelVMaxFrame);
            this.groupVSearchParams.Controls.Add(this.textVMinFrame);
            this.groupVSearchParams.Controls.Add(this.labelVMinFrame);
            this.groupVSearchParams.Controls.Add(this.checkVMonth);
            this.groupVSearchParams.Controls.Add(this.dateTimeSearch);
            this.groupVSearchParams.Controls.Add(this.labelVDate);
            this.groupVSearchParams.Location = new System.Drawing.Point(539, 181);
            this.groupVSearchParams.Margin = new System.Windows.Forms.Padding(4);
            this.groupVSearchParams.Name = "groupVSearchParams";
            this.groupVSearchParams.Padding = new System.Windows.Forms.Padding(4);
            this.groupVSearchParams.Size = new System.Drawing.Size(236, 190);
            this.groupVSearchParams.TabIndex = 8;
            this.groupVSearchParams.TabStop = false;
            this.groupVSearchParams.Text = "计算参数";
            // 
            // checkBoxSaveExists
            // 
            this.checkBoxSaveExists.AutoSize = true;
            this.checkBoxSaveExists.Enabled = false;
            this.checkBoxSaveExists.Location = new System.Drawing.Point(23, 129);
            this.checkBoxSaveExists.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSaveExists.Name = "checkBoxSaveExists";
            this.checkBoxSaveExists.Size = new System.Drawing.Size(119, 19);
            this.checkBoxSaveExists.TabIndex = 11;
            this.checkBoxSaveExists.Text = "已经有存档了";
            this.toolTips.SetToolTip(this.checkBoxSaveExists, "Choose any day during the month you want to search.");
            this.checkBoxSaveExists.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinFrameCalc
            // 
            this.checkBoxMinFrameCalc.AutoSize = true;
            this.checkBoxMinFrameCalc.Location = new System.Drawing.Point(23, 108);
            this.checkBoxMinFrameCalc.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMinFrameCalc.Name = "checkBoxMinFrameCalc";
            this.checkBoxMinFrameCalc.Size = new System.Drawing.Size(104, 19);
            this.checkBoxMinFrameCalc.TabIndex = 10;
            this.checkBoxMinFrameCalc.Text = "计算最小帧";
            this.toolTips.SetToolTip(this.checkBoxMinFrameCalc, "Choose any day during the month you want to search.");
            this.checkBoxMinFrameCalc.UseVisualStyleBackColor = true;
            this.checkBoxMinFrameCalc.CheckedChanged += new System.EventHandler(this.checkBoxMinFrameCalc_CheckedChanged);
            // 
            // textVMaxFrame
            // 
            this.textVMaxFrame.Hex = false;
            this.textVMaxFrame.Location = new System.Drawing.Point(105, 156);
            this.textVMaxFrame.Margin = new System.Windows.Forms.Padding(4);
            this.textVMaxFrame.Mask = "00";
            this.textVMaxFrame.Name = "textVMaxFrame";
            this.textVMaxFrame.Size = new System.Drawing.Size(119, 23);
            this.textVMaxFrame.TabIndex = 7;
            this.textVMaxFrame.Text = "40";
            // 
            // labelVMaxFrame
            // 
            this.labelVMaxFrame.AutoSize = true;
            this.labelVMaxFrame.Location = new System.Drawing.Point(19, 159);
            this.labelVMaxFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVMaxFrame.Name = "labelVMaxFrame";
            this.labelVMaxFrame.Size = new System.Drawing.Size(60, 15);
            this.labelVMaxFrame.TabIndex = 9;
            this.labelVMaxFrame.Text = "最大帧:";
            // 
            // textVMinFrame
            // 
            this.textVMinFrame.Hex = false;
            this.textVMinFrame.Location = new System.Drawing.Point(105, 79);
            this.textVMinFrame.Margin = new System.Windows.Forms.Padding(4);
            this.textVMinFrame.Mask = "00";
            this.textVMinFrame.Name = "textVMinFrame";
            this.textVMinFrame.Size = new System.Drawing.Size(119, 23);
            this.textVMinFrame.TabIndex = 6;
            this.textVMinFrame.Text = "28";
            // 
            // labelVMinFrame
            // 
            this.labelVMinFrame.AutoSize = true;
            this.labelVMinFrame.Location = new System.Drawing.Point(19, 82);
            this.labelVMinFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVMinFrame.Name = "labelVMinFrame";
            this.labelVMinFrame.Size = new System.Drawing.Size(60, 15);
            this.labelVMinFrame.TabIndex = 7;
            this.labelVMinFrame.Text = "最小帧:";
            // 
            // checkVMonth
            // 
            this.checkVMonth.AutoSize = true;
            this.checkVMonth.Location = new System.Drawing.Point(23, 52);
            this.checkVMonth.Margin = new System.Windows.Forms.Padding(4);
            this.checkVMonth.Name = "checkVMonth";
            this.checkVMonth.Size = new System.Drawing.Size(164, 19);
            this.checkVMonth.TabIndex = 5;
            this.checkVMonth.Text = "日期范围改为整个月";
            this.toolTips.SetToolTip(this.checkVMonth, "Choose any day during the month you want to search.");
            this.checkVMonth.UseVisualStyleBackColor = true;
            // 
            // dateTimeSearch
            // 
            this.dateTimeSearch.CustomFormat = "";
            this.dateTimeSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSearch.Location = new System.Drawing.Point(93, 22);
            this.dateTimeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeSearch.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimeSearch.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeSearch.Name = "dateTimeSearch";
            this.dateTimeSearch.Size = new System.Drawing.Size(131, 25);
            this.dateTimeSearch.TabIndex = 4;
            this.toolTips.SetToolTip(this.dateTimeSearch, "Select the date to search.");
            this.dateTimeSearch.Value = new System.DateTime(2011, 3, 28, 0, 0, 0, 0);
            // 
            // labelVDate
            // 
            this.labelVDate.AutoSize = true;
            this.labelVDate.Location = new System.Drawing.Point(19, 25);
            this.labelVDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVDate.Name = "labelVDate";
            this.labelVDate.Size = new System.Drawing.Size(52, 15);
            this.labelVDate.TabIndex = 6;
            this.labelVDate.Text = "日期：";
            // 
            // groupVPID
            // 
            this.groupVPID.Controls.Add(this.textVSID);
            this.groupVPID.Controls.Add(this.checkVSID);
            this.groupVPID.Controls.Add(this.checkVPID);
            this.groupVPID.Controls.Add(this.textVPID);
            this.groupVPID.Controls.Add(this.labelVFrame);
            this.groupVPID.Controls.Add(this.textVFrame);
            this.groupVPID.Controls.Add(this.textVTID);
            this.groupVPID.Controls.Add(this.checkVSeed);
            this.groupVPID.Controls.Add(this.textVSeed);
            this.groupVPID.Controls.Add(this.checkVTID);
            this.groupVPID.Location = new System.Drawing.Point(8, 201);
            this.groupVPID.Margin = new System.Windows.Forms.Padding(4);
            this.groupVPID.Name = "groupVPID";
            this.groupVPID.Padding = new System.Windows.Forms.Padding(4);
            this.groupVPID.Size = new System.Drawing.Size(260, 171);
            this.groupVPID.TabIndex = 0;
            this.groupVPID.TabStop = false;
            this.groupVPID.Text = "计算条件";
            // 
            // textVSID
            // 
            this.textVSID.Enabled = false;
            this.textVSID.Hex = false;
            this.textVSID.Location = new System.Drawing.Point(89, 139);
            this.textVSID.Margin = new System.Windows.Forms.Padding(4);
            this.textVSID.Mask = "00000";
            this.textVSID.Name = "textVSID";
            this.textVSID.Size = new System.Drawing.Size(157, 23);
            this.textVSID.TabIndex = 9;
            this.textVSID.Tag = "id/sid";
            this.toolTips.SetToolTip(this.textVSID, "Enter TID to search for here.");
            // 
            // checkVSID
            // 
            this.checkVSID.AutoSize = true;
            this.checkVSID.Location = new System.Drawing.Point(15, 141);
            this.checkVSID.Margin = new System.Windows.Forms.Padding(4);
            this.checkVSID.Name = "checkVSID";
            this.checkVSID.Size = new System.Drawing.Size(69, 19);
            this.checkVSID.TabIndex = 8;
            this.checkVSID.Text = "SID: ";
            this.checkVSID.UseVisualStyleBackColor = true;
            this.checkVSID.CheckedChanged += new System.EventHandler(this.checkVSID_CheckedChanged);
            // 
            // checkVPID
            // 
            this.checkVPID.AutoSize = true;
            this.checkVPID.Location = new System.Drawing.Point(15, 82);
            this.checkVPID.Margin = new System.Windows.Forms.Padding(4);
            this.checkVPID.Name = "checkVPID";
            this.checkVPID.Size = new System.Drawing.Size(61, 19);
            this.checkVPID.TabIndex = 6;
            this.checkVPID.Text = "PID:";
            this.checkVPID.UseVisualStyleBackColor = true;
            this.checkVPID.CheckedChanged += new System.EventHandler(this.checkVPID_CheckedChanged);
            // 
            // textVPID
            // 
            this.textVPID.Enabled = false;
            this.textVPID.Hex = true;
            this.textVPID.Location = new System.Drawing.Point(89, 81);
            this.textVPID.Margin = new System.Windows.Forms.Padding(4);
            this.textVPID.Mask = "AAAAAAAA";
            this.textVPID.Name = "textVPID";
            this.textVPID.Size = new System.Drawing.Size(157, 23);
            this.textVPID.TabIndex = 7;
            this.toolTips.SetToolTip(this.textVPID, "Enter the full seed given by RNG Reporter.");
            // 
            // labelVFrame
            // 
            this.labelVFrame.AutoSize = true;
            this.labelVFrame.Location = new System.Drawing.Point(35, 56);
            this.labelVFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVFrame.Name = "labelVFrame";
            this.labelVFrame.Size = new System.Drawing.Size(52, 15);
            this.labelVFrame.TabIndex = 5;
            this.labelVFrame.Text = "最大帧";
            // 
            // textVFrame
            // 
            this.textVFrame.Enabled = false;
            this.textVFrame.Hex = false;
            this.textVFrame.Location = new System.Drawing.Point(89, 52);
            this.textVFrame.Margin = new System.Windows.Forms.Padding(4);
            this.textVFrame.Mask = "0000";
            this.textVFrame.Name = "textVFrame";
            this.textVFrame.Size = new System.Drawing.Size(157, 23);
            this.textVFrame.TabIndex = 4;
            this.toolTips.SetToolTip(this.textVFrame, "Enter the frame number for the PID.");
            // 
            // textVTID
            // 
            this.textVTID.Enabled = false;
            this.textVTID.Hex = false;
            this.textVTID.Location = new System.Drawing.Point(89, 111);
            this.textVTID.Margin = new System.Windows.Forms.Padding(4);
            this.textVTID.Mask = "00000";
            this.textVTID.Name = "textVTID";
            this.textVTID.Size = new System.Drawing.Size(157, 23);
            this.textVTID.TabIndex = 3;
            this.textVTID.Tag = "id/sid";
            this.toolTips.SetToolTip(this.textVTID, "Enter TID to search for here.");
            // 
            // checkVSeed
            // 
            this.checkVSeed.AutoSize = true;
            this.checkVSeed.Location = new System.Drawing.Point(15, 24);
            this.checkVSeed.Margin = new System.Windows.Forms.Padding(4);
            this.checkVSeed.Name = "checkVSeed";
            this.checkVSeed.Size = new System.Drawing.Size(69, 19);
            this.checkVSeed.TabIndex = 0;
            this.checkVSeed.Text = "Seed:";
            this.checkVSeed.UseVisualStyleBackColor = true;
            this.checkVSeed.CheckedChanged += new System.EventHandler(this.textVSeed_TextChanged);
            // 
            // textVSeed
            // 
            this.textVSeed.Enabled = false;
            this.textVSeed.Hex = true;
            this.textVSeed.Location = new System.Drawing.Point(89, 22);
            this.textVSeed.Margin = new System.Windows.Forms.Padding(4);
            this.textVSeed.Mask = "AAAAAAAAAAAAAAAA";
            this.textVSeed.Name = "textVSeed";
            this.textVSeed.Size = new System.Drawing.Size(157, 23);
            this.textVSeed.TabIndex = 1;
            this.toolTips.SetToolTip(this.textVSeed, "Enter the full seed given by RNG Reporter.");
            // 
            // checkVTID
            // 
            this.checkVTID.AutoSize = true;
            this.checkVTID.Location = new System.Drawing.Point(15, 112);
            this.checkVTID.Margin = new System.Windows.Forms.Padding(4);
            this.checkVTID.Name = "checkVTID";
            this.checkVTID.Size = new System.Drawing.Size(69, 19);
            this.checkVTID.TabIndex = 2;
            this.checkVTID.Text = "TID: ";
            this.checkVTID.UseVisualStyleBackColor = true;
            this.checkVTID.CheckedChanged += new System.EventHandler(this.checkTID_CheckedChanged);
            // 
            // buttonVFindSeeds
            // 
            this.buttonVFindSeeds.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonVFindSeeds.ForeColor = System.Drawing.Color.Black;
            this.buttonVFindSeeds.Location = new System.Drawing.Point(9, 379);
            this.buttonVFindSeeds.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVFindSeeds.Name = "buttonVFindSeeds";
            this.buttonVFindSeeds.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonVFindSeeds.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonVFindSeeds.Size = new System.Drawing.Size(260, 29);
            this.buttonVFindSeeds.TabIndex = 8;
            this.buttonVFindSeeds.Text = "计算目标seed";
            this.buttonVFindSeeds.Click += new System.EventHandler(this.buttonVFindSeeds_Click);
            // 
            // buttonVCancel
            // 
            this.buttonVCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonVCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonVCancel.Location = new System.Drawing.Point(539, 379);
            this.buttonVCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVCancel.Name = "buttonVCancel";
            this.buttonVCancel.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonVCancel.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonVCancel.Size = new System.Drawing.Size(236, 29);
            this.buttonVCancel.TabIndex = 22;
            this.buttonVCancel.Text = "取消计算";
            this.buttonVCancel.Click += new System.EventHandler(this.buttonVCancel_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSeed,
            this.clmFrame,
            this.clmInitialFrame,
            this.clmID,
            this.clmSID,
            this.clmDelay,
            this.clmSeconds,
            this.clmStarter,
            this.clmDate,
            this.clmTime,
            this.clmButton});
            this.dgvResults.ContextMenuStrip = this.contextMenuStrip;
            this.dgvResults.Location = new System.Drawing.Point(13, 458);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 20;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(795, 202);
            this.dgvResults.TabIndex = 25;
            this.dgvResults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCapValues_ColumnHeaderMouseClick);
            this.dgvResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvResults_MouseDown);
            // 
            // clmSeed
            // 
            this.clmSeed.DataPropertyName = "Seed";
            this.clmSeed.HeaderText = "Seed";
            this.clmSeed.MinimumWidth = 6;
            this.clmSeed.Name = "clmSeed";
            this.clmSeed.ReadOnly = true;
            this.clmSeed.Width = 125;
            // 
            // clmFrame
            // 
            this.clmFrame.DataPropertyName = "Frame";
            this.clmFrame.HeaderText = "帧";
            this.clmFrame.MinimumWidth = 6;
            this.clmFrame.Name = "clmFrame";
            this.clmFrame.ReadOnly = true;
            this.clmFrame.Visible = false;
            this.clmFrame.Width = 125;
            // 
            // clmInitialFrame
            // 
            this.clmInitialFrame.DataPropertyName = "InitialFrame";
            this.clmInitialFrame.HeaderText = "初始帧";
            this.clmInitialFrame.MinimumWidth = 6;
            this.clmInitialFrame.Name = "clmInitialFrame";
            this.clmInitialFrame.ReadOnly = true;
            this.clmInitialFrame.Visible = false;
            this.clmInitialFrame.Width = 125;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "TID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 125;
            // 
            // clmSID
            // 
            this.clmSID.DataPropertyName = "SID";
            this.clmSID.HeaderText = "SID";
            this.clmSID.MinimumWidth = 6;
            this.clmSID.Name = "clmSID";
            this.clmSID.ReadOnly = true;
            this.clmSID.Width = 125;
            // 
            // clmDelay
            // 
            this.clmDelay.DataPropertyName = "Delay";
            this.clmDelay.HeaderText = "Delay";
            this.clmDelay.MinimumWidth = 6;
            this.clmDelay.Name = "clmDelay";
            this.clmDelay.ReadOnly = true;
            this.clmDelay.Visible = false;
            this.clmDelay.Width = 125;
            // 
            // clmSeconds
            // 
            this.clmSeconds.DataPropertyName = "Seconds";
            this.clmSeconds.HeaderText = "秒数";
            this.clmSeconds.MinimumWidth = 6;
            this.clmSeconds.Name = "clmSeconds";
            this.clmSeconds.ReadOnly = true;
            this.clmSeconds.Visible = false;
            this.clmSeconds.Width = 125;
            // 
            // clmStarter
            // 
            this.clmStarter.DataPropertyName = "Starter";
            this.clmStarter.HeaderText = "Starter";
            this.clmStarter.MinimumWidth = 6;
            this.clmStarter.Name = "clmStarter";
            this.clmStarter.ReadOnly = true;
            this.clmStarter.Visible = false;
            this.clmStarter.Width = 125;
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "Date";
            this.clmDate.HeaderText = "日期";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Visible = false;
            this.clmDate.Width = 125;
            // 
            // clmTime
            // 
            this.clmTime.DataPropertyName = "Time";
            this.clmTime.HeaderText = "时间";
            this.clmTime.MinimumWidth = 6;
            this.clmTime.Name = "clmTime";
            this.clmTime.ReadOnly = true;
            this.clmTime.Visible = false;
            this.clmTime.Width = 125;
            // 
            // clmButton
            // 
            this.clmButton.DataPropertyName = "Button";
            this.clmButton.HeaderText = "按键";
            this.clmButton.MinimumWidth = 6;
            this.clmButton.Name = "clmButton";
            this.clmButton.ReadOnly = true;
            this.clmButton.Visible = false;
            this.clmButton.Width = 125;
            // 
            // Pandora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 691);
            this.Controls.Add(this.tabGenSelect);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pandora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TID\\SID 计算器 （\"潘多拉魔盒\"）";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpShiny.ResumeLayout(false);
            this.grpShiny.PerformLayout();
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpSeed.ResumeLayout(false);
            this.grpSeed.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabGenSelect.ResumeLayout(false);
            this.tabXDColo.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabGen3FRLGE.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabGen3RS.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabGen4.ResumeLayout(false);
            this.tabGen4.PerformLayout();
            this.tabGen5.ResumeLayout(false);
            this.groupVSeedFinder.ResumeLayout(false);
            this.groupVSeedFinder.PerformLayout();
            this.groupVDSParams.ResumeLayout(false);
            this.groupVDSParams.PerformLayout();
            this.groupVSearchParams.ResumeLayout(false);
            this.groupVSearchParams.PerformLayout();
            this.groupVPID.ResumeLayout(false);
            this.groupVPID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabGenSelect;
        private System.Windows.Forms.TabPage tabGen4;
        private System.Windows.Forms.TabPage tabGen5;
        private System.Windows.Forms.GroupBox groupVPID;
        private System.Windows.Forms.Label labelBy;
        private System.Windows.Forms.DateTimePicker dateTimeSearch;
        private MaskedTextBox2 textVSeed;
        private System.Windows.Forms.CheckBox checkVMonth;
        private System.Windows.Forms.Label labelVDate;
        private System.Windows.Forms.CheckBox checkVTID;
        private System.Windows.Forms.GroupBox groupVSearchParams;
        private System.Windows.Forms.CheckBox checkVSeed;
        private MaskedTextBox2 textVTID;
        private System.Windows.Forms.Label labelVMaxFrame;
        private MaskedTextBox2 textVMinFrame;
        private System.Windows.Forms.Label labelVMinFrame;
        private System.Windows.Forms.ToolTip toolTips;
        private MaskedTextBox2 textVMaxFrame;
        private RNGReporter.GlassButton buttonVCancel;
        private RNGReporter.GlassButton buttonVFindSeeds;
        private System.Windows.Forms.GroupBox groupVDSParams;
        private System.Windows.Forms.GroupBox groupVSeedFinder;
        private RNGReporter.GlassButton buttonVFindSeedHit;
        private MaskedTextBox2 textVMinute;
        private System.Windows.Forms.Label labelVMinute;
        private MaskedTextBox2 textVHour;
        private System.Windows.Forms.Label labelVHour;
        private System.Windows.Forms.Label labelTIDReceived;
        private MaskedTextBox2 textVTIDReceived;
        private MaskedTextBox2 textVMaxSec;
        private MaskedTextBox2 textVMinSec;
        private System.Windows.Forms.Label label1;
        private MaskedTextBox2 textVMaxFrameHit;
        private System.Windows.Forms.DateTimePicker dateTimeSeedSearch;
        private System.Windows.Forms.Label label3;
        private MaskedTextBox2 textVMinFrameHit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVFrame;
        private MaskedTextBox2 textVFrame;
        private System.Windows.Forms.CheckBox checkBoxMinFrameCalc;
        private System.Windows.Forms.CheckBox checkBoxSaveExists;
        private System.Windows.Forms.CheckBox checkVPID;
        private MaskedTextBox2 textVPID;
        private System.Windows.Forms.GroupBox grpShiny;
        private System.Windows.Forms.GroupBox grpID;
        private System.Windows.Forms.GroupBox grpSeed;
        private MaskedTextBox2 textBoxShinyPID;
        private System.Windows.Forms.Label lblShinyPID;
        private MaskedTextBox2 textBoxShinyYear;
        private System.Windows.Forms.Label lblShinyYr;
        private MaskedTextBox2 txtShinyMinDelay;
        private System.Windows.Forms.Label lblShinyMinDelay;
        private MaskedTextBox2 txtShinyMaxDelay;
        private System.Windows.Forms.Label lblShinyMaxDelay;
        private RNGReporter.GlassButton btnShinyGo;
        private System.Windows.Forms.Label lblTrainerID;
        private MaskedTextBox2 textBoxDesiredSID;
        private System.Windows.Forms.Label lblSecretID;
        private System.Windows.Forms.CheckBox cbxSearchSID;
        private MaskedTextBox2 textBoxDesiredTID;
        private MaskedTextBox2 textBoxIDYear;
        private System.Windows.Forms.Label lblIDYr;
        private MaskedTextBox2 textBoxIDMaxDelay;
        private MaskedTextBox2 textBoxIDMinDelay;
        private System.Windows.Forms.Label lblIDMaxDelay;
        private System.Windows.Forms.Label lblIDMinDelay;
        private RNGReporter.GlassButton btnIDGo;
        private MaskedTextBox2 txtMonth;
        private MaskedTextBox2 txtIDObtained;
        private System.Windows.Forms.Label lblIDObtained;
        private MaskedTextBox2 txtDay;
        private System.Windows.Forms.Label lblMonth;
        private RNGReporter.GlassButton btnCredits;
        private MaskedTextBox2 txtSeedMinDelay;
        private MaskedTextBox2 txtMinute;
        private MaskedTextBox2 txtHour;
        private MaskedTextBox2 txtSeedYr;
        private MaskedTextBox2 txtSeedMaxDelay;
        private RNGReporter.GlassButton btnSeedGo;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblSeedMinDelay;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSeedYr;
        private System.Windows.Forms.Label lblSeedMaxDelay;
        private DoubleBufferedDataGridView dgvResults;
        private RNGReporter.GlassButton btnShinyCancel;
        private RNGReporter.GlassButton btnIDCancel;
        private System.Windows.Forms.CheckBox cbxIDInf;
        private System.Windows.Forms.CheckBox cbxSearchID;
        private System.Windows.Forms.Label lblShinyTrainerID;
        private System.Windows.Forms.CheckBox cbxShinyInf;
        private MaskedTextBox2 textBoxShinyTID;
        private System.Windows.Forms.Label lblSimple;
        private System.Windows.Forms.Label lblSeed;
        private RNGReporter.GlassButton btnSimpleGo;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.ComponentModel.BackgroundWorker bgwShiny;
        private System.ComponentModel.BackgroundWorker bgwID;
        private System.ComponentModel.BackgroundWorker bgwIDInf;
        private System.ComponentModel.BackgroundWorker bgwShinyInf;
        private System.Windows.Forms.ToolStripStatusLabel lblAction;
        private MaskedTextBox2 textBoxSeed;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem generateTimesToolStripMenuItem;
        private MaskedTextBox2 textVSID;
        private System.Windows.Forms.CheckBox checkVSID;
        private System.Windows.Forms.Label labelProfileInformation;
        private GlassComboBox comboBoxProfiles;
        private GlassButton buttonEditProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabGen3RS;
        private GlassButton buttonIIIFindFrames;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaskedTextBox2 textIIISID;
        private System.Windows.Forms.CheckBox checkIIISID;
        private System.Windows.Forms.CheckBox checkIIIPID;
        private MaskedTextBox2 textIIIPID;
        private MaskedTextBox2 textIIITID;
        private System.Windows.Forms.CheckBox checkIIITID;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaskedTextBox2 textIIIMaxFrame;
        private System.Windows.Forms.Label label6;
        private MaskedTextBox2 textIIIMinFrame;
        private System.Windows.Forms.Label label7;
        private GlassButton buttonIIICancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private MaskedTextBox2 textIIIMinute;
        private System.Windows.Forms.DateTimePicker dateIII;
        private MaskedTextBox2 textIIIHour;
        private System.Windows.Forms.CheckBox checkIIIClock;
        private System.Windows.Forms.TabPage tabGen3FRLGE;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaskedTextBox2 genFRLGEPID;
        private MaskedTextBox2 genFRLGETID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaskedTextBox2 genFRLGEMaxFrame;
        private System.Windows.Forms.Label label12;
        private MaskedTextBox2 genFRLGEMinFrame;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private GlassButton genCancelFRLGE;
        private GlassButton genSearchFRLGE;
        private System.Windows.Forms.TabPage tabXDColo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private MaskedTextBox2 XDColoPID;
        private MaskedTextBox2 XDColoPRNG;
        private System.Windows.Forms.GroupBox groupBox7;
        private MaskedTextBox2 XDColoMaxFrame;
        private System.Windows.Forms.Label label16;
        private MaskedTextBox2 XDColoMinFrame;
        private System.Windows.Forms.Label label17;
        private GlassButton genCancelXDColo;
        private GlassButton searchGenXDColo;
        private System.Windows.Forms.Label labelXDColo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private MaskedTextBox2 maskedTextBox21;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitialFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmButton;
    }
}

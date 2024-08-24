using RNGReporter.Controls;
using RNGReporter.Objects;

namespace RNGReporter
{
    partial class TimeFinder4th
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties1 = new RNGReporter.Controls.CheckBoxProperties();
            RNGReporter.Controls.CheckBoxProperties checkBoxProperties2 = new RNGReporter.Controls.CheckBoxProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStripEggPid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.outputResultsToTXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.setAsTargetFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToTargetFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.generateAdjacentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.outputResultsToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.tabPageEggIVs = new System.Windows.Forms.TabPage();
            this.ivFiltersEgg = new RNGReporter.Controls.IVFilters();
            this.radioButtonEggHGSS = new System.Windows.Forms.RadioButton();
            this.radioButtonEggDPPt = new System.Windows.Forms.RadioButton();
            this.checkBoxShowInheritance = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIVB = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.dataGridViewEggIVValues = new RNGReporter.DoubleBufferedDataGridView();
            this.Seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new RNGReporter.GlassButton();
            this.buttonEggGenerate = new RNGReporter.GlassButton();
            this.maskedTextBoxDefB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtkB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpeB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpDB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpAB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHPB = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxDefA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxAtkA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpeA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpDA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSpAA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxHPA = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMaxOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMinOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxYear = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.tabPageShinyEgg = new System.Windows.Forms.TabPage();
            this.labelHappinessWarning = new System.Windows.Forms.Label();
            this.checkBoxNoHappiness = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIntlParents = new System.Windows.Forms.CheckBox();
            this.radioButtonHGSS = new System.Windows.Forms.RadioButton();
            this.radioButtonDPPt = new System.Windows.Forms.RadioButton();
            this.label92 = new System.Windows.Forms.Label();
            this.checkBoxShinyShinyOnly = new System.Windows.Forms.CheckBox();
            this.labelDPPtWarning = new System.Windows.Forms.Label();
            this.dataGridViewShinyResults = new RNGReporter.DoubleBufferedDataGridView();
            this.EggSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EggPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shinyShinyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFemale50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFemale25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFemale125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFemale75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFlipSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyTaps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyFlips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelShinySecretID = new System.Windows.Forms.Label();
            this.labelShinyNature = new System.Windows.Forms.Label();
            this.labelShinyTrainerID = new System.Windows.Forms.Label();
            this.labelShinyAbility = new System.Windows.Forms.Label();
            this.labelShinyDelay = new System.Windows.Forms.Label();
            this.labelShinyYear = new System.Windows.Forms.Label();
            this.comboBoxShinyGender = new RNGReporter.GlassComboBox();
            this.buttonShinyClearAbility = new RNGReporter.GlassButton();
            this.comboBoxShinyAbility = new RNGReporter.GlassComboBox();
            this.buttonShinyGenerate = new RNGReporter.GlassButton();
            this.buttonShinyClearNature = new RNGReporter.GlassButton();
            this.comboBoxShinyNature = new RNGReporter.GlassComboBox();
            this.maskedTextBoxMaxTaps = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxShinySecretID = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxShinyID = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxShinyMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxShinyMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxShinyYear = new RNGReporter.Controls.MaskedTextBox2();
            this.tabPageCapture = new System.Windows.Forms.TabPage();
            this.ivFiltersCapture = new RNGReporter.Controls.IVFilters();
            this.comboBoxCapGenderRatio = new RNGReporter.GlassComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCapGender = new RNGReporter.GlassComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dataGridViewCapValues = new RNGReporter.DoubleBufferedDataGridView();
            this.contextMenuStripCap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySeedToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.outputCapResultsToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAnySlot = new RNGReporter.GlassButton();
            this.maskedTextBoxCapMinOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.label54 = new System.Windows.Forms.Label();
            this.comboBoxEncounterType = new RNGReporter.GlassComboBox();
            this.comboBoxEncounterSlot = new RNGReporter.Controls.CheckBoxComboBox();
            this.maskedTextBoxCapMaxDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.label52 = new System.Windows.Forms.Label();
            this.maskedTextBoxCapMinDelay = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxCapYear = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxCapMaxOffset = new RNGReporter.Controls.MaskedTextBox2();
            this.labelCapMinMaxFrame = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new RNGReporter.GlassComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.buttonCapGenerate = new RNGReporter.GlassButton();
            this.buttonAnyNature = new RNGReporter.GlassButton();
            this.lblID = new System.Windows.Forms.Label();
            this.comboBoxAbility = new RNGReporter.GlassComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBoxShinyOnly = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxID = new RNGReporter.Controls.MaskedTextBox2();
            this.maskedTextBoxSID = new RNGReporter.Controls.MaskedTextBox2();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxNature = new RNGReporter.Controls.CheckBoxComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolTipDataGrid = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGenderRatio = new System.Windows.Forms.ToolTip(this.components);
            this.CapSeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncounterMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.HiddenPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiddenPowerPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripEggPid.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabPageEggIVs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEggIVValues)).BeginInit();
            this.tabPageShinyEgg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShinyResults)).BeginInit();
            this.tabPageCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapValues)).BeginInit();
            this.contextMenuStripCap.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripEggPid
            // 
            this.contextMenuStripEggPid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEggPid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem2,
            this.toolStripMenuItem7,
            this.generateTimeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.outputResultsToTXTToolStripMenuItem1});
            this.contextMenuStripEggPid.Name = "contextMenuStripEggPid";
            this.contextMenuStripEggPid.Size = new System.Drawing.Size(253, 88);
            this.contextMenuStripEggPid.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEggPid_Opening);
            // 
            // copySeedToClipboardToolStripMenuItem2
            // 
            this.copySeedToClipboardToolStripMenuItem2.Name = "copySeedToClipboardToolStripMenuItem2";
            this.copySeedToClipboardToolStripMenuItem2.Size = new System.Drawing.Size(252, 24);
            this.copySeedToClipboardToolStripMenuItem2.Text = "复制Seed到剪贴板";
            this.copySeedToClipboardToolStripMenuItem2.Click += new System.EventHandler(this.copySeedToClipboardToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(249, 6);
            // 
            // generateTimeToolStripMenuItem
            // 
            this.generateTimeToolStripMenuItem.Name = "generateTimeToolStripMenuItem";
            this.generateTimeToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.generateTimeToolStripMenuItem.Text = "Generate More Times ...";
            this.generateTimeToolStripMenuItem.Click += new System.EventHandler(this.generateTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(249, 6);
            // 
            // outputResultsToTXTToolStripMenuItem1
            // 
            this.outputResultsToTXTToolStripMenuItem1.Name = "outputResultsToTXTToolStripMenuItem1";
            this.outputResultsToTXTToolStripMenuItem1.Size = new System.Drawing.Size(252, 24);
            this.outputResultsToTXTToolStripMenuItem1.Text = "输出结果至TXT文本文件";
            this.outputResultsToTXTToolStripMenuItem1.Click += new System.EventHandler(this.outputResultsToTXTToolStripMenuItem1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem,
            this.toolStripMenuItem5,
            this.setAsTargetFrameToolStripMenuItem,
            this.jumpToTargetFrameToolStripMenuItem,
            this.toolStripMenuItem2,
            this.generateAdjacentToolStripMenuItem,
            this.returnToResultsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.outputResultsToTXTToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(287, 166);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copySeedToClipboardToolStripMenuItem
            // 
            this.copySeedToClipboardToolStripMenuItem.Name = "copySeedToClipboardToolStripMenuItem";
            this.copySeedToClipboardToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.copySeedToClipboardToolStripMenuItem.Text = "复制Seed到剪贴板";
            this.copySeedToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySeedToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(283, 6);
            // 
            // setAsTargetFrameToolStripMenuItem
            // 
            this.setAsTargetFrameToolStripMenuItem.Name = "setAsTargetFrameToolStripMenuItem";
            this.setAsTargetFrameToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.setAsTargetFrameToolStripMenuItem.Text = "Set as Target Frame";
            this.setAsTargetFrameToolStripMenuItem.Click += new System.EventHandler(this.setAsTargetFrameToolStripMenuItem_Click);
            // 
            // jumpToTargetFrameToolStripMenuItem
            // 
            this.jumpToTargetFrameToolStripMenuItem.Name = "jumpToTargetFrameToolStripMenuItem";
            this.jumpToTargetFrameToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.jumpToTargetFrameToolStripMenuItem.Text = "Jump to Target Frame";
            this.jumpToTargetFrameToolStripMenuItem.Click += new System.EventHandler(this.jumpToTargetFrameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(283, 6);
            // 
            // generateAdjacentToolStripMenuItem
            // 
            this.generateAdjacentToolStripMenuItem.Name = "generateAdjacentToolStripMenuItem";
            this.generateAdjacentToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.generateAdjacentToolStripMenuItem.Text = "Generate Adjacent Results ...";
            this.generateAdjacentToolStripMenuItem.Click += new System.EventHandler(this.generateAdjacentToolStripMenuItem_Click);
            // 
            // returnToResultsToolStripMenuItem
            // 
            this.returnToResultsToolStripMenuItem.Name = "returnToResultsToolStripMenuItem";
            this.returnToResultsToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.returnToResultsToolStripMenuItem.Text = "Return to Results";
            this.returnToResultsToolStripMenuItem.Visible = false;
            this.returnToResultsToolStripMenuItem.Click += new System.EventHandler(this.returnToResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(283, 6);
            // 
            // outputResultsToTXTToolStripMenuItem
            // 
            this.outputResultsToTXTToolStripMenuItem.Name = "outputResultsToTXTToolStripMenuItem";
            this.outputResultsToTXTToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.outputResultsToTXTToolStripMenuItem.Text = "输出结果至TXT文本文件";
            this.outputResultsToTXTToolStripMenuItem.Click += new System.EventHandler(this.outputResultsToTXTToolStripMenuItem_Click);
            // 
            // tabPageEggIVs
            // 
            this.tabPageEggIVs.Controls.Add(this.ivFiltersEgg);
            this.tabPageEggIVs.Controls.Add(this.radioButtonEggHGSS);
            this.tabPageEggIVs.Controls.Add(this.radioButtonEggDPPt);
            this.tabPageEggIVs.Controls.Add(this.checkBoxShowInheritance);
            this.tabPageEggIVs.Controls.Add(this.label29);
            this.tabPageEggIVs.Controls.Add(this.label27);
            this.tabPageEggIVs.Controls.Add(this.label25);
            this.tabPageEggIVs.Controls.Add(this.label24);
            this.tabPageEggIVs.Controls.Add(this.label12);
            this.tabPageEggIVs.Controls.Add(this.label11);
            this.tabPageEggIVs.Controls.Add(this.lblIVB);
            this.tabPageEggIVs.Controls.Add(this.lblIVA);
            this.tabPageEggIVs.Controls.Add(this.dataGridViewEggIVValues);
            this.tabPageEggIVs.Controls.Add(this.label14);
            this.tabPageEggIVs.Controls.Add(this.label5);
            this.tabPageEggIVs.Controls.Add(this.label3);
            this.tabPageEggIVs.Controls.Add(this.button1);
            this.tabPageEggIVs.Controls.Add(this.buttonEggGenerate);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxDefB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxAtkB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpeB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpDB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpAB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxHPB);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxDefA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxAtkA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpeA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpDA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxSpAA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxHPA);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxMaxOffset);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxMinOffset);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxYear);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxMinDelay);
            this.tabPageEggIVs.Controls.Add(this.maskedTextBoxMaxDelay);
            this.tabPageEggIVs.Location = new System.Drawing.Point(4, 25);
            this.tabPageEggIVs.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEggIVs.Name = "tabPageEggIVs";
            this.tabPageEggIVs.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEggIVs.Size = new System.Drawing.Size(1241, 626);
            this.tabPageEggIVs.TabIndex = 0;
            this.tabPageEggIVs.Text = "Egg IVs";
            this.tabPageEggIVs.UseVisualStyleBackColor = true;
            // 
            // ivFiltersEgg
            // 
            this.ivFiltersEgg.Location = new System.Drawing.Point(394, 8);
            this.ivFiltersEgg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ivFiltersEgg.Name = "ivFiltersEgg";
            this.ivFiltersEgg.Size = new System.Drawing.Size(394, 208);
            this.ivFiltersEgg.TabIndex = 101;
            // 
            // radioButtonEggHGSS
            // 
            this.radioButtonEggHGSS.AutoSize = true;
            this.radioButtonEggHGSS.Location = new System.Drawing.Point(222, 159);
            this.radioButtonEggHGSS.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEggHGSS.Name = "radioButtonEggHGSS";
            this.radioButtonEggHGSS.Size = new System.Drawing.Size(60, 19);
            this.radioButtonEggHGSS.TabIndex = 19;
            this.radioButtonEggHGSS.Text = "HGSS";
            this.radioButtonEggHGSS.UseVisualStyleBackColor = true;
            // 
            // radioButtonEggDPPt
            // 
            this.radioButtonEggDPPt.AutoSize = true;
            this.radioButtonEggDPPt.Checked = true;
            this.radioButtonEggDPPt.Location = new System.Drawing.Point(34, 159);
            this.radioButtonEggDPPt.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEggDPPt.Name = "radioButtonEggDPPt";
            this.radioButtonEggDPPt.Size = new System.Drawing.Size(60, 19);
            this.radioButtonEggDPPt.TabIndex = 18;
            this.radioButtonEggDPPt.TabStop = true;
            this.radioButtonEggDPPt.Text = "DPPt";
            this.radioButtonEggDPPt.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowInheritance
            // 
            this.checkBoxShowInheritance.AutoSize = true;
            this.checkBoxShowInheritance.Location = new System.Drawing.Point(222, 200);
            this.checkBoxShowInheritance.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowInheritance.Name = "checkBoxShowInheritance";
            this.checkBoxShowInheritance.Size = new System.Drawing.Size(157, 19);
            this.checkBoxShowInheritance.TabIndex = 22;
            this.checkBoxShowInheritance.Text = "Show Inheritance";
            this.checkBoxShowInheritance.UseVisualStyleBackColor = true;
            this.checkBoxShowInheritance.CheckedChanged += new System.EventHandler(this.checkBoxShowInheritance_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(320, 71);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 15);
            this.label29.TabIndex = 100;
            this.label29.Text = "速度";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(280, 71);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 15);
            this.label27.TabIndex = 99;
            this.label27.Text = "特防";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(239, 71);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 15);
            this.label25.TabIndex = 98;
            this.label25.Text = "特攻";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(201, 71);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 15);
            this.label24.TabIndex = 97;
            this.label24.Text = "防御";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 96;
            this.label12.Text = "攻击";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 95;
            this.label11.Text = "HP";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIVB
            // 
            this.lblIVB.AutoSize = true;
            this.lblIVB.Location = new System.Drawing.Point(54, 124);
            this.lblIVB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVB.Name = "lblIVB";
            this.lblIVB.Size = new System.Drawing.Size(45, 15);
            this.lblIVB.TabIndex = 87;
            this.lblIVB.Text = "父母B";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(54, 94);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(45, 15);
            this.lblIVA.TabIndex = 86;
            this.lblIVA.Text = "父母A";
            // 
            // dataGridViewEggIVValues
            // 
            this.dataGridViewEggIVValues.AllowUserToAddRows = false;
            this.dataGridViewEggIVValues.AllowUserToDeleteRows = false;
            this.dataGridViewEggIVValues.AllowUserToResizeRows = false;
            this.dataGridViewEggIVValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEggIVValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEggIVValues.ColumnHeadersHeight = 20;
            this.dataGridViewEggIVValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seed,
            this.Date,
            this.Delay,
            this.Offset,
            this.HP,
            this.Atk,
            this.Def,
            this.SpA,
            this.SpD,
            this.Spe,
            this.Flips});
            this.dataGridViewEggIVValues.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEggIVValues.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewEggIVValues.Location = new System.Drawing.Point(8, 236);
            this.dataGridViewEggIVValues.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEggIVValues.MultiSelect = false;
            this.dataGridViewEggIVValues.Name = "dataGridViewEggIVValues";
            this.dataGridViewEggIVValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEggIVValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewEggIVValues.RowHeadersVisible = false;
            this.dataGridViewEggIVValues.RowHeadersWidth = 51;
            this.dataGridViewEggIVValues.RowTemplate.Height = 20;
            this.dataGridViewEggIVValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEggIVValues.ShowCellErrors = false;
            this.dataGridViewEggIVValues.ShowCellToolTips = false;
            this.dataGridViewEggIVValues.ShowEditingIcon = false;
            this.dataGridViewEggIVValues.ShowRowErrors = false;
            this.dataGridViewEggIVValues.Size = new System.Drawing.Size(1196, 379);
            this.dataGridViewEggIVValues.TabIndex = 35;
            this.dataGridViewEggIVValues.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewValues_CellFormatting);
            this.dataGridViewEggIVValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewValues_MouseDown);
            // 
            // Seed
            // 
            this.Seed.DataPropertyName = "Seed";
            this.Seed.HeaderText = "Seed";
            this.Seed.MinimumWidth = 6;
            this.Seed.Name = "Seed";
            this.Seed.ReadOnly = true;
            this.Seed.Width = 60;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "SeedTime";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 120;
            // 
            // Delay
            // 
            this.Delay.DataPropertyName = "Delay";
            this.Delay.HeaderText = "Delay";
            this.Delay.MinimumWidth = 6;
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            this.Delay.Width = 40;
            // 
            // Offset
            // 
            this.Offset.DataPropertyName = "Offset";
            this.Offset.HeaderText = "Frame";
            this.Offset.MinimumWidth = 6;
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.Width = 40;
            // 
            // HP
            // 
            this.HP.DataPropertyName = "Hp";
            this.HP.HeaderText = "HP";
            this.HP.MinimumWidth = 6;
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Width = 30;
            // 
            // Atk
            // 
            this.Atk.DataPropertyName = "Atk";
            this.Atk.HeaderText = "攻击";
            this.Atk.MinimumWidth = 6;
            this.Atk.Name = "Atk";
            this.Atk.ReadOnly = true;
            this.Atk.Width = 30;
            // 
            // Def
            // 
            this.Def.DataPropertyName = "Def";
            this.Def.HeaderText = "防御";
            this.Def.MinimumWidth = 6;
            this.Def.Name = "Def";
            this.Def.ReadOnly = true;
            this.Def.Width = 30;
            // 
            // SpA
            // 
            this.SpA.DataPropertyName = "Spa";
            this.SpA.HeaderText = "特攻";
            this.SpA.MinimumWidth = 6;
            this.SpA.Name = "SpA";
            this.SpA.ReadOnly = true;
            this.SpA.Width = 30;
            // 
            // SpD
            // 
            this.SpD.DataPropertyName = "Spd";
            this.SpD.HeaderText = "特防";
            this.SpD.MinimumWidth = 6;
            this.SpD.Name = "SpD";
            this.SpD.ReadOnly = true;
            this.SpD.Width = 30;
            // 
            // Spe
            // 
            this.Spe.DataPropertyName = "Spe";
            this.Spe.HeaderText = "速度";
            this.Spe.MinimumWidth = 6;
            this.Spe.Name = "Spe";
            this.Spe.ReadOnly = true;
            this.Spe.Width = 30;
            // 
            // Flips
            // 
            this.Flips.DataPropertyName = "Flips";
            this.Flips.HeaderText = "Flip Sequence";
            this.Flips.MinimumWidth = 6;
            this.Flips.Name = "Flips";
            this.Flips.ReadOnly = true;
            this.Flips.Width = 400;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "年份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "最小/最大Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "最小/最大帧";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(116, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.button1.ShineColor = System.Drawing.SystemColors.Window;
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search Flips";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEggGenerate
            // 
            this.buttonEggGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEggGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonEggGenerate.Location = new System.Drawing.Point(15, 196);
            this.buttonEggGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEggGenerate.Name = "buttonEggGenerate";
            this.buttonEggGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonEggGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonEggGenerate.Size = new System.Drawing.Size(91, 29);
            this.buttonEggGenerate.TabIndex = 20;
            this.buttonEggGenerate.Text = "计算";
            this.buttonEggGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // maskedTextBoxDefB
            // 
            this.maskedTextBoxDefB.Hex = false;
            this.maskedTextBoxDefB.Location = new System.Drawing.Point(200, 120);
            this.maskedTextBoxDefB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxDefB.Mask = "00";
            this.maskedTextBoxDefB.Name = "maskedTextBoxDefB";
            this.maskedTextBoxDefB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxDefB.TabIndex = 14;
            this.maskedTextBoxDefB.Tag = "ivs";
            this.maskedTextBoxDefB.ValidatingType = typeof(int);
            // 
            // maskedTextBoxAtkB
            // 
            this.maskedTextBoxAtkB.Hex = false;
            this.maskedTextBoxAtkB.Location = new System.Drawing.Point(161, 120);
            this.maskedTextBoxAtkB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxAtkB.Mask = "00";
            this.maskedTextBoxAtkB.Name = "maskedTextBoxAtkB";
            this.maskedTextBoxAtkB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxAtkB.TabIndex = 12;
            this.maskedTextBoxAtkB.Tag = "ivs";
            this.maskedTextBoxAtkB.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpeB
            // 
            this.maskedTextBoxSpeB.Hex = false;
            this.maskedTextBoxSpeB.Location = new System.Drawing.Point(320, 120);
            this.maskedTextBoxSpeB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpeB.Mask = "00";
            this.maskedTextBoxSpeB.Name = "maskedTextBoxSpeB";
            this.maskedTextBoxSpeB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpeB.TabIndex = 17;
            this.maskedTextBoxSpeB.Tag = "ivs";
            this.maskedTextBoxSpeB.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpDB
            // 
            this.maskedTextBoxSpDB.Hex = false;
            this.maskedTextBoxSpDB.Location = new System.Drawing.Point(280, 120);
            this.maskedTextBoxSpDB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpDB.Mask = "00";
            this.maskedTextBoxSpDB.Name = "maskedTextBoxSpDB";
            this.maskedTextBoxSpDB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpDB.TabIndex = 16;
            this.maskedTextBoxSpDB.Tag = "ivs";
            this.maskedTextBoxSpDB.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpAB
            // 
            this.maskedTextBoxSpAB.Hex = false;
            this.maskedTextBoxSpAB.Location = new System.Drawing.Point(240, 120);
            this.maskedTextBoxSpAB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpAB.Mask = "00";
            this.maskedTextBoxSpAB.Name = "maskedTextBoxSpAB";
            this.maskedTextBoxSpAB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpAB.TabIndex = 15;
            this.maskedTextBoxSpAB.Tag = "ivs";
            this.maskedTextBoxSpAB.ValidatingType = typeof(int);
            // 
            // maskedTextBoxHPB
            // 
            this.maskedTextBoxHPB.Hex = false;
            this.maskedTextBoxHPB.Location = new System.Drawing.Point(121, 120);
            this.maskedTextBoxHPB.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHPB.Mask = "00";
            this.maskedTextBoxHPB.Name = "maskedTextBoxHPB";
            this.maskedTextBoxHPB.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxHPB.TabIndex = 11;
            this.maskedTextBoxHPB.Tag = "ivs";
            // 
            // maskedTextBoxDefA
            // 
            this.maskedTextBoxDefA.Hex = false;
            this.maskedTextBoxDefA.Location = new System.Drawing.Point(200, 90);
            this.maskedTextBoxDefA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxDefA.Mask = "00";
            this.maskedTextBoxDefA.Name = "maskedTextBoxDefA";
            this.maskedTextBoxDefA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxDefA.TabIndex = 7;
            this.maskedTextBoxDefA.Tag = "ivs";
            this.maskedTextBoxDefA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxAtkA
            // 
            this.maskedTextBoxAtkA.Hex = false;
            this.maskedTextBoxAtkA.Location = new System.Drawing.Point(161, 90);
            this.maskedTextBoxAtkA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxAtkA.Mask = "00";
            this.maskedTextBoxAtkA.Name = "maskedTextBoxAtkA";
            this.maskedTextBoxAtkA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxAtkA.TabIndex = 6;
            this.maskedTextBoxAtkA.Tag = "ivs";
            this.maskedTextBoxAtkA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpeA
            // 
            this.maskedTextBoxSpeA.Hex = false;
            this.maskedTextBoxSpeA.Location = new System.Drawing.Point(320, 90);
            this.maskedTextBoxSpeA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpeA.Mask = "00";
            this.maskedTextBoxSpeA.Name = "maskedTextBoxSpeA";
            this.maskedTextBoxSpeA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpeA.TabIndex = 10;
            this.maskedTextBoxSpeA.Tag = "ivs";
            this.maskedTextBoxSpeA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpDA
            // 
            this.maskedTextBoxSpDA.Hex = false;
            this.maskedTextBoxSpDA.Location = new System.Drawing.Point(280, 90);
            this.maskedTextBoxSpDA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpDA.Mask = "00";
            this.maskedTextBoxSpDA.Name = "maskedTextBoxSpDA";
            this.maskedTextBoxSpDA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpDA.TabIndex = 9;
            this.maskedTextBoxSpDA.Tag = "ivs";
            this.maskedTextBoxSpDA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSpAA
            // 
            this.maskedTextBoxSpAA.Hex = false;
            this.maskedTextBoxSpAA.Location = new System.Drawing.Point(240, 90);
            this.maskedTextBoxSpAA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSpAA.Mask = "00";
            this.maskedTextBoxSpAA.Name = "maskedTextBoxSpAA";
            this.maskedTextBoxSpAA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxSpAA.TabIndex = 8;
            this.maskedTextBoxSpAA.Tag = "ivs";
            this.maskedTextBoxSpAA.ValidatingType = typeof(int);
            // 
            // maskedTextBoxHPA
            // 
            this.maskedTextBoxHPA.Hex = false;
            this.maskedTextBoxHPA.Location = new System.Drawing.Point(121, 90);
            this.maskedTextBoxHPA.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHPA.Mask = "00";
            this.maskedTextBoxHPA.Name = "maskedTextBoxHPA";
            this.maskedTextBoxHPA.Size = new System.Drawing.Size(33, 24);
            this.maskedTextBoxHPA.TabIndex = 5;
            this.maskedTextBoxHPA.Tag = "ivs";
            // 
            // maskedTextBoxMaxOffset
            // 
            this.maskedTextBoxMaxOffset.Hex = false;
            this.maskedTextBoxMaxOffset.Location = new System.Drawing.Point(298, 30);
            this.maskedTextBoxMaxOffset.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMaxOffset.Mask = "00";
            this.maskedTextBoxMaxOffset.Name = "maskedTextBoxMaxOffset";
            this.maskedTextBoxMaxOffset.Size = new System.Drawing.Size(54, 24);
            this.maskedTextBoxMaxOffset.TabIndex = 4;
            // 
            // maskedTextBoxMinOffset
            // 
            this.maskedTextBoxMinOffset.Hex = false;
            this.maskedTextBoxMinOffset.Location = new System.Drawing.Point(235, 30);
            this.maskedTextBoxMinOffset.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMinOffset.Mask = "00";
            this.maskedTextBoxMinOffset.Name = "maskedTextBoxMinOffset";
            this.maskedTextBoxMinOffset.Size = new System.Drawing.Size(54, 24);
            this.maskedTextBoxMinOffset.TabIndex = 3;
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Hex = false;
            this.maskedTextBoxYear.Location = new System.Drawing.Point(69, 30);
            this.maskedTextBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(43, 24);
            this.maskedTextBoxYear.TabIndex = 0;
            this.maskedTextBoxYear.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxMinDelay
            // 
            this.maskedTextBoxMinDelay.Hex = false;
            this.maskedTextBoxMinDelay.Location = new System.Drawing.Point(120, 30);
            this.maskedTextBoxMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMinDelay.Mask = "00000";
            this.maskedTextBoxMinDelay.Name = "maskedTextBoxMinDelay";
            this.maskedTextBoxMinDelay.Size = new System.Drawing.Size(50, 24);
            this.maskedTextBoxMinDelay.TabIndex = 1;
            this.maskedTextBoxMinDelay.ValidatingType = typeof(int);
            // 
            // maskedTextBoxMaxDelay
            // 
            this.maskedTextBoxMaxDelay.Hex = false;
            this.maskedTextBoxMaxDelay.Location = new System.Drawing.Point(178, 30);
            this.maskedTextBoxMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMaxDelay.Mask = "00000";
            this.maskedTextBoxMaxDelay.Name = "maskedTextBoxMaxDelay";
            this.maskedTextBoxMaxDelay.Size = new System.Drawing.Size(50, 24);
            this.maskedTextBoxMaxDelay.TabIndex = 2;
            // 
            // tabPageShinyEgg
            // 
            this.tabPageShinyEgg.Controls.Add(this.labelHappinessWarning);
            this.tabPageShinyEgg.Controls.Add(this.checkBoxNoHappiness);
            this.tabPageShinyEgg.Controls.Add(this.label8);
            this.tabPageShinyEgg.Controls.Add(this.checkBoxIntlParents);
            this.tabPageShinyEgg.Controls.Add(this.radioButtonHGSS);
            this.tabPageShinyEgg.Controls.Add(this.radioButtonDPPt);
            this.tabPageShinyEgg.Controls.Add(this.label92);
            this.tabPageShinyEgg.Controls.Add(this.checkBoxShinyShinyOnly);
            this.tabPageShinyEgg.Controls.Add(this.labelDPPtWarning);
            this.tabPageShinyEgg.Controls.Add(this.dataGridViewShinyResults);
            this.tabPageShinyEgg.Controls.Add(this.labelShinySecretID);
            this.tabPageShinyEgg.Controls.Add(this.labelShinyNature);
            this.tabPageShinyEgg.Controls.Add(this.labelShinyTrainerID);
            this.tabPageShinyEgg.Controls.Add(this.labelShinyAbility);
            this.tabPageShinyEgg.Controls.Add(this.labelShinyDelay);
            this.tabPageShinyEgg.Controls.Add(this.labelShinyYear);
            this.tabPageShinyEgg.Controls.Add(this.comboBoxShinyGender);
            this.tabPageShinyEgg.Controls.Add(this.buttonShinyClearAbility);
            this.tabPageShinyEgg.Controls.Add(this.comboBoxShinyAbility);
            this.tabPageShinyEgg.Controls.Add(this.buttonShinyGenerate);
            this.tabPageShinyEgg.Controls.Add(this.buttonShinyClearNature);
            this.tabPageShinyEgg.Controls.Add(this.comboBoxShinyNature);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxMaxTaps);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxShinySecretID);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxShinyID);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxShinyMaxDelay);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxShinyMinDelay);
            this.tabPageShinyEgg.Controls.Add(this.maskedTextBoxShinyYear);
            this.tabPageShinyEgg.Location = new System.Drawing.Point(4, 25);
            this.tabPageShinyEgg.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageShinyEgg.Name = "tabPageShinyEgg";
            this.tabPageShinyEgg.Size = new System.Drawing.Size(1241, 626);
            this.tabPageShinyEgg.TabIndex = 2;
            this.tabPageShinyEgg.Text = "异色蛋";
            this.tabPageShinyEgg.UseVisualStyleBackColor = true;
            // 
            // labelHappinessWarning
            // 
            this.labelHappinessWarning.Location = new System.Drawing.Point(276, 105);
            this.labelHappinessWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHappinessWarning.Name = "labelHappinessWarning";
            this.labelHappinessWarning.Size = new System.Drawing.Size(336, 101);
            this.labelHappinessWarning.TabIndex = 325;
            this.labelHappinessWarning.Text = "It also assumes that you start the game from the coin flip application, and then " +
    "switch to the happiness checker application.\r\n";
            // 
            // checkBoxNoHappiness
            // 
            this.checkBoxNoHappiness.AutoSize = true;
            this.checkBoxNoHappiness.Location = new System.Drawing.Point(624, 62);
            this.checkBoxNoHappiness.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNoHappiness.Name = "checkBoxNoHappiness";
            this.checkBoxNoHappiness.Size = new System.Drawing.Size(213, 19);
            this.checkBoxNoHappiness.TabIndex = 8;
            this.checkBoxNoHappiness.Text = "Avoid Happiness Checker";
            this.checkBoxNoHappiness.UseVisualStyleBackColor = true;
            this.checkBoxNoHappiness.CheckedChanged += new System.EventHandler(this.checkBoxNoHappiness_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 322;
            this.label8.Text = "Max Taps";
            // 
            // checkBoxIntlParents
            // 
            this.checkBoxIntlParents.AutoSize = true;
            this.checkBoxIntlParents.Location = new System.Drawing.Point(69, 108);
            this.checkBoxIntlParents.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIntlParents.Name = "checkBoxIntlParents";
            this.checkBoxIntlParents.Size = new System.Drawing.Size(197, 19);
            this.checkBoxIntlParents.TabIndex = 5;
            this.checkBoxIntlParents.Text = "International Parents";
            this.checkBoxIntlParents.UseVisualStyleBackColor = true;
            // 
            // radioButtonHGSS
            // 
            this.radioButtonHGSS.AutoSize = true;
            this.radioButtonHGSS.Location = new System.Drawing.Point(69, 84);
            this.radioButtonHGSS.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHGSS.Name = "radioButtonHGSS";
            this.radioButtonHGSS.Size = new System.Drawing.Size(60, 19);
            this.radioButtonHGSS.TabIndex = 4;
            this.radioButtonHGSS.Text = "HGSS";
            this.radioButtonHGSS.UseVisualStyleBackColor = true;
            this.radioButtonHGSS.CheckedChanged += new System.EventHandler(this.comboBoxShinyVersion_SelectedIndexChanged);
            // 
            // radioButtonDPPt
            // 
            this.radioButtonDPPt.AutoSize = true;
            this.radioButtonDPPt.Checked = true;
            this.radioButtonDPPt.Location = new System.Drawing.Point(69, 61);
            this.radioButtonDPPt.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDPPt.Name = "radioButtonDPPt";
            this.radioButtonDPPt.Size = new System.Drawing.Size(60, 19);
            this.radioButtonDPPt.TabIndex = 3;
            this.radioButtonDPPt.TabStop = true;
            this.radioButtonDPPt.Text = "DPPt\r\n";
            this.radioButtonDPPt.UseVisualStyleBackColor = true;
            this.radioButtonDPPt.CheckedChanged += new System.EventHandler(this.comboBoxShinyVersion_SelectedIndexChanged);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(819, 118);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(67, 15);
            this.label92.TabIndex = 317;
            this.label92.Text = "性别比例";
            // 
            // checkBoxShinyShinyOnly
            // 
            this.checkBoxShinyShinyOnly.AutoSize = true;
            this.checkBoxShinyShinyOnly.Location = new System.Drawing.Point(875, 196);
            this.checkBoxShinyShinyOnly.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShinyShinyOnly.Name = "checkBoxShinyShinyOnly";
            this.checkBoxShinyShinyOnly.Size = new System.Drawing.Size(74, 19);
            this.checkBoxShinyShinyOnly.TabIndex = 16;
            this.checkBoxShinyShinyOnly.Text = "仅异色";
            this.checkBoxShinyShinyOnly.UseVisualStyleBackColor = true;
            // 
            // labelDPPtWarning
            // 
            this.labelDPPtWarning.Location = new System.Drawing.Point(276, 14);
            this.labelDPPtWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDPPtWarning.Name = "labelDPPtWarning";
            this.labelDPPtWarning.Size = new System.Drawing.Size(336, 89);
            this.labelDPPtWarning.TabIndex = 117;
            this.labelDPPtWarning.Text = "Please note that number of flips and taps that are listed assume that you will al" +
    "so be doing 10 coin flips to verify your initial seed. ";
            // 
            // dataGridViewShinyResults
            // 
            this.dataGridViewShinyResults.AllowUserToAddRows = false;
            this.dataGridViewShinyResults.AllowUserToDeleteRows = false;
            this.dataGridViewShinyResults.AllowUserToOrderColumns = true;
            this.dataGridViewShinyResults.AllowUserToResizeRows = false;
            this.dataGridViewShinyResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShinyResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewShinyResults.ColumnHeadersHeight = 20;
            this.dataGridViewShinyResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EggSeed,
            this.ShinyOffset,
            this.EggPID,
            this.shinyShinyDisplay,
            this.ShinyNature,
            this.dataGridViewTextBoxColumn4,
            this.ShinyFemale50,
            this.ShinyFemale25,
            this.ShinyFemale125,
            this.ShinyFemale75,
            this.ShinyFlipSequence,
            this.ShinyTaps,
            this.ShinyFlips});
            this.dataGridViewShinyResults.ContextMenuStrip = this.contextMenuStripEggPid;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShinyResults.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewShinyResults.Location = new System.Drawing.Point(8, 236);
            this.dataGridViewShinyResults.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewShinyResults.MultiSelect = false;
            this.dataGridViewShinyResults.Name = "dataGridViewShinyResults";
            this.dataGridViewShinyResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShinyResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewShinyResults.RowHeadersVisible = false;
            this.dataGridViewShinyResults.RowHeadersWidth = 51;
            this.dataGridViewShinyResults.RowTemplate.Height = 20;
            this.dataGridViewShinyResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShinyResults.ShowCellErrors = false;
            this.dataGridViewShinyResults.ShowCellToolTips = false;
            this.dataGridViewShinyResults.ShowEditingIcon = false;
            this.dataGridViewShinyResults.ShowRowErrors = false;
            this.dataGridViewShinyResults.Size = new System.Drawing.Size(1196, 379);
            this.dataGridViewShinyResults.TabIndex = 17;
            this.dataGridViewShinyResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewShinyResults_CellFormatting);
            this.dataGridViewShinyResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewShinyResults_MouseDown);
            // 
            // EggSeed
            // 
            this.EggSeed.DataPropertyName = "Seed";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.EggSeed.DefaultCellStyle = dataGridViewCellStyle12;
            this.EggSeed.HeaderText = "Seed";
            this.EggSeed.MinimumWidth = 6;
            this.EggSeed.Name = "EggSeed";
            this.EggSeed.ReadOnly = true;
            this.EggSeed.Width = 65;
            // 
            // ShinyOffset
            // 
            this.ShinyOffset.DataPropertyName = "Offset";
            this.ShinyOffset.HeaderText = "Frame";
            this.ShinyOffset.MinimumWidth = 6;
            this.ShinyOffset.Name = "ShinyOffset";
            this.ShinyOffset.ReadOnly = true;
            this.ShinyOffset.Width = 45;
            // 
            // EggPID
            // 
            this.EggPID.DataPropertyName = "Pid";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.EggPID.DefaultCellStyle = dataGridViewCellStyle13;
            this.EggPID.HeaderText = "PID";
            this.EggPID.MinimumWidth = 6;
            this.EggPID.Name = "EggPID";
            this.EggPID.ReadOnly = true;
            this.EggPID.Width = 70;
            // 
            // shinyShinyDisplay
            // 
            this.shinyShinyDisplay.DataPropertyName = "ShinyDisplay";
            this.shinyShinyDisplay.HeaderText = "!!!";
            this.shinyShinyDisplay.MinimumWidth = 6;
            this.shinyShinyDisplay.Name = "shinyShinyDisplay";
            this.shinyShinyDisplay.ReadOnly = true;
            this.shinyShinyDisplay.Width = 20;
            // 
            // ShinyNature
            // 
            this.ShinyNature.DataPropertyName = "Nature";
            this.ShinyNature.HeaderText = "性格";
            this.ShinyNature.MinimumWidth = 6;
            this.ShinyNature.Name = "ShinyNature";
            this.ShinyNature.ReadOnly = true;
            this.ShinyNature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShinyNature.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ability";
            this.dataGridViewTextBoxColumn4.HeaderText = "特性";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // ShinyFemale50
            // 
            this.ShinyFemale50.DataPropertyName = "Female50";
            this.ShinyFemale50.HeaderText = "50% F";
            this.ShinyFemale50.MinimumWidth = 6;
            this.ShinyFemale50.Name = "ShinyFemale50";
            this.ShinyFemale50.ReadOnly = true;
            this.ShinyFemale50.Width = 50;
            // 
            // ShinyFemale25
            // 
            this.ShinyFemale25.DataPropertyName = "Female25";
            this.ShinyFemale25.HeaderText = "25% F";
            this.ShinyFemale25.MinimumWidth = 6;
            this.ShinyFemale25.Name = "ShinyFemale25";
            this.ShinyFemale25.ReadOnly = true;
            this.ShinyFemale25.Width = 50;
            // 
            // ShinyFemale125
            // 
            this.ShinyFemale125.DataPropertyName = "Female125";
            this.ShinyFemale125.HeaderText = "12.5%F";
            this.ShinyFemale125.MinimumWidth = 6;
            this.ShinyFemale125.Name = "ShinyFemale125";
            this.ShinyFemale125.ReadOnly = true;
            this.ShinyFemale125.Width = 50;
            // 
            // ShinyFemale75
            // 
            this.ShinyFemale75.DataPropertyName = "Female75";
            this.ShinyFemale75.HeaderText = "75% F";
            this.ShinyFemale75.MinimumWidth = 6;
            this.ShinyFemale75.Name = "ShinyFemale75";
            this.ShinyFemale75.ReadOnly = true;
            this.ShinyFemale75.Width = 50;
            // 
            // ShinyFlipSequence
            // 
            this.ShinyFlipSequence.DataPropertyName = "FlipSequence";
            this.ShinyFlipSequence.HeaderText = "Flip Sequence";
            this.ShinyFlipSequence.MinimumWidth = 6;
            this.ShinyFlipSequence.Name = "ShinyFlipSequence";
            this.ShinyFlipSequence.ReadOnly = true;
            this.ShinyFlipSequence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShinyFlipSequence.Width = 150;
            // 
            // ShinyTaps
            // 
            this.ShinyTaps.DataPropertyName = "Taps";
            this.ShinyTaps.HeaderText = "Taps";
            this.ShinyTaps.MinimumWidth = 6;
            this.ShinyTaps.Name = "ShinyTaps";
            this.ShinyTaps.ReadOnly = true;
            this.ShinyTaps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShinyTaps.Width = 50;
            // 
            // ShinyFlips
            // 
            this.ShinyFlips.DataPropertyName = "Flips";
            this.ShinyFlips.HeaderText = "Additional Flips";
            this.ShinyFlips.MinimumWidth = 6;
            this.ShinyFlips.Name = "ShinyFlips";
            this.ShinyFlips.ReadOnly = true;
            this.ShinyFlips.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShinyFlips.Width = 125;
            // 
            // labelShinySecretID
            // 
            this.labelShinySecretID.AutoSize = true;
            this.labelShinySecretID.Location = new System.Drawing.Point(941, 146);
            this.labelShinySecretID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinySecretID.Name = "labelShinySecretID";
            this.labelShinySecretID.Size = new System.Drawing.Size(31, 15);
            this.labelShinySecretID.TabIndex = 23;
            this.labelShinySecretID.Text = "SID";
            // 
            // labelShinyNature
            // 
            this.labelShinyNature.AutoSize = true;
            this.labelShinyNature.Location = new System.Drawing.Point(825, 25);
            this.labelShinyNature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinyNature.Name = "labelShinyNature";
            this.labelShinyNature.Size = new System.Drawing.Size(37, 15);
            this.labelShinyNature.TabIndex = 14;
            this.labelShinyNature.Text = "性格";
            // 
            // labelShinyTrainerID
            // 
            this.labelShinyTrainerID.AutoSize = true;
            this.labelShinyTrainerID.Location = new System.Drawing.Point(874, 146);
            this.labelShinyTrainerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinyTrainerID.Name = "labelShinyTrainerID";
            this.labelShinyTrainerID.Size = new System.Drawing.Size(23, 15);
            this.labelShinyTrainerID.TabIndex = 21;
            this.labelShinyTrainerID.Text = "ID";
            // 
            // labelShinyAbility
            // 
            this.labelShinyAbility.AutoSize = true;
            this.labelShinyAbility.Location = new System.Drawing.Point(829, 59);
            this.labelShinyAbility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinyAbility.Name = "labelShinyAbility";
            this.labelShinyAbility.Size = new System.Drawing.Size(37, 15);
            this.labelShinyAbility.TabIndex = 20;
            this.labelShinyAbility.Text = "特性";
            // 
            // labelShinyDelay
            // 
            this.labelShinyDelay.AutoSize = true;
            this.labelShinyDelay.Location = new System.Drawing.Point(121, 11);
            this.labelShinyDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinyDelay.Name = "labelShinyDelay";
            this.labelShinyDelay.Size = new System.Drawing.Size(115, 15);
            this.labelShinyDelay.TabIndex = 12;
            this.labelShinyDelay.Text = "最小/最大Delay";
            // 
            // labelShinyYear
            // 
            this.labelShinyYear.AutoSize = true;
            this.labelShinyYear.Location = new System.Drawing.Point(65, 11);
            this.labelShinyYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShinyYear.Name = "labelShinyYear";
            this.labelShinyYear.Size = new System.Drawing.Size(37, 15);
            this.labelShinyYear.TabIndex = 2;
            this.labelShinyYear.Text = "年份";
            // 
            // comboBoxShinyGender
            // 
            this.comboBoxShinyGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShinyGender.ForeColor = System.Drawing.Color.Black;
            this.comboBoxShinyGender.FormattingEnabled = true;
            this.comboBoxShinyGender.Items.AddRange(new object[] {
            "Don\'t Care/Fixed Gender/Genderless",
            "Female (50% Male, 50% Female)",
            "Male (50% Male, 50% Female)",
            "Female (25% Male, 75% Female)",
            "Male (25% Male, 75% Female)",
            "Female (75% Male, 25% Female)",
            "Male (75% Male, 25% Female)",
            "Female (87.5% Male, 12.5% Female)",
            "Male (87.5% Male, 12.5% Female)"});
            this.comboBoxShinyGender.Location = new System.Drawing.Point(875, 114);
            this.comboBoxShinyGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShinyGender.MaxDropDownItems = 3;
            this.comboBoxShinyGender.Name = "comboBoxShinyGender";
            this.comboBoxShinyGender.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxShinyGender.Size = new System.Drawing.Size(274, 23);
            this.comboBoxShinyGender.TabIndex = 13;
            // 
            // buttonShinyClearAbility
            // 
            this.buttonShinyClearAbility.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonShinyClearAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonShinyClearAbility.ForeColor = System.Drawing.Color.Black;
            this.buttonShinyClearAbility.Location = new System.Drawing.Point(980, 52);
            this.buttonShinyClearAbility.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShinyClearAbility.Name = "buttonShinyClearAbility";
            this.buttonShinyClearAbility.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonShinyClearAbility.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonShinyClearAbility.Size = new System.Drawing.Size(58, 28);
            this.buttonShinyClearAbility.TabIndex = 12;
            this.buttonShinyClearAbility.TabStop = false;
            this.buttonShinyClearAbility.Text = "任意";
            this.buttonShinyClearAbility.Click += new System.EventHandler(this.buttonShinyClearAbility_Click);
            // 
            // comboBoxShinyAbility
            // 
            this.comboBoxShinyAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShinyAbility.ForeColor = System.Drawing.Color.Black;
            this.comboBoxShinyAbility.FormattingEnabled = true;
            this.comboBoxShinyAbility.Items.AddRange(new object[] {
            "任意",
            "特性0",
            "特性1"});
            this.comboBoxShinyAbility.Location = new System.Drawing.Point(875, 54);
            this.comboBoxShinyAbility.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShinyAbility.MaxDropDownItems = 3;
            this.comboBoxShinyAbility.Name = "comboBoxShinyAbility";
            this.comboBoxShinyAbility.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxShinyAbility.Size = new System.Drawing.Size(94, 23);
            this.comboBoxShinyAbility.TabIndex = 11;
            // 
            // buttonShinyGenerate
            // 
            this.buttonShinyGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonShinyGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonShinyGenerate.Location = new System.Drawing.Point(15, 196);
            this.buttonShinyGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShinyGenerate.Name = "buttonShinyGenerate";
            this.buttonShinyGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonShinyGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonShinyGenerate.Size = new System.Drawing.Size(91, 29);
            this.buttonShinyGenerate.TabIndex = 6;
            this.buttonShinyGenerate.Text = "计算";
            this.buttonShinyGenerate.Click += new System.EventHandler(this.buttonShinyGenerate_Click);
            // 
            // buttonShinyClearNature
            // 
            this.buttonShinyClearNature.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonShinyClearNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonShinyClearNature.ForeColor = System.Drawing.Color.Black;
            this.buttonShinyClearNature.Location = new System.Drawing.Point(980, 18);
            this.buttonShinyClearNature.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShinyClearNature.Name = "buttonShinyClearNature";
            this.buttonShinyClearNature.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonShinyClearNature.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonShinyClearNature.Size = new System.Drawing.Size(58, 28);
            this.buttonShinyClearNature.TabIndex = 10;
            this.buttonShinyClearNature.TabStop = false;
            this.buttonShinyClearNature.Text = "任意";
            this.buttonShinyClearNature.Click += new System.EventHandler(this.buttonShinyClearNature_Click);
            // 
            // comboBoxShinyNature
            // 
            this.comboBoxShinyNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShinyNature.ForeColor = System.Drawing.Color.Black;
            this.comboBoxShinyNature.FormattingEnabled = true;
            this.comboBoxShinyNature.Location = new System.Drawing.Point(875, 20);
            this.comboBoxShinyNature.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShinyNature.MaxDropDownItems = 26;
            this.comboBoxShinyNature.Name = "comboBoxShinyNature";
            this.comboBoxShinyNature.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxShinyNature.Size = new System.Drawing.Size(94, 23);
            this.comboBoxShinyNature.TabIndex = 9;
            this.comboBoxShinyNature.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FocusControl);
            // 
            // maskedTextBoxMaxTaps
            // 
            this.maskedTextBoxMaxTaps.Hex = false;
            this.maskedTextBoxMaxTaps.Location = new System.Drawing.Point(624, 30);
            this.maskedTextBoxMaxTaps.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMaxTaps.Mask = "000";
            this.maskedTextBoxMaxTaps.Name = "maskedTextBoxMaxTaps";
            this.maskedTextBoxMaxTaps.Size = new System.Drawing.Size(54, 24);
            this.maskedTextBoxMaxTaps.TabIndex = 7;
            this.maskedTextBoxMaxTaps.Text = "10";
            // 
            // maskedTextBoxShinySecretID
            // 
            this.maskedTextBoxShinySecretID.Hex = false;
            this.maskedTextBoxShinySecretID.Location = new System.Drawing.Point(942, 165);
            this.maskedTextBoxShinySecretID.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxShinySecretID.Mask = "00000";
            this.maskedTextBoxShinySecretID.Name = "maskedTextBoxShinySecretID";
            this.maskedTextBoxShinySecretID.Size = new System.Drawing.Size(59, 24);
            this.maskedTextBoxShinySecretID.TabIndex = 15;
            this.maskedTextBoxShinySecretID.Tag = "id/sid";
            this.maskedTextBoxShinySecretID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxShinyID
            // 
            this.maskedTextBoxShinyID.Hex = false;
            this.maskedTextBoxShinyID.Location = new System.Drawing.Point(875, 165);
            this.maskedTextBoxShinyID.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxShinyID.Mask = "00000";
            this.maskedTextBoxShinyID.Name = "maskedTextBoxShinyID";
            this.maskedTextBoxShinyID.Size = new System.Drawing.Size(59, 24);
            this.maskedTextBoxShinyID.TabIndex = 14;
            this.maskedTextBoxShinyID.Tag = "id/sid";
            this.maskedTextBoxShinyID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxShinyMaxDelay
            // 
            this.maskedTextBoxShinyMaxDelay.Hex = false;
            this.maskedTextBoxShinyMaxDelay.Location = new System.Drawing.Point(178, 30);
            this.maskedTextBoxShinyMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxShinyMaxDelay.Mask = "00000";
            this.maskedTextBoxShinyMaxDelay.Name = "maskedTextBoxShinyMaxDelay";
            this.maskedTextBoxShinyMaxDelay.Size = new System.Drawing.Size(49, 24);
            this.maskedTextBoxShinyMaxDelay.TabIndex = 2;
            this.maskedTextBoxShinyMaxDelay.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxShinyMinDelay
            // 
            this.maskedTextBoxShinyMinDelay.Hex = false;
            this.maskedTextBoxShinyMinDelay.Location = new System.Drawing.Point(120, 30);
            this.maskedTextBoxShinyMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxShinyMinDelay.Mask = "00000";
            this.maskedTextBoxShinyMinDelay.Name = "maskedTextBoxShinyMinDelay";
            this.maskedTextBoxShinyMinDelay.Size = new System.Drawing.Size(50, 24);
            this.maskedTextBoxShinyMinDelay.TabIndex = 1;
            this.maskedTextBoxShinyMinDelay.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxShinyYear
            // 
            this.maskedTextBoxShinyYear.Hex = false;
            this.maskedTextBoxShinyYear.Location = new System.Drawing.Point(69, 30);
            this.maskedTextBoxShinyYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxShinyYear.Mask = "0000";
            this.maskedTextBoxShinyYear.Name = "maskedTextBoxShinyYear";
            this.maskedTextBoxShinyYear.Size = new System.Drawing.Size(43, 24);
            this.maskedTextBoxShinyYear.TabIndex = 0;
            this.maskedTextBoxShinyYear.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tabPageCapture
            // 
            this.tabPageCapture.Controls.Add(this.ivFiltersCapture);
            this.tabPageCapture.Controls.Add(this.comboBoxCapGenderRatio);
            this.tabPageCapture.Controls.Add(this.label2);
            this.tabPageCapture.Controls.Add(this.comboBoxCapGender);
            this.tabPageCapture.Controls.Add(this.label31);
            this.tabPageCapture.Controls.Add(this.dataGridViewCapValues);
            this.tabPageCapture.Controls.Add(this.buttonAnySlot);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxCapMinOffset);
            this.tabPageCapture.Controls.Add(this.label54);
            this.tabPageCapture.Controls.Add(this.comboBoxEncounterType);
            this.tabPageCapture.Controls.Add(this.comboBoxEncounterSlot);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxCapMaxDelay);
            this.tabPageCapture.Controls.Add(this.label52);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxCapMinDelay);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxCapYear);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxCapMaxOffset);
            this.tabPageCapture.Controls.Add(this.labelCapMinMaxFrame);
            this.tabPageCapture.Controls.Add(this.label22);
            this.tabPageCapture.Controls.Add(this.label20);
            this.tabPageCapture.Controls.Add(this.comboBoxMethod);
            this.tabPageCapture.Controls.Add(this.label30);
            this.tabPageCapture.Controls.Add(this.buttonCapGenerate);
            this.tabPageCapture.Controls.Add(this.buttonAnyNature);
            this.tabPageCapture.Controls.Add(this.lblID);
            this.tabPageCapture.Controls.Add(this.comboBoxAbility);
            this.tabPageCapture.Controls.Add(this.label26);
            this.tabPageCapture.Controls.Add(this.label23);
            this.tabPageCapture.Controls.Add(this.checkBoxShinyOnly);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxID);
            this.tabPageCapture.Controls.Add(this.maskedTextBoxSID);
            this.tabPageCapture.Controls.Add(this.label21);
            this.tabPageCapture.Controls.Add(this.comboBoxNature);
            this.tabPageCapture.Location = new System.Drawing.Point(4, 25);
            this.tabPageCapture.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCapture.Name = "tabPageCapture";
            this.tabPageCapture.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCapture.Size = new System.Drawing.Size(1241, 626);
            this.tabPageCapture.TabIndex = 1;
            this.tabPageCapture.Text = "Capture";
            this.tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // ivFiltersCapture
            // 
            this.ivFiltersCapture.Location = new System.Drawing.Point(459, 8);
            this.ivFiltersCapture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ivFiltersCapture.Name = "ivFiltersCapture";
            this.ivFiltersCapture.Size = new System.Drawing.Size(394, 208);
            this.ivFiltersCapture.TabIndex = 325;
            // 
            // comboBoxCapGenderRatio
            // 
            this.comboBoxCapGenderRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCapGenderRatio.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCapGenderRatio.FormattingEnabled = true;
            this.comboBoxCapGenderRatio.Items.AddRange(new object[] {
            "All Ratios",
            "50% M / 50% F",
            "25% M / 75% F",
            "75% M / 25% F",
            "87.5% M / 12.5% F",
            "Fixed Gender"});
            this.comboBoxCapGenderRatio.Location = new System.Drawing.Point(1055, 112);
            this.comboBoxCapGenderRatio.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCapGenderRatio.MaxDropDownItems = 3;
            this.comboBoxCapGenderRatio.Name = "comboBoxCapGenderRatio";
            this.comboBoxCapGenderRatio.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxCapGenderRatio.Size = new System.Drawing.Size(148, 23);
            this.comboBoxCapGenderRatio.TabIndex = 27;
            this.toolTipGenderRatio.SetToolTip(this.comboBoxCapGenderRatio, "Right-click to look up the gender\r\nratio of a certain Pokémon.\r\n\r\nUse this box to" +
        " filter out unwanted\r\nCute Charm results.\r\n");
            this.comboBoxCapGenderRatio.SelectedIndexChanged += new System.EventHandler(this.comboBoxCapGenderRatio_SelectedIndexChanged);
            this.comboBoxCapGenderRatio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxCapGenderRatio_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 324;
            this.label2.Text = "比例";
            // 
            // comboBoxCapGender
            // 
            this.comboBoxCapGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCapGender.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCapGender.FormattingEnabled = true;
            this.comboBoxCapGender.Items.AddRange(new object[] {
            "任意",
            "Male",
            "Female"});
            this.comboBoxCapGender.Location = new System.Drawing.Point(929, 114);
            this.comboBoxCapGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCapGender.MaxDropDownItems = 3;
            this.comboBoxCapGender.Name = "comboBoxCapGender";
            this.comboBoxCapGender.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxCapGender.Size = new System.Drawing.Size(73, 23);
            this.comboBoxCapGender.TabIndex = 26;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(872, 118);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 15);
            this.label31.TabIndex = 321;
            this.label31.Text = "性别";
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCapValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewCapValues.ColumnHeadersHeight = 20;
            this.dataGridViewCapValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCapValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CapSeed,
            this.CapOffset,
            this.Hour,
            this.EncounterMod,
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
            this.HiddenPower,
            this.HiddenPowerPower,
            this.f50,
            this.f125,
            this.f25,
            this.f75});
            this.dataGridViewCapValues.ContextMenuStrip = this.contextMenuStripCap;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCapValues.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewCapValues.Location = new System.Drawing.Point(8, 236);
            this.dataGridViewCapValues.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCapValues.MultiSelect = false;
            this.dataGridViewCapValues.Name = "dataGridViewCapValues";
            this.dataGridViewCapValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCapValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewCapValues.RowHeadersVisible = false;
            this.dataGridViewCapValues.RowHeadersWidth = 51;
            this.dataGridViewCapValues.RowTemplate.Height = 20;
            this.dataGridViewCapValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCapValues.ShowCellErrors = false;
            this.dataGridViewCapValues.ShowCellToolTips = false;
            this.dataGridViewCapValues.ShowEditingIcon = false;
            this.dataGridViewCapValues.ShowRowErrors = false;
            this.dataGridViewCapValues.Size = new System.Drawing.Size(1196, 379);
            this.dataGridViewCapValues.TabIndex = 10;
            this.toolTipDataGrid.SetToolTip(this.dataGridViewCapValues, "test");
            this.dataGridViewCapValues.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCapValues_CellFormatting);
            this.dataGridViewCapValues.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCapValues_CellMouseEnter);
            this.dataGridViewCapValues.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCapValues_CellMouseLeave);
            this.dataGridViewCapValues.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCapValues_ColumnHeaderMouseClick);
            this.dataGridViewCapValues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCapValues_KeyDown);
            this.dataGridViewCapValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCapValues_MouseDown);
            // 
            // contextMenuStripCap
            // 
            this.contextMenuStripCap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripCap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySeedToClipboardToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.generateTimesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.outputCapResultsToTXTToolStripMenuItem});
            this.contextMenuStripCap.Name = "contextMenuStripCap";
            this.contextMenuStripCap.Size = new System.Drawing.Size(253, 88);
            this.contextMenuStripCap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCap_Opening);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(249, 6);
            // 
            // outputCapResultsToTXTToolStripMenuItem
            // 
            this.outputCapResultsToTXTToolStripMenuItem.Name = "outputCapResultsToTXTToolStripMenuItem";
            this.outputCapResultsToTXTToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.outputCapResultsToTXTToolStripMenuItem.Text = "输出结果至TXT文本文件";
            this.outputCapResultsToTXTToolStripMenuItem.Click += new System.EventHandler(this.outputCapResultsToTXTToolStripMenuItem_Click);
            // 
            // buttonAnySlot
            // 
            this.buttonAnySlot.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonAnySlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAnySlot.ForeColor = System.Drawing.Color.Black;
            this.buttonAnySlot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnySlot.Location = new System.Drawing.Point(320, 122);
            this.buttonAnySlot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnySlot.Name = "buttonAnySlot";
            this.buttonAnySlot.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonAnySlot.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonAnySlot.Size = new System.Drawing.Size(51, 28);
            this.buttonAnySlot.TabIndex = 8;
            this.buttonAnySlot.Text = "任意";
            this.buttonAnySlot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnySlot.Click += new System.EventHandler(this.buttonAnySlot_Click);
            // 
            // maskedTextBoxCapMinOffset
            // 
            this.maskedTextBoxCapMinOffset.Hex = false;
            this.maskedTextBoxCapMinOffset.Location = new System.Drawing.Point(235, 30);
            this.maskedTextBoxCapMinOffset.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCapMinOffset.Mask = "00000";
            this.maskedTextBoxCapMinOffset.Name = "maskedTextBoxCapMinOffset";
            this.maskedTextBoxCapMinOffset.Size = new System.Drawing.Size(54, 24);
            this.maskedTextBoxCapMinOffset.TabIndex = 3;
            this.maskedTextBoxCapMinOffset.Text = "1";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(35, 130);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(67, 15);
            this.label54.TabIndex = 120;
            this.label54.Text = "遭遇槽位";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEncounterType
            // 
            this.comboBoxEncounterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncounterType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEncounterType.FormattingEnabled = true;
            this.comboBoxEncounterType.Items.AddRange(new object[] {
            "Stationary\\Gift Pokémon"});
            this.comboBoxEncounterType.Location = new System.Drawing.Point(121, 95);
            this.comboBoxEncounterType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEncounterType.Name = "comboBoxEncounterType";
            this.comboBoxEncounterType.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxEncounterType.Size = new System.Drawing.Size(194, 23);
            this.comboBoxEncounterType.TabIndex = 6;
            // 
            // comboBoxEncounterSlot
            // 
            this.comboBoxEncounterSlot.BlankText = "任意";
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxEncounterSlot.CheckBoxProperties = checkBoxProperties1;
            this.comboBoxEncounterSlot.DisplayMemberSingleItem = "";
            this.comboBoxEncounterSlot.DropDownHeight = 310;
            this.comboBoxEncounterSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncounterSlot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEncounterSlot.FormattingEnabled = true;
            this.comboBoxEncounterSlot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBoxEncounterSlot.Location = new System.Drawing.Point(121, 124);
            this.comboBoxEncounterSlot.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEncounterSlot.Name = "comboBoxEncounterSlot";
            this.comboBoxEncounterSlot.Size = new System.Drawing.Size(194, 23);
            this.comboBoxEncounterSlot.TabIndex = 7;
            this.comboBoxEncounterSlot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FocusControl);
            // 
            // maskedTextBoxCapMaxDelay
            // 
            this.maskedTextBoxCapMaxDelay.Hex = false;
            this.maskedTextBoxCapMaxDelay.Location = new System.Drawing.Point(178, 30);
            this.maskedTextBoxCapMaxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCapMaxDelay.Mask = "00000";
            this.maskedTextBoxCapMaxDelay.Name = "maskedTextBoxCapMaxDelay";
            this.maskedTextBoxCapMaxDelay.Size = new System.Drawing.Size(50, 24);
            this.maskedTextBoxCapMaxDelay.TabIndex = 2;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(35, 101);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(67, 15);
            this.label52.TabIndex = 121;
            this.label52.Text = "相遇类型";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maskedTextBoxCapMinDelay
            // 
            this.maskedTextBoxCapMinDelay.Hex = false;
            this.maskedTextBoxCapMinDelay.Location = new System.Drawing.Point(120, 30);
            this.maskedTextBoxCapMinDelay.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCapMinDelay.Mask = "00000";
            this.maskedTextBoxCapMinDelay.Name = "maskedTextBoxCapMinDelay";
            this.maskedTextBoxCapMinDelay.Size = new System.Drawing.Size(50, 24);
            this.maskedTextBoxCapMinDelay.TabIndex = 1;
            this.maskedTextBoxCapMinDelay.ValidatingType = typeof(int);
            // 
            // maskedTextBoxCapYear
            // 
            this.maskedTextBoxCapYear.Hex = false;
            this.maskedTextBoxCapYear.Location = new System.Drawing.Point(69, 30);
            this.maskedTextBoxCapYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCapYear.Mask = "0000";
            this.maskedTextBoxCapYear.Name = "maskedTextBoxCapYear";
            this.maskedTextBoxCapYear.Size = new System.Drawing.Size(43, 24);
            this.maskedTextBoxCapYear.TabIndex = 0;
            this.maskedTextBoxCapYear.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCapMaxOffset
            // 
            this.maskedTextBoxCapMaxOffset.Hex = false;
            this.maskedTextBoxCapMaxOffset.Location = new System.Drawing.Point(298, 30);
            this.maskedTextBoxCapMaxOffset.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCapMaxOffset.Mask = "00000";
            this.maskedTextBoxCapMaxOffset.Name = "maskedTextBoxCapMaxOffset";
            this.maskedTextBoxCapMaxOffset.Size = new System.Drawing.Size(54, 24);
            this.maskedTextBoxCapMaxOffset.TabIndex = 4;
            // 
            // labelCapMinMaxFrame
            // 
            this.labelCapMinMaxFrame.AutoSize = true;
            this.labelCapMinMaxFrame.Location = new System.Drawing.Point(239, 11);
            this.labelCapMinMaxFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapMinMaxFrame.Name = "labelCapMinMaxFrame";
            this.labelCapMinMaxFrame.Size = new System.Drawing.Size(90, 15);
            this.labelCapMinMaxFrame.TabIndex = 107;
            this.labelCapMinMaxFrame.Text = "最小/最大帧";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(121, 11);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 15);
            this.label22.TabIndex = 108;
            this.label22.Text = "最小/最大Delay";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(65, 11);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 15);
            this.label20.TabIndex = 106;
            this.label20.Text = "年份";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(121, 66);
            this.comboBoxMethod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxMethod.Size = new System.Drawing.Size(194, 23);
            this.comboBoxMethod.TabIndex = 5;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(64, 71);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 15);
            this.label30.TabIndex = 113;
            this.label30.Text = "算法 ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCapGenerate
            // 
            this.buttonCapGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCapGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonCapGenerate.Location = new System.Drawing.Point(15, 196);
            this.buttonCapGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapGenerate.Name = "buttonCapGenerate";
            this.buttonCapGenerate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonCapGenerate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonCapGenerate.Size = new System.Drawing.Size(91, 29);
            this.buttonCapGenerate.TabIndex = 9;
            this.buttonCapGenerate.Text = "计算";
            this.buttonCapGenerate.Click += new System.EventHandler(this.buttonCapGenerate_Click);
            // 
            // buttonAnyNature
            // 
            this.buttonAnyNature.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonAnyNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAnyNature.ForeColor = System.Drawing.Color.Black;
            this.buttonAnyNature.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnyNature.Location = new System.Drawing.Point(1152, 19);
            this.buttonAnyNature.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnyNature.Name = "buttonAnyNature";
            this.buttonAnyNature.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonAnyNature.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonAnyNature.Size = new System.Drawing.Size(51, 28);
            this.buttonAnyNature.TabIndex = 24;
            this.buttonAnyNature.Text = "任意";
            this.buttonAnyNature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnyNature.Click += new System.EventHandler(this.buttonAnyNature_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(928, 146);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 15);
            this.lblID.TabIndex = 69;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxAbility
            // 
            this.comboBoxAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAbility.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAbility.FormattingEnabled = true;
            this.comboBoxAbility.Items.AddRange(new object[] {
            "任意",
            "特性0",
            "特性1"});
            this.comboBoxAbility.Location = new System.Drawing.Point(929, 54);
            this.comboBoxAbility.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAbility.Name = "comboBoxAbility";
            this.comboBoxAbility.ShineColor = System.Drawing.SystemColors.Window;
            this.comboBoxAbility.Size = new System.Drawing.Size(83, 23);
            this.comboBoxAbility.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(995, 146);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 15);
            this.label26.TabIndex = 71;
            this.label26.Text = "SID";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(882, 59);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 68;
            this.label23.Text = "特性";
            // 
            // checkBoxShinyOnly
            // 
            this.checkBoxShinyOnly.AutoSize = true;
            this.checkBoxShinyOnly.Location = new System.Drawing.Point(929, 196);
            this.checkBoxShinyOnly.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShinyOnly.Name = "checkBoxShinyOnly";
            this.checkBoxShinyOnly.Size = new System.Drawing.Size(74, 19);
            this.checkBoxShinyOnly.TabIndex = 30;
            this.checkBoxShinyOnly.Text = "仅异色";
            this.checkBoxShinyOnly.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Hex = false;
            this.maskedTextBoxID.Location = new System.Drawing.Point(929, 165);
            this.maskedTextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxID.Mask = "00000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(59, 24);
            this.maskedTextBoxID.TabIndex = 28;
            this.maskedTextBoxID.Tag = "id/sid";
            this.maskedTextBoxID.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSID
            // 
            this.maskedTextBoxSID.Hex = false;
            this.maskedTextBoxSID.Location = new System.Drawing.Point(996, 165);
            this.maskedTextBoxSID.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxSID.Mask = "00000";
            this.maskedTextBoxSID.Name = "maskedTextBoxSID";
            this.maskedTextBoxSID.Size = new System.Drawing.Size(59, 24);
            this.maskedTextBoxSID.TabIndex = 29;
            this.maskedTextBoxSID.Tag = "id/sid";
            this.maskedTextBoxSID.ValidatingType = typeof(int);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(879, 25);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 15);
            this.label21.TabIndex = 11;
            this.label21.Text = "性格";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.BlankText = "任意";
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxNature.CheckBoxProperties = checkBoxProperties2;
            this.comboBoxNature.DisplayMemberSingleItem = "";
            this.comboBoxNature.DropDownHeight = 300;
            this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Location = new System.Drawing.Point(929, 20);
            this.comboBoxNature.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.Size = new System.Drawing.Size(219, 23);
            this.comboBoxNature.TabIndex = 23;
            this.comboBoxNature.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FocusControl);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageCapture);
            this.tabControl.Controls.Add(this.tabPageShinyEgg);
            this.tabControl.Controls.Add(this.tabPageEggIVs);
            this.tabControl.Location = new System.Drawing.Point(15, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1249, 655);
            this.tabControl.TabIndex = 0;
            // 
            // toolTipDataGrid
            // 
            this.toolTipDataGrid.AutoPopDelay = 6000;
            this.toolTipDataGrid.InitialDelay = 300;
            this.toolTipDataGrid.ReshowDelay = 100;
            this.toolTipDataGrid.ToolTipTitle = "Gender Ratio";
            // 
            // toolTipGenderRatio
            // 
            this.toolTipGenderRatio.AutoPopDelay = 6000;
            this.toolTipGenderRatio.InitialDelay = 300;
            this.toolTipGenderRatio.ReshowDelay = 100;
            this.toolTipGenderRatio.ToolTipTitle = "Gender Ratio";
            // 
            // CapSeed
            // 
            this.CapSeed.DataPropertyName = "Seed";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.CapSeed.DefaultCellStyle = dataGridViewCellStyle21;
            this.CapSeed.FillWeight = 110F;
            this.CapSeed.HeaderText = "Seed";
            this.CapSeed.MinimumWidth = 6;
            this.CapSeed.Name = "CapSeed";
            this.CapSeed.ReadOnly = true;
            this.CapSeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CapSeed.Width = 65;
            // 
            // CapOffset
            // 
            this.CapOffset.DataPropertyName = "Offset";
            this.CapOffset.HeaderText = "帧数";
            this.CapOffset.MinimumWidth = 6;
            this.CapOffset.Name = "CapOffset";
            this.CapOffset.ReadOnly = true;
            this.CapOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CapOffset.Width = 45;
            // 
            // Hour
            // 
            this.Hour.DataPropertyName = "Hour";
            this.Hour.HeaderText = "时";
            this.Hour.MinimumWidth = 6;
            this.Hour.Name = "Hour";
            this.Hour.ReadOnly = true;
            this.Hour.Width = 40;
            // 
            // EncounterMod
            // 
            this.EncounterMod.DataPropertyName = "EncounterMod";
            this.EncounterMod.HeaderText = "Required Lead";
            this.EncounterMod.MinimumWidth = 6;
            this.EncounterMod.Name = "EncounterMod";
            this.EncounterMod.ReadOnly = true;
            this.EncounterMod.Width = 115;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "Pid";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Consolas", 8.75F);
            this.PID.DefaultCellStyle = dataGridViewCellStyle22;
            this.PID.HeaderText = "PID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 70;
            // 
            // EncounterSlot
            // 
            this.EncounterSlot.DataPropertyName = "EncounterSlot";
            this.EncounterSlot.FillWeight = 50F;
            this.EncounterSlot.HeaderText = "遭遇槽位";
            this.EncounterSlot.MinimumWidth = 6;
            this.EncounterSlot.Name = "EncounterSlot";
            this.EncounterSlot.ReadOnly = true;
            this.EncounterSlot.Width = 85;
            // 
            // Shiny
            // 
            this.Shiny.DataPropertyName = "ShinyDisplay";
            this.Shiny.HeaderText = "异色";
            this.Shiny.MinimumWidth = 6;
            this.Shiny.Name = "Shiny";
            this.Shiny.ReadOnly = true;
            this.Shiny.Width = 20;
            // 
            // Nature
            // 
            this.Nature.DataPropertyName = "Nature";
            this.Nature.HeaderText = "性格";
            this.Nature.MinimumWidth = 6;
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            this.Nature.Width = 65;
            // 
            // Ability
            // 
            this.Ability.DataPropertyName = "Ability";
            this.Ability.HeaderText = "特性";
            this.Ability.MinimumWidth = 6;
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            this.Ability.Width = 40;
            // 
            // CapHP
            // 
            this.CapHP.DataPropertyName = "Hp";
            this.CapHP.HeaderText = "HP";
            this.CapHP.MinimumWidth = 6;
            this.CapHP.Name = "CapHP";
            this.CapHP.ReadOnly = true;
            this.CapHP.Width = 30;
            // 
            // CapAtk
            // 
            this.CapAtk.DataPropertyName = "Atk";
            this.CapAtk.HeaderText = "攻击";
            this.CapAtk.MinimumWidth = 6;
            this.CapAtk.Name = "CapAtk";
            this.CapAtk.ReadOnly = true;
            this.CapAtk.Width = 30;
            // 
            // CapDef
            // 
            this.CapDef.DataPropertyName = "Def";
            this.CapDef.HeaderText = "防御";
            this.CapDef.MinimumWidth = 6;
            this.CapDef.Name = "CapDef";
            this.CapDef.ReadOnly = true;
            this.CapDef.Width = 30;
            // 
            // CapSpA
            // 
            this.CapSpA.DataPropertyName = "SpA";
            this.CapSpA.HeaderText = "特攻";
            this.CapSpA.MinimumWidth = 6;
            this.CapSpA.Name = "CapSpA";
            this.CapSpA.ReadOnly = true;
            this.CapSpA.Width = 30;
            // 
            // CapSpD
            // 
            this.CapSpD.DataPropertyName = "SpD";
            this.CapSpD.HeaderText = "特防";
            this.CapSpD.MinimumWidth = 6;
            this.CapSpD.Name = "CapSpD";
            this.CapSpD.ReadOnly = true;
            this.CapSpD.Width = 30;
            // 
            // CapSpe
            // 
            this.CapSpe.DataPropertyName = "Spe";
            this.CapSpe.HeaderText = "速度";
            this.CapSpe.MinimumWidth = 6;
            this.CapSpe.Name = "CapSpe";
            this.CapSpe.ReadOnly = true;
            this.CapSpe.Width = 30;
            // 
            // HiddenPower
            // 
            this.HiddenPower.DataPropertyName = "HiddenPowerType";
            this.HiddenPower.HeaderText = "觉醒之力";
            this.HiddenPower.MinimumWidth = 6;
            this.HiddenPower.Name = "HiddenPower";
            this.HiddenPower.ReadOnly = true;
            this.HiddenPower.Width = 50;
            // 
            // HiddenPowerPower
            // 
            this.HiddenPowerPower.DataPropertyName = "HiddenPowerPower";
            this.HiddenPowerPower.HeaderText = "觉醒之力威力";
            this.HiddenPowerPower.MinimumWidth = 6;
            this.HiddenPowerPower.Name = "HiddenPowerPower";
            this.HiddenPowerPower.ReadOnly = true;
            this.HiddenPowerPower.Width = 50;
            // 
            // f50
            // 
            this.f50.DataPropertyName = "Female50";
            this.f50.HeaderText = "50% F";
            this.f50.MinimumWidth = 6;
            this.f50.Name = "f50";
            this.f50.ReadOnly = true;
            this.f50.Width = 50;
            // 
            // f125
            // 
            this.f125.DataPropertyName = "Female125";
            this.f125.HeaderText = "12.5%F";
            this.f125.MinimumWidth = 6;
            this.f125.Name = "f125";
            this.f125.ReadOnly = true;
            this.f125.Width = 50;
            // 
            // f25
            // 
            this.f25.DataPropertyName = "Female25";
            this.f25.HeaderText = "25% F";
            this.f25.MinimumWidth = 6;
            this.f25.Name = "f25";
            this.f25.ReadOnly = true;
            this.f25.Width = 50;
            // 
            // f75
            // 
            this.f75.DataPropertyName = "Female75";
            this.f75.HeaderText = "75% F";
            this.f75.MinimumWidth = 6;
            this.f75.Name = "f75";
            this.f75.ReadOnly = true;
            this.f75.Width = 50;
            // 
            // TimeFinder4th
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeFinder4th";
            this.Text = "GEN4 Time Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlatinumTime_FormClosing);
            this.Load += new System.EventHandler(this.TimeFinder4th_Load);
            this.contextMenuStripEggPid.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabPageEggIVs.ResumeLayout(false);
            this.tabPageEggIVs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEggIVValues)).EndInit();
            this.tabPageShinyEgg.ResumeLayout(false);
            this.tabPageShinyEgg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShinyResults)).EndInit();
            this.tabPageCapture.ResumeLayout(false);
            this.tabPageCapture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapValues)).EndInit();
            this.contextMenuStripCap.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem generateAdjacentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outputResultsToTXTToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
        private System.Windows.Forms.ToolStripMenuItem jumpToTargetFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsTargetFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEggPid;
        private System.Windows.Forms.ToolStripMenuItem generateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem outputResultsToTXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.TabPage tabPageEggIVs;
        private System.Windows.Forms.Label lblIVB;
        private System.Windows.Forms.Label lblIVA;
        private RNGReporter.GlassButton button1;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewEggIVValues;
        private RNGReporter.GlassButton buttonEggGenerate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private MaskedTextBox2 maskedTextBoxDefB;
        private MaskedTextBox2 maskedTextBoxAtkB;
        private MaskedTextBox2 maskedTextBoxSpeB;
        private MaskedTextBox2 maskedTextBoxSpDB;
        private MaskedTextBox2 maskedTextBoxSpAB;
        private MaskedTextBox2 maskedTextBoxHPB;
        private MaskedTextBox2 maskedTextBoxDefA;
        private MaskedTextBox2 maskedTextBoxAtkA;
        private MaskedTextBox2 maskedTextBoxSpeA;
        private MaskedTextBox2 maskedTextBoxSpDA;
        private MaskedTextBox2 maskedTextBoxSpAA;
        private MaskedTextBox2 maskedTextBoxHPA;
        private MaskedTextBox2 maskedTextBoxMaxOffset;
        private MaskedTextBox2 maskedTextBoxMinOffset;
        private MaskedTextBox2 maskedTextBoxYear;
        private MaskedTextBox2 maskedTextBoxMinDelay;
        private MaskedTextBox2 maskedTextBoxMaxDelay;
        private System.Windows.Forms.TabPage tabPageShinyEgg;
        private System.Windows.Forms.Label labelDPPtWarning;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewShinyResults;
        private RNGReporter.GlassButton buttonShinyClearAbility;
        private RNGReporter.GlassComboBox comboBoxShinyAbility;
        private RNGReporter.GlassButton buttonShinyGenerate;
        private System.Windows.Forms.Label labelShinySecretID;
        private System.Windows.Forms.Label labelShinyNature;
        private System.Windows.Forms.Label labelShinyTrainerID;
        private RNGReporter.GlassButton buttonShinyClearNature;
        private System.Windows.Forms.Label labelShinyAbility;
        private RNGReporter.GlassComboBox comboBoxShinyNature;
        private System.Windows.Forms.Label labelShinyDelay;
        private System.Windows.Forms.Label labelShinyYear;
        private MaskedTextBox2 maskedTextBoxShinySecretID;
        private MaskedTextBox2 maskedTextBoxShinyID;
        private MaskedTextBox2 maskedTextBoxShinyMaxDelay;
        private MaskedTextBox2 maskedTextBoxShinyMinDelay;
        private MaskedTextBox2 maskedTextBoxShinyYear;
        private System.Windows.Forms.TabPage tabPageCapture;
        private RNGReporter.GlassButton buttonAnyNature;
        private System.Windows.Forms.Label lblID;
        private RNGReporter.GlassComboBox comboBoxAbility;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBoxShinyOnly;
        private MaskedTextBox2 maskedTextBoxID;
        private MaskedTextBox2 maskedTextBoxSID;
        private System.Windows.Forms.Label label21;
        private CheckBoxComboBox comboBoxNature;
        private RNGReporter.DoubleBufferedDataGridView dataGridViewCapValues;
        private System.Windows.Forms.TabControl tabControl;
        private MaskedTextBox2 maskedTextBoxCapMinOffset;
        private MaskedTextBox2 maskedTextBoxCapMaxDelay;
        private MaskedTextBox2 maskedTextBoxCapMinDelay;
        private MaskedTextBox2 maskedTextBoxCapYear;
        private MaskedTextBox2 maskedTextBoxCapMaxOffset;
        private System.Windows.Forms.Label labelCapMinMaxFrame;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private RNGReporter.GlassButton buttonCapGenerate;
        private System.Windows.Forms.CheckBox checkBoxShinyShinyOnly;
        private RNGReporter.GlassComboBox comboBoxShinyGender;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCap;
        private System.Windows.Forms.ToolStripMenuItem copySeedToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem generateTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem outputCapResultsToTXTToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxIntlParents;
        private System.Windows.Forms.RadioButton radioButtonHGSS;
        private System.Windows.Forms.RadioButton radioButtonDPPt;
        private MaskedTextBox2 maskedTextBoxMaxTaps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxNoHappiness;
        private System.Windows.Forms.Label labelHappinessWarning;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private RNGReporter.GlassComboBox comboBoxCapGender;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox checkBoxShowInheritance;
        private System.Windows.Forms.RadioButton radioButtonEggHGSS;
        private System.Windows.Forms.RadioButton radioButtonEggDPPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Def;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flips;
        private System.Windows.Forms.ToolStripMenuItem returnToResultsToolStripMenuItem;
        private RNGReporter.GlassButton buttonAnySlot;
        private System.Windows.Forms.Label label54;
        private RNGReporter.GlassComboBox comboBoxEncounterType;
        private CheckBoxComboBox comboBoxEncounterSlot;
        private System.Windows.Forms.Label label52;
        private RNGReporter.GlassComboBox comboBoxMethod;
        private System.Windows.Forms.Label label30;
        private RNGReporter.GlassComboBox comboBoxCapGenderRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipDataGrid;
        private System.Windows.Forms.ToolTip toolTipGenderRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EggSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn EggPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shinyShinyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyNature;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFemale50;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFemale25;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFemale125;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFemale75;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFlipSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyTaps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyFlips;
        private IVFilters ivFiltersEgg;
        private IVFilters ivFiltersCapture;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapSeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncounterMod;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenPowerPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn f50;
        private System.Windows.Forms.DataGridViewTextBoxColumn f125;
        private System.Windows.Forms.DataGridViewTextBoxColumn f25;
        private System.Windows.Forms.DataGridViewTextBoxColumn f75;
    }
}
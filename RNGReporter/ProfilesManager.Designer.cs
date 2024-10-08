﻿using RNGReporter.Controls;

namespace RNGReporter
{
    partial class ProfileManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFileDialogXml = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.buttonDuplicate = new RNGReporter.GlassButton();
            this.buttonEdit = new RNGReporter.GlassButton();
            this.buttonDelete = new RNGReporter.GlassButton();
            this.buttonNew = new RNGReporter.GlassButton();
            this.dataGridViewValues = new RNGReporter.DoubleBufferedDataGridView();
            this.profileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileMAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileVCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileTimer0Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileTimer0Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileGxStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileVFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileKeypresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkipLR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.profileSoftReset = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.profilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialogXml
            // 
            this.saveFileDialogXml.DefaultExt = "xml";
            this.saveFileDialogXml.FileName = "profiles";
            this.saveFileDialogXml.Title = "保存存档信息...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(762, 25);
            this.menuStrip1.TabIndex = 151;
            this.menuStrip1.Text = "菜单栏";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "新建";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.DefaultExt = "xml";
            this.openFileDialogXml.FileName = "profiles";
            this.openFileDialogXml.Filter = "XML Profiles|*.xml|All files|*.*";
            this.openFileDialogXml.Title = "打开存档信息...";
            // 
            // buttonDuplicate
            // 
            this.buttonDuplicate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDuplicate.ForeColor = System.Drawing.Color.Black;
            this.buttonDuplicate.Location = new System.Drawing.Point(399, 25);
            this.buttonDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDuplicate.Name = "buttonDuplicate";
            this.buttonDuplicate.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonDuplicate.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonDuplicate.Size = new System.Drawing.Size(123, 22);
            this.buttonDuplicate.TabIndex = 6;
            this.buttonDuplicate.Text = "复制";
            this.buttonDuplicate.Click += new System.EventHandler(this.buttonDuplicate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(141, 25);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonEdit.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonEdit.Size = new System.Drawing.Size(123, 22);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "编辑";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(270, 25);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonDelete.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Size = new System.Drawing.Size(123, 22);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonNew.ForeColor = System.Drawing.Color.Black;
            this.buttonNew.Location = new System.Drawing.Point(12, 25);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.OuterBorderColor = System.Drawing.Color.Transparent;
            this.buttonNew.ShineColor = System.Drawing.SystemColors.Window;
            this.buttonNew.Size = new System.Drawing.Size(123, 22);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "新建";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToOrderColumns = true;
            this.dataGridViewValues.AllowUserToResizeRows = false;
            this.dataGridViewValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewValues.AutoGenerateColumns = false;
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
            this.profileName,
            this.profileID,
            this.profileSID,
            this.profileMAC,
            this.profileVersion,
            this.DSType,
            this.profileVCount,
            this.profileTimer0Min,
            this.profileTimer0Max,
            this.profileGxStat,
            this.profileVFrame,
            this.profileKeypresses,
            this.SkipLR,
            this.profileSoftReset});
            this.dataGridViewValues.DataSource = this.profilesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValues.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewValues.Location = new System.Drawing.Point(13, 52);
            this.dataGridViewValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewValues.MultiSelect = false;
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewValues.RowHeadersVisible = false;
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.RowTemplate.Height = 20;
            this.dataGridViewValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValues.ShowEditingIcon = false;
            this.dataGridViewValues.Size = new System.Drawing.Size(737, 414);
            this.dataGridViewValues.TabIndex = 33;
            this.dataGridViewValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewValues_MouseDown);
            // 
            // profileName
            // 
            this.profileName.DataPropertyName = "Name";
            this.profileName.HeaderText = "名称";
            this.profileName.MinimumWidth = 6;
            this.profileName.Name = "profileName";
            this.profileName.ReadOnly = true;
            this.profileName.Width = 120;
            // 
            // profileID
            // 
            this.profileID.DataPropertyName = "ID";
            this.profileID.HeaderText = "ID";
            this.profileID.MinimumWidth = 6;
            this.profileID.Name = "profileID";
            this.profileID.ReadOnly = true;
            this.profileID.Width = 55;
            // 
            // profileSID
            // 
            this.profileSID.DataPropertyName = "SID";
            this.profileSID.HeaderText = "SID";
            this.profileSID.MinimumWidth = 6;
            this.profileSID.Name = "profileSID";
            this.profileSID.ReadOnly = true;
            this.profileSID.Width = 60;
            // 
            // profileMAC
            // 
            this.profileMAC.DataPropertyName = "MAC_Address";
            dataGridViewCellStyle2.Format = "X";
            dataGridViewCellStyle2.NullValue = null;
            this.profileMAC.DefaultCellStyle = dataGridViewCellStyle2;
            this.profileMAC.HeaderText = "MAC地址";
            this.profileMAC.MinimumWidth = 6;
            this.profileMAC.Name = "profileMAC";
            this.profileMAC.ReadOnly = true;
            this.profileMAC.Width = 120;
            // 
            // profileVersion
            // 
            this.profileVersion.DataPropertyName = "VersionStr";
            this.profileVersion.HeaderText = "游戏版本";
            this.profileVersion.MinimumWidth = 6;
            this.profileVersion.Name = "profileVersion";
            this.profileVersion.ReadOnly = true;
            this.profileVersion.Width = 120;
            // 
            // DSType
            // 
            this.DSType.DataPropertyName = "DSType";
            this.DSType.HeaderText = "DS机型";
            this.DSType.MinimumWidth = 6;
            this.DSType.Name = "DSType";
            this.DSType.ReadOnly = true;
            this.DSType.Width = 125;
            // 
            // profileVCount
            // 
            this.profileVCount.DataPropertyName = "VCount";
            dataGridViewCellStyle3.Format = "X";
            this.profileVCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.profileVCount.HeaderText = "VCount";
            this.profileVCount.MinimumWidth = 6;
            this.profileVCount.Name = "profileVCount";
            this.profileVCount.ReadOnly = true;
            this.profileVCount.Width = 60;
            // 
            // profileTimer0Min
            // 
            this.profileTimer0Min.DataPropertyName = "Timer0Min";
            dataGridViewCellStyle4.Format = "X";
            this.profileTimer0Min.DefaultCellStyle = dataGridViewCellStyle4;
            this.profileTimer0Min.HeaderText = "最小Timer0";
            this.profileTimer0Min.MinimumWidth = 6;
            this.profileTimer0Min.Name = "profileTimer0Min";
            this.profileTimer0Min.ReadOnly = true;
            this.profileTimer0Min.Width = 70;
            // 
            // profileTimer0Max
            // 
            this.profileTimer0Max.DataPropertyName = "Timer0Max";
            dataGridViewCellStyle5.Format = "X";
            this.profileTimer0Max.DefaultCellStyle = dataGridViewCellStyle5;
            this.profileTimer0Max.HeaderText = "最大Timer0";
            this.profileTimer0Max.MinimumWidth = 6;
            this.profileTimer0Max.Name = "profileTimer0Max";
            this.profileTimer0Max.ReadOnly = true;
            this.profileTimer0Max.Width = 60;
            // 
            // profileGxStat
            // 
            this.profileGxStat.DataPropertyName = "GxStat";
            dataGridViewCellStyle6.Format = "X";
            this.profileGxStat.DefaultCellStyle = dataGridViewCellStyle6;
            this.profileGxStat.HeaderText = "GxStat";
            this.profileGxStat.MinimumWidth = 6;
            this.profileGxStat.Name = "profileGxStat";
            this.profileGxStat.ReadOnly = true;
            this.profileGxStat.Width = 55;
            // 
            // profileVFrame
            // 
            this.profileVFrame.DataPropertyName = "VFrame";
            dataGridViewCellStyle7.Format = "X";
            this.profileVFrame.DefaultCellStyle = dataGridViewCellStyle7;
            this.profileVFrame.HeaderText = "VFrame";
            this.profileVFrame.MinimumWidth = 6;
            this.profileVFrame.Name = "profileVFrame";
            this.profileVFrame.ReadOnly = true;
            this.profileVFrame.Width = 70;
            // 
            // profileKeypresses
            // 
            this.profileKeypresses.DataPropertyName = "KeyString";
            this.profileKeypresses.HeaderText = "按键";
            this.profileKeypresses.MinimumWidth = 6;
            this.profileKeypresses.Name = "profileKeypresses";
            this.profileKeypresses.ReadOnly = true;
            this.profileKeypresses.Width = 125;
            // 
            // SkipLR
            // 
            this.SkipLR.DataPropertyName = "SkipLR";
            this.SkipLR.HeaderText = "跳过L\\R按键";
            this.SkipLR.MinimumWidth = 6;
            this.SkipLR.Name = "SkipLR";
            this.SkipLR.ReadOnly = true;
            this.SkipLR.Width = 125;
            // 
            // profileSoftReset
            // 
            this.profileSoftReset.DataPropertyName = "SoftReset";
            this.profileSoftReset.HeaderText = "软复位";
            this.profileSoftReset.MinimumWidth = 6;
            this.profileSoftReset.Name = "profileSoftReset";
            this.profileSoftReset.ReadOnly = true;
            this.profileSoftReset.Width = 125;
            // 
            // profilesBindingSource
            // 
            this.profilesBindingSource.DataSource = typeof(RNGReporter.Objects.Profiles);
            // 
            // ProfileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 487);
            this.Controls.Add(this.buttonDuplicate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridViewValues);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(642, 485);
            this.Name = "ProfileManager";
            this.Text = "存档信息管理（GEN5）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfilesProfileManager_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RNGReporter.DoubleBufferedDataGridView dataGridViewValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXml;
        private GlassButton buttonNew;
        private GlassButton buttonEdit;
        private GlassButton buttonDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private GlassButton buttonDuplicate;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.BindingSource profilesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileMAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSType;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileVCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileTimer0Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileTimer0Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileGxStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileVFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileKeypresses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SkipLR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn profileSoftReset;
    }
}
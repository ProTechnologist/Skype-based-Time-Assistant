namespace TimeAssistant
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.btnGenerateDaySummary = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDayEndSummaryToClipboard = new System.Windows.Forms.CheckBox();
            this.btnCalcBreaks = new System.Windows.Forms.Button();
            this.chkIncludeMeetings = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbTT = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lnkbtnUpdateSkypeID = new System.Windows.Forms.LinkLabel();
            this.lblSecretCommand = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.chkEnableReminder = new System.Windows.Forms.CheckBox();
            this.cbMyAccount = new System.Windows.Forms.CheckBox();
            this.chkRemoveDuplicatedUpdates = new System.Windows.Forms.CheckBox();
            this.txtUpdateFormat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkConvertToPastTense = new System.Windows.Forms.CheckBox();
            this.cbLoadOptions = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.prepareUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBackToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skype Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Visible = false;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Room:";
            // 
            // cbRooms
            // 
            this.cbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRooms.FormattingEnabled = true;
            this.cbRooms.Location = new System.Drawing.Point(214, 55);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(261, 24);
            this.cbRooms.TabIndex = 3;
            // 
            // btnGenerateDaySummary
            // 
            this.btnGenerateDaySummary.Location = new System.Drawing.Point(403, 365);
            this.btnGenerateDaySummary.Name = "btnGenerateDaySummary";
            this.btnGenerateDaySummary.Size = new System.Drawing.Size(187, 26);
            this.btnGenerateDaySummary.TabIndex = 4;
            this.btnGenerateDaySummary.Text = "&Generate Day End Summary";
            this.btnGenerateDaySummary.UseVisualStyleBackColor = true;
            this.btnGenerateDaySummary.Click += new System.EventHandler(this.btnGenerateDaySummary_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.BackColor = System.Drawing.Color.White;
            this.txtUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdate.ForeColor = System.Drawing.Color.White;
            this.txtUpdate.Location = new System.Drawing.Point(14, 397);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ReadOnly = true;
            this.txtUpdate.Size = new System.Drawing.Size(576, 197);
            this.txtUpdate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(203, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Assistant";
            // 
            // chkDayEndSummaryToClipboard
            // 
            this.chkDayEndSummaryToClipboard.AutoSize = true;
            this.chkDayEndSummaryToClipboard.BackColor = System.Drawing.SystemColors.Control;
            this.chkDayEndSummaryToClipboard.ForeColor = System.Drawing.Color.Black;
            this.chkDayEndSummaryToClipboard.Location = new System.Drawing.Point(214, 226);
            this.chkDayEndSummaryToClipboard.Name = "chkDayEndSummaryToClipboard";
            this.chkDayEndSummaryToClipboard.Size = new System.Drawing.Size(250, 20);
            this.chkDayEndSummaryToClipboard.TabIndex = 10;
            this.chkDayEndSummaryToClipboard.Text = "Copy Day End Summary to Clipboard";
            this.chkDayEndSummaryToClipboard.UseVisualStyleBackColor = false;
            this.chkDayEndSummaryToClipboard.CheckedChanged += new System.EventHandler(this.chkDayEndSummaryToClipboard_CheckedChanged);
            // 
            // btnCalcBreaks
            // 
            this.btnCalcBreaks.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcBreaks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcBreaks.Location = new System.Drawing.Point(294, 365);
            this.btnCalcBreaks.Name = "btnCalcBreaks";
            this.btnCalcBreaks.Size = new System.Drawing.Size(103, 26);
            this.btnCalcBreaks.TabIndex = 11;
            this.btnCalcBreaks.Text = "Calc. &Breaks";
            this.btnCalcBreaks.UseVisualStyleBackColor = true;
            this.btnCalcBreaks.Click += new System.EventHandler(this.btnCalcBreaks_Click);
            // 
            // chkIncludeMeetings
            // 
            this.chkIncludeMeetings.AutoSize = true;
            this.chkIncludeMeetings.BackColor = System.Drawing.SystemColors.Control;
            this.chkIncludeMeetings.ForeColor = System.Drawing.Color.Black;
            this.chkIncludeMeetings.Location = new System.Drawing.Point(214, 252);
            this.chkIncludeMeetings.Name = "chkIncludeMeetings";
            this.chkIncludeMeetings.Size = new System.Drawing.Size(320, 20);
            this.chkIncludeMeetings.TabIndex = 13;
            this.chkIncludeMeetings.Text = "Include Meeting Breaks during calculating Breaks";
            this.chkIncludeMeetings.UseVisualStyleBackColor = false;
            this.chkIncludeMeetings.CheckedChanged += new System.EventHandler(this.chkIncludeMeetings_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.cbTT);
            this.groupBox3.Controls.Add(this.cbMinutes);
            this.groupBox3.Controls.Add(this.cbHours);
            this.groupBox3.Controls.Add(this.lblUsername);
            this.groupBox3.Controls.Add(this.lnkbtnUpdateSkypeID);
            this.groupBox3.Controls.Add(this.lblSecretCommand);
            this.groupBox3.Controls.Add(this.txtSecret);
            this.groupBox3.Controls.Add(this.chkEnableReminder);
            this.groupBox3.Controls.Add(this.cbMyAccount);
            this.groupBox3.Controls.Add(this.chkRemoveDuplicatedUpdates);
            this.groupBox3.Controls.Add(this.txtUpdateFormat);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.chkConvertToPastTense);
            this.groupBox3.Controls.Add(this.chkIncludeMeetings);
            this.groupBox3.Controls.Add(this.chkDayEndSummaryToClipboard);
            this.groupBox3.Controls.Add(this.cbLoadOptions);
            this.groupBox3.Controls.Add(this.btnSaveSettings);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbRooms);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 311);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TimeAssistant.Properties.Resources.up;
            this.pictureBox2.Location = new System.Drawing.Point(551, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "up";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cbTT
            // 
            this.cbTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTT.FormattingEnabled = true;
            this.cbTT.Location = new System.Drawing.Point(322, 144);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(48, 24);
            this.cbTT.TabIndex = 31;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(268, 144);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(48, 24);
            this.cbMinutes.TabIndex = 30;
            // 
            // cbHours
            // 
            this.cbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Location = new System.Drawing.Point(214, 144);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(48, 24);
            this.cbHours.TabIndex = 29;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(215, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 16);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Unavailable";
            // 
            // lnkbtnUpdateSkypeID
            // 
            this.lnkbtnUpdateSkypeID.AutoSize = true;
            this.lnkbtnUpdateSkypeID.Location = new System.Drawing.Point(360, 30);
            this.lnkbtnUpdateSkypeID.Name = "lnkbtnUpdateSkypeID";
            this.lnkbtnUpdateSkypeID.Size = new System.Drawing.Size(119, 16);
            this.lnkbtnUpdateSkypeID.TabIndex = 27;
            this.lnkbtnUpdateSkypeID.TabStop = true;
            this.lnkbtnUpdateSkypeID.Text = "Update Username";
            this.lnkbtnUpdateSkypeID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbtnUpdateSkypeID_LinkClicked);
            // 
            // lblSecretCommand
            // 
            this.lblSecretCommand.AutoSize = true;
            this.lblSecretCommand.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretCommand.Location = new System.Drawing.Point(6, 251);
            this.lblSecretCommand.Name = "lblSecretCommand";
            this.lblSecretCommand.Size = new System.Drawing.Size(120, 35);
            this.lblSecretCommand.TabIndex = 26;
            this.lblSecretCommand.Text = "Secret Command:";
            this.lblSecretCommand.Visible = false;
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(6, 281);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(123, 22);
            this.txtSecret.TabIndex = 1;
            this.txtSecret.Visible = false;
            this.txtSecret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecret_KeyDown);
            // 
            // chkEnableReminder
            // 
            this.chkEnableReminder.AutoSize = true;
            this.chkEnableReminder.Location = new System.Drawing.Point(214, 174);
            this.chkEnableReminder.Name = "chkEnableReminder";
            this.chkEnableReminder.Size = new System.Drawing.Size(222, 20);
            this.chkEnableReminder.TabIndex = 25;
            this.chkEnableReminder.Text = "Enable Hourly Update Reminder";
            this.chkEnableReminder.UseVisualStyleBackColor = true;
            // 
            // cbMyAccount
            // 
            this.cbMyAccount.AutoSize = true;
            this.cbMyAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbMyAccount.Checked = true;
            this.cbMyAccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMyAccount.ForeColor = System.Drawing.Color.Black;
            this.cbMyAccount.Location = new System.Drawing.Point(370, 28);
            this.cbMyAccount.Name = "cbMyAccount";
            this.cbMyAccount.Size = new System.Drawing.Size(103, 20);
            this.cbMyAccount.TabIndex = 24;
            this.cbMyAccount.Text = "My Account?";
            this.cbMyAccount.UseVisualStyleBackColor = false;
            this.cbMyAccount.Visible = false;
            // 
            // chkRemoveDuplicatedUpdates
            // 
            this.chkRemoveDuplicatedUpdates.AutoSize = true;
            this.chkRemoveDuplicatedUpdates.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemoveDuplicatedUpdates.ForeColor = System.Drawing.Color.Black;
            this.chkRemoveDuplicatedUpdates.Location = new System.Drawing.Point(214, 278);
            this.chkRemoveDuplicatedUpdates.Name = "chkRemoveDuplicatedUpdates";
            this.chkRemoveDuplicatedUpdates.Size = new System.Drawing.Size(202, 20);
            this.chkRemoveDuplicatedUpdates.TabIndex = 23;
            this.chkRemoveDuplicatedUpdates.Text = "Remove Duplicated Updates";
            this.chkRemoveDuplicatedUpdates.UseVisualStyleBackColor = false;
            this.chkRemoveDuplicatedUpdates.CheckedChanged += new System.EventHandler(this.chkRemoveDuplicatedUpdates_CheckedChanged);
            // 
            // txtUpdateFormat
            // 
            this.txtUpdateFormat.Location = new System.Drawing.Point(214, 116);
            this.txtUpdateFormat.Name = "txtUpdateFormat";
            this.txtUpdateFormat.Size = new System.Drawing.Size(261, 22);
            this.txtUpdateFormat.TabIndex = 22;
            this.txtUpdateFormat.Text = "(o) update:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Update Format:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Shift Start Time:";
            // 
            // chkConvertToPastTense
            // 
            this.chkConvertToPastTense.AutoSize = true;
            this.chkConvertToPastTense.BackColor = System.Drawing.SystemColors.Control;
            this.chkConvertToPastTense.ForeColor = System.Drawing.Color.Black;
            this.chkConvertToPastTense.Location = new System.Drawing.Point(214, 200);
            this.chkConvertToPastTense.Name = "chkConvertToPastTense";
            this.chkConvertToPastTense.Size = new System.Drawing.Size(295, 20);
            this.chkConvertToPastTense.TabIndex = 17;
            this.chkConvertToPastTense.Text = "Convert day summary updates to Past Tense";
            this.chkConvertToPastTense.UseVisualStyleBackColor = false;
            this.chkConvertToPastTense.CheckedChanged += new System.EventHandler(this.chkConvertToPastTense_CheckedChanged);
            // 
            // cbLoadOptions
            // 
            this.cbLoadOptions.BackColor = System.Drawing.Color.Gray;
            this.cbLoadOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoadOptions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLoadOptions.FormattingEnabled = true;
            this.cbLoadOptions.Items.AddRange(new object[] {
            "Calculate Breaks on load",
            "Prepare Day End Summary on Load",
            "Hide to System Tray"});
            this.cbLoadOptions.Location = new System.Drawing.Point(214, 85);
            this.cbLoadOptions.Name = "cbLoadOptions";
            this.cbLoadOptions.Size = new System.Drawing.Size(261, 24);
            this.cbLoadOptions.TabIndex = 16;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(467, 279);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(103, 26);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "&Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Default Start Action:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "\"Back\" copied to Clipboard";
            this.notifyIcon1.BalloonTipTitle = "Clipboard Updated";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Time Assistant";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.prepareUpdateToolStripMenuItem,
            this.copyBackToClipboardToolStripMenuItem,
            this.showToolStripMenuItem,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 136);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem1.Text = "Calculate Breaks";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem2.Text = "Prepare Day Summary";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // prepareUpdateToolStripMenuItem
            // 
            this.prepareUpdateToolStripMenuItem.Name = "prepareUpdateToolStripMenuItem";
            this.prepareUpdateToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.prepareUpdateToolStripMenuItem.Text = "Write Update";
            this.prepareUpdateToolStripMenuItem.Click += new System.EventHandler(this.prepareUpdateToolStripMenuItem_Click);
            // 
            // copyBackToClipboardToolStripMenuItem
            // 
            this.copyBackToClipboardToolStripMenuItem.Name = "copyBackToClipboardToolStripMenuItem";
            this.copyBackToClipboardToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyBackToClipboardToolStripMenuItem.Text = "Copy Back to clipboard";
            this.copyBackToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyBackToClipboardToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 16);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "User Configurations";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 45000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TimeAssistant.Properties.Resources.close3;
            this.pictureBox1.Location = new System.Drawing.Point(559, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(503, 597);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "Version:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(14, 365);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(126, 26);
            this.btnCopyToClipboard.TabIndex = 18;
            this.btnCopyToClipboard.Text = "&Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 10000000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 2;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "About Hourly Reminder";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(15, 595);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 15);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Have a suggestion or comment?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 619);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalcBreaks);
            this.Controls.Add(this.btnGenerateDaySummary);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.Button btnGenerateDaySummary;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDayEndSummaryToClipboard;
        private System.Windows.Forms.Button btnCalcBreaks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIncludeMeetings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoadOptions;
        private System.Windows.Forms.CheckBox chkConvertToPastTense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkRemoveDuplicatedUpdates;
        private System.Windows.Forms.CheckBox cbMyAccount;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem prepareUpdateToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkEnableReminder;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBackToClipboardToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label lblSecretCommand;
        private System.Windows.Forms.LinkLabel lnkbtnUpdateSkypeID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbTT;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbHours;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Net;

namespace TimeAssistant
{
    public partial class frmMain : ThemedBaseForm
    {
        public bool WasUpdatePrepared = false;

        
        string MySkypeUsername;
        bool IsPathValid = false;
        string secretCode = string.Empty;
        public frmMain()
        {
            InitializeComponent();
            base.ApplyTheme();
        }

        protected override void OnShown(EventArgs e)
        {
            if (string.IsNullOrEmpty(App.Default.Username))
            {
                (new frmSkypeInfo()).ShowDialog();
            }
        }

        #region Skype related functions
        /// <summary>
        /// Returns the relative file path of Skype Database
        /// </summary>
        /// <param name="Username">skype username</param>
        /// <returns>Absolute Database Path</returns>
        string GetDBFile(string Username)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
            if (cbMyAccount.Checked)
            {
                path += string.Format(@"\Skype\{0}\main.db",Username);
            }
            else
            {
                path += string.Format(@"\Skype\{0}\main.db", MySkypeUsername);
            }
            // for testing only ...
            //path = @"D:\main.db";

            if ( !cbMyAccount.Checked || File.Exists(path))
            {
                IsPathValid = true;
                return path;
            }
            IsPathValid = false;
            return string.Empty;
        }

        /// <summary>
        /// Returns the Skpe Chat Room List 
        /// </summary>
        /// <param name="Filepath">Path of skype Datbase (GetDBFile function generates absolute path )</param>
        /// <returns>List of Skype Rooms</returns>
        List<Room> FetchChatRooms(string Filepath)
        {
            List<Room> rooms = new List<Room>();
            string query = "select id, meta_topic from Conversations where meta_topic not like '' order by meta_topic";

            DataTable roomsTable = DBHelper.GetDataTable(Filepath, query);

            foreach (DataRow row in roomsTable.Rows)
            {
                rooms.Add(new Room()
                {
                    RoomID = int.Parse(row[0].ToString()),
                    RoomName = WebUtility.HtmlDecode(row[1].ToString())
                });
            }
            return rooms;
        }

        /// <summary>
        /// Returns Accepted Update format
        /// </summary>
        /// <returns>Update Format</returns>
        string GetUpdateFormat()
        {
            // not calling trim on this because of space at the end
            return txtUpdateFormat.Text.Replace("(o)", "<ss type=%time%>(o)</ss>") + "%"; 
        }

//        void GetLastUpdateTime()
//        {
//            Room r = cbRooms.SelectedItem as Room;

//            string path = GetDBFile(GetUsername());

//            string query = string.Format(@"select body_xml, strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') from messages where convo_id = {1}
//                                                   and author = '{0}' and body_xml like '{3}'
//                                                   and strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') > '{2}'
//                                                   order by id",
//                                           GetUsername(), r.RoomID, GetTimeString(), GetUpdateFormat());

//            DataTable table = DBHelper.GetDataTable(path, query);
//            int count = table.Rows.Count;
//        }

        /// <summary>
        /// Prepare Update based on defined formats
        /// </summary>
        /// <returns>Returns the list of update messages</returns>
        List<string> PrepareUpdate()
        {
            DateTime? d = GetLastUpdateTime();

            int UpdateCharCount = 0;
            try
            {
                string msg;
                List<string> msgs = new List<string>();
                if (IsPathValid)
                {
                    Room r = cbRooms.SelectedItem as Room;

                    string path = GetDBFile(GetUsername());

                    string query = string.Format(@"select body_xml from messages where convo_id = {1}
                                                   and author = '{0}' and body_xml like '{3}'
                                                   and strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') > '{2}'
                                                   order by id",
                                                   GetUsername(), r.RoomID, GetTimeString(), GetUpdateFormat());

                    DataTable table = DBHelper.GetDataTable(path, query);

                    foreach (DataRow row in table.Rows)
                    {
                        #region count characters to count to trim from the start of skype update

                        // clock smiley is of 24 chars - 3 characters of user input so: 21 characters to trim

                        UpdateCharCount = txtUpdateFormat.Text.Length + 21; // 21 is for clock symbol char-count

                        #endregion

                        msg = row[0].ToString().Substring(UpdateCharCount).Trim();

                        if (chkConvertToPastTense.Checked)
                        {
                            // my dictionary {all possible starting words for updates that I could think of ... }
                            //msg = char.ToLower(msg[0]) + msg.Substring(1);
                            msg = msg.Substring(0, msg.IndexOf(" "))
                                     .ToLower()
                                     .Replace("working", "worked")
                                     .Replace("testing", "tested")
                                     .Replace("rectifying", "rectified")
                                     .Replace("reviewing", "reviewed")
                                     .Replace("studying", "studied")
                                     .Replace("reading", "read")
                                     .Replace("writing", "wrote")
                                     .Replace("implementing", "implemented")
                                     .Replace("converting", "converted")
                                     .Replace("prototyping", "prototyped")
                                     .Replace("designing", "designed")
                                     .Replace("converting", "converted")
                                     .Replace("selecting", "selected")
                                     .Replace("collaborating", "collaborated")
                                     .Replace("Discussing", "discussed")
                                     .Replace("styling", "styled")
                                     .Replace("collaborating", "collaborated")
                                     .Replace("uploading", "uploaded")
                                     .Replace("downloading", "downloaded")
                                     .Replace("exploring", "explored")
                                     .Replace("start", "started")
                                     .Replace("exploring", "explored")
                                     .Replace("presenting", "presented")
                                     .Replace("deliver", "delivered")
                                     .Replace("preparing", "prepared")
                                     .Replace("presenting", "presented")
                                     .Replace("waiting", "waited")
                                     .Replace("communicating", "communicated")
                                     .Replace("retrieving", "retrieved")
                                     .Replace("hosting", "hosted")
                                     .Replace("publishing", "published")
                                     .Replace("making", "made")
                                     .Replace("performing", "performed")
                                     .Replace("hosting", "hosted")
                                     .Replace("hosting", "hosted")
                                     +
                                     msg.Substring(msg.IndexOf(" "));

                        }
                        // capitalizing first character of first word.
                        msgs.Add(WebUtility.HtmlDecode(char.ToUpper(msg[0]) + msg.Substring(1)));
                    }
                }

                return msgs;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }
        /// <summary>
        /// Function not in use (but plans to open Update window with last update - leaving it for fun time)
        /// </summary>
        /// <returns>Last Skype Update</returns>
        public string GetLastUpdate()
        {
            Room r = cbRooms.SelectedItem as Room;
            string query = string.Format(@"select body_xml from messages where convo_id = {1}
                                           and author = '{0}' and body_xml like '{3}'
                                           and strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') > '{2}'
                                           order by id desc limit 1",
                                           GetUsername(), r.RoomID, GetTimeString(), GetUpdateFormat());

            DataTable table = DBHelper.GetDataTable(GetDBFile(GetUsername()), query);
            if (table == null || table.Rows.Count == 0)
            {
                return string.Empty;
            }

            return WebUtility.HtmlDecode(table.Rows[0][0].ToString().Substring(txtUpdateFormat.Text.Length + 21));
        }

        public DateTime? GetLastUpdateTime()
        {
            Room r = cbRooms.SelectedItem as Room;
            string query = string.Format(@"select strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') as t from messages where convo_id = {1}
                                           and author = '{0}' and body_xml like '{3}'
                                           and strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') > '{2}'
                                           order by id desc limit 1",
                                           GetUsername(), r.RoomID, GetTimeString(), GetUpdateFormat());

            DataTable table = DBHelper.GetDataTable(GetDBFile(GetUsername()), query);
            if (table == null || table.Rows.Count == 0)
            {
                return null;
            }

            DateTime d = DateTime.Parse(table.Rows[0][0].ToString());
            return d;
        }

        /// <summary>
        /// Get Time String
        /// </summary>
        /// <returns>Time String</returns>
        string GetTimeString()
        {
            string shiftStartTime = cbHours.Text + ":" + cbMinutes.Text + " " + cbTT.Text;

            DateTime currentDateTime = DateTime.Parse(shiftStartTime);

            if (DateTime.Now.Hour < 12)
            {
                currentDateTime = currentDateTime.AddDays(-1);
            }

            return currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            #region old implementation
            /*
            string format = string.Format("yyyy-MM-dd {0}:00", cbShiftStart.Text);
            if (DateTime.Now.Hour < 3)
            {
                return DateTime.Now.AddDays(-1).ToString(format);
            }
            else
            {
                return DateTime.Now.ToString(format);
            }
            */
            #endregion
        }

        /// <summary>
        /// Returns Username from UI component
        /// </summary>
        /// <returns>Skype Username</returns>
        string GetUsername()
        {
            return txtUsername.Text.ToLower();
        }

        /// <summary>
        /// Computes and returns breaks
        /// </summary>
        /// <param name="includeMeetings">Whether to include breaks during break calculations</param>
        /// <returns>List of breaks</returns>
        List<BRB> FetchBreaks(bool includeMeetings)
        {
            List<BRB> brbs = new List<BRB>();

            Room r = cbRooms.SelectedItem as Room;
            string path = GetDBFile(GetUsername());
            string query = string.Empty;
            string includeMeetingClause = string.Empty;
            DateTime tempTimeStamp = new DateTime();

            DateTime FromTime, ToTime;


            int minutes = 0;

            if (chkIncludeMeetings.Checked)
            {
                includeMeetingClause = " and body_xml not like '%meeting%' ";
            }

            query = string.Format(@"select strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime'),
                                    body_xml from messages where convo_id = {1}
                                    and author = '{0}'
                                    and (body_xml like 'brb%' or body_xml like 'back%') {3}
                                    and strftime('%Y-%m-%d %H:%M:%S', timestamp,'unixepoch','localtime') > '{2}'",
                                        GetUsername(), r.RoomID, GetTimeString(), includeMeetingClause);

            DataTable table = DBHelper.GetDataTable(path, query);

            foreach (DataRow row in table.Rows)
            {
                if (row[1].ToString().ToLower().Contains("brb"))
                {
                    tempTimeStamp = DateTime.Parse(row[0].ToString());

                    try
                    {
                        if (table.Rows.IndexOf(row) == table.Rows.Count - 1)
                        {
                            brbs.Add(new BRB()
                            {
                                Message = "Most recent break is in progress.",
                                Minutes = 0,

                            });
                        }
                    }
                    catch (Exception) { }
                }
                if (row[1].ToString().ToLower().Contains("back"))
                {
                    if (tempTimeStamp != new DateTime())
                    {
                        minutes = DateTime.Parse(row[0].ToString()).Subtract(tempTimeStamp).Minutes;

                        // calculating time (without seconds)
                        DateTime fromTime = new DateTime(tempTimeStamp.Year, tempTimeStamp.Month, tempTimeStamp.Day, tempTimeStamp.Hour, tempTimeStamp.Minute, tempTimeStamp.Second);
                        DateTime toTime = DateTime.Parse(row[0].ToString());
                        toTime = new DateTime(toTime.Year, toTime.Month, toTime.Day, toTime.Hour, toTime.Minute, toTime.Second);

                        brbs.Add(new BRB()
                        {
                            Message = string.Format("{0}  -  {1}  :  Total Time in Minutes  :  {2}",
                                                     fromTime.ToString("hh:mm tt"),
                                                     toTime.ToString("hh:mm tt"),
                                                     int.Parse(Math.Ceiling(toTime.Subtract(fromTime).TotalMinutes).ToString())
                                                   ),
                                                   Minutes = int.Parse(Math.Ceiling(toTime.Subtract(fromTime).TotalMinutes).ToString())
                        });
                    }
                }
            }

            return brbs;
        }

        /// <summary>
        /// Whether or not the hourly update time is active
        /// </summary>
        void ApplyHourlyTimer()
        {
            if (App.Default.EnableHourlyReminder)
            {
                UpdateTimer.Start();
            }
            else
            {
                UpdateTimer.Stop();
            }
        }

        /// <summary>
        /// Control flow function to fetch Skype Rooms without any execpted input
        /// </summary>
        private void FetchRooms()
        {
            if (string.IsNullOrEmpty(GetUsername()))
            {
                cbRooms.DataSource = null;
                cbRooms.Items.Clear();
                return;
            }

            try
            {
                string path = GetDBFile(GetUsername());
                if (!string.IsNullOrEmpty(path))
                {
                    List<Room> rooms = FetchChatRooms(path);

                    cbRooms.Items.Clear();
                    cbRooms.DisplayMember = "RoomName";
                    cbRooms.ValueMember = "RoomID";
                    cbRooms.DataSource = rooms;
                }
            }
            catch (Exception) { }
        }

        #endregion

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            FetchRooms();
            if (cbMyAccount.Visible)
            {
                if (txtUsername.Text.Trim().ToLower() == App.Default.Username.Trim().ToLower())
                {
                    cbMyAccount.Checked = true;
                }
                else
                {
                    cbMyAccount.Checked = false;
                }
            }
        }

        /// <summary>
        /// Returns the version of Application
        /// </summary>
        void UpdateVersion()
        {
            lblVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region setting tooltips
            string message = string.Format("{0}Prepare Update Alert will appear after{0}each 2 minutes unless following are true:  {0}{0}1) 10 minutes are elapsed or{0}2) you've updated client's room.{0} ", Environment.NewLine);
            toolTip1.SetToolTip(chkEnableReminder, message);
            #endregion

            UpdateVersion();
            PopulateShiftStartValues();
            notifyIcon1.Icon = TimeAssistant.Properties.Resources.icon;

            LoadSettings();
            FetchRooms();

            #region applying settings

            if (App.Default.DefaultAction == 2)
            {
                this.ShowInTaskbar = false;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1, "Time Assistant", "Time Assistant has started", ToolTipIcon.Info);
            }

            if (!string.IsNullOrEmpty(App.Default.Username))
            {
                txtUsername.Text = App.Default.Username;
                MySkypeUsername = App.Default.Username;
                lblUsername.Text = App.Default.Username;
            }

            if (!string.IsNullOrEmpty(App.Default.RoomName))
            {
                cbRooms.SelectedIndex = cbRooms.FindString(App.Default.RoomName);
            }

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(cbRooms.Text))
            {
                return;
            }

            #endregion

            #region performing default actions
            (App.Default.DefaultAction == 0 ? btnCalcBreaks : btnGenerateDaySummary).PerformClick();
            #endregion
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnCalcBreaks.PerformClick();
        }

        private void chkIncludeMeetings_CheckedChanged(object sender, EventArgs e)
        {
            btnCalcBreaks.PerformClick();
        }

        private void chkRemoveDuplicatedUpdates_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerateDaySummary.PerformClick();
        }

        private void btnCalcBreaks_Click(object sender, EventArgs e)
        {
            int overBreak = 0;
            if (string.IsNullOrEmpty(GetUsername()) || string.IsNullOrEmpty(cbRooms.Text))
                return;

            List<string> updates = new List<string>();
            int minutes = 0;
            List<BRB> breaks = FetchBreaks(chkIncludeMeetings.Checked);

            if (breaks.Count == 0)
            {
                txtUpdate.Text = "You have not yet taken any breaks so far";
            }
            else
            {
                foreach (BRB brb in breaks)
                {
                    updates.Add(brb.Message);
                    minutes += brb.Minutes;
                }

                updates.Add("\n\r");
                updates.Add(string.Format("Total break time in minutes so far:  {0}", minutes));

                // calculating over break
                overBreak = minutes - 40;
                if (overBreak < 0)
                {
                    overBreak = 0;
                }
                updates.Add(string.Format("Over Break time in minutes so far:  {0}", overBreak));

                updates.Insert(0, "Break Calculation Summary");
                updates.Insert(1, "\n\r");

                txtUpdate.Lines = updates.ToArray();
                txtUpdate.Select(0, 0);
            }
        }

        /// <summary>
        /// Updates Skype Username
        /// </summary>
        /// <param name="Username">Skype Username</param>
        public void updateUsername(string Username)
        {
            txtUsername.Text = Username;
            lblUsername.Text = Username;
            FetchRooms();
        }

        private void btnGenerateDaySummary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetUsername()) || string.IsNullOrEmpty(cbRooms.Text))
                return;

            string temp = string.Empty;

            List<string> msgs = PrepareUpdate();

            if (msgs.Count == 0)
            {
                txtUpdate.Text = "No Record Found. Make sure that you've selected correct skype room and update Format is correct.";
                return;
            }

            if (chkRemoveDuplicatedUpdates.Checked)
            {
                msgs = msgs.Distinct().ToList();
            }
            //msgs.Reverse();

            #region appending header footer
            msgs.Insert(0, "(o) Today, I have:");
            msgs.Insert(1, "\n\r");
            msgs.Add("\n\r");
            msgs.Add("Bye Everyone!");
            msgs.Add("Hi Everyone");
            #endregion

            txtUpdate.Lines = msgs.ToArray();
            if (chkDayEndSummaryToClipboard.Checked)
            {
                txtUpdate.SelectAll();
                txtUpdate.Copy();
                //txtUpdate.Select(0, 0);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            bool isSuccessfull = false;

            #region perform input validations

            if (!cbMyAccount.Checked)
            {
                MessageBox.Show("Please make sure you're saving settings with your own Skype ID. (My Account? is still unchecked)", "Username Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(GetUsername()))
            {
                MessageBox.Show("Please provide valid skype username.", "Username Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbRooms.Text.Trim()))
            {
                MessageBox.Show("Please select skype room.", "Skype Room Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtUpdateFormat.Text.Trim()))
            {
                MessageBox.Show("Please provide Update format.", "Update Format Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdate.Focus();
                return;
            }

            if (!txtUpdateFormat.Text.ToLower().Contains("(o)"))
            {
                MessageBox.Show("Update format must include clock icon (o).", "Update Format Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdate.Focus();
                return;
            }
            #endregion

            isSuccessfull = SaveSettings();

            if (isSuccessfull)
            {
                MessageBox.Show("Information has been updated successfully.", "User Skype Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error saving information. Please make sure that this application has rights to write on Hard disk drive", "User Skype Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Save and load settings

        void PopulateShiftStartValues()
        {
            cbHours.Items.Clear();

            #region populating hours
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cbHours.Items.Add("0" + i.ToString());
                }
                else
                {
                    cbHours.Items.Add(i.ToString());
                }
            }
            #endregion

            #region populating minutes
            cbMinutes.Items.Clear();
            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    cbMinutes.Items.Add("0" + i.ToString());
                }
                else
                {
                    cbMinutes.Items.Add(i.ToString());
                }
            }
            #endregion

            #region populating AM / PM
            cbTT.Items.Clear();
            cbTT.Items.Add("AM");
            cbTT.Items.Add("PM");
            #endregion

        }

        /// <summary>
        /// Save settings made by user
        /// </summary>
        /// <returns>Is Successfull</returns>
        bool SaveSettings()
        {
            try
            {
                if (cbMyAccount.Checked)
                {
                    App.Default.Username = txtUsername.Text.Trim();
                }
                App.Default.RoomName = cbRooms.Text.Trim(); ;
                App.Default.DefaultAction = cbLoadOptions.SelectedIndex;
                App.Default.DayEndSummaryToClipboard = chkDayEndSummaryToClipboard.Checked;
                App.Default.IncludeMeetingBreaks = chkIncludeMeetings.Checked;
                App.Default.ConvertDayEndSummarytoPastTense = chkConvertToPastTense.Checked;
                
                // shift start time
                App.Default.ShiftStartHour = cbHours.Text;
                App.Default.ShiftStartMinute = cbMinutes.Text;
                App.Default.ShiftStartTT = cbTT.Text;


                App.Default.UpdateFormat = txtUpdateFormat.Text.TrimStart();
                App.Default.RemoveDuplicatedUpdates = chkRemoveDuplicatedUpdates.Checked;
                App.Default.EnableHourlyReminder = chkEnableReminder.Checked;
                App.Default.Save();

                MySkypeUsername = txtUsername.Text.Trim();
                ApplyHourlyTimer();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Loads previously saved settings (fallback enabled)
        /// </summary>
        /// <returns>Is Successfull</returns>
        bool LoadSettings()
        {
            try
            {
                cbLoadOptions.SelectedIndex = App.Default.DefaultAction;
                chkIncludeMeetings.Checked = App.Default.IncludeMeetingBreaks;
                chkDayEndSummaryToClipboard.Checked = App.Default.DayEndSummaryToClipboard;
                chkConvertToPastTense.Checked = App.Default.ConvertDayEndSummarytoPastTense;
                
                cbHours.Text = App.Default.ShiftStartHour;
                cbMinutes.Text = App.Default.ShiftStartMinute;
                cbTT.Text = App.Default.ShiftStartTT;


                txtUpdateFormat.Text = App.Default.UpdateFormat;
                chkRemoveDuplicatedUpdates.Checked = App.Default.RemoveDuplicatedUpdates;
                chkEnableReminder.Checked = App.Default.EnableHourlyReminder;
                
                ApplyHourlyTimer();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion


        private void chkConvertToPastTense_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerateDaySummary.PerformClick();
        }

        private void chkDayEndSummaryToClipboard_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerateDaySummary.PerformClick();
        }

        #region Context Menu Events

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            isExitCommand = true;
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //btnCalcBreaks.PerformClick();
            btnCalcBreaks_Click(btnCalcBreaks, null); // not calling performclick since it won't work if form is hidden
            this.Show();
            this.BringToFront();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //btnGenerateDaySummary.PerformClick();
            btnGenerateDaySummary_Click(btnGenerateDaySummary, null); // not calling performclick since it won't work if form is hidden
            this.Show();
            this.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExitCommand)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void prepareUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUpdate form = new CreateUpdate();
            form.ShowDialog();
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void copyBackToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText("Back");
            notifyIcon1.ShowBalloonTip(1);
        }

        #endregion

        void ShowPrepareUpdateWindow()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateUpdate) return;
            }

            (new CreateUpdate()).ShowDialog();
            this.Hide();
        }

        #region Timer Event

        void ShowMinuteWiseSchedulerForm()
        {
            if (DateTime.Now.Minute == 0) ShowPrepareUpdateWindow();
            if (DateTime.Now.Minute == 2) ShowPrepareUpdateWindow();
            if (DateTime.Now.Minute == 4) ShowPrepareUpdateWindow();
            if (DateTime.Now.Minute == 6) ShowPrepareUpdateWindow();
            if (DateTime.Now.Minute == 8) ShowPrepareUpdateWindow();
            if (DateTime.Now.Minute == 10) ShowPrepareUpdateWindow();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime? updateTime = GetLastUpdateTime();

            if (updateTime.HasValue && updateTime.Value.Hour == DateTime.Now.Hour) return;

            ShowMinuteWiseSchedulerForm();

            if (DateTime.Now.Hour == 23)
            {
                ShowMinuteWiseSchedulerForm();
            }

            #region code not in use
            //if (DateTime.Now.Minute == 0)
            //{
            //    if (DateTime.Now.Hour == 2)
            //    {
            //        btnGenerateDaySummary.PerformClick();
            //        this.Show();
            //        this.BringToFront();
            //        return;
            //    }

            //    ShowPrepareUpdateWindow();
            //}

            //if (DateTime.Now.Minute == 30)
            //{
            //    if (DateTime.Now.Hour == 21)
            //    {
                    

            //        ShowPrepareUpdateWindow();
            //    }
            //}
            #endregion
        }

        #endregion

        #region Making form Draggable
        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}
        //void groupBox3_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSecret_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                executeSecretCommand(txtSecret.Text.Trim());
                
                // resetting state...
                txtSecret.Visible = false;
                lblSecretCommand.Visible = false;
                txtSecret.Text = string.Empty;
            }
        }

        void executeSecretCommand(string command)
        {
            if (command.ToLower().ToString() == "sa")
            {
                cbMyAccount.Visible = !cbMyAccount.Visible;
                txtUsername.Visible = !txtUsername.Visible;

                lblUsername.Visible = !lblUsername.Visible;
                lnkbtnUpdateSkypeID.Visible = !lnkbtnUpdateSkypeID.Visible;
            }

            if (string.IsNullOrEmpty(command))
            {
                // restoring default view
                cbMyAccount.Visible = false;
                txtUsername.Visible = false;
                txtUsername.Text = lblUsername.Text;

                lblUsername.Visible = true;
                lnkbtnUpdateSkypeID.Visible = true;
            }

            txtUpdate.Focus();
        }

        private void lnkbtnUpdateSkypeID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmSkypeInfo()).ShowDialog();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.X)
            {
                txtSecret.Visible = true;
                lblSecretCommand.Visible = true;
                txtSecret.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtSecret.Text = string.Empty;
                txtSecret_KeyDown(this, new KeyEventArgs(Keys.Enter));
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            txtUpdate.SelectAll();
            txtUpdate.Copy();
            txtUpdate.Select(0, 0);
        }

        /// <summary>
        /// Update Form Component and maintaining gradient
        /// </summary>
        /// <param name="isCollapse">Collapse or expand</param>
        void UpdateHeight(bool isCollapse)
        {
            int height = 280;
            if (isCollapse)
            {
                groupBox3.Height -= height;
                btnCopyToClipboard.Location = new Point(btnCopyToClipboard.Location.X, btnCopyToClipboard.Location.Y - height);
                btnCalcBreaks.Location = new Point(btnCalcBreaks.Location.X, btnCalcBreaks.Location.Y - height);
                btnGenerateDaySummary.Location = new Point(btnGenerateDaySummary.Location.X, btnGenerateDaySummary.Location.Y - height);
                txtUpdate.Location = new Point(txtUpdate.Location.X, txtUpdate.Location.Y - height);
                lblVersion.Location = new Point(lblVersion.Location.X, lblVersion.Location.Y - height);
                this.Height -= height;
            }
            else
            {
                groupBox3.Height += height;
                btnCopyToClipboard.Location = new Point(btnCopyToClipboard.Location.X, btnCopyToClipboard.Location.Y + height);
                btnCalcBreaks.Location = new Point(btnCalcBreaks.Location.X, btnCalcBreaks.Location.Y + height);
                btnGenerateDaySummary.Location = new Point(btnGenerateDaySummary.Location.X, btnGenerateDaySummary.Location.Y + height);
                txtUpdate.Location = new Point(txtUpdate.Location.X, txtUpdate.Location.Y + height);
                lblVersion.Location = new Point(lblVersion.Location.X, lblVersion.Location.Y + height);
                this.Height += height;
            }
            this.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag.ToString() == "up")
            {
                UpdateHeight(true);
                pictureBox2.Tag = "down";
                pictureBox2.Image = TimeAssistant.Properties.Resources.down;
            }
            else
            {
                UpdateHeight(false);
                pictureBox2.Tag = "up";
                pictureBox2.Image = TimeAssistant.Properties.Resources.up;
            }
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:pro.technologist@gmail.com");
        }
    }
}

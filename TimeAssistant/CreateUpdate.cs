using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace TimeAssistant
{
    public partial class CreateUpdate : ThemedBaseForm
    {
        public CreateUpdate()
        {
            InitializeComponent();
            base.ApplyTheme();
        }

        private void CreateUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                // will work once form is open once after cold start up
                string lastUpdate = (Application.OpenForms[0] as frmMain).GetLastUpdate();
                if (!string.IsNullOrEmpty(lastUpdate))
                {
                    txtUpdate.Text = lastUpdate.Trim();
                    txtUpdate.SelectAll();
                }
            }
            catch (Exception) { }
            txtUpdate.Focus();
        }
        private void ShowSkype()
        {
            try
            {
                Process skype = Process.GetProcessesByName("Skype")[0];
                Interaction.AppActivate(skype.Id);
            }
            catch (Exception) { }
        }

        private void txtUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Hide();
                    txtUpdate.Text = txtUpdate.Text.Trim();
                    txtUpdate.Text = App.Default.UpdateFormat.TrimEnd() + " " + char.ToUpper(txtUpdate.Text[0]) + txtUpdate.Text.Substring(1);
                    txtUpdate.SelectAll();
                    txtUpdate.Copy();

                    if (cbFocusSkype.Checked)
                    {
                        ShowSkype();
                    }
                }
                catch (Exception) { }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

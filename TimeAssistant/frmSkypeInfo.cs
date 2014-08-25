using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeAssistant
{
    public partial class frmSkypeInfo : ThemedBaseForm
    {
        public frmSkypeInfo()
        {
            InitializeComponent();
            base.ApplyTheme();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSkypeID.Text))
            {
                MessageBox.Show("Please provide Skype ID before continue", "Skype Account Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            App.Default.Username = txtSkypeID.Text.Trim();
            App.Default.Save();
            this.Hide();

            (Application.OpenForms[0] as frmMain).updateUsername(txtSkypeID.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtSkypeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnContinue.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void frmSkypeInfo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(App.Default.Username))
            {
                txtSkypeID.Text = App.Default.Username;
                txtSkypeID.Select(txtSkypeID.Text.Length, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnCancel.PerformClick();
        }

    }
}

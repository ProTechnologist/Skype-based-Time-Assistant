using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TimeAssistant
{
    public partial class ThemedBaseForm : Form
    {
        protected bool isExitCommand = false;

        protected themes CurrentTheme = themes.Black;

        public enum themes
        {
            Black,
            None
        }
        #region Helper functions to making form draggable (and with GroupBox)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region applying Black Theme

        protected void ApplyTheme()
        {
            ApplyTheme(this);
        }

        void ApplyTheme(Control ContainerControl)
        {
            if (ContainerControl is Form)
            {
                (ContainerControl as Form).Paint += new PaintEventHandler(c_Paint);
                (ContainerControl as Form).Invalidate(true);
            }

            foreach (Control ctrl in ContainerControl.Controls)
            {
                if (ctrl is GroupBox)
                {
                    GroupBox gBox = ctrl as GroupBox;

                    gBox.Paint += new PaintEventHandler(c_Paint);
                    gBox.Invalidate();
                    gBox.ForeColor = System.Drawing.Color.White;
                    ApplyTheme(gBox);
                    
                    gBox.ForeColor = System.Drawing.Color.White;
                    ApplyTheme(gBox);

                    gBox.MouseDown += new MouseEventHandler(GroupBox_MouseDown);
                }

                if (ctrl is Label)
                {
                    Label lbl = ctrl as Label;
                    if (lbl.Name == "lblTitle")
                    {
                        lbl.BackColor = System.Drawing.Color.Gray;
                        lbl.ForeColor = System.Drawing.Color.White;
                        continue;
                    }
                    lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
                    lbl.BackColor = System.Drawing.Color.Transparent;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox chk = ctrl as CheckBox;
                    chk.ForeColor = System.Drawing.Color.White;
                    chk.BackColor = System.Drawing.Color.Transparent;
                }

                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    if (txt != null)
                    {
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.ForeColor = System.Drawing.Color.White;
                        txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    }
                }
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn != null)
                    {
                        btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        btn.ForeColor = System.Drawing.Color.Transparent;
                        btn.UseVisualStyleBackColor = false;
                    }
                }

                if (ctrl is ComboBox)
                {
                    ComboBox cb = ctrl as ComboBox;
                    cb.FlatStyle = FlatStyle.Popup;
                    cb.BackColor = System.Drawing.Color.Gray;
                    cb.ForeColor = System.Drawing.Color.White;
                }

                if (ctrl is LinkLabel)
                {
                    LinkLabel lbl = ctrl as LinkLabel;
                    lbl.LinkColor = System.Drawing.Color.White;
                }
            }
        }

        void c_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.Gray,
                                                               Color.Black,
                                                               90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            if (sender is Form)
            {
                (sender as Form).Opacity = 1.5;

                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    Color.DimGray, 5, ButtonBorderStyle.Outset,    // left border
                    Color.DimGray, 5, ButtonBorderStyle.Dashed,    // top border
                    Color.DimGray, 5, ButtonBorderStyle.Dashed,    // right border
                    Color.DarkGray, 5, ButtonBorderStyle.Outset);   // bottom border
            }
        }

        void c_Paint2(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 48f, FontStyle.Bold);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height + 5), Color.Gold, Color.Black, LinearGradientMode.Vertical);
            e.Graphics.DrawString(Text, font, brush, 0, 0);
        }

        void paint(Control c)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle,
                                                               Color.Gray,
                                                               Color.Black,
                                                               90F))
            {
                c.CreateGraphics().FillRectangle(brush, this.ClientRectangle);
                c.Invalidate();
            }
        }

        #endregion

        public ThemedBaseForm()
        {
            ApplyTheme();
        }

        #region Making form and GroupBox draggable

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void GroupBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}

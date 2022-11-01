using ClientApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.Forms
{
    public partial class Main : Form
    {
        private Size formSize;
        public Main()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        protected override void WndProc(ref Message m)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Padding = new Padding(8);
            }
            if (WindowState == FormWindowState.Normal)
            {
                Padding = new Padding(2);
            }
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            #region Form Resize

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = ClientSize;
                if (wParam == SC_RESTORE)
                    Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(Controls);
        }
        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(Controls);
        }
        public void LoadForm(object FormObject)
        {
            if (WorkPanel.Panel1.Controls.Count > 0)
            {
                WorkPanel.Panel1.Controls.RemoveAt(0);
            }
            Form Form = FormObject as Form;
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            Form.ShowInTaskbar = false;
            WorkPanel.Panel1.Controls.Add(Form);
            Form.Show();
        }
        private void ButtonShutdown_Click(object sender, EventArgs e)
        {
            ShutdownMenu.Show(ButtonShutdown, ButtonShutdown.Width, 0);
        }

        private void ExitApplicationShutdownMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinimizeToTrayShutdownMenuButton_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(5);
            ShowInTaskbar = false;
            Hide();
        }
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;
            ShowInTaskbar = true;
            Show();
        }
        private void LogoutShutdownMenuButton_Click(object sender, EventArgs e)
        {
            FormManagerService.Login.Show();
            Hide();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            LoadForm(FormManagerService.Home);
        }
        private void ButtonDevices_Click(object sender, EventArgs e)
        {
            LoadForm(FormManagerService.Devices);
        }
        private void ButtonMonitoring_Click(object sender, EventArgs e)
        {
            LoadForm(FormManagerService.Monitoring);
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            LoadForm(FormManagerService.Settings);
        }
    }
}
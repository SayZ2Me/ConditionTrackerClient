using ClientApplication.Managers;
using System.Runtime.InteropServices;

namespace ClientApplication.Forms
{
    public partial class Main : Form
    {
        private Size formSize;
        NotifyIcon trayNotifyIcon = ControlManager.TrayNotifyIcon;
        public Main()
        {
            InitializeComponent();
        }

        #region [ Window behavior DLL import ]

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion [ Window behavior DLL import ]

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #region [ Window behavior WndProc override ]

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

        #endregion [ Window behavior WndProc override ]

        private void Main_Load(object sender, EventArgs e)
        {
            LoadForm(FormManager.Home);
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }

        public override void Refresh()
        {
            base.Refresh();
            MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }

        public void LoadForm(object formObject)
        {
            if (WorkPanel.Controls.Count > 0)
            {
                WorkPanel.Invalidate();
                WorkPanel.Controls.RemoveAt(0);
            }
            if (formObject is not null)
            {
                Form form = formObject as Form;

                ButtonHome.Checked = false;
                ButtonDevices.Checked = false;
                ButtonMonitoring.Checked = false;
                ButtonSettings.Checked = false;
                if (form.Text == "Home") { ButtonHome.Checked = true; }
                if (form.Text == "Devices") { ButtonDevices.Checked = true; }
                if (form.Text == "Monitoring") { ButtonMonitoring.Checked = true; }
                if (form.Text == "Settings") { ButtonSettings.Checked = true; }

                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.ShowInTaskbar = false;
                WorkPanel.Controls.Add(form);
                form.Show();
            }
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
            trayNotifyIcon.Visible = true;
            trayNotifyIcon.ShowBalloonTip(5);
            Hide();
        }
        private void LogoutShutdownMenuButton_Click(object sender, EventArgs e)
        {
            FormManager.Login.Show();
            Hide();
        }
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            LoadForm(FormManager.Home);
        }
        private void ButtonDevices_Click(object sender, EventArgs e)
        {
            LoadForm(FormManager.Devices);
        }
        private void ButtonMonitoring_Click(object sender, EventArgs e)
        {
            LoadForm(FormManager.Monitoring);
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            LoadForm(FormManager.Settings);
        }
    }
}
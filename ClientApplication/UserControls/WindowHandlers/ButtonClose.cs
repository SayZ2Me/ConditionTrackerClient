using ClientApplication.Managers;
using ClientApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.UserControls
{
    public partial class ButtonClose : UserControl
    {

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Параметры")]
        public bool hideWindow { get; set; }
        private NotifyIcon trayNotifyIcon = ControlManager.TrayNotifyIcon;
        public ButtonClose()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.ButtonClose;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (hideWindow)
            {
                ParentForm.Visible = false;
            }
            else if (Properties.Settings.Default.AppClose)
            {
                trayNotifyIcon.Visible = true;
                trayNotifyIcon.ShowBalloonTip(5);
                ParentForm.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonCloseEnter;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonClose;
        }
    }
}

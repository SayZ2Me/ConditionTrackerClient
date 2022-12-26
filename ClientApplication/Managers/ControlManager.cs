using ClientApplication.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Managers
{
    internal class ControlManager
    {
        private static NotifyIcon trayNotifyIcon;
        public static NotifyIcon TrayNotifyIcon
        {
            get
            {
                trayNotifyIcon ??= new();
                SetupTrayNotification();
                return trayNotifyIcon;
            }
        }
        private static void SetupTrayNotification()
        {
            trayNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayNotifyIcon.BalloonTipTitle = "Приложение переведено в фоновый режим.";
            trayNotifyIcon.BalloonTipText = "Работа приложения переведена в фоновый режим. В фоновом режиме вы будете получать уведомления от подключенных устройств. Чтобы отобразить приложение на экране нажмите на иконку в меню \"Отображать скрытые значки\"";
            trayNotifyIcon.Text = "Condidtion Tracker";
            trayNotifyIcon.Visible = false;
            trayNotifyIcon.Icon = Properties.Resources.IconConditionTracker;
            trayNotifyIcon.Click += (sender, e) =>
            {
                FormManager.Main.Show();
                trayNotifyIcon.Visible = false;
            };
        }
    }
}

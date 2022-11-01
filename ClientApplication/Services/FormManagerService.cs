using ClientApplication.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Services
{
    internal class FormManagerService
    {
        private static Login login = new();
        private static Main main = new();
        private static Forms.WorkPanels.Home home = new();
        private static Forms.WorkPanels.Devices devices = new();
        private static Forms.WorkPanels.Monitoring monitoring = new();
        private static Forms.WorkPanels.Settings settings = new();
        private static readonly List<Form> forms = new();
        public static Login Login
        {
            get
            {
                login ??= new();
                forms.Add(login);
                return login;
            }
        }
        public static Main Main
        {
            get
            {
                main ??= new();
                forms.Add(main);
                return main;
            }
        }
        public static Forms.WorkPanels.Home Home
        {
            get
            {
                home ??= new();
                return home;
            }
        }
        public static Forms.WorkPanels.Devices Devices
        {
            get
            {
                devices ??= new();
                return devices;
            }
        }
        public static Forms.WorkPanels.Monitoring Monitoring
        {
            get
            {
                monitoring ??= new();
                return monitoring;
            }
        }
        public static Forms.WorkPanels.Settings Settings
        {
            get
            {
                settings ??= new();
                return settings;
            }
        }
        public static void RefreshAll()
        {
            foreach (Form form in forms)
            {
                form.Refresh();
            }
        }
    }
}

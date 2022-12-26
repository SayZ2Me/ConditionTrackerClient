using ClientApplication.Forms;

namespace ClientApplication.Managers
{
    internal class FormManager
    {
        private static Login _login = new();
        private static Main _main = new();
        private static Forms.WorkPanels.Home _home = new();
        private static Forms.WorkPanels.Devices _devices = new();
        private static Forms.WorkPanels.Monitoring _monitoring = new();
        private static Forms.WorkPanels.Settings _settings = new();
        private static Forms.AuxiliaryForms.Error _error = new();
        private static readonly List<Form> _forms = new();
        public static Login Login
        {
            get
            {
                _login ??= new();
                _login.Refresh();
                _forms.Add(_login);
                return _login;
            }
        }
        public static Main Main
        {
            get
            {
                _main ??= new();
                _main.Refresh();
                _forms.Add(_main);
                return _main;
            }
        }
        public static Forms.AuxiliaryForms.Error Error
        {
            get
            {
                _error ??= new();
                _error.Refresh();
                return _error;
            }
        }
        public static Forms.WorkPanels.Home Home
        {
            get
            {
                _home ??= new();
                _home.Refresh();
                return _home;
            }
        }
        public static Forms.WorkPanels.Devices Devices
        {
            get
            {
                _devices ??= new();
                _devices.Refresh();
                return _devices;
            }
        }
        public static Forms.WorkPanels.Monitoring Monitoring
        {
            get
            {
                _monitoring ??= new();
                _monitoring.Refresh();
                return _monitoring;
            }
        }
        public static Forms.WorkPanels.Settings Settings
        {
            get
            {
                _settings ??= new();
                _settings.Refresh();
                return _settings;
            }
        }
        public static void RefreshAll()
        {
            foreach (Form form in _forms)
            {
                form.Refresh();
            }
        }
        public static void ShowErrorWindow(string errorMessage, string errorDescription)
        {
            Error.SetErrorMessage(errorMessage);
            Error.SetErrorDescription(errorDescription);
            Error.Visible = true;
        }
    }
}

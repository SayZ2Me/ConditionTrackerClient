using ClientApplication.Managers;
using ClientApplication.Classes;
using System.DirectoryServices.ActiveDirectory;

namespace ClientApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            HttpManager.Ping();
            SettingsManager.IsThemeDark = Properties.Settings.Default.DarkTheme;
            FormManager.RefreshAll();
            Application.Run(FormManager.Login);
        }
    }
}
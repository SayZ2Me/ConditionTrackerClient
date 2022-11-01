using ClientApplication.Services;
using System.DirectoryServices.ActiveDirectory;

namespace ClientApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SettingsService.IsThemeDark = Properties.Settings.Default.DarkTheme;
            ApplicationConfiguration.Initialize();
            Application.Run(FormManagerService.Login);
        }
    }
}
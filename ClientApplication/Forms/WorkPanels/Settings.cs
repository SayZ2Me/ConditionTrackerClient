using ClientApplication.Services;
using ClientApplication.UserControls.InputHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.Forms.WorkPanels
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(Controls);

            AppCloseToggle.Checked = Properties.Settings.Default.AppClose;
            DarkThemeToggle.Checked = Properties.Settings.Default.DarkTheme;
        }
        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(Controls);
        }
        private void DarkThemeToggle_CheckStateChanged(object sender, EventArgs e)
        {
            SettingsService.IsThemeDark = DarkThemeToggle.Checked;
            Properties.Settings.Default["DarkTheme"] = DarkThemeToggle.Checked;
            FormManagerService.RefreshAll();
        }
        private void AppCloseToggle_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["AppClose"] = AppCloseToggle.Checked;
        }
        private void SaveApplicationSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
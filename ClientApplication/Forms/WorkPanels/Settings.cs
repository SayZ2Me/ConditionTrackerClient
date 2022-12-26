using ClientApplication.Managers;
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
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);

            AppCloseToggle.Checked = Properties.Settings.Default.AppClose;
            DarkThemeToggle.Checked = Properties.Settings.Default.DarkTheme;
        }
        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }
        private void DarkThemeToggle_CheckStateChanged(object sender, EventArgs e)
        {
            SettingsManager.IsThemeDark = DarkThemeToggle.Checked;
            Properties.Settings.Default["DarkTheme"] = DarkThemeToggle.Checked;
            Properties.Settings.Default.Save();
            FormManager.RefreshAll();
        }
        private void AppCloseToggle_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["AppClose"] = AppCloseToggle.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
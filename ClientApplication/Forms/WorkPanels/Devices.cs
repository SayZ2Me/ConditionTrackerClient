using ClientApplication.Services;
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
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }
        private void Devices_Load(object sender, EventArgs e)
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
    }
}
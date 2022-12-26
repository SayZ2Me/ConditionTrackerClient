using ClientApplication.Classes;
using ClientApplication.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.UserControls.InputHandlers
{
    public class MenuColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground { get { return SettingsManager.PanelColor(); } }
        public override Color MenuBorder { get { return SettingsManager.BackGroundColor(); } }
        public override Color MenuItemBorder { get { return SettingsManager.BackGroundColor(); } }
        public override Color MenuItemSelected { get { return SettingsManager.MainColor(); } }
        public override Color ImageMarginGradientBegin { get { return SettingsManager.BackGroundColor(); } }
        public override Color ImageMarginGradientMiddle { get { return SettingsManager.BackGroundColor(); } }
        public override Color ImageMarginGradientEnd { get { return SettingsManager.BackGroundColor(); } }
    }
}
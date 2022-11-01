using ClientApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.UserControls.InputHandlers
{
    public class MenuColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground { get { return SettingsService.PanelColor(); } }
        public override Color MenuBorder { get { return SettingsService.BackGroundColor(); } }
        public override Color MenuItemBorder { get { return SettingsService.BackGroundColor(); } }
        public override Color MenuItemSelected { get { return SettingsService.MainColor(); } }
        public override Color ImageMarginGradientBegin { get { return SettingsService.BackGroundColor(); } }
        public override Color ImageMarginGradientMiddle { get { return SettingsService.BackGroundColor(); } }
        public override Color ImageMarginGradientEnd { get { return SettingsService.BackGroundColor(); } }
    }
}
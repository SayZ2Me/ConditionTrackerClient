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

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class ButtonResponsive : UserControl
    {
        public Delegate button_OnClick;
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return ResponsiveButton.Text; }
            set { ResponsiveButton.Text = "    " + value; }
        }
        public Image ImageDark
        {
            get { return ImageDark; }
            set { ImageDark = value; }
        }
        private Image ImageLight
        {
            get { return ImageLight; }
            set { ImageLight = value; }
        }
        private Image ImageHighlight
        {
            get { return ImageHighlight; }
            set { ImageHighlight = value; }
        }
        public ButtonResponsive()
        {
            InitializeComponent();
            ImageLight = ExtensionService.ConvertColor(ImageDark, SettingsService.TextColor());
            ImageHighlight = ExtensionService.ConvertColor(ImageDark, SettingsService.MainColor());
        }
        public override void Refresh()
        {
            base.Refresh();
            ResponsiveButton.Image = SettingsService.IsThemeDark ? ImageDark : ImageLight;
        }
        private void ResponsiveButton_MouseEnter(object sender, EventArgs e)
        {
            ResponsiveButton.ForeColor = SettingsService.HighlightColor();
            ResponsiveButton.Image = ImageHighlight;
        }
        private void ResponsiveButton_MouseLeave(object sender, EventArgs e)
        {
            ResponsiveButton.ForeColor = SettingsService.TextColor();
            ResponsiveButton.Image = SettingsService.IsThemeDark ? ImageDark : ImageLight;
        }
    }
}

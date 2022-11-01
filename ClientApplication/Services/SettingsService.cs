using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Services
{
    internal class SettingsService
    {
        private static readonly Color _mainColor = ColorTranslator.FromHtml("#ff80a8a4");

        private static readonly Color _backGroundDark = ColorTranslator.FromHtml("#ff303238");
        private static readonly Color _highlightDark = ColorTranslator.FromHtml("#ff4c4e57");
        private static readonly Color _panelDark = ColorTranslator.FromHtml("#ff3c3d42");
        private static readonly Color _textDark = ColorTranslator.FromHtml("#ffefefef");

        private static readonly Color _backGroundLight = ColorTranslator.FromHtml("#ffc4c4c4");
        private static readonly Color _highlightLight = ColorTranslator.FromHtml("#ffeaeaea");
        private static readonly Color _panelLight = ColorTranslator.FromHtml("#fff0f0f0");
        private static readonly Color _textLight = ColorTranslator.FromHtml("#ff525252");

        private static bool _isThemeDark = true;
        public static bool IsThemeDark { get { return _isThemeDark; } set { _isThemeDark = value; } }
        public static Color MainColor() { return _mainColor; }
        public static Color BackGroundColor() { if (IsThemeDark) return _backGroundDark; else return _backGroundLight; }
        public static Color HighlightColor() { if (IsThemeDark) return _highlightDark; else return _highlightLight; }
        public static Color PanelColor() { if (IsThemeDark) return _panelDark; else return _panelLight; }
        public static Color TextColor() { if (IsThemeDark) return _textDark; else return _textLight; }
        private static void ApplyTheme(Control control)
        {
            if (control.GetType() == typeof(Label))
            {
                Label label = (Label)control;
                label.ForeColor = TextColor();
            }
            else if (control.GetType() == typeof(Button))
            {
                Button button = (Button)control;
                button.FlatAppearance.BorderColor = MainColor();
                button.ForeColor = TextColor();
                button.FlatAppearance.MouseOverBackColor = HighlightColor();
                button.FlatAppearance.MouseDownBackColor = MainColor();
            }
            else if (control.Tag == null || control.Tag.ToString() == "Panel")
            {
                control.BackColor = PanelColor();
            }
            else if (control.Tag.ToString() == "Main")
            {
                control.BackColor = MainColor();
            }
            else if (control.Tag.ToString() == "BackGround")
            {
                control.BackColor = BackGroundColor();
            }
        }
        public static void SetThemeColors(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                foreach (Control childControl in control.Controls.All())
                {
                    ApplyTheme(childControl);
                }
                ApplyTheme(control);
            }
        }
    }
}

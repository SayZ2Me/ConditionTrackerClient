using ClientApplication.UserControls.InputHandlers;
using ClientApplication.Classes;

namespace ClientApplication.Managers
{
    internal class SettingsManager
    {
        private static bool _isThemeDark = true;

        private static readonly Color _mainColor = ColorTranslator.FromHtml("#60607b");

        private static readonly Color _highlightDark = ColorTranslator.FromHtml("#8888f0");
        private static readonly Color _headerDark = ColorTranslator.FromHtml("#424250");
        private static readonly Color _backGroundDark = ColorTranslator.FromHtml("#373740");
        private static readonly Color _panelDark = ColorTranslator.FromHtml("#2E2E34");
        private static readonly Color _textDark = ColorTranslator.FromHtml("#ffefefef");

        private static readonly Color _backGroundLight = ColorTranslator.FromHtml("#e8e8f1");
        private static readonly Color _headerLight = ColorTranslator.FromHtml("#b8b7ce");
        private static readonly Color _highlightLight = ColorTranslator.FromHtml("#8888f0");
        private static readonly Color _panelLight = ColorTranslator.FromHtml("#f2f2f6");
        private static readonly Color _textLight = ColorTranslator.FromHtml("#60607b");

        public static bool IsThemeDark { get { return _isThemeDark; } set { _isThemeDark = value; } }
        public static Color MainColor() { return _mainColor; }
        public static Color HighlightColor() { if (IsThemeDark) return _highlightDark; else return _highlightLight; }
        public static Color HeaderColor() { if (IsThemeDark) return _headerDark; else return _headerLight; }
        public static Color BackGroundColor() { if (IsThemeDark) return _backGroundDark; else return _backGroundLight; }
        public static Color PanelColor() { if (IsThemeDark) return _panelDark; else return _panelLight; }
        public static Color TextColor() { if (IsThemeDark) return _textDark; else return _textLight; }
        public static Color TextColorDark() { return _textDark; }
        public static Color TextColorLight() { return _textLight; }
        private static void ApplyTheme(Control control)
        {
            if (control.GetType() == typeof(Label) && control.Tag == null)
            {
                Label label = (Label)control;
                label.ForeColor = TextColor();
            }
            else if (control.GetType() == typeof(Button))
            {
                Button button = (Button)control;
                button.FlatAppearance.BorderColor = MainColor();
                button.ForeColor = MainColor();
                button.FlatAppearance.MouseOverBackColor = BackGroundColor();
                button.FlatAppearance.MouseDownBackColor = MainColor();
            }
            else if (control.GetType() == typeof(ButtonCustom))
            {
                ButtonCustom button = (ButtonCustom)control;
                button.Refresh();
            }
            else if (control.GetType() == typeof(TextBoxCustom))
            {
                TextBoxCustom textBox = (TextBoxCustom)control;
                textBox.Refresh();
                textBox.BackColor = PanelColor();
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
            else if (control.Tag.ToString() == "Header")
            {
                control.BackColor = HeaderColor();
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

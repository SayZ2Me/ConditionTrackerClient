using ClientApplication.Classes;
using ClientApplication.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.UserControls.InputHandlers
{
    public class ButtonCustom : Button
    {
        private Image _iconDark;
        private Image _iconLight;
        private Image _iconMain;
        private bool _checked = false;

        [Category("Внешний вид")]
        public bool Checked
        {
            get { return _checked; }
            set {
                _checked = value;
                if (_checked)
                {
                    Image = IconHighLight;
                    ForeColor = SettingsManager.HighlightColor();
                }
                else
                {
                    Image = IconLight;
                    ForeColor = SettingsManager.MainColor();
                }
            }
        }
        [Category("Внешний вид")]
        public Image IconDark
        {
            get { return _iconDark; }
            set { _iconDark = value; Invalidate(); }
        }

        [Category("Внешний вид")]
        public Image IconLight
        {
            get { return _iconLight; }
            set { _iconLight = value; Image = value; Invalidate(); }
        }

        [Category("Внешний вид")]
        public Image IconHighLight
        {
            get { return _iconMain; }
            set { _iconMain = value; Invalidate(); }
        }

        [Category("Внешний вид")]
        public bool OnPanel { get; set; }

        [Category("Внешний вид")]
        public bool MainOnClick { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            Image = IconHighLight;
            ForeColor = SettingsManager.HighlightColor();
            base.OnMouseEnter(e);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            Image = IconDark;
            ForeColor = SettingsManager.TextColorDark();
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (_checked)
            {
                Image = IconHighLight;
                ForeColor = SettingsManager.HighlightColor();
            }
            else
            {
                Image = IconLight;
                ForeColor = SettingsManager.MainColor();
            }
            BackColor = SettingsManager.BackGroundColor();
            base.OnMouseLeave(e);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            Image = IconHighLight;
            ForeColor = SettingsManager.HighlightColor();
            base.OnMouseUp(mevent);
        }
        public override void Refresh()
        {
            base.Refresh();
            if (_checked)
            {
                Image = IconHighLight;
                ForeColor= SettingsManager.HighlightColor();
            }
            else
            {
                Image = IconLight;
                ForeColor= SettingsManager.MainColor();
            }
            BackColor = Color.Transparent;

            FlatAppearance.BorderColor = SettingsManager.MainColor();

            FlatAppearance.MouseOverBackColor = OnPanel ? SettingsManager.PanelColor() : SettingsManager.BackGroundColor();

            FlatAppearance.MouseDownBackColor = MainOnClick ? SettingsManager.MainColor() : SettingsManager.BackGroundColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using ClientApplication.Services;

namespace ClientApplication.UserControls.InputHandlers
{
    public class ButtonToggle : CheckBox
    {
        private Color enabledBackColor = SettingsService.MainColor();
        private Color enabledToggleColor = Color.WhiteSmoke;
        private Color disabledBackColor = Color.Gray;
        private Color disabledToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        [Category("Внешний вид")]
        public Color EnabledBackColor
        {
            get { return enabledBackColor; }
            set
            {
                enabledBackColor = value;
                Invalidate();
            }
        }
        [Category("Внешний вид")]
        public Color EnabledToggleColor
        {
            get { return enabledToggleColor; }
            set
            {
                enabledToggleColor = value;
                Invalidate();
            }
        }
        [Category("Внешний вид")]
        public Color DisabledBackColor
        {
            get { return disabledBackColor; }
            set
            {
                disabledBackColor = value;
                Invalidate();
            }
        }
        [Category("Внешний вид")]
        public Color DisabledToggleColor
        {
            get { return disabledToggleColor; }
            set
            {
                disabledToggleColor = value;
                Invalidate();
            }
        }
        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { }
        }
        [Category("Внешний вид")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set
            {
                solidStyle = value;
                Invalidate();
            }
        }
        public ButtonToggle()
        {
            MinimumSize = new Size(45, 22);
            AutoSize = false;
        }
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new(0, 0, arcSize, arcSize);
            Rectangle rightArc = new(Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int toggleSize = Height - 5;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent.BackColor);

            if (Checked)
            {
                if (solidStyle)
                {
                    e.Graphics.FillPath(new SolidBrush(enabledBackColor), GetFigurePath());
                }
                else
                {
                    e.Graphics.DrawPath(new Pen(enabledBackColor, 2), GetFigurePath());
                }
                e.Graphics.FillEllipse(new SolidBrush(enabledToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                {
                    e.Graphics.FillPath(new SolidBrush(disabledBackColor), GetFigurePath());
                }
                else
                {
                    e.Graphics.DrawPath(new Pen(disabledBackColor, 2), GetFigurePath());
                }
                e.Graphics.FillEllipse(new SolidBrush(disabledToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}

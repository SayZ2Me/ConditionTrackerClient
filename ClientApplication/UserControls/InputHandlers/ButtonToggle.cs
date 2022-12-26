using System.Drawing.Drawing2D;
using System.ComponentModel;
using ClientApplication.Managers;

namespace ClientApplication.UserControls.InputHandlers
{
    public class ButtonToggle : CheckBox
    {
        private readonly Color _enabledBackColor = SettingsManager.HighlightColor();
        private readonly Color _enabledToggleColor = Color.WhiteSmoke;
        private readonly Color _disabledBackColor = SettingsManager.MainColor();
        private readonly Color _disabledToggleColor = Color.Gainsboro;

        private bool solidStyle = true;

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
                    e.Graphics.FillPath(new SolidBrush(_enabledBackColor), GetFigurePath());
                }
                else
                {
                    e.Graphics.DrawPath(new Pen(_enabledBackColor, 2), GetFigurePath());
                }
                e.Graphics.FillEllipse(new SolidBrush(_enabledToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                {
                    e.Graphics.FillPath(new SolidBrush(_disabledBackColor), GetFigurePath());
                }
                else
                {
                    e.Graphics.DrawPath(new Pen(_disabledBackColor, 2), GetFigurePath());
                }
                e.Graphics.FillEllipse(new SolidBrush(_disabledToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}

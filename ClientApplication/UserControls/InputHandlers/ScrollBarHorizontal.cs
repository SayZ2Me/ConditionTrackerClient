using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class ScrollBarHorizontal : UserControl
    {
        private Panel _parentPanel;
        private int _leftOfset = 27;
        private int _rightOfset = 27;
        private double _scaleFactor = 0;
        private Point _CursorPosition;
        private Point _CurrentCursorPosition;
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Свойства")]
        public Panel ParentPanel
        {
            get { return _parentPanel; }
            set { _parentPanel = value; }
        }
        public ScrollBarHorizontal()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _CurrentCursorPosition = PointToClient(Cursor.Position);

            if (_CurrentCursorPosition.X < _leftOfset)
            {
                _CurrentCursorPosition.X = _leftOfset;
            }
            else if (_CurrentCursorPosition.X > Width - _rightOfset)
            {
                _CurrentCursorPosition.X = Width - _rightOfset;
            }
            if (_CursorPosition != _CurrentCursorPosition)
            {
                _CursorPosition = _CurrentCursorPosition;
                _parentPanel.HorizontalScroll.Value = (int)((_CursorPosition.X - _leftOfset) / _scaleFactor);
                Invalidate();
            }
        }
        private void ScrollBarCustom_MouseDown(object sender, MouseEventArgs e)
        {
            Timer.Start();
        }
        private void ScrollBarCustom_MouseUp(object sender, MouseEventArgs e)
        {
            Timer.Stop();
        }
        private GraphicsPath GetScrollBarPath()
        {
            int arcSize = 5;
            Rectangle rightArc = new(_CursorPosition.X + 20, (Height - arcSize) / 2, arcSize, arcSize);
            Rectangle leftArc = new(_CursorPosition.X - 20 - arcSize, (Height - arcSize) / 2, arcSize, arcSize);
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        public void SetBarPosition(int x)
        {
            _CursorPosition = new Point((int)(x * _scaleFactor) + _leftOfset, 0);
            Invalidate();
        }
        public void SetScaleFactor(int horizontalScrollMaximum)
        {
            if (horizontalScrollMaximum != 0)
            {
                _scaleFactor = (Width - _leftOfset - _rightOfset) / (double)horizontalScrollMaximum;
                if (_scaleFactor > 0)
                {
                    Enabled = true;
                    Visible = true;
                }
                else
                {
                    Enabled = false;
                    Visible = false;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.FillPath(new SolidBrush(Managers.SettingsManager.HeaderColor()), GetScrollBarPath());
        }
    }
}

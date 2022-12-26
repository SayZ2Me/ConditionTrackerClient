using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class ScrollBarVertical : UserControl
    {
        private Panel _parentPanel;
        private int _topOfset = 27;
        private int _bottomOfset = 27;
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
        public ScrollBarVertical()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _CurrentCursorPosition = PointToClient(Cursor.Position);

            if (_CurrentCursorPosition.Y < _topOfset)
            {
                _CurrentCursorPosition.Y = _topOfset;
            }
            else if (_CurrentCursorPosition.Y > Height - _bottomOfset)
            {
                _CurrentCursorPosition.Y = Height - _bottomOfset;
            }
            if (_CursorPosition != _CurrentCursorPosition)
            {
                _CursorPosition = _CurrentCursorPosition;
                _parentPanel.VerticalScroll.Value = (int)((_CursorPosition.Y - _topOfset) / _scaleFactor);
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
            Rectangle topArc = new(((Width - arcSize) / 2), _CursorPosition.Y + 20, arcSize, arcSize);
            Rectangle bottomArc = new(((Width - arcSize) / 2), _CursorPosition.Y - 20 - arcSize, arcSize, arcSize);
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(topArc, 0, 180);
            path.AddArc(bottomArc, 180, 180);
            path.CloseFigure();
            return path;
        }
        public void SetBarPosition(int Y)
        {
            _CursorPosition = new Point(0, (int)(Y * _scaleFactor) + _topOfset);
            Invalidate();
        }
        public void SetScaleFactor(int verticalScrollMaximum)
        {
            if (verticalScrollMaximum != 0)
            {
                _scaleFactor = (double)(Height - _topOfset - _bottomOfset) / (double)verticalScrollMaximum;
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

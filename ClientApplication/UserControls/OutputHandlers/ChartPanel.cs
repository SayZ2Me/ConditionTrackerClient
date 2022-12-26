using ClientApplication.Classes;
using ClientApplication.Managers;
using ClientApplication.UserControls.InputHandlers;
using System.Drawing.Drawing2D;

namespace ClientApplication.UserControls.OutputHandlers
{
    public partial class ChartPanel : UserControl
    {
        private Device _device;
        private SortedDictionary<string,bool> _enabledCharts = new();
        private double[] _timeSpan;

        private double _yMax = 0;
        private double _yMin = 0;
        private double _xMin = 0;
        private double _xMax = 0;

        private double _lowVal = 0;
        private double _midVal = 0;
        private double _highVal = 0;

        private double _chartWidth = 0;
        private double _chartHeight = 0;
        private double _chartScaleOnX = 0;
        private double _chartScaleOnY = 0;

        private int _height = 0;
        private int _width = 0;

        private int _labelMaxWidth = 60;

        private GraphicsPath _graphicsPath;

        public ChartPanel()
        {
            InitializeComponent();
            chartController.SetDoubleBuffered();
            _graphicsPath = GetGraphicsPath();
        }
        public ChartPanel CreateCopy(ChartPanel copy)
        {
            copy.SetDevice(_device);
            return copy;
        }
        private void CalculateBoundaries()
        {
            _yMin = double.MaxValue;
            _yMax = double.MinValue;

            _xMin = _timeSpan[0];
            _xMax = _timeSpan[^1];

            foreach (Sensor deviceSensor in _device.sensors)
            {
                if (!_enabledCharts[deviceSensor.GetType])
                {
                    continue;
                }
                double min = deviceSensor.GetData.Min();
                double max = deviceSensor.GetData.Max();
                _yMin = min < _yMin ? min : _yMin;
                _yMax = max > _yMax ? max : _yMax;
            }

            if (_yMin < 0)
            {
                _lowVal = _yMin;
                _midVal = 0;
                _highVal = _yMax;
            }
            else
            {
                _lowVal = _yMin;
                _midVal = (_yMin + _yMax) / 2;
                _highVal = _yMax;
            }

            lowValueLabel.Text = Math.Round(_lowVal, 3).ToString();

            midValueLabel.Text = Math.Round(_midVal, 3).ToString();

            highValueLabel.Text = Math.Round(_highVal, 3).ToString();

            _chartWidth = _xMax - _xMin;
            _chartHeight = _yMax - _yMin;
            _chartScaleOnX = _width / _chartWidth;
            _chartScaleOnY = _height / _chartHeight;
        }
        private GraphicsPath GetGraphicsPath()
        {
            GraphicsPath path = new();

            if (Padding.All!=0)
            {
                int arcSize = Padding.All * 2;

                Rectangle NWArc = new(Padding.All, Padding.All, arcSize, arcSize);

                Rectangle NEArc = new(Width - arcSize - Padding.All, Padding.All, arcSize, arcSize);

                Rectangle SWArc = new(Padding.All, Height - arcSize - Padding.All, arcSize, arcSize);

                Rectangle SEArc = new(Width - arcSize - Padding.All, Height - arcSize - Padding.All, arcSize, arcSize);

                path.StartFigure();

                path.AddArc(SEArc, 0, 90);
                path.AddArc(SWArc, 90, 90);
                path.AddArc(NWArc, 180, 90);
                path.AddArc(NEArc, 270, 90);

                path.CloseFigure();
            }

            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.FillPath(new SolidBrush(SettingsManager.BackGroundColor()), _graphicsPath);

            if (_device != null && _enabledCharts.ContainsValue(true))
            {
                Point chartPointPrevious, chartPoint;

                Pen gridPen = new Pen(SettingsManager.HeaderColor(), 1 );

                e.Graphics.DrawLine(gridPen,
                    new Point(Padding.Left * 2 + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_lowVal - _yMin) * _chartScaleOnY)),
                    new Point(Padding.Left * 2 + _width + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_lowVal - _yMin) * _chartScaleOnY)));

                lowValueLabel.Location = new Point(lowValueLabel.Location.X, Padding.Top * 2 + (int)(_height - (_lowVal - _yMin) * _chartScaleOnY) - lowValueLabel.Height / 2);

                e.Graphics.DrawLine(gridPen,
                    new Point(Padding.Left * 2 + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_midVal - _yMin) * _chartScaleOnY)),
                    new Point(Padding.Left * 2 + _width + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_midVal - _yMin) * _chartScaleOnY)));

                midValueLabel.Location = new Point(midValueLabel.Location.X, Padding.Top * 2 + (int)(_height - (_midVal - _yMin) * _chartScaleOnY) - midValueLabel.Height / 2);

                e.Graphics.DrawLine(gridPen,
                    new Point(Padding.Left * 2 + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_highVal - _yMin) * _chartScaleOnY)),
                    new Point(Padding.Left * 2 + _width + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (_highVal - _yMin) * _chartScaleOnY)));

                highValueLabel.Location = new Point(highValueLabel.Location.X, Padding.Top * 2 + (int)(_height - (_highVal - _yMin) * _chartScaleOnY) - highValueLabel.Height / 2);

                foreach (Sensor deviceSensor in _device.sensors)
                {
                    if (!_enabledCharts[deviceSensor.GetType])
                    {
                        continue;
                    }

                    GraphicsPath graphicsPath = new();

                    double[] data = deviceSensor.GetData;

                    Pen pen = new Pen(new SolidBrush(SettingsManager.HighlightColor()),1);

                    chartPointPrevious = new Point(Padding.Left * 2 + _labelMaxWidth, Padding.Top * 2 + (int)(_height - (data[0] - _yMin) * _chartScaleOnY));

                    for (int i = 0; i < _timeSpan.Length; i++)
                    {
                        chartPoint = new Point(Padding.Left * 2 + (int)((_timeSpan[i] - _xMin) * _chartScaleOnX + _labelMaxWidth), Padding.Top * 2 + (int)(_height - (data[i] - _yMin) * _chartScaleOnY));
                        graphicsPath.AddLine(chartPointPrevious, chartPoint);
                        chartPointPrevious = chartPoint;
                    }

                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else
            {
                base.OnPaint(e);
                lowValueLabel.Text = "";
                midValueLabel.Text = "";
                highValueLabel.Text = "";
            }
        }

        private void ChartPanel_SizeChanged(object sender, EventArgs e)
        {
            _width = Width - chartController.Width - (Padding.Right + Padding.Left) * 2 - _labelMaxWidth;
            _height = Height - (Padding.Top + Padding.Bottom) * 2;

            _graphicsPath = GetGraphicsPath();

            if (_device != null)
            {
                CalculateBoundaries();
            }

            Refresh();
        }

        public void SetDevice(Device device)
        {
            _device = device;
            _enabledCharts.Clear();
            _timeSpan = device.timeSpan.GetData;

            foreach(Sensor sensor in _device.sensors)
            {
                _enabledCharts.Add(sensor.GetType, false);
            }
            foreach (KeyValuePair<string, bool> sensor in _enabledCharts.Reverse())
            {
                ChartControlPanel chartControlPanel = new();
                chartControlPanel.Dock = DockStyle.Top;
                chartControlPanel.SetSensorType(sensor.Key);
                chartControlPanel.chartPanel = this;
                chartController.Controls.Add(chartControlPanel);
            }
            CalculateBoundaries();
        }
        public void SetChartVisibility(string key, bool value)
        {
            if (_enabledCharts.ContainsKey(key))
            {
                _enabledCharts[key] = value;
            }

            if (_device != null)
            {
                CalculateBoundaries();
            }
            Refresh();
        }
    }
}
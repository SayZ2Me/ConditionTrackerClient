using ClientApplication.Classes;
using ClientApplication.Managers;
using ClientApplication.UserControls.ElementContainers;
using System.Drawing.Drawing2D;

namespace ClientApplication.UserControls.OutputHandlers
{
    public partial class DevicePanel : UserControl
    {
        private GraphicsPath GraphicsPath = new GraphicsPath();
        public Device device { get; set; }
        public DevicePanel()
        {
            InitializeComponent();
        }
        private GraphicsPath GetGraphicsPath()
        {
            int arcSize = Padding.All * 2;
            Rectangle NWArc = new(0, 0, arcSize, arcSize);
            Rectangle NEArc = new(Width - arcSize, 0, arcSize, arcSize);
            Rectangle SWArc = new(0, Height - arcSize, arcSize, arcSize);
            Rectangle SEArc = new(Width - arcSize, Height - arcSize, arcSize, arcSize);
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(SEArc, 0, 90);
            path.AddArc(SWArc, 90, 90);
            path.AddArc(NWArc, 180, 90);
            path.AddArc(NEArc, 270, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.FillPath(new SolidBrush(SettingsManager.BackGroundColor()), GraphicsPath);
        }
        private void DevicePanel_Load(object sender, EventArgs e)
        {
            GraphicsPath = GetGraphicsPath();

            DeviceID.Text = device.Id.ToString();
            DeviceName.Text = device.Name;
            DeviceIpAdress.Text = device.IPv4_adress;
            DeviceRealAdress.Text = device.Real_adress;
        }
        private void DevicePanel_Resize(object sender, EventArgs e)
        {
            GraphicsPath = GetGraphicsPath();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            DeviceOptions.Show(ButtonOptions, ButtonOptions.Width, 0);
        }

        private void OpenSensorTab_Click(object sender, EventArgs e)
        {
            if (device.sensors.Count == 0)
            {
                HttpManager.FetchSensors(device, User.GetInstance().AccessToken);
            }
            FormManager.Monitoring.CreateMasterChartPanel(device);
            FormManager.Main.LoadForm(FormManager.Monitoring);
        }
    }
}

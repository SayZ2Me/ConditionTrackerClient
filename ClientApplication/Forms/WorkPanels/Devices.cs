using ClientApplication.Classes;
using ClientApplication.Managers;
using ClientApplication.UserControls.ElementContainers;
using ClientApplication.UserControls.OutputHandlers;

namespace ClientApplication.Forms.WorkPanels
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }
        private void Devices_Load(object sender, EventArgs e)
        {
            scrollPanelVertical.Clear();
            base.BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);

            HttpManager.FetchDevices(User.GetInstance().AccessToken);

            ScrollPanelHorizontal scrollPanelHorizontal = new ScrollPanelHorizontal();

            foreach (Device device in Device.devices)
            {
                DevicePanel devicePanel = new DevicePanel();
                devicePanel.device = device;
                scrollPanelHorizontal.Add(devicePanel);
                devicePanel.Top = 20;
                devicePanel.Left = (devicePanel.Width + 20) * (scrollPanelHorizontal.contenPanel.Controls.Count - 1);
                devicePanel.SetDoubleBuffered();
                devicePanel.Invalidate();
                devicePanel.Refresh();
                devicePanel.Visible = true;
            }
            scrollPanelHorizontal.Dock = DockStyle.Bottom;
            scrollPanelHorizontal.Height = 217;
            scrollPanelVertical.Add(scrollPanelHorizontal);
            Refresh();
        }
        public override void Refresh()
        {
            base.Refresh();
            base.BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }
    }
}
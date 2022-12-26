using ClientApplication.Classes;
using ClientApplication.Managers;
using ClientApplication.UserControls.InputHandlers;
using ClientApplication.UserControls.OutputHandlers;

namespace ClientApplication.Forms.WorkPanels
{
    public partial class Monitoring : Form
    {
        private ChartPanel _masterChartPanel;
        public Monitoring()
        {
            InitializeComponent();
        }
        private void Monitoring_Load(object sender, EventArgs e)
        {
            base.BackColor = Managers.SettingsManager.BackGroundColor();
            Managers.SettingsManager.SetThemeColors(Controls);
        }
        public override void Refresh()
        {
            base.Refresh();
            base.BackColor = Managers.SettingsManager.BackGroundColor();
            Managers.SettingsManager.SetThemeColors(Controls);
        }
        private void CreateNewChartButton()
        {
            Panel panel = new Panel();
            panel.Size = new Size(100,65);
            panel.Padding = new Padding(10);
            panel.Dock = DockStyle.Top;

            ButtonCustom buttonCustom = new();
            buttonCustom.Size = new Size(100, 45);
            buttonCustom.Text = "+";
            buttonCustom.Font = new Font("Segoe UI",15,FontStyle.Bold);
            buttonCustom.Dock = DockStyle.Fill;
            buttonCustom.FlatStyle = FlatStyle.Flat;
            buttonCustom.Click += (sender, e) =>
            {
                ChartPanel chartPanel = _masterChartPanel.CreateCopy(new());

                chartPanel.SetDoubleBuffered();
                chartPanel.Dock = DockStyle.Top;
                chartPanel.Padding = new Padding(10);
                chartPanel.Refresh();

                scrollPanelVertical.Add(chartPanel);
                scrollPanelVertical.Refresh();

                FormManager.Main.LoadForm(FormManager.Monitoring);
            };
            panel.Controls.Add(buttonCustom);
            scrollPanelVertical.Add(panel);
        }
        public void CreateMasterChartPanel(Device device)
        {
            _masterChartPanel = new ChartPanel();
            _masterChartPanel.SetDevice(device);

            ChartPanel chartPanel = _masterChartPanel.CreateCopy(new());

            chartPanel.SetDoubleBuffered();
            chartPanel.Dock = DockStyle.Top;
            chartPanel.Padding = new Padding(10);
            chartPanel.Refresh();

            scrollPanelVertical.Clear();
            CreateNewChartButton();
            scrollPanelVertical.Add(chartPanel);
        }
    }
}
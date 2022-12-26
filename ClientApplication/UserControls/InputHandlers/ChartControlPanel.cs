using ClientApplication.UserControls.OutputHandlers;

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class ChartControlPanel : UserControl
    {
        public ChartPanel chartPanel;
        public ChartControlPanel()
        {
            InitializeComponent();
        }
        public void SetSensorType(string sensorType)
        {
            this.sensorType.Text = sensorType;
        }
        public string GetSensorType()
        {
            return sensorType.Text;
        }
        private void buttonToggle1_Click(object sender, EventArgs e)
        {
            chartPanel.SetChartVisibility(sensorType.Text, buttonSwitch.Checked);
        }
    }
}

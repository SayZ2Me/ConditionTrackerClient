using ClientApplication.Forms;
using ClientApplication.Services;
using System.Runtime.InteropServices;

namespace ClientApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(LoginPanel.Controls);
        }
        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsService.BackGroundColor();
            SettingsService.SetThemeColors(Controls);
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            Hide();
            FormManagerService.Main.Show();
        }
    }
}
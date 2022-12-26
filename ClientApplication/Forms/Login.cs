using ClientApplication.Forms;
using ClientApplication.Managers;
using ClientApplication.Classes;
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
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);

            if (Properties.Settings.Default.Email != null)
            {
                Email.Text = Properties.Settings.Default.Email;
                SaveEmailToggle.Checked = true;
            }
        }
        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (User.Login(Email.Text.ToString(), Password.Text.ToString()))
            {
                Hide();
                if (SaveEmailToggle.Checked)
                {
                    Properties.Settings.Default["Email"] = Email.Text.ToLower();
                }
                else
                {
                    Properties.Settings.Default["Email"] = "";
                }

                Password.Text = "";
                Properties.Settings.Default.Save();
                FormManager.Main.Show();
            }
            else
            {
                return;
            }
        }
    }
}
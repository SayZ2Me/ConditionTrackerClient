using ClientApplication.Managers;
using System.Runtime.InteropServices;

namespace ClientApplication.Forms.AuxiliaryForms
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        public void SetErrorMessage(string errorMessage) { ErrorMessage.Text = errorMessage; }
        public void SetErrorDescription(string errorDescription) { ErrorDescription.Text = errorDescription; }

        #region [ Window behavior DLL import ]

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        public override void Refresh()
        {
            base.Refresh();
            BackColor = SettingsManager.BackGroundColor();
            SettingsManager.SetThemeColors(Controls);
        }
    }
}
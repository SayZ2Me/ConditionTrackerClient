namespace ClientApplication.UserControls
{
    public partial class ButtonMaximize : UserControl
    {
        public ButtonMaximize()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.ButtonMaximize;
        }

        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            Screen screen = Screen.FromControl(this);
            if (ParentForm.WindowState == FormWindowState.Maximized)
            {
                ParentForm.WindowState = FormWindowState.Normal;
                ParentForm.Padding = new Padding(2);
            }
            else
            {
                ParentForm.WindowState = FormWindowState.Maximized;
                ParentForm.Padding = new Padding(8);
            }
        }

        private void Button_Maximize_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonMaximizeEnter;
        }

        private void Button_Maximize_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonMaximize;
        }
    }
}

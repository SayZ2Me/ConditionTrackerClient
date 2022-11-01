using ClientApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.UserControls
{
    public partial class ButtonClose : UserControl
    {
        public ButtonClose()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AppClose)
            {
                Application.Exit();
            }
            else
            {
                ParentForm.Hide();
            }
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonCloseEnter;
            BackColor = Color.IndianRed;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonClose;
            BackColor = Color.Transparent;
        }
    }
}

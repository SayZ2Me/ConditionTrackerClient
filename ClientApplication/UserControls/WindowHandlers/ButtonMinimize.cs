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
    public partial class ButtonMinimize : UserControl
    {
        public ButtonMinimize()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.ButtonMinimize;
        }
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void ButtonMinimize_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonMinimizeEnter;
        }

        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.ButtonMinimize;
        }
    }
}


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
    public partial class ButtonMaximize : UserControl
    {
        public ButtonMaximize()
        {
            InitializeComponent();
        }

        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                ParentForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
                ParentForm.Padding = new Padding(2);
            }
            else
            {
                ParentForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

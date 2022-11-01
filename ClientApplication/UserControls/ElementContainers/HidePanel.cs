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

namespace ClientApplication.UserControls.ElementContainers
{
    public partial class HidePanel : UserControl
    {
        bool Hided = true;
        Panel ParentPanel;
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Slide panel")]
        public int MaxWidth { get; set; }
        [Category("Slide panel")]
        public int MinWidth { get; set; }
        [Category("Slide panel")]
        public int Step { get; set; }
        public HidePanel()
        {
            InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                ParentPanel.Width += Step;
                if (ParentPanel.Width > MaxWidth - Step)
                {
                    Timer.Stop();
                    ParentPanel.Width = MaxWidth;
                    Hided = false;
                    BackgroundImage = Properties.Resources.IconLeftBig;
                }
            }
            else
            {
                ParentPanel.Width -= Step;
                if (ParentPanel.Width < MinWidth + Step)
                {
                    ParentPanel.Width = MinWidth;
                    Timer.Stop();
                    Hided = true;
                    BackgroundImage = Properties.Resources.IconRightBig;
                }
            }
        }
        private void HidePanel_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }
        private void HidePanel_Load(object sender, EventArgs e)
        {
            try
            {
                ParentPanel = (Panel)Parent;
                ParentPanel.Width = MinWidth;
            }
            catch (Exception)
            {
                throw new Exception("Slide panel button " + Name.ToString() + "on form" + ParentForm.Name.ToString() + " don`t have parent panel." );
            }
        }
        private void HidePanel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SettingsService.HighlightColor();
        }

        private void HidePanel_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}

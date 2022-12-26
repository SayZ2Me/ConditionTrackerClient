using ClientApplication.Classes;
using ClientApplication.UserControls.InputHandlers;

namespace ClientApplication.UserControls.ElementContainers
{
    public partial class ScrollPanelVertical : UserControl
    {
        public Panel contenPanel;
        public ScrollPanelVertical()
        {
            InitializeComponent();
            contenPanel = ContentPanel;
            contenPanel.MouseWheel += ContentPanel_MouseWheel;
            contenPanel.AutoScroll = true;
            scrollBarVertical.SetDoubleBuffered();
            scrollBarVertical.SetScaleFactor(contenPanel.VerticalScroll.Maximum);
            scrollBarVertical.Width = 17;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (contenPanel != null)
            {
                scrollBarVertical.SetScaleFactor(contenPanel.VerticalScroll.Maximum - contenPanel.Height);
                scrollBarVertical.SetBarPosition(contenPanel.VerticalScroll.Value);
                scrollBarVertical.Width = 17;
            }
        }
        public override void Refresh()
        {
            base.Refresh();
            //Sorry for this but i dont fckn know how to put custom scroll bar on top of default;
            Shake();
        }
        private void ContentPanel_MouseWheel(object sender, EventArgs e)
        {
            scrollBarVertical.SetBarPosition(contenPanel.VerticalScroll.Value) ;
        }
        public void Clear()
        {
            contenPanel.Controls.Clear();
        }
        public void Add(Control control)
        {
            contenPanel.Controls.Add(control);
        }
        private void Shake()
        {
            Height += 1;
            Height -= 1;
        }
    }
}

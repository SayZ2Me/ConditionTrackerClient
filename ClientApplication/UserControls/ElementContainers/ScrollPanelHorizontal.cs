using ClientApplication.Classes;

namespace ClientApplication.UserControls.ElementContainers
{
    public partial class ScrollPanelHorizontal : UserControl
    {
        public Panel contenPanel;
        public ScrollPanelHorizontal()
        {
            InitializeComponent();
            contenPanel = ContentPanel;
            contenPanel.MouseWheel += ContentPanel_MouseWheel;
            contenPanel.AutoScroll = true;
            scrollBarHorizontal.SetDoubleBuffered();
            scrollBarHorizontal.SetScaleFactor(contenPanel.HorizontalScroll.Maximum);
            scrollBarHorizontal.Height = 17;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (contenPanel != null)
            {
                scrollBarHorizontal.SetScaleFactor(contenPanel.HorizontalScroll.Maximum - contenPanel.Width);
                scrollBarHorizontal.SetBarPosition(contenPanel.HorizontalScroll.Value);
                scrollBarHorizontal.Height = 17;
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
            scrollBarHorizontal.SetBarPosition(contenPanel.HorizontalScroll.Value);
        }
        public void Clear()
        {
            contenPanel.Controls.Clear();
        }
        public void Add(UserControl control)
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

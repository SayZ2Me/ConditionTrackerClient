using System.ComponentModel;

namespace ClientApplication.UserControls.ElementContainers
{
    public partial class HidePanel : UserControl
    {
        private bool _hided = true;
        private Panel _parentPanel;

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Параметры анимации")]
        public int MaxWidth { get; set; }
        [Category("Параметры анимации")]
        public int MinWidth { get; set; }
        [Category("Параметры анимации")]
        public int Step { get; set; }
        [Category("Внешний вид")]
        public Image IconShowDark { get; set; }
        [Category("Внешний вид")]
        public Image IconShowLight { get; set; }
        [Category("Внешний вид")]
        public Image IconShowMain { get; set; }
        [Category("Внешний вид")]
        public Image IconHideDark { get; set; }
        [Category("Внешний вид")]
        public Image IconHideLight { get; set; }
        [Category("Внешний вид")]
        public Image IconHideMain { get; set; }
        public HidePanel()
        {
            InitializeComponent();
        }
        private void SetResources()
        {
            if (_hided)
            {
                HidePanelButton.IconDark = IconShowDark;
                HidePanelButton.IconLight = IconShowLight;
                HidePanelButton.IconHighLight = IconShowMain;
            }
            else
            {
                HidePanelButton.IconDark = IconHideDark;
                HidePanelButton.IconLight = IconHideLight;
                HidePanelButton.IconHighLight = IconHideMain;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_hided)
            {
                _parentPanel.Width += Step;
                if (_parentPanel.Width > MaxWidth - Step)
                {
                    Timer.Stop();
                    _parentPanel.Width = MaxWidth;
                    _hided = false;
                    SetResources();
                }
            }
            else
            {
                _parentPanel.Width -= Step;
                if (_parentPanel.Width < MinWidth + Step)
                {
                    _parentPanel.Width = MinWidth;
                    Timer.Stop();
                    _hided = true;
                    SetResources();
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
                _parentPanel = (Panel)Parent;
                _parentPanel.Width = MinWidth;
            }
            catch (Exception)
            {
                throw new Exception("Slide panel button " + Name.ToString() + "on form" + ParentForm.Name.ToString() + " don`t have parent panel." );
            }
            SetResources();
        }
    }
}

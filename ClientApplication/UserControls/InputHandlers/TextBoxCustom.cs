using ClientApplication.Classes;
using ClientApplication.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class TextBoxCustom : UserControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Input field")]
        public override string Text
        {
            get { return InputField.Text; }
            set { InputField.Text = value; }
        }
        public string PlaceholderText
        {
            get { return InputField.PlaceholderText; }
            set { InputField.PlaceholderText = value; }
        }
        public override System.Drawing.Image BackgroundImage
        {
            get { return Image.BackgroundImage; }
            set { Image.BackgroundImage = value; }
        }
        [Category("Input field")]
        public bool UseSystemPasswordChar
        {
            get { return InputField.UseSystemPasswordChar; }
            set {
                InputField.UseSystemPasswordChar = value;
                if (value)
                {
                    Option.Size = new Size(40, 40);
                    Option.Enabled = true;
                }
                else
                {
                    Option.Size = new Size(0, 40);
                    Option.Enabled = false;
                }
            }
        }
        public TextBoxCustom()
        {
            InitializeComponent();
        }
        private void SetResources(bool hided)
        {
            if (hided)
            {
                Option.IconDark = Properties.Resources.IconUnhideDark;
                Option.IconLight = Properties.Resources.IconUnhideLight;
                Option.IconHighLight = Properties.Resources.IconUnhideMain;
            }
            else
            {
                Option.IconDark = Properties.Resources.IconHideDark;
                Option.IconLight = Properties.Resources.IconHideLight;
                Option.IconHighLight = Properties.Resources.IconHideMain;
            }
        }
        private void Option_Click(object sender, EventArgs e)
        {
            InputField.UseSystemPasswordChar = !InputField.UseSystemPasswordChar;
            SetResources(InputField.UseSystemPasswordChar);
        }
        public override void Refresh()
        {
            base.Refresh();
            InputField.BackColor = SettingsManager.BackGroundColor();
            InputField.ForeColor = SettingsManager.TextColor();
            InputFIeldContainer.BackColor = SettingsManager.BackGroundColor();
            Image.BackColor = SettingsManager.BackGroundColor();
            Option.BackColor = SettingsManager.BackGroundColor();
        }
    }
}

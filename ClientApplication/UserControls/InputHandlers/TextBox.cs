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
using static System.Net.Mime.MediaTypeNames;

namespace ClientApplication.UserControls.InputHandlers
{
    public partial class TextBox : UserControl
    {
        [Browsable(false)]
        public string GetText
        {
            get { return InputField.Text; }
        }
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Category("Input field")]
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
        public TextBox()
        {
            InitializeComponent();
        }

        private void TextBox_Load(object sender, EventArgs e)
        {
            BackColor = SettingsService.PanelColor();
            InputField.BackColor = SettingsService.PanelColor();
            InputField.ForeColor = SettingsService.TextColor();
            Underscore.BackColor = SettingsService.TextColor();
        }
        private void Option_Click(object sender, EventArgs e)
        {
            InputField.UseSystemPasswordChar = !InputField.UseSystemPasswordChar;
            if (InputField.UseSystemPasswordChar)
            {
                Option.BackgroundImage = Properties.Resources.IconUnhide;
            }
            else
            {
                Option.BackgroundImage = Properties.Resources.IconHide;
            }
        }
    }
}

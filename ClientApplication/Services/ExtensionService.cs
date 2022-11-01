using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Services
{
    internal static class ExtensionService
    {
        public static IEnumerable<Control> All(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                foreach (Control childControl in control.Controls.All())
                {
                    yield return childControl;
                }
                yield return control;
            }
        }
        public static Image ConvertColor(Image image ,Color newColor)
        {
            if (image.Width > 255 || image.Height > 255)
            {
                throw new Exception("Image color converter exception, image is too big");
            }
            Bitmap convertedImage = new Bitmap(image);
            for (byte y = 0; y < convertedImage.Height; y++)
            {
                for (byte x = 0; x < convertedImage.Width; x++)
                {
                    Color PixelColor = convertedImage.GetPixel(x, y);
                    convertedImage.SetPixel(x, y, Color.FromArgb(PixelColor.A, newColor.R, newColor.G, newColor.B));
                }
            }
            return convertedImage;
        }
    }
}

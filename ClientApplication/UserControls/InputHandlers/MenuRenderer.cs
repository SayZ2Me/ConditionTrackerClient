using ClientApplication.Classes;
using System;
using System.Collections.Generic;
using ClientApplication.Managers;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.UserControls.InputHandlers
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness = 2;
        public MenuRenderer() : base(new MenuColorTable())
        {
            primaryColor = SettingsManager.MainColor();
            textColor = SettingsManager.TextColor();
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? ColorTranslator.FromHtml("#ff303238") : SettingsManager.TextColor();
            e.Item.BackColor = SettingsManager.BackGroundColor();
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? SettingsManager.BackGroundColor() : SettingsManager.MainColor();
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2, arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath()) using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}
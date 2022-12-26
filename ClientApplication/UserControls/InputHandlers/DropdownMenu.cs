using ClientApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.UserControls.InputHandlers
{
    public class DropdownMenu : ContextMenuStrip
    {
        private bool _isMainMenu;
        private int _menuItemHeight = 25;
        private Color _menuItemTextColor = Color.Empty;
        private Color _primaryColor = Color.Empty;
        private Bitmap _menuItemHeaderSize;
        public DropdownMenu(IContainer container)
            : base(container)
        {
        }
        [Browsable(false)]
        public bool IsMainMenu
        {
            get { return _isMainMenu; }
            set { _isMainMenu = value; }
        }
        [Browsable(false)]
        public int MenuItemHeight
        {
            get { return _menuItemHeight; }
            set { _menuItemHeight = value; }
        }
        [Browsable(false)]
        public Color MenuItemTextColor
        {
            get { return _menuItemTextColor; }
            set { _menuItemTextColor = value; }
        }
        [Browsable(false)]
        public Color PrimaryColor
        {
            get { return _primaryColor; }
            set { _primaryColor = value; }
        }
        private void LoadMenuItemHeight()
        {
            if (_isMainMenu)
                _menuItemHeaderSize = new Bitmap(25, 45);
            else _menuItemHeaderSize = new Bitmap(20, _menuItemHeight);
            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = _menuItemHeaderSize;
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer();
                LoadMenuItemHeight();
            }
        }
    }
}
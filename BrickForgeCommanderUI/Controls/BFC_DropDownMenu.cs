using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BrickForgeCommanderUI.Controls
{
    public class BFC_DropDownMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;

        public BFC_DropDownMenu(IContainer container) : base(container)
        {

        }

        public bool IsMainMenu 
        {
            get
            {
                return isMainMenu;
            }
            set
            { 
                isMainMenu = value; 
            }
        }
        public int MenuItemHeight 
        {
            get 
            { 
                return menuItemHeight; 
            }
            set
            {
                menuItemHeight = value;
            }
        }
        public Color MenuItemTextColor 
        {
            get
            {
                return menuItemTextColor;
            }
            set 
            { 
                menuItemTextColor = value; 
            }
        }
        public Color PrimaryColor 
        {
            get 
            { 
                return  primaryColor; 
            }
            set
            {
                primaryColor = value;
            }
        }

        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }

            foreach (ToolStripMenuItem menuItem1 in this.Items)
            {
                menuItem1.ForeColor = menuItemTextColor;
                menuItem1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItem1.Image == null) menuItem1.Image = menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItem2 in menuItem1.DropDownItems)
                {
                    menuItem2.ForeColor = menuItemTextColor;
                    menuItem2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItem2.Image == null) menuItem2.Image = menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItem3 in menuItem2.DropDownItems)
                    {
                        menuItem3.ForeColor = menuItemTextColor;
                        menuItem3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItem3.Image == null) menuItem3.Image = menuItemHeaderSize;

                        foreach (ToolStripMenuItem menuItem4 in menuItem3.DropDownItems)
                        {
                            menuItem4.ForeColor = menuItemTextColor;
                            menuItem4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItem4.Image == null) menuItem4.Image = menuItemHeaderSize;
                        }
                    }
                }
            } 
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(IsMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}

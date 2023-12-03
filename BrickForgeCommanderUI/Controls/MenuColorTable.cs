using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BrickForgeCommanderUI.Controls
{
    public class MenuColorTable : ProfessionalColorTable
    {
        private Color backColor;
        private Color leftcolumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if(isMainMenu)
            {
                backColor = Color.FromArgb(37, 39, 60);
                leftcolumnColor = Color.FromArgb(32, 33, 51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftcolumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectedColor;
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return leftcolumnColor;
            }
        }

        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return leftcolumnColor;
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return leftcolumnColor;
            }
        }
    }
}

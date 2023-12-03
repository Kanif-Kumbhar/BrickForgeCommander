using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickForgeCommanderUI.Controls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;

        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if(isMainMenu ) arrowThickness = 3;
            else arrowThickness = 2;
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : primaryColor; e.Item.ForeColor = textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var graph = e.Graphics;
            var ArrowSize = new Size(5, 12);
            var ArrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-ArrowSize.Height)/2,ArrowSize.Width, ArrowSize.Height);
            using(GraphicsPath path = new GraphicsPath())
                using (Pen pen = new Pen(ArrowColor, arrowThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left,rect.Top,rect.Right,rect.Top + rect.Height/2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2,rect.Left,rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}

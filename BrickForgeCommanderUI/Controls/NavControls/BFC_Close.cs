using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Controls.NavControls
{
    public class BFC_Close : BFC_Button
    {
        public BFC_Close()
        {
            this.Text = " ";
            this.Size = new Size(75, 37);
            this.Image = Properties.Resources.icons8_close_24;
            this.Click += BFC_Close_Click;
            this.BorderRadius = 0;
        }

        private void BFC_Close_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            if (form != null)
            {
                form.Close();
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (this.Parent != null && this.Parent is Panel)
            {
                this.BackColor = ((Panel)this.Parent).BackColor;
            }
        }
    }
}

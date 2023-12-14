using System;
using System.Collections.Generic;
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
            this.Image = Properties.Resources.icons8_close_24;
            this.Click += BFC_Close_Click;
        }

        private void BFC_Close_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            if (form != null)
            {
                form.Close();
            }
        }
    }
}

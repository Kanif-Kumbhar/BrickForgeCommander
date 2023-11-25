using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.MasterForms
{
    public partial class frmVendorTypeDetails : Form
    {
        public frmVendorTypeDetails()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Load += frmVendorTypeDetails_Load;
        }

        private void frmVendorTypeDetails_Load(object sender, EventArgs e)
        {
            int radius = 50; // Adjust the radius as needed
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);
        }

        #region Buttons Click Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void txtVendorTypeId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

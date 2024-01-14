using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.MasterForms.Menu
{
    public partial class frmMasterMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     
           int nTopRect,      
           int nRightRect,    
           int nBottomRect,    
           int nWidthEllipse, 
           int nHeightEllipse  
       );
        public frmMasterMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmMasterMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVendorTypeDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void bfC_Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

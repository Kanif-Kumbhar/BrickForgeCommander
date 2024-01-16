using BrickForgeCommanderUI.Controls;
using BrickForgeCommanderUI.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using BrickForgeCommanderUI.Forms.MasterForms.MasterHelper;

namespace BrickForgeCommanderUI.Forms.MasterForms.Master
{
    public partial class frmVenderTypeDetails : Form
    {
        private readonly SqlConnection connection;
        private readonly SqlDataAdapter adapter;
        private readonly DataTable dataTable;

        private readonly KeyHandler keyHandler;
        private bool aKeyPressed = false;
        private bool bCtrlKeyPressed = false;

        public frmVenderTypeDetails()
        {
            InitializeComponent();

            keyHandler = new KeyHandler();
        }

        private void frmVenderTypeDetails_Load(object sender, EventArgs e)
        {
            dgvVenderTypeDetails.DefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);
            dgvVenderTypeDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);

            keyHandler.AddKeyAction(Keys.A, () => btnUndo.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.B, Keys.Control }, () => btnRedo.PerformClick());

            this.KeyDown += frmVenderTypeDetails_KeyDown;
            this.KeyUp += frmVenderTypeDetails_KeyUp;

            SqlCommandHelper.DisplayData("VendorTypeDetails",dgvVenderTypeDetails,dataTable);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.InsertData(txtVenderTypeName, "VendorTypeDetails");
            SqlCommandHelper.DisplayData("VendorTypeDetails",dgvVenderTypeDetails,dataTable);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.DeleteData(txtVenderTypeId,"VendorTypeDetails");
        }


        private void frmVenderTypeDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.None)
            {
                if (!aKeyPressed)
                {
                    btnUndo.PerformClick();
                    aKeyPressed = true;
                }
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                if (!bCtrlKeyPressed)
                {
                    btnRedo.PerformClick();
                    bCtrlKeyPressed = true;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HHH");
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HjH");
        }

        private void frmVenderTypeDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.None)
            {
                aKeyPressed = false;
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                bCtrlKeyPressed = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.UpdateData(txtVenderTypeId,txtVenderTypeName,"VendorTypeDetails");
        }

        private void dgvVenderTypeDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenderTypeDetails.SelectedRows.Count > 0)
            {
                // Change the background color of the selected row
                dgvVenderTypeDetails.SelectedRows[0].DefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95); 
                // Optionally, you can also change the text color
                dgvVenderTypeDetails.SelectedRows[0].DefaultCellStyle.ForeColor = Color.LightYellow;
            }
        }
    }
}

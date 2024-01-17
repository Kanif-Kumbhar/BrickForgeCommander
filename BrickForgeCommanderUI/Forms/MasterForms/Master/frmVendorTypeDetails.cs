using BrickForgeCommanderUI.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BrickForgeCommanderUI.Forms.MasterForms.MasterHelper;

namespace BrickForgeCommanderUI.Forms.MasterForms.Master
{
    public partial class frmVendorTypeDetails : Form
    {
        private readonly DataTable dataTable;
        private readonly string tableName = "VendorTypeDetails";

        private readonly KeyHandler keyHandler;
        private bool aKeyPressed = false;
        private bool bCtrlKeyPressed = false;

        public frmVendorTypeDetails()
        {
            InitializeComponent();
            keyHandler = new KeyHandler();
        }

        #region Form Events

        private void frmVendorTypeDetails_Load(object sender, EventArgs e)
        {
            dgvVendorTypeDetails.DefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);
            dgvVendorTypeDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);

            keyHandler.AddKeyAction(new List<Keys> { Keys.I, Keys.Control }, () => btnInsert.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.U, Keys.Control }, () => btnUpdate.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.D, Keys.Control }, () => btnDelete.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Delete, Keys.Control }, () => btnClear.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Next, Keys.Control }, () => btnRedo.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Back, Keys.Control }, () => btnRedo.PerformClick());

            this.KeyDown += frmVendorTypeDetails_KeyDown;
            this.KeyUp += frmVendorTypeDetails_KeyUp;

            lblVendorTypeId.Text = (SqlCommandHelper.GetId(tableName)+1).ToString();
        }

        private void frmVendorTypeDetails_Activated(object sender, EventArgs e)
        {
            SqlCommandHelper.DisplayData(tableName, dgvVendorTypeDetails, dataTable);
        }
       
        private void frmVendorTypeDetails_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I when e.Modifiers == Keys.Control && !aKeyPressed:
                    btnInsert.PerformClick();
                    aKeyPressed = true;
                    break;

                case Keys.U when e.Control && !bCtrlKeyPressed:
                    btnUpdate.PerformClick();
                    bCtrlKeyPressed = true;
                    break;

                case Keys.D when e.Control && !bCtrlKeyPressed:
                    btnDelete.PerformClick();
                    bCtrlKeyPressed = true;
                    break;

                case Keys.Delete when e.Control && !bCtrlKeyPressed:
                    btnClear.PerformClick();
                    bCtrlKeyPressed = true;
                    break;

                case Keys.Next when e.Control && !bCtrlKeyPressed:
                    btnForward.PerformClick();
                    bCtrlKeyPressed = true;
                    break;

                case Keys.Back when e.Control && !bCtrlKeyPressed:
                    btnBackWard.PerformClick();
                    bCtrlKeyPressed = true;
                    break;
            }
        }

        #endregion
       
        #region Button Events

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.InsertData(txtVendorTypeName, tableName);
            SqlCommandHelper.DisplayData(tableName,dgvVendorTypeDetails,dataTable);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.UpdateData(lblVendorTypeId,txtVendorTypeName,tableName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.DeleteData(lblVendorTypeId,tableName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVendorTypeName.Texts = string.Empty;
            lblVendorTypeId.Text = (SqlCommandHelper.GetId(tableName) + 1).ToString();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<frmCityDetails>();
            this.Hide();
        }
       
        private void frmVendorTypeDetails_KeyUp(object sender, KeyEventArgs e)
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
        

        #endregion

        #region DataGridView Events

        private void dgvVendorTypeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblVendorTypeId.Text = dgvVendorTypeDetails.SelectedCells[0].Value.ToString();
            MasterControlHelper.CellSingleClick(lblVendorTypeId,tableName,dgvVendorTypeDetails,e);
        }
        
        private void dgvVendorTypeDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MasterControlHelper.CellDoubleClick(lblVendorTypeId,txtVendorTypeName ,tableName, dgvVendorTypeDetails, e);
        }

        #endregion


    }
}

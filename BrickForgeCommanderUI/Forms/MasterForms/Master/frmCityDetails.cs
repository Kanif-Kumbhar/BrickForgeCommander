﻿using BrickForgeCommanderUI.Forms.MasterForms.MasterHelper;
using BrickForgeCommanderUI.Helpers;
using BrickForgeCommanderUI.Login___Registeration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Forms.MasterForms.Master
{
    public partial class frmCityDetails : Form
    {
        private readonly DataTable dataTable;
        private readonly string tableName = "CityDetails";

        private readonly KeyHandler keyHandler;
        private bool aKeyPressed = false;
        private bool bCtrlKeyPressed = false;

        public frmCityDetails()
        {
            InitializeComponent();
            keyHandler = new KeyHandler();
        }

        #region Form Events

        private void frmVendorTypeDetails_Load(object sender, EventArgs e)
        {
            dgvCityDetails.DefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);
            dgvCityDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);

            keyHandler.AddKeyAction(new List<Keys> { Keys.I, Keys.Control }, () => btnInsert.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.U, Keys.Control }, () => btnUpdate.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.D, Keys.Control }, () => btnDelete.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Delete, Keys.Control }, () => btnClear.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Next, Keys.Control }, () => btnRedo.PerformClick());
            keyHandler.AddKeyAction(new List<Keys> { Keys.Back, Keys.Control }, () => btnRedo.PerformClick());

            this.KeyDown += frmVendorTypeDetails_KeyDown;
            this.KeyUp += frmVendorTypeDetails_KeyUp;

            lblCityId.Text = (SqlCommandHelper.GetId(tableName) + 1).ToString();
        }

        private void frmVendorTypeDetails_Activated(object sender, EventArgs e)
        {
            SqlCommandHelper.DisplayData(tableName, dgvCityDetails, dataTable);
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
            SqlCommandHelper.InsertData(txtCityName, tableName);
            SqlCommandHelper.DisplayData(tableName, dgvCityDetails, dataTable);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.UpdateData(lblCityId, txtCityName, tableName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommandHelper.DeleteData(lblCityId, tableName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCityName.Texts = string.Empty;
            lblCityId.Text = (SqlCommandHelper.GetId(tableName) + 1).ToString();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<frmLogin>();
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
            lblCityId.Text = dgvCityDetails.SelectedCells[0].Value.ToString();
            MasterControlHelper.CellSingleClick(lblCityId, tableName, dgvCityDetails, e);
        }

        private void dgvVendorTypeDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MasterControlHelper.CellDoubleClick(lblCityId, txtCityName, tableName, dgvCityDetails, e);
        }

        #endregion


    }
}

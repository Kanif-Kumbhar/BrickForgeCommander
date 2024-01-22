﻿using System.Windows.Forms;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration
{
    public partial class frmWorkersRegistration : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        public frmWorkersRegistration()
        {
            InitializeComponent();
            this.Icon = null;
        }

        #region Borderless Form

        private void frmWorkersRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void frmWorkersRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void btnMaximize_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void frmWorkersRegistration_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'brickForgeCommanderDBDataSet.CityDetails' table. You can move, or remove it, as needed.
            //this.cityDetailsTableAdapter.Fill(this.brickForgeCommanderDBDataSet.CityDetails);
            // TODO: This line of code loads data into the 'brickForgeCommanderDBDataSet.CityDetails' table. You can move, or remove it, as needed.
            //this.cityDetailsTableAdapter.Fill(this.brickForgeCommanderDBDataSet.CityDetails);

        }

        private void requiredFieldTextBox1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, System.EventArgs e)
        {
            dgvDocument.Rows.Add();
        }

        private void frmWorkersRegistration_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        #endregion
    }
}

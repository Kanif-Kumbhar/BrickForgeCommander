using BrickForgeCommanderUI.Presenters.CommonPresenters;
using System;
using System.Windows.Forms;
using BrickForgeCommanderUI.Interface.CommonInterface;
using System.Collections.Generic;
using System.ComponentModel;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration
{
    public partial class frmWorkersRegistration : Form, IDocumentView
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private readonly DocumentPresenter _presenter;

        public event Action<string, byte[]> UploadDocument;
        public event Action<string> PreviewDocument;
        public frmWorkersRegistration()
        {
            InitializeComponent();
            this.Icon = null;
            _presenter = new DocumentPresenter(this);
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

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdateDataGridView(List<string> documentNames)
        {
            dgvDocument.DataSource = new BindingSource(new BindingList<string>(documentNames), null);
        }
    }
}

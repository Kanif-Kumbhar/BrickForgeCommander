using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BrickForgeCommanderUI.Helpers;

namespace BrickForgeCommanderUI.Forms.Misc
{
    public partial class frmPreviewImage : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        public frmPreviewImage()
        {
            InitializeComponent();
            this.Icon = null;

            DocumentUploader.GetDocumentTable();
            ShowImage();
        }

        private void ShowImage()
        {
            DataTable selectedDocumentTable = DocumentUploader.GetDocumentTable();

            if (selectedDocumentTable.Rows.Count > 0)
            {
                string filePath = selectedDocumentTable.Rows[0]["FilePath"].ToString();

                Image image = Image.FromFile(filePath);
                picImage.Image = image;
            }
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

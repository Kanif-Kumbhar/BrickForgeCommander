using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using BrickForgeCommanderUI.Helpers;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration
{
    public partial class frmWorkersRegistration : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        private DataTable documentTable;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ConnectionString;
        private string image;

        public frmWorkersRegistration()
        {
            InitializeComponent();
            InitializeComponents();
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



        private void frmWorkersRegistration_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        #endregion
        private void frmWorkersRegistration_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'worker.CityDetails' table. You can move, or remove it, as needed.
            this.cityDetailsTableAdapter.Fill(this.worker.CityDetails);
            // TODO: This line of code loads data into the 'worker.WorkerRoleDetails' table. You can move, or remove it, as needed.
            this.workerRoleDetailsTableAdapter.Fill(this.worker.WorkerRoleDetails);
            // TODO: This line of code loads data into the 'worker.BatchDetails' table. You can move, or remove it, as needed.
            this.batchDetailsTableAdapter.Fill(this.worker.BatchDetails);

        }

        #region Events

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dgvDocument.Rows.Add();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            int age = CalculateAge(dtpDOB.Value, DateTime.Now);
            txtAge.Texts = age.ToString();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        private void dgvDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentUploader.UploadDocument(dgvDocument,e);
            DocumentUploader.PreviewDocument(pnlMain,dgvDocument,e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateUpload();
            UploadDocument();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

        #region Functions

        private void InitializeComponents()
        {
            cbxBloodGroup.Items.AddRange(new object[] { "A+", "O+","B+", "AB+", "A-", "O-", "B-", "AB-" });
        }

        static int CalculateAge(DateTime birthdate, DateTime currentDate)
        {
            int age = currentDate.Year - birthdate.Year;

            if (birthdate.Date > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void InsertData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string[] name = SplitFullName(txtName.Texts);
                    string firstName = name[0];
                    string middleName = name[1];
                    string lastName = name[2];
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("BFC.usp_InsertVendorData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Address", txtAddress.Texts);
                        

                        if (cbxCity.SelectedItem != null && cbxCity.SelectedItem is DataRowView)
                        {
                            DataRowView selectedCity = (DataRowView)cbxCity.SelectedItem;
                            int cityId = Convert.ToInt32(selectedCity["CityId"]);
                            command.Parameters.AddWithValue("@CityId", cityId);
                        }

                        command.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
                        command.Parameters.AddWithValue("@Image", image);

                        if (cbxBatch.SelectedItem != null && cbxBatch.SelectedItem is DataRowView)
                        {
                            DataRowView selectedBatch = (DataRowView)cbxBatch.SelectedItem;
                            int batchId = Convert.ToInt32(selectedBatch["BatchId"]);
                            command.Parameters.AddWithValue("@BatchId", batchId);
                        }

                        // Remove the duplicate declaration of UserId
                        if (cbxRole.SelectedItem != null && cbxRole.SelectedItem is DataRowView)
                        {
                            DataRowView selectedRole = (DataRowView)cbxRole.SelectedItem;
                            int roleId = Convert.ToInt32(selectedRole["RoleId"]);
                            command.Parameters.AddWithValue("@RoleId", roleId);
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Successfully!", "Registration Complete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Upload Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadDocument()
        {
            if (documentTable != null && documentTable.Rows.Count > 0)
            {
                documentTable = new DataTable("Documents");
                documentTable = DocumentUploader.GetDataTable();
                foreach (DataRow row in documentTable.Rows)
                {
                    string documentName = row["DocumentName"].ToString();
                    string filePath = row["FilePath"].ToString();

                    StoreDocumentToDataBase(documentName, filePath);
                }
            }
        }

        private void StoreDocumentToDataBase(string documentName, string documentImage)
        {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("BFC.usp_UploadDocument", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@DocumentName", documentName);
                            command.Parameters.AddWithValue("@DocumentImage", documentImage);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e)
                {
                   MessageBox.Show(e.Message,"Upload Fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }

        static string[] SplitFullName(string fullName)
        {
            string[] nameParts = new string[3];

            string[] splitNames = fullName.Split(' ');

            nameParts[0] = splitNames.Length > 0 ? splitNames[0] : "";
            nameParts[1] = splitNames.Length > 2 ? splitNames[1] : "";
            nameParts[2] = splitNames.Length > 1 ? splitNames[splitNames.Length - 1] : "";

            return nameParts;
        }

        private void UploadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Upload Image";
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    FileInfo fileInfo = new FileInfo(filePath);
                    long fileSizeInBytes = fileInfo.Length;
                    long fileSizeInKb = fileSizeInBytes / 1024;

                    if (fileSizeInKb > 500)
                    {
                        MessageBox.Show("Image size should be below 500KB.");
                        return;
                    }

                    image = filePath;
                    picWorkerPhoto.ImageLocation = image;
                }
            }
        }

        private void ValidateUpload()
        {
            if (!string.IsNullOrEmpty(txtName.Texts) &&
                !string.IsNullOrWhiteSpace(txtPhoneNo.Text) &&
                cbxRole.SelectedItem != null &&
                cbxBatch.SelectedItem != null &&
                cbxCity.SelectedItem != null &&
                image != null) 
            {
                InsertData();
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields and upload an image.", "Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtName.Texts = "";
            txtAddress.Texts = "";
            txtPhoneNo.Text = "";
            txtAge.Texts = "";

            dtpDOB.Value = DateTime.Now;

            cbxBatch.SelectedItem = null;
            cbxCity.SelectedItem = null;
            cbxRole.SelectedItem = null;
            cbxBloodGroup.SelectedItem = null;

            picWorkerPhoto.Image = null;

            dgvDocument.Rows.Clear();
        }

        #endregion
    }
}

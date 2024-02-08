using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using BrickForgeCommanderUI.Forms.TransactionForms.Worker.WorkerRegistration;
using BrickForgeCommanderUI.Helpers;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Worker
{
    public partial class frmStaffList : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        private bool isDragging = false;
        private int mouseX, mouseY;
        public DataTable dataTable = new DataTable("WorkerInfo");
        public frmStaffList()
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

       

        private void frmWorkersRegistration_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
       
        #endregion

        #region Events

        private void btnNewRegistration_Click(object sender, System.EventArgs e)
        {
            FormHelper.OpenForm<frmWorkersRegistration>(pnlMain);
        }

        private void frmStaffList_Load(object sender, System.EventArgs e)
        {
            GetStaffList();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            SearchStaff();
        }

        private void btnRefesh_Click(object sender, System.EventArgs e)
        {
            GetStaffList();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStaff.Columns["clmName"].Index && e.RowIndex >= 0)
            {
                // Access the value in the clicked cell in the "clmName" column
                string clickedName = dgvStaff.Rows[e.RowIndex].Cells["clmName"].Value.ToString();
                string selectQuery = "SELECT * FROM BFC.StaffList";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (DataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        dataTable.Clear();

                    }
                }
            }
        }
        #endregion

        #region Functions

        private void GetStaffList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BFC.StaffList";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvStaff.Rows.Clear();

                        while (reader.Read())
                        {
                            int rowIndex = dgvStaff.Rows.Add();

                            dgvStaff.Rows[rowIndex].Cells["clmId"].Value = rowIndex + 1;
                            dgvStaff.Rows[rowIndex].Cells["clmName"].Value = reader["VendorName"];
                            dgvStaff.Rows[rowIndex].Cells["clmAddress"].Value = reader["Address"];
                            dgvStaff.Rows[rowIndex].Cells["clmCity"].Value = reader["City"];
                            dgvStaff.Rows[rowIndex].Cells["clmBatch"].Value = reader["Batch"];
                            dgvStaff.Rows[rowIndex].Cells["clmRole"].Value = reader["Role"];
                            dgvStaff.Rows[rowIndex].Cells["clmBloodGroup"].Value = reader["BloodGroup"];
                        }
                    }
                }
            }
        }

        private void SearchStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BFC.StaffList WHERE 1=1";

                if (!string.IsNullOrEmpty(txtName.Texts))
                    query += $" AND VendorName LIKE '%{txtName.Texts}%'";

                if (!string.IsNullOrWhiteSpace(txtBloodGroup.Texts))
                    query += $" AND BloodGroup = '{txtBloodGroup.Texts}'";

                if (!string.IsNullOrWhiteSpace(txtCity.Texts))
                    query += $" AND City = '{txtCity.Texts}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvStaff.Rows.Clear();

                        while (reader.Read())
                        {
                            int rowIndex = dgvStaff.Rows.Add();

                            dgvStaff.Rows[rowIndex].Cells["clmId"].Value = rowIndex+1;
                            dgvStaff.Rows[rowIndex].Cells["clmName"].Value = reader["VendorName"];
                            dgvStaff.Rows[rowIndex].Cells["clmAddress"].Value = reader["Address"];
                            dgvStaff.Rows[rowIndex].Cells["clmCity"].Value = reader["City"];
                            dgvStaff.Rows[rowIndex].Cells["clmBatch"].Value = reader["Batch"];
                            dgvStaff.Rows[rowIndex].Cells["clmRole"].Value = reader["Role"];
                            dgvStaff.Rows[rowIndex].Cells["clmBloodGroup"].Value = reader["BloodGroup"];
                        }
                    }
                }
            }
        }
        #endregion
    }
}

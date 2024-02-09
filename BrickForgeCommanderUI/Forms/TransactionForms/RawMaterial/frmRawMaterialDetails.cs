using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System;
using System.Xml.Linq;

namespace BrickForgeCommanderUI.Forms.TransactionForms.RawMaterial
{
    public partial class frmRawMaterialDetails : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        public frmRawMaterialDetails()
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

        private void frmRawMaterialDetails_Load(object sender, System.EventArgs e)
        {
            cbxUnit.SelectedIndex = 0;

            GetRawMaterialList();
        }

        private void btnInsert_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Texts) && !string.IsNullOrEmpty(txtCapacity.Texts))          
            {
                string name = txtName.Texts;
                double capacity = GetCapacity();

                InsertRawMaterial(name,capacity);
            }
            else
            {
                MessageBox.Show("Please fill all the necessary fields!!", "Insertion Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        private void dgvRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateRecord(dgvRawMaterial,e);
            DeleteRecord(dgvRawMaterial,e);
        }

        private void frmRawMaterialDetails_Activated(object sender, EventArgs e)
        {
            GetRawMaterialList();
            lblId.Text = (GetLastEnteredMaterialId()+1).ToString();
        }
        #endregion

        #region Functions

        private double ConvertCapacity(double capacity, string selectedUnit)
        {
            if (selectedUnit == "METRIC TONS")
            {
                capacity *= 1000;
            }

            return capacity;
        }

        private double GetCapacity()
        {
            if (!string.IsNullOrEmpty(txtCapacity.Texts))
            {
                double capacity = double.Parse(txtCapacity.Texts);
                string selectedUnit = cbxUnit.SelectedItem.ToString(); 

                capacity = ConvertCapacity(capacity, selectedUnit);
                return capacity;
            }
            else
            {
                MessageBox.Show("Please enter a capacity value.", "Invalid Capacity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private void InsertRawMaterial(string materialName, double capacity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("BFC.usp_InsertRawMaterialDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaterialName", materialName);
                        command.Parameters.AddWithValue("@Capacity", capacity);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Raw material record inserted successfully.", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetRawMaterialList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BFC.RawMaterialDetails";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvRawMaterial.Rows.Clear();

                        while (reader.Read())
                        {
                            int rowIndex = dgvRawMaterial.Rows.Add();

                            dgvRawMaterial.Rows[rowIndex].Cells["clmId"].Value = reader["MaterialId"];
                            dgvRawMaterial.Rows[rowIndex].Cells["clmSrNo"].Value = rowIndex + 1;
                            dgvRawMaterial.Rows[rowIndex].Cells["clmName"].Value = reader["MaterialName"];
                            dgvRawMaterial.Rows[rowIndex].Cells["clmCapacity"].Value = reader["Capacity"];
                        }
                    }
                }
            }
        }

        private void Clear()
        {
            txtName.Texts = "";
            txtCapacity.Texts = "";
            lblId.Text = GetLastEnteredMaterialId().ToString();
        }

        private int GetLastEnteredMaterialId()
        {
            int lastMaterialId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IDENT_CURRENT('BFC.RawMaterialDetails')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        lastMaterialId = Convert.ToInt32(result);
                    }
                }
            }

            return lastMaterialId;
        }

        private void UpdateRawMaterial(int id, string name, double capacity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE BFC.RawMaterialDetails SET MaterialName = @Name, Capacity = @Capacity WHERE MaterialId = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Capacity", capacity);
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Raw material record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRawMaterial(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM BFC.RawMaterialDetails WHERE MaterialId = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Raw material record deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecord(DataGridView dgvRawMaterials, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvRawMaterial.Columns["clmUpdate"].Index)
                {
                    int id = (int)dgvRawMaterial.Rows[e.RowIndex].Cells["clmId"].Value;
                    string name = dgvRawMaterial.Rows[e.RowIndex].Cells["clmName"].Value.ToString();

                    object capacityCellValue = dgvRawMaterial.Rows[e.RowIndex].Cells["clmCapacity"].Value;
                    double capacity;

                    if (capacityCellValue != DBNull.Value && double.TryParse(capacityCellValue.ToString(), out capacity))
                    {
                        UpdateRawMaterial(id, name, capacity);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid capacity value.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "Update Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteRecord(DataGridView dgvRawMaterials, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvRawMaterial.Columns["clmDelete"].Index)
                {
                    int id = (int)dgvRawMaterial.Rows[e.RowIndex].Cells["clmId"].Value;

                    DeleteRawMaterial(id);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "Update Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

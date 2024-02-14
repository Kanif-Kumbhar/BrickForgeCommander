using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace BrickForgeCommanderUI.Forms.TransactionForms.RawMaterial
{
    public partial class frmRawMaterialPurchase : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        public frmRawMaterialPurchase()
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

        private void frmRawMaterialPurchase_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'rawMaterials.RawMaterialDetails' table. You can move, or remove it, as needed.
            this.rawMaterialDetailsTableAdapter.Fill(this.rawMaterials.RawMaterialDetails);

            PopulateSupplierComboBox();
            GetStockReports();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPurchasePrice.Texts, out decimal purchasePrice) &&
                int.TryParse(txtQuantity.Texts, out int quantity))
            {
                if (cbxMaterial.SelectedItem is DataRowView materialRow &&
                    cbxSupplier.SelectedItem is DataRowView vendorRow &&
                    materialRow.Row["MaterialId"] is int materialId &&
                    vendorRow.Row["VendorId"] is int vendorId)
                {
                    InsertStockDetails(materialId, vendorId, purchasePrice, quantity);
                }
                else
                {
                    MessageBox.Show("Please select valid Material and Vendor from the dropdowns.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Purchase Price and Quantity.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmRawMaterialPurchase_Activated(object sender, EventArgs e)
        {
            GetStockReports();
        }
        #endregion

        #region Functions

        private void PopulateSupplierComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT VendorDetails.VendorId, CONCAT(VendorDetails.FirstName, ' ', VendorDetails.MiddleName, ' ', VendorDetails.LastName) AS [FullName] " +
                                   "FROM BFC.VendorDetails " +
                                   "JOIN BFC.VendorTypeDetails ON BFC.VendorDetails.VendorTypeId = BFC.VendorTypeDetails.VendorTypeId " +
                                   "WHERE BFC.VendorTypeDetails.VendorTypeName = 'Supplier'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbxSupplier.DataSource = dataTable;
                    cbxSupplier.ValueMember = "VendorId";
                    cbxSupplier.DisplayMember = "FullName"; 
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show($"{e}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void InsertStockDetails(int materialId, int vendorId, decimal purchasePrice, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("BFC.usp_InsertStockDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaterialId", materialId);
                        command.Parameters.AddWithValue("@VendorId", vendorId);
                        command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Clear();
                    }
                }
                MessageBox.Show("Stock details inserted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while inserting stock details: " + ex.Message);
            }
        }

        private void Clear()
        {
            txtPurchasePrice.Texts = "";
            txtQuantity.Texts = "";
            cbxMaterial.SelectedItem = null;
            cbxSupplier.SelectedItem = null;
        }

        private void GetStockReports()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BFC.StockDetails";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dgvRawMaterial.Rows.Clear();

                            while (reader.Read())
                            {
                                int rowIndex = dgvRawMaterial.Rows.Add();

                                dgvRawMaterial.Rows[rowIndex].Cells["clmId"].Value = reader["Id"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmSrNo"].Value = rowIndex + 1;
                                dgvRawMaterial.Rows[rowIndex].Cells["clmSupplierName"].Value = reader["SupplierName"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmName"].Value = reader["MaterialName"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmQuantity"].Value = reader["Quantity"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmPurchase"].Value = reader["Price"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmDate"].Value = reader["Date"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmStatus"].Value = reader["Status"];
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}");
                }
            }
        }

        #endregion
    }
}

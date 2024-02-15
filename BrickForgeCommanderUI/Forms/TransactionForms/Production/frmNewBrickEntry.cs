using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Production
{
    public partial class frmNewBrickEntry : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private int selectedBrickId = -1;
        private decimal workerCharges = 0;
        private decimal totalRawMaterialCost = 0;
        private decimal unitPrice = 0;
        private decimal totalCost = 0;
        private int round = 2;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        public frmNewBrickEntry()
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

        private void frmNewBrickEntry_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'product.BrickDetails' table. You can move, or remove it, as needed.
            this.brickDetailsTableAdapter.Fill(this.product.BrickDetails);
            this.rawMaterialDetailsTableAdapter.Fill(this.rawMaterials.RawMaterialDetails);
        }

        private void btnAddRow_Click(object sender, System.EventArgs e)
        {
            int rowIndex = dgvRawMaterial.Rows.Add();
            dgvRawMaterial.Rows[rowIndex].Cells["clmSrNo"].Value = (rowIndex + 1).ToString();
        }

        private void cbxBrickType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrickDetails();
        }

        private void dgvRawMaterial_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAddRawMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalCost = 0;

                foreach (DataGridViewRow row in dgvRawMaterial.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int materialId = Convert.ToInt32(row.Cells["clmName"].Value);
                        int quantity = Convert.ToInt32(row.Cells["clmQuantity"].Value);

                        decimal unitPrice = GetUnitPrice(materialId);
                        decimal rowTotalCost = unitPrice * quantity;

                        totalCost += rowTotalCost;
                    }
                }

                unitPrice = totalCost + decimal.Parse(txtLabourCharges.Texts);
                
                txtUnitPrice.Texts = unitPrice.ToString();  
                txtRawMaterialCost.Texts = totalCost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProfitMargin_Leave(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region Functions

        private decimal GetUnitPrice(int materialId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT UnitPrice FROM BFC.RawMaterialDetails WHERE MaterialId = @MaterialId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaterialId", materialId);
                    return Convert.ToDecimal(command.ExecuteScalar());
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void LoadBrickDetails()
        {
            try
            {
                if (cbxBrickType.SelectedItem != null)
                {
                    DataRowView selectedBrick = (DataRowView)cbxBrickType.SelectedItem;

                    if (selectedBrick.Row["BrickId"] != DBNull.Value)
                    {
                        selectedBrickId = Convert.ToInt32(selectedBrick.Row["BrickId"]);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT BricksMadePrice, DhulaiPrice, NikashiPrice FROM [BFC].[BrickLabourCharges] WHERE BrickId = @BrickId";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@BrickId", selectedBrickId);

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                decimal bricksMadePrice = Convert.ToDecimal(reader["BricksMadePrice"]);
                                decimal dhulaiPrice = Convert.ToDecimal(reader["DhulaiPrice"]);
                                decimal nikashiPrice = Convert.ToDecimal(reader["NikashiPrice"]);

                                workerCharges = bricksMadePrice + dhulaiPrice + nikashiPrice;

                                txtLabourCharges.Texts = workerCharges.ToString();
                            }
                        }

                        //CalculateTotalCost();
                    }
                    else
                    {
                        MessageBox.Show("BrickId is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotalCost()
        {
            totalRawMaterialCost = 0;

            try
            {
                    unitPrice = decimal.Parse(txtUnitPrice.Texts.ToString());
                    decimal profitMargin = decimal.Parse(txtProfitMargin.Texts.ToString());
                    decimal profit = unitPrice * profitMargin / 100;
                    totalCost = unitPrice + profit;

                    txtTotalAmount.Texts = totalCost.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtCreditScore.Texts = "";
            txtLabourCharges.Texts = "";
            txtProfitMargin.Texts = "";
            txtRawMaterialCost.Texts = "";
            txtTotalAmount.Texts = "";
            txtUnitPrice.Texts = "";

            cbxBrickType.Texts = "     -Select Brick Type-";
            dgvRawMaterial.Rows.Clear();
        }

        private void InsertBrickData()
        {
            try
            {
                if (cbxBrickType.SelectedItem != null)
                {
                    DataRowView selectedBrick = (DataRowView)cbxBrickType.SelectedItem;

                    if (selectedBrick.Row["BrickId"] != DBNull.Value)
                    {
                        selectedBrickId = Convert.ToInt32(selectedBrick.Row["BrickId"]);
                        unitPrice = decimal.Round(decimal.Parse(txtUnitPrice.Texts), round); 
                        decimal profitMargin = decimal.Round(decimal.Parse(txtProfitMargin.Texts), round);
                        totalCost = decimal.Round(decimal.Parse(txtTotalAmount.Texts), round);
                        int scoreValue = int.Parse(txtCreditScore.Texts);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("BFC.usp_InsertProductDetails", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@BrickId", selectedBrickId);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@ProfitMargin", profitMargin);
                                command.Parameters.AddWithValue("@TotalAmount", totalCost);
                                command.Parameters.AddWithValue("@ScoreId", scoreValue);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Raw material record inserted successfully.", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetRawMaterials()
        {
            foreach (DataGridViewRow row in dgvRawMaterial.Rows)
            {
                int rawMaterialId;
                decimal materialQuantity;

                if (!int.TryParse(row.Cells["clmName"].Value.ToString(), out rawMaterialId) || !decimal.TryParse(row.Cells["clmQuantity"].Value.ToString(), out materialQuantity))
                {
                    MessageBox.Show("Invalid input in row " + (row.Index + 1) + ". Please enter valid raw material ID and quantity.");
                    return;
                }

                InsertRawMaterial(rawMaterialId, materialQuantity);
            }
        }

        private void InsertRawMaterial(int rawMaterialId, decimal materialQuantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("BFC.usp_InsertProductRawMaterials", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RawMaterialID", rawMaterialId);
                command.Parameters.AddWithValue("@MaterialQuantity", materialQuantity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ValidateAndInsertData();
        }

        private void ValidateAndInsertData()
        {
            try
            {
                if (cbxBrickType.SelectedItem != null && dgvRawMaterial.Rows.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        InsertBrickData();

                        GetRawMaterials();

                        Clear();
                        MessageBox.Show("Data inserted successfully.", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion
}

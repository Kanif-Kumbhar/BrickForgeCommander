using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrickForgeCommanderUI.Forms.TransactionForms.Production
{
    public partial class frmBricksPaymentSetting : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        public frmBricksPaymentSetting()
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

        private void btnInsert_Click(object sender, System.EventArgs e)
        {
            ValidateInsert();
            Clear();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        private void cbxCity_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            GetBrickDetails();
        }

        private void frmBricksPaymentSetting_Load(object sender, EventArgs e)
        {
            this.brickDetailsTableAdapter.Fill(this.product.BrickDetails);
        }
        #endregion

        #region Fuctions

        private void InsertOrUpdateBrick(int id,int makeAmount,double makeCharges,int dhulaiAmount,double dhulaiCharges, int nikashiAmount,double nikashiCharges)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("BFC.InsertOrUpdateBrickPaymentDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BrickId", id);
                        command.Parameters.AddWithValue("@BricksMadeAmount", makeAmount);
                        command.Parameters.AddWithValue("@BricksMadePrice", makeCharges);
                        command.Parameters.AddWithValue("@DhulaiAmount", dhulaiAmount);
                        command.Parameters.AddWithValue("@DhulaiPrice", dhulaiCharges);
                        command.Parameters.AddWithValue("@NikashiAmount", nikashiAmount);
                        command.Parameters.AddWithValue("@NikashiPrice", nikashiCharges);

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

        private void ValidateInsert()
        {
            if(cbxBrickType.SelectedIndex >= 0)
            {
                if (!string.IsNullOrEmpty(txtDhulaiAmount.Texts) &&
                !string.IsNullOrEmpty(txtDhulaiQuantity.Texts) &&
                !string.IsNullOrEmpty(txtMakingAmount.Texts) &&
                !string.IsNullOrEmpty(txtMakingQuantity.Texts) &&
                !string.IsNullOrEmpty(txtNikashiAmount.Texts) &&
                !string.IsNullOrEmpty(txtNikashiQuantity.Texts))
                {
                    int brickId = -1;
                    if (cbxBrickType.SelectedItem != null)
                    {
                        DataRowView selectedBrick = (DataRowView)cbxBrickType.SelectedItem;
                        brickId = Convert.ToInt32(selectedBrick["BrickId"]);
                    }

                    int makeQuantity = int.Parse(txtMakingQuantity.Texts);
                    double makeAmount = double.Parse(txtMakingAmount.Texts);

                    int dhulaiQuantity = int.Parse(txtDhulaiQuantity.Texts);
                    double dhulaiAmount = double.Parse(txtDhulaiAmount.Texts);

                    int nikashiQuantity = int.Parse(txtNikashiQuantity.Texts);
                    double nikashiAmount = double.Parse(txtNikashiAmount.Texts);

                    InsertOrUpdateBrick(brickId,makeQuantity,makeAmount,dhulaiQuantity, dhulaiAmount, nikashiQuantity, dhulaiAmount);
                }
                else
                {
                    MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a brick type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GetBrickDetails()
        {
            try
            {
                int brickId = -1;
                if (cbxBrickType.SelectedItem != null)
                {
                    DataRowView selectedBrick = (DataRowView)cbxBrickType.SelectedItem;
                    brickId = Convert.ToInt32(selectedBrick["BrickId"]);
                }
                string query = "SELECT * FROM BFC.BrickPaymentDetails WHERE BrickId = @BrickType";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BrickType", brickId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMakingQuantity.Texts = reader["BricksMadeAmount"].ToString();
                            txtMakingAmount.Texts = reader["BricksMadePrice"].ToString();
                            txtDhulaiQuantity.Texts = reader["DhulaiAmount"].ToString();
                            txtDhulaiAmount.Texts = reader["DhulaiPrice"].ToString();
                            txtNikashiQuantity.Texts = reader["NikashiAmount"].ToString();
                            txtNikashiAmount.Texts = reader["NikashiPrice"].ToString();
                        }
                        else
                        {
                            txtMakingQuantity.Texts = "";
                            txtMakingAmount.Texts = "";
                            txtDhulaiQuantity.Texts = "";
                            txtDhulaiAmount.Texts = "";
                            txtNikashiQuantity.Texts = "";
                            txtNikashiAmount.Texts = "";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Clear()
        {
            cbxBrickType.SelectedIndex = -1;
            txtMakingQuantity.Texts = "";
            txtMakingAmount.Texts = "";
            txtDhulaiQuantity.Texts = "";
            txtDhulaiAmount.Texts = "";
            txtNikashiQuantity.Texts = "";
            txtNikashiAmount.Texts = "";
        }
        #endregion
    }
}

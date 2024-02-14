using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace BrickForgeCommanderUI.Forms.TransactionForms.RawMaterial
{
    public partial class frmStockReport : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BFC"].ToString();
        public frmStockReport()
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

        private void frmStockReport_Load(object sender, System.EventArgs e)
        {
            GetStockReports();
        }

        private void frmStockReport_Activated(object sender, System.EventArgs e)
        {

        }

        #endregion

        #region Events

        private void GetStockReports()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MaterialName, SUM(Quantity) AS TotalQuantity, UnitPrice, [Status], Capacity " +
                                        "FROM [BFC].[StockDetails] " +
                                                    "GROUP BY MaterialName, [Status], UnitPrice, Capacity;";

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

                                dgvRawMaterial.Rows[rowIndex].Cells["clmCapacity"].Value = reader["Capacity"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmSrNo"].Value = rowIndex + 1;
                                dgvRawMaterial.Rows[rowIndex].Cells["clmName"].Value = reader["MaterialName"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmQuantity"].Value = reader["TotalQuantity"];
                                dgvRawMaterial.Rows[rowIndex].Cells["clmUnitPrice"].Value = reader["UnitPrice"];
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

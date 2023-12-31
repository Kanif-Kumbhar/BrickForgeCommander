using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Data.SqlClient;


namespace BrickForgeCommanderUI.MasterForms
{
    public partial class frmVendorTypeDetails : Form
    {
        private SqlQueryRunner sqlQueryRunner;
        private DataTable dataTable;
        private DataTable originalDataTable;
        string tableName = "kanif.VendorTypeDetails";

        private int currentId = 1;
        private DataTable changesDataTable;
        private DataTable originalDataTableCopy;

        private void ExecuteSelectQuery()
        {
            string selectQuery = $"SELECT * FROM kanif.VendorTypeDetails";
            DataTable resultTable = sqlQueryRunner.RunSelectQuery(selectQuery);

            dgvVendorTypeDetails.DataSource = resultTable;
            dgvVendorTypeDetails.Refresh();
        }

        private void UpdateChangesDataTable()
        {
            changesDataTable = originalDataTable.Clone();

            changesDataTable.Merge(dataTable, true, MissingSchemaAction.Add);
        }

        #region CUR Operation
        private Stack<string> vendorTypeIdUndoStack = new Stack<string>();
        private Stack<string> vendorTypeIdRedoStack = new Stack<string>();

        private Stack<string> vendorTypeNameUndoStack = new Stack<string>();
        private Stack<string> vendorTypeNameRedoStack = new Stack<string>();

        private void UpdateUndoRedoButtons()
        {
            btnUndo.Enabled = vendorTypeIdUndoStack.Count > 0 || vendorTypeNameUndoStack.Count > 0;
            btnRedo.Enabled = vendorTypeIdRedoStack.Count > 0 || vendorTypeNameRedoStack.Count > 0;
        }

        private void SaveTextToUndoStack(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            undoStack.Push(textBox.Text);
            redoStack.Clear();
            UpdateUndoRedoButtons();
        }

        private void UndoTextBox(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(textBox.Text);
                textBox.Text = undoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        private void RedoTextBox(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(textBox.Text);
                textBox.Text = redoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        #endregion

        #region CUR Click Events
        private void txtVendorTypeId_TextChanged(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            SaveTextToUndoStack(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);

            txtVendorTypeId.Clear();
            txtVendorTypeName.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoTextBox(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            UndoTextBox(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            RedoTextBox(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            RedoTextBox(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        private void txtVendorTypeName_TextChanged(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        #endregion

        public frmVendorTypeDetails()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Load += frmVendorTypeDetails_Load;

            sqlQueryRunner = new SqlQueryRunner("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True;Encrypt=False");
            
            txtVendorTypeId.Text = currentId.ToString();

            dataTable = new DataTable();
            dataTable.Columns.Add("VendorTypeId", typeof(int));
            dataTable.Columns.Add("VendorTypeName", typeof(string));

            originalDataTable = dataTable.Clone();
            
            dgvVendorTypeDetails.AutoGenerateColumns = true;
            dgvVendorTypeDetails.ReadOnly = true;
        }

        private void frmVendorTypeDetails_Load(object sender, EventArgs e)
        {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);

            ExecuteSelectQuery();

            originalDataTableCopy = dataTable.Copy();
        }


        #region Buttons Click Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["VendorTypeId"] = int.Parse(txtVendorTypeId.Text);
                newRow["VendorTypeName"] = txtVendorTypeName.Text;

                dataTable.Rows.Add(newRow);

                txtVendorTypeId.Clear();
                txtVendorTypeName.Clear();
                txtVendorTypeId.Focus();

                MessageBox.Show("Data Added Successfully", "Vendor Type Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExecuteSelectQuery();
                UpdateChangesDataTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlQueryRunner.SaveDataToDatabase(dataTable, tableName);

            originalDataTableCopy = dataTable?.Copy();

            dataTable.Clear();

            currentId++;
            txtVendorTypeId.Text = currentId.ToString();

            MessageBox.Show("Saved Successfully", "Vendor Type Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExecuteSelectQuery();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idToUpdate = int.Parse(txtVendorTypeId.Text.Trim());
                string updatedName = txtVendorTypeName.Text.Trim();
                string updateQuery = $"UPDATE kanif.VendorTypeDetails SET VendorTypeName = @UpdatedName WHERE VendorTypeId = @IdToUpdate";

                SqlParameter[] parameters = {
                    new SqlParameter("@UpdatedName", SqlDbType.VarChar) { Value = updatedName },
                    new SqlParameter("@IdToUpdate", SqlDbType.Int) { Value = idToUpdate }
                };

                sqlQueryRunner.RunParameterizedNonQuery(updateQuery, parameters);

                MessageBox.Show("Successfully Updated", "Vendor Type Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExecuteSelectQuery();
                UpdateChangesDataTable();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idToDelete = int.Parse(txtVendorTypeId.Text);
                string deleteQuery = $"DELETE FROM kanif.VendorTypeDetails WHERE VendorTypeId = @IdToDelete";

                SqlParameter parameter = new SqlParameter("@IdToDelete", SqlDbType.Int) { Value = idToDelete };
                sqlQueryRunner.RunParameterizedNonQuery(deleteQuery, parameter);

                MessageBox.Show("Delete Successful", "Vendor Type Record", MessageBoxButtons.OK);
                ExecuteSelectQuery();
                UpdateChangesDataTable();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }
    

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (originalDataTableCopy != null)
            {
                dataTable.Clear();
                dataTable.Merge(originalDataTableCopy);

                UpdateChangesDataTable();

                vendorTypeIdUndoStack.Clear();
                vendorTypeIdRedoStack.Clear();
                vendorTypeNameUndoStack.Clear();
                vendorTypeNameRedoStack.Clear();

                UpdateUndoRedoButtons();

                dgvVendorTypeDetails.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Original data is not available for reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dgvVendorTypeDetails_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvVendorTypeDetails.SelectedRows)
            {
                txtVendorTypeId.Text = row.Cells[0].Value.ToString();
                txtVendorTypeName.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}

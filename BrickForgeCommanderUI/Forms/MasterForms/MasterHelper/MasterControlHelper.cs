using System.Windows.Forms;
using BrickForgeCommanderUI.Controls.Validation;

namespace BrickForgeCommanderUI.Forms.MasterForms.MasterHelper
{
    public static class MasterControlHelper
    {
        public static void CellSingleClick(Label lbLabel,string tableName,DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                if (!string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                {
                    string vendorTypeId = selectedRow.Cells[0].Value.ToString();
                    lbLabel.Text = vendorTypeId;
                }
                else
                {
                    lbLabel.Text = (SqlCommandHelper.GetId(tableName) + 1).ToString();
                }
            }
        }

        public static void CellDoubleClick(Label lbLabel,RequiredFieldTextBox textBox, string tableName, DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];

                if (!string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                {
                    string vendorTypeId = selectedRow.Cells[0].Value.ToString();
                    string vendorTypeName = selectedRow.Cells[1].Value.ToString();
                    lbLabel.Text = vendorTypeId;
                    textBox.Texts = vendorTypeName;
                }
                else
                {
                    lbLabel.Text = (SqlCommandHelper.GetId(tableName) + 1).ToString();
                    textBox.Texts = string.Empty;
                }
            }
        }
    }
}

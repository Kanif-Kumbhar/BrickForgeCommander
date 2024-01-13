using System.Drawing;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Controls.FunctionControls
{
    public class BfcDataGridView : DataGridView
    {
        public BfcDataGridView()
        {
            InitializeCustomDataGridView();
        }

        private void InitializeCustomDataGridView()
        {
            // Add event handlers
            this.CellClick += CustomDataGridView_CellClick;

            // Create Edit and Delete button columns
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";


            // Add the button columns to the DataGridView
            this.Columns.Add(editButtonColumn);
            this.Columns.Add(deleteButtonColumn);

            int totalColumns = this.Columns.Count;

            SetButton(totalColumns, "EditButton", "DeleteButton");

        }


        private void SetButton(int totalCount,string edit,string delete)
        {
            if (totalCount >= 2)
            {
                int editColumnIndex = totalCount - 1;
                int deleteColumnIndex = totalCount - 2;


            }
        }

        private void CustomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle button clicks
            if (e.RowIndex == this.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                string buttonName = this.Columns[e.ColumnIndex].Name;
                if (buttonName == "EditButton")
                {
                    // Handle Edit button click
                    MessageBox.Show("Edit button clicked");
                }
                else if (buttonName == "DeleteButton")
                {
                    // Handle Delete button click
                    MessageBox.Show("Delete button clicked");
                }
            }
        }
    }
}

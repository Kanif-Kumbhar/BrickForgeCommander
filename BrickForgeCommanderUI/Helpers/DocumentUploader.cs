using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BrickForgeCommanderUI.Forms.Misc;

namespace BrickForgeCommanderUI.Helpers
{
    public static class DocumentUploader
    {
        public static DataTable documentTable = new DataTable("Document");
        private static DataTable previewDataTable;
        private static string documentName;

        static DocumentUploader()
        {
            documentTable.Columns.Add("DocumentName", typeof(string));
            documentTable.Columns.Add("FilePath", typeof(string));
        }

        public static void UploadDocument(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Upload Document";
                    openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        FileInfo fileInfo = new FileInfo(filePath);
                        long fileSizeInBytes = fileInfo.Length;
                        long fileSizeInKB = fileSizeInBytes / 1024;

                        if (fileSizeInKB > 200)
                        {
                            MessageBox.Show("Image size should be below 200KB.");
                            return;
                        }

                        DataRow newRow = documentTable.NewRow();
                        newRow["DocumentName"] = Path.GetFileName(filePath);
                        newRow["FilePath"] = filePath;
                        documentTable.Rows.Add(newRow);

                        UpdateDataGridView(documentTable, dgv, e.RowIndex);
                    }
                }
            }
        }

        public static void UpdateDataGridView(DataTable table, DataGridView dgv, int rowIndex)
        {
            int previewColumnIndex = 1;

            dgv.Rows[rowIndex].Cells[previewColumnIndex].Value = table.Rows[rowIndex]["DocumentName"].ToString();
        }

        public static void PreviewDocument(Panel pnl, DataGridView dgv, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].HeaderText == "Document Preview")
            {
                previewDataTable = documentTable;
                DataRow selectedRow = documentTable.Rows[e.RowIndex];
                documentName = selectedRow["DocumentName"].ToString();

                FormHelper.OpenForm<frmPreviewImage>(pnl, FormHelper.FormPosition.Center);
            }
        }

        public static DataTable GetDocumentTable()
        {
            DataTable selectedTable = previewDataTable.Clone(); 

            DataRow[] rows = previewDataTable.Select($"DocumentName = '{documentName}'");

            foreach (DataRow row in rows)
            {
                selectedTable.ImportRow(row);
            }
            return selectedTable;
        }

        public static DataTable GetDataTable()
        {
            if (documentTable != null && documentTable.Rows.Count > 0)
            {
                return documentTable;
            }
            else
            {
                return null;
            }
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BrickForgeCommanderUI.Controls.Validation;


namespace BrickForgeCommanderUI.Forms.MasterForms.MasterHelper
{
    public static class SqlCommandHelper
    {
        private static readonly string
            connectionString = ConfigurationManager.ConnectionStrings["BFC"].ConnectionString;

        public static void DisplayData(string tableName, DataGridView dgv, DataTable dataTable)
        {
            try
            {
                if (dataTable == null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string select = $"SELECT * FROM [BFC].[{tableName}]";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, connection);
                        dataTable = new DataTable(tableName);

                        dataAdapter.Fill(dataTable);
                    }
                }

                dgv.Columns.Clear();
                dgv.DataSource = dataTable;
                for (int i = 0; i < 2; i++)
                {
                    dgv.Columns[i].HeaderText = i == 0 ? "Id" : "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InsertData(RequiredFieldTextBox textBox, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string name = tableName.Replace("Details", "Name");
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(textBox.Texts))
                            {
                                string insert = $"INSERT INTO [BFC].[{tableName}] ({name}) VALUES (@Name)";
                                using (SqlCommand command = new SqlCommand(insert, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Name", textBox.Texts);
                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                textBox.Texts = String.Empty;
                                MessageBox.Show("Record Added Successfull", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Failed to add record. Error: {ex.Message}", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateData(Label textId, RequiredFieldTextBox textName, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string name = tableName.Replace("Details", "Name");
                    string id = tableName.Replace("Details", "Id");
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(textName.Texts) && !string.IsNullOrEmpty(textId.Text))
                            {
                                string update =
                                    $"UPDATE [BFC].[{tableName}] SET {name} = @Name WHERE {id} = @Id";
                                using (SqlCommand command = new SqlCommand(update, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Id", textId.Text);
                                    command.Parameters.AddWithValue("@Name", textName.Texts);
                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                textName.Texts = String.Empty;
                                MessageBox.Show("Record Updated Successfull", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                string message = $"Please Enter the valid name in the field.";
                                MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Failed to update record. \nError: {ex.Message}", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteData(Label textId, string tableName)
        {
            try
            {
                string message = $"Do you want to delete the record with ID {textId.Text}?";
                if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string id = tableName.Replace("Details", "Id");
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                if (!string.IsNullOrEmpty(textId.Text))
                                {
                                    string delete = 
                                        $"DELETE FROM [BFC].[{tableName}] WHERE {id} = @Id";

                                    using (SqlCommand command = new SqlCommand(delete, connection, transaction))
                                    {
                                        command.Parameters.AddWithValue("@Id", textId.Text);
                                        command.ExecuteNonQuery();
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Record Deleted Successfull", "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    message = $"Please Enter the valid name in the field.";
                                    MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Failed to delete record. \nError: {ex.Message}", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GetId(string tableName)
        {
            int lastInsertedId = 0;
            DataTable table = new DataTable(tableName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM [BFC].[{tableName}]";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection))
                {
                    dataAdapter.Fill(table);
                }

                if (table.Rows.Count > 0)
                {
                    DataRow lastRow = table.Rows[table.Rows.Count - 1];
                    foreach (DataColumn column in table.Columns)
                    {
                        string columnName = column.ColumnName;
                        lastInsertedId = (int)lastRow[columnName];
                        break;
                    }
                }

            }
            return lastInsertedId;
        }
    }
}

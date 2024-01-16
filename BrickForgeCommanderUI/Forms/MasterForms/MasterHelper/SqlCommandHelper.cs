using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BrickForgeCommanderUI.Controls;
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
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(textBox.Texts))
                            {
                                string insert = $"INSERT INTO [BFC].[{tableName}] (VendorTypeName) VALUES (@Name)";
                                using (SqlCommand command = new SqlCommand(insert, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Name", textBox.Texts);
                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();
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

        public static void UpdateData(BFC_TextBox textId, RequiredFieldTextBox textName, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(textName.Texts) && !string.IsNullOrEmpty(textId.Texts))
                            {
                                string update =
                                    $"UPDATE [BFC].[{tableName}] SET VendorTypeName = @Name WHERE VendorTypeId = @Id";
                                using (SqlCommand command = new SqlCommand(update, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Id", textId.Texts);
                                    command.Parameters.AddWithValue("@Name", textName.Texts);
                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();
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

        public static void DeleteData(BFC_TextBox textId, string tableName)
        {
            try
            {
                string message = $"Do you want to delete the record with ID {textId.Texts}?";
                if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                if (!string.IsNullOrEmpty(textId.Texts))
                                {
                                    string delete = 
                                        $"DELETE FROM [BFC].[{tableName}] WHERE VendorTypeId = @Id";

                                    using (SqlCommand command = new SqlCommand(delete, connection, transaction))
                                    {
                                        command.Parameters.AddWithValue("@Id", textId.Texts);
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
    }
}

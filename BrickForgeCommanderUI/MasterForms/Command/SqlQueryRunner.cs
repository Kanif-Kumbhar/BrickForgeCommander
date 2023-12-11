using System;
using System.Data;
using System.Data.SqlClient;

public class SqlQueryRunner
{
    private string connectionString; 

    public SqlQueryRunner(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void SaveDataToDatabase(DataTable dataTable, string tableName)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
            {
                bulkCopy.DestinationTableName = tableName;

                // Map columns from DataTable to SQL table columns
                foreach (DataColumn column in dataTable.Columns)
                {
                    bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                }

                // Write the data to the SQL server
                bulkCopy.WriteToServer(dataTable);
            }
        }
    }

    public DataTable RunSelectQuery(string query)
    {
        DataTable resultTable = new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Load the result set into a DataTable
                        resultTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log, display an error, etc.)
                    Console.WriteLine($"Error executing SQL query: {ex.Message}");
                }
            }
        }

        return resultTable;
    }

    public void RunNonQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log, display an error, etc.)
                    Console.WriteLine($"Error executing non-query SQL statement: {ex.Message}");
                }
            }
        }
    }

    public void RunParameterizedNonQuery(string query, params SqlParameter[] parameters)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    // Add parameters to the command
                    command.Parameters.AddRange(parameters);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log, display an error, etc.)
                    Console.WriteLine($"Error executing parameterized non-query SQL statement: {ex.Message}");
                }
            }
        }
    }
}
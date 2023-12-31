using BrickForgeCommanderUI.Db;
using BrickForgeCommanderUI.MasterForms.Encapsulation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickForgeCommanderUI.MasterForms.Models
{
    public class VendorTypeDetails : DbConnection
    {
        private DataTable dataTable;
        private DataTable originalDataTable;
        private SqlConnection sqlConnection;




        public void SavePersonDataToDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = "kanif.VendorTypeDetails";

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                    }

                    bulkCopy.WriteToServer(dataTable);

                }
            }
        }
    }
}

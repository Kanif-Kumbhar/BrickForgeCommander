using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickForgeCommanderUI.Helpers
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        protected DbConnection()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True;Encrypt=False";
        }

        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }
    }
}

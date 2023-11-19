using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickForgeCommanderUI.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BrickForgeCommanderDB;Integrated Security=True;Encrypt=True";
        }

        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }
    }
}

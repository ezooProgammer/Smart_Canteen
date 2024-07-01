using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen
{
    public abstract class DbConnection
    {
        private readonly string connectionstring; 

        public DbConnection()
        {
            connectionstring = @"Data Source = DESKTOP-6KER5J3\MSSQLSERVER1; Initial Catalog = SmartDB; Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBACKUP
{
    public class SqlFuncs
    {
        public SqlConnection SqlConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=" + "."/*conString.Text*/ + ";" + "Initial Catalog= master ;" + "User id=" + "sa"/*conUsername.Text*/ + ";" + "Password=" + "guncel@123"/*conPassword.Text*/ + ";";

            return conn;
        }

        public SqlConnection SqlConnectionWindowsAuth()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=" + "."/*conString.Text*/ + ";" + "Initial Catalog= master ;" + "User id=" + "sa"/*conUsername.Text*/ + ";" + "Password=" + "guncel@123"/*conPassword.Text*/ + ";";

            return conn;
        }
    }
}

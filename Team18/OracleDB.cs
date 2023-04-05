using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Team18
{
    public class OracleDB
    {
        public static string connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-DVGEP05O)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = XE)));";
        public static void createConnectionString(string username, string password)
        {
            connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-DVGEP05O)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = XE)));";
            if (username != "")
            {
                connectionString += "User Id = " + username + "; Password = " + password + ";";
            }
        }

    }
}

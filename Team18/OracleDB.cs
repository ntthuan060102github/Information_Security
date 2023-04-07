using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Team18
{
    public static class OracleDB
    {
        public static OracleConnection conn;
        public static string connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-DVGEP05O)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = XE)));";

        public static void connectToOracle(string username, string password)
        {
            connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-DVGEP05O)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = XE)));";
            if (username != "")
            {
                connectionString += "User Id = " + username + "; Password = " + password + ";";
            }

            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        public static void closeConnection()
        {
            conn.Close();
        }
    }
}

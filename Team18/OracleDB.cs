using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Team18
{
    public static class OracleDB
    {
        public static OracleConnection conn;
        public static string connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = ATBM_QLNV_PDB)));";

        public static void connectToOracle(string username, string password)
        {
            connectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = ATBM_QLNV_PDB)));";
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

        public static string getRoleOfUser(string username)
        {
            string MaNV = username.Substring(2);
            string role = "";
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT VAITRO FROM ATBM_QLNV.NHANVIEN WHERE MANV = :MaNV";
                cmd.Parameters.Add(new OracleParameter("MaNV", MaNV));
                role = cmd.ExecuteScalar().ToString();
                return role;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return role;
        }
    }
}

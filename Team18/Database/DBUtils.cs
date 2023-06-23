using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Team18.Database
{
    class DBUtils
    {
        public static string username;
        private static string password;
        public static string Dbschema;

        static DBUtils()
        {
            username = "ATBM_QLNV";
            password = "team18";
            Dbschema = "ATBM_QLNV";
        }

        public static void set_username(string _username)
        {
            username = _username;
        }

        public static void set_password(string _password)
        {
            password = _password;
        }
        
        public static OracleConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 1521;
            string sid = "ATBM_QLNV_PDB";

            return OracleDB.GetDBConnection(host, port, sid, username, password);
        }

        public static bool CheckSQLInput(string str)
        {
            str = str.ToLower();
            if (str.Contains("or ")     || str.Contains("and ") ||
                str.Contains("union ")  || str.Contains("--")   ) return false;

            foreach (char ch in str)
            {
                if (ch == '`' || ch == '\'' || ch == '%' || ch == '!' || ch == '=' || ch == '(' || ch == ')')
                    return false;
            }
            return true;
        }
    }

}
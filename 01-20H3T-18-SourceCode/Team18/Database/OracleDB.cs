﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Team18.Database
{
    public class DBOracleParameters : List<OracleParameter>
    {
        public void Add(OracleParameter item, Object value)
        {
            item.Value = value;
            this.Add(item);
        }
    }
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

        public static OracleConnection GetDBConnection(string host, int port, String sid, String username, String password)
        {

            Console.WriteLine("Getting Connection ...");

            // 'Connection string' to connect directly to Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username;


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }

        public static string Login(String username, String password, ref string role)
        {
            DBUtils.set_username(username);
            DBUtils.set_password(password);

            OracleConnection conn = DBUtils.GetDBConnection();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = DBUtils.Dbschema + "SP_GET_DB_ROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("role_R", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                role = cmd.Parameters["role_R"].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return ex.Message;
            }
            return null;
        }

        public static string ExecProc_OutputDataTable(string proc_name, ref DataTable dt)
        {
            DBOracleParameters parameters = new DBOracleParameters();

            return ExecProc_OutputDataTable(proc_name, ref parameters, ref dt);
        }

        public static string ExecProc_OutputDataTable(string proc_name, ref DBOracleParameters parameters, ref DataTable dt)
        {
            OracleConnection conn = DBUtils.GetDBConnection();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = proc_name; //DBUtils.Dbschema + 
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (OracleParameter pa in parameters)
            {
                cmd.Parameters.Add(pa);
            }

            cmd.Parameters.Add("O_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            try
            {
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                conn.Open();
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return ex.Message;
            }
            return null;
        }

        public static string ExecProc(string proc_name, ref DBOracleParameters parameters)
        {
            OracleConnection conn = DBUtils.GetDBConnection();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = proc_name; //DBUtils.Dbschema + 
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (OracleParameter pa in parameters)
            {
                cmd.Parameters.Add(pa);
            }

            try
            {
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return ex.Message;
            }
            return null;
        }

        public static string ExecQuery_OutputDataTable(string SQL, ref DataTable dt)
        {
            OracleConnection conn = DBUtils.GetDBConnection();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            cmd.CommandType = CommandType.Text;
            Console.WriteLine("SQL: " + SQL);
            try
            {
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                conn.Open();
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return ex.Message;
            }
            return null;
        }

        public static string ExecQuery(string SQL)
        {
            OracleConnection conn = DBUtils.GetDBConnection();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            cmd.CommandType = CommandType.Text;
            Console.WriteLine("SQL: " + SQL);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return ex.Message;
            }
            return null;
        }
    }
}

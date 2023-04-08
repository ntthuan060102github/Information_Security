using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace Team18.Forms
{
    public partial class Form_ListUser : Form
    {
        public Form_ListUser()
        {
            InitializeComponent();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VIEW_LIST_USER";
            cmd.Parameters.Add("O_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            this.dataGridView1.DataSource = dt1.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

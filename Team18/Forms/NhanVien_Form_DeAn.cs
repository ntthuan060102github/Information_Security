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
using Team18.Database;

namespace Team18.Forms
{
    public partial class NhanVien_Form_DeAn : Form
    {
        public NhanVien_Form_DeAn()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.DEAN";
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                deAnDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

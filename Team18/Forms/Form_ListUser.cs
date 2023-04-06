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
            Console.WriteLine("start");
            DataTable dt = new DataTable();
            DBOracleUtils.ExecProc_OutputDataTable("SP_VIEW_LIST_USER", ref dt);
            if (dt.Rows.Count <= 0) return;

            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView1.Rows.Add(dr["USER_ID"], dr["USERNAME"], true, dr["CREATED"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

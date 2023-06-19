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
using Team18.Encryption;

namespace Team18.Forms
{
    public partial class DBA_Form_ViewPrivs : Form
    {
        public DBA_Form_ViewPrivs()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            OracleDB.ExecProc_OutputDataTable("SP_VIEW_LIST_PRIVILEGE", ref dt);
            if (dt.Rows.Count <= 0) return;

            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView1.Rows.Add(dr["GRANTEE"], dr["OBJECT_NAME"], dr["COLUMN"], dr["PRIVILEGE"], dr["TYPE"], dr["GRANTABLE"], dr["TYPE"]);
            }
        }

        private void Form_ViewPrivs_Load(object sender, EventArgs e)
        {

        }
    }
}

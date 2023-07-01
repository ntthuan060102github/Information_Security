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
    public partial class NhanSu_Form_NVInfo : Form
    {
        public NhanSu_Form_NVInfo()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.NHANVIEN ORDER BY MANV";
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    string LUONG = dr["LUONG"].ToString();
                    if (LUONG != "")
                    {
                        var isNumeric_LUONG = int.TryParse(LUONG, out _);
                        if (!isNumeric_LUONG)
                            LUONG = Encryption.DecryptData(LUONG, Encryption.GetKey());
                        dr["LUONG"] = LUONG;
                    }

                    string PHUCAP = dr["PHUCAP"].ToString();
                    if (PHUCAP != "")
                    {
                        var isNumeric_PHUCAP = int.TryParse(PHUCAP, out _);
                        if (!isNumeric_PHUCAP)
                            PHUCAP = Encryption.DecryptData(PHUCAP, Encryption.GetKey());
                        dr["PHUCAP"] = PHUCAP;
                    }

                }
                nhanVienInfoDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

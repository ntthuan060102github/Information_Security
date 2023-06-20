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
    public partial class TruongPhong_Form_PhanCong : Form
    {
        public TruongPhong_Form_PhanCong()
        {
            InitializeComponent();
            Them_MANV.Items.Clear();
            Xoa_MANV.Items.Clear();
            CapNhat_MANV.Items.Clear();
            Them_MADA.Items.Clear();
            Xoa_MADA.Items.Clear();
            CapNhat_MADA.Items.Clear();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE 'NV'||MANV != USER ORDER BY MANV ASC";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MANV = reader.GetString(0);
                Them_MANV.Items.Add(MANV);
                Xoa_MANV.Items.Add(MANV);
                CapNhat_MANV.Items.Add(MANV);
            }
            reader.Close();
            OracleCommand cmd2 = OracleDB.conn.CreateCommand();
            cmd2.CommandText = "SELECT MADA FROM ATBM_QLNV.DEAN WHERE PHONG IN (SELECT PHG FROM ATBM_QLNV.NHANVIEN WHERE 'NV'||MANV = USER)";
            OracleDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string MADA = reader2.GetString(0);
                Them_MADA.Items.Add(MADA);
                Xoa_MADA.Items.Add(MADA);
                CapNhat_MADA.Items.Add(MADA);
            }
            reader2.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.PHANCONG WHERE MANV = :MANV AND MADA = :MADA";
                cmd.Parameters.Add(new OracleParameter("MANV", Xoa_MANV.Text));
                cmd.Parameters.Add(new OracleParameter("MADA", Xoa_MADA.Text));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                    cmd2.CommandText = "DELETE FROM ATBM_QLNV.PHANCONG WHERE MANV = :MANV AND MADA = :MADA";
                    cmd2.Parameters.Add(new OracleParameter("MANV", Xoa_MANV.Text));
                    cmd2.Parameters.Add(new OracleParameter("MADA", Xoa_MADA.Text));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Không tồn tại dữ liệu phân công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}

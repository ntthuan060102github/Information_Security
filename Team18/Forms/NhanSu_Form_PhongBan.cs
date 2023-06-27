using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team18.Database;

namespace Team18.Forms
{
    public partial class NhanSu_Form_PhongBan : Form
    {
        public NhanSu_Form_PhongBan()
        {
            InitializeComponent();
            Them_TRPHG.Items.Clear();
            CapNhat_TRPHG.Items.Clear();
            CapNhat_MAPB.Items.Clear();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT MANV FROM ATBM_QLNV.NHANVIEN ORDER BY MANV ASC";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MANV = reader.GetString(0);
                Them_TRPHG.Items.Add(MANV);
                CapNhat_TRPHG.Items.Add(MANV);
            }
            reader.Close();
            OracleCommand cmd2 = OracleDB.conn.CreateCommand();
            cmd2.CommandText = "SELECT MAPB FROM ATBM_QLNV.PHONGBAN";
            OracleDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string MAPB = reader2.GetString(0);
                CapNhat_MAPB.Items.Add(MAPB);
            }
            reader2.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MAPB = Them_MAPB.Text;
            string TENPB = Them_TENPB.Text;
            string TRPHG = Them_TRPHG.Text;
            if (MAPB != "" && TENPB != "" && TRPHG != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "SELECT MAPB FROM ATBM_QLNV.PHONGBAN WHERE MAPB = :MAPB";
                    cmd.Parameters.Add(new OracleParameter("MAPB", MAPB));
                    OracleDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        reader.Close();
                        OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                        cmd2.CommandText = "INSERT INTO ATBM_QLNV.PHONGBAN (MAPB, TENPB, TRPHG) VALUES(:MAPB,:TENPB,null)";
                        cmd2.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd2.Parameters.Add(new OracleParameter(":TENPB", TENPB));
                        cmd2.ExecuteNonQuery();
                        OracleCommand cmd3 = OracleDB.conn.CreateCommand();
                        cmd3.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET PHG = :MAPB WHERE MANV = :TRPHG";
                        cmd3.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd3.Parameters.Add(new OracleParameter(":TRPHG", TRPHG));
                        cmd3.ExecuteNonQuery();
                        OracleCommand cmd4 = OracleDB.conn.CreateCommand();
                        cmd4.CommandText = "UPDATE ATBM_QLNV.PHONGBAN SET TRPHG = :TRPHG WHERE MAPB = :MAPB";
                        cmd4.Parameters.Add(new OracleParameter(":TRPHG", TRPHG));
                        cmd4.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Mã phòng ban đã tồn tại, không thể thêm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MAPB = CapNhat_MAPB.Text;
            string TENPB = CapNhat_TENPB.Text;
            string TRPHG = CapNhat_TRPHG.Text;
            if (MAPB != "" && TENPB != "" && TRPHG != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "SELECT MAPB FROM ATBM_QLNV.PHONGBAN WHERE MAPB = :MAPB";
                    cmd.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Mã phòng ban không tồn tại, không thể cập nhật!");
                    }
                    else
                    {
                        reader.Close();
                        OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                        cmd2.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET VAITRO = 'Nhan vien' WHERE MANV IN (SELECT TRPHG FROM ATBM_QLNV.PHONGBAN WHERE MAPB = :MAPB)";
                        cmd2.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd2.ExecuteNonQuery();
                        OracleCommand cmd3 = OracleDB.conn.CreateCommand();
                        cmd3.CommandText = "UPDATE ATBM_QLNV.PHONGBAN SET TENPB = :TENPB, TRPHG = :TRPHG WHERE MAPB = :MAPB";
                        cmd3.Parameters.Add(new OracleParameter(":TENPB", TENPB));
                        cmd3.Parameters.Add(new OracleParameter(":TRPHG", TRPHG));
                        cmd3.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd3.ExecuteNonQuery();
                        OracleCommand cmd4 = OracleDB.conn.CreateCommand();
                        cmd4.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET PHG = :MAPB WHERE MANV = :TRPHG";
                        cmd4.Parameters.Add(new OracleParameter(":MAPB", MAPB));
                        cmd4.Parameters.Add(new OracleParameter(":TRPHG", TRPHG));
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void CapNhat_MAPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat_TRPHG.Items.Clear();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT MANV FROM ATBM_QLNV.NHANVIEN WHERE PHG = :MAPB ORDER BY MANV ASC";
            cmd.Parameters.Add(new OracleParameter(":MAPB", CapNhat_MAPB.Text));
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MANV = reader.GetString(0);
                CapNhat_TRPHG.Items.Add(MANV);
            }
            reader.Close();
            OracleCommand cmd2 = OracleDB.conn.CreateCommand();
            cmd2.CommandText = "SELECT TENPB FROM ATBM_QLNV.PHONGBAN WHERE MAPB = :MAPB";
            cmd2.Parameters.Add(new OracleParameter(":MAPB", CapNhat_MAPB.Text));
            string TENPB = cmd2.ExecuteScalar().ToString();
            CapNhat_TENPB.Text = TENPB;
        }
    }
}

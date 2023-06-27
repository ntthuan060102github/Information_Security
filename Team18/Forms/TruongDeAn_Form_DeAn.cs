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
    public partial class TruongDeAn_Form_DeAn : Form
    {
        public TruongDeAn_Form_DeAn()
        {
            InitializeComponent();
            Xoa_MADA.Items.Clear();
            CapNhat_MADA.Items.Clear();
            Them_PHONG.Items.Clear();
            CapNhat_PHONG.Items.Clear();
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT MADA FROM ATBM_QLNV.DEAN";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MADA = reader.GetString(0);
                    Xoa_MADA.Items.Add(MADA);
                    CapNhat_MADA.Items.Add(MADA);
                }
                reader.Close();
                OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                cmd2.CommandText = "SELECT MAPB FROM ATBM_QLNV.PHONGBAN";
                OracleDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string MAPB = reader2.GetString(0);
                    Them_PHONG.Items.Add(MAPB);
                    CapNhat_PHONG.Items.Add(MAPB);
                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Them_MADA.Text != "" && Them_TENDA.Text != "" && Them_PHONG.Text != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "SELECT MADA FROM ATBM_QLNV.DEAN WHERE MADA = :MADA";
                    cmd.Parameters.Add(new OracleParameter(":MADA", Them_MADA.Text));
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();

                        OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                        cmd2.CommandText = @"INSERT INTO ATBM_QLNV.DEAN (MADA, TENDA, NGAYBD, PHONG) 
                                            VALUES(:MADA, :TENDA, TO_DATE(:NGAYBD,'YYYY/MM/DD'), :PHONG)";
                        cmd2.Parameters.Add(new OracleParameter(":MADA", Them_MADA.Text));
                        cmd2.Parameters.Add(new OracleParameter(":TENDA", Them_TENDA.Text));
                        cmd2.Parameters.Add(new OracleParameter(":NGAYBD", Them_NGAYBD.Value.ToString("yyyy/MM/dd")));
                        cmd2.Parameters.Add(new OracleParameter(":PHONG", Them_PHONG.Text));
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Mã đề án đã tồn tại, không thể thêm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.PHANCONG WHERE MADA = :MADA";
                cmd.Parameters.Add(new OracleParameter(":MADA", Xoa_MADA.Text));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Đề án đã phân công, không thể xóa!");
                }
                else
                {
                    reader.Close();
                    OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                    cmd2.CommandText = "DELETE FROM ATBM_QLNV.DEAN WHERE MADA = :MADA";
                    cmd2.Parameters.Add(new OracleParameter(":MADA", Xoa_MADA.Text));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CapNhat_MADA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.DEAN WHERE MADA = :MADA";
                cmd.Parameters.Add(new OracleParameter(":MADA", CapNhat_MADA.Text));
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    CapNhat_TENDA.Text = dr["TENDA"].ToString();
                    CapNhat_NGAYBD.Value = DateTime.Parse(dr["NGAYBD"].ToString());
                    CapNhat_PHONG.Text = dr["PHONG"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT MADA FROM ATBM_QLNV.DEAN WHERE MADA = :MADA";
                cmd.Parameters.Add(new OracleParameter(":MADA", CapNhat_MADA.Text));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                    cmd2.CommandText = "UPDATE ATBM_QLNV.DEAN SET TENDA = :TENDA, NGAYBD = TO_DATE(:NGAYBD,'YYYY/MM/DD'), PHONG = :PHONG WHERE MADA = :MADA";
                    cmd2.Parameters.Add(new OracleParameter(":TENDA", CapNhat_TENDA.Text));
                    cmd2.Parameters.Add(new OracleParameter(":NGAYBD", CapNhat_NGAYBD.Value.ToString("yyyy/MM/dd")));
                    cmd2.Parameters.Add(new OracleParameter(":PHONG", CapNhat_PHONG.Text));
                    cmd2.Parameters.Add(new OracleParameter(":MADA", CapNhat_MADA.Text));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Không tồn tại mã đề án, không thể cập nhật!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

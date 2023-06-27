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
    public partial class NhanSu_Form_NhanVien : Form
    {
        public NhanSu_Form_NhanVien()
        {
            InitializeComponent();
            Them_cbbMANQL.Items.Clear();
            CapNhat_cbbMANV.Items.Clear();
            CapNhat_cbbMANQL.Items.Clear();
            Them_cbbPHG.Items.Clear();
            CapNhat_cbbPHG.Items.Clear();
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT MAX(MANV) + 1 FROM ATBM_QLNV.NHANVIEN ORDER BY MANV ASC";
                string newMANV = cmd.ExecuteScalar().ToString();
                Them_txbMANV.Text = newMANV;
                OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                cmd2.CommandText = "SELECT MANV FROM ATBM_QLNV.NHANVIEN ORDER BY MANV ASC";
                OracleDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    string MANV = reader.GetString(0);
                    Them_cbbMANQL.Items.Add(MANV);
                    CapNhat_cbbMANV.Items.Add(MANV);
                    CapNhat_cbbMANQL.Items.Add(MANV);
                }
                reader.Close();
                OracleCommand cmd3 = OracleDB.conn.CreateCommand();
                cmd3.CommandText = "SELECT MAPB FROM ATBM_QLNV.PHONGBAN";
                OracleDataReader reader2 = cmd3.ExecuteReader();
                while (reader2.Read())
                {
                    string MAPB = reader2.GetString(0);
                    Them_cbbPHG.Items.Add(MAPB);
                    CapNhat_cbbPHG.Items.Add(MAPB);
                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string MANV = Them_txbMANV.Text;
            string TENNV = Them_txbTENNV.Text;
            string PHAI = Them_cbbPHAI.Text;
            string NGAYSINH = Them_dtpNGAYSINH.Value.ToString("yyyy/MM/dd");
            string DIACHI = Them_txbDIACHI.Text;
            string SODT = Them_txbSODT.Text;
            string VAITRO = Them_cbbVAITRO.Text;
            string MANQL = Them_cbbMANQL.Text;
            string PHG = Them_cbbPHG.Text;
            if (MANV != "" && TENNV != "" && PHAI != "" && NGAYSINH != "" && DIACHI != "" && SODT != "" && VAITRO != "")
            {
                try
                {
                    //Ban giám đốc không có người quản lý trực tiếp và không thuộc phòng ban nào
                    if (VAITRO == "Ban giam doc")
                    {
                        OracleCommand cmd = OracleDB.conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO ATBM_QLNV.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) 
                                            VALUES(:MANV, :TENNV, :PHAI, TO_DATE(:NGAYSINH,'YYYY/MM/DD'), :DIACHI, :SODT, :VAITRO, null, null)";
                        cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                        cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                        cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                        cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                        cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                        cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                        cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        if (PHG != "")
                        {
                            if (MANQL == "")
                            {
                                OracleCommand cmd = OracleDB.conn.CreateCommand();
                                cmd.CommandText = @"INSERT INTO ATBM_QLNV.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) 
                                                    VALUES(:MANV, :TENNV, :PHAI, TO_DATE(:NGAYSINH,'YYYY/MM/DD'), :DIACHI, :SODT, :VAITRO, null, :PHG)";
                                cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                                cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                                cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                                cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                                cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                                cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                                cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                                cmd.Parameters.Add(new OracleParameter(":PHG", PHG));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công!");
                            }
                            else
                            {
                                OracleCommand cmd = OracleDB.conn.CreateCommand();
                                cmd.CommandText = @"INSERT INTO ATBM_QLNV.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) 
                                                    VALUES(:MANV, :TENNV, :PHAI, TO_DATE(:NGAYSINH,'YYYY/MM/DD'), :DIACHI, :SODT, :VAITRO, :MANQL, :PHG)";
                                cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                                cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                                cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                                cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                                cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                                cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                                cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                                cmd.Parameters.Add(new OracleParameter(":MANQL", MANQL));
                                cmd.Parameters.Add(new OracleParameter(":PHG", PHG));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền thông tin phòng ban!");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        }

        private void Them_cbbVAITRO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Them_cbbPHG.Enabled = true;
            Them_cbbMANQL.Enabled = true;
            string VAITRO = Them_cbbVAITRO.Text;
            if (VAITRO == "Ban giam doc")
            {
                Them_cbbPHG.Enabled = false;
                Them_cbbPHG.Text = "";
                Them_cbbMANQL.Enabled = false;
                Them_cbbMANQL.Text = "";
            }
            else if (VAITRO == "Truong phong")
            {
                Them_cbbMANQL.Enabled = false;
                Them_cbbMANQL.Text = "";
            }
        }

        private void CapNhat_cbbVAITRO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat_cbbPHG.Enabled = true;
            CapNhat_cbbMANQL.Enabled = true;
            string VAITRO = CapNhat_cbbVAITRO.Text;
            if (VAITRO == "Ban giam doc")
            {
                CapNhat_cbbPHG.Enabled = false;
                CapNhat_cbbPHG.Text = "";
                CapNhat_cbbMANQL.Enabled = false;
                CapNhat_cbbMANQL.Text = "";
            }
            else if (VAITRO == "Truong phong")
            {
                CapNhat_cbbMANQL.Enabled = false;
                CapNhat_cbbMANQL.Text = "";
            }
        }

        private void CapNhat_cbbMANV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.NHANVIEN WHERE MANV = :MANV";
                cmd.Parameters.Add(new OracleParameter(":MANV", CapNhat_cbbMANV.Text));
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    CapNhat_txbTENNV.Text = dr["TENNV"].ToString();
                    CapNhat_cbbPHAI.Text = dr["PHAI"].ToString();
                    CapNhat_dtpNGAYSINH.Value = DateTime.Parse(dr["NGAYSINH"].ToString());
                    CapNhat_txbDIACHI.Text = dr["DIACHI"].ToString();
                    CapNhat_txbSODT.Text = dr["SODT"].ToString();
                    CapNhat_cbbVAITRO.Text = dr["VAITRO"].ToString();
                    string MANQL = dr["MANQL"].ToString();
                    if (!(MANQL is null) && MANQL != "")
                    {
                        CapNhat_cbbMANQL.Text = MANQL;

                    }
                    string PHG = dr["PHG"].ToString();
                    if (!(PHG is null) && PHG != "")
                    {
                        CapNhat_cbbPHG.Text = PHG;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MANV = CapNhat_cbbMANV.Text;
            string TENNV = CapNhat_txbTENNV.Text;
            string PHAI = CapNhat_cbbPHAI.Text;
            string NGAYSINH = CapNhat_dtpNGAYSINH.Value.ToString("yyyy/MM/dd");
            string DIACHI = CapNhat_txbDIACHI.Text;
            string SODT = CapNhat_txbSODT.Text;
            string VAITRO = CapNhat_cbbVAITRO.Text;
            string MANQL = CapNhat_cbbMANQL.Text;
            string PHG = CapNhat_cbbPHG.Text;
            if (MANV != "" && TENNV != "" && PHAI != "" && NGAYSINH != "" && DIACHI != "" && SODT != "" && VAITRO != "")
            {
                try
                {
                    //Ban giám đốc không có người quản lý trực tiếp và không thuộc phòng ban nào
                    if (VAITRO == "Ban giam doc")
                    {
                        OracleCommand cmd = OracleDB.conn.CreateCommand();
                        cmd.CommandText = @"UPDATE ATBM_QLNV.NHANVIEN
                                            SET TENNV = :TENNV, PHAI = :PHAI, NGAYSINH = TO_DATE(:NGAYSINH,'YYYY/MM/DD'), 
                                                DIACHI = :DIACHI, SODT = :SODT, VAITRO = :VAITRO
                                            WHERE MANV = :MANV";
                        cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                        cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                        cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                        cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                        cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                        cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                        cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        if (PHG != "")
                        {
                            if (MANQL == "")
                            {
                                OracleCommand cmd = OracleDB.conn.CreateCommand();
                                cmd.CommandText = @"UPDATE ATBM_QLNV.NHANVIEN
                                                    SET TENNV = :TENNV, PHAI = :PHAI, NGAYSINH = TO_DATE(:NGAYSINH,'YYYY/MM/DD'), 
                                                        DIACHI = :DIACHI, SODT = :SODT, VAITRO = :VAITRO, MANQL = null, PHG = :PHG
                                                    WHERE MANV = :MANV";
                                cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                                cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                                cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                                cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                                cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                                cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                                cmd.Parameters.Add(new OracleParameter(":PHG", PHG));
                                cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cập nhật thành công!");
                            }
                            else
                            {
                                OracleCommand cmd = OracleDB.conn.CreateCommand();
                                cmd.CommandText = @"UPDATE ATBM_QLNV.NHANVIEN
                                                    SET TENNV = :TENNV, PHAI = :PHAI, NGAYSINH = TO_DATE(:NGAYSINH,'YYYY/MM/DD'), 
                                                        DIACHI = :DIACHI, SODT = :SODT, VAITRO = :VAITRO, MANQL = :MANQL, PHG = :PHG
                                                    WHERE MANV = :MANV";
                                cmd.Parameters.Add(new OracleParameter(":TENNV", TENNV));
                                cmd.Parameters.Add(new OracleParameter(":PHAI", PHAI));
                                cmd.Parameters.Add(new OracleParameter(":NGAYSINH", NGAYSINH));
                                cmd.Parameters.Add(new OracleParameter(":DIACHI", DIACHI));
                                cmd.Parameters.Add(new OracleParameter(":SODT", SODT));
                                cmd.Parameters.Add(new OracleParameter(":VAITRO", VAITRO));
                                cmd.Parameters.Add(new OracleParameter(":MANQL", MANQL));
                                cmd.Parameters.Add(new OracleParameter(":PHG", PHG));
                                cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền thông tin phòng ban!");
                        }
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
    }
}

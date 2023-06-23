using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Team18.Database;

namespace Team18.Forms
{
    public partial class NhanVien_Form_NVInfo : Form
    {
        public NhanVien_Form_NVInfo()
        {
            InitializeComponent();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT NGAYSINH, DIACHI, SODT FROM ATBM_QLNV.NHANVIEN WHERE 'NV'||MANV = USER";
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                birthdayDatePicker.Value = DateTime.Parse(reader[0].ToString());
                addressTxb.Text = reader[1].ToString();
                phoneNumberTxb.Text = reader[2].ToString();
            }
            reader.Close();
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
                    var isNumeric_LUONG = int.TryParse(LUONG, out _);
                    if (!isNumeric_LUONG)
                        LUONG = Encryption.DecryptData(LUONG, Encryption.GetKey());
                    dr["LUONG"] = LUONG;
                    string PHUCAP = dr["PHUCAP"].ToString();
                    var isNumeric_PHUCAP = int.TryParse(PHUCAP, out _);
                    if (!isNumeric_PHUCAP)
                        PHUCAP = Encryption.DecryptData(PHUCAP, Encryption.GetKey());
                    dr["PHUCAP"] = PHUCAP;
                }
                nhanVienInfoDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string birthday = birthdayDatePicker.Value.ToString("yyyy/MM/dd");
            string address = addressTxb.Text;
            string phoneNumber = phoneNumberTxb.Text;
            if (birthday != "" && address != "" && phoneNumber != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET NGAYSINH = TO_DATE(:birthday,'YYYY/MM/DD'), DIACHI = :address, SODT = :phoneNumber";
                    cmd.Parameters.Add(new OracleParameter("birthday", birthday));
                    cmd.Parameters.Add(new OracleParameter("address", address));
                    cmd.Parameters.Add(new OracleParameter("phoneNumber", phoneNumber));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    btnLoad_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");


        }

    }
}

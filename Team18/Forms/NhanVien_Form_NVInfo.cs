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
            cmd.CommandText = "SELECT NGAYSINH, DIACHI, SODT FROM ATBM_QLNV.NHANVIEN";
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
                cmd.CommandText = "SELECT * FROM ATBM_QLNV.NHANVIEN";
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
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
            if (birthday != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET NGAYSINH = TO_DATE(:birthday,'YYYY/MM/DD')";
                    cmd.Parameters.Add(new OracleParameter("birthday", birthday));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            if (address!="")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET DIACHI = :address";
                    cmd.Parameters.Add(new OracleParameter("address", address));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            if (phoneNumber!="")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET SODT = :phoneNumber";
                    cmd.Parameters.Add(new OracleParameter("phoneNumber", phoneNumber));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            MessageBox.Show("Cập nhật thành công!");
            
        }

    }
}

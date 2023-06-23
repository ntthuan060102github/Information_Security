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
    public partial class TaiChinh_Form_UpdateNV : Form
    {
        public TaiChinh_Form_UpdateNV()
        {
            InitializeComponent();
            MANV_cbb.Items.Clear();
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT MANV FROM ATBM_QLNV.NHANVIEN";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MANV = reader.GetString(0);
                MANV_cbb.Items.Add(MANV);
            }
            reader.Close();
        }

        private void MANV_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = OracleDB.conn.CreateCommand();
            cmd.CommandText = "SELECT LUONG, PHUCAP FROM ATBM_QLNV.NHANVIEN WHERE MANV = :MANV";
            cmd.Parameters.Add(new OracleParameter(":MANV", MANV_cbb.Text));
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string LUONG = reader.GetString(0);
                var isNumeric_LUONG = int.TryParse(LUONG, out _);
                if (!isNumeric_LUONG)
                    LUONG = Encryption.DecryptData(LUONG, Encryption.GetKey());
                LUONG_txb.Text = LUONG;
                string PHUCAP = reader.GetString(1);
                var isNumeric_PHUCAP = int.TryParse(PHUCAP, out _);
                if (!isNumeric_PHUCAP)
                    PHUCAP = Encryption.DecryptData(PHUCAP, Encryption.GetKey());
                PHUCAP_txb.Text = PHUCAP;
            }
            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string encrypted_LUONG = Encryption.EncryptData(LUONG_txb.Text, Encryption.GetKey());
            string encrypted_PHUCAP = Encryption.EncryptData(PHUCAP_txb.Text, Encryption.GetKey());
            string MANV = MANV_cbb.Text;
            if (encrypted_LUONG != "" && encrypted_PHUCAP != "" && MANV != "")
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandText = "UPDATE ATBM_QLNV.NHANVIEN SET LUONG = :LUONG, PHUCAP = :PHUCAP WHERE MANV = :MANV";
                    cmd.Parameters.Add(new OracleParameter(":LUONG", encrypted_LUONG));
                    cmd.Parameters.Add(new OracleParameter(":PHUCAP", encrypted_PHUCAP));
                    cmd.Parameters.Add(new OracleParameter(":MANV", MANV));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
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

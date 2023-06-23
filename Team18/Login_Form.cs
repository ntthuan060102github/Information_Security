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

namespace Team18
{
    public partial class Login_Form : Form
    {
        private string username="";
        private string password="";
        private string role = "";
        public Login_Form()
        {
            InitializeComponent();
            roleCbb.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txbUsername.Text;
            password = txbPassword.Text;
            role = roleCbb.Text;
            

            if (username == "" && false)
            {
                MessageBox.Show("Vui lòng nhập Username","Error");
            }
            else
            {
                try
                {
                    OracleDB.connectToOracle(username, password);
                    if (role == "DBA")
                    {
                        try
                        {

                            OracleCommand cmd = OracleDB.conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * FROM dba_role_privs " +
                                "WHERE GRANTEE = USER AND GRANTED_ROLE = 'DBA'";
                            string user = cmd.ExecuteScalar().ToString();
                            MessageBox.Show("Đăng nhập thành công!");
                            DBUtils.set_username(username);
                            DBUtils.set_password(password);
                            DBA_Home home = new DBA_Home();
                            this.Hide();
                            home.ShowDialog();
                            this.Show();
                        }
                        catch
                        {
                            MessageBox.Show("User không có quyền quản trị (DBA)");
                        }
                    }
                    else if (role == "Nhân viên" && OracleDB.getRoleOfUser(username) == "Nhan vien")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        NhanVien_Home home = new NhanVien_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "QL trực tiếp" && OracleDB.getRoleOfUser(username) == "QL truc tiep")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        QLTrucTiep_Home home = new QLTrucTiep_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Trưởng phòng" && OracleDB.getRoleOfUser(username) == "Truong phong")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        TruongPhong_Home home = new TruongPhong_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Tài chính" && OracleDB.getRoleOfUser(username) == "Tai chinh")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        TaiChinh_Home home = new TaiChinh_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Nhân sự" && OracleDB.getRoleOfUser(username) == "Nhan su")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        TruongDeAn_Home home = new TruongDeAn_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Trưởng đề án" && OracleDB.getRoleOfUser(username) == "Truong de an")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        TruongDeAn_Home home = new TruongDeAn_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Ban giám đốc" && OracleDB.getRoleOfUser(username) == "Ban giam doc")
                    {
                        DBUtils.set_username(username);
                        DBUtils.set_password(password);
                        BanGiamDoc_Home home = new BanGiamDoc_Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Show();
                    }
                    else if (role != OracleDB.getRoleOfUser(username))
                    {
                        MessageBox.Show("User không được cấp role " + role);
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DBA_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

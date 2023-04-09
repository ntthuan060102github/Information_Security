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

namespace Team18
{
    public partial class DBA_Login : Form
    {
        private string username="";
        private string password="";
        public DBA_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txbUsername.Text;
            password = txbPassword.Text;
            

            if (username == "" && false)
            {
                MessageBox.Show("Vui lòng nhập Username","Error");
            }
            else
            {    
                try
                {
                    OracleDB.connectToOracle(username, password);
                    try
                    {

                        OracleCommand cmd = OracleDB.conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM dba_role_privs " +
                            "WHERE GRANTEE = USER AND GRANTED_ROLE = 'DBA'";
                        string user = cmd.ExecuteScalar().ToString();
                        MessageBox.Show("Đăng nhập thành công!");
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
                catch (Exception ex)
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

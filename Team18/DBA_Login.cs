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
            

            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập Username","Error");
            }
            else
            {
                try
                {
                    OracleDB.createConnectionString(username, password);
                    OracleConnection conn = new OracleConnection(OracleDB.connectionString);
                    conn.Open();
                    MessageBox.Show("Đăng nhập thành công!");
                    DBA_Home home = new DBA_Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

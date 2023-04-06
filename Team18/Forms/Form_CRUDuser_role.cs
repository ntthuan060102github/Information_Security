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
using Tutorial.SqlConn;

namespace Team18.Forms
{
    public partial class Form_CRUDuser_role : Form
    {
        public Form_CRUDuser_role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = this.textBox1.Text;
                string password = this.textBox2.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(
                        "Invalid username or password!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                DBOracleParameters parameters = new DBOracleParameters();
                parameters.Add(new OracleParameter("I_USERNAME", OracleDbType.Varchar2), username);
                parameters.Add(new OracleParameter("I_PASSWORD", OracleDbType.Varchar2), password);

                var save = DBOracleUtils.ExecProc("SP_CREATE_USER", ref parameters);
                MessageBox.Show(
                    "Success!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show(
                    "Username already exists!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role_name = this.textBox3.Text;

            if (string.IsNullOrEmpty(role_name))
            {
                MessageBox.Show(
                    "Invalid role name!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DBOracleParameters parameters = new DBOracleParameters();
            parameters.Add(new OracleParameter("I_ROLENAME", OracleDbType.Varchar2), "ROLE_" + role_name);
            DBOracleUtils.ExecProc("SP_CREATE_ROLE", ref parameters);
            MessageBox.Show(
                "Success!",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

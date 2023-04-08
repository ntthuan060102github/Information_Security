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
            DataTable dt = new DataTable();

            DBOracleUtils.ExecProc_OutputDataTable("SP_VIEW_USER_ROLE", ref dt);
            
            foreach(DataRow row in dt.Rows)
            {
                this.comboBox1.Items.Add(row["USERTYPE"] + " - " + row["USERNAME"]);
            }

            DBOracleUtils.ExecProc_OutputDataTable("SP_VIEW_LIST_USER", ref dt);

            foreach (DataRow row in dt.Rows)
            {
                this.comboBox2.Items.Add(row["USERNAME"]);
            }
            this.radioButton1.Checked = true;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select the user or role to delete",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string[] input = this.comboBox1.Text.Replace(" - ", "#").Split('#');
            DBOracleParameters parameters = new DBOracleParameters();
            parameters.Add(new OracleParameter("I_USERTYPE", OracleDbType.Varchar2), input[0]);
            parameters.Add(new OracleParameter("I_USERNAME", OracleDbType.Varchar2), input[1]);

            DBOracleUtils.ExecProc("SP_DROP_USER", ref parameters);
            MessageBox.Show(
                    "Success",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select the user to lock or unlock",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }   
            string username = this.comboBox2.Text;
            string action_type = this.radioButton1.Checked ? "LOCK" : "UNLOCK";

            DBOracleParameters parameters = new DBOracleParameters();
            parameters.Add(new OracleParameter("ACTION_TYPE", OracleDbType.Varchar2), action_type);
            parameters.Add(new OracleParameter("USERNAME", OracleDbType.Varchar2), username);

            DBOracleUtils.ExecProc("SP_LOCK_UNLOCK_USER", ref parameters);
            MessageBox.Show(
                    "Success",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

        }
    }
}

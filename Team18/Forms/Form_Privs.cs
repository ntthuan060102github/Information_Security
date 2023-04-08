using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Team18.Forms
{
    public partial class Form_Privs : Form
    {
        public Form_Privs()
        {
            InitializeComponent();
            if (tabControlPrivs.SelectedTab.Text == "Cấp quyền")
            {
                this.comboBoxPrivsSys.Enabled = false;
                this.comboBoxSubjectSys.Enabled = false;
                this.ckbWGO_Sys.Enabled = false;
                this.btnGrantSys.Enabled = false;

                this.comboBoxPrivsTab.Enabled = false;
                this.comboBoxSubjectTab.Enabled = false;
                this.comboBoxObjTab.Enabled = false;
                this.ckbWGO_Tab.Enabled = false;
                this.btnGrantTab.Enabled = false;
                this.comboBoxUser.Enabled = false;
                this.comboBoxRole.Enabled = false;
                this.btnGrantRoleToUser.Enabled = false;
                comboBoxPrivsSys.Items.Clear();
                comboBoxSubjectSys.Items.Clear();
                comboBoxSubjectTab.Items.Clear();
                comboBoxPrivsTab.Items.Clear();
                comboBoxObjTab.Items.Clear();
                comboBoxUser.Items.Clear();
                comboBoxRole.Items.Clear();
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT DISTINCT PRIVILEGE FROM USER_SYS_PRIVS";
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        comboBoxPrivsSys.Items.Add(r1.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT USERNAME FROM ALL_USERS";
                    OracleDataReader r2 = cmd.ExecuteReader();
                    while (r2.Read())
                    {
                        comboBoxSubjectSys.Items.Add(r2.GetString(0));
                        comboBoxSubjectTab.Items.Add(r2.GetString(0));
                        comboBoxUser.Items.Add(r2.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                    OracleDataReader r3 = cmd.ExecuteReader();
                    while (r3.Read())
                    {
                        comboBoxSubjectSys.Items.Add(r3.GetString(0));
                        comboBoxSubjectTab.Items.Add(r3.GetString(0));
                        comboBoxRole.Items.Add(r3.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT PRIVILEGE FROM DBA_TAB_PRIVS";
                    OracleDataReader r4 = cmd.ExecuteReader();
                    while (r4.Read())
                    {
                        comboBoxPrivsTab.Items.Add(r4.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT OBJECT_NAME FROM USER_OBJECTS";
                    OracleDataReader r5 = cmd.ExecuteReader();
                    while (r5.Read())
                    {
                        comboBoxObjTab.Items.Add(r5.GetString(0));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            


        }

        private void tabControlPrivs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrivs.SelectedTab.Text == "Cấp quyền")
            {
                this.comboBoxPrivsSys.Enabled = false;
                this.comboBoxSubjectSys.Enabled = false;
                this.ckbWGO_Sys.Enabled = false;
                this.btnGrantSys.Enabled = false;

                this.comboBoxPrivsTab.Enabled = false;
                this.comboBoxSubjectTab.Enabled = false;
                this.comboBoxObjTab.Enabled = false;
                this.ckbWGO_Tab.Enabled = false;
                this.btnGrantTab.Enabled = false;
                this.comboBoxUser.Enabled = false;
                this.comboBoxRole.Enabled = false;
                this.btnGrantRoleToUser.Enabled = false;
                comboBoxPrivsSys.Items.Clear();
                comboBoxSubjectSys.Items.Clear();
                comboBoxSubjectTab.Items.Clear();
                comboBoxPrivsTab.Items.Clear();
                comboBoxObjTab.Items.Clear();
                comboBoxUser.Items.Clear();
                comboBoxRole.Items.Clear();
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT DISTINCT PRIVILEGE FROM USER_SYS_PRIVS";
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        comboBoxPrivsSys.Items.Add(r1.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT USERNAME FROM ALL_USERS";
                    OracleDataReader r2 = cmd.ExecuteReader();
                    while (r2.Read())
                    {
                        comboBoxSubjectSys.Items.Add(r2.GetString(0));
                        comboBoxSubjectTab.Items.Add(r2.GetString(0));
                        comboBoxUser.Items.Add(r2.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                    OracleDataReader r3 = cmd.ExecuteReader();
                    while (r3.Read())
                    {
                        comboBoxSubjectSys.Items.Add(r3.GetString(0));
                        comboBoxSubjectTab.Items.Add(r3.GetString(0));
                        comboBoxRole.Items.Add(r3.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT PRIVILEGE FROM DBA_TAB_PRIVS";
                    OracleDataReader r4 = cmd.ExecuteReader();
                    while (r4.Read())
                    {
                        comboBoxPrivsTab.Items.Add(r4.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT OBJECT_NAME FROM USER_OBJECTS";
                    OracleDataReader r5 = cmd.ExecuteReader();
                    while (r5.Read())
                    {
                        comboBoxObjTab.Items.Add(r5.GetString(0));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (tabControlPrivs.SelectedTab.Text == "Kiểm tra quyền")
            {
                this.comboBoxUser_Role.Items.Clear();
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT DISTINCT USERNAME FROM ALL_USERS";
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        comboBoxUser_Role.Items.Add(r1.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                    OracleDataReader r2 = cmd.ExecuteReader();
                    while (r2.Read())
                    {
                        comboBoxUser_Role.Items.Add(r2.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBtnSys_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnSys.Checked == true)
            {
                this.comboBoxPrivsSys.Enabled = true;
                this.comboBoxSubjectSys.Enabled = true;
                this.ckbWGO_Sys.Enabled = true;
                this.btnGrantSys.Enabled = true;
            }
            else
            {
                this.comboBoxPrivsSys.Enabled = false;
                this.comboBoxSubjectSys.Enabled = false;
                this.ckbWGO_Sys.Enabled = false;
                this.btnGrantSys.Enabled = false;
            }
        }

        private void radioBtnTab_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnTab.Checked == true)
            {
                this.comboBoxPrivsTab.Enabled = true;
                this.comboBoxSubjectTab.Enabled = true;
                this.comboBoxObjTab.Enabled = true;
                this.ckbWGO_Tab.Enabled = true;
                this.btnGrantTab.Enabled = true;
            }
            else
            {
                this.comboBoxPrivsTab.Enabled = false;
                this.comboBoxSubjectTab.Enabled = false;
                this.comboBoxObjTab.Enabled = false;
                this.ckbWGO_Tab.Enabled = false;
                this.btnGrantTab.Enabled = false;
            }
        }

        private void radioBtnRoleUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBtnRoleUser.Checked == true)
            {
                this.comboBoxUser.Enabled = true;
                this.comboBoxRole.Enabled = true;
                this.btnGrantRoleToUser.Enabled = true;
            }
            else
            {
                this.comboBoxUser.Enabled = false;
                this.comboBoxRole.Enabled = false;
                this.btnGrantRoleToUser.Enabled = false;
            }
        }

        private void btnGrantSys_Click(object sender, EventArgs e)
        {
            int with_grant_option = 0;
            if (ckbWGO_Sys.Checked)
                with_grant_option = 1;
            if (comboBoxPrivsSys.SelectedItem != null && comboBoxSubjectSys.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_GRANT_SYS_PRIVS";
                cmd.Parameters.Add(new OracleParameter("privs", comboBoxPrivsSys.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("subject", comboBoxSubjectSys.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("with_grant_option", with_grant_option));
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnGrantTab_Click(object sender, EventArgs e)
        {
            int with_grant_option = 0;
            if (ckbWGO_Tab.Checked)
                with_grant_option = 1;
            if (comboBoxPrivsTab.SelectedItem != null && comboBoxSubjectTab.SelectedItem != null && comboBoxObjTab.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_GRANT_TAB_PRIVS";
                cmd.Parameters.Add(new OracleParameter("privs", comboBoxPrivsTab.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("subject", comboBoxSubjectTab.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("obj", comboBoxObjTab.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("with_grant_option", with_grant_option));
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnGrantRoleToUser_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem != null && comboBoxUser.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Grant " + comboBoxRole.SelectedItem.ToString() + " to " + comboBoxUser.SelectedItem.ToString();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp role cho user thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void btnCheckPrivs_Click(object sender, EventArgs e)
        {
            if (comboBoxUser_Role.SelectedItem != null)
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_VIEW_SYS_PRIVILEGE";
                    cmd.Parameters.Add(new OracleParameter("I_SUBJECT", comboBoxUser_Role.SelectedItem.ToString()));
                    cmd.Parameters.Add("O_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    OracleDataAdapter dataAdapter1 = new OracleDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    dataAdapter1.Fill(dt1);
                    this.dgCheckSysPrivs.DataSource = dt1.DefaultView;

                    OracleCommand cmd2 = OracleDB.conn.CreateCommand();
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "SP_VIEW_TAB_PRIVILEGE";
                    cmd2.Parameters.Add(new OracleParameter("I_SUBJECT", comboBoxUser_Role.SelectedItem.ToString()));
                    cmd2.Parameters.Add("O_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    OracleDataAdapter dataAdapter2 = new OracleDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    dataAdapter2.Fill(dt2);
                    this.dgCheckTabPrivs.DataSource = dt2.DefaultView;

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        
    }
}

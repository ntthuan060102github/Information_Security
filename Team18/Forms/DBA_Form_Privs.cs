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
using System.Xml.Linq;
using Team18.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Team18.Forms
{
    public partial class DBA_Form_Privs : Form
    {
        public DBA_Form_Privs()
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

            if (tabControlPrivs.SelectedTab.Text == "Thu hồi quyền")
            {
                panelRevokeSys.Enabled = false;
                panelRevokeTab.Enabled = false;
                cbbSubjectSys_Revoke.Items.Clear();
                cbbSubjectTab_Revoke.Items.Clear();
                cbbPrivsSys_Revoke.Items.Clear();
                cbbPrivsSys_Revoke.Items.Add("Vui lòng chọn user/role");
                cbbPrivsSys_Revoke.SelectedIndex = 0;
                cbbPrivsTab_Revoke.Items.Clear();
                cbbPrivsTab_Revoke.Items.Add("Vui lòng chọn user/role và đối tượng");
                cbbPrivsTab_Revoke.SelectedIndex = 0;
                cbbObjTab_Revoke.Items.Clear();
                cbbObjTab_Revoke.Items.Add("Vui lòng chọn user/role");
                cbbObjTab_Revoke.SelectedIndex = 0;
                try 
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT DISTINCT USERNAME FROM ALL_USERS";
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        cbbSubjectSys_Revoke.Items.Add(r1.GetString(0));
                        cbbSubjectTab_Revoke.Items.Add(r1.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                    OracleDataReader r2 = cmd.ExecuteReader();
                    while (r2.Read())
                    {
                        cbbSubjectSys_Revoke.Items.Add(r2.GetString(0));
                        cbbSubjectTab_Revoke.Items.Add(r2.GetString(0));
                    }
                } 
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (tabControlPrivs.SelectedTab.Text == "Kiểm tra quyền")
            {
                this.dgCheckSysPrivs.DataSource = null;
                this.dgCheckTabPrivs.DataSource = null;
                this.comboBoxUser_Role.Items.Clear();
                this.comboBoxUser_Role.Text = "";
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

            if (tabControlPrivs.SelectedTab.Text == "Chỉnh sửa quyền")
            {     
                cbbSubject_Edit.Text = "";
                cbbCMD_Edit.Text = "";
                cbbPrivs_Edit.Text = "";
                cbbObj_Edit.Text = "";
                ckbWGO_Edit.Checked = false;
                cbbSubject_Edit.Items.Clear();
                cbbObj_Edit.Items.Clear();
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT DISTINCT USERNAME FROM ALL_USERS";
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        cbbSubject_Edit.Items.Add(r1.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT ROLE FROM DBA_ROLES";
                    OracleDataReader r2 = cmd.ExecuteReader();
                    while (r2.Read())
                    {
                        cbbSubject_Edit.Items.Add(r2.GetString(0));
                    }

                    cmd.CommandText = "SELECT DISTINCT OBJECT_NAME FROM USER_OBJECTS";
                    OracleDataReader r3 = cmd.ExecuteReader();
                    while (r3.Read())
                    {
                        cbbObj_Edit.Items.Add(r3.GetString(0));
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

        private void comboBoxObjTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObjTab.SelectedItem != null)
            {
                comboBoxPrivsTab.Items.Clear();
                comboBoxPrivsTab.Text = "";
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT DISTINCT PRIVILEGE FROM ALL_TAB_PRIVS WHERE TYPE IN (SELECT OBJECT_TYPE FROM DBA_OBJECTS WHERE OBJECT_NAME = :obj)";
                    cmd.Parameters.Add(new OracleParameter("obj", comboBoxObjTab.SelectedItem.ToString()));
                    OracleDataReader r4 = cmd.ExecuteReader();
                    while (r4.Read())
                    {
                        comboBoxPrivsTab.Items.Add(r4.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void radioBtnRevokeSys_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRevokeSys.Checked)
            {
                panelRevokeSys.Enabled = true;
            }
            else
            {
                panelRevokeSys.Enabled = false;
            }
        }

        private void radioBtnRevokeTab_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRevokeTab.Checked)
            {
                panelRevokeTab.Enabled = true;
            }
            else
            {
                panelRevokeTab.Enabled = false;
            }
        }

        private void cbbSubjectSys_Revoke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrivsSys_Revoke.Items.Clear();
            cbbPrivsSys_Revoke.Text = "";
            if (cbbSubjectSys_Revoke.SelectedItem != null)
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT PRIVILEGE " +
                                        "FROM DBA_SYS_PRIVS " +
                                        "WHERE GRANTEE = :subject " +
                                        "UNION " +
                                        "SELECT PRIVILEGE " +
                                        "FROM ROLE_SYS_PRIVS " +
                                        "WHERE ROLE = :subject " +
                                        "ORDER BY PRIVILEGE ASC";
                    cmd.Parameters.Add(new OracleParameter(":subject", cbbSubjectSys_Revoke.SelectedItem.ToString()));
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        cbbPrivsSys_Revoke.Items.Add(r1.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void cbbSubjectTab_Revoke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbObjTab_Revoke.Items.Clear();
            cbbObjTab_Revoke.Text = "";
            if (cbbSubjectTab_Revoke.SelectedItem != null)
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT TABLE_NAME "+
                                        "FROM DBA_TAB_PRIVS "+
                                        "WHERE GRANTEE = :subject " +

                                        "UNION "+
                                        "SELECT TABLE_NAME "+
                                        "FROM DBA_COL_PRIVS "+
                                        "WHERE GRANTEE = :subject " +

                                        "UNION "+
                                        "SELECT TABLE_NAME "+
                                        "FROM ROLE_TAB_PRIVS "+
                                        "WHERE ROLE = :subject " +
                                        "ORDER BY TABLE_NAME ASC";
                    cmd.Parameters.Add(new OracleParameter(":subject", cbbSubjectTab_Revoke.SelectedItem.ToString()));
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        cbbObjTab_Revoke.Items.Add(r1.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void cbbObjTab_Revoke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrivsTab_Revoke.Items.Clear();
            if (cbbSubjectTab_Revoke.SelectedItem != null)
            {
                cbbPrivsTab_Revoke.Text = "";
            }
            if (cbbObjTab_Revoke.SelectedItem != null && cbbSubjectTab_Revoke.SelectedItem != null)
            {
                try
                {
                    OracleCommand cmd = OracleDB.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT PRIVILEGE "+
                                        "FROM DBA_TAB_PRIVS "+
                                        "WHERE GRANTEE = :subject AND TABLE_NAME = :obj "+

                                        "UNION "+
                                        "SELECT PRIVILEGE "+
                                        "FROM DBA_COL_PRIVS "+
                                        "WHERE GRANTEE = :subject AND TABLE_NAME = :obj "+

                                        "UNION "+
                                        "SELECT PRIVILEGE "+
                                        "FROM ROLE_TAB_PRIVS "+
                                        "WHERE ROLE = :subject AND TABLE_NAME = :obj "+
                                        "ORDER BY PRIVILEGE ASC";
                    cmd.Parameters.Add(new OracleParameter(":subject", cbbSubjectTab_Revoke.SelectedItem.ToString()));
                    cmd.Parameters.Add(new OracleParameter(":obj", cbbObjTab_Revoke.SelectedItem.ToString()));
                    OracleDataReader r1 = cmd.ExecuteReader();
                    while (r1.Read())
                    {
                        cbbPrivsTab_Revoke.Items.Add(r1.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRevokeSys_Click(object sender, EventArgs e)
        {
            if (cbbPrivsSys_Revoke.SelectedItem != null && cbbSubjectSys_Revoke.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_REVOKE_SYS_PRIVS";
                cmd.Parameters.Add(new OracleParameter("subject", cbbSubjectSys_Revoke.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("privs", cbbPrivsSys_Revoke.SelectedItem.ToString()));
                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thu hồi quyền thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRevokeTab_Click(object sender, EventArgs e)
        {
            if (cbbPrivsTab_Revoke.SelectedItem != null && cbbSubjectTab_Revoke.SelectedItem != null && cbbObjTab_Revoke.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_REVOKE_TAB_PRIVS";
                cmd.Parameters.Add(new OracleParameter("subject", cbbSubjectTab_Revoke.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("obj", cbbObjTab_Revoke.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("privs", cbbPrivsTab_Revoke.SelectedItem.ToString()));

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thu hồi quyền thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditPrivs_Click(object sender, EventArgs e)
        {
            bool with_grant_option = false;
            if (ckbWGO_Edit.Checked)
                with_grant_option = true;
            if (cbbSubject_Edit.SelectedItem != null && cbbCMD_Edit.SelectedItem != null && cbbPrivs_Edit.SelectedItem != null && cbbObj_Edit.SelectedItem != null)
            {
                OracleCommand cmd = OracleDB.conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EDIT_PRIVILEGE_TO_USER";
                cmd.Parameters.Add(new OracleParameter("I_CMD", cbbCMD_Edit.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("I_USER", cbbSubject_Edit.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("I_OBJECT", cbbObj_Edit.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("I_PRIVILEGE_TYPE", cbbPrivs_Edit.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("I_COLUMN_LIST", null));
                cmd.Parameters.Add(new OracleParameter("I_GRANT_OPTION", with_grant_option));
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa quyền thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}

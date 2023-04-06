namespace Team18.Forms
{
    partial class Form_ViewPrivs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view_privs__grantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_privs__object_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_privs__column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_privs___priv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_privs__grantable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_privs__type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view_privs__grantee,
            this.view_privs__object_name,
            this.view_privs__column,
            this.view_privs___priv,
            this.view_privs__grantable,
            this.view_privs__type});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // view_privs__grantee
            // 
            this.view_privs__grantee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_privs__grantee.HeaderText = "Grantee";
            this.view_privs__grantee.MinimumWidth = 6;
            this.view_privs__grantee.Name = "view_privs__grantee";
            this.view_privs__grantee.ReadOnly = true;
            // 
            // view_privs__object_name
            // 
            this.view_privs__object_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_privs__object_name.HeaderText = "Object Name";
            this.view_privs__object_name.MinimumWidth = 6;
            this.view_privs__object_name.Name = "view_privs__object_name";
            this.view_privs__object_name.ReadOnly = true;
            // 
            // view_privs__column
            // 
            this.view_privs__column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_privs__column.HeaderText = "Column";
            this.view_privs__column.MinimumWidth = 6;
            this.view_privs__column.Name = "view_privs__column";
            this.view_privs__column.ReadOnly = true;
            // 
            // view_privs___priv
            // 
            this.view_privs___priv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_privs___priv.HeaderText = "Privilege";
            this.view_privs___priv.MinimumWidth = 6;
            this.view_privs___priv.Name = "view_privs___priv";
            this.view_privs___priv.ReadOnly = true;
            // 
            // view_privs__grantable
            // 
            this.view_privs__grantable.HeaderText = "Grantable";
            this.view_privs__grantable.MinimumWidth = 6;
            this.view_privs__grantable.Name = "view_privs__grantable";
            this.view_privs__grantable.ReadOnly = true;
            this.view_privs__grantable.Width = 125;
            // 
            // view_privs__type
            // 
            this.view_privs__type.HeaderText = "Type";
            this.view_privs__type.MinimumWidth = 6;
            this.view_privs__type.Name = "view_privs__type";
            this.view_privs__type.ReadOnly = true;
            this.view_privs__type.Width = 125;
            // 
            // Form_ViewPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ViewPrivs";
            this.Text = "Quyền của user/role";
            this.Load += new System.EventHandler(this.Form_ViewPrivs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs__grantee;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs__object_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs__column;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs___priv;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs__grantable;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_privs__type;
    }
}
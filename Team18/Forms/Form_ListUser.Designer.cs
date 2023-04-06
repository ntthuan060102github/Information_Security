namespace Team18.Forms
{
    partial class Form_ListUser
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
            this.list_user__username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_user__user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_user__account_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_user__created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_user__username,
            this.list_user__user_id,
            this.list_user__account_status,
            this.list_user__created_at});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // list_user__username
            // 
            this.list_user__username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.list_user__username.HeaderText = "Username";
            this.list_user__username.MinimumWidth = 6;
            this.list_user__username.Name = "list_user__username";
            this.list_user__username.ReadOnly = true;
            // 
            // list_user__user_id
            // 
            this.list_user__user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.list_user__user_id.HeaderText = "User Id";
            this.list_user__user_id.MinimumWidth = 6;
            this.list_user__user_id.Name = "list_user__user_id";
            this.list_user__user_id.ReadOnly = true;
            // 
            // list_user__account_status
            // 
            this.list_user__account_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.list_user__account_status.HeaderText = "Account Status";
            this.list_user__account_status.MinimumWidth = 6;
            this.list_user__account_status.Name = "list_user__account_status";
            this.list_user__account_status.ReadOnly = true;
            // 
            // list_user__created_at
            // 
            this.list_user__created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.list_user__created_at.HeaderText = "Created At";
            this.list_user__created_at.MinimumWidth = 6;
            this.list_user__created_at.Name = "list_user__created_at";
            this.list_user__created_at.ReadOnly = true;
            // 
            // Form_ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ListUser";
            this.Text = "Danh sách user";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_user__username;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_user__user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_user__account_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_user__created_at;
    }
}
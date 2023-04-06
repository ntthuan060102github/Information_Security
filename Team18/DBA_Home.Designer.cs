namespace Team18
{
    partial class DBA_Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEditPrivs = new System.Windows.Forms.Button();
            this.btnCheckPrivs = new System.Windows.Forms.Button();
            this.btnRevokePrivs = new System.Windows.Forms.Button();
            this.btnGrantPrivs = new System.Windows.Forms.Button();
            this.btnCRUDuser_role = new System.Windows.Forms.Button();
            this.btnViewPrivs = new System.Windows.Forms.Button();
            this.btnListUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnEditPrivs);
            this.panelMenu.Controls.Add(this.btnCheckPrivs);
            this.panelMenu.Controls.Add(this.btnRevokePrivs);
            this.panelMenu.Controls.Add(this.btnGrantPrivs);
            this.panelMenu.Controls.Add(this.btnCRUDuser_role);
            this.panelMenu.Controls.Add(this.btnViewPrivs);
            this.panelMenu.Controls.Add(this.btnListUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEditPrivs
            // 
            this.btnEditPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditPrivs.FlatAppearance.BorderSize = 0;
            this.btnEditPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPrivs.Location = new System.Drawing.Point(0, 357);
            this.btnEditPrivs.Name = "btnEditPrivs";
            this.btnEditPrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnEditPrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditPrivs.Size = new System.Drawing.Size(214, 44);
            this.btnEditPrivs.TabIndex = 7;
            this.btnEditPrivs.Text = "Chỉnh sửa quyền";
            this.btnEditPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPrivs.UseVisualStyleBackColor = true;
            this.btnEditPrivs.Click += new System.EventHandler(this.btnEditPrivs_Click);
            // 
            // btnCheckPrivs
            // 
            this.btnCheckPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckPrivs.FlatAppearance.BorderSize = 0;
            this.btnCheckPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckPrivs.Location = new System.Drawing.Point(0, 313);
            this.btnCheckPrivs.Name = "btnCheckPrivs";
            this.btnCheckPrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCheckPrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckPrivs.Size = new System.Drawing.Size(214, 44);
            this.btnCheckPrivs.TabIndex = 6;
            this.btnCheckPrivs.Text = "Kiểm tra quyền";
            this.btnCheckPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckPrivs.UseVisualStyleBackColor = true;
            this.btnCheckPrivs.Click += new System.EventHandler(this.btnCheckPrivs_Click);
            // 
            // btnRevokePrivs
            // 
            this.btnRevokePrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevokePrivs.FlatAppearance.BorderSize = 0;
            this.btnRevokePrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevokePrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokePrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRevokePrivs.Location = new System.Drawing.Point(0, 269);
            this.btnRevokePrivs.Name = "btnRevokePrivs";
            this.btnRevokePrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnRevokePrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRevokePrivs.Size = new System.Drawing.Size(214, 44);
            this.btnRevokePrivs.TabIndex = 5;
            this.btnRevokePrivs.Text = "Thu hồi quyền";
            this.btnRevokePrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevokePrivs.UseVisualStyleBackColor = true;
            this.btnRevokePrivs.Click += new System.EventHandler(this.btnRevokePrivs_Click);
            // 
            // btnGrantPrivs
            // 
            this.btnGrantPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrantPrivs.FlatAppearance.BorderSize = 0;
            this.btnGrantPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrantPrivs.Location = new System.Drawing.Point(0, 225);
            this.btnGrantPrivs.Name = "btnGrantPrivs";
            this.btnGrantPrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnGrantPrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGrantPrivs.Size = new System.Drawing.Size(214, 44);
            this.btnGrantPrivs.TabIndex = 4;
            this.btnGrantPrivs.Text = "Cấp quyền";
            this.btnGrantPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantPrivs.UseVisualStyleBackColor = true;
            this.btnGrantPrivs.Click += new System.EventHandler(this.btnGrantPrivs_Click);
            // 
            // btnCRUDuser_role
            // 
            this.btnCRUDuser_role.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCRUDuser_role.FlatAppearance.BorderSize = 0;
            this.btnCRUDuser_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRUDuser_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRUDuser_role.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCRUDuser_role.Location = new System.Drawing.Point(0, 166);
            this.btnCRUDuser_role.Name = "btnCRUDuser_role";
            this.btnCRUDuser_role.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCRUDuser_role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCRUDuser_role.Size = new System.Drawing.Size(214, 59);
            this.btnCRUDuser_role.TabIndex = 3;
            this.btnCRUDuser_role.Text = "Thêm, xóa, sửa user/role";
            this.btnCRUDuser_role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRUDuser_role.UseVisualStyleBackColor = true;
            this.btnCRUDuser_role.Click += new System.EventHandler(this.btnCRUDuser_role_Click);
            // 
            // btnViewPrivs
            // 
            this.btnViewPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewPrivs.FlatAppearance.BorderSize = 0;
            this.btnViewPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewPrivs.Location = new System.Drawing.Point(0, 122);
            this.btnViewPrivs.Name = "btnViewPrivs";
            this.btnViewPrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnViewPrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewPrivs.Size = new System.Drawing.Size(214, 44);
            this.btnViewPrivs.TabIndex = 2;
            this.btnViewPrivs.Text = "Quyền của user/role";
            this.btnViewPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPrivs.UseVisualStyleBackColor = true;
            this.btnViewPrivs.Click += new System.EventHandler(this.btnViewPrivs_Click);
            // 
            // btnListUser
            // 
            this.btnListUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUser.FlatAppearance.BorderSize = 0;
            this.btnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListUser.Location = new System.Drawing.Point(0, 78);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnListUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListUser.Size = new System.Drawing.Size(214, 44);
            this.btnListUser.TabIndex = 1;
            this.btnListUser.Text = "Danh sách user";
            this.btnListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(214, 78);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team 18";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1268, 78);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(610, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(90, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(214, 78);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1268, 675);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng cho người quản trị cơ sở dữ liệu";
            // 
            // DBA_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "DBA_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBA App";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Button btnEditPrivs;
        private System.Windows.Forms.Button btnCheckPrivs;
        private System.Windows.Forms.Button btnRevokePrivs;
        private System.Windows.Forms.Button btnGrantPrivs;
        private System.Windows.Forms.Button btnCRUDuser_role;
        private System.Windows.Forms.Button btnViewPrivs;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
    }
}
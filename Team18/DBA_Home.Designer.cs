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
            this.btnPrivs = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.btnPrivs);
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
            // btnPrivs
            // 
            this.btnPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrivs.FlatAppearance.BorderSize = 0;
            this.btnPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivs.Location = new System.Drawing.Point(0, 225);
            this.btnPrivs.Name = "btnPrivs";
            this.btnPrivs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnPrivs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrivs.Size = new System.Drawing.Size(214, 44);
            this.btnPrivs.TabIndex = 4;
            this.btnPrivs.Text = "Phân quyền";
            this.btnPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivs.UseVisualStyleBackColor = true;
            this.btnPrivs.Click += new System.EventHandler(this.btnPrivs_Click);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(559, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Location = new System.Drawing.Point(214, 78);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1268, 675);
            this.panelChildForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 336);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Button btnPrivs;
        private System.Windows.Forms.Button btnCRUDuser_role;
        private System.Windows.Forms.Button btnViewPrivs;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
    }
}
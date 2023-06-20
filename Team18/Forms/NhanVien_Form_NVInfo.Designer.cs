namespace Team18.Forms
{
    partial class NhanVien_Form_NVInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.view = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.nhanVienInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Privs_Sys = new System.Windows.Forms.Label();
            this.addressTxb = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoDataGridView)).BeginInit();
            this.update.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.view);
            this.tabControl.Controls.Add(this.update);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1250, 628);
            this.tabControl.TabIndex = 0;
            // 
            // view
            // 
            this.view.Controls.Add(this.btnLoad);
            this.view.Controls.Add(this.nhanVienInfoDataGridView);
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(4, 34);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(3);
            this.view.Size = new System.Drawing.Size(1242, 590);
            this.view.TabIndex = 0;
            this.view.Text = "Xem thông tin";
            this.view.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1098, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(138, 37);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // nhanVienInfoDataGridView
            // 
            this.nhanVienInfoDataGridView.AllowUserToAddRows = false;
            this.nhanVienInfoDataGridView.AllowUserToDeleteRows = false;
            this.nhanVienInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nhanVienInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nhanVienInfoDataGridView.Location = new System.Drawing.Point(3, 64);
            this.nhanVienInfoDataGridView.Name = "nhanVienInfoDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienInfoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.nhanVienInfoDataGridView.RowHeadersWidth = 51;
            this.nhanVienInfoDataGridView.RowTemplate.Height = 24;
            this.nhanVienInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.nhanVienInfoDataGridView.Size = new System.Drawing.Size(1236, 523);
            this.nhanVienInfoDataGridView.TabIndex = 0;
            // 
            // update
            // 
            this.update.Controls.Add(this.btnUpdate);
            this.update.Controls.Add(this.label2);
            this.update.Controls.Add(this.phoneNumberTxb);
            this.update.Controls.Add(this.label1);
            this.update.Controls.Add(this.birthdayDatePicker);
            this.update.Controls.Add(this.Privs_Sys);
            this.update.Controls.Add(this.addressTxb);
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(4, 34);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(3);
            this.update.Size = new System.Drawing.Size(1242, 590);
            this.update.TabIndex = 1;
            this.update.Text = "Cập nhật thông tin";
            this.update.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(497, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại:";
            // 
            // phoneNumberTxb
            // 
            this.phoneNumberTxb.Location = new System.Drawing.Point(441, 301);
            this.phoneNumberTxb.Multiline = true;
            this.phoneNumberTxb.Name = "phoneNumberTxb";
            this.phoneNumberTxb.Size = new System.Drawing.Size(428, 30);
            this.phoneNumberTxb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Địa chỉ:";
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.CustomFormat = "";
            this.birthdayDatePicker.Location = new System.Drawing.Point(441, 66);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(428, 30);
            this.birthdayDatePicker.TabIndex = 2;
            // 
            // Privs_Sys
            // 
            this.Privs_Sys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Privs_Sys.Location = new System.Drawing.Point(224, 66);
            this.Privs_Sys.Name = "Privs_Sys";
            this.Privs_Sys.Size = new System.Drawing.Size(174, 30);
            this.Privs_Sys.TabIndex = 1;
            this.Privs_Sys.Text = "Ngày sinh:";
            // 
            // addressTxb
            // 
            this.addressTxb.Location = new System.Drawing.Point(441, 165);
            this.addressTxb.Multiline = true;
            this.addressTxb.Name = "addressTxb";
            this.addressTxb.Size = new System.Drawing.Size(428, 80);
            this.addressTxb.TabIndex = 0;
            // 
            // NhanVien_Form_NVInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.Controls.Add(this.tabControl);
            this.Name = "NhanVien_Form_NVInfo";
            this.Text = "Thông tin nhân viên";
            this.tabControl.ResumeLayout(false);
            this.view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoDataGridView)).EndInit();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage view;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.DataGridView nhanVienInfoDataGridView;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox addressTxb;
        private System.Windows.Forms.Label Privs_Sys;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberTxb;
        private System.Windows.Forms.Button btnUpdate;
    }
}
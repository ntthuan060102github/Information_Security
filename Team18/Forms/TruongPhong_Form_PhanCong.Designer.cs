namespace Team18.Forms
{
    partial class TruongPhong_Form_PhanCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Them_THOIGIAN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Xoa_MANV = new System.Windows.Forms.ComboBox();
            this.Xoa_MADA = new System.Windows.Forms.ComboBox();
            this.CapNhat_MADA = new System.Windows.Forms.ComboBox();
            this.CapNhat_MANV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CapNhat_THOIGIAN = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.Them_MANV = new System.Windows.Forms.ComboBox();
            this.Them_MADA = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 628);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Them_MADA);
            this.panel2.Controls.Add(this.Them_MANV);
            this.panel2.Controls.Add(this.Them_THOIGIAN);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 628);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.CapNhat_THOIGIAN);
            this.panel3.Controls.Add(this.CapNhat_MADA);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CapNhat_MANV);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(823, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 628);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Xoa_MADA);
            this.panel4.Controls.Add(this.Xoa_MANV);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(407, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 628);
            this.panel4.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(127, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 37);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(156, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "THÊM";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(168, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "XÓA";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(144, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "CẬP NHẬT";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã đề án:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thời gian:";
            // 
            // Them_THOIGIAN
            // 
            this.Them_THOIGIAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_THOIGIAN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Them_THOIGIAN.Location = new System.Drawing.Point(182, 314);
            this.Them_THOIGIAN.Name = "Them_THOIGIAN";
            this.Them_THOIGIAN.Size = new System.Drawing.Size(207, 30);
            this.Them_THOIGIAN.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã đề án:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 35);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã nhân viên:";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(138, 447);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 37);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Xoa_MANV
            // 
            this.Xoa_MANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_MANV.FormattingEnabled = true;
            this.Xoa_MANV.Location = new System.Drawing.Point(195, 129);
            this.Xoa_MANV.Name = "Xoa_MANV";
            this.Xoa_MANV.Size = new System.Drawing.Size(207, 33);
            this.Xoa_MANV.TabIndex = 21;
            // 
            // Xoa_MADA
            // 
            this.Xoa_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_MADA.FormattingEnabled = true;
            this.Xoa_MADA.Location = new System.Drawing.Point(195, 222);
            this.Xoa_MADA.Name = "Xoa_MADA";
            this.Xoa_MADA.Size = new System.Drawing.Size(207, 33);
            this.Xoa_MADA.TabIndex = 22;
            // 
            // CapNhat_MADA
            // 
            this.CapNhat_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_MADA.FormattingEnabled = true;
            this.CapNhat_MADA.Location = new System.Drawing.Point(204, 222);
            this.CapNhat_MADA.Name = "CapNhat_MADA";
            this.CapNhat_MADA.Size = new System.Drawing.Size(207, 33);
            this.CapNhat_MADA.TabIndex = 26;
            // 
            // CapNhat_MANV
            // 
            this.CapNhat_MANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_MANV.FormattingEnabled = true;
            this.CapNhat_MANV.Location = new System.Drawing.Point(204, 129);
            this.CapNhat_MANV.Name = "CapNhat_MANV";
            this.CapNhat_MANV.Size = new System.Drawing.Size(207, 33);
            this.CapNhat_MANV.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 35);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mã đề án:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 35);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã nhân viên:";
            // 
            // CapNhat_THOIGIAN
            // 
            this.CapNhat_THOIGIAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_THOIGIAN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CapNhat_THOIGIAN.Location = new System.Drawing.Point(204, 309);
            this.CapNhat_THOIGIAN.Name = "CapNhat_THOIGIAN";
            this.CapNhat_THOIGIAN.Size = new System.Drawing.Size(207, 30);
            this.CapNhat_THOIGIAN.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 35);
            this.label11.TabIndex = 17;
            this.label11.Text = "Thời gian:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(153, 447);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(138, 37);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Them_MANV
            // 
            this.Them_MANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_MANV.FormattingEnabled = true;
            this.Them_MANV.Location = new System.Drawing.Point(182, 126);
            this.Them_MANV.Name = "Them_MANV";
            this.Them_MANV.Size = new System.Drawing.Size(207, 33);
            this.Them_MANV.TabIndex = 23;
            // 
            // Them_MADA
            // 
            this.Them_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_MADA.FormattingEnabled = true;
            this.Them_MADA.Location = new System.Drawing.Point(182, 217);
            this.Them_MADA.Name = "Them_MADA";
            this.Them_MADA.Size = new System.Drawing.Size(207, 33);
            this.Them_MADA.TabIndex = 23;
            // 
            // TruongPhong_Form_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.Controls.Add(this.panel1);
            this.Name = "TruongPhong_Form_PhanCong";
            this.Text = "Thêm, xóa, cập nhật phân công";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Them_THOIGIAN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox Xoa_MADA;
        private System.Windows.Forms.ComboBox Xoa_MANV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DateTimePicker CapNhat_THOIGIAN;
        private System.Windows.Forms.ComboBox CapNhat_MADA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CapNhat_MANV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Them_MADA;
        private System.Windows.Forms.ComboBox Them_MANV;
    }
}
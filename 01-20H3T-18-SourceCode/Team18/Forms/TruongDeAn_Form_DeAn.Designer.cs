namespace Team18.Forms
{
    partial class TruongDeAn_Form_DeAn
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Them_NGAYBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Them_MADA = new System.Windows.Forms.TextBox();
            this.Them_TENDA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Them_PHONG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CapNhat_PHONG = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CapNhat_TENDA = new System.Windows.Forms.TextBox();
            this.CapNhat_NGAYBD = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CapNhat_MADA = new System.Windows.Forms.ComboBox();
            this.Xoa_MADA = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.CapNhat_MADA);
            this.panel3.Controls.Add(this.CapNhat_PHONG);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CapNhat_TENDA);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CapNhat_NGAYBD);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(823, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 628);
            this.panel3.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(149, 505);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(138, 37);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Them_PHONG);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Them_TENDA);
            this.panel2.Controls.Add(this.Them_MADA);
            this.panel2.Controls.Add(this.Them_NGAYBD);
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
            // Them_NGAYBD
            // 
            this.Them_NGAYBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_NGAYBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Them_NGAYBD.Location = new System.Drawing.Point(182, 333);
            this.Them_NGAYBD.Name = "Them_NGAYBD";
            this.Them_NGAYBD.Size = new System.Drawing.Size(207, 30);
            this.Them_NGAYBD.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên đề án:";
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
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(130, 505);
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
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã đề án:";
            // 
            // Them_MADA
            // 
            this.Them_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_MADA.Location = new System.Drawing.Point(182, 131);
            this.Them_MADA.Multiline = true;
            this.Them_MADA.Name = "Them_MADA";
            this.Them_MADA.Size = new System.Drawing.Size(207, 33);
            this.Them_MADA.TabIndex = 34;
            // 
            // Them_TENDA
            // 
            this.Them_TENDA.Location = new System.Drawing.Point(182, 213);
            this.Them_TENDA.Multiline = true;
            this.Them_TENDA.Name = "Them_TENDA";
            this.Them_TENDA.Size = new System.Drawing.Size(207, 70);
            this.Them_TENDA.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 35);
            this.label12.TabIndex = 36;
            this.label12.Text = "Phòng:";
            // 
            // Them_PHONG
            // 
            this.Them_PHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_PHONG.FormattingEnabled = true;
            this.Them_PHONG.Location = new System.Drawing.Point(182, 418);
            this.Them_PHONG.Name = "Them_PHONG";
            this.Them_PHONG.Size = new System.Drawing.Size(207, 33);
            this.Them_PHONG.TabIndex = 23;
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
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(144, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 37);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Xoa_MADA);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(407, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 628);
            this.panel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 35);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã đề án:";
            // 
            // CapNhat_PHONG
            // 
            this.CapNhat_PHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_PHONG.FormattingEnabled = true;
            this.CapNhat_PHONG.Location = new System.Drawing.Point(200, 408);
            this.CapNhat_PHONG.Name = "CapNhat_PHONG";
            this.CapNhat_PHONG.Size = new System.Drawing.Size(207, 33);
            this.CapNhat_PHONG.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 35);
            this.label8.TabIndex = 44;
            this.label8.Text = "Phòng:";
            // 
            // CapNhat_TENDA
            // 
            this.CapNhat_TENDA.Location = new System.Drawing.Point(200, 203);
            this.CapNhat_TENDA.Multiline = true;
            this.CapNhat_TENDA.Name = "CapNhat_TENDA";
            this.CapNhat_TENDA.Size = new System.Drawing.Size(207, 70);
            this.CapNhat_TENDA.TabIndex = 43;
            // 
            // CapNhat_NGAYBD
            // 
            this.CapNhat_NGAYBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_NGAYBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CapNhat_NGAYBD.Location = new System.Drawing.Point(200, 323);
            this.CapNhat_NGAYBD.Name = "CapNhat_NGAYBD";
            this.CapNhat_NGAYBD.Size = new System.Drawing.Size(207, 30);
            this.CapNhat_NGAYBD.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 35);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 35);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tên đề án:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 35);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mã đề án:";
            // 
            // CapNhat_MADA
            // 
            this.CapNhat_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat_MADA.FormattingEnabled = true;
            this.CapNhat_MADA.Location = new System.Drawing.Point(200, 121);
            this.CapNhat_MADA.Name = "CapNhat_MADA";
            this.CapNhat_MADA.Size = new System.Drawing.Size(207, 33);
            this.CapNhat_MADA.TabIndex = 45;
            this.CapNhat_MADA.SelectedIndexChanged += new System.EventHandler(this.CapNhat_MADA_SelectedIndexChanged);
            // 
            // Xoa_MADA
            // 
            this.Xoa_MADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_MADA.FormattingEnabled = true;
            this.Xoa_MADA.Location = new System.Drawing.Point(173, 126);
            this.Xoa_MADA.Name = "Xoa_MADA";
            this.Xoa_MADA.Size = new System.Drawing.Size(207, 33);
            this.Xoa_MADA.TabIndex = 46;
            // 
            // TruongDeAn_Form_DeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.Controls.Add(this.panel1);
            this.Name = "TruongDeAn_Form_DeAn";
            this.Text = "Thêm, xóa, cập nhật đề án";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Them_NGAYBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Them_MADA;
        private System.Windows.Forms.ComboBox Them_PHONG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Them_TENDA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CapNhat_PHONG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CapNhat_TENDA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker CapNhat_NGAYBD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CapNhat_MADA;
        private System.Windows.Forms.ComboBox Xoa_MADA;
    }
}
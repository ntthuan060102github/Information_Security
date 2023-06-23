namespace Team18.Forms
{
    partial class TaiChinh_Form_UpdateNV
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
            this.label2 = new System.Windows.Forms.Label();
            this.PHUCAP_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LUONG_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.MANV_cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phụ cấp:";
            // 
            // PHUCAP_txb
            // 
            this.PHUCAP_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHUCAP_txb.Location = new System.Drawing.Point(481, 372);
            this.PHUCAP_txb.Multiline = true;
            this.PHUCAP_txb.Name = "PHUCAP_txb";
            this.PHUCAP_txb.Size = new System.Drawing.Size(428, 42);
            this.PHUCAP_txb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lương:";
            // 
            // LUONG_txb
            // 
            this.LUONG_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUONG_txb.Location = new System.Drawing.Point(481, 239);
            this.LUONG_txb.Multiline = true;
            this.LUONG_txb.Name = "LUONG_txb";
            this.LUONG_txb.Size = new System.Drawing.Size(428, 42);
            this.LUONG_txb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã nhân viên:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(526, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MANV_cbb
            // 
            this.MANV_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV_cbb.FormattingEnabled = true;
            this.MANV_cbb.ItemHeight = 25;
            this.MANV_cbb.Location = new System.Drawing.Point(481, 103);
            this.MANV_cbb.Name = "MANV_cbb";
            this.MANV_cbb.Size = new System.Drawing.Size(428, 33);
            this.MANV_cbb.TabIndex = 13;
            this.MANV_cbb.SelectedIndexChanged += new System.EventHandler(this.MANV_cbb_SelectedIndexChanged);
            // 
            // TaiChinh_Form_UpdateNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.Controls.Add(this.MANV_cbb);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PHUCAP_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LUONG_txb);
            this.Name = "TaiChinh_Form_UpdateNV";
            this.Text = "Cập nhật lương, phụ cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PHUCAP_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LUONG_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox MANV_cbb;
    }
}
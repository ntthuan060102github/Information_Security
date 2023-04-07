namespace Team18.Forms
{
    partial class Form_GrantPrivs
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
            this.radioBtnSys = new System.Windows.Forms.RadioButton();
            this.radioBtnTab = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSys = new System.Windows.Forms.Panel();
            this.btnGrantSys = new System.Windows.Forms.Button();
            this.ckbWGO_Sys = new System.Windows.Forms.CheckBox();
            this.comboBoxSubjectSys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivsSys = new System.Windows.Forms.ComboBox();
            this.Privs_Sys = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.comboBoxObjTab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGrantTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbWGO_Tab = new System.Windows.Forms.CheckBox();
            this.comboBoxPrivsTab = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjectTab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSys.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnSys
            // 
            this.radioBtnSys.AutoSize = true;
            this.radioBtnSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSys.Location = new System.Drawing.Point(233, 28);
            this.radioBtnSys.Name = "radioBtnSys";
            this.radioBtnSys.Size = new System.Drawing.Size(203, 33);
            this.radioBtnSys.TabIndex = 0;
            this.radioBtnSys.TabStop = true;
            this.radioBtnSys.Text = "Quyền hệ thống";
            this.radioBtnSys.UseVisualStyleBackColor = true;
            this.radioBtnSys.CheckedChanged += new System.EventHandler(this.radioBtnSys_CheckedChanged);
            // 
            // radioBtnTab
            // 
            this.radioBtnTab.AutoSize = true;
            this.radioBtnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTab.Location = new System.Drawing.Point(614, 28);
            this.radioBtnTab.Name = "radioBtnTab";
            this.radioBtnTab.Size = new System.Drawing.Size(210, 33);
            this.radioBtnTab.TabIndex = 1;
            this.radioBtnTab.TabStop = true;
            this.radioBtnTab.Text = "Quyền đối tượng";
            this.radioBtnTab.UseVisualStyleBackColor = true;
            this.radioBtnTab.CheckedChanged += new System.EventHandler(this.radioBtnTab_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnSys);
            this.panel1.Controls.Add(this.radioBtnTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 80);
            this.panel1.TabIndex = 2;
            // 
            // panelSys
            // 
            this.panelSys.Controls.Add(this.btnGrantSys);
            this.panelSys.Controls.Add(this.ckbWGO_Sys);
            this.panelSys.Controls.Add(this.comboBoxSubjectSys);
            this.panelSys.Controls.Add(this.label1);
            this.panelSys.Controls.Add(this.comboBoxPrivsSys);
            this.panelSys.Controls.Add(this.Privs_Sys);
            this.panelSys.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSys.Location = new System.Drawing.Point(0, 80);
            this.panelSys.Name = "panelSys";
            this.panelSys.Size = new System.Drawing.Size(528, 448);
            this.panelSys.TabIndex = 3;
            // 
            // btnGrantSys
            // 
            this.btnGrantSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantSys.Location = new System.Drawing.Point(183, 316);
            this.btnGrantSys.Name = "btnGrantSys";
            this.btnGrantSys.Size = new System.Drawing.Size(138, 37);
            this.btnGrantSys.TabIndex = 5;
            this.btnGrantSys.Text = "Cấp quyền";
            this.btnGrantSys.UseVisualStyleBackColor = true;
            this.btnGrantSys.Click += new System.EventHandler(this.btnGrantSys_Click);
            // 
            // ckbWGO_Sys
            // 
            this.ckbWGO_Sys.AutoSize = true;
            this.ckbWGO_Sys.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbWGO_Sys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWGO_Sys.Location = new System.Drawing.Point(17, 242);
            this.ckbWGO_Sys.Name = "ckbWGO_Sys";
            this.ckbWGO_Sys.Size = new System.Drawing.Size(181, 29);
            this.ckbWGO_Sys.TabIndex = 4;
            this.ckbWGO_Sys.Text = "With grant option";
            this.ckbWGO_Sys.UseVisualStyleBackColor = true;
            // 
            // comboBoxSubjectSys
            // 
            this.comboBoxSubjectSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubjectSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubjectSys.FormattingEnabled = true;
            this.comboBoxSubjectSys.Location = new System.Drawing.Point(183, 148);
            this.comboBoxSubjectSys.Name = "comboBoxSubjectSys";
            this.comboBoxSubjectSys.Size = new System.Drawing.Size(305, 24);
            this.comboBoxSubjectSys.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User/role";
            // 
            // comboBoxPrivsSys
            // 
            this.comboBoxPrivsSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPrivsSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPrivsSys.FormattingEnabled = true;
            this.comboBoxPrivsSys.Location = new System.Drawing.Point(183, 42);
            this.comboBoxPrivsSys.Name = "comboBoxPrivsSys";
            this.comboBoxPrivsSys.Size = new System.Drawing.Size(305, 24);
            this.comboBoxPrivsSys.TabIndex = 1;
            // 
            // Privs_Sys
            // 
            this.Privs_Sys.AutoSize = true;
            this.Privs_Sys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Privs_Sys.Location = new System.Drawing.Point(12, 42);
            this.Privs_Sys.Name = "Privs_Sys";
            this.Privs_Sys.Size = new System.Drawing.Size(164, 25);
            this.Privs_Sys.TabIndex = 0;
            this.Privs_Sys.Text = "Quyền (Privilege)";
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.comboBoxObjTab);
            this.panelTab.Controls.Add(this.label4);
            this.panelTab.Controls.Add(this.btnGrantTab);
            this.panelTab.Controls.Add(this.label3);
            this.panelTab.Controls.Add(this.ckbWGO_Tab);
            this.panelTab.Controls.Add(this.comboBoxPrivsTab);
            this.panelTab.Controls.Add(this.comboBoxSubjectTab);
            this.panelTab.Controls.Add(this.label2);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(528, 80);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(510, 448);
            this.panelTab.TabIndex = 4;
            // 
            // comboBoxObjTab
            // 
            this.comboBoxObjTab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxObjTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxObjTab.FormattingEnabled = true;
            this.comboBoxObjTab.Location = new System.Drawing.Point(187, 105);
            this.comboBoxObjTab.Name = "comboBoxObjTab";
            this.comboBoxObjTab.Size = new System.Drawing.Size(305, 24);
            this.comboBoxObjTab.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đối tượng";
            // 
            // btnGrantTab
            // 
            this.btnGrantTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantTab.Location = new System.Drawing.Point(187, 316);
            this.btnGrantTab.Name = "btnGrantTab";
            this.btnGrantTab.Size = new System.Drawing.Size(138, 37);
            this.btnGrantTab.TabIndex = 11;
            this.btnGrantTab.Text = "Cấp quyền";
            this.btnGrantTab.UseVisualStyleBackColor = true;
            this.btnGrantTab.Click += new System.EventHandler(this.btnGrantTab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quyền (Privilege)";
            // 
            // ckbWGO_Tab
            // 
            this.ckbWGO_Tab.AutoSize = true;
            this.ckbWGO_Tab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbWGO_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWGO_Tab.Location = new System.Drawing.Point(21, 242);
            this.ckbWGO_Tab.Name = "ckbWGO_Tab";
            this.ckbWGO_Tab.Size = new System.Drawing.Size(181, 29);
            this.ckbWGO_Tab.TabIndex = 10;
            this.ckbWGO_Tab.Text = "With grant option";
            this.ckbWGO_Tab.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrivsTab
            // 
            this.comboBoxPrivsTab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPrivsTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPrivsTab.FormattingEnabled = true;
            this.comboBoxPrivsTab.Location = new System.Drawing.Point(187, 42);
            this.comboBoxPrivsTab.Name = "comboBoxPrivsTab";
            this.comboBoxPrivsTab.Size = new System.Drawing.Size(305, 24);
            this.comboBoxPrivsTab.TabIndex = 7;
            // 
            // comboBoxSubjectTab
            // 
            this.comboBoxSubjectTab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubjectTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubjectTab.FormattingEnabled = true;
            this.comboBoxSubjectTab.Location = new System.Drawing.Point(187, 169);
            this.comboBoxSubjectTab.Name = "comboBoxSubjectTab";
            this.comboBoxSubjectTab.Size = new System.Drawing.Size(305, 24);
            this.comboBoxSubjectTab.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "User/role";
            // 
            // Form_GrantPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 528);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelSys);
            this.Controls.Add(this.panel1);
            this.Name = "Form_GrantPrivs";
            this.Text = "Cấp quyền";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSys.ResumeLayout(false);
            this.panelSys.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.panelTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnSys;
        private System.Windows.Forms.RadioButton radioBtnTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSys;
        private System.Windows.Forms.Label Privs_Sys;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.ComboBox comboBoxPrivsSys;
        private System.Windows.Forms.ComboBox comboBoxSubjectSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbWGO_Sys;
        private System.Windows.Forms.Button btnGrantSys;
        private System.Windows.Forms.ComboBox comboBoxObjTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrantTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbWGO_Tab;
        private System.Windows.Forms.ComboBox comboBoxPrivsTab;
        private System.Windows.Forms.ComboBox comboBoxSubjectTab;
        private System.Windows.Forms.Label label2;
    }
}
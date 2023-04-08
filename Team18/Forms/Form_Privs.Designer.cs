namespace Team18.Forms
{
    partial class Form_Privs
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
            this.tabControlPrivs = new System.Windows.Forms.TabControl();
            this.tabGrant = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGrantRoleToUser = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.comboBoxObjTab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGrantTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbWGO_Tab = new System.Windows.Forms.CheckBox();
            this.comboBoxPrivsTab = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjectTab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSys = new System.Windows.Forms.Panel();
            this.btnGrantSys = new System.Windows.Forms.Button();
            this.ckbWGO_Sys = new System.Windows.Forms.CheckBox();
            this.comboBoxSubjectSys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivsSys = new System.Windows.Forms.ComboBox();
            this.Privs_Sys = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnRoleUser = new System.Windows.Forms.RadioButton();
            this.radioBtnSys = new System.Windows.Forms.RadioButton();
            this.radioBtnTab = new System.Windows.Forms.RadioButton();
            this.tabRevoke = new System.Windows.Forms.TabPage();
            this.tabCheckPrivs = new System.Windows.Forms.TabPage();
            this.tabEditPrivs = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUser_Role = new System.Windows.Forms.ComboBox();
            this.btnCheckPrivs = new System.Windows.Forms.Button();
            this.dgCheckSysPrivs = new System.Windows.Forms.DataGridView();
            this.dgCheckTabPrivs = new System.Windows.Forms.DataGridView();
            this.tabControlPrivs.SuspendLayout();
            this.tabGrant.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.panelSys.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCheckPrivs.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckSysPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckTabPrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrivs
            // 
            this.tabControlPrivs.Controls.Add(this.tabGrant);
            this.tabControlPrivs.Controls.Add(this.tabRevoke);
            this.tabControlPrivs.Controls.Add(this.tabCheckPrivs);
            this.tabControlPrivs.Controls.Add(this.tabEditPrivs);
            this.tabControlPrivs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrivs.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrivs.Name = "tabControlPrivs";
            this.tabControlPrivs.SelectedIndex = 0;
            this.tabControlPrivs.Size = new System.Drawing.Size(1250, 628);
            this.tabControlPrivs.TabIndex = 1;
            this.tabControlPrivs.SelectedIndexChanged += new System.EventHandler(this.tabControlPrivs_SelectedIndexChanged);
            // 
            // tabGrant
            // 
            this.tabGrant.Controls.Add(this.panel1);
            this.tabGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrant.Location = new System.Drawing.Point(4, 38);
            this.tabGrant.Name = "tabGrant";
            this.tabGrant.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrant.Size = new System.Drawing.Size(1242, 586);
            this.tabGrant.TabIndex = 0;
            this.tabGrant.Text = "Cấp quyền";
            this.tabGrant.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTab);
            this.panel1.Controls.Add(this.panelSys);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 580);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGrantRoleToUser);
            this.panel3.Controls.Add(this.comboBoxRole);
            this.panel3.Controls.Add(this.comboBoxUser);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(869, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 472);
            this.panel3.TabIndex = 14;
            // 
            // btnGrantRoleToUser
            // 
            this.btnGrantRoleToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRoleToUser.Location = new System.Drawing.Point(127, 288);
            this.btnGrantRoleToUser.Name = "btnGrantRoleToUser";
            this.btnGrantRoleToUser.Size = new System.Drawing.Size(138, 37);
            this.btnGrantRoleToUser.TabIndex = 14;
            this.btnGrantRoleToUser.Text = "Cấp role";
            this.btnGrantRoleToUser.UseVisualStyleBackColor = true;
            this.btnGrantRoleToUser.Click += new System.EventHandler(this.btnGrantRoleToUser_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(82, 101);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(260, 24);
            this.comboBoxRole.TabIndex = 16;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(82, 33);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(260, 24);
            this.comboBoxUser.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "User";
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
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTab.Location = new System.Drawing.Point(430, 108);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(439, 472);
            this.panelTab.TabIndex = 7;
            // 
            // comboBoxObjTab
            // 
            this.comboBoxObjTab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxObjTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxObjTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxObjTab.FormattingEnabled = true;
            this.comboBoxObjTab.Location = new System.Drawing.Point(123, 102);
            this.comboBoxObjTab.Name = "comboBoxObjTab";
            this.comboBoxObjTab.Size = new System.Drawing.Size(292, 24);
            this.comboBoxObjTab.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đối tượng";
            // 
            // btnGrantTab
            // 
            this.btnGrantTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantTab.Location = new System.Drawing.Point(139, 288);
            this.btnGrantTab.Name = "btnGrantTab";
            this.btnGrantTab.Size = new System.Drawing.Size(138, 37);
            this.btnGrantTab.TabIndex = 11;
            this.btnGrantTab.Text = "Cấp quyền";
            this.btnGrantTab.UseVisualStyleBackColor = true;
            this.btnGrantTab.Click += new System.EventHandler(this.btnGrantTab_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quyền (Privilege)";
            // 
            // ckbWGO_Tab
            // 
            this.ckbWGO_Tab.AutoSize = true;
            this.ckbWGO_Tab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbWGO_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWGO_Tab.Location = new System.Drawing.Point(21, 203);
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
            this.comboBoxPrivsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrivsTab.FormattingEnabled = true;
            this.comboBoxPrivsTab.Location = new System.Drawing.Point(123, 30);
            this.comboBoxPrivsTab.Name = "comboBoxPrivsTab";
            this.comboBoxPrivsTab.Size = new System.Drawing.Size(292, 24);
            this.comboBoxPrivsTab.TabIndex = 7;
            // 
            // comboBoxSubjectTab
            // 
            this.comboBoxSubjectTab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubjectTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubjectTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectTab.FormattingEnabled = true;
            this.comboBoxSubjectTab.Location = new System.Drawing.Point(123, 158);
            this.comboBoxSubjectTab.Name = "comboBoxSubjectTab";
            this.comboBoxSubjectTab.Size = new System.Drawing.Size(292, 24);
            this.comboBoxSubjectTab.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "User/role";
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
            this.panelSys.Location = new System.Drawing.Point(0, 108);
            this.panelSys.Name = "panelSys";
            this.panelSys.Size = new System.Drawing.Size(430, 472);
            this.panelSys.TabIndex = 6;
            // 
            // btnGrantSys
            // 
            this.btnGrantSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantSys.Location = new System.Drawing.Point(118, 288);
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
            this.ckbWGO_Sys.Location = new System.Drawing.Point(17, 203);
            this.ckbWGO_Sys.Name = "ckbWGO_Sys";
            this.ckbWGO_Sys.Size = new System.Drawing.Size(190, 29);
            this.ckbWGO_Sys.TabIndex = 4;
            this.ckbWGO_Sys.Text = "With admin option";
            this.ckbWGO_Sys.UseVisualStyleBackColor = true;
            // 
            // comboBoxSubjectSys
            // 
            this.comboBoxSubjectSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubjectSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubjectSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectSys.FormattingEnabled = true;
            this.comboBoxSubjectSys.Location = new System.Drawing.Point(118, 105);
            this.comboBoxSubjectSys.Name = "comboBoxSubjectSys";
            this.comboBoxSubjectSys.Size = new System.Drawing.Size(294, 24);
            this.comboBoxSubjectSys.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User/role";
            // 
            // comboBoxPrivsSys
            // 
            this.comboBoxPrivsSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPrivsSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPrivsSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrivsSys.FormattingEnabled = true;
            this.comboBoxPrivsSys.Location = new System.Drawing.Point(118, 29);
            this.comboBoxPrivsSys.Name = "comboBoxPrivsSys";
            this.comboBoxPrivsSys.Size = new System.Drawing.Size(294, 24);
            this.comboBoxPrivsSys.TabIndex = 1;
            // 
            // Privs_Sys
            // 
            this.Privs_Sys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Privs_Sys.Location = new System.Drawing.Point(12, 25);
            this.Privs_Sys.Name = "Privs_Sys";
            this.Privs_Sys.Size = new System.Drawing.Size(100, 57);
            this.Privs_Sys.TabIndex = 0;
            this.Privs_Sys.Text = "Quyền (Privilege)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtnRoleUser);
            this.panel2.Controls.Add(this.radioBtnSys);
            this.panel2.Controls.Add(this.radioBtnTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 108);
            this.panel2.TabIndex = 5;
            // 
            // radioBtnRoleUser
            // 
            this.radioBtnRoleUser.AutoSize = true;
            this.radioBtnRoleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRoleUser.Location = new System.Drawing.Point(951, 36);
            this.radioBtnRoleUser.Name = "radioBtnRoleUser";
            this.radioBtnRoleUser.Size = new System.Drawing.Size(224, 33);
            this.radioBtnRoleUser.TabIndex = 2;
            this.radioBtnRoleUser.TabStop = true;
            this.radioBtnRoleUser.Text = "Cấp role cho user";
            this.radioBtnRoleUser.UseVisualStyleBackColor = true;
            this.radioBtnRoleUser.CheckedChanged += new System.EventHandler(this.radioBtnRoleUser_CheckedChanged);
            // 
            // radioBtnSys
            // 
            this.radioBtnSys.AutoSize = true;
            this.radioBtnSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSys.Location = new System.Drawing.Point(101, 36);
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
            this.radioBtnTab.Location = new System.Drawing.Point(535, 36);
            this.radioBtnTab.Name = "radioBtnTab";
            this.radioBtnTab.Size = new System.Drawing.Size(210, 33);
            this.radioBtnTab.TabIndex = 1;
            this.radioBtnTab.TabStop = true;
            this.radioBtnTab.Text = "Quyền đối tượng";
            this.radioBtnTab.UseVisualStyleBackColor = true;
            this.radioBtnTab.CheckedChanged += new System.EventHandler(this.radioBtnTab_CheckedChanged);
            // 
            // tabRevoke
            // 
            this.tabRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRevoke.Location = new System.Drawing.Point(4, 38);
            this.tabRevoke.Name = "tabRevoke";
            this.tabRevoke.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevoke.Size = new System.Drawing.Size(1242, 586);
            this.tabRevoke.TabIndex = 1;
            this.tabRevoke.Text = "Thu hồi quyền";
            this.tabRevoke.UseVisualStyleBackColor = true;
            // 
            // tabCheckPrivs
            // 
            this.tabCheckPrivs.Controls.Add(this.panel4);
            this.tabCheckPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCheckPrivs.Location = new System.Drawing.Point(4, 38);
            this.tabCheckPrivs.Name = "tabCheckPrivs";
            this.tabCheckPrivs.Size = new System.Drawing.Size(1242, 586);
            this.tabCheckPrivs.TabIndex = 2;
            this.tabCheckPrivs.Text = "Kiểm tra quyền";
            this.tabCheckPrivs.UseVisualStyleBackColor = true;
            // 
            // tabEditPrivs
            // 
            this.tabEditPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditPrivs.Location = new System.Drawing.Point(4, 38);
            this.tabEditPrivs.Name = "tabEditPrivs";
            this.tabEditPrivs.Size = new System.Drawing.Size(1242, 586);
            this.tabEditPrivs.TabIndex = 3;
            this.tabEditPrivs.Text = "Chỉnh sửa quyền";
            this.tabEditPrivs.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dgCheckTabPrivs);
            this.panel4.Controls.Add(this.dgCheckSysPrivs);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1242, 586);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCheckPrivs);
            this.panel5.Controls.Add(this.comboBoxUser_Role);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1242, 113);
            this.panel5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn user/role muốn kiểm tra";
            // 
            // comboBoxUser_Role
            // 
            this.comboBoxUser_Role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUser_Role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUser_Role.FormattingEnabled = true;
            this.comboBoxUser_Role.Location = new System.Drawing.Point(439, 39);
            this.comboBoxUser_Role.Name = "comboBoxUser_Role";
            this.comboBoxUser_Role.Size = new System.Drawing.Size(446, 37);
            this.comboBoxUser_Role.TabIndex = 10;
            // 
            // btnCheckPrivs
            // 
            this.btnCheckPrivs.Location = new System.Drawing.Point(956, 35);
            this.btnCheckPrivs.Name = "btnCheckPrivs";
            this.btnCheckPrivs.Size = new System.Drawing.Size(136, 42);
            this.btnCheckPrivs.TabIndex = 11;
            this.btnCheckPrivs.Text = "Kiểm tra";
            this.btnCheckPrivs.UseVisualStyleBackColor = true;
            this.btnCheckPrivs.Click += new System.EventHandler(this.btnCheckPrivs_Click);
            // 
            // dgCheckSysPrivs
            // 
            this.dgCheckSysPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCheckSysPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckSysPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCheckSysPrivs.Location = new System.Drawing.Point(0, 113);
            this.dgCheckSysPrivs.Name = "dgCheckSysPrivs";
            this.dgCheckSysPrivs.RowHeadersWidth = 51;
            this.dgCheckSysPrivs.RowTemplate.Height = 24;
            this.dgCheckSysPrivs.Size = new System.Drawing.Size(1242, 232);
            this.dgCheckSysPrivs.TabIndex = 1;
            // 
            // dgCheckTabPrivs
            // 
            this.dgCheckTabPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCheckTabPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckTabPrivs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCheckTabPrivs.Location = new System.Drawing.Point(0, 345);
            this.dgCheckTabPrivs.Name = "dgCheckTabPrivs";
            this.dgCheckTabPrivs.RowHeadersWidth = 51;
            this.dgCheckTabPrivs.RowTemplate.Height = 24;
            this.dgCheckTabPrivs.Size = new System.Drawing.Size(1242, 241);
            this.dgCheckTabPrivs.TabIndex = 2;
            // 
            // Form_Privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.Controls.Add(this.tabControlPrivs);
            this.Name = "Form_Privs";
            this.Text = "Phân quyền";
            this.tabControlPrivs.ResumeLayout(false);
            this.tabGrant.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.panelTab.PerformLayout();
            this.panelSys.ResumeLayout(false);
            this.panelSys.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabCheckPrivs.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckSysPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckTabPrivs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrivs;
        private System.Windows.Forms.TabPage tabGrant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGrantRoleToUser;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.ComboBox comboBoxObjTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrantTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbWGO_Tab;
        private System.Windows.Forms.ComboBox comboBoxPrivsTab;
        private System.Windows.Forms.ComboBox comboBoxSubjectTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSys;
        private System.Windows.Forms.Button btnGrantSys;
        private System.Windows.Forms.CheckBox ckbWGO_Sys;
        private System.Windows.Forms.ComboBox comboBoxSubjectSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrivsSys;
        private System.Windows.Forms.Label Privs_Sys;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBtnRoleUser;
        private System.Windows.Forms.RadioButton radioBtnSys;
        private System.Windows.Forms.RadioButton radioBtnTab;
        private System.Windows.Forms.TabPage tabRevoke;
        private System.Windows.Forms.TabPage tabCheckPrivs;
        private System.Windows.Forms.TabPage tabEditPrivs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxUser_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckPrivs;
        private System.Windows.Forms.DataGridView dgCheckSysPrivs;
        private System.Windows.Forms.DataGridView dgCheckTabPrivs;
    }
}
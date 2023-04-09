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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelRevokeTab = new System.Windows.Forms.Panel();
            this.cbbObjTab_Revoke = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRevokeTab = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbPrivsTab_Revoke = new System.Windows.Forms.ComboBox();
            this.cbbSubjectTab_Revoke = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelRevokeSys = new System.Windows.Forms.Panel();
            this.btnRevokeSys = new System.Windows.Forms.Button();
            this.cbbSubjectSys_Revoke = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbPrivsSys_Revoke = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioBtnRevokeSys = new System.Windows.Forms.RadioButton();
            this.radioBtnRevokeTab = new System.Windows.Forms.RadioButton();
            this.tabCheckPrivs = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgCheckTabPrivs = new System.Windows.Forms.DataGridView();
            this.dgCheckSysPrivs = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCheckPrivs = new System.Windows.Forms.Button();
            this.comboBoxUser_Role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabEditPrivs = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbPrivs_Edit = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEditPrivs = new System.Windows.Forms.Button();
            this.ckbWGO_Edit = new System.Windows.Forms.CheckBox();
            this.cbbObj_Edit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbSubject_Edit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbCMD_Edit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControlPrivs.SuspendLayout();
            this.tabGrant.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.panelSys.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRevoke.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelRevokeTab.SuspendLayout();
            this.panelRevokeSys.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabCheckPrivs.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckTabPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckSysPrivs)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabEditPrivs.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.comboBoxObjTab.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjTab_SelectedIndexChanged);
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
            this.tabRevoke.Controls.Add(this.panel6);
            this.tabRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRevoke.Location = new System.Drawing.Point(4, 38);
            this.tabRevoke.Name = "tabRevoke";
            this.tabRevoke.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevoke.Size = new System.Drawing.Size(1242, 586);
            this.tabRevoke.TabIndex = 1;
            this.tabRevoke.Text = "Thu hồi quyền";
            this.tabRevoke.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelRevokeTab);
            this.panel6.Controls.Add(this.panelRevokeSys);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1236, 580);
            this.panel6.TabIndex = 0;
            // 
            // panelRevokeTab
            // 
            this.panelRevokeTab.Controls.Add(this.cbbObjTab_Revoke);
            this.panelRevokeTab.Controls.Add(this.label8);
            this.panelRevokeTab.Controls.Add(this.btnRevokeTab);
            this.panelRevokeTab.Controls.Add(this.label9);
            this.panelRevokeTab.Controls.Add(this.cbbPrivsTab_Revoke);
            this.panelRevokeTab.Controls.Add(this.cbbSubjectTab_Revoke);
            this.panelRevokeTab.Controls.Add(this.label10);
            this.panelRevokeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRevokeTab.Location = new System.Drawing.Point(617, 108);
            this.panelRevokeTab.Name = "panelRevokeTab";
            this.panelRevokeTab.Size = new System.Drawing.Size(619, 472);
            this.panelRevokeTab.TabIndex = 10;
            // 
            // cbbObjTab_Revoke
            // 
            this.cbbObjTab_Revoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbObjTab_Revoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbObjTab_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObjTab_Revoke.FormattingEnabled = true;
            this.cbbObjTab_Revoke.Location = new System.Drawing.Point(123, 108);
            this.cbbObjTab_Revoke.Name = "cbbObjTab_Revoke";
            this.cbbObjTab_Revoke.Size = new System.Drawing.Size(474, 33);
            this.cbbObjTab_Revoke.TabIndex = 13;
            this.cbbObjTab_Revoke.SelectedIndexChanged += new System.EventHandler(this.cbbObjTab_Revoke_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đối tượng";
            // 
            // btnRevokeTab
            // 
            this.btnRevokeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokeTab.Location = new System.Drawing.Point(231, 288);
            this.btnRevokeTab.Name = "btnRevokeTab";
            this.btnRevokeTab.Size = new System.Drawing.Size(138, 37);
            this.btnRevokeTab.TabIndex = 11;
            this.btnRevokeTab.Text = "Thu hồi";
            this.btnRevokeTab.UseVisualStyleBackColor = true;
            this.btnRevokeTab.Click += new System.EventHandler(this.btnRevokeTab_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 53);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quyền (Privilege)";
            // 
            // cbbPrivsTab_Revoke
            // 
            this.cbbPrivsTab_Revoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPrivsTab_Revoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPrivsTab_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivsTab_Revoke.FormattingEnabled = true;
            this.cbbPrivsTab_Revoke.Location = new System.Drawing.Point(123, 192);
            this.cbbPrivsTab_Revoke.Name = "cbbPrivsTab_Revoke";
            this.cbbPrivsTab_Revoke.Size = new System.Drawing.Size(474, 33);
            this.cbbPrivsTab_Revoke.TabIndex = 7;
            // 
            // cbbSubjectTab_Revoke
            // 
            this.cbbSubjectTab_Revoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSubjectTab_Revoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSubjectTab_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectTab_Revoke.FormattingEnabled = true;
            this.cbbSubjectTab_Revoke.Location = new System.Drawing.Point(123, 26);
            this.cbbSubjectTab_Revoke.Name = "cbbSubjectTab_Revoke";
            this.cbbSubjectTab_Revoke.Size = new System.Drawing.Size(474, 33);
            this.cbbSubjectTab_Revoke.TabIndex = 9;
            this.cbbSubjectTab_Revoke.SelectedIndexChanged += new System.EventHandler(this.cbbSubjectTab_Revoke_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "User/role";
            // 
            // panelRevokeSys
            // 
            this.panelRevokeSys.Controls.Add(this.btnRevokeSys);
            this.panelRevokeSys.Controls.Add(this.cbbSubjectSys_Revoke);
            this.panelRevokeSys.Controls.Add(this.label11);
            this.panelRevokeSys.Controls.Add(this.cbbPrivsSys_Revoke);
            this.panelRevokeSys.Controls.Add(this.label12);
            this.panelRevokeSys.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRevokeSys.Location = new System.Drawing.Point(0, 108);
            this.panelRevokeSys.Name = "panelRevokeSys";
            this.panelRevokeSys.Size = new System.Drawing.Size(617, 472);
            this.panelRevokeSys.TabIndex = 9;
            // 
            // btnRevokeSys
            // 
            this.btnRevokeSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokeSys.Location = new System.Drawing.Point(243, 288);
            this.btnRevokeSys.Name = "btnRevokeSys";
            this.btnRevokeSys.Size = new System.Drawing.Size(138, 37);
            this.btnRevokeSys.TabIndex = 5;
            this.btnRevokeSys.Text = "Thu hồi";
            this.btnRevokeSys.UseVisualStyleBackColor = true;
            this.btnRevokeSys.Click += new System.EventHandler(this.btnRevokeSys_Click);
            // 
            // cbbSubjectSys_Revoke
            // 
            this.cbbSubjectSys_Revoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSubjectSys_Revoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSubjectSys_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectSys_Revoke.FormattingEnabled = true;
            this.cbbSubjectSys_Revoke.Location = new System.Drawing.Point(118, 26);
            this.cbbSubjectSys_Revoke.Name = "cbbSubjectSys_Revoke";
            this.cbbSubjectSys_Revoke.Size = new System.Drawing.Size(474, 33);
            this.cbbSubjectSys_Revoke.TabIndex = 3;
            this.cbbSubjectSys_Revoke.SelectedIndexChanged += new System.EventHandler(this.cbbSubjectSys_Revoke_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "User/role";
            // 
            // cbbPrivsSys_Revoke
            // 
            this.cbbPrivsSys_Revoke.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPrivsSys_Revoke.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPrivsSys_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivsSys_Revoke.FormattingEnabled = true;
            this.cbbPrivsSys_Revoke.Location = new System.Drawing.Point(118, 141);
            this.cbbPrivsSys_Revoke.Name = "cbbPrivsSys_Revoke";
            this.cbbPrivsSys_Revoke.Size = new System.Drawing.Size(474, 33);
            this.cbbPrivsSys_Revoke.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 57);
            this.label12.TabIndex = 0;
            this.label12.Text = "Quyền (Privilege)";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radioBtnRevokeSys);
            this.panel9.Controls.Add(this.radioBtnRevokeTab);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1236, 108);
            this.panel9.TabIndex = 8;
            // 
            // radioBtnRevokeSys
            // 
            this.radioBtnRevokeSys.AutoSize = true;
            this.radioBtnRevokeSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRevokeSys.Location = new System.Drawing.Point(206, 36);
            this.radioBtnRevokeSys.Name = "radioBtnRevokeSys";
            this.radioBtnRevokeSys.Size = new System.Drawing.Size(203, 33);
            this.radioBtnRevokeSys.TabIndex = 0;
            this.radioBtnRevokeSys.TabStop = true;
            this.radioBtnRevokeSys.Text = "Quyền hệ thống";
            this.radioBtnRevokeSys.UseVisualStyleBackColor = true;
            this.radioBtnRevokeSys.CheckedChanged += new System.EventHandler(this.radioBtnRevokeSys_CheckedChanged);
            // 
            // radioBtnRevokeTab
            // 
            this.radioBtnRevokeTab.AutoSize = true;
            this.radioBtnRevokeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRevokeTab.Location = new System.Drawing.Point(809, 36);
            this.radioBtnRevokeTab.Name = "radioBtnRevokeTab";
            this.radioBtnRevokeTab.Size = new System.Drawing.Size(210, 33);
            this.radioBtnRevokeTab.TabIndex = 1;
            this.radioBtnRevokeTab.TabStop = true;
            this.radioBtnRevokeTab.Text = "Quyền đối tượng";
            this.radioBtnRevokeTab.UseVisualStyleBackColor = true;
            this.radioBtnRevokeTab.CheckedChanged += new System.EventHandler(this.radioBtnRevokeTab_CheckedChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn user/role muốn kiểm tra";
            // 
            // tabEditPrivs
            // 
            this.tabEditPrivs.Controls.Add(this.panel7);
            this.tabEditPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditPrivs.Location = new System.Drawing.Point(4, 38);
            this.tabEditPrivs.Name = "tabEditPrivs";
            this.tabEditPrivs.Size = new System.Drawing.Size(1242, 586);
            this.tabEditPrivs.TabIndex = 3;
            this.tabEditPrivs.Text = "Chỉnh sửa quyền";
            this.tabEditPrivs.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbPrivs_Edit);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.btnEditPrivs);
            this.panel7.Controls.Add(this.ckbWGO_Edit);
            this.panel7.Controls.Add(this.cbbObj_Edit);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.cbbSubject_Edit);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.cbbCMD_Edit);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1242, 586);
            this.panel7.TabIndex = 0;
            // 
            // cbbPrivs_Edit
            // 
            this.cbbPrivs_Edit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPrivs_Edit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPrivs_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivs_Edit.FormattingEnabled = true;
            this.cbbPrivs_Edit.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE",
            "EXEC"});
            this.cbbPrivs_Edit.Location = new System.Drawing.Point(510, 186);
            this.cbbPrivs_Edit.Name = "cbbPrivs_Edit";
            this.cbbPrivs_Edit.Size = new System.Drawing.Size(474, 33);
            this.cbbPrivs_Edit.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(273, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "Quyền";
            // 
            // btnEditPrivs
            // 
            this.btnEditPrivs.Location = new System.Drawing.Point(546, 427);
            this.btnEditPrivs.Name = "btnEditPrivs";
            this.btnEditPrivs.Size = new System.Drawing.Size(163, 42);
            this.btnEditPrivs.TabIndex = 13;
            this.btnEditPrivs.Text = "Chỉnh sửa";
            this.btnEditPrivs.UseVisualStyleBackColor = true;
            this.btnEditPrivs.Click += new System.EventHandler(this.btnEditPrivs_Click);
            // 
            // ckbWGO_Edit
            // 
            this.ckbWGO_Edit.AutoSize = true;
            this.ckbWGO_Edit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbWGO_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWGO_Edit.Location = new System.Drawing.Point(278, 349);
            this.ckbWGO_Edit.Name = "ckbWGO_Edit";
            this.ckbWGO_Edit.Size = new System.Drawing.Size(181, 29);
            this.ckbWGO_Edit.TabIndex = 12;
            this.ckbWGO_Edit.Text = "With grant option";
            this.ckbWGO_Edit.UseVisualStyleBackColor = true;
            // 
            // cbbObj_Edit
            // 
            this.cbbObj_Edit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbObj_Edit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbObj_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObj_Edit.FormattingEnabled = true;
            this.cbbObj_Edit.Location = new System.Drawing.Point(510, 264);
            this.cbbObj_Edit.Name = "cbbObj_Edit";
            this.cbbObj_Edit.Size = new System.Drawing.Size(474, 33);
            this.cbbObj_Edit.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(273, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Đối tượng";
            // 
            // cbbSubject_Edit
            // 
            this.cbbSubject_Edit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSubject_Edit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSubject_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubject_Edit.FormattingEnabled = true;
            this.cbbSubject_Edit.Location = new System.Drawing.Point(510, 30);
            this.cbbSubject_Edit.Name = "cbbSubject_Edit";
            this.cbbSubject_Edit.Size = new System.Drawing.Size(474, 33);
            this.cbbSubject_Edit.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(273, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "User/Role";
            // 
            // cbbCMD_Edit
            // 
            this.cbbCMD_Edit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCMD_Edit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCMD_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCMD_Edit.FormattingEnabled = true;
            this.cbbCMD_Edit.Items.AddRange(new object[] {
            "GRANT",
            "REVOKE"});
            this.cbbCMD_Edit.Location = new System.Drawing.Point(510, 105);
            this.cbbCMD_Edit.Name = "cbbCMD_Edit";
            this.cbbCMD_Edit.Size = new System.Drawing.Size(474, 33);
            this.cbbCMD_Edit.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Loại chỉnh sửa";
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
            this.tabRevoke.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelRevokeTab.ResumeLayout(false);
            this.panelRevokeTab.PerformLayout();
            this.panelRevokeSys.ResumeLayout(false);
            this.panelRevokeSys.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabCheckPrivs.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckTabPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckSysPrivs)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabEditPrivs.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelRevokeTab;
        private System.Windows.Forms.ComboBox cbbObjTab_Revoke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRevokeTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbPrivsTab_Revoke;
        private System.Windows.Forms.ComboBox cbbSubjectTab_Revoke;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelRevokeSys;
        private System.Windows.Forms.Button btnRevokeSys;
        private System.Windows.Forms.ComboBox cbbSubjectSys_Revoke;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbPrivsSys_Revoke;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioBtnRevokeSys;
        private System.Windows.Forms.RadioButton radioBtnRevokeTab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbCMD_Edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbSubject_Edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbObj_Edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckbWGO_Edit;
        private System.Windows.Forms.Button btnEditPrivs;
        private System.Windows.Forms.ComboBox cbbPrivs_Edit;
        private System.Windows.Forms.Label label16;
    }
}
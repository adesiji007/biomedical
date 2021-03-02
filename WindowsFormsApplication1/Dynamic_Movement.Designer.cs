namespace WindowsFormsApplication1
{
    partial class Dynamic_Movement
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtDynaMoveID = new System.Windows.Forms.TextBox();
            this.lbluser_id = new System.Windows.Forms.Label();
            this.lblDynaMove_ID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxSRADP = new System.Windows.Forms.ComboBox();
            this.comboBoxSRPDCC = new System.Windows.Forms.ComboBox();
            this.comboBoxSRPL = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxSHEP = new System.Windows.Forms.ComboBox();
            this.comboBoxSHEHH = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxASRP = new System.Windows.Forms.ComboBox();
            this.comboBoxASRAB = new System.Windows.Forms.ComboBox();
            this.comboBoxASRFFD = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLMAP = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBoxLMUBM = new System.Windows.Forms.ComboBox();
            this.comboBoxLKF = new System.Windows.Forms.ComboBox();
            this.cboBoxLHKAF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDSPA = new System.Windows.Forms.ComboBox();
            this.comboBoxDSDO = new System.Windows.Forms.ComboBox();
            this.comboBoxDSHBK = new System.Windows.Forms.ComboBox();
            this.comboBoxDSHF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(487, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 402);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(182, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(90, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(744, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 51);
            this.panel2.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Location = new System.Drawing.Point(101, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.txtuserid);
            this.panel8.Controls.Add(this.txtDynaMoveID);
            this.panel8.Controls.Add(this.lbluser_id);
            this.panel8.Controls.Add(this.lblDynaMove_ID);
            this.panel8.Controls.Add(this.dateTimePicker1);
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.lblLastname);
            this.panel8.Controls.Add(this.txtRefNo);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Location = new System.Drawing.Point(7, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(731, 51);
            this.panel8.TabIndex = 39;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(146, 19);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.Size = new System.Drawing.Size(100, 20);
            this.txtuserid.TabIndex = 11;
            // 
            // txtDynaMoveID
            // 
            this.txtDynaMoveID.Location = new System.Drawing.Point(25, 22);
            this.txtDynaMoveID.Name = "txtDynaMoveID";
            this.txtDynaMoveID.ReadOnly = true;
            this.txtDynaMoveID.Size = new System.Drawing.Size(100, 20);
            this.txtDynaMoveID.TabIndex = 11;
            // 
            // lbluser_id
            // 
            this.lbluser_id.AutoSize = true;
            this.lbluser_id.Location = new System.Drawing.Point(154, 0);
            this.lbluser_id.Name = "lbluser_id";
            this.lbluser_id.Size = new System.Drawing.Size(41, 13);
            this.lbluser_id.TabIndex = 10;
            this.lbluser_id.Text = "user_id";
            // 
            // lblDynaMove_ID
            // 
            this.lblDynaMove_ID.AutoSize = true;
            this.lblDynaMove_ID.Location = new System.Drawing.Point(22, 3);
            this.lblDynaMove_ID.Name = "lblDynaMove_ID";
            this.lblDynaMove_ID.Size = new System.Drawing.Size(76, 13);
            this.lblDynaMove_ID.TabIndex = 9;
            this.lblDynaMove_ID.Text = "DynaMove_ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(277, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(49, 13);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Fullname";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(418, 22);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(108, 20);
            this.txtRefNo.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(547, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Assessment Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(425, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Reference No";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.comboBoxSRADP);
            this.panel7.Controls.Add(this.comboBoxSRPDCC);
            this.panel7.Controls.Add(this.comboBoxSRPL);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.Level);
            this.panel7.Controls.Add(this.button13);
            this.panel7.Location = new System.Drawing.Point(6, 405);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(473, 70);
            this.panel7.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Pain";
            // 
            // comboBoxSRADP
            // 
            this.comboBoxSRADP.FormattingEnabled = true;
            this.comboBoxSRADP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSRADP.Location = new System.Drawing.Point(267, 46);
            this.comboBoxSRADP.Name = "comboBoxSRADP";
            this.comboBoxSRADP.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSRADP.TabIndex = 28;
            // 
            // comboBoxSRPDCC
            // 
            this.comboBoxSRPDCC.FormattingEnabled = true;
            this.comboBoxSRPDCC.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSRPDCC.Location = new System.Drawing.Point(267, 25);
            this.comboBoxSRPDCC.Name = "comboBoxSRPDCC";
            this.comboBoxSRPDCC.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSRPDCC.TabIndex = 28;
            // 
            // comboBoxSRPL
            // 
            this.comboBoxSRPL.FormattingEnabled = true;
            this.comboBoxSRPL.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSRPL.Location = new System.Drawing.Point(267, 5);
            this.comboBoxSRPL.Name = "comboBoxSRPL";
            this.comboBoxSRPL.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSRPL.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(112, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Dowell in contact with Chest";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(219, 5);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(33, 13);
            this.Level.TabIndex = 1;
            this.Level.Text = "Level";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(201, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Seated Rotation & Pelvic Disassociation";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.comboBoxSHEP);
            this.panel6.Controls.Add(this.comboBoxSHEHH);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Location = new System.Drawing.Point(6, 343);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(473, 56);
            this.panel6.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(142, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Pain";
            // 
            // comboBoxSHEP
            // 
            this.comboBoxSHEP.FormattingEnabled = true;
            this.comboBoxSHEP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSHEP.Location = new System.Drawing.Point(264, 30);
            this.comboBoxSHEP.Name = "comboBoxSHEP";
            this.comboBoxSHEP.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSHEP.TabIndex = 28;
            // 
            // comboBoxSHEHH
            // 
            this.comboBoxSHEHH.FormattingEnabled = true;
            this.comboBoxSHEHH.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSHEHH.Location = new System.Drawing.Point(264, 3);
            this.comboBoxSHEHH.Name = "comboBoxSHEHH";
            this.comboBoxSHEHH.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSHEHH.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "High Hamstring";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(3, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "Standing Hip Extension";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.comboBoxASRP);
            this.panel5.Controls.Add(this.comboBoxASRAB);
            this.panel5.Controls.Add(this.comboBoxASRFFD);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Location = new System.Drawing.Point(6, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 67);
            this.panel5.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Pain";
            // 
            // comboBoxASRP
            // 
            this.comboBoxASRP.FormattingEnabled = true;
            this.comboBoxASRP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxASRP.Location = new System.Drawing.Point(271, 46);
            this.comboBoxASRP.Name = "comboBoxASRP";
            this.comboBoxASRP.Size = new System.Drawing.Size(184, 21);
            this.comboBoxASRP.TabIndex = 28;
            // 
            // comboBoxASRAB
            // 
            this.comboBoxASRAB.FormattingEnabled = true;
            this.comboBoxASRAB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxASRAB.Location = new System.Drawing.Point(271, 27);
            this.comboBoxASRAB.Name = "comboBoxASRAB";
            this.comboBoxASRAB.Size = new System.Drawing.Size(184, 21);
            this.comboBoxASRAB.TabIndex = 28;
            // 
            // comboBoxASRFFD
            // 
            this.comboBoxASRFFD.FormattingEnabled = true;
            this.comboBoxASRFFD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxASRFFD.Location = new System.Drawing.Point(271, 6);
            this.comboBoxASRFFD.Name = "comboBoxASRFFD";
            this.comboBoxASRFFD.Size = new System.Drawing.Size(184, 21);
            this.comboBoxASRFFD.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ankle Bones 90 Degree";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Foot Flexed";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Active SL Raise";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxLMAP);
            this.panel4.Controls.Add(this.comboBox10);
            this.panel4.Controls.Add(this.comboBoxLMUBM);
            this.panel4.Controls.Add(this.comboBoxLKF);
            this.panel4.Controls.Add(this.cboBoxLHKAF);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Location = new System.Drawing.Point(7, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 100);
            this.panel4.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pain";
            // 
            // comboBoxLMAP
            // 
            this.comboBoxLMAP.FormattingEnabled = true;
            this.comboBoxLMAP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxLMAP.Location = new System.Drawing.Point(270, 66);
            this.comboBoxLMAP.Name = "comboBoxLMAP";
            this.comboBoxLMAP.Size = new System.Drawing.Size(184, 21);
            this.comboBoxLMAP.TabIndex = 28;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox10.Location = new System.Drawing.Point(270, 69);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(184, 21);
            this.comboBox10.TabIndex = 28;
            // 
            // comboBoxLMUBM
            // 
            this.comboBoxLMUBM.FormattingEnabled = true;
            this.comboBoxLMUBM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxLMUBM.Location = new System.Drawing.Point(270, 42);
            this.comboBoxLMUBM.Name = "comboBoxLMUBM";
            this.comboBoxLMUBM.Size = new System.Drawing.Size(184, 21);
            this.comboBoxLMUBM.TabIndex = 28;
            // 
            // comboBoxLKF
            // 
            this.comboBoxLKF.FormattingEnabled = true;
            this.comboBoxLKF.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxLKF.Location = new System.Drawing.Point(270, 23);
            this.comboBoxLKF.Name = "comboBoxLKF";
            this.comboBoxLKF.Size = new System.Drawing.Size(184, 21);
            this.comboBoxLKF.TabIndex = 28;
            this.comboBoxLKF.SelectedIndexChanged += new System.EventHandler(this.comboBoxLKF_SelectedIndexChanged);
            // 
            // cboBoxLHKAF
            // 
            this.cboBoxLHKAF.FormattingEnabled = true;
            this.cboBoxLHKAF.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboBoxLHKAF.Location = new System.Drawing.Point(270, 1);
            this.cboBoxLHKAF.Name = "cboBoxLHKAF";
            this.cboBoxLHKAF.Size = new System.Drawing.Size(184, 21);
            this.cboBoxLHKAF.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Maintain Balance / Pain";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Minimal Upper body movement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Knee to Floor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hips, Knees, Ankle, Fwd";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(4, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Lunge";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxDSPA);
            this.panel1.Controls.Add(this.comboBoxDSDO);
            this.panel1.Controls.Add(this.comboBoxDSHBK);
            this.panel1.Controls.Add(this.comboBoxDSHF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(6, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 96);
            this.panel1.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pain";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dowel Overhead";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hips Below Knees";
            // 
            // comboBoxDSPA
            // 
            this.comboBoxDSPA.FormattingEnabled = true;
            this.comboBoxDSPA.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxDSPA.Location = new System.Drawing.Point(271, 71);
            this.comboBoxDSPA.Name = "comboBoxDSPA";
            this.comboBoxDSPA.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDSPA.TabIndex = 28;
            // 
            // comboBoxDSDO
            // 
            this.comboBoxDSDO.FormattingEnabled = true;
            this.comboBoxDSDO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxDSDO.Location = new System.Drawing.Point(271, 48);
            this.comboBoxDSDO.Name = "comboBoxDSDO";
            this.comboBoxDSDO.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDSDO.TabIndex = 28;
            // 
            // comboBoxDSHBK
            // 
            this.comboBoxDSHBK.FormattingEnabled = true;
            this.comboBoxDSHBK.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxDSHBK.Location = new System.Drawing.Point(271, 28);
            this.comboBoxDSHBK.Name = "comboBoxDSHBK";
            this.comboBoxDSHBK.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDSHBK.TabIndex = 28;
            // 
            // comboBoxDSHF
            // 
            this.comboBoxDSHF.FormattingEnabled = true;
            this.comboBoxDSHF.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxDSHF.Location = new System.Drawing.Point(271, 5);
            this.comboBoxDSHF.Name = "comboBoxDSHF";
            this.comboBoxDSHF.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDSHF.TabIndex = 28;
            this.comboBoxDSHF.SelectedIndexChanged += new System.EventHandler(this.comboBoxDSHF_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Heels on Floor";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(7, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Deep Squat";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.Location = new System.Drawing.Point(6, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Location = new System.Drawing.Point(270, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 33);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Cyan;
            this.btnDelete.Location = new System.Drawing.Point(108, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Cyan;
            this.bntExit.Location = new System.Drawing.Point(404, 494);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 33);
            this.bntExit.TabIndex = 48;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(540, 49);
            this.button1.TabIndex = 49;
            this.button1.Text = "Patient Dynamic Movement Excercise";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Dynamic_Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Dynamic_Movement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic_Movement";
            this.Load += new System.EventHandler(this.Dynamic_Movement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.ComboBox cboBoxLHKAF;
        private System.Windows.Forms.ComboBox comboBoxSHEP;
        private System.Windows.Forms.ComboBox comboBoxSHEHH;
        private System.Windows.Forms.ComboBox comboBoxASRP;
        private System.Windows.Forms.ComboBox comboBoxASRAB;
        private System.Windows.Forms.ComboBox comboBoxASRFFD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLMAP;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBoxLMUBM;
        private System.Windows.Forms.ComboBox comboBoxLKF;
        private System.Windows.Forms.ComboBox comboBoxDSPA;
        private System.Windows.Forms.ComboBox comboBoxDSDO;
        private System.Windows.Forms.ComboBox comboBoxDSHBK;
        private System.Windows.Forms.ComboBox comboBoxDSHF;
        private System.Windows.Forms.ComboBox comboBoxSRADP;
        private System.Windows.Forms.ComboBox comboBoxSRPDCC;
        private System.Windows.Forms.ComboBox comboBoxSRPL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtDynaMoveID;
        private System.Windows.Forms.Label lbluser_id;
        private System.Windows.Forms.Label lblDynaMove_ID;
        private System.Windows.Forms.Button button1;
    }
}
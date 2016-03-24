namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.butReffered = new System.Windows.Forms.Button();
            this.butLetters = new System.Windows.Forms.Button();
            this.butInformation = new System.Windows.Forms.Button();
            this.butCentral_Index = new System.Windows.Forms.Button();
            this.butCaseLoadManage = new System.Windows.Forms.Button();
            this.butCareDocument = new System.Windows.Forms.Button();
            this.butTrainingHistory = new System.Windows.Forms.Button();
            this.butImpatient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butCaseLoad = new System.Windows.Forms.Button();
            this.butTraining = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btnVideo2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refferedTrainningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientRefferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refferedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfMobilityScreenSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refferedFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.injuryHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticPostoralAssessmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPhone_Number = new System.Windows.Forms.Label();
            this.txtPhone_Number = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblReference_Number = new System.Windows.Forms.Label();
            this.txtReference_Number = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblClientType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(404, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(664, 144);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFname.Location = new System.Drawing.Point(2, 59);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(46, 13);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "Firstame";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLastname.Location = new System.Drawing.Point(2, 80);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddress.Location = new System.Drawing.Point(3, 106);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(956, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(875, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 29);
            this.Search.TabIndex = 7;
            this.Search.Text = "Select";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(81, 85);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(640, -42);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(205, 33);
            this.btnVideo.TabIndex = 57;
            this.btnVideo.Text = "Link To Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // butReffered
            // 
            this.butReffered.Image = ((System.Drawing.Image)(resources.GetObject("butReffered.Image")));
            this.butReffered.Location = new System.Drawing.Point(278, 157);
            this.butReffered.Name = "butReffered";
            this.butReffered.Size = new System.Drawing.Size(90, 129);
            this.butReffered.TabIndex = 56;
            this.butReffered.Text = "Reffered Form";
            this.butReffered.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butReffered.UseVisualStyleBackColor = true;
            this.butReffered.Click += new System.EventHandler(this.butReffered_Click);
            // 
            // butLetters
            // 
            this.butLetters.Image = ((System.Drawing.Image)(resources.GetObject("butLetters.Image")));
            this.butLetters.Location = new System.Drawing.Point(178, 157);
            this.butLetters.Name = "butLetters";
            this.butLetters.Size = new System.Drawing.Size(94, 129);
            this.butLetters.TabIndex = 55;
            this.butLetters.Text = "Letters";
            this.butLetters.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butLetters.UseVisualStyleBackColor = true;
            this.butLetters.Click += new System.EventHandler(this.butLetters_Click);
            // 
            // butInformation
            // 
            this.butInformation.Image = ((System.Drawing.Image)(resources.GetObject("butInformation.Image")));
            this.butInformation.Location = new System.Drawing.Point(469, 157);
            this.butInformation.Name = "butInformation";
            this.butInformation.Size = new System.Drawing.Size(87, 129);
            this.butInformation.TabIndex = 53;
            this.butInformation.Text = "Injury History";
            this.butInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butInformation.UseVisualStyleBackColor = true;
            this.butInformation.Click += new System.EventHandler(this.butInformation_Click);
            // 
            // butCentral_Index
            // 
            this.butCentral_Index.Image = ((System.Drawing.Image)(resources.GetObject("butCentral_Index.Image")));
            this.butCentral_Index.Location = new System.Drawing.Point(659, 156);
            this.butCentral_Index.Name = "butCentral_Index";
            this.butCentral_Index.Size = new System.Drawing.Size(92, 130);
            this.butCentral_Index.TabIndex = 52;
            this.butCentral_Index.Text = "Dynamic Movement";
            this.butCentral_Index.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butCentral_Index.UseVisualStyleBackColor = true;
            this.butCentral_Index.Click += new System.EventHandler(this.butCentral_Index_Click);
            // 
            // butCaseLoadManage
            // 
            this.butCaseLoadManage.Image = ((System.Drawing.Image)(resources.GetObject("butCaseLoadManage.Image")));
            this.butCaseLoadManage.Location = new System.Drawing.Point(562, 157);
            this.butCaseLoadManage.Name = "butCaseLoadManage";
            this.butCaseLoadManage.Size = new System.Drawing.Size(89, 129);
            this.butCaseLoadManage.TabIndex = 51;
            this.butCaseLoadManage.Text = "Static Postural Ass";
            this.butCaseLoadManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butCaseLoadManage.UseVisualStyleBackColor = true;
            this.butCaseLoadManage.Click += new System.EventHandler(this.butCaseLoadManage_Click);
            // 
            // butCareDocument
            // 
            this.butCareDocument.Image = ((System.Drawing.Image)(resources.GetObject("butCareDocument.Image")));
            this.butCareDocument.Location = new System.Drawing.Point(371, 157);
            this.butCareDocument.Name = "butCareDocument";
            this.butCareDocument.Size = new System.Drawing.Size(92, 129);
            this.butCareDocument.TabIndex = 50;
            this.butCareDocument.Text = "Self Mobility";
            this.butCareDocument.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butCareDocument.UseVisualStyleBackColor = true;
            this.butCareDocument.Click += new System.EventHandler(this.butCareDocument_Click);
            // 
            // butTrainingHistory
            // 
            this.butTrainingHistory.Image = ((System.Drawing.Image)(resources.GetObject("butTrainingHistory.Image")));
            this.butTrainingHistory.Location = new System.Drawing.Point(374, 22);
            this.butTrainingHistory.Name = "butTrainingHistory";
            this.butTrainingHistory.Size = new System.Drawing.Size(89, 129);
            this.butTrainingHistory.TabIndex = 49;
            this.butTrainingHistory.Text = "Training History";
            this.butTrainingHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butTrainingHistory.UseVisualStyleBackColor = true;
            this.butTrainingHistory.Click += new System.EventHandler(this.butTrainingHistory_Click);
            // 
            // butImpatient
            // 
            this.butImpatient.Image = ((System.Drawing.Image)(resources.GetObject("butImpatient.Image")));
            this.butImpatient.Location = new System.Drawing.Point(177, 22);
            this.butImpatient.Name = "butImpatient";
            this.butImpatient.Size = new System.Drawing.Size(92, 129);
            this.butImpatient.TabIndex = 48;
            this.butImpatient.Text = " Trainee";
            this.butImpatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butImpatient.UseVisualStyleBackColor = true;
            this.butImpatient.Click += new System.EventHandler(this.butImpatient_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(562, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 129);
            this.button3.TabIndex = 47;
            this.button3.Text = "Diagnosis Information";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butCaseLoad
            // 
            this.butCaseLoad.Image = ((System.Drawing.Image)(resources.GetObject("butCaseLoad.Image")));
            this.butCaseLoad.Location = new System.Drawing.Point(469, 22);
            this.butCaseLoad.Name = "butCaseLoad";
            this.butCaseLoad.Size = new System.Drawing.Size(90, 129);
            this.butCaseLoad.TabIndex = 46;
            this.butCaseLoad.Text = "Training Weeks";
            this.butCaseLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butCaseLoad.UseVisualStyleBackColor = true;
            this.butCaseLoad.Click += new System.EventHandler(this.butCaseLoad_Click);
            // 
            // butTraining
            // 
            this.butTraining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butTraining.Image = ((System.Drawing.Image)(resources.GetObject("butTraining.Image")));
            this.butTraining.Location = new System.Drawing.Point(278, 22);
            this.butTraining.Name = "butTraining";
            this.butTraining.Size = new System.Drawing.Size(90, 129);
            this.butTraining.TabIndex = 44;
            this.butTraining.Text = "Activity Record";
            this.butTraining.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butTraining.UseVisualStyleBackColor = true;
            this.butTraining.Click += new System.EventHandler(this.butTraining_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(3, 6);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(119, 37);
            this.btn_LogOut.TabIndex = 43;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btnVideo2
            // 
            this.btnVideo2.Location = new System.Drawing.Point(640, -71);
            this.btnVideo2.Name = "btnVideo2";
            this.btnVideo2.Size = new System.Drawing.Size(205, 23);
            this.btnVideo2.TabIndex = 42;
            this.btnVideo2.Text = "Click Here to Watch Full Video Below:";
            this.btnVideo2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.trainingToolStripMenuItem,
            this.refferedTrainningToolStripMenuItem,
            this.selfMobilityScreenSheetToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffInformationToolStripMenuItem,
            this.generalInformationToolStripMenuItem,
            this.trainingRegistrationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // staffInformationToolStripMenuItem
            // 
            this.staffInformationToolStripMenuItem.Name = "staffInformationToolStripMenuItem";
            this.staffInformationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.staffInformationToolStripMenuItem.Text = "Staff Information";
            this.staffInformationToolStripMenuItem.Click += new System.EventHandler(this.staffInformationToolStripMenuItem_Click);
            // 
            // generalInformationToolStripMenuItem
            // 
            this.generalInformationToolStripMenuItem.Name = "generalInformationToolStripMenuItem";
            this.generalInformationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.generalInformationToolStripMenuItem.Text = "General Information";
            this.generalInformationToolStripMenuItem.Click += new System.EventHandler(this.generalInformationToolStripMenuItem_Click);
            // 
            // trainingRegistrationToolStripMenuItem
            // 
            this.trainingRegistrationToolStripMenuItem.Name = "trainingRegistrationToolStripMenuItem";
            this.trainingRegistrationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.trainingRegistrationToolStripMenuItem.Text = "Training Registration";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientRegistrationToolStripMenuItem,
            this.newAppointmentToolStripMenuItem,
            this.trainingHistoryToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // clientRegistrationToolStripMenuItem
            // 
            this.clientRegistrationToolStripMenuItem.Name = "clientRegistrationToolStripMenuItem";
            this.clientRegistrationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clientRegistrationToolStripMenuItem.Text = "Client Registration";
            this.clientRegistrationToolStripMenuItem.Click += new System.EventHandler(this.clientRegistrationToolStripMenuItem_Click);
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newAppointmentToolStripMenuItem.Text = "New Appointment";
            this.newAppointmentToolStripMenuItem.Click += new System.EventHandler(this.newAppointmentToolStripMenuItem_Click);
            // 
            // trainingHistoryToolStripMenuItem
            // 
            this.trainingHistoryToolStripMenuItem.Name = "trainingHistoryToolStripMenuItem";
            this.trainingHistoryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.trainingHistoryToolStripMenuItem.Text = "Training History";
            this.trainingHistoryToolStripMenuItem.Click += new System.EventHandler(this.trainingHistoryToolStripMenuItem_Click);
            // 
            // refferedTrainningToolStripMenuItem
            // 
            this.refferedTrainningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientRefferedToolStripMenuItem,
            this.letterToolStripMenuItem,
            this.refferedFormToolStripMenuItem});
            this.refferedTrainningToolStripMenuItem.Name = "refferedTrainningToolStripMenuItem";
            this.refferedTrainningToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.refferedTrainningToolStripMenuItem.Text = "Reffered Trainning";
            // 
            // clientRefferedToolStripMenuItem
            // 
            this.clientRefferedToolStripMenuItem.Name = "clientRefferedToolStripMenuItem";
            this.clientRefferedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientRefferedToolStripMenuItem.Text = "Client Reffered";
            this.clientRefferedToolStripMenuItem.Click += new System.EventHandler(this.clientRefferedToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem
            // 
            this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            this.letterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.letterToolStripMenuItem.Text = "Letter";
            this.letterToolStripMenuItem.Click += new System.EventHandler(this.letterToolStripMenuItem_Click);
            // 
            // refferedFormToolStripMenuItem
            // 
            this.refferedFormToolStripMenuItem.Name = "refferedFormToolStripMenuItem";
            this.refferedFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refferedFormToolStripMenuItem.Text = "Reffered Form";
            this.refferedFormToolStripMenuItem.Click += new System.EventHandler(this.refferedFormToolStripMenuItem_Click);
            // 
            // selfMobilityScreenSheetToolStripMenuItem
            // 
            this.selfMobilityScreenSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisInformationToolStripMenuItem,
            this.refferedFormToolStripMenuItem1,
            this.injuryHistoryToolStripMenuItem,
            this.staticPostoralAssessmentToolStripMenuItem});
            this.selfMobilityScreenSheetToolStripMenuItem.Name = "selfMobilityScreenSheetToolStripMenuItem";
            this.selfMobilityScreenSheetToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.selfMobilityScreenSheetToolStripMenuItem.Text = "Self Mobility Screen Sheet";
            this.selfMobilityScreenSheetToolStripMenuItem.Click += new System.EventHandler(this.selfMobilityScreenSheetToolStripMenuItem_Click);
            // 
            // diagnosisInformationToolStripMenuItem
            // 
            this.diagnosisInformationToolStripMenuItem.Name = "diagnosisInformationToolStripMenuItem";
            this.diagnosisInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diagnosisInformationToolStripMenuItem.Text = "Diagnosis Information";
            this.diagnosisInformationToolStripMenuItem.Click += new System.EventHandler(this.diagnosisInformationToolStripMenuItem_Click);
            // 
            // refferedFormToolStripMenuItem1
            // 
            this.refferedFormToolStripMenuItem1.Name = "refferedFormToolStripMenuItem1";
            this.refferedFormToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.refferedFormToolStripMenuItem1.Text = "Reffered Form";
            this.refferedFormToolStripMenuItem1.Click += new System.EventHandler(this.refferedFormToolStripMenuItem1_Click);
            // 
            // injuryHistoryToolStripMenuItem
            // 
            this.injuryHistoryToolStripMenuItem.Name = "injuryHistoryToolStripMenuItem";
            this.injuryHistoryToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.injuryHistoryToolStripMenuItem.Text = "Injury History";
            this.injuryHistoryToolStripMenuItem.Click += new System.EventHandler(this.injuryHistoryToolStripMenuItem_Click);
            // 
            // staticPostoralAssessmentToolStripMenuItem
            // 
            this.staticPostoralAssessmentToolStripMenuItem.Name = "staticPostoralAssessmentToolStripMenuItem";
            this.staticPostoralAssessmentToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.staticPostoralAssessmentToolStripMenuItem.Text = "Static Postoral Assessment";
            this.staticPostoralAssessmentToolStripMenuItem.Click += new System.EventHandler(this.staticPostoralAssessmentToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingWeekToolStripMenuItem,
            this.hardCopiesToolStripMenuItem,
            this.letterToolStripMenuItem1});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // trainingWeekToolStripMenuItem
            // 
            this.trainingWeekToolStripMenuItem.Name = "trainingWeekToolStripMenuItem";
            this.trainingWeekToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.trainingWeekToolStripMenuItem.Text = "Training Week";
            this.trainingWeekToolStripMenuItem.Click += new System.EventHandler(this.trainingWeekToolStripMenuItem_Click);
            // 
            // hardCopiesToolStripMenuItem
            // 
            this.hardCopiesToolStripMenuItem.Name = "hardCopiesToolStripMenuItem";
            this.hardCopiesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hardCopiesToolStripMenuItem.Text = "Hard Copies";
            this.hardCopiesToolStripMenuItem.Click += new System.EventHandler(this.hardCopiesToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem1
            // 
            this.letterToolStripMenuItem1.Name = "letterToolStripMenuItem1";
            this.letterToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.letterToolStripMenuItem1.Text = "Letter";
            this.letterToolStripMenuItem1.Click += new System.EventHandler(this.letterToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // lblPhone_Number
            // 
            this.lblPhone_Number.AutoSize = true;
            this.lblPhone_Number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhone_Number.Location = new System.Drawing.Point(-3, 157);
            this.lblPhone_Number.Name = "lblPhone_Number";
            this.lblPhone_Number.Size = new System.Drawing.Size(81, 13);
            this.lblPhone_Number.TabIndex = 3;
            this.lblPhone_Number.Text = "Phone_Number";
            // 
            // txtPhone_Number
            // 
            this.txtPhone_Number.Location = new System.Drawing.Point(81, 154);
            this.txtPhone_Number.Name = "txtPhone_Number";
            this.txtPhone_Number.Size = new System.Drawing.Size(100, 20);
            this.txtPhone_Number.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDOB.Location = new System.Drawing.Point(3, 132);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(81, 129);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGender.Location = new System.Drawing.Point(6, 179);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(81, 179);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 12;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOccupation.Location = new System.Drawing.Point(192, 59);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 3;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(298, 59);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(100, 20);
            this.txtOccupation.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.butTrainingHistory);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.butTraining);
            this.panel1.Controls.Add(this.butInformation);
            this.panel1.Controls.Add(this.butReffered);
            this.panel1.Controls.Add(this.butLetters);
            this.panel1.Controls.Add(this.butCaseLoad);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.butImpatient);
            this.panel1.Controls.Add(this.butCentral_Index);
            this.panel1.Controls.Add(this.butCareDocument);
            this.panel1.Controls.Add(this.butCaseLoadManage);
            this.panel1.Location = new System.Drawing.Point(12, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 289);
            this.panel1.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(856, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 33);
            this.button2.TabIndex = 58;
            this.button2.Text = "Link To Video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(856, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 23);
            this.button4.TabIndex = 57;
            this.button4.Text = "Click Here to Watch Full Video Below:";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblReference_Number
            // 
            this.lblReference_Number.AutoSize = true;
            this.lblReference_Number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReference_Number.Location = new System.Drawing.Point(192, 85);
            this.lblReference_Number.Name = "lblReference_Number";
            this.lblReference_Number.Size = new System.Drawing.Size(100, 13);
            this.lblReference_Number.TabIndex = 3;
            this.lblReference_Number.Text = "Reference_Number";
            // 
            // txtReference_Number
            // 
            this.txtReference_Number.Location = new System.Drawing.Point(298, 85);
            this.txtReference_Number.Name = "txtReference_Number";
            this.txtReference_Number.Size = new System.Drawing.Size(100, 20);
            this.txtReference_Number.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(2, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(81, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(323, 154);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 27);
            this.btnInsert.TabIndex = 60;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientType.Location = new System.Drawing.Point(192, 36);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(76, 16);
            this.lblClientType.TabIndex = 64;
            this.lblClientType.Text = "Client Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Manager",
            "Physiotheraphy",
            "Nurse",
            "Career",
            "Others"});
            this.cboType.Location = new System.Drawing.Point(298, 33);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 21);
            this.cboType.TabIndex = 65;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 538);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblClientType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnVideo2);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtReference_Number);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhone_Number);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.lblReference_Number);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhone_Number);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button butReffered;
        private System.Windows.Forms.Button butLetters;
        private System.Windows.Forms.Button butInformation;
        private System.Windows.Forms.Button butCentral_Index;
        private System.Windows.Forms.Button butCaseLoadManage;
        private System.Windows.Forms.Button butCareDocument;
        private System.Windows.Forms.Button butTrainingHistory;
        private System.Windows.Forms.Button butImpatient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butCaseLoad;
        private System.Windows.Forms.Button butTraining;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btnVideo2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refferedTrainningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientRefferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refferedFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfMobilityScreenSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosisInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refferedFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem injuryHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticPostoralAssessmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label lblPhone_Number;
        private System.Windows.Forms.TextBox txtPhone_Number;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblReference_Number;
        private System.Windows.Forms.TextBox txtReference_Number;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.ComboBox cboType;
    }
}


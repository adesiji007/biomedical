namespace WindowsFormsApplication1
{
    partial class Diagnosis_Information
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtResApp = new System.Windows.Forms.TextBox();
            this.txtPreApp = new System.Windows.Forms.TextBox();
            this.txtNatur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReference_Number = new System.Windows.Forms.Label();
            this.txtReference_Number = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDiagInfo_ID = new System.Windows.Forms.Label();
            this.lbluser_id = new System.Windows.Forms.Label();
            this.txtDiagInfo_ID = new System.Windows.Forms.TextBox();
            this.txtuser_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Next Clinic Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Clinic Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(264, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 348);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.BtnUpdate.Location = new System.Drawing.Point(481, 453);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 49;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Cyan;
            this.btnInsert.Location = new System.Drawing.Point(311, 453);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Location = new System.Drawing.Point(481, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.Location = new System.Drawing.Point(392, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Location = new System.Drawing.Point(587, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(706, 6);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 33);
            this.txtSearch.TabIndex = 57;
            // 
            // txtResApp
            // 
            this.txtResApp.Location = new System.Drawing.Point(78, 445);
            this.txtResApp.Multiline = true;
            this.txtResApp.Name = "txtResApp";
            this.txtResApp.Size = new System.Drawing.Size(179, 78);
            this.txtResApp.TabIndex = 56;
            // 
            // txtPreApp
            // 
            this.txtPreApp.Location = new System.Drawing.Point(78, 365);
            this.txtPreApp.Multiline = true;
            this.txtPreApp.Name = "txtPreApp";
            this.txtPreApp.Size = new System.Drawing.Size(179, 61);
            this.txtPreApp.TabIndex = 55;
            // 
            // txtNatur
            // 
            this.txtNatur.Location = new System.Drawing.Point(78, 291);
            this.txtNatur.Multiline = true;
            this.txtNatur.Name = "txtNatur";
            this.txtNatur.Size = new System.Drawing.Size(179, 55);
            this.txtNatur.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Reschedule of Appointment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nature of Previous Appointment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Nature of Training Required";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Cyan;
            this.btnDelete.Location = new System.Drawing.Point(311, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fullname";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReference_Number
            // 
            this.lblReference_Number.AutoSize = true;
            this.lblReference_Number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReference_Number.Location = new System.Drawing.Point(6, 128);
            this.lblReference_Number.Name = "lblReference_Number";
            this.lblReference_Number.Size = new System.Drawing.Size(100, 13);
            this.lblReference_Number.TabIndex = 59;
            this.lblReference_Number.Text = "Reference_Number";
            this.lblReference_Number.Click += new System.EventHandler(this.lblReference_Number_Click);
            // 
            // txtReference_Number
            // 
            this.txtReference_Number.Location = new System.Drawing.Point(117, 125);
            this.txtReference_Number.Name = "txtReference_Number";
            this.txtReference_Number.Size = new System.Drawing.Size(141, 20);
            this.txtReference_Number.TabIndex = 60;
            this.txtReference_Number.TextChanged += new System.EventHandler(this.txtReference_Number_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 47);
            this.panel1.TabIndex = 61;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 62;
            // 
            // lblDiagInfo_ID
            // 
            this.lblDiagInfo_ID.AutoSize = true;
            this.lblDiagInfo_ID.Location = new System.Drawing.Point(5, 72);
            this.lblDiagInfo_ID.Name = "lblDiagInfo_ID";
            this.lblDiagInfo_ID.Size = new System.Drawing.Size(64, 13);
            this.lblDiagInfo_ID.TabIndex = 63;
            this.lblDiagInfo_ID.Text = "DiagInfo_ID";
            // 
            // lbluser_id
            // 
            this.lbluser_id.AutoSize = true;
            this.lbluser_id.Location = new System.Drawing.Point(6, 101);
            this.lbluser_id.Name = "lbluser_id";
            this.lbluser_id.Size = new System.Drawing.Size(41, 13);
            this.lbluser_id.TabIndex = 64;
            this.lbluser_id.Text = "user_id";
            // 
            // txtDiagInfo_ID
            // 
            this.txtDiagInfo_ID.Location = new System.Drawing.Point(116, 72);
            this.txtDiagInfo_ID.Name = "txtDiagInfo_ID";
            this.txtDiagInfo_ID.ReadOnly = true;
            this.txtDiagInfo_ID.Size = new System.Drawing.Size(142, 20);
            this.txtDiagInfo_ID.TabIndex = 65;
            // 
            // txtuser_id
            // 
            this.txtuser_id.Location = new System.Drawing.Point(116, 99);
            this.txtuser_id.Name = "txtuser_id";
            this.txtuser_id.ReadOnly = true;
            this.txtuser_id.Size = new System.Drawing.Size(141, 20);
            this.txtuser_id.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(652, 32);
            this.button1.TabIndex = 67;
            this.button1.Text = "Diagnosis Information For Clients";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 69;
            // 
            // Diagnosis_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 535);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuser_id);
            this.Controls.Add(this.txtDiagInfo_ID);
            this.Controls.Add(this.lbluser_id);
            this.Controls.Add(this.lblDiagInfo_ID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtReference_Number);
            this.Controls.Add(this.lblReference_Number);
            this.Controls.Add(this.txtResApp);
            this.Controls.Add(this.txtPreApp);
            this.Controls.Add(this.txtNatur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "Diagnosis_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis_Information";
            this.Load += new System.EventHandler(this.Diagnosis_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtResApp;
        private System.Windows.Forms.TextBox txtPreApp;
        private System.Windows.Forms.TextBox txtNatur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReference_Number;
        private System.Windows.Forms.TextBox txtReference_Number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDiagInfo_ID;
        private System.Windows.Forms.Label lbluser_id;
        private System.Windows.Forms.TextBox txtDiagInfo_ID;
        private System.Windows.Forms.TextBox txtuser_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
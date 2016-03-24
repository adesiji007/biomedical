namespace WindowsFormsApplication1
{
    partial class ActivityRecord
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
            this.dataGridViewActivity = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBackToDash = new System.Windows.Forms.Button();
            this.txtNextAct = new System.Windows.Forms.TextBox();
            this.txtPrv = new System.Windows.Forms.TextBox();
            this.lblDNActivity = new System.Windows.Forms.Label();
            this.lblPrv = new System.Windows.Forms.Label();
            this.txtTypActivity = new System.Windows.Forms.TextBox();
            this.txtDoActivity = new System.Windows.Forms.TextBox();
            this.txtTrName = new System.Windows.Forms.TextBox();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.lblTypActivity = new System.Windows.Forms.Label();
            this.lblDoActivity = new System.Windows.Forms.Label();
            this.lblTrName = new System.Windows.Forms.Label();
            this.lblTrainingC = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewActivity
            // 
            this.dataGridViewActivity.AllowUserToOrderColumns = true;
            this.dataGridViewActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridViewActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewActivity.Location = new System.Drawing.Point(424, 107);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.Size = new System.Drawing.Size(613, 314);
            this.dataGridViewActivity.TabIndex = 7;
            // 
            // id
            // 
            this.id.DataPropertyName = " \tID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reference_No";
            this.Column1.HeaderText = "Training Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Training Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date_of_Activity";
            this.Column3.HeaderText = "Date of Activity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Type_of_Activity";
            this.Column4.HeaderText = "Type of Activity";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date_of_Next_Activity";
            this.Column6.HeaderText = "Date of Next Activity";
            this.Column6.Name = "Column6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnBackToDash);
            this.panel1.Controls.Add(this.txtNextAct);
            this.panel1.Controls.Add(this.txtPrv);
            this.panel1.Controls.Add(this.lblDNActivity);
            this.panel1.Controls.Add(this.lblPrv);
            this.panel1.Controls.Add(this.txtTypActivity);
            this.panel1.Controls.Add(this.txtDoActivity);
            this.panel1.Controls.Add(this.txtTrName);
            this.panel1.Controls.Add(this.txtTraining);
            this.panel1.Controls.Add(this.lblTypActivity);
            this.panel1.Controls.Add(this.lblDoActivity);
            this.panel1.Controls.Add(this.lblTrName);
            this.panel1.Controls.Add(this.lblTrainingC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(124, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 473);
            this.panel1.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // btnBackToDash
            // 
            this.btnBackToDash.Location = new System.Drawing.Point(103, 362);
            this.btnBackToDash.Name = "btnBackToDash";
            this.btnBackToDash.Size = new System.Drawing.Size(118, 23);
            this.btnBackToDash.TabIndex = 18;
            this.btnBackToDash.Text = "Back To Dashboad";
            this.btnBackToDash.UseVisualStyleBackColor = true;
            // 
            // txtNextAct
            // 
            this.txtNextAct.Location = new System.Drawing.Point(158, 223);
            this.txtNextAct.Name = "txtNextAct";
            this.txtNextAct.Size = new System.Drawing.Size(100, 20);
            this.txtNextAct.TabIndex = 17;
            // 
            // txtPrv
            // 
            this.txtPrv.Location = new System.Drawing.Point(158, 186);
            this.txtPrv.Name = "txtPrv";
            this.txtPrv.Size = new System.Drawing.Size(100, 20);
            this.txtPrv.TabIndex = 16;
            // 
            // lblDNActivity
            // 
            this.lblDNActivity.AutoSize = true;
            this.lblDNActivity.Location = new System.Drawing.Point(8, 226);
            this.lblDNActivity.Name = "lblDNActivity";
            this.lblDNActivity.Size = new System.Drawing.Size(104, 13);
            this.lblDNActivity.TabIndex = 15;
            this.lblDNActivity.Text = "Date of Next Activity";
            // 
            // lblPrv
            // 
            this.lblPrv.AutoSize = true;
            this.lblPrv.Location = new System.Drawing.Point(8, 186);
            this.lblPrv.Name = "lblPrv";
            this.lblPrv.Size = new System.Drawing.Size(85, 13);
            this.lblPrv.TabIndex = 14;
            this.lblPrv.Text = "Previous Activity";
            // 
            // txtTypActivity
            // 
            this.txtTypActivity.Location = new System.Drawing.Point(158, 156);
            this.txtTypActivity.Name = "txtTypActivity";
            this.txtTypActivity.Size = new System.Drawing.Size(100, 20);
            this.txtTypActivity.TabIndex = 13;
            // 
            // txtDoActivity
            // 
            this.txtDoActivity.Location = new System.Drawing.Point(158, 127);
            this.txtDoActivity.Name = "txtDoActivity";
            this.txtDoActivity.Size = new System.Drawing.Size(100, 20);
            this.txtDoActivity.TabIndex = 12;
            // 
            // txtTrName
            // 
            this.txtTrName.Location = new System.Drawing.Point(158, 101);
            this.txtTrName.Name = "txtTrName";
            this.txtTrName.Size = new System.Drawing.Size(100, 20);
            this.txtTrName.TabIndex = 11;
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(158, 77);
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(100, 20);
            this.txtTraining.TabIndex = 10;
            // 
            // lblTypActivity
            // 
            this.lblTypActivity.AutoSize = true;
            this.lblTypActivity.Location = new System.Drawing.Point(6, 156);
            this.lblTypActivity.Name = "lblTypActivity";
            this.lblTypActivity.Size = new System.Drawing.Size(80, 13);
            this.lblTypActivity.TabIndex = 9;
            this.lblTypActivity.Text = "Type of Activity";
            // 
            // lblDoActivity
            // 
            this.lblDoActivity.AutoSize = true;
            this.lblDoActivity.Location = new System.Drawing.Point(6, 129);
            this.lblDoActivity.Name = "lblDoActivity";
            this.lblDoActivity.Size = new System.Drawing.Size(79, 13);
            this.lblDoActivity.TabIndex = 8;
            this.lblDoActivity.Text = "Date of Activity";
            // 
            // lblTrName
            // 
            this.lblTrName.AutoSize = true;
            this.lblTrName.Location = new System.Drawing.Point(2, 104);
            this.lblTrName.Name = "lblTrName";
            this.lblTrName.Size = new System.Drawing.Size(76, 13);
            this.lblTrName.TabIndex = 7;
            this.lblTrName.Text = "Training Name";
            // 
            // lblTrainingC
            // 
            this.lblTrainingC.AutoSize = true;
            this.lblTrainingC.Location = new System.Drawing.Point(3, 75);
            this.lblTrainingC.Name = "lblTrainingC";
            this.lblTrainingC.Size = new System.Drawing.Size(73, 13);
            this.lblTrainingC.TabIndex = 6;
            this.lblTrainingC.Text = "Training Code";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(420, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 77);
            this.panel2.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // ActivityRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 489);
            this.Controls.Add(this.dataGridViewActivity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ActivityRecord";
            this.Text = "ActivityRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBackToDash;
        private System.Windows.Forms.TextBox txtNextAct;
        private System.Windows.Forms.TextBox txtPrv;
        private System.Windows.Forms.Label lblDNActivity;
        private System.Windows.Forms.Label lblPrv;
        private System.Windows.Forms.TextBox txtTypActivity;
        private System.Windows.Forms.TextBox txtDoActivity;
        private System.Windows.Forms.TextBox txtTrName;
        private System.Windows.Forms.TextBox txtTraining;
        private System.Windows.Forms.Label lblTypActivity;
        private System.Windows.Forms.Label lblDoActivity;
        private System.Windows.Forms.Label lblTrName;
        private System.Windows.Forms.Label lblTrainingC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
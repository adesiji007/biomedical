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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNextAct = new System.Windows.Forms.TextBox();
            this.txtDoActivity = new System.Windows.Forms.TextBox();
            this.txtPrv = new System.Windows.Forms.TextBox();
            this.lblDNActivity = new System.Windows.Forms.Label();
            this.lblPrv = new System.Windows.Forms.Label();
            this.txtTypActivity = new System.Windows.Forms.TextBox();
            this.txtTrName = new System.Windows.Forms.TextBox();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.lblTypActivity = new System.Windows.Forms.Label();
            this.lblDoActivity = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblTrainingC = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewActivity
            // 
            this.dataGridViewActivity.AllowUserToOrderColumns = true;
            this.dataGridViewActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewActivity.Location = new System.Drawing.Point(308, 105);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.Size = new System.Drawing.Size(613, 314);
            this.dataGridViewActivity.TabIndex = 7;
            this.dataGridViewActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivity_CellClick);
            this.dataGridViewActivity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivity_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtNextAct);
            this.panel1.Controls.Add(this.txtDoActivity);
            this.panel1.Controls.Add(this.txtPrv);
            this.panel1.Controls.Add(this.lblDNActivity);
            this.panel1.Controls.Add(this.lblPrv);
            this.panel1.Controls.Add(this.txtTypActivity);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtTrName);
            this.panel1.Controls.Add(this.txtTraining);
            this.panel1.Controls.Add(this.lblTypActivity);
            this.panel1.Controls.Add(this.lblDoActivity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.lblTrainingC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 473);
            this.panel1.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(195, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 20);
            this.txtID.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // txtNextAct
            // 
            this.txtNextAct.Location = new System.Drawing.Point(113, 221);
            this.txtNextAct.Name = "txtNextAct";
            this.txtNextAct.Size = new System.Drawing.Size(124, 20);
            this.txtNextAct.TabIndex = 17;
            // 
            // txtDoActivity
            // 
            this.txtDoActivity.Location = new System.Drawing.Point(113, 129);
            this.txtDoActivity.Name = "txtDoActivity";
            this.txtDoActivity.Size = new System.Drawing.Size(124, 20);
            this.txtDoActivity.TabIndex = 12;
            // 
            // txtPrv
            // 
            this.txtPrv.Location = new System.Drawing.Point(113, 184);
            this.txtPrv.Name = "txtPrv";
            this.txtPrv.Size = new System.Drawing.Size(124, 20);
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
            this.txtTypActivity.Location = new System.Drawing.Point(113, 154);
            this.txtTypActivity.Name = "txtTypActivity";
            this.txtTypActivity.Size = new System.Drawing.Size(124, 20);
            this.txtTypActivity.TabIndex = 13;
            // 
            // txtTrName
            // 
            this.txtTrName.Location = new System.Drawing.Point(113, 66);
            this.txtTrName.Name = "txtTrName";
            this.txtTrName.Size = new System.Drawing.Size(124, 20);
            this.txtTrName.TabIndex = 11;
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(113, 38);
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(124, 20);
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
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(9, 95);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 7;
            this.lblLastname.Text = "Lastname";
            // 
            // lblTrainingC
            // 
            this.lblTrainingC.AutoSize = true;
            this.lblTrainingC.Location = new System.Drawing.Point(8, 45);
            this.lblTrainingC.Name = "lblTrainingC";
            this.lblTrainingC.Size = new System.Drawing.Size(73, 13);
            this.lblTrainingC.TabIndex = 6;
            this.lblTrainingC.Text = "Training Code";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(635, 4);
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
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(113, 92);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(124, 20);
            this.txtLastname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Training Name";
            // 
            // ActivityRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.dataGridViewActivity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ActivityRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityRecord";
            this.Load += new System.EventHandler(this.ActivityRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActivity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
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
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblTrainingC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label1;
    }
}
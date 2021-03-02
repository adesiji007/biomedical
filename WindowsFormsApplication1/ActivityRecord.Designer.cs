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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNextAct = new System.Windows.Forms.TextBox();
            this.txtDoActivity = new System.Windows.Forms.TextBox();
            this.txtPrv = new System.Windows.Forms.TextBox();
            this.lblDNActivity = new System.Windows.Forms.Label();
            this.lblPrv = new System.Windows.Forms.Label();
            this.txtTypActivity = new System.Windows.Forms.TextBox();
            this.txtTraining = new System.Windows.Forms.TextBox();
            this.lblTypActivity = new System.Windows.Forms.Label();
            this.lblDoActivity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrainingC = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridViewActivity.Location = new System.Drawing.Point(308, 104);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.Size = new System.Drawing.Size(613, 383);
            this.dataGridViewActivity.TabIndex = 7;
            this.dataGridViewActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivity_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtNextAct);
            this.panel1.Controls.Add(this.txtDoActivity);
            this.panel1.Controls.Add(this.txtPrv);
            this.panel1.Controls.Add(this.lblDNActivity);
            this.panel1.Controls.Add(this.lblPrv);
            this.panel1.Controls.Add(this.txtTypActivity);
            this.panel1.Controls.Add(this.txtTraining);
            this.panel1.Controls.Add(this.lblTypActivity);
            this.panel1.Controls.Add(this.lblDoActivity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTrainingC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 383);
            this.panel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Cyan;
            this.btnClear.Location = new System.Drawing.Point(195, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(137, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 20);
            this.txtID.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // txtNextAct
            // 
            this.txtNextAct.Location = new System.Drawing.Point(137, 219);
            this.txtNextAct.Name = "txtNextAct";
            this.txtNextAct.Size = new System.Drawing.Size(124, 20);
            this.txtNextAct.TabIndex = 17;
            // 
            // txtDoActivity
            // 
            this.txtDoActivity.Enabled = false;
            this.txtDoActivity.Location = new System.Drawing.Point(137, 148);
            this.txtDoActivity.Name = "txtDoActivity";
            this.txtDoActivity.Size = new System.Drawing.Size(124, 20);
            this.txtDoActivity.TabIndex = 12;
            // 
            // txtPrv
            // 
            this.txtPrv.Enabled = false;
            this.txtPrv.Location = new System.Drawing.Point(137, 105);
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
            this.lblPrv.Location = new System.Drawing.Point(10, 105);
            this.lblPrv.Name = "lblPrv";
            this.lblPrv.Size = new System.Drawing.Size(85, 13);
            this.lblPrv.TabIndex = 14;
            this.lblPrv.Text = "Previous Activity";
            // 
            // txtTypActivity
            // 
            this.txtTypActivity.Location = new System.Drawing.Point(137, 183);
            this.txtTypActivity.Name = "txtTypActivity";
            this.txtTypActivity.Size = new System.Drawing.Size(124, 20);
            this.txtTypActivity.TabIndex = 13;
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(137, 38);
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(124, 20);
            this.txtTraining.TabIndex = 10;
            // 
            // lblTypActivity
            // 
            this.lblTypActivity.AutoSize = true;
            this.lblTypActivity.Location = new System.Drawing.Point(10, 186);
            this.lblTypActivity.Name = "lblTypActivity";
            this.lblTypActivity.Size = new System.Drawing.Size(66, 13);
            this.lblTypActivity.TabIndex = 9;
            this.lblTypActivity.Text = "Next Activity";
            // 
            // lblDoActivity
            // 
            this.lblDoActivity.AutoSize = true;
            this.lblDoActivity.Location = new System.Drawing.Point(11, 148);
            this.lblDoActivity.Name = "lblDoActivity";
            this.lblDoActivity.Size = new System.Drawing.Size(123, 13);
            this.lblDoActivity.TabIndex = 8;
            this.lblDoActivity.Text = "Date of Previous Activity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fullname";
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
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(103, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cyan;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(12, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(103, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(11, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 35);
            this.panel2.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Location = new System.Drawing.Point(622, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(723, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Magenta;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(909, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "Record of all Training Activities";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ActivityRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.TextBox txtTraining;
        private System.Windows.Forms.Label lblTypActivity;
        private System.Windows.Forms.Label lblDoActivity;
        private System.Windows.Forms.Label lblTrainingC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}
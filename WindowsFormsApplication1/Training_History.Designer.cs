namespace WindowsFormsApplication1
{
    partial class Training_History
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTraRefCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtTNSport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtPPWeakness = new System.Windows.Forms.TextBox();
            this.txtPPStrenght = new System.Windows.Forms.TextBox();
            this.txtPPNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTNWeakness = new System.Windows.Forms.TextBox();
            this.txtTNStrenght = new System.Windows.Forms.TextBox();
            this.txtTNNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(320, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 281);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTraRefCode);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(464, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 144);
            this.panel2.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(89, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(89, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTraRefCode
            // 
            this.txtTraRefCode.Location = new System.Drawing.Point(175, 10);
            this.txtTraRefCode.Multiline = true;
            this.txtTraRefCode.Name = "txtTraRefCode";
            this.txtTraRefCode.Size = new System.Drawing.Size(171, 20);
            this.txtTraRefCode.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Training Reference Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtTNSport);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.txtPPWeakness);
            this.panel1.Controls.Add(this.txtPPStrenght);
            this.panel1.Controls.Add(this.txtPPNote);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTNWeakness);
            this.panel1.Controls.Add(this.txtTNStrenght);
            this.panel1.Controls.Add(this.txtTNNote);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 492);
            this.panel1.TabIndex = 14;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(97, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(171, 20);
            this.txtFirstname.TabIndex = 15;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(97, 34);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(171, 20);
            this.txtLastname.TabIndex = 15;
            // 
            // txtTNSport
            // 
            this.txtTNSport.Location = new System.Drawing.Point(97, 60);
            this.txtTNSport.Name = "txtTNSport";
            this.txtTNSport.Size = new System.Drawing.Size(171, 20);
            this.txtTNSport.TabIndex = 15;
            this.txtTNSport.TextChanged += new System.EventHandler(this.txtTNSport_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Firstname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(3, 37);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 14;
            this.lblLastname.Text = "Lastname";
            // 
            // txtPPWeakness
            // 
            this.txtPPWeakness.Location = new System.Drawing.Point(97, 414);
            this.txtPPWeakness.Multiline = true;
            this.txtPPWeakness.Name = "txtPPWeakness";
            this.txtPPWeakness.Size = new System.Drawing.Size(171, 52);
            this.txtPPWeakness.TabIndex = 13;
            // 
            // txtPPStrenght
            // 
            this.txtPPStrenght.Location = new System.Drawing.Point(97, 354);
            this.txtPPStrenght.Multiline = true;
            this.txtPPStrenght.Name = "txtPPStrenght";
            this.txtPPStrenght.Size = new System.Drawing.Size(171, 45);
            this.txtPPStrenght.TabIndex = 12;
            // 
            // txtPPNote
            // 
            this.txtPPNote.Location = new System.Drawing.Point(97, 310);
            this.txtPPNote.Multiline = true;
            this.txtPPNote.Name = "txtPPNote";
            this.txtPPNote.Size = new System.Drawing.Size(171, 35);
            this.txtPPNote.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Weakness:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Strenght:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Note:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Physical Preparation:";
            // 
            // txtTNWeakness
            // 
            this.txtTNWeakness.Location = new System.Drawing.Point(97, 223);
            this.txtTNWeakness.Multiline = true;
            this.txtTNWeakness.Name = "txtTNWeakness";
            this.txtTNWeakness.Size = new System.Drawing.Size(171, 54);
            this.txtTNWeakness.TabIndex = 6;
            // 
            // txtTNStrenght
            // 
            this.txtTNStrenght.Location = new System.Drawing.Point(97, 150);
            this.txtTNStrenght.Multiline = true;
            this.txtTNStrenght.Name = "txtTNStrenght";
            this.txtTNStrenght.Size = new System.Drawing.Size(171, 53);
            this.txtTNStrenght.TabIndex = 5;
            // 
            // txtTNNote
            // 
            this.txtTNNote.Location = new System.Drawing.Point(97, 92);
            this.txtTNNote.Multiline = true;
            this.txtTNNote.Name = "txtTNNote";
            this.txtTNNote.Size = new System.Drawing.Size(171, 47);
            this.txtTNNote.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weakness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strenght:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport:";
            // 
            // Training_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Training_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training_History";
            this.Load += new System.EventHandler(this.Training_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTraRefCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTNSport;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtPPWeakness;
        private System.Windows.Forms.TextBox txtPPStrenght;
        private System.Windows.Forms.TextBox txtPPNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTNWeakness;
        private System.Windows.Forms.TextBox txtTNStrenght;
        private System.Windows.Forms.TextBox txtTNNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstname;
    }
}
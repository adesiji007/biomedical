namespace WindowsFormsApplication1
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.grpClientDetail = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblClientType = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpClientDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClientDetail
            // 
            this.grpClientDetail.Controls.Add(this.lblPassword);
            this.grpClientDetail.Controls.Add(this.txtPassword);
            this.grpClientDetail.Controls.Add(this.txtRegistrationDate);
            this.grpClientDetail.Controls.Add(this.txtRegistrationNo);
            this.grpClientDetail.Controls.Add(this.txtEmail);
            this.grpClientDetail.Controls.Add(this.txtLname);
            this.grpClientDetail.Controls.Add(this.lblRegDate);
            this.grpClientDetail.Controls.Add(this.lblEmail);
            this.grpClientDetail.Controls.Add(this.lblRegNo);
            this.grpClientDetail.Controls.Add(this.lblSurname);
            this.grpClientDetail.Controls.Add(this.lblFirstname);
            this.grpClientDetail.Controls.Add(this.txtFirstname);
            this.grpClientDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientDetail.Location = new System.Drawing.Point(176, 118);
            this.grpClientDetail.Name = "grpClientDetail";
            this.grpClientDetail.Size = new System.Drawing.Size(394, 280);
            this.grpClientDetail.TabIndex = 34;
            this.grpClientDetail.TabStop = false;
            this.grpClientDetail.Text = "NewClientDetail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 241);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 20);
            this.txtPassword.TabIndex = 42;
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(125, 89);
            this.txtRegistrationDate.Multiline = true;
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(226, 20);
            this.txtRegistrationDate.TabIndex = 40;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(125, 139);
            this.txtRegistrationNo.Multiline = true;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(226, 20);
            this.txtRegistrationNo.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 183);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(125, 47);
            this.txtLname.Multiline = true;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(226, 20);
            this.txtLname.TabIndex = 35;
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Location = new System.Drawing.Point(9, 94);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(105, 15);
            this.lblRegDate.TabIndex = 34;
            this.lblRegDate.Text = "Registration Date:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(6, 139);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(95, 15);
            this.lblRegNo.TabIndex = 32;
            this.lblRegNo.Text = "Registration No:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(9, 54);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 15);
            this.lblSurname.TabIndex = 29;
            this.lblSurname.Text = "Lastname:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(9, 19);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(67, 15);
            this.lblFirstname.TabIndex = 28;
            this.lblFirstname.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(124, 9);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(226, 20);
            this.txtFirstname.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.lblClientType);
            this.groupBox1.Controls.Add(this.lblEmployeeType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Registration";
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
            this.cboType.Location = new System.Drawing.Point(178, 55);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(143, 32);
            this.cboType.TabIndex = 25;
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientType.Location = new System.Drawing.Point(68, 71);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(76, 16);
            this.lblClientType.TabIndex = 23;
            this.lblClientType.Text = "Client Type";
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeType.Location = new System.Drawing.Point(16, 33);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(138, 18);
            this.lblEmployeeType.TabIndex = 24;
            this.lblEmployeeType.Text = "Choose Client Type";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 158);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(195, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(439, 420);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 38);
            this.btnRegister.TabIndex = 30;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 539);
            this.Controls.Add(this.grpClientDetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.grpClientDetail.ResumeLayout(false);
            this.grpClientDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientDetail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
    }
}
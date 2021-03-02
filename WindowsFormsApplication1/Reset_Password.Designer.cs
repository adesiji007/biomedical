namespace WindowsFormsApplication1
{
    partial class Reset_Password
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
            this.lblOldP = new System.Windows.Forms.Label();
            this.lblNewP = new System.Windows.Forms.Label();
            this.lblConfP = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldP
            // 
            this.lblOldP.AutoSize = true;
            this.lblOldP.Location = new System.Drawing.Point(92, 75);
            this.lblOldP.Name = "lblOldP";
            this.lblOldP.Size = new System.Drawing.Size(72, 13);
            this.lblOldP.TabIndex = 0;
            this.lblOldP.Text = "Old Password";
            // 
            // lblNewP
            // 
            this.lblNewP.AutoSize = true;
            this.lblNewP.Location = new System.Drawing.Point(92, 109);
            this.lblNewP.Name = "lblNewP";
            this.lblNewP.Size = new System.Drawing.Size(78, 13);
            this.lblNewP.TabIndex = 1;
            this.lblNewP.Text = "New Password";
            this.lblNewP.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblConfP
            // 
            this.lblConfP.AutoSize = true;
            this.lblConfP.Location = new System.Drawing.Point(92, 140);
            this.lblConfP.Name = "lblConfP";
            this.lblConfP.Size = new System.Drawing.Size(91, 13);
            this.lblConfP.TabIndex = 2;
            this.lblConfP.Text = "Confirm Password";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(209, 75);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(230, 20);
            this.txtoldpassword.TabIndex = 3;
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(209, 109);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(230, 20);
            this.txtnewpassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(209, 140);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(230, 20);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Location = new System.Drawing.Point(209, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Cyan;
            this.btnChange.Location = new System.Drawing.Point(309, 196);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(130, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 303);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.lblConfP);
            this.Controls.Add(this.lblNewP);
            this.Controls.Add(this.lblOldP);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.Load += new System.EventHandler(this.Reset_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldP;
        private System.Windows.Forms.Label lblNewP;
        private System.Windows.Forms.Label lblConfP;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChange;
    }
}
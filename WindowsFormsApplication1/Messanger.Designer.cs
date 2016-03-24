namespace WindowsFormsApplication1
{
    partial class Messanger
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCompose = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComposed = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Enter Email";
            // 
            // lblCompose
            // 
            this.lblCompose.AutoSize = true;
            this.lblCompose.Location = new System.Drawing.Point(39, 152);
            this.lblCompose.Name = "lblCompose";
            this.lblCompose.Size = new System.Drawing.Size(108, 13);
            this.lblCompose.TabIndex = 1;
            this.lblCompose.Text = "Composed Messages";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtComposed
            // 
            this.txtComposed.Location = new System.Drawing.Point(179, 152);
            this.txtComposed.Multiline = true;
            this.txtComposed.Name = "txtComposed";
            this.txtComposed.Size = new System.Drawing.Size(259, 219);
            this.txtComposed.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(324, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Messanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 475);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtComposed);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCompose);
            this.Controls.Add(this.lblEmail);
            this.Name = "Messanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messanger";
            this.Load += new System.EventHandler(this.Messanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCompose;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtComposed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;

    }
}
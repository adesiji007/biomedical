namespace WindowsFormsApplication1
{
    partial class StaffDetails
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panOverview = new System.Windows.Forms.Panel();
            this.lblBillTD = new System.Windows.Forms.Label();
            this.lblWkBill = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoOfStaff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBTDashboard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblShiftPattern = new System.Windows.Forms.Label();
            this.panBillBreakdown = new System.Windows.Forms.Panel();
            this.lbltypeTotalBill = new System.Windows.Forms.Label();
            this.lblTypeWeekBill = new System.Windows.Forms.Label();
            this.lblNoOfType = new System.Windows.Forms.Label();
            this.panOverview.SuspendLayout();
            this.panBillBreakdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(273, 183);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(186, 21);
            this.cboType.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Clinic Staffs:";
            // 
            // panOverview
            // 
            this.panOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOverview.Controls.Add(this.lblBillTD);
            this.panOverview.Controls.Add(this.lblWkBill);
            this.panOverview.Controls.Add(this.label11);
            this.panOverview.Controls.Add(this.label10);
            this.panOverview.Controls.Add(this.label2);
            this.panOverview.Controls.Add(this.label1);
            this.panOverview.Controls.Add(this.lblNoOfStaff);
            this.panOverview.Location = new System.Drawing.Point(108, 11);
            this.panOverview.Margin = new System.Windows.Forms.Padding(2);
            this.panOverview.Name = "panOverview";
            this.panOverview.Size = new System.Drawing.Size(351, 156);
            this.panOverview.TabIndex = 25;
            // 
            // lblBillTD
            // 
            this.lblBillTD.AutoSize = true;
            this.lblBillTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTD.Location = new System.Drawing.Point(236, 108);
            this.lblBillTD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillTD.Name = "lblBillTD";
            this.lblBillTD.Size = new System.Drawing.Size(99, 17);
            this.lblBillTD.TabIndex = 19;
            this.lblBillTD.Text = "AttendanceTD";
            // 
            // lblWkBill
            // 
            this.lblWkBill.AutoSize = true;
            this.lblWkBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWkBill.Location = new System.Drawing.Point(236, 76);
            this.lblWkBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWkBill.Name = "lblWkBill";
            this.lblWkBill.Size = new System.Drawing.Size(100, 17);
            this.lblWkBill.TabIndex = 18;
            this.lblWkBill.Text = "WkAttendance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Attendant Till Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "This Week\'s Attendance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Attendant Rate / Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of Staff";
            // 
            // lblNoOfStaff
            // 
            this.lblNoOfStaff.AutoSize = true;
            this.lblNoOfStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfStaff.Location = new System.Drawing.Point(236, 43);
            this.lblNoOfStaff.Name = "lblNoOfStaff";
            this.lblNoOfStaff.Size = new System.Drawing.Size(44, 17);
            this.lblNoOfStaff.TabIndex = 13;
            this.lblNoOfStaff.Text = "Staffs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Attendant Overview:";
            // 
            // btnBTDashboard
            // 
            this.btnBTDashboard.BackColor = System.Drawing.Color.Cyan;
            this.btnBTDashboard.Location = new System.Drawing.Point(271, 426);
            this.btnBTDashboard.Name = "btnBTDashboard";
            this.btnBTDashboard.Size = new System.Drawing.Size(120, 23);
            this.btnBTDashboard.TabIndex = 31;
            this.btnBTDashboard.Text = "Back to Dashboard";
            this.btnBTDashboard.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Location = new System.Drawing.Point(108, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblShiftPattern
            // 
            this.lblShiftPattern.AutoSize = true;
            this.lblShiftPattern.Location = new System.Drawing.Point(14, 27);
            this.lblShiftPattern.Name = "lblShiftPattern";
            this.lblShiftPattern.Size = new System.Drawing.Size(65, 13);
            this.lblShiftPattern.TabIndex = 29;
            this.lblShiftPattern.Text = "Shift Pattern";
            // 
            // panBillBreakdown
            // 
            this.panBillBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBillBreakdown.Controls.Add(this.lbltypeTotalBill);
            this.panBillBreakdown.Controls.Add(this.lblTypeWeekBill);
            this.panBillBreakdown.Controls.Add(this.lblNoOfType);
            this.panBillBreakdown.Controls.Add(this.label3);
            this.panBillBreakdown.Enabled = false;
            this.panBillBreakdown.Location = new System.Drawing.Point(108, 238);
            this.panBillBreakdown.Margin = new System.Windows.Forms.Padding(2);
            this.panBillBreakdown.Name = "panBillBreakdown";
            this.panBillBreakdown.Size = new System.Drawing.Size(351, 171);
            this.panBillBreakdown.TabIndex = 28;
            // 
            // lbltypeTotalBill
            // 
            this.lbltypeTotalBill.AutoSize = true;
            this.lbltypeTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypeTotalBill.Location = new System.Drawing.Point(14, 117);
            this.lbltypeTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltypeTotalBill.Name = "lbltypeTotalBill";
            this.lbltypeTotalBill.Size = new System.Drawing.Size(0, 17);
            this.lbltypeTotalBill.TabIndex = 20;
            // 
            // lblTypeWeekBill
            // 
            this.lblTypeWeekBill.AutoSize = true;
            this.lblTypeWeekBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeWeekBill.Location = new System.Drawing.Point(14, 72);
            this.lblTypeWeekBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeWeekBill.Name = "lblTypeWeekBill";
            this.lblTypeWeekBill.Size = new System.Drawing.Size(0, 17);
            this.lblTypeWeekBill.TabIndex = 19;
            // 
            // lblNoOfType
            // 
            this.lblNoOfType.AutoSize = true;
            this.lblNoOfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfType.Location = new System.Drawing.Point(12, 43);
            this.lblNoOfType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfType.Name = "lblNoOfType";
            this.lblNoOfType.Size = new System.Drawing.Size(0, 17);
            this.lblNoOfType.TabIndex = 18;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 481);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panOverview);
            this.Controls.Add(this.btnBTDashboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblShiftPattern);
            this.Controls.Add(this.panBillBreakdown);
            this.Name = "StaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDetails";
            this.Load += new System.EventHandler(this.StaffDetails_Load);
            this.panOverview.ResumeLayout(false);
            this.panOverview.PerformLayout();
            this.panBillBreakdown.ResumeLayout(false);
            this.panBillBreakdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panOverview;
        private System.Windows.Forms.Label lblBillTD;
        private System.Windows.Forms.Label lblWkBill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoOfStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBTDashboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblShiftPattern;
        private System.Windows.Forms.Panel panBillBreakdown;
        private System.Windows.Forms.Label lbltypeTotalBill;
        private System.Windows.Forms.Label lblTypeWeekBill;
        private System.Windows.Forms.Label lblNoOfType;
    }
}
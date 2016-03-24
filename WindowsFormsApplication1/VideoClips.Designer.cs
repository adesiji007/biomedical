namespace WindowsFormsApplication1
{
    partial class VideoClips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoClips));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Choose = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.but4 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.textBox1_path = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Choose);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.but4);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Controls.Add(this.but1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 487);
            this.panel1.TabIndex = 8;
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(0, 3);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(171, 23);
            this.Choose.TabIndex = 10;
            this.Choose.Text = "Choose File";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 456);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Exit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(3, 203);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(87, 23);
            this.but4.TabIndex = 3;
            this.but4.Text = "Play Video 4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(99, 203);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 23);
            this.but3.TabIndex = 2;
            this.but3.Text = "Play Video 3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(96, 165);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 1;
            this.but2.Text = "Play Video 2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(3, 165);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(87, 23);
            this.but1.TabIndex = 0;
            this.but1.Text = "Play Video 1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // textBox1_path
            // 
            this.textBox1_path.Location = new System.Drawing.Point(215, 12);
            this.textBox1_path.Multiline = true;
            this.textBox1_path.Name = "textBox1_path";
            this.textBox1_path.Size = new System.Drawing.Size(514, 20);
            this.textBox1_path.TabIndex = 9;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(475, 265);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(254, 228);
            this.axWindowsMediaPlayer3.TabIndex = 10;
            // 
            // axWindowsMediaPlayer4
            // 
            this.axWindowsMediaPlayer4.Enabled = true;
            this.axWindowsMediaPlayer4.Location = new System.Drawing.Point(215, 265);
            this.axWindowsMediaPlayer4.Name = "axWindowsMediaPlayer4";
            this.axWindowsMediaPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer4.OcxState")));
            this.axWindowsMediaPlayer4.Size = new System.Drawing.Size(254, 228);
            this.axWindowsMediaPlayer4.TabIndex = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(215, 34);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(254, 228);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(475, 34);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(254, 228);
            this.axWindowsMediaPlayer2.TabIndex = 10;
            // 
            // VideoClips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 526);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.axWindowsMediaPlayer4);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.textBox1_path);
            this.Controls.Add(this.panel1);
            this.Name = "VideoClips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoClips";
            this.Load += new System.EventHandler(this.VideoClips_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TextBox textBox1_path;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
    }
}
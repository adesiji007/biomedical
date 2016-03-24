using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class VideoClips : Form
    {
        private string Server;
        private string DB;
        private string UName;
        ////private string Pass;
        private DataTable myDT;
        int i;


        public VideoClips(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //DT = dt;
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;
        //private DataTable myDT;

        private void Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1_path.Text = openFileDialog1.FileName;
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1_path.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = textBox1_path.Text;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = textBox1_path.Text;
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.URL = textBox1_path.Text;
            axWindowsMediaPlayer4.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.previous();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.next();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void VideoClips_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

           // DisplayTable("Select * fROM dynamic_movement");

        }
    }
}

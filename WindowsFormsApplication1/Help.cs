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
    public partial class Help : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;

        public Help(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information hel = new Login_Information(Server, DB, UName);
            this.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information logh = new Login_Information(Server, DB, UName);
            logh.Show();
        }
    }
}

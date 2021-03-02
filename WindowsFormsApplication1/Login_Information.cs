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
    public partial class Login_Information : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        public Login_Information(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(Server, DB, UName);
            this.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help dash = new Help(Server, DB, UName);
            dash.Show();
        }

        private void Login_Information_Load(object sender, EventArgs e)
        {

        }
    }
}

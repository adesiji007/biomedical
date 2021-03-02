using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        //private MySqlDataAdapter myAdap;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard myForm = new Dashboard(txtServer.Text, txtDB.Text, txtUN.Text);
            myForm.ShowDialog();

        }

        private void login_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Dashboard myForm = new Dashboard(txtServer.Text, txtDB.Text, txtUN.Text);
            //myForm.ShowDialog();
        }

            

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butForget_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password newu = new Forget_Password(Server, DB, UName);
            newu.Show();
        }

        private void butNewuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newu = new NewUser(Server, DB, UName);
            newu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Password resp = new Reset_Password(Server, DB, UName);
            resp.Show();
        }
    }
}

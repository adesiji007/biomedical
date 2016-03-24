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

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //NewUser newu = new NewUser();
            //newu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Forget_Password newu = new Forget_Password(Server, DB, UName);
            //newu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

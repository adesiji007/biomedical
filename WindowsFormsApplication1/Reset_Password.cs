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
    public partial class Reset_Password : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        private MySqlDataAdapter myAdap;
        public Reset_Password(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }
        private MySqlConnection myConn;
        private string sConnStr;
        DataTable dTable = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login resp = new login();
            resp.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtnewpassword.Text == txtConfirmPassword.Text)
            {
                //sConnStr = "select * from login where Username = '" + txtUN.Text + "' and password = '" + txtPassword.Text + "'";
                sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
                myConn = new MySqlConnection(sConnStr);

                //myConn = dTable.GetTable(sConnStr);

                if (dTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        sConnStr = "UPDATE bio_login SET password = '" + txtConfirmPassword.Text + "' WHERE user_name = '" + Convert.ToString(dTable.Rows[i]["user_name"]) + "'";
                        //dTable.ExecuteSQLNonQuery(sConnStr);
                        
                    }
                    MessageBox.Show("Password Changed Successfully");
                    txtnewpassword.Text = txtConfirmPassword.Text;
                    return;
                }
                else
                {
                    MessageBox.Show("User Not Found");
                    return;
                }
            }
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            //DisplayTable("Select * fROM bio_user");
        }
    }
}

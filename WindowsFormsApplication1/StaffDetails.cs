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
    public partial class StaffDetails : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        public StaffDetails(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

         private MySqlConnection myConn;
         private string sConnStr;
      

        private void StaffDetails_Load(object sender, EventArgs e)
        {
             DataTable dTable = new DataTable();
            
            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM  bio_clientdetail");
            
        }
        private void DisplayTable(string sQuery)
        {
             try
            {
                //myConn.Open();
                //MessageBox.Show("connected");
                 this.Hide();
                DataTable dTable2 = new DataTable();
                
                MySqlDataAdapter myAdap = new MySqlDataAdapter(sQuery, sConnStr);
                myAdap.Fill(dTable2);
                myDT = dTable2;

                //dataGridView.DataSource = dTable2;
               // listBox1.DataSource = dTable2;
                myAdap.Dispose();
                dTable2.Dispose();
            }
            catch
            {
                MessageBox.Show("not connected");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }
    }
}

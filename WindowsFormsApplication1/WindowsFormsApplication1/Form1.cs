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
    public partial class Dashboard : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        private DataTable myDT;
        
        public Dashboard(string server, string db, string uname)
        {
            InitializeComponent();

            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;

            
        }

        public Dashboard(DataTable myDT)
        {
            // TODO: Complete member initialization
            this.myDT = myDT;
        }

        private MySqlConnection myConn;
        private string sConnStr;
     //--private DataTable dTable;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM user");
           
        }
        private void DisplayTable(string sQuery)
        {
             try
            {
               // myConn.Open();
                MessageBox.Show("connected");
                DataTable dTable2 = new DataTable();
                
                MySqlDataAdapter myAdap = new MySqlDataAdapter(sQuery, sConnStr);
                myAdap.Fill(dTable2);
                myDT = dTable2;

                dataGridView.DataSource = dTable2;
               // listBox1.DataSource = dTable2;
                myAdap.Dispose();
                dTable2.Dispose();
            }
            catch
            {
                MessageBox.Show("not connected");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           // txtName.Text
            try
            {
               
                
                string sQry = "SELECt * FROm USER";
                MySqlDataAdapter myAdap = new MySqlDataAdapter(sQry, sConnStr);
                DataTable dTable = new DataTable();

                myAdap.Fill(dTable);

                DataRow dr = dTable.NewRow();
                dr["id"] = txtID.Text;
                dr["fname"] = txtName.Text;
                dr["lname"] = txtLastname.Text;
                dr["age"] = txtAge.Text;

                dTable.Rows.Add(dr);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder(myAdap);

                myAdap.Update(dTable);


                DisplayTable("Select * fROM user");
                
            }
            catch
            {
                MessageBox.Show("not connected");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DisplayTable("Select * fROM user where fname = '" + txtSearch.Text + "'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2(myDT);
            myform.Show();
        }

        private void butImpatient_Click(object sender, EventArgs e)
        {

        }
    }
}

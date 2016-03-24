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
    public partial class Clients_Details : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;

        public Clients_Details(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }
        //public DataTable myDT;
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;

        private void Clients_Details_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM clientdetail");
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
                //myDT = dTable2;

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


        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dah = new Dashboard(Server, DB, UName);
            dah.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from user", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            dr["ClientType"] = cboType.Text;
            dr["Title"] = txtTitle.Text;
            dr["Firstname"] = txtFirstname.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Address"] = txtAddress.Text;
            dr["DOB"] = txtDOB.Text;
            dr["Phone_Number"] = txtPhone_Number.Text;
            dr["Gender"] = cboGender.Text;
            dr["Occupation"] = txtOccupation.Text;
            dr["Reference_No"] = txtRefNo.Text;

            dTable.Rows.Add(dr);

            // create a command builder
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);


            //update the data with mnodification table
            int iRowsAffeected = dAdapter.Update(dTable);
            dAdapter.Dispose();

            if (iRowsAffeected > 0)
            {
                // update the datagrid
                // display if new row is added
                string sQuery = "SELECT * FROM user";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();
        }
    }
}

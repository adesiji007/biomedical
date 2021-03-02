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
    public partial class NewUser : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        private DataTable DT;

        public NewUser(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
            //DT = dt;
        }

        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;

        DataTable dt = new DataTable();
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM bio_training_week");

        }

        private void DisplayTable(string sQuery)
        {
            try
            {
                //myConn.Open();
                //MessageBox.Show("connected");
                this.Hide();
                DataTable dTable2 = new DataTable();
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("select * from bio_newuser", myConn);

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);

                MySqlDataAdapter myAdap = new MySqlDataAdapter(sQuery, sConnStr);
                myAdap.Fill(dTable2);
                myDT = dTable2;

                //dataGridView2.DataSource = dTable2;
                // listBox1.DataSource = dTable2;
                myAdap.Dispose();
                dTable2.Dispose();
            }
            catch
            {
                MessageBox.Show("not connected");
            }

            //dataGridView1.DataSource = DT;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_newuser", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;
                dr["ClientType"] = cboType.Text;
                dr["Firstname"] = txtFullname.Text;
                dr["Registration_Date"] = Convert.ToDateTime(txtRegistrationDate.Text);
                //Date date = format.parse(string);
                //DateTime dt = Convert.ToDateTime(dateTime);
                dr["Registration_Number"] = txtRegistrationNo.Text;
                dr["Email"] = txtEmail.Text;
                dr["Password"] = txtPassword.Text;


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
                    string sQuery = "SELECT * FROM bio_newuser";
                    DisplayTable(sQuery);


                    MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Show();

                this.Hide();
                login logg = new login();
                logg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //    dt.Rows.Add(cboType.Text, txtFirstname.Text, txtLname.Text, txtRegistrationDate.Text, txtRegistrationNo.Text, txtEmail.Text, txtPassword.Text);
            //    this.Hide();
            //    login logg = new login();
            //    logg.Show();
            //    MessageBox.Show("Information stored");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}

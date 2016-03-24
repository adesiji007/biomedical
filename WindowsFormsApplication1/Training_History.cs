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
    public partial class Training_History : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;

        public Training_History(string server, string db, string uname)
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

        private void Training_History_Load(object sender, EventArgs e)
        {
            //myDT.Columns.Add("Training_Reference_Code", typeof(int));
            //myDT.Columns.Add("TN_Sport", typeof(string));
            //myDT.Columns.Add("TN_Note", typeof(string));
            //myDT.Columns.Add("TN_Stenght", typeof(int));
            //myDT.Columns.Add("TN_Weakness", typeof(int));
            //myDT.Columns.Add("PHP_Note", typeof(int));
            //myDT.Columns.Add("PHP_Strenght", typeof(int));
            //myDT.Columns.Add("PHP_Weakness", typeof(int));


            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM training_history");
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

                dataGridView1.DataSource = dTable2;
                // listBox1.DataSource = dTable2;
                myAdap.Dispose();
                dTable2.Dispose();
            }
            catch
            {
                MessageBox.Show("not connected");
            }
        }



        private void Add_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from training_history", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;
            dr["Firstname"] = txtFirstname.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Training_Reference_Code"] = txtTraRefCode.Text;
            dr["TN_Sport"] = txtTNSport.Text;
            dr["TN_Note"] = txtTNNote.Text;
            dr["TN_Stenght"] = txtTNStrenght.Text;
            dr["TN_Weakness"] = txtTNWeakness.Text;
            dr["PHP_Note"] = txtPPNote.Text;
            dr["PHP_Strenght"] = txtPPStrenght.Text;
            dr["PHP_Weakness"] = txtPPWeakness.Text;

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
                string sQuery = "SELECT * FROM training_history";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myDT.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = myDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtFirstname.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtTraRefCode.Text = row.Cells[3].Value.ToString();
            txtTNSport.Text = row.Cells[4].Value.ToString();
            txtTNNote.Text = row.Cells[5].Value.ToString();
            txtTNStrenght.Text = row.Cells[6].Value.ToString();
            txtTNWeakness.Text = row.Cells[7].Value.ToString();
            txtPPNote.Text = row.Cells[8].Value.ToString();
            txtPPStrenght.Text = row.Cells[9].Value.ToString();
            txtPPWeakness.Text = row.Cells[10].Value.ToString();



           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[i];
            row.Cells[1].Value = txtFirstname.Text;
            row.Cells[2].Value = txtLastname.Text;
            row.Cells[3].Value = txtTraRefCode.Text;
            row.Cells[4].Value = txtTNSport.Text;
            row.Cells[5].Value = txtTNNote.Text;
            row.Cells[6].Value = txtTNStrenght.Text;
            row.Cells[7].Value = txtTNWeakness.Text;
            row.Cells[8].Value = txtPPNote.Text;
            row.Cells[9].Value = txtPPStrenght.Text;
            row.Cells[10].Value = txtPPWeakness.Text;


            //DataGridViewRow row = dataGridView.Rows[i];
            ////row.Cells[0].Value = txtID.Text;
            //row.Cells[1].Value = cboType.Text;
            //row.Cells[2].Value = txtTitle.Text;
            //row.Cells[3].Value = txtName.Text;
            //row.Cells[4].Value = txtLastname.Text;
            //row.Cells[5].Value = txtAddress.Text;
            //row.Cells[6].Value = txtDOB.Text;
            //row.Cells[7].Value = txtPhone_Number.Text;
            //row.Cells[8].Value = txtGender.Text;
            //row.Cells[9].Value = txtOccupation.Text;
            //row.Cells[10].Value = txtReference_Number.Text;

             // Display the contents of the row specified by the rowIndex variable
            //txtFirstname.Text = dTable.Rows[1]["Firstname"].ToString();
            //txtLastname.Text = dTable.Rows[2]["Lastname"].ToString();
            //txtTraRefCode.Text = dTable.Rows[3]["Training_Reference_Code"].ToString();
            //txtTNSport.Text = dTable.Rows[4]["TN_Sport"].ToString();
            //txtTNNote.Text = dTable.Rows[5]["TN_Note"].ToString();
            //txtTNStrenght.Text = dTable.Rows[6]["TN_Stenght"].ToString();
            //txtTNWeakness.Text = dTable.Rows[7]["TN_Weakness"].ToString();
            //txtPPNote.Text = dTable.Rows[8]["PHP_Note"].ToString();
            //txtPPStrenght.Text = dTable.Rows[9]["PHP_Strenght"].ToString();
            //txtPPWeakness.Text = dTable.Rows[10][" 	PHP_Weakness"].ToString();

                      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtFirstname.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtTraRefCode.Text = row.Cells[3].Value.ToString();
            txtTNSport.Text = row.Cells[4].Value.ToString();
            txtTNNote.Text = row.Cells[5].Value.ToString();
            txtTNStrenght.Text = row.Cells[6].Value.ToString();
            txtTNWeakness.Text = row.Cells[7].Value.ToString();
            txtPPNote.Text = row.Cells[8].Value.ToString();
            txtPPStrenght.Text = row.Cells[9].Value.ToString();
            txtPPWeakness.Text = row.Cells[10].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from  training_history", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;

            dr["Firstname"] = txtFirstname.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Training_Reference_Code"] = txtTraRefCode.Text;
            dr["TN_Sport"] = txtTNSport.Text;
            dr["TN_Note"] = txtTNNote.Text;
            dr["TN_Stenght"] = txtTNStrenght.Text;
            dr["TN_Weakness"] = txtTNWeakness.Text;
            dr["PHP_Note"] = txtPPNote.Text;
            dr["PHP_Strenght"] = txtPPStrenght.Text;
            dr["PHP_Weakness"] = txtPPWeakness.Text;

            //txtTraRefCode.Text = dTable.Rows[0]["Training_Reference_Code"].ToString();
            //txtTNSport.Text = dTable.Rows[1]["TN_Sport"].ToString();
            //txtTNNote.Text = dTable.Rows[2]["TN_Note"].ToString();
            //txtTNStrenght.Text = dTable.Rows[3]["TN_Stenght"].ToString();
            //txtTNWeakness.Text = dTable.Rows[4]["TN_Weakness"].ToString();
            //txtPPNote.Text = dTable.Rows[5]["PHP_Note"].ToString();
            //txtPPStrenght.Text = dTable.Rows[6]["PHP_Strenght"].ToString();
            //txtPPWeakness.Text = dTable.Rows[7][" 	PHP_Weakness"].ToString();
            

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
                string sQuery = "SELECT * FROM  training_history";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

        }

        private void txtTNSport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            //DisplayTable("Select * fROM bio_training_history");
            DisplayTable("SELECT a.*, u.Fullname FROM bio_training_history a, bio_user u WHERE a.user_id = u.user_ID");
            populateName();
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
        private void populateName()
        {
            try
            {
                String query = "select Fullname from bio_user";
                MySqlDataAdapter myAdap = new MySqlDataAdapter(query, sConnStr);
                DataTable userdata = new DataTable();
                myAdap.Fill(userdata);
                foreach (DataRow dr in userdata.Rows)
                {
                    comboBox1.Items.Add(dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Add_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_training_history", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;
                dr["Fullname"] = comboBox1.Text;
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
                    string sQuery = "SELECT * FROM bio_training_history";
                    DisplayTable(sQuery);


                    MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                //MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            comboBox1.Text = row.Cells[1].Value.ToString();
            txtTraRefCode.Text = row.Cells[2].Value.ToString();
            txtTNSport.Text = row.Cells[3].Value.ToString();
            txtTNNote.Text = row.Cells[4].Value.ToString();
            txtTNStrenght.Text = row.Cells[5].Value.ToString();
            txtTNWeakness.Text = row.Cells[6].Value.ToString();
            txtPPNote.Text = row.Cells[7].Value.ToString();
            txtPPStrenght.Text = row.Cells[8].Value.ToString();
            txtPPWeakness.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Cells[1].Value = comboBox1.Text;
                row.Cells[2].Value = txtTraRefCode.Text;
                row.Cells[3].Value = txtTNSport.Text;
                row.Cells[4].Value = txtTNNote.Text;
                row.Cells[5].Value = txtTNStrenght.Text;
                row.Cells[6].Value = txtTNWeakness.Text;
                row.Cells[7].Value = txtPPNote.Text;
                row.Cells[8].Value = txtPPStrenght.Text;
                row.Cells[9].Value = txtPPWeakness.Text;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                comboBox1.Text = row.Cells[1].Value.ToString();
                txtTraRefCode.Text = row.Cells[2].Value.ToString();
                txtTNSport.Text = row.Cells[3].Value.ToString();
                txtTNNote.Text = row.Cells[4].Value.ToString();
                txtTNStrenght.Text = row.Cells[5].Value.ToString();
                txtTNWeakness.Text = row.Cells[6].Value.ToString();
                txtPPNote.Text = row.Cells[7].Value.ToString();
                txtPPStrenght.Text = row.Cells[8].Value.ToString();
                txtPPWeakness.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from  bio_training_history", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;

                //dr["Fullname"] = comboBox1.Text;
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
                    string sQuery = "SELECT * FROM  bio_training_history";
                    DisplayTable(sQuery);


                    MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTNSport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ActivityRecord : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        private DataTable myDT;

        public ActivityRecord(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard(Server, DB, UName);
            db.Show();
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        DataTable dt = new DataTable();
        int i;

        private MySqlConnection myConn;
        private string sConnStr;

        private void ActivityRecord_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("SELECT a.*, u.Fullname FROM bio_activity_record a, bio_user u WHERE a.user_id = u.user_ID");
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

                dataGridViewActivity.DataSource = dTable2;
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
            try { 
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_activity_record", myConn);

                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;
                dr["TrainingCode"] = txtTraining.Text;
                dr["Fullname"] = comboBox1.Text;
                dr["DatOfActivity"] = txtDoActivity.Text;
                dr["TypeOfActivity"] = txtTypActivity.Text;
                dr["PreviousActivity"] = txtPrv.Text;
                dr["DateOfNextActivity"] = txtNextAct.Text;

                dTable.Rows.Add(dr);

                // create a command builder
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);


                //update the data with modification table
                int iRowsAffeected = dAdapter.Update(dTable);
                dAdapter.Dispose();

                if (iRowsAffeected > 0)
                {
                    // update the datagrid
                    // display if new row is added
                    string sQuery = "SELECT * FROM bio_activity_record";
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
                //MessageBox.Show(ex.Message);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                dTable.Rows.RemoveAt(dataGridViewActivity.CurrentCell.RowIndex);
                dataGridViewActivity.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
                        
            DisplayTable("Select * fROM  bio_activity_record where Fullname = '" + txtSearch.Text + "'");
            this.Show();
        }

        private void dataGridViewActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                i = e.RowIndex;
                DataGridViewRow row = dataGridViewActivity.Rows[i];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTraining.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                txtDoActivity.Text = row.Cells[3].Value.ToString();
                txtTypActivity.Text = row.Cells[4].Value.ToString();
                txtPrv.Text = row.Cells[5].Value.ToString();
                txtNextAct.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridViewActivity.Rows[i];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTraining.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[7].Value.ToString();
                txtDoActivity.Text = row.Cells[2].Value.ToString();
                txtTypActivity.Text = row.Cells[3].Value.ToString();
                txtPrv.Text = row.Cells[4].Value.ToString();
                txtNextAct.Text = row.Cells[5].Value.ToString();

                txtTraining.Enabled = false;
                comboBox1.Enabled = false;
                button1.Enabled = false;
                btnUpdate.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //DisplayTable("INSERT INTO bio_activity_record (TrainingCode,Fullname,DatOfActivity, TypeOfActivity, PreviousActivity, DateOfNextActivity) VALUES('" + txtTraining.Text + "','" + comboBox1.Text + "','" + txtDoActivity.Text + "','" + txtTypActivity.Text + "','" + txtPrv.Text + "','" + txtNextAct.Text + "')");
            //this.Show();
            clearFields();
        }

        private void clearFields()
        {
            txtID.Clear();
            comboBox1.Text = "";
            comboBox1.Enabled = true;
            txtTraining.Clear();
            txtTraining.Enabled = true;
            txtPrv.Clear();
            txtPrv.Enabled = false;
            txtDoActivity.Clear();
            txtDoActivity.Enabled = false;
            txtTypActivity.Clear();
            txtTypActivity.Enabled = true;
            txtNextAct.Clear();
            txtNextAct.Enabled = true;

            button1.Enabled = true;
            btnUpdate.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                myDT.Rows.RemoveAt(dataGridViewActivity.CurrentCell.RowIndex);
                dataGridViewActivity.DataSource = myDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            try
            {
                // MySqlDataAdapter dAdapter = new MySqlDataAdapter("UPDATE bio_user (SET Firstname = 'Tunde' and Lastname = 'Coxhoe')  WHERE (user_ID = '2')", myConn);
                //UPDATE CUSTOMERS SET ADDRESS = 'Pune'WHERE ID = 6;


                //DataTable dTable = new DataTable();
                //dAdapter.Fill(dTable);

                DataGridViewRow row = dataGridViewActivity.Rows[i];
                row.Cells[0].Value = txtID.Text;
                row.Cells[1].Value = txtTraining.Text;
                row.Cells[2].Value = comboBox1.Text;
                row.Cells[3].Value = txtDoActivity.Text;
                row.Cells[4].Value = txtTypActivity.Text;
                row.Cells[5].Value = txtPrv.Text;
                row.Cells[6].Value = txtNextAct.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        

        //private void dataGridViewActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}

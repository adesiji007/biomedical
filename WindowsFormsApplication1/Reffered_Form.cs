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
    public partial class Reffered_Form : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        //private DataTable DT;


        public Reffered_Form(string server, string db, string uname)
        {
            InitializeComponent();
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
            //DT = dt;

        }

        DataTable dTable2 = new DataTable();
        //DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;

        //DataTable myDT = new DataTable();
        //int i;

        private void Reffered_Form_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dTable = new DataTable();

                sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
                myConn = new MySqlConnection(sConnStr);
              
                
                DisplayTable("SELECT a.*, u.Fullname FROM bio_reffered_form a, bio_user u WHERE a.user_id = u.user_ID");
                populateName();
                //MessageBox.Show("here");

            }
            catch
            {
                MessageBox.Show("not connected");
            }

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

            //dataGridView1.DataSource = DT;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard fs = new Dashboard(Server, DB, UName);
            fs.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_reffered_form", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;

                dr["Training_Code"] = textTraCode.Text;
                dr["Fullname"] = comboBox1.Text;
                dr["Date_of_Reffered"] = dateTimePicker1.Text;
                dr["Hospital_Location"] = textHLocation.Text;
                dr["NatureOfReffered"] = textReffered.Text;
                dr["General_Note"] = textNote.Text;

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
                    string sQuery = "SELECT * FROM bio_reffered_form";
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
                textTraCode.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                textHLocation.Text = row.Cells[3].Value.ToString();
                textReffered.Text = row.Cells[4].Value.ToString();
                textNote.Text = row.Cells[5].Value.ToString();
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
                row.Cells[0].Value = textTraCode.Text;
                row.Cells[1].Value = comboBox1.Text;
                row.Cells[2].Value = dateTimePicker1.Text;
                row.Cells[3].Value = textHLocation.Text;
                row.Cells[4].Value = textReffered.Text;
                row.Cells[5].Value = textNote.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                textTraCode.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                textHLocation.Text = row.Cells[3].Value.ToString();
                textReffered.Text = row.Cells[4].Value.ToString();
                textNote.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DisplayTable("INSERT INTO  bio_reffered_form (Training_Code,Fullname,Date_of_Reffered, Hospital_Location, NatureOfReffered, General_Note) VALUES('" + textTraCode.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textHLocation.Text + "','" + textReffered.Text + "','" + textNote.Text + "')");
            this.Show();
        }
    }
}

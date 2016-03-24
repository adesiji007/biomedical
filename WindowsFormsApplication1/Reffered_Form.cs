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
        private DataTable DT;


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
        DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;

        //DataTable myDT = new DataTable();
        //int i;

        private void Reffered_Form_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM reffered_form");
            
            
            
            //myDT.Columns.Add("Training_Code", typeof(int));
            //myDT.Columns.Add("Training_Name", typeof(string));
            //myDT.Columns.Add("Date_of_Reffered", typeof(string));
            //myDT.Columns.Add("Hospital_Location", typeof(int));
            //myDT.Columns.Add("NatureOfReffered", typeof(int));
            //myDT.Columns.Add("General_Note", typeof(int));
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard fs = new Dashboard(Server, DB, UName);
            fs.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from reffered_form", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;

            dr["Training_Code"] = textTraCode.Text;
            dr["Training_Name"] = textName.Text;
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
                string sQuery = "SELECT * FROM reffered_form";
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
            textTraCode.Text = row.Cells[0].Value.ToString();
            textName.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            textHLocation.Text = row.Cells[3].Value.ToString();
            textReffered.Text = row.Cells[4].Value.ToString();
            textNote.Text = row.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[i];
            row.Cells[0].Value = textTraCode.Text;
            row.Cells[1].Value = textName.Text;
            row.Cells[2].Value = dateTimePicker1.Text;
            row.Cells[3].Value = textHLocation.Text;
            row.Cells[4].Value = textReffered.Text;
            row.Cells[5].Value = textNote.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            textTraCode.Text = row.Cells[0].Value.ToString();
            textName.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            textHLocation.Text = row.Cells[3].Value.ToString();
            textReffered.Text = row.Cells[4].Value.ToString();
            textNote.Text = row.Cells[5].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DisplayTable("INSERT INTO  reffered_form (Training_Code,Training_Name,Date_of_Reffered, Hospital_Location, NatureOfReffered, General_Note) VALUES('" + textTraCode.Text + "','" + textName.Text + "','" + dateTimePicker1.Text + "','" + textHLocation.Text + "','" + textReffered.Text + "','" + textNote.Text + "')");
            this.Show();
        }
    }
}

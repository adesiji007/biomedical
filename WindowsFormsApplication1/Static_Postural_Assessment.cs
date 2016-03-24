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
    public partial class Static_Postural_Assessment : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;

        public Static_Postural_Assessment(string server, string db, string uname)
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

        private void Static_Postural_Assessment_Load(object sender, EventArgs e)
        {

            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM  static_postural_assessment");


            //myDT.Columns.Add("Reference_No", typeof(int));
            //myDT.Columns.Add("Name", typeof(string));
            //myDT.Columns.Add("Assessment_Date", typeof(string));
            //myDT.Columns.Add("Front_Feet", typeof(int));
            //myDT.Columns.Add("Front_Hips", typeof(int));
            //myDT.Columns.Add("Front_Shoulders", typeof(int));
            //myDT.Columns.Add("Side_Knees", typeof(int));
            //myDT.Columns.Add("Side_Hips", typeof(int));
            //myDT.Columns.Add("Side_Shoulders", typeof(int));
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

        

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from static_postural_assessment", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;
            dr["Name"] = txtName.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Reference_No"] = txtRef.Text;
            dr["Assessment_Date"] = txtAss.Text;
            dr["Front_Feet"] = comboBox1.Text;
            dr["Front_Hips"] = comboBox2.Text;
            dr["Front_Shoulders"] = comboBox4.Text;
            dr["Side_Knees"] = comboBox3.Text;
            dr["Side_Hips"] = comboBox5.Text;
            dr["Side_Shoulders"] = comboBox6.Text;

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
                string sQuery = "SELECT * FROM static_postural_assessment";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

        }

        private void button5_Click(object sender, EventArgs e)
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
            txtRef.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtAss.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();
            comboBox2.Text = row.Cells[5].Value.ToString();
            comboBox3.Text = row.Cells[6].Value.ToString();
            comboBox4.Text = row.Cells[7].Value.ToString();
            comboBox5.Text = row.Cells[8].Value.ToString();
            comboBox6.Text = row.Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[i];
            row.Cells[0].Value = txtRef.Text;
            row.Cells[1].Value = txtName.Text;
            row.Cells[2].Value = txtLastname.Text;
            row.Cells[3].Value = txtAss.Text;
            row.Cells[4].Value = comboBox1.Text;
            row.Cells[5].Value = comboBox2.Text;
            row.Cells[6].Value = comboBox3.Text;
            row.Cells[7].Value = comboBox4.Text;
            row.Cells[8].Value = comboBox5.Text;
            row.Cells[9].Value = comboBox6.Text;
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtRef.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtAss.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();
            comboBox2.Text = row.Cells[5].Value.ToString();
            comboBox3.Text = row.Cells[6].Value.ToString();
            comboBox4.Text = row.Cells[7].Value.ToString();
            comboBox5.Text = row.Cells[8].Value.ToString();
            comboBox6.Text = row.Cells[9].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayTable("Select * fROM static_postural_assessment where Name = '" + txtSearch.Text + "'");
            this.Show();
        }
    }
}

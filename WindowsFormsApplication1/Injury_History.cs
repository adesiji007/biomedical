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
    public partial class Injury_History : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        private DataTable DT;

        public Injury_History(string server, string db, string uname)
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

        private void Injury_History_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM   injury_history");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
            textBox1.Text = row.Cells[4].Value.ToString();
            textBox2.Text = row.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
            textBox1.Text = row.Cells[4].Value.ToString();
            textBox2.Text = row.Cells[5].Value.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from  injury_history", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;
            //dr["Reference_Code"] = Convert.ToInt32(textBox4.Text);
            dr["Reference_Code"] = textBox4.Text;
            dr["Training_Name"] = textBox3.Text;
            dr["Lastname"] = txtLastname.Text;
            //int.Parse(textBox1.Text);
            //dr["Reference_Code"] = int.Parse(textBox4.Text);
            dr["Date"] = textBox5.Text;
            dr["Note"] = textBox1.Text;
            dr["Additional_Note"] = textBox2.Text;
          


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
                string sQuery = "SELECT * FROM  injury_history";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayTable("Select * fROM user where Training_Name = '" + txtSearch.Text + "'");
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[i];
            //row.Cells[0].Value = txtID.Text;
            row.Cells[2].Value = textBox4.Text;
            row.Cells[1].Value = textBox3.Text;
            row.Cells[2].Value = txtLastname.Text;
            row.Cells[3].Value = textBox5.Text;
            row.Cells[4].Value = textBox1.Text;
            row.Cells[5].Value = textBox2.Text;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

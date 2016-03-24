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
    public partial class History_Week : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        private DataTable DT;

        public History_Week(string server, string db, string uname)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM training_week");

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

                dataGridView2.DataSource = dTable2;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[4].Value.ToString();
            comboBoxTime.Text = row.Cells[5].Value.ToString();
            comboBoxSession.Text = row.Cells[6].Value.ToString();
            comboBoxDuration.Text = row.Cells[7].Value.ToString();
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[4].Value.ToString();
            comboBoxTime.Text = row.Cells[5].Value.ToString();
            comboBoxSession.Text = row.Cells[6].Value.ToString();
            comboBoxDuration.Text = row.Cells[7].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from training_week", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;
            //dr["Reference_No"] = Convert.ToInt32(txtReference_Number.Text);
            dr["Training_Reference_Code"] = Convert.ToInt32(textBox4.Text);
            dr["Name"] = textBox2.Text;
            dr["Date"] = textBox3.Text;
            dr["DateOfTheWeek"] = dateTimePicker1.Text;
            dr["Time"] = comboBoxTime.Text;
            dr["Session"] = comboBoxSession.Text;
            dr["Duration"] = comboBoxDuration.Text;
            

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
                string sQuery = "SELECT * FROM training_week";
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
            DisplayTable("Select * fROM user where Name = '" + txtSearch.Text + "'");
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[i];
            //row.Cells[0].Value = txtID.Text;
            row.Cells[1].Value = textBox4.Text;
            row.Cells[2].Value = textBox2.Text;
            row.Cells[3].Value = textBox3.Text;
            row.Cells[4].Value = dateTimePicker1.Text;
            row.Cells[5].Value = comboBoxTime.Text;
            row.Cells[6].Value = comboBoxSession.Text;
            row.Cells[7].Value = comboBoxDuration.Text;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }
    }
}

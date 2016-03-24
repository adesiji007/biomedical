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
    public partial class Self_Mobility_Screen : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        //public DataTable myDT;
        int i;
        private DataTable DT;

        public Self_Mobility_Screen(string server, string db, string uname)
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

        private void Self_Mobility_Screen_Load(object sender, EventArgs e)
        {
            //DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM self_mobility_screen");

            //dt.Columns.Add("Reference_No", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Assessment_Date", typeof(string));
            //dt.Columns.Add("Deep_Squat_Alignment", typeof(string));
            //dt.Columns.Add("Hurdle_Step_Alignment", typeof(string));
            //dt.Columns.Add("Inline_Step_Alignment", typeof(string));
            //dt.Columns.Add("Active_straight_Leg_Raise_Flexed", typeof(string));
            //dt.Columns.Add("Seated_Rotation_45Degree", typeof(string));
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
                
                dataGridViewSelf.DataSource = dTable2;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from self_mobility_screen", myConn);


            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
            //dr["ID"] = txtID.Text;
            dr["Name"] = txtName.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Reference_No"] = txtRefenNo.Text;
            dr["Assessment_Date"] = txtAssmentDate.Text;
            dr["Deep_Squat_Alignment"] = comboBox1.Text;
            dr["Hurdle_Step_Alignment"] = comboBox2.Text;
            dr["Inline_Step_Alignment"] = comboBox3.Text;
            dr["Active_straight_Leg_Raise_Flexed"] = comboBox4.Text;
            dr["Seated_Rotation_45Degree"] = comboBox5.Text;


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
                string sQuery = "SELECT * FROM self_mobility_screen";
                DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

            //try
            //{
            //    dt.Rows.Add(txtRefenNo.Text, txtName.Text, txtAssmentDate.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        dt.Rows.RemoveAt(dataGridViewSelf.CurrentCell.RowIndex);
        //        dataGridViewSelf.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        }

        private void dataGridViewSelf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridViewSelf.Rows[i];
            txtName.Text = row.Cells[0].Value.ToString();
            txtLastname.Text = row.Cells[0].Value.ToString();
            txtRefenNo.Text = row.Cells[1].Value.ToString();
            txtAssmentDate.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();
            comboBox3.Text = row.Cells[5].Value.ToString();
            comboBox4.Text = row.Cells[6].Value.ToString();
            comboBox5.Text = row.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewSelf.Rows[i];
            row.Cells[0].Value = txtRefenNo.Text;
            row.Cells[1].Value = txtName.Text;
            row.Cells[2].Value = txtLastname.Text;
            row.Cells[3].Value = txtAssmentDate.Text;
            row.Cells[4].Value = comboBox1.Text;
            row.Cells[5].Value = comboBox2.Text;
            row.Cells[6].Value = comboBox3.Text;
            row.Cells[7].Value = comboBox4.Text;
            row.Cells[8].Value = comboBox5.Text;
        }
        //private DataTable myDT;
        DataTable myDT = new DataTable();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(Server, DB, UName);
            dash.Show();
        }

        private void dataGridViewSelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridViewSelf.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            txtRefenNo.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtLastname.Text = row.Cells[3].Value.ToString();
            txtAssmentDate.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[5].Value.ToString();
            comboBox2.Text = row.Cells[6].Value.ToString();
            comboBox3.Text = row.Cells[7].Value.ToString();
            comboBox4.Text = row.Cells[8].Value.ToString();
            comboBox5.Text = row.Cells[9].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

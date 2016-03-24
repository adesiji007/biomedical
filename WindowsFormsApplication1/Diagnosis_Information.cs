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
    public partial class Diagnosis_Information : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        private DataTable myDT;


        public Diagnosis_Information(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //Pass = password;
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        DataTable dt = new DataTable();
        int i;

        private MySqlConnection myConn;
        private string sConnStr;
    
        private void Diagnosis_Information_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM diagnosis_informatin");
            
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // DisplayTable("Select diagnosis_informatin.DiagInfo_ID,user_info_Firstname, user_info.user_Lastname from user_info INNER JOIN diagnosis_informatin ON user_info.user_info_id=diagnosis_informatin.DiagInfo_ID where Firstname = '" + txtSearch.Text + "'");
            
            DisplayTable("Select * fROM  diagnosis_informatin where name = '" + txtSearch.Text + "'");
            this.Show();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            //txtID.Text = row.Cells[0].Value.ToString();
            txtReference_Number.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[0].Value.ToString();
            txtLastname.Text = row.Cells[1].Value.ToString();
            txtDate.Text = row.Cells[2].Value.ToString();
            txtLCD.Text = row.Cells[3].Value.ToString();
            txtNatur.Text = row.Cells[4].Value.ToString();
            txtPreApp.Text = row.Cells[5].Value.ToString();
            txtResApp.Text = row.Cells[6].Value.ToString();
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from diagnosis_informatin", myConn);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            DataRow dr = dTable.NewRow();
           // dr["ID"] = txtID.Text;
            dr["Reference_No"] = txtReference_Number;
            dr["Firstname"] = txtName.Text;
            dr["Lastname"] = txtLastname.Text;
            dr["Date"] = txtDate.Text;
            dr["Last_Clinic_date"] = txtLCD.Text;
            dr["NatureOfTraining"] = txtNatur.Text;
            dr["PreviousAppointment"] = txtPreApp.Text;
            dr["RescheduleOfAppointment"] = txtResApp.Text;
            
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
                string sQuery = "SELECT * FROM diagnosis_informatin";
               DisplayTable(sQuery);


                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                dTable.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DisplayTable("INSERT INTO user (Reference_No,Firstname,Lastname,Date,Last_Clinic_date, NatureOfTraining, PreviousAppointment, RescheduleOfAppointment) VALUES('" + txtReference_Number.Text + "','" + txtName.Text + "','" + txtLastname.Text + "','" + txtDate.Text + "','" + txtLCD.Text + "','" + txtNatur.Text + "','" + txtPreApp.Text + "', '" + txtResApp.Text + "')");
            this.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ////show the preious record if the current one is not the first
            //if (rowIndex > 0)
            //{
            //    rowIndex = rowIndex - 1 // decrease rowIndex by 1
            //        U
            //}
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
            //txtID.Text = row.Cells[0].Value.ToString();
            txtReference_Number.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[0].Value.ToString();
            txtLastname.Text = row.Cells[0].Value.ToString();
            txtDate.Text = row.Cells[1].Value.ToString();
            txtLCD.Text = row.Cells[2].Value.ToString();
            txtNatur.Text = row.Cells[3].Value.ToString();
            txtPreApp.Text = row.Cells[4].Value.ToString();
            txtResApp.Text = row.Cells[5].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
}
}

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

            DisplayTable("SELECT a.*, u.Fullname FROM bio_diagnosis_informatin a, bio_user u WHERE a.user_id = u.user_ID");
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
           // DisplayTable("Select bio_diagnosis_informatin.DiagInfo_ID,user_info_Firstname, user_info.user_Lastname from user_info INNER JOIN diagnosis_informatin ON user_info.user_info_id=diagnosis_informatin.DiagInfo_ID where Firstname = '" + txtSearch.Text + "'");
            
            DisplayTable("Select * fROM  bio_diagnosis_informatin where Fullname = '" + txtSearch.Text + "'");
            this.Show();
           
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                //txtID.Text = row.Cells[0].Value.ToString();
                txtDiagInfo_ID.Text = row.Cells[0].Value.ToString();
                txtuser_id.Text = row.Cells[1].Value.ToString();
                txtReference_Number.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                dateTimePicker2.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
                txtNatur.Text = row.Cells[6].Value.ToString();
                txtPreApp.Text = row.Cells[7].Value.ToString();
                txtResApp.Text = row.Cells[8].Value.ToString();
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
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_diagnosis_informatin", myConn);

                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                // dr["ID"] = txtID.Text;
                dr["Reference_No"] = txtReference_Number;
                dr["Fullname"] = comboBox1.Text;
                dr["Date"] = dateTimePicker2.Text;
                dr["Last_Clinic_date"] = dateTimePicker1.Text;
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
                    string sQuery = "SELECT * FROM bio_diagnosis_informatin";
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

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                myDT.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = myDT;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DisplayTable("INSERT INTO bio_user (Reference_No,Fullname,Date,Last_Clinic_date, NatureOfTraining, PreviousAppointment, RescheduleOfAppointment) VALUES('" + txtReference_Number.Text + "','" + comboBox1.Text + "','" + "','" + dateTimePicker2.Text + "','" + dateTimePicker1.Text + "','" + txtNatur.Text + "','" + txtPreApp.Text + "', '" + txtResApp.Text + "')");
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
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                //txtID.Text = row.Cells[0].Value.ToString();
                txtReference_Number.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                dateTimePicker2.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                txtNatur.Text = row.Cells[4].Value.ToString();
                txtPreApp.Text = row.Cells[5].Value.ToString();
                txtResApp.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                //row.Cells[0].Value = txtID.Text;
                row.Cells[0].Value = txtReference_Number.Text;
                row.Cells[1].Value = comboBox1.Text;
                row.Cells[2].Value = dateTimePicker2.Text;
                row.Cells[3].Value = dateTimePicker1.Text;
                row.Cells[4].Value = txtNatur.Text;
                row.Cells[5].Value = txtPreApp.Text;
                row.Cells[6].Value = txtResApp.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblReference_Number_Click(object sender, EventArgs e)
        {

        }

        private void txtReference_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    
}
}

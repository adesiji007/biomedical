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
    public partial class Dynamic_Movement : Form
    {
        private string Server;
        private string DB;
        private string UName;
        ////private string Pass;
        private DataTable myDT;
        int i;

        //private DataTable DT;
        public Dynamic_Movement(string server, string db, string uname)
        {
            InitializeComponent();
            Server = server;
            DB = db;
            UName = uname;
            //DT = dt;
            
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        private MySqlConnection myConn;
        private string sConnStr;

       
        private void Dynamic_Movement_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            sConnStr = "Server = " + Server + "; " + "database = " + DB + "; " + "uid = " + UName + ";";
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM dynamic_movement");

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
        //private DataTable myDT;
        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dah = new Dashboard(Server, DB, UName);
            dah.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from dynamic_movement", myConn);

            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

             DataRow dr = dTable.NewRow();
           
             dr["Name"] = txtName.Text;
             dr["Lastname"] = txtLastname.Text;
             dr["ReferenceNo"] = txtRefNo.Text;
             dr["AssessmentDate"] = txtAssm.Text;
             dr["DeepSquatHeelOnFloor"] = comboBoxDSHF.Text;
             dr["DeepSquatHipBelowKnees"] = comboBoxDSHBK.Text;


             dr["DeepSquatDowelOverHead"] = comboBoxDSDO.Text;
             dr["DeepSquatPain"] = comboBoxDSPA.Text;

             dr["LungeHipKneesAnkleFwd"] = cboBoxLHKAF.Text;
             dr["LungeKneeToFloor"] = comboBoxLKF.Text;

             dr["LungeMinUppBodyMov"] = comboBoxLMUBM.Text;
             dr["LungeMaintBalan90"] = comboBoxLMAP.Text;

             dr["ActiveSlTaiseFootFlexed"] = comboBoxASRFFD.Text;
             dr["ActiveSlTaiseAnkleBone"] = comboBoxASRAB.Text;

             dr["ActiveSlTaisePain"] = comboBoxASRP.Text;
             dr["StandingHipExtHigHams"] = comboBoxSHEHH.Text;

             dr["StandingHipExtPain"] = comboBoxSHEP.Text;
             dr["SeatedTotPelv_Level"] = comboBoxSRPL.Text;
             dr["SeatedTotPelv_DowelInChest"] = comboBoxSRPDCC.Text;
             dr["SeatedTotPelv_Pain"] = comboBoxSRADP.Text;









            ////myDT.Columns.Add("ID", typeof(int));
            //myDT.Columns.Add("Name", typeof(string));
            //myDT.Columns.Add("ReferenceNo", typeof(int));
            //myDT.Columns.Add("AssessmentDate", typeof(string));
            //myDT.Columns.Add("DeepSquatHeelOnFloor", typeof(int));
            //myDT.Columns.Add("DeepSquatHipBelowKnees", typeof(int));
            //myDT.Columns.Add("DeepSquatDowelOverHead", typeof(int));
            //myDT.Columns.Add("DeepSquatPain", typeof(int));
            //myDT.Columns.Add("LungeHipKneesAnkleFwd", typeof(int));
            //myDT.Columns.Add("LungeKneeToFloor", typeof(int));
            //myDT.Columns.Add("LungeMinUppBodyMov", typeof(int));
            //myDT.Columns.Add("LungeMaintBalan90", typeof(int));
            //myDT.Columns.Add("ActiveSlTaiseFootFlexed", typeof(int));
            //myDT.Columns.Add("ActiveSlTaiseAnkleBone", typeof(int));
            //myDT.Columns.Add(" ActiveSlTaisePain", typeof(int));
            //myDT.Columns.Add("StandingHipExtHigHams", typeof(int));
            //myDT.Columns.Add("StandingHipExtPain", typeof(int));
            //myDT.Columns.Add("SeatedTotPelv_Level", typeof(int));
            //myDT.Columns.Add("SeatedTotPelv_DowelInChest", typeof(int));
            //myDT.Columns.Add("SeatedTotPelv_Pain", typeof(int));
            
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
                string sQuery = "SELECT * FROM dynamic_movement";
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
            //    myDT.Rows.Add(txtName.Text, txtRefNo.Text, txtAssm.Text, txtID.Text, comboBoxDSHF.Text, comboBoxDSHBK.Text, comboBoxDSDO.Text, comboBoxDSPA.Text, cboBoxLHKAF.Text, comboBoxLKF.Text, comboBoxLMUBM.Text, comboBoxLMAP.Text, comboBoxASRFFD.Text, comboBoxASRAB.Text, comboBoxASRP.Text, comboBoxSHEHH.Text, comboBoxSHEP.Text, comboBoxSRPL.Text, comboBoxSRPDCC.Text, comboBoxSRADP.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
            txtName.Text = row.Cells[0].Value.ToString();
            txtLastname.Text = row.Cells[0].Value.ToString();
            txtRefNo.Text = row.Cells[1].Value.ToString();
            txtAssm.Text = row.Cells[2].Value.ToString();
            //txtID.Text = row.Cells[3].Value.ToString();
            comboBoxDSHF.Text = row.Cells[3].Value.ToString();
            comboBoxDSHBK.Text = row.Cells[3].Value.ToString();
            comboBoxDSDO.Text = row.Cells[3].Value.ToString();
            comboBoxDSPA.Text = row.Cells[3].Value.ToString();
            cboBoxLHKAF.Text = row.Cells[3].Value.ToString();
            comboBoxLKF.Text = row.Cells[3].Value.ToString();
            comboBoxLMUBM.Text = row.Cells[3].Value.ToString();
            comboBoxLMAP.Text = row.Cells[3].Value.ToString();
            comboBoxASRFFD.Text = row.Cells[3].Value.ToString();
            comboBoxASRAB.Text = row.Cells[3].Value.ToString();
            comboBoxASRP.Text = row.Cells[3].Value.ToString();
            comboBoxSHEHH.Text = row.Cells[3].Value.ToString();
            comboBoxSHEP.Text = row.Cells[3].Value.ToString();
            comboBoxSRPL.Text = row.Cells[3].Value.ToString();
            comboBoxSRPDCC.Text = row.Cells[3].Value.ToString();
            comboBoxSRADP.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[i];
            row.Cells[0].Value = txtName.Text;
            row.Cells[0].Value = txtLastname.Text;
            row.Cells[1].Value = txtRefNo.Text;
            row.Cells[2].Value = txtAssm.Text;
            //row.Cells[3].Value = txtID.Text;
            row.Cells[4].Value = comboBoxDSHF.Text;
            row.Cells[5].Value = comboBoxDSHBK.Text;
            row.Cells[6].Value = comboBoxDSDO.Text;
            row.Cells[7].Value = comboBoxDSPA.Text;
            row.Cells[8].Value = cboBoxLHKAF.Text;
            row.Cells[9].Value = comboBoxLKF.Text;
            row.Cells[10].Value = comboBoxLMUBM.Text;
            row.Cells[11].Value = comboBoxLMAP.Text;
            row.Cells[12].Value = comboBoxASRFFD.Text;
            row.Cells[13].Value = comboBoxASRAB.Text;
            row.Cells[14].Value = comboBoxASRP.Text;
            row.Cells[15].Value = comboBoxSHEHH.Text;
            row.Cells[16].Value = comboBoxSHEP.Text;
            row.Cells[17].Value = comboBoxSRPL.Text;
            row.Cells[18].Value = comboBoxSRPDCC.Text;
            row.Cells[19].Value = comboBoxSRADP.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayTable("Select * fROM dynamic_movement where Name = '" + txtSearch.Text + "'");
        }

        private void comboBoxDSHF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(sConnStr);
                MySqlDataAdapter myAdap = new MySqlDataAdapter("SELECT DeepSquatHeelOnFloor FROM dynamic_movement", sConnStr);
                DataTable dt = new DataTable();
                myAdap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDSHF.Text == "ID")
            {
                MySqlConnection myConn = new MySqlConnection(sConnStr);
                MySqlDataAdapter myAdap = new MySqlDataAdapter("SELECT ID FROM dynamic_movement where id like '" + txtSearch.Text + "%'", sConnStr);
                DataTable dt = new DataTable();
                myAdap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBoxDSHF.Text == "Name")
            {
                MySqlConnection myConn = new MySqlConnection(sConnStr);
                MySqlDataAdapter myAdap = new MySqlDataAdapter("SELECT Name FROM dynamic_movement where id like '" + txtSearch.Text + "%'", sConnStr);
                DataTable dt = new DataTable();
                myAdap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtName.Text = row.Cells[0].Value.ToString();
            txtLastname.Text = row.Cells[0].Value.ToString();
            txtRefNo.Text = row.Cells[1].Value.ToString();
            txtAssm.Text = row.Cells[2].Value.ToString();
            //txtID.Text = row.Cells[3].Value.ToString();
            comboBoxDSHF.Text = row.Cells[4].Value.ToString();
            comboBoxDSHBK.Text = row.Cells[5].Value.ToString();
            comboBoxDSDO.Text = row.Cells[6].Value.ToString();
            comboBoxDSPA.Text = row.Cells[7].Value.ToString();
            cboBoxLHKAF.Text = row.Cells[8].Value.ToString();
            comboBoxLKF.Text = row.Cells[9].Value.ToString();
            comboBoxLMUBM.Text = row.Cells[10].Value.ToString();
            comboBoxLMAP.Text = row.Cells[11].Value.ToString();
            comboBoxASRFFD.Text = row.Cells[12].Value.ToString();
            comboBoxASRAB.Text = row.Cells[13].Value.ToString();
            comboBoxASRP.Text = row.Cells[14].Value.ToString();
            comboBoxSHEHH.Text = row.Cells[15].Value.ToString();
            comboBoxSHEP.Text = row.Cells[16].Value.ToString();
            comboBoxSRPL.Text = row.Cells[17].Value.ToString();
            comboBoxSRPDCC.Text = row.Cells[18].Value.ToString();
            comboBoxSRADP.Text = row.Cells[19].Value.ToString();
        }

        private void comboBoxLKF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        
    }
}

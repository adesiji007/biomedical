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

            // select fullname from the database
            DisplayTable("SELECT a.*, u.Fullname FROM bio_dynamic_movement a, bio_user u WHERE a.user_id = u.user_ID");
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
        //private DataTable myDT;
        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dah = new Dashboard(Server, DB, UName);
            dah.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_dynamic_movement", myConn);

                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();

                dr["DynaMove_ID"] = txtDynaMoveID.Text;
                dr["user_id"] = txtuserid.Text;
                dr["Fullname"] = comboBox1.Text;
                dr["ReferenceNo"] = txtRefNo.Text;
                dr["AssessmentDate"] = dateTimePicker1.Text;
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
                    string sQuery = "SELECT * FROM bio_dynamic_movement";
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
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                
                txtDynaMoveID.Text = row.Cells[0].Value.ToString();
                txtuserid.Text = row.Cells[1].Value.ToString();
                txtRefNo.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                comboBoxDSHF.Text = row.Cells[5].Value.ToString();
                comboBoxDSHBK.Text = row.Cells[6].Value.ToString();
                comboBoxDSDO.Text = row.Cells[7].Value.ToString();
                comboBoxDSPA.Text = row.Cells[8].Value.ToString();
                cboBoxLHKAF.Text = row.Cells[9].Value.ToString();
                comboBoxLKF.Text = row.Cells[10].Value.ToString();
                comboBoxLMUBM.Text = row.Cells[11].Value.ToString();
                comboBoxLMAP.Text = row.Cells[12].Value.ToString();
                comboBoxASRFFD.Text = row.Cells[13].Value.ToString();
                comboBoxASRAB.Text = row.Cells[14].Value.ToString();
                comboBoxASRP.Text = row.Cells[15].Value.ToString();
                comboBoxSHEHH.Text = row.Cells[16].Value.ToString();
                comboBoxSHEP.Text = row.Cells[17].Value.ToString();
                comboBoxSRPL.Text = row.Cells[18].Value.ToString();
                comboBoxSRPDCC.Text = row.Cells[19].Value.ToString();
                comboBoxSRADP.Text = row.Cells[20].Value.ToString();
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
                
                row.Cells[0].Value = txtDynaMoveID.Text;
                row.Cells[1].Value = txtuserid.Text;
                row.Cells[2].Value = txtRefNo.Text;
                row.Cells[3].Value = comboBox1.Text;
                row.Cells[4].Value = dateTimePicker1.Text;
                row.Cells[5].Value = comboBoxDSHF.Text;
                row.Cells[6].Value = comboBoxDSHBK.Text;
                row.Cells[7].Value = comboBoxDSDO.Text;
                row.Cells[8].Value = comboBoxDSPA.Text;
                row.Cells[9].Value = cboBoxLHKAF.Text;
                row.Cells[10].Value = comboBoxLKF.Text;
                row.Cells[11].Value = comboBoxLMUBM.Text;
                row.Cells[12].Value = comboBoxLMAP.Text;
                row.Cells[13].Value = comboBoxASRFFD.Text;
                row.Cells[14].Value = comboBoxASRAB.Text;
                row.Cells[15].Value = comboBoxASRP.Text;
                row.Cells[16].Value = comboBoxSHEHH.Text;
                row.Cells[17].Value = comboBoxSHEP.Text;
                row.Cells[18].Value = comboBoxSRPL.Text;
                row.Cells[19].Value = comboBoxSRPDCC.Text;
                row.Cells[20].Value = comboBoxSRADP.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DisplayTable("Select * fROM bio_dynamic_movement where Fullname = '" + txtSearch.Text + "'");
            this.Show();
        }

        private void comboBoxDSHF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(sConnStr);
                MySqlDataAdapter myAdap = new MySqlDataAdapter("SELECT * FROM bio_dynamic_movement", sConnStr);
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
            DisplayTable("Select * fROM  bio_dynamic_movement where Fullname = '" + txtSearch.Text + "'");
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];

                
                txtDynaMoveID.Text = row.Cells[0].Value.ToString();
                txtuserid.Text = row.Cells[1].Value.ToString();
                txtRefNo.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                comboBoxDSHF.Text = row.Cells[5].Value.ToString();
                comboBoxDSHBK.Text = row.Cells[6].Value.ToString();
                comboBoxDSDO.Text = row.Cells[7].Value.ToString();
                comboBoxDSPA.Text = row.Cells[8].Value.ToString();
                cboBoxLHKAF.Text = row.Cells[9].Value.ToString();
                comboBoxLKF.Text = row.Cells[10].Value.ToString();
                comboBoxLMUBM.Text = row.Cells[11].Value.ToString();
                comboBoxLMAP.Text = row.Cells[12].Value.ToString();
                comboBoxASRFFD.Text = row.Cells[13].Value.ToString();
                comboBoxASRAB.Text = row.Cells[14].Value.ToString();
                comboBoxASRP.Text = row.Cells[15].Value.ToString();
                comboBoxSHEHH.Text = row.Cells[16].Value.ToString();
                comboBoxSHEP.Text = row.Cells[17].Value.ToString();
                comboBoxSRPL.Text = row.Cells[18].Value.ToString();
                comboBoxSRPDCC.Text = row.Cells[19].Value.ToString();
                comboBoxSRADP.Text = row.Cells[20].Value.ToString();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxLKF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

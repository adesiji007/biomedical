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
    public partial class Dashboard : Form
    {
        private string Server;
        private string DB;
        private string UName;
        //private string Pass;
        public DataTable myDT;
        int i;
        private MySqlDataAdapter myAdap;
        
        public Dashboard(string server, string db, string uname)
        {
            InitializeComponent();

            Server = server;
            DB = db;
            UName = uname;
          //Pass = password;


            //Server = fas-dbms.sunderland.ac.uk;
            //DB = bg47de;
            //UName = uname;
            ////Pass = password;

            
        }
        DataTable dTable2 = new DataTable();
        DataTable dTable = new DataTable();

        public Dashboard(DataTable myDT)
        {
            // TODO: Complete member initialization
            this.myDT = myDT;
        }

       
        private MySqlConnection myConn;
        private string sConnStr;
     //--private DataTable dTable;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            //string sConnStr = "server = fas-dbms.sunderland.ac.uk;" + "database = bg47de;" + "uid = bg47de;" + "pwd = nifemi48DAMMY;";



            sConnStr = "Server = " + Server + "; " +
                        "database = " + DB + "; " +
                        "uid = " + UName + ";";
             
            myConn = new MySqlConnection(sConnStr);

            DisplayTable("Select * fROM bio_user");
           
        }
        private void DisplayTable(string sQuery)
        {
             try
            {
                //myConn.Open();
                //MessageBox.Show("connected");
                 this.Hide();
                DataTable dTable2 = new DataTable();
                
                myAdap = new MySqlDataAdapter(sQuery, sConnStr);
                myAdap.Fill(dTable2);
                myDT = dTable2;

                dataGridView.DataSource = dTable2;
                 //myAdap.Update()
               // listBox1.DataSource = dTable2;
                myAdap.Dispose();
                dTable2.Dispose();
            }
            catch
            {
                MessageBox.Show("not connected");
            }
        }

        
//select user table into new table/adapter 
            private void Add_Click(object sender, EventArgs e)
            {
                      
           MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_user", myConn);
                                 
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);

            // create a new row ana add data
            // leave id field empty as this is auto-increament
               DataRow dr = dTable.NewRow();
               //dr["ID"] = txtID.Text;
               dr["ClientType"] = cboType.Text;
               dr["Title"] = txtTitle.Text;
               dr["Fullname"] = txtFullname.Text;
               dr["Address"] = txtAddress.Text;
               dr["DOB"] = dateTimePicker1.Text;
               dr["Phone_Number"] = txtPhone_Number.Text;
               dr["Email"] = txtEmail.Text;
               dr["Gender"] = comboBox1.Text;
               dr["Occupation"] = txtOccupation.Text;
               dr["Reference_No"] = txtReference_Number.Text;

               dTable.Rows.Add(dr);

               // create a command builder and update adapter to save data
               MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);
            
               //update the data with mnodification table
            
                int iRowsAffeected = dAdapter.Update(dTable);
                // reload data into data grid
                dAdapter.Dispose();

            if(iRowsAffeected > 0)
            {
                // update the datagrid                // display if new row is added
                string sQuery = "SELECT * FROM bio_user";
                DisplayTable(sQuery);
                

                MessageBox.Show(iRowsAffeected + "Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Show();

        }

        public void UpdateTextBoxes()
        {
            // Display the contents of the row specified by the rowIndex variable
            cboType.Text = dTable.Rows[0]["ClientType"].ToString();
            txtTitle.Text = dTable.Rows[1]["Title"].ToString();
            txtFullname.Text = dTable.Rows[2]["Fullname"].ToString();
            txtAddress.Text = dTable.Rows[3]["Address"].ToString();
            dateTimePicker1.Text = dTable.Rows[4]["DOB"].ToString();
            txtPhone_Number.Text = dTable.Rows[5]["Phone_Number"].ToString();
            txtEmail.Text = dTable.Rows[6]["Email"].ToString();
            comboBox1.Text = dTable.Rows[7]["Gender"].ToString();
            txtOccupation.Text = dTable.Rows[8]["Occupation"].ToString();
            txtReference_Number.Text = dTable.Rows[9]["Reference_No"].ToString();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            DisplayTable("Select * fROM bio_user where Fullname = '" + txtSearch.Text + "'");
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            History_Week myform = new History_Week(Server, DB, UName);
            myform.Show();
        }

        private void butImpatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients_Details cl = new Clients_Details(Server, DB, UName);
            cl.Show();
        }

        private void butTraining_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord ar = new ActivityRecord(Server, DB, UName);
            ar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideoClips vc = new VideoClips(Server, DB, UName);
            vc.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Training_You_Tube_Video tyv = new Training_You_Tube_Video(Server, DB, UName);
            tyv.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DisplayTable("INSERT INTO bio_user (Title,Fullname, Address, DOB, Phone_Number, Gender, Occupation, Reference_Number) VALUES('" + txtTitle.Text + "','" + txtFullname.Text + "','" + txtAddress.Text + "','" + dateTimePicker1.Text + "','" + txtPhone_Number.Text + "', '" + comboBox1.Text + "', '" + txtOccupation.Text + "','" + txtReference_Number.Text + "')");
            this.Show();
        }

        //private void CloseConnection()
        //{
            
        //        throw new NotImplementedException();
            
            
        //}

        private void butCaseNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History tw = new Training_History(Server, DB, UName);
            tw.Show();
        }

        private void butTrainingHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History th = new Training_History(Server, DB, UName);
            th.Show();
        }

        private void butCaseLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Week tw = new History_Week(Server, DB, UName);
            tw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT Reference_No,Fullname from bio_user", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                dr["Fullname"] = txtFullname.Text;


                this.Hide();
                Diagnosis_Information di = new Diagnosis_Information(Server, DB, UName);
                di.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butCentral_Index_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dynamic_Movement dm = new Dynamic_Movement(Server, DB, UName);
            dm.Show();
        }

        private void butHardCopy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messanger mess = new Messanger(Server, DB, UName);
            mess.Show();
        }

        private void butLetters_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messanger mess = new Messanger(Server, DB, UName);
            mess.Show();
        }

        private void butReffered_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form reff = new Reffered_Form(Server, DB, UName);
            reff.Show();
        }

        private void butCareDocument_Click(object sender, EventArgs e)
        {
            this.Hide();
            Self_Mobility_Screen sms = new Self_Mobility_Screen(Server, DB, UName);
            sms.Show();
        }

        private void butInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Injury_History reff = new Injury_History(Server, DB, UName);
            reff.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView.Rows[i];
                //row.Cells[0].Value = txtID.Text;
                row.Cells[0].Value = cboType.Text;
                row.Cells[1].Value = txtTitle.Text;
                row.Cells[2].Value = txtFullname.Text;
                row.Cells[3].Value = txtAddress.Text;
                row.Cells[4].Value = dateTimePicker1.Text;
                row.Cells[5].Value = txtPhone_Number.Text;
                row.Cells[6].Value = txtEmail.Text;
                row.Cells[7].Value = comboBox1.Text;
                row.Cells[8].Value = txtOccupation.Text;
                row.Cells[9].Value = txtReference_Number.Text;

                
                DataTable temp = dataGridView.DataSource as DataTable;
                //DataRow[] r = temp.
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {


                i = e.RowIndex;
                DataGridViewRow row = dataGridView.Rows[i];
                //txtID.Text = row.Cells[0].Value.ToString();
                cboType.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtFullname.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                txtPhone_Number.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                comboBox1.Text = row.Cells[7].Value.ToString();
                txtOccupation.Text = row.Cells[8].Value.ToString();
                txtReference_Number.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                myDT.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
                dataGridView.DataSource = myDT;
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            
        }

        private void butCaseLoadManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static_Postural_Assessment spas = new Static_Postural_Assessment(Server, DB, UName);
            spas.Show();
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser nu = new NewUser(Server, DB, UName);
            nu.Show();
        }

        private void generalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord nu = new ActivityRecord(Server, DB, UName);
            nu.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Information dab = new Login_Information(Server, DB, UName);
            dab.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideoClips dabe = new VideoClips(Server, DB, UName);
            dabe.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord nu = new ActivityRecord(Server, DB, UName);
            nu.Show();
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord dab = new ActivityRecord(Server, DB, UName);
            dab.Show();
        }

        private void trainingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History th = new Training_History(Server, DB, UName);
            th.Show();
        }

        private void clientRefferedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void refferedFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void selfMobilityScreenSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Static_Postural_Assessment ih = new Static_Postural_Assessment(Server, DB, UName);
            ih.Show();
        }

        private void diagnosisInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static_Postural_Assessment ih = new Static_Postural_Assessment(Server, DB, UName);
            ih.Show();
        }

        private void refferedFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void injuryHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Injury_History dabi = new Injury_History(Server, DB, UName);
            dabi.Show();
        }

        private void staticPostoralAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Self_Mobility_Screen sdab = new Self_Mobility_Screen(Server, DB, UName);
            sdab.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void trainingWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideoClips dab = new VideoClips(Server, DB, UName);
            dab.Show();
        }

        private void hardCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void letterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form(Server, DB, UName);
            dab.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help hp = new Help(Server, DB, UName);
            hp.Show();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                i = e.RowIndex;
                DataGridViewRow row = dataGridView.Rows[i];
                //txtID.Text = row.Cells[0].Value.ToString();
                cboType.Text = row.Cells[1].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtFullname.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                txtPhone_Number.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                comboBox1.Text = row.Cells[7].Value.ToString();
                txtOccupation.Text = row.Cells[8].Value.ToString();
                txtReference_Number.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
              //DisplayTable("INSERT INTO bio_activity_record (TrainingCode,Fullname,DatOfActivity, TypeOfActivity, PreviousActivity, DateOfNextActivity) VALUES('" + txtTraining.Text + "','" + comboBox1.Text + "','" + txtDoActivity.Text + "','" + txtTypActivity.Text + "','" + txtPrv.Text + "','" + txtNextAct.Text + "')");
            //this.Show();
            clearFields();
        }

        private void clearFields()
        {
            txtTitle.Clear();
            txtFullname.Clear();
            txtAddress.Clear();
            dateTimePicker1.Enabled = true;
            txtPhone_Number.Clear();
            txtEmail.Clear();
            //comboBox1.Clear();
            btnUpdate.Enabled = false;
            cboType.Enabled = true;
            txtOccupation.Enabled = true;
            txtOccupation.Clear();
            txtReference_Number.Enabled = true;
            txtReference_Number.Clear();
        
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }



        public string bg47de { get; set; }
    }
}

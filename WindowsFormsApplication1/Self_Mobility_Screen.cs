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

            //DisplayTable("Select * fROM bio_self_mobility_screen");
            DisplayTable("SELECT a.*, u.Fullname FROM bio_self_mobility_screen a, bio_user u WHERE a.user_id = u.user_ID");
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
                    comboBox6.Items.Add(dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * from bio_self_mobility_screen", myConn);


                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                DataRow dr = dTable.NewRow();
                //dr["ID"] = txtID.Text;
                dr["Name"] = comboBox6.Text;
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
                    string sQuery = "SELECT * FROM bio_self_mobility_screen";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myDT.Rows.RemoveAt(dataGridViewSelf.CurrentCell.RowIndex);
                dataGridViewSelf.DataSource = myDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewSelf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridViewSelf.Rows[i];
                comboBox6.Text = row.Cells[0].Value.ToString();
                txtRefenNo.Text = row.Cells[1].Value.ToString();
                txtAssmentDate.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                comboBox2.Text = row.Cells[4].Value.ToString();
                comboBox3.Text = row.Cells[5].Value.ToString();
                comboBox4.Text = row.Cells[6].Value.ToString();
                comboBox5.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewSelf.Rows[i];
            row.Cells[0].Value = txtRefenNo.Text;
            row.Cells[1].Value = comboBox6.Text;
            row.Cells[2].Value = txtAssmentDate.Text;
            row.Cells[3].Value = comboBox1.Text;
            row.Cells[4].Value = comboBox2.Text;
            row.Cells[5].Value = comboBox3.Text;
            row.Cells[6].Value = comboBox4.Text;
            row.Cells[7].Value = comboBox5.Text;
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
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridViewSelf.Rows[i];
                //txtID.Text = row.Cells[0].Value.ToString();
                txtRefenNo.Text = row.Cells[0].Value.ToString();
                comboBox6.Text = row.Cells[1].Value.ToString();
                txtAssmentDate.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                comboBox2.Text = row.Cells[4].Value.ToString();
                comboBox3.Text = row.Cells[5].Value.ToString();
                comboBox4.Text = row.Cells[6].Value.ToString();
                comboBox5.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

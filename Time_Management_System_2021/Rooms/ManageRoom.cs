using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021.Rooms
{
    public partial class ManageRoom : Form
    {
        private SqlConnection conn;

        public ManageRoom()
        {
            InitializeComponent();
        }

        private void ManageRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeManagementSystem_DBDataSet25.ConsecutiveSessionRoom' table. You can move, or remove it, as needed.
            this.consecutiveSessionRoomTableAdapter1.Fill(this.timeManagementSystem_DBDataSet25.ConsecutiveSessionRoom);

            this.consecutive_SessionsTableAdapter4.Fill(this.timeManagementSystem_DBDataSet24.consecutive_Sessions);
            DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
            this.parellelRoomTableAdapter1.Fill(this.timeManagementSystem_DBDataSet20.ParellelRoom);
            this.parellelRoomTableAdapter.Fill(this.timeManagementSystem_DBDataSet16.ParellelRoom);
            this.nonParellelRoomTableAdapter.Fill(this.timeManagementSystem_DBDataSet15.NonParellelRoom);
            this.not_overlapping_SessionsTableAdapter2.Fill(this.timeManagementSystem_DBDataSet13.not_overlapping_Sessions);
            DataGridViewCheckBoxColumn chckbox1 = new DataGridViewCheckBoxColumn();
            this.parellel_SessionsTableAdapter2.Fill(this.timeManagementSystem_DBDataSet11.parellel_Sessions);
            this.parellel_SessionsTableAdapter.Fill(this.timeManagementSystem_DBDataSet6.parellel_Sessions);
            DataGridViewCheckBoxColumn chckbox2 = new DataGridViewCheckBoxColumn();
            
            chckbox.HeaderText = "";
            chckbox.Width = 30;
            chckbox.Name = "CheckboxClumn";
            dataGridView1.Columns.Insert(0, chckbox);
            chckbox1.HeaderText = "";
            chckbox1.Width = 30;
            chckbox1.Name = "CheckboxClumn1";
            dataGridView3.Columns.Insert(0, chckbox1);
            chckbox2.HeaderText = "";
            chckbox2.Width = 30;
            chckbox2.Name = "CheckboxClumn2";
            dataGridView2.Columns.Insert(0, chckbox2);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void SessionAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void C_SessionRoomBtn_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Time_Management_System_2021.Properties.Settings.TimeManagementSystem_DBConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String Room_Name = AddRoomSession.Text;
            String Building_Name = AddLocationSession.Text;
            String Capacity = AddCapacitySession.Text;

            /*foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn"].Value);
                if (chackboxselected)
                {
                    string Sqlquery = "INSERT INTO [dbo].[ConsecutiveSessionRoom] VALUES (@C_sesstionID, @SessionID, @session_name, @LecturerName, @SubjectName, @SubjectCode, @Tag, @GroupNumber, @StudentCount, @Duration, @StartTime, @EndTime, @Day, @Room_Name, @Building_Name, @Capacity)";
                    SqlCommand sqlcomm = new SqlCommand(Sqlquery, sqlconn);


                    sqlcomm.Parameters.AddWithValue("@C_sesstionID", dr.Cells[0].Value);
                    sqlcomm.Parameters.AddWithValue("@SessionID", dr.Cells[1].Value);
                    sqlcomm.Parameters.AddWithValue("@session_name", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@LecturerName", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectName", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectCode", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@GroupNumber", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@StudentCount", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@Duration", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@StartTime", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@EndTime", dr.Cells[11].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[12].Value);
                    sqlcomm.Parameters.AddWithValue("@Room_Name", Room_Name);
                    sqlcomm.Parameters.AddWithValue("@Building_Name", Building_Name);
                    sqlcomm.Parameters.AddWithValue("@Capacity", Capacity);

                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();


                }
            }*/
            MessageBox.Show("Add Room for Consecutive Session successfully", "Successfully");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox2.Text + "%'";
            dataGridView2.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void AddParellelRoom_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Time_Management_System_2021.Properties.Settings.TimeManagementSystem_DBConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String Room_Name1 = addroomparellel.Text;
            String Building_Name1 = addlocationParellel.Text;
            String Capacity1 = addcapacityparellel.Text;

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn2"].Value);
                if (chackboxselected)
                {
                    string Sqlquery = "INSERT INTO [dbo].[parellelRoom] VALUES (@P_sesstionID, @SessionID, @session_name, @LecturerName, @SubjectName, @SubjectCode, @Tag, @GroupNumber, @StudentCount, @Duration, @StartTime, @EndTime, @Day, @Room_Name, @Building_Name, @Capacity)";
                    SqlCommand sqlcomm = new SqlCommand(Sqlquery, sqlconn);

                    


                    sqlcomm.Parameters.AddWithValue("@P_sesstionID", dr.Cells[0].Value);
                    sqlcomm.Parameters.AddWithValue("@SessionID", dr.Cells[1].Value);
                    sqlcomm.Parameters.AddWithValue("@session_name", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@LecturerName", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectName", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectCode", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@GroupNumber", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@StudentCount", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@Duration", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@StartTime", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@EndTime", dr.Cells[11].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[12].Value);
                    sqlcomm.Parameters.AddWithValue("@Room_Name", Room_Name1);
                    sqlcomm.Parameters.AddWithValue("@Building_Name", Building_Name1);
                    sqlcomm.Parameters.AddWithValue("@Capacity", Capacity1);

                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();


                }
            }
            MessageBox.Show("Add Room for Parallel Session successfully", "Successfully");

        }

        private void addNonOverlappingbtn_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Time_Management_System_2021.Properties.Settings.TimeManagementSystem_DBConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String Room_Name = addNotOverlapRoom.Text;
            String Building_Name = AddNotOverlapLocation.Text;
            String Capacity = AddNotOverlapCapacity.Text;

            foreach (DataGridViewRow dr in dataGridView3.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn1"].Value);
                if (chackboxselected)
                {
                    string Sqlquery = "INSERT INTO [dbo].[NonParellelRoom] VALUES (@NOT_overlapping_sesstionID, @SessionID, @session_name, @LecturerName, @SubjectName, @SubjectCode, @Tag, @GroupNumber, @StudentCount, @Duration, @StartTime, @EndTime, @Day, @Room_Name, @Building_Name, @Capacity)";
                    SqlCommand sqlcomm = new SqlCommand(Sqlquery, sqlconn);

                    sqlcomm.Parameters.AddWithValue("@NOT_overlapping_sesstionID", dr.Cells[1].Value);
                    sqlcomm.Parameters.AddWithValue("@SessionID", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@session_name", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@LecturerName", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectName", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectCode", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@GroupNumber", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@StudentCount", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@Duration", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@StartTime", dr.Cells[11].Value);
                    sqlcomm.Parameters.AddWithValue("@EndTime", dr.Cells[12].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[13].Value);
                    sqlcomm.Parameters.AddWithValue("@Room_Name", Room_Name);
                    sqlcomm.Parameters.AddWithValue("@Building_Name", Building_Name);
                    sqlcomm.Parameters.AddWithValue("@Capacity", Capacity);
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();


                }
            }
            MessageBox.Show("Add Room for Not Parallel Session successfully", "Successfully");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SesionClearBtn_Click(object sender, EventArgs e)
        {
            AddRoomSession.Text = string.Empty;
            AddLocationSession.Text= string.Empty;
            AddCapacitySession.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRoomSession.Text = string.Empty;
            AddLocationSession.Text = string.Empty;
            AddCapacitySession.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddRoomSession.Text = string.Empty;
            AddLocationSession.Text = string.Empty;
            AddCapacitySession.Text = string.Empty;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox5.Text + "%'";
            dataGridView3.DataSource = bs;
        }
    }
}
    
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021.Rooms
{
    public partial class ManageRoom : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthElipse,
            int nHeightElipse
        );


        private SqlConnection conn;

        public ManageRoom()
        {
            InitializeComponent();
        }

        NonReservableTimeRoom nrtr = new NonReservableTimeRoom();
        
        private void ManageRoom_Load(object sender, EventArgs e)
        {

            C_sessionAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, C_sessionAdd.Width, C_sessionAdd.Height, 20, 20));
            SesionClearBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SesionClearBtn.Width, SesionClearBtn.Height, 20, 20));
            AddParellelRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddParellelRoom.Width, AddParellelRoom.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            addNonOverlappingbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNonOverlappingbtn.Width, addNonOverlappingbtn.Height, 20, 20));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));
            btnAllocateNRTR.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAllocateNRTR.Width, btnAllocateNRTR.Height, 20, 20));
            btnUpdateNRTR.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdateNRTR.Width, btnUpdateNRTR.Height, 20, 20));
            btnDeleteNRTR.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDeleteNRTR.Width, btnDeleteNRTR.Height, 20, 20));
            btnResetNRTR.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnResetNRTR.Width, btnResetNRTR.Height, 20, 20));

            //data grid view for the sessions

            // TODO: This line of code loads data into the 'timeManagementSystem_DBDataSet28.consecutive_Sessions' table. You can move, or remove it, as needed.
            this.consecutive_SessionsTableAdapter7.Fill(this.timeManagementSystem_DBDataSet28.consecutive_Sessions);
            DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
          
           
            // TODO: This line of code loads data into the 'timeManagementSystem_DBDataSet25.ConsecutiveSessionRoom' table. You can move, or remove it, as needed.
            this.consecutiveSessionRoomTableAdapter1.Fill(this.timeManagementSystem_DBDataSet25.ConsecutiveSessionRoom);

            //this.consecutive_SessionsTableAdapter4.Fill(this.timeManagementSystem_DBDataSet24.consecutive_Sessions);
            //DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
            this.parellelRoomTableAdapter1.Fill(this.timeManagementSystem_DBDataSet20.ParellelRoom);
            this.parellelRoomTableAdapter.Fill(this.timeManagementSystem_DBDataSet16.ParellelRoom);
            this.nonParellelRoomTableAdapter.Fill(this.timeManagementSystem_DBDataSet15.NonParellelRoom);
            this.not_overlapping_SessionsTableAdapter2.Fill(this.timeManagementSystem_DBDataSet13.not_overlapping_Sessions);
            DataGridViewCheckBoxColumn chckbox1 = new DataGridViewCheckBoxColumn();
            this.parellel_SessionsTableAdapter2.Fill(this.timeManagementSystem_DBDataSet11.parellel_Sessions);
            this.parellel_SessionsTableAdapter.Fill(this.timeManagementSystem_DBDataSet6.parellel_Sessions);
            DataGridViewCheckBoxColumn chckbox2 = new DataGridViewCheckBoxColumn();
            
            //checkboxclumn and grid view names

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



            //Loading non-reservable time tab room data
            DataSet ds = nrtr.displayRooms();
            cmbRoomNRRT.DataSource = ds.Tables[0];
            cmbRoomNRRT.DisplayMember = "Room_name";
            cmbRoomNRRT.ValueMember = "LocID";


            //Load non-reservable time data on data gridview
            DataTable dtNRTR = nrtr.displayRoomNonReservableTimeData();
            dgvNRTR.DataSource = dtNRTR;

            /*
            //Loading non-reservable time tab starting time data
            DataSet ds1 = nrtr.displayStartingTime();
            cmbStartTime.DataSource = ds1.Tables[0];
            cmbStartTime.DisplayMember = "StartingTime";


            //Loading non-reservable time tab ending time data
            DataSet ds2 = nrtr.displayEndingTime();
            cmbEndTime.DataSource = ds2.Tables[0];
            cmbEndTime.DisplayMember = "EndingTime";
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //search by session name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        //button for return home page
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
        //search by session name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox2.Text + "%'";
            dataGridView2.DataSource = bs;
        }
        //button for return home page
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        //data insert to parellel room
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
        //data insert to NonParellelRoom room
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
        //button for return home page
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

        //consecutive_Session
        private void clearFields()
        {
            AddRoomSession.Text = "";
            AddLocationSession.Text = "";
            AddCapacitySession.Text = "";

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn"].Value);
                if (chackboxselected)
                {

                    dr.Cells["CheckboxClumn"].Value = false;


                }
            }

        }
        //clear field
        private void SesionClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        //parellelSession clear
        private void clearFields2()
        {
            addroomparellel.Text = "";
            addlocationParellel.Text = "";
            addcapacityparellel.Text = "";

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn2"].Value);
                if (chackboxselected)
                {

                    dr.Cells["CheckboxClumn2"].Value = false;


                }
            }

        }
        //not overlapingSession clear 

        private void clearFields3()
        {
            addNotOverlapRoom.Text = "";
            AddNotOverlapLocation.Text = "";
            AddNotOverlapCapacity.Text = "";

            foreach (DataGridViewRow dr in dataGridView3.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn1"].Value);
                if (chackboxselected)
                {

                    dr.Cells["CheckboxClumn1"].Value = false;


                }
            }

        }

        //parellel session clear button
        private void button3_Click(object sender, EventArgs e)
        {
            clearFields2();
        }
        //not overlapingSession session clear button
        private void button7_Click(object sender, EventArgs e)
        {
            clearFields3();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = "Convert(session_name, 'System.String') Like '%" + textBox5.Text + "%'";
            dataGridView3.DataSource = bs;
        }


        //RoomNonReservableTime home icon
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
        }



        //Insert data to RoomNonReservableTime
        private void btnAllocateNRTR_Click(object sender, EventArgs e)
        {
            if ((cmbRoomNRRT.Text != string.Empty) && (txtStartTime.Text != string.Empty) && (txtEndTime.Text != string.Empty) && (cmbDay.Text != string.Empty))
            {
                //Getting values from the input fields
                nrtr.Room_name = cmbRoomNRRT.Text;
                nrtr.StartTime = txtStartTime.Text;
                nrtr.EndTime = txtEndTime.Text;
                nrtr.Day = cmbDay.Text;

                //Inserting data to db
                int RoomNonReservableTimeID = nrtr.insertRoomNonReservableTime(nrtr);

                if (RoomNonReservableTimeID > 0)
                {
                    MessageBox.Show("New Non Reservable Time Room successfully added!");

                    //calling clear TimeSlot fields method
                    clearRoomNonReservableTimeFields();

                }
                else
                {
                    MessageBox.Show("Failed to insert Non Reservable Time Room to database...");
                }

                //Load time slots data on data gridview
                DataTable dtNRTR = nrtr.displayRoomNonReservableTimeData();
                dgvNRTR.DataSource = dtNRTR;


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Method to clear RoomNonReservableTime fields
        public void clearRoomNonReservableTimeFields()
        {
            cmbRoomNRRT.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
            cmbDay.Text = "";
        }


        //Reset RoomNonReservableTime data 
        private void btnResetNRTR_Click(object sender, EventArgs e)
        {
            //calling clear RoomNonReservableTime fields method
            clearRoomNonReservableTimeFields();
        }


        string NonReservableID;

        //Retrieving data from the selected row and filled with textboxes
        private void dgvNRTR_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data gridview and load it into the textboxes
            int rowIndex = e.RowIndex;
            cmbRoomNRRT.Text = dgvNRTR.Rows[rowIndex].Cells[1].Value.ToString();
            txtStartTime.Text = dgvNRTR.Rows[rowIndex].Cells[2].Value.ToString();
            txtEndTime.Text = dgvNRTR.Rows[rowIndex].Cells[3].Value.ToString();
            cmbDay.Text = dgvNRTR.Rows[rowIndex].Cells[4].Value.ToString();

            NonReservableID = dgvNRTR.Rows[rowIndex].Cells[0].Value.ToString();
        }



        //Update RoomNonReservableTime data
        private void btnUpdateNRTR_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            nrtr.NonReservableID = int.Parse(NonReservableID);
            nrtr.Room_name = cmbRoomNRRT.Text;
            nrtr.StartTime = txtStartTime.Text;
            nrtr.EndTime = txtEndTime.Text;
            nrtr.Day = cmbDay.Text;

            //Update data in db
            bool success = nrtr.updateRoomNonReservableTime(nrtr);

            if (success == true)
            {
                MessageBox.Show("Non reservable room time successfully updated!");

                //Load non-reservable time data on data gridview
                DataTable dtNRTR = nrtr.displayRoomNonReservableTimeData();
                dgvNRTR.DataSource = dtNRTR;

                //calling clear RoomNonReservableTime fields method
                clearRoomNonReservableTimeFields();


            }
            else
            {
                MessageBox.Show("Failed to update non reservable room time...");
            }
        }


        //Delete RoomNonReservableTime data
        private void btnDeleteNRTR_Click(object sender, EventArgs e)
        {
            nrtr.NonReservableID = int.Parse(NonReservableID);
            bool success = nrtr.deleteRoomNonReservableTime(nrtr);

            if (success == true)
            {
                MessageBox.Show("Non reservable room time successfully deleted!");

                //Load non-reservable time data on data gridview
                DataTable dtNRTR = nrtr.displayRoomNonReservableTimeData();
                dgvNRTR.DataSource = dtNRTR;

                //calling clear RoomNonReservableTime fields method
                clearRoomNonReservableTimeFields();
            }
            else
            {
                MessageBox.Show("Failed to delete non reservable room time...");
            }
        }
        //data insert to ConsecutiveSessionRoom
        private void C_sessionAdd_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Time_Management_System_2021.Properties.Settings.TimeManagementSystem_DBConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String Room_Name = AddRoomSession.Text;
            String Building_Name = AddLocationSession.Text;
            String Capacity = AddCapacitySession.Text;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chackboxselected = Convert.ToBoolean(dr.Cells["CheckboxClumn"].Value);
                if (chackboxselected)
                {
                    string Sqlquery = "INSERT INTO [dbo].[ConsecutiveSessionRoom] VALUES (@C_sesstionID, @SessionID, @session_name, @LectureName, @SubjectName, @SubjectCode, @Tag, @GroupNumber, @StudentCount, @Duration, @StartTime, @EndTime, @Day, @Room_Name, @Building_Name, @Capacity)";
                    SqlCommand sqlcomm = new SqlCommand(Sqlquery, sqlconn);


                    sqlcomm.Parameters.AddWithValue("@C_sesstionID", dr.Cells[0].Value);
                    sqlcomm.Parameters.AddWithValue("@SessionID", dr.Cells[1].Value);
                    sqlcomm.Parameters.AddWithValue("@session_name", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@LectureName", dr.Cells[3].Value);
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
            }
            MessageBox.Show("Add Room for Consecutive Session successfully", "Successfully");


        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Search method
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM RoomNonReservableTime WHERE Room_name LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvNRTR.DataSource = dt;
        }
        //home page button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }
    }
}
    
    


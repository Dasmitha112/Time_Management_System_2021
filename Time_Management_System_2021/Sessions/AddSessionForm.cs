using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;

namespace Time_Management_System_2021.Sessions
{
    public partial class AddSessionForm : Form
    {
        public AddSessionForm()
        {
            InitializeComponent();
            GetDisplaySession();
            //GetSessions();

        }

        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;




        public String lecturer = "";
        public String tags = "";
        public String groups = "";
        public String subject = "";
        public int SessionID;
        public String tagEdit = "";
        public String lecturersEdit = "";
        public String tagsEdit = "";
        public String groupsEdit = "";
        public String subjectEdit = "";

        public TabPage tabControl { get; private set; }
        public TabPage ViewSessions { get; private set; }

        private void Sessions_Load(object sender, EventArgs e)
        {
            GetLecturer();
            GetTags();
            GetGroups();
            GetSubjectscode();
            GetSubjectsName();

            //tabControl1.SelectedTab = AddSessionTab;
           // MGTSessionTab.SelectedTab = tabControl1;

        }
        





        public void GetLecturer()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT LecturerName FROM Lecturer order by LecturerName";

            cmd.ExecuteNonQuery();

            DataTable dtlecturers = new DataTable();

            SqlDataAdapter dalecturers = new SqlDataAdapter(cmd);

            dalecturers.Fill(dtlecturers);

            foreach (DataRow dr in dtlecturers.Rows)
            {
                SessionLecBox.Items.Add(dr["LecturerName"].ToString());
            }

            foreach (DataRow dr in dtlecturers.Rows)
            {
                MBoxLecture.Items.Add(dr["LecturerName"].ToString() + ", ");
            }

            con.Close();
        }
        private void GetSessions()
        {
            SqlCommand cmd = new SqlCommand("Select * from Sessions", con);
            DataTable dt = new DataTable();
            GetDisplaySession();
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            //dgvSessions.AutoGenerateColumns = false;
            dataGridViewSession.DataSource = dt;

            this.dataGridViewSession.Columns["SessionID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSession.Columns["SubjectName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSession.Columns["SubjectCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSession.Columns["GroupNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSession.Columns["Tag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
              this.dataGridViewSession.Columns["StudentCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
              this.dataGridViewSession.Columns["Duration"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
              this.dataGridViewSession.Columns["StartTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
              this.dataGridViewSession.Columns["EndTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
              this.dataGridViewSession.Columns["Day"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            



        }
        private void GetTags()
        {

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT Tag_name FROM Tag";

            cmd.ExecuteNonQuery();

            DataTable dttags = new DataTable();

            SqlDataAdapter datags = new SqlDataAdapter(cmd);

            datags.Fill(dttags);

            foreach (DataRow dr in dttags.Rows)
            {
                SessionTagBox.Items.Add(dr["Tag_name"].ToString());
            }

            foreach (DataRow dr in dttags.Rows)
            {
                MBoxtag.Items.Add(dr["Tag_name"].ToString());
            }

            con.Close();
        }
        public void GetGroups()
        {

            if (SessionTagBox.Text == "Practical")
            {
                con.Open();
                SessionGroupBox.Items.Clear();
                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.Text;

                cmd2.CommandText = "SELECT GroupNumber FROM Student order by GroupNumber";

                cmd2.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd2);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    SessionGroupBox.Items.Add(dr["GroupNumber"].ToString());
                }
                foreach (DataRow dr in dtgroups.Rows)
                {
                    MBoxGroup.Items.Add(dr["GroupNumber"].ToString());
                }

                con.Close();
            }
            else
            {
                con.Open();
                SessionGroupBox.Items.Clear();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT GroupNumber FROM Student order by GroupNumber";

                cmd.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    SessionGroupBox.Items.Add(dr["GroupNumber"].ToString());
                }
                foreach (DataRow dr in dtgroups.Rows)
                {
                    MBoxGroup.Items.Add(dr["GroupNumber"].ToString());
                }

                con.Close();
            }
        }

        public void GetSubjectscode()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SubjectCode FROM Subject order by OfferedYear";

            cmd.ExecuteNonQuery();

            DataTable dtsubjects = new DataTable();

            SqlDataAdapter dasubjects = new SqlDataAdapter(cmd);

            dasubjects.Fill(dtsubjects);

            foreach (DataRow dr in dtsubjects.Rows)
            {
                SessionSubCodeBox.Items.Add(dr["SubjectCode"].ToString());
            }

            foreach (DataRow dr in dtsubjects.Rows)
            {
                MBoxCode.Items.Add(dr["SubjectCode"].ToString());
            }

            con.Close();
        }


        public void GetSubjectsName()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SubjectName FROM Subject order by OfferedYear";

            cmd.ExecuteNonQuery();

            DataTable dtsubjects = new DataTable();

            SqlDataAdapter dasubjects = new SqlDataAdapter(cmd);

            dasubjects.Fill(dtsubjects);

            foreach (DataRow dr in dtsubjects.Rows)
            {
                SessionSubNBox.Items.Add(dr["SubjectName"].ToString());
            }

            foreach (DataRow dr in dtsubjects.Rows)
            {
                MBoxName.Items.Add(dr["SubjectName"].ToString());
            }

            con.Close();
        }














        private void SessionLecBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lecturer = lecturer + SessionLecBox.Text + ", ";

            //SessionLecBox.Text = lecturer;
        }

        private void TxtSessionLecBox_TextChanged(object sender, EventArgs e)
        {
            //lecturer = SessionLecBox.Text;
        }


        private void SessionAddBtn_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Sessions VALUES (@LecturerName, @SubjectName, @SubjectCode, @Tag, @GroupNumber, @StudentCount, @Duration, @StartTime, @EndTime, @Day)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LecturerName", SessionLecBox.Text);
                cmd.Parameters.AddWithValue("@SubjectName", SessionSubNBox.Text);
                cmd.Parameters.AddWithValue("@SubjectCode", SessionSubCodeBox.Text);
                cmd.Parameters.AddWithValue("@Tag", SessionTagBox.Text);
                cmd.Parameters.AddWithValue("@GroupNumber", SessionGroupBox.Text);
                cmd.Parameters.AddWithValue("@StudentCount", SessionStucountBox.Text);
                cmd.Parameters.AddWithValue("@Duration", SesionDurationBox.Text);
                cmd.Parameters.AddWithValue("@StartTime", start.Text);
                cmd.Parameters.AddWithValue("@EndTime", end.Text);
                cmd.Parameters.AddWithValue("@Day", SBoxDay.Text);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //GetDisplaySession();
                GetSessions();
                ClearFieldsAfterAdd();

                tabControl1.SelectedTab = SessionViewTab;
            }
        }
        private bool IsValid()
        {
            if ((SessionLecBox.Text == string.Empty) || (SessionSubNBox.Text == string.Empty) || (SessionSubCodeBox.Text == string.Empty) ||
                (SessionTagBox.Text == string.Empty) || (SessionGroupBox.Text == string.Empty) || (SBoxDay.Text == string.Empty) ||
                (Int32.Parse(SessionStucountBox.Text) == 0) || (Int32.Parse(SesionDurationBox.Text) == 0))
            {
                MessageBox.Show("Please fill the all fields", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SessionSubCodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject = SessionSubCodeBox.Text;

            if (subject != "")
            {
                con.Open();

                SqlCommand command = new SqlCommand("SELECT SubjectName FROM Subject Where SubjectCode = '" + subject + "'", con);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                string data = reader["SubjectName"].ToString();

                reader.Close();

                con.Close();

                SessionSubNBox.Text = data;
            }
        }

        private void ClearFieldsAfterAdd()
        {
            SessionLecBox.SelectedIndex = -1;


            SessionSubNBox.SelectedIndex = -1;
            //tags = "";
            //txtSelectedTags.Clear();

            SessionSubCodeBox.SelectedIndex = -1;
            //groups = "";
            //txtSelectedGroups.Clear();

            SessionGroupBox.SelectedIndex = -1;
            SessionTagBox.SelectedIndex = -1;
            SesionDurationBox.Value = 0;
            SessionStucountBox.Value = 0;

            start.Clear();
            SBoxDay.SelectedIndex = -1;
            end.Clear();

            SessionID = 0;

        }

        private void SesionClearBtn_Click(object sender, EventArgs e)
        {
            ClearFieldsAfterAdd();
        }

        private void GetDisplaySession()
        {

            adpt = new SqlDataAdapter("select * from Sessions", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSession.DataSource = dt;
            
        }

        private void DataGridViewSession_cellDoubleClick(object sender, EventArgs e)
        {
            
            OpenManageSessionFormWithData(this.dataGridViewSession.CurrentRow);
        }

        private void OpenManageSessionFormWithData(DataGridViewRow dataGridViewRow)
        {

            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectTab(t); //go to tab
            MBoxLecture.Text = dataGridViewRow.Cells[1].Value.ToString();
            MBoxName.Text = dataGridViewRow.Cells[2].Value.ToString();
            MBoxCode.Text = dataGridViewRow.Cells[3].Value.ToString();
            MBoxtag.Text = dataGridViewRow.Cells[4].Value.ToString();
            MBoxGroup.Text = dataGridViewRow.Cells[5].Value.ToString();
            numericMCOUNT.Text = dataGridViewRow.Cells[6].Value.ToString();
            numericMDuration.Text = dataGridViewRow.Cells[7].Value.ToString();
            MBoxstart.Text = dataGridViewRow.Cells[8].Value.ToString();
            MBoxEnd.Text = dataGridViewRow.Cells[9].Value.ToString();
            MBoxDay.Text = dataGridViewRow.Cells[10].Value.ToString();
            // SubCode = dgvSubjects.SelectedRows[0].Cells[0].Value.ToString();
            this.SessionID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

        }

        private void SMupdate_Click(object sender, EventArgs e)
        {
            if (SessionID > 0)
            {
                if (IsValidUpdate())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Sessions SET LecturerName = @LecturerName, SubjectName = @SubjectName, SubjectCode = @SubjectCode, Tag = @Tag, GroupNumber = @GroupNumber, StudentCount = @StudentCount, Duration = @Duration, StartTime = @StartTime, EndTime= @EndTime, Day = @Day WHERE SessionID = @SessionID", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LecturerName", MBoxLecture.Text);
                    cmd.Parameters.AddWithValue("@SubjectName", MBoxName.Text);
                    cmd.Parameters.AddWithValue("@SubjectCode", MBoxCode.Text);
                    cmd.Parameters.AddWithValue("@Tag", MBoxtag.Text);
                    cmd.Parameters.AddWithValue("@GroupNumber", MBoxGroup.Text);
                    cmd.Parameters.AddWithValue("@StudentCount", numericMCOUNT.Text);
                    cmd.Parameters.AddWithValue("@Duration", numericMDuration.Text);
                    cmd.Parameters.AddWithValue("@StartTime", MBoxstart.Text);
                    cmd.Parameters.AddWithValue("@EndTime", MBoxEnd.Text);
                    cmd.Parameters.AddWithValue("@Day", MBoxDay.Text);

                    cmd.Parameters.AddWithValue("@SessionID", this.SessionID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Session Details Updated", "Successfully");

                    //GetDisplaySession();
                    GetSessions();

                    ClearFieldsAfterupdates();

                    tabControl1.SelectedTab = MGTSessionTab;
                }
            }

            else
            {
                MessageBox.Show("Please Select a session to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsAfterupdates()
        {
            //throw new NotImplementedException();
            MBoxLecture.SelectedIndex = -1;


            MBoxtag.SelectedIndex = -1;
            //tags = "";
            //txtSelectedTags.Clear();

            MBoxCode.SelectedIndex = -1;
            //groups = "";
            //txtSelectedGroups.Clear();

            MBoxGroup.SelectedIndex = -1;
            MBoxName.SelectedIndex = -1;
            numericMCOUNT.Value = 0;
            
            numericMDuration.Value = 0;

            MBoxstart.Clear();
            MBoxDay.SelectedIndex = -1;
            MBoxEnd.Clear();

            SessionID = 0;
        }

        private bool IsValidUpdate()
        {
            if ((MBoxLecture.Text == string.Empty) || (MBoxtag.Text == string.Empty) || (MBoxCode.Text == string.Empty) ||
                (MBoxGroup.Text == string.Empty) || (MBoxName.Text == string.Empty) || (MBoxDay.Text == string.Empty) ||
                (Int32.Parse(numericMDuration.Text) == 0) || (Int32.Parse(numericMCOUNT.Text) == 0))
            {
                MessageBox.Show("Please fill the all fields", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SMdelete_Click(object sender, EventArgs e)
        {
            if (SessionID > 0)
            {

                if (MessageBox.Show("Are You Sure You Want to Delete the Session?", "Delete Session", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Sessions WHERE SessionID = @SessionID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@SessionID", this.SessionID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Session is Deleted", "Successfully");

                    //clear
                    ClearFieldsAfterupdates();
                    //display in gridview
                    //GetDisplaySession();
                    GetSessions();
                }

            }
            else
            {
                MessageBox.Show("Please Select a Subject to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backhomesession_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void backhomeS2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void backhome2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void txtstart_Click(object sender, EventArgs e)
        {

        }
    }

   

   


}



 


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

namespace Time_Management_System_2021.Subjects
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
            GetDisplaySubject();
        }


        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;

        public String SubCode;
        public int SubCodeValue = 0;
        public int SubID;

       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SUPkey_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Badd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Subject(OfferedYear, SubjectName, SubjectCode, OfferedSemester, LectureHours, TutorialHours, LabHours, EvaluationHours) VALUES (@OfferedYear, @SubjectName, @SubjectCode, @OfferedSemester, @LectureHours, @TutorialHours, @LabHours, @EvaluationHours)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@OfferedYear", SyearBox.Text);
                cmd.Parameters.AddWithValue("@SubjectName", Tname.Text);
                cmd.Parameters.AddWithValue("@SubjectCode", Tkey.Text);
                cmd.Parameters.AddWithValue("@OfferedSemester", SsemesterBox.Text);
                cmd.Parameters.AddWithValue("@LectureHours", SLHBox.Text);
                cmd.Parameters.AddWithValue("@TutorialHours", STHBox.Text);
                cmd.Parameters.AddWithValue("@LabHours", SLabHBox.Text);
                cmd.Parameters.AddWithValue("@EvaluationHours", SEHBox.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //GetSubjects();

                ClearSubjectFieldAfterAdd();
                GetDisplaySubject();

                //tabControlSubjects.SelectedTab = tabPageSubView;
            }
        }
        private void ClearSubjectFieldAfterAdd()
        {
            Tkey.Clear();
            Tname.Clear();
            SyearBox.SelectedIndex = -1;
            SsemesterBox.SelectedIndex = -1;
            SLHBox.SelectedIndex = -1;
            STHBox.SelectedIndex = -1;
            SLabHBox.SelectedIndex = -1;
            SEHBox.SelectedIndex = -1;
        }
        private bool IsValid()
        {
            if ((Tkey.Text == string.Empty) || (Tname.Text == string.Empty)
                || (SyearBox.Text == string.Empty) || (SsemesterBox.Text == string.Empty) || (SLHBox.Text == string.Empty)
                || (STHBox.Text == string.Empty) || (SLabHBox.Text == string.Empty) || (SEHBox.Text == string.Empty))
            {
                MessageBox.Show("Please Fill the all required fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void GetDisplaySubject()
        {

            adpt = new SqlDataAdapter("select * from Subject", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewSubject.DataSource = dt;

        }

        private void dataGridViewSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridViewSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            OpenManageSubjectFormWithData(this.dataGridViewSubject.CurrentRow);
        }
        //get all details for update
        private void OpenManageSubjectFormWithData(DataGridViewRow dataGridViewRow)
        {

            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectTab(t); //go to tab
            SUPYearBox.Text = dataGridViewRow.Cells[1].Value.ToString();
            SUPNametext.Text = dataGridViewRow.Cells[2].Value.ToString();
            SUPKeyText.Text = dataGridViewRow.Cells[3].Value.ToString();
            SUPSemesterBox.Text = dataGridViewRow.Cells[4].Value.ToString();
            SUPLHBox.Text = dataGridViewRow.Cells[5].Value.ToString();
            SUPTHBox.Text = dataGridViewRow.Cells[6].Value.ToString();
            SUPLabHBox.Text = dataGridViewRow.Cells[7].Value.ToString();
            SUPVivaHBox.Text = dataGridViewRow.Cells[8].Value.ToString();
           // SubCode = dgvSubjects.SelectedRows[0].Cells[0].Value.ToString();
            this.SubID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
           
        }

        private void Supdate_Click(object sender, EventArgs e)
        {
            if (SubID > 0)
            {
                if (IsValidUpdate())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Subject SET OfferedYear = @OfferedYear, SubjectName = @SubjectName, SubjectCode = @SubjectCode, OfferedSemester = @OfferedSemester, LectureHours = @LectureHours, TutorialHours = @TutorialHours, LabHours = @LabHours, EvaluationHours = @EvaluationHours  WHERE SubID = @SubID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@OfferedYear", SUPYearBox.Text);
                    cmd.Parameters.AddWithValue("@SubjectName", SUPNametext.Text);
                    cmd.Parameters.AddWithValue("@SubjectCode", SUPKeyText.Text);
                    cmd.Parameters.AddWithValue("@OfferedSemester", SUPSemesterBox.Text);
                    cmd.Parameters.AddWithValue("@LectureHours", SUPLHBox.Text);
                    cmd.Parameters.AddWithValue("@TutorialHours", SUPTHBox.Text);
                    cmd.Parameters.AddWithValue("@LabHours", SUPLabHBox.Text);
                    cmd.Parameters.AddWithValue("@EvaluationHours", SUPVivaHBox.Text);
                    cmd.Parameters.AddWithValue("@SubID", this.SubID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Subject Details Updated", "Successfully");

                    ClearFieldsAfterUpdate();
                    GetDisplaySubject();

                    // tabControlSubjects.SelectedTab = tabPageSubView;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Subject to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidUpdate()
        {
            if ((SUPYearBox.Text == string.Empty) || (SUPNametext.Text == string.Empty)
                || (SUPKeyText.Text == string.Empty) || (SUPSemesterBox.Text == string.Empty) || (SUPLHBox.Text == string.Empty)
                || (SUPTHBox.Text == string.Empty) || (SUPLabHBox.Text == string.Empty) || (SUPVivaHBox.Text == string.Empty))
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Sdelete_Click(object sender, EventArgs e)
        {
            if (SubID > 0)
            {

                if (MessageBox.Show("Are You Sure You Want to Delete the Subject?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Subject WHERE SubID = @SubID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@SubID", this.SubID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Subject is Deleted", "Successfully");

                    //clear
                    ClearFieldsAfterUpdate();
                    //display in gridview
                    GetDisplaySubject();

                }

            }
            else
            {
                MessageBox.Show("Please Select a Subject to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFieldsAfterUpdate()
        {
            SUPNametext.Clear();
            SUPKeyText.Clear();
            SUPYearBox.SelectedIndex = -1;
            SUPSemesterBox.SelectedIndex = -1;
            SUPLHBox.SelectedIndex = -1;
            SUPTHBox.SelectedIndex = -1;
            SUPLabHBox.SelectedIndex = -1;
            SUPVivaHBox.SelectedIndex = -1;
            SubCodeValue = 0;
        }

        private void FilterName_TextChanged(object sender, EventArgs e)
        {
            GetDisplaySubject();

            BindingSource ds = new BindingSource();
            ds.DataSource = dataGridViewSubject.DataSource;
            ds.Filter = "SubjectName like '%" + FilterName.Text + "%'";
            dataGridViewSubject.DataSource = ds;

        }

        private void FilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDisplaySubject();

            BindingSource ds = new BindingSource();
            ds.DataSource = dataGridViewSubject.DataSource;
            ds.Filter = "OfferedYear like '%" + FilterYear.Text + "%'";
            dataGridViewSubject.DataSource = ds;

        }

        private void SUPNametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

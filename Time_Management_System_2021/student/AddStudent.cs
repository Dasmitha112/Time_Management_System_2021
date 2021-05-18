using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;

namespace Time_Management_System_2021.student
{
    public partial class AddStudent : Form
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


        public AddStudent()
        {
            InitializeComponent();
            GetDisplay();

        }



        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;

        public int StudentID;



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }


        private void add_Y_Click(object sender, EventArgs e)
        {


        }




        private void Yclear_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private bool IsValid()
        {


            if ((yeartxt.Text == string.Empty) || (semestertxt.Text == string.Empty) || (facultytxt.Text == string.Empty) || (programtxt.Text == string.Empty) || (groupnumtxt.Text == string.Empty) || (subgroupnumtxt.Text == string.Empty) || (generateID.Text == string.Empty) || (generateSubID.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
            throw new NotImplementedException();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Student(EduYear, Faculty, Semester, Programme, GroupNumber, SubGroupNumber,GroupID,SubGroupID) VALUES (@EduYear, @Faculty, @Semester, @Programme, @GroupNumber, @SubGroupNumber,@GroupID,@SubGroupID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EduYear", yeartxt.Text);
                cmd.Parameters.AddWithValue("@Faculty", facultytxt.Text);
                cmd.Parameters.AddWithValue("@Semester", semestertxt.Text);
                cmd.Parameters.AddWithValue("@Programme", programtxt.Text);
                cmd.Parameters.AddWithValue("@GroupNumber", groupnumtxt.Text);
                cmd.Parameters.AddWithValue("@SubGroupNumber", subgroupnumtxt.Text);
                cmd.Parameters.AddWithValue("@GroupID", generateID.Text);
                cmd.Parameters.AddWithValue("@SubGroupID", generateSubID.Text);


                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("data insert Successfully", "Added Successful");

                GetDisplay();
                ClearFieldsAfterAdd();



                //Ltab1.SelectedTab = Ltab0;
            }

        }

        private void ClearFieldsAfterAdd()
        {
            generateSubID.Clear();
            generateID.Clear();
            yeartxt.ResetText();
            yeartxt.SelectedIndex = -1;
            programtxt.ResetText();
            programtxt.SelectedIndex = -1;
            semestertxt.ResetText();
            semestertxt.SelectedIndex = -1;
            facultytxt.ResetText();
            facultytxt.SelectedIndex = -1;
            groupnumtxt.ResetText();
            groupnumtxt.SelectedIndex = -1;
            subgroupnumtxt.ResetText();
            subgroupnumtxt.SelectedIndex = -1;
            StudentID = 0;

        }

        private void GetDisplay()
        {

            adpt = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView5.DataSource = dt;
        }
        private void yeartxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void gurpgenereate_Click(object sender, EventArgs e)
        {
            if ((yeartxt.Text == string.Empty) || (semestertxt.Text == string.Empty) || (programtxt.Text == string.Empty) || (groupnumtxt.Text == string.Empty))
            {
                MessageBox.Show("Acadamic year , semester , programme or group number is empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string year = yeartxt.Text;
                string semester = semestertxt.Text;
                string programme = programtxt.Text;
                string group = groupnumtxt.Text;

                generateID.Text = "Y" + year + "." + "S" + semester + "." + programme + "." + group;
                Console.WriteLine(generateID);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((yeartxt.Text == string.Empty) || (semestertxt.Text == string.Empty) || (programtxt.Text == string.Empty) || (groupnumtxt.Text == string.Empty) || (subgroupnumtxt.Text == string.Empty))
            {
                MessageBox.Show("Acadamic year , semester , programme ,group number or sub group number is empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string year = yeartxt.Text;
                string semester = semestertxt.Text;
                string programme = programtxt.Text;
                string group = groupnumtxt.Text;
                string sgroup = subgroupnumtxt.Text;

                generateSubID.Text = "Y" + year + "." + "S" + semester + "." + programme + "." + group + "." + sgroup;
                Console.WriteLine(generateSubID);


            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            yeartxt.Text = string.Empty;
            semestertxt.Text = string.Empty;
            programtxt.Text = string.Empty;
            facultytxt.Text = string.Empty;
            groupnumtxt.Text = string.Empty;
            subgroupnumtxt.Text = string.Empty;
            generateID.Text = string.Empty;
            generateSubID.Text = string.Empty;
            MessageBox.Show("Reseted!");

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenManagestudentFormWithData(this.dataGridView5.CurrentRow);
        }

        private void OpenManagestudentFormWithData(DataGridViewRow DataGridViewRow)
        {

            TabPage tab = tabControl1.TabPages[2];
            tabControl1.SelectTab(tab);
            EDITacaYeartxt.Text = DataGridViewRow.Cells[1].Value.ToString();
            EDITfactxt.Text = DataGridViewRow.Cells[2].Value.ToString();
            EDITsemtxt.Text = DataGridViewRow.Cells[3].Value.ToString();
            EDITprogtxt.Text = DataGridViewRow.Cells[4].Value.ToString();
            EDITgrouptxt.Text = DataGridViewRow.Cells[5].Value.ToString();
            EDITsubgrouptxt.Text = DataGridViewRow.Cells[6].Value.ToString();
            EDITgenerategroupID.Text = DataGridViewRow.Cells[7].Value.ToString();
            EDITsubgroupID.Text = DataGridViewRow.Cells[8].Value.ToString();
            this.StudentID = Convert.ToInt32(DataGridViewRow.Cells[0].Value);

        }

        private void S_reset_Button_Click(object sender, EventArgs e)
        {
            EDITacaYeartxt.Text = string.Empty;
            EDITfactxt.Text = string.Empty;
            EDITsemtxt.Text = string.Empty;
            EDITprogtxt.Text = string.Empty;
            EDITgrouptxt.Text = string.Empty;
            EDITsubgrouptxt.Text = string.Empty;
            EDITgenerategroupID.Text = string.Empty;
            EDITsubgroupID.Text = string.Empty;
            MessageBox.Show("Reseted!");

        }

        private void EditGgroupid_button_Click(object sender, EventArgs e)
        {
            if ((EDITacaYeartxt.Text == string.Empty) || (EDITsemtxt.Text == string.Empty) || (EDITprogtxt.Text == string.Empty) || (EDITgrouptxt.Text == string.Empty))
            {
                MessageBox.Show("Acadamic year , semester , programme or group number is empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Eyear = EDITacaYeartxt.Text;
                string Esemester = EDITsemtxt.Text;
                string Eprogramme = EDITprogtxt.Text;
                string Egroup = EDITgrouptxt.Text;

                EDITgenerategroupID.Text = "Y" + Eyear + "." + "S" + Esemester + "." + Eprogramme + "." + Egroup;
                Console.WriteLine(EDITgenerategroupID);

                MessageBox.Show("Group ID updated!!!!!");


            }

        }

        private void EDITSGgroupid_button_Click(object sender, EventArgs e)
        {
            if ((EDITacaYeartxt.Text == string.Empty) || (EDITsemtxt.Text == string.Empty) || (EDITprogtxt.Text == string.Empty) || (EDITgrouptxt.Text == string.Empty) || (EDITsubgrouptxt.Text == string.Empty))
            {
                MessageBox.Show("Acadamic year , semester , programme ,group number or sub group number is empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Eyear = EDITacaYeartxt.Text;
                string Esemester = EDITsemtxt.Text;
                string Eprogramme = EDITprogtxt.Text;
                string Egroup = EDITgrouptxt.Text;
                string Esbgroup = EDITsubgrouptxt.Text;

                EDITsubgroupID.Text = "Y" + Eyear + "." + "S" + Esemester + "." + Eprogramme + "." + Egroup + "." + Esbgroup;
                Console.WriteLine(EDITsubgroupID);

                MessageBox.Show("Sub Group ID updated!!!!!");


            }

        }

        private void S_delete_Button_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Student details?", "Delete Student details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE StudentID = @StudentID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@StudentID", this.StudentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student details are Deleted", "Successfully");

                    GetDisplay();

                    ClearFieldsUpdate();

                    //tabControlLecturers.SelectedTab = tabPageLecView;
                }
            }
            else
            {
                MessageBox.Show("Please Select a lecturer to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsUpdate()
        {
            EDITgenerategroupID.Clear();
            EDITsubgroupID.Clear();
            EDITacaYeartxt.ResetText();
            EDITacaYeartxt.SelectedIndex = -1;
            EDITfactxt.ResetText();
            EDITfactxt.SelectedIndex = -1;
            EDITsemtxt.ResetText();
            EDITsemtxt.SelectedIndex = -1;
            EDITprogtxt.ResetText();
            EDITprogtxt.SelectedIndex = -1;
            EDITgrouptxt.ResetText();
            EDITgrouptxt.SelectedIndex = -1;
            EDITsubgrouptxt.ResetText();
            EDITsubgrouptxt.SelectedIndex = -1;
            StudentID = 0;
        }

        private void UpdateDetails_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                if (MessageBox.Show("Are You Sure You Want to Update the Student details?", "Update Student details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (IsValidUpdate())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET EduYear = @EduYear, Faculty = @Faculty, Semester =  @Semester, Programme = @Programme, GroupNumber = @GroupNumber, SubGroupNumber = @SubGroupNumber, GroupID = @GroupID ,SubGroupID = @SubGroupID WHERE StudentID = @StudentID", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@EduYear", EDITacaYeartxt.Text);
                        cmd.Parameters.AddWithValue("@Faculty", EDITfactxt.Text);
                        cmd.Parameters.AddWithValue("@Semester", EDITsemtxt.Text);
                        cmd.Parameters.AddWithValue("@Programme", EDITprogtxt.Text);
                        cmd.Parameters.AddWithValue("@GroupNumber", EDITgrouptxt.Text);
                        cmd.Parameters.AddWithValue("@SubGroupNumber", EDITsubgrouptxt.Text);
                        cmd.Parameters.AddWithValue("@GroupID", EDITgenerategroupID.Text);
                        cmd.Parameters.AddWithValue("@SubGroupID", EDITsubgroupID.Text);
                        cmd.Parameters.AddWithValue("@StudentID", this.StudentID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Student Details Updated", "Successfully");

                        GetDisplay();

                        ClearFieldsUpdate();


                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Student Details to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUpdate()
        {
            if ((EDITacaYeartxt.Text == string.Empty) || (EDITsemtxt.Text == string.Empty) || (EDITfactxt.Text == string.Empty) || (EDITprogtxt.Text == string.Empty) || (EDITgrouptxt.Text == string.Empty) || (EDITsubgrouptxt.Text == string.Empty) || (EDITsubgroupID.Text == string.Empty) || (EDITgenerategroupID.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetDisplay();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView5.DataSource;
            bs.Filter = "Convert(EduYear, 'System.String') Like '%" + textBox1.Text + "%'";
            dataGridView5.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GetDisplay();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dataGridView5.DataSource;
            bs1.Filter = "Programme Like '%" + textBox2.Text + "%'";
            dataGridView5.DataSource = bs1;
        }

        private void btnHomeMWD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            EditGgroupID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EditGgroupID.Width, EditGgroupID.Height, 20, 20));
            EDITSGgroupid_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EDITSGgroupid_button.Width, EDITSGgroupid_button.Height, 20, 20));
            S_update_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, S_update_button.Width, S_update_button.Height, 20, 20));
            S_delete_Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, S_delete_Button.Width, S_delete_Button.Height, 20, 20));
            S_reset_Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, S_reset_Button.Width, S_reset_Button.Height, 20, 20));
        }
    }
}



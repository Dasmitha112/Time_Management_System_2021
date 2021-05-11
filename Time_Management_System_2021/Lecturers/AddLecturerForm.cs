using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;

namespace Time_Management_System_2021.Lecturers
{

    public partial class AddLecturerForm : Form
    {
        public AddLecturerForm()
        {
            InitializeComponent();
            GetDisplay();
        }

        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;



        public String EmployeeID;
        public float LecturerRank;






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UPlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private bool IsValid()
        {
            if ((textLname.Text == string.Empty) || (facultybox.Text == string.Empty)
                   || (deptBox.Text == string.Empty) || (centerBox.Text == string.Empty) || (buildingBox.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
            throw new NotImplementedException();
        }

        private void Lsave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("declare @NextEmployeeNumber int = 0,@EmployeeID varchar(6) = '' " +
"select @NextEmployeeNumber = NEXT VALUE FOR EmployeeID_Sequence " +

    "select @EmployeeID = FORMAT(@NextEmployeeNumber, 'D6') " +
 "INSERT INTO Lecturer(EmployeeID,LecturerName, Faculty, Department, Center, Building, Levels, Ranks) " +
 "VALUES (@EmployeeID,@LecturerName, @Faculty, @Department, @Center, @Building, @Levels,@Ranks)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LecturerName", textLname.Text);
                cmd.Parameters.AddWithValue("@Faculty", facultybox.Text);
                cmd.Parameters.AddWithValue("@Department", deptBox.Text);
                cmd.Parameters.AddWithValue("@Center", centerBox.Text);
                cmd.Parameters.AddWithValue("@Building", buildingBox.Text);
                cmd.Parameters.AddWithValue("@Levels", levelbox.Text);

                if (levelbox.Text.Equals("Professor"))
                {
                    LecturerRank = 1;
                }
                else if (levelbox.Text.Equals("Assistant Professor"))
                {
                    LecturerRank = 2;
                }
                else if (levelbox.Text.Equals("Senior Lecturer(HG)"))
                {
                    LecturerRank = 3;
                }
                else if (levelbox.Text.Equals("Senior Lecturer"))
                {
                    LecturerRank = 4;
                }
                else if (levelbox.Text.Equals("Lecturer"))
                {
                    LecturerRank = 5;
                }
                else if (levelbox.Text.Equals("Assistant Lecturer"))
                {
                    LecturerRank = 6;
                }
                else
                {
                    LecturerRank = 7;
                }
                cmd.Parameters.AddWithValue("@Ranks", LecturerRank);

                con.Open();
                cmd.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("SELECT TOP(1) EmployeeID FROM Lecturer ORDER BY 1 DESC", con);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                string data = reader["EmployeeID"].ToString();

                reader.Close();

                con.Close();

                SqlCommand command2 = new SqlCommand("UPDATE Lecturer SET Ranks = @Ranks Where EmployeeID = @EmployeeID ", con);
                command2.CommandType = CommandType.Text;

                command2.Parameters.AddWithValue("@Ranks", System.Convert.ToDecimal(LecturerRank + "." + data));

                command2.Parameters.AddWithValue("@EmployeeID", data);

                con.Open();

                command2.ExecuteNonQuery();

                con.Close();

                GetDisplay();

                ClearFieldsAfterAdd();

                //Ltab1.SelectedTab = Ltab0;
            }






        }

        private void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        private void ClearFieldsAfterAdd()
        {
            textLname.Clear();
            facultybox.ResetText();
            facultybox.SelectedIndex = -1;
            deptBox.ResetText();
            deptBox.SelectedIndex = -1;
            centerBox.ResetText();
            centerBox.SelectedIndex = -1;
            buildingBox.ResetText();
            buildingBox.SelectedIndex = -1;
            levelbox.ResetText();
            levelbox.SelectedIndex = -1;
            EmployeeID = "000000";
            MessageBox.Show("CLEARED!");
        }
        private void GetDisplay()
        {

            adpt = new SqlDataAdapter("select * from Lecturer", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;





        }
        private void levelbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lclear_Click(object sender, EventArgs e)
        {
            ClearFieldsAfterAdd();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            OpenManageLecturerFormWithData(this.dataGridView1.CurrentRow);
        }

        private void OpenManageLecturerFormWithData(DataGridViewRow dataGridViewRow)
        {

            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectTab(t); //go to tab
            updatename.Text = dataGridViewRow.Cells[1].Value.ToString();
            LUPfacultyBox.Text = dataGridViewRow.Cells[2].Value.ToString();
            LUPdeptbox.Text = dataGridViewRow.Cells[3].Value.ToString();
            UPcenter.Text = dataGridViewRow.Cells[4].Value.ToString();
            LUPbuildingbox.Text = dataGridViewRow.Cells[5].Value.ToString();
            UPlevel.Text = dataGridViewRow.Cells[6].Value.ToString();
            this.EmployeeID = dataGridViewRow.Cells[0].Value.ToString();
            // this.EmployeeID = dataGridViewRow.Cells[0].Value.Convert.ToString(EmployeeID);








        }

        private void UPadd_Click(object sender, EventArgs e)
        {
            if (EmployeeID != "000000")
            {
                if (IsValidUpdate())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Lecturer SET LecturerName = @LecturerName, Faculty = @Faculty, Department = @Department, Center = @Center, Building = @Building, Levels = @Levels, Ranks = @Ranks WHERE EmployeeID = @EmployeeID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@LecturerName", updatename.Text);
                    cmd.Parameters.AddWithValue("@Faculty", LUPfacultyBox.Text);
                    cmd.Parameters.AddWithValue("@Department", LUPdeptbox.Text);
                    cmd.Parameters.AddWithValue("@Center", UPcenter.Text);
                    cmd.Parameters.AddWithValue("@Building", LUPbuildingbox.Text);
                    cmd.Parameters.AddWithValue("@Levels", UPlevel.Text);

                    if (UPlevel.Text.Equals("Professor"))
                    {
                        LecturerRank = 1;
                    }
                    else if (UPlevel.Text.Equals("Assistant Professor"))
                    {
                        LecturerRank = 2;
                    }
                    else if (UPlevel.Text.Equals("Senior Lecturer(HG)"))
                    {
                        LecturerRank = 3;
                    }
                    else if (UPlevel.Text.Equals("Senior Lecturer"))
                    {
                        LecturerRank = 4;
                    }
                    else if (UPlevel.Text.Equals("Lecturer"))
                    {
                        LecturerRank = 5;
                    }
                    else if (UPlevel.Text.Equals("Assistant Lecturer"))
                    {
                        LecturerRank = 6;
                    }
                    else
                    {
                        LecturerRank = 7;
                    }
                    cmd.Parameters.AddWithValue("@Ranks", System.Convert.ToDecimal(LecturerRank + "." + this.EmployeeID));

                    cmd.Parameters.AddWithValue("@EmployeeID", this.EmployeeID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Lecturer Details Updated", "Successfully");

                    GetDisplay();

                    ClearFieldsUpdate();

                    //tabControlLecturers.SelectedTab = tabPageLecView;
                }
            }
            else
            {
                MessageBox.Show("Please Select a lecturer to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidUpdate()
        {
            if ((updatename.Text == string.Empty) || (LUPfacultyBox.Text == string.Empty)
                || (LUPdeptbox.Text == string.Empty) || (UPcenter.Text == string.Empty) || (LUPbuildingbox.Text == string.Empty)
                || (UPlevel.Text == string.Empty))
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ClearFieldsUpdate()
        {
            updatename.Clear();
            LUPfacultyBox.ResetText();
            LUPfacultyBox.SelectedIndex = -1;
            LUPdeptbox.ResetText();
            LUPdeptbox.SelectedIndex = -1;
            UPcenter.ResetText();
            UPcenter.SelectedIndex = -1;
            LUPbuildingbox.ResetText();
            LUPbuildingbox.SelectedIndex = -1;
            UPlevel.ResetText();
            UPlevel.SelectedIndex = -1;
            EmployeeID = "000000";
            MessageBox.Show("CLEARED!");
        }

        private void UPdelete_Click(object sender, EventArgs e)
        {
            if (EmployeeID != "000000")
            {

                if (MessageBox.Show("Are You Sure You Want to Delete the Lecturer?", "Delete Lecturer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Lecturer WHERE EmployeeID = @EmployeeID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@EmployeeID", this.EmployeeID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Lecturer is Deleted", "Successfully");

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

        private void Ltab0_Click(object sender, EventArgs e)
        {

        }


        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            GetDisplay();

            BindingSource ds = new BindingSource();
            ds.DataSource = dataGridView1.DataSource;
            ds.Filter = "LecturerName like '%" + SearchName.Text + "%'";
            dataGridView1.DataSource = ds;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDisplay();

            BindingSource ds = new BindingSource();
            ds.DataSource = dataGridView1.DataSource;
            ds.Filter = "Department like '%" + SearchDept.Text + "%'";
            dataGridView1.DataSource = ds;

        }

        private void SearchLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDisplay();

            BindingSource ds = new BindingSource();
            ds.DataSource = dataGridView1.DataSource;
            ds.Filter = "Levels like '%" + SearchLevel.Text + "%'";
            dataGridView1.DataSource = ds;

        }
    }
}

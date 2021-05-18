using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;
using Time_Management_System_2021.Working_days_and_hours;

namespace Time_Management_System_2021.Generate
{
    public partial class GenerateTimeTable : Form
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


        public SqlConnection con = DBconfig.con;
        public int hr = 8;
        public int min = 30;
        public int sec = 0;
        //public int TimetableID;

        public GenerateTimeTable()
        {
            InitializeComponent();
        }


        private void GenerateTimetable_Load(object sender, EventArgs e)
        {

            this.cmbGroup.DataSource = null;
            cmbGroup.Items.Clear();

            string query2 = "select StudentID, GroupID FROM Student";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
            con.Open();
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Student");

            cmbGroup.DisplayMember = "GroupID";
            cmbGroup.ValueMember = "StudentID";
            cmbGroup.DataSource = ds2.Tables["Student"];

            con.Close();
            cmbGroup.SelectedIndex = -1;



            this.cmbLec.DataSource = null;
            cmbLec.Items.Clear();

            string query3 = "select EmployeeID, LecturerName FROM Lecturer";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, con);
            con.Open();
            DataSet ds3 = new DataSet();
            da3.Fill(ds3, "Lecturer");

            cmbLec.DisplayMember = "LecturerName";
            cmbLec.ValueMember = "EmployeeID";
            cmbLec.DataSource = ds3.Tables["Lecturer"];

            con.Close();
            cmbLec.SelectedIndex = -1;



            this.cmbRoom.DataSource = null;
            cmbRoom.Items.Clear();

            string query4 = "select Room_name FROM building";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, con);
            con.Open();
            DataSet ds4 = new DataSet();
            da4.Fill(ds4, "building");

            cmbRoom.DisplayMember = "Room_name";
            cmbRoom.ValueMember = "Room_name";
            cmbRoom.DataSource = ds4.Tables["building"];

            con.Close();
            cmbRoom.SelectedIndex = -1;

            //daege.SelectedTab = metroTabPage3;

            //generateTimetable();
        }

        //private void generateTimetable()
        //{
        //    SqlCommand cmd = new SqlCommand("select * from Timetable", con);
        //    DataTable generatedt = new DataTable();

        //    con.Open();

        //    SqlDataReader gTT = cmd.ExecuteReader();
        //    generatedt.Load(gTT);
        //    con.Close();

        //    dvgGT.DataSource = generatedt;

        //}

        private void btnGTlecadd_Click(object sender, EventArgs e)
        {
            //if (iswTimeTableValid())
            //{
            //    SqlCommand cmd = new SqlCommand("INSERT INTO WorkingTime VALUES( @lecturer, @room_num, @subject, @day, @startTime ,@endTime , @sessionType, @sessionID , @range , @timeslot )", con);
            //    cmd.CommandType = CommandType.Text;

            //    cmd.Parameters.AddWithValue("@lecturer", numericUpDownMinutes.Text);
            //    cmd.Parameters.AddWithValue("@room_num", numericUpDownMinutes.Text);
            //    cmd.Parameters.AddWithValue("@subject", numericUpDownMinutes.Text);
            //    cmd.Parameters.AddWithValue("@day", cmdGTlec.Text);
            //    cmd.Parameters.AddWithValue("@startTime", cmdGTclassroom.Text);
            //    cmd.Parameters.AddWithValue("@endTime", cmdGTlecSubject.Text);
            //    cmd.Parameters.AddWithValue("@sessionType", numericUpDownMinutes.Text);
            //    cmd.Parameters.AddWithValue("@sessionID", cmdGTlecDay.Text);




            //    cmd.Parameters.AddWithValue("@room_num", numericUpDownMinutes.Text);
            //    cmd.Parameters.AddWithValue("@room_num", numericUpDownMinutes.Text);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show(" Data is sucessfully saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    generateTimetable();
            //    ResetGT();

            //}
        }

        //working Time checking valid
        //private bool iswTimeTableValid()
        //{
        //    if (cmdGTlec.Text == "" || cmdGTclassroom.Text == "" || cmdGTlecSubject.Text == "" || cmdGTlecDay.Text == ""
        //        || cmdGTclassroom.Text == "" || cmdGTclassroom.Text == "" || cmdGTclassroom.Text == "" || cmdGTclassroom.Text == ""
        //        || cmdGTclassroom.Text == "" || cmdGTclassroom.Text == "")
        //    {
        //        MessageBox.Show("This Field Can not be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    return true;
        //}



        //generate timetable 
        private void btnGTreset_Click(object sender, EventArgs e)
        {
            //    ResetGT();

        }

        //cancle
        //private void ResetGT()
        //{

        //    numericUpDownHours.Text = "0";
        //    numericUpDownMinutes.Text = "0";

        //}

        //private void dvgGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //WorkingTimeID = Convert.ToInt32(dgvWT.SelectedRows[0].Cells[0].Value);
        //    //numericUpDownHours.Text = dgvWT.SelectedRows[0].Cells[1].Value.ToString();
        //    //numericUpDownMinutes.Text = dgvWT.SelectedRows[0].Cells[2].Value.ToString();
        //}





       /* //--------------------Side Nav Buttons--------------------
        private void btnSideNavWorking_Click(object sender, EventArgs e)
        {
            int TimetableType = -1;
            try
            {
                using (Form1 form = new Form1())
                {
                    form.ShowDialog();
                    TimetableType = form.getText();
                    if (!form.getClose())
                    {
                        Working_Days.Add_Number_of_Working_Days workingDays = new Working_Days.Add_Number_of_Working_Days(TimetableType);
                        this.Hide();
                        workingDays.ShowDialog();
                    }
                }
            }

            catch (Exception)
            {

            }
        }*/


        /*
        private void btnSideNavLecturers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturers.AddLecturer addLecturer = new Lecturers.AddLecturer();
            addLecturer.ShowDialog();
        }

        private void btnSideNavSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects.AddSubject addSubject = new Subjects.AddSubject();
            addSubject.ShowDialog();
        }

        private void btnSideNavStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students.Students stu = new Students.Students();
            stu.ShowDialog();
        }

        private void btnSideNavTags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tags.Tags tag = new Tags.Tags();
            tag.ShowDialog();
        }

        private void btnSideNavLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locations.Location loc = new Locations.Location();
            loc.ShowDialog();
        }

        private void btnSideNavStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics.Statistics stat = new Statistics.Statistics();
            stat.ShowDialog();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {

            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select SubjectName,GroupNumber,SubjectCode,Tag,Duration,'1' from Sessions where LecturerName LIKE '%" + cmbLec.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dgvLec.ColumnCount = 8;
            dgvLec.Columns[0].Name = "";
            dgvLec.Columns[1].Name = "Monday";
            dgvLec.Columns[2].Name = "Tuesday";
            dgvLec.Columns[3].Name = "Wednesday";
            dgvLec.Columns[4].Name = "Thursday";
            dgvLec.Columns[5].Name = "Friday";
            dgvLec.Columns[6].Name = "Saturday";
            dgvLec.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvLec.Rows)
                {
                    try
                    {
                        dgvLec.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvLec.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgvLec.Rows.Add(row);
            }
        }

        /*private void btnGTCRgenerate_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select Lecturer,Subject,SubjectCode,Tag,Duration,'1' from sessions where GroupID LIKE '%" + genGrpCmb.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dgvWT.ColumnCount = 8;
            dgvWT.Columns[0].Name = "";
            dgvWT.Columns[1].Name = "Monday";
            dgvWT.Columns[2].Name = "Tuesday";
            dgvWT.Columns[3].Name = "Wednesday";
            dgvWT.Columns[4].Name = "Thursday";
            dgvWT.Columns[5].Name = "Friday";
            dgvWT.Columns[6].Name = "Saturday";
            dgvWT.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvWT.Rows)
                {
                    try
                    {
                        dgvWT.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvWT.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {
                }

                dgvWT.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }*/

        private void timeCalc(int hr1, int min1, int sec1)
        {

            sec += sec1;

            if (sec > 60)
            {
                min++;
                sec -= 60;
            }

            min += min1;

            if (min > 60)
            {
                hr++;
                min -= 60;
            }

            hr += hr1;
        }

        /*
        private void btnHeaderGenerate_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateTimeTable generatetimetable = new GenerateTimeTable();
            generatetimetable.ShowDialog();
        }*/



        //Generate button Student group
        private void button6_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select SubjectName,GroupNumber,SubjectCode,Tag,Duration,'1' from Sessions where GroupNumber LIKE '%" + cmbGroup.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);


            con.Close();

            dgvGroup.ColumnCount = 8;
            dgvGroup.Columns[0].Name = "Time";
            dgvGroup.Columns[1].Name = "Monday";
            dgvGroup.Columns[2].Name = "Tuesday";
            dgvGroup.Columns[3].Name = "Wednesday";
            dgvGroup.Columns[4].Name = "Thursday";
            dgvGroup.Columns[5].Name = "Friday";
            dgvGroup.Columns[6].Name = "Saturday";
            dgvGroup.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvGroup.Rows)
                {
                    try
                    {
                        dgvGroup.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvGroup.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgvGroup.Rows.Add(row);
            }
        }
        


        //Page loading method
        private void GenerateTimeTable_Load_1(object sender, EventArgs e)
        {

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 20, 20));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));


            this.cmbGroup.DataSource = null;
            cmbGroup.Items.Clear();

            string query2 = "select StudentID, GroupID FROM Student";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
            con.Open();
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Student");

            cmbGroup.DisplayMember = "GroupID";
            cmbGroup.ValueMember = "StudentID";
            cmbGroup.DataSource = ds2.Tables["Student"];

            con.Close();
            cmbGroup.SelectedIndex = -1;



            this.cmbLec.DataSource = null;
            cmbLec.Items.Clear();

            string query3 = "select EmployeeID, LecturerName FROM Lecturer";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, con);
            con.Open();
            DataSet ds3 = new DataSet();
            da3.Fill(ds3, "Lecturer");

            cmbLec.DisplayMember = "LecturerName";
            cmbLec.ValueMember = "EmployeeID";
            cmbLec.DataSource = ds3.Tables["Lecturer"];

            con.Close();
            cmbLec.SelectedIndex = -1;



            this.cmbRoom.DataSource = null;
            cmbRoom.Items.Clear();

            string query4 = "select Room_name FROM ConsecutiveSessionRoom";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, con);
            con.Open();
            DataSet ds4 = new DataSet();
            da4.Fill(ds4, "ConsecutiveSessionRoom");

            cmbRoom.DisplayMember = "Room_name";
            cmbRoom.ValueMember = "Room_name";
            cmbRoom.DataSource = ds4.Tables["ConsecutiveSessionRoom"];

            con.Close();
            cmbRoom.SelectedIndex = -1;

            //daege.SelectedTab = metroTabPage3;

            //generateTimetable();
        }

        private void dgvLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Generate button lecturer
        private void button1_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select SubjectName,GroupNumber,SubjectCode,Tag,Duration,'1' from Sessions where LecturerName LIKE '%" + cmbLec.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
 

            con.Close();

            dgvLec.ColumnCount = 8;
            dgvLec.Columns[0].Name = "Time";
            dgvLec.Columns[1].Name = "Monday";
            dgvLec.Columns[2].Name = "Tuesday";
            dgvLec.Columns[3].Name = "Wednesday";
            dgvLec.Columns[4].Name = "Thursday";
            dgvLec.Columns[5].Name = "Friday";
            dgvLec.Columns[6].Name = "Saturday";
            dgvLec.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvLec.Rows)
                {
                    try
                    {
                        dgvLec.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvLec.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgvLec.Rows.Add(row);
            }
        }


        //Generate button Class Room
        private void button9_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select SubjectName,Building_Name,SubjectCode,Tag,Duration,'1' from ConsecutiveSessionRoom where Room_name LIKE '%" + cmbRoom.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);


            con.Close();

            dgvClassRoom.ColumnCount = 8;
            dgvClassRoom.Columns[0].Name = "Time";
            dgvClassRoom.Columns[1].Name = "Monday";
            dgvClassRoom.Columns[2].Name = "Tuesday";
            dgvClassRoom.Columns[3].Name = "Wednesday";
            dgvClassRoom.Columns[4].Name = "Thursday";
            dgvClassRoom.Columns[5].Name = "Friday";
            dgvClassRoom.Columns[6].Name = "Saturday";
            dgvClassRoom.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvClassRoom.Rows)
                {
                    try
                    {
                        dgvClassRoom.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvClassRoom.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgvClassRoom.Rows.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgvLec.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_" + cmbLec.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvLec.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvLec.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvLec.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell((string)cell.Value);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }


        //pdf generation student
        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvGroup.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_" + cmbGroup.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvGroup.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvGroup.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvGroup.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell((string)cell.Value);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }


        //pdf generation classroom
        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvClassRoom.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_" + cmbRoom.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvClassRoom.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvClassRoom.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvClassRoom.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell((string)cell.Value);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

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

        TimeSlot ts = new TimeSlot();

        //Round button generation
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


        public GenerateTimeTable()
        {
            InitializeComponent();
        }
 



        //Generate button Student group
        private void button6_Click(object sender, EventArgs e)
        {

            //Query
            String query2 = "select SubjectName,GroupNumber,SubjectCode,Tag,Duration,StartTime,Day from Sessions where GroupNumber LIKE '%" + cmbGroup.Text + "%' order by StartTime";

            SqlCommand cmd = new SqlCommand(query2, con);
            con.Open();
            DataTable dt2 = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt2.Load(sdr);


            con.Close();

            DataTable newData2 = new DataTable();

            //First row data
            newData2.Columns.Add("Time", typeof(String));
            newData2.Columns.Add("Monday", typeof(String));
            newData2.Columns.Add("Tuesday", typeof(String));
            newData2.Columns.Add("Wednesday", typeof(String));
            newData2.Columns.Add("Thursday", typeof(String));
            newData2.Columns.Add("Friday", typeof(String));
            newData2.Columns.Add("Saturday", typeof(String));
            newData2.Columns.Add("Sunday", typeof(String));


            


            String[] timeSlot2 = new String[] { "08.30", "09.30", "10.30", "11.30", "12.30", "01.30", "02.30", "03.30", "04.30" };


            //Fill entire table
            for (int i = 0; i < timeSlot2.Length; i++)
            {
                newData2.Rows.Add(new object[] { timeSlot2[i], "---", "---", "---", "---", "---", "---", "---" });
            }

            foreach (DataRow row in dt2.Rows)
            {

                //fetching data
                string ss2 = row[0] + "\n" + row[1] + "\n" + row[2] + "\n" + row[3] + "\n" + row[4] + "\n" + row[5] + "\n" + row[6];
                string col2 = null;

                //assigning col value to fetched data
                if (row[6].Equals("Monday"))
                {
                    col2 = "Monday";
                }
                else if (row[6].Equals("Tuesday"))
                {
                    col2 = "Tuesday";
                }
                else if (row[6].Equals("Wednesday"))
                {
                    col2 = "Wednesday";
                }
                else if (row[6].Equals("Thursday"))
                {
                    col2 = "Thursday";
                }
                else if (row[6].Equals("Friday"))
                {
                    col2 = "Friday";
                }

                //compare fetched data and with timeslot values and place to correct timetable slot
                for (int i = 0; i < timeSlot2.Length; i++)
                {
                    if (row[5].Equals(timeSlot2[i]))
                    {
                        newData2.Rows[i][col2] = ss2;
                        break;
                    }
                }
            }

            //place values to table
            dgvGroup.DataSource = newData2;
        }
        


        //Page loading method
        private void GenerateTimeTable_Load_1(object sender, EventArgs e)
        {

            //Round button generation
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 20, 20));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));


            //Group combobox data retrieving
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


            //Lecturer combobox data retrieving
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


            //Room combobox data retrieving
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

        }

        private void dgvLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Generate button lecturer
        private void button1_Click(object sender, EventArgs e)
        {
            //Query
            String query1 = "select SubjectName,GroupNumber,SubjectCode,Tag,Duration,StartTime,Day from Sessions where LecturerName LIKE '%" + cmbLec.Text + "%' order by StartTime";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            DataTable newData = new DataTable();

            //First row data
            newData.Columns.Add("Time", typeof(String));
            newData.Columns.Add("Monday", typeof(String));
            newData.Columns.Add("Tuesday", typeof(String));
            newData.Columns.Add("Wednesday", typeof(String));
            newData.Columns.Add("Thursday", typeof(String));
            newData.Columns.Add("Friday", typeof(String));
            newData.Columns.Add("Saturday", typeof(String));
            newData.Columns.Add("Sunday", typeof(String));

            String[] timeSlot = new String[] { "08.30", "09.30", "10.30", "11.30", "12.30", "01.30", "02.30", "03.30", "04.30" };


            //Fill entire table
            for (int i = 0; i < timeSlot.Length; i++)
            {
                newData.Rows.Add(new object[] { timeSlot[i], "---", "---", "---", "---", "---", "---", "---" });
            }

            foreach (DataRow row in dt.Rows)
            {

                //fetching data
                string ss = row[0] + "\n" + row[1] + "\n" + row[2] + "\n" + row[3] + "\n" + row[4] + "\n" + row[5] + "\n" + row[6];
                string col = null;


                //assigning col value to fetched data
                if (row[6].Equals("Monday"))
                {
                    col = "Monday";
                }
                else if (row[6].Equals("Tuesday"))
                {
                    col = "Tuesday";
                }
                else if (row[6].Equals("Wednesday"))
                {
                    col = "Wednesday";
                }
                else if (row[6].Equals("Thursday"))
                {
                    col = "Thursday";
                }
                else if (row[6].Equals("Friday"))
                {
                    col = "Friday";
                }


                //compare fetched data and with timeslot values and place to correct timetable slot
                for (int i = 0; i < timeSlot.Length; i++)
                {
                    if (row[5].Equals(timeSlot[i]))
                    {
                        newData.Rows[i][col] = ss;
                        break;
                    }
                }
            }

            //place values to table
            dgvLec.DataSource = newData;
        }


        //Generate button Class Room
        private void button9_Click(object sender, EventArgs e)
        {
            //Query
            String query3 = "select SubjectName,Building_Name,SubjectCode,Tag,Duration,Room_Name,StartTime,Day from ConsecutiveSessionRoom where Room_Name LIKE '%" + cmbRoom.Text + "%' order by StartTime";

            //Loading data table
            SqlCommand cmd = new SqlCommand(query3, con);
            con.Open();
            DataTable dt3 = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt3.Load(sdr);

            con.Close();

            DataTable newData3 = new DataTable();



            //First row data
            newData3.Columns.Add("Time", typeof(String));
            newData3.Columns.Add("Monday", typeof(String));
            newData3.Columns.Add("Tuesday", typeof(String));
            newData3.Columns.Add("Wednesday", typeof(String));
            newData3.Columns.Add("Thursday", typeof(String));
            newData3.Columns.Add("Friday", typeof(String));
            newData3.Columns.Add("Saturday", typeof(String));
            newData3.Columns.Add("Sunday", typeof(String));

            String[] timeSlot3 = new String[] { "08.30", "09.30", "10.30", "11.30", "12.30", "01.30", "02.30", "03.30", "04.30" };

            //Fill entire table
            for (int i = 0; i < timeSlot3.Length; i++)
            {
                newData3.Rows.Add(new object[] { timeSlot3[i], "---", "---", "---", "---", "---", "---", "---" });
            }

            foreach (DataRow row in dt3.Rows)
            {

                //fetching data
                string ss = row[0] + "\n" + row[1] + "\n" + row[2] + "\n" + row[3] + "\n" + row[4] + "\n" + row[5] + "\n" + row[6] + "\n" + row[7];
                string col = null;

                //assigning col value to fetched data
                if (row[7].Equals("Monday"))
                {
                    col = "Monday";
                }
                else if (row[7].Equals("Tuesday"))
                {
                    col = "Tuesday";
                }
                else if (row[7].Equals("Wednesday"))
                {
                    col = "Wednesday";
                }
                else if (row[7].Equals("Thursday"))
                {
                    col = "Thursday";
                }
                else if (row[7].Equals("Friday"))
                {
                    col = "Friday";
                }

                //compare fetched data and with timeslot values and place to correct timetable slot
                for (int i = 0; i < timeSlot3.Length; i++)
                {
                    if (row[6].Equals(timeSlot3[i]))
                    {
                        newData3.Rows[i][col] = ss;
                        break;
                    }
                }
            }

            //place values to table
            dgvClassRoom.DataSource = newData3;
        }


        //----------------------------- Home icon reference -------------------------------------

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

        //------------------------------------------------------------------------------------



        //PDF generation Lecturer
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


        //PDF generation student
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


        //PDF generation classroom
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

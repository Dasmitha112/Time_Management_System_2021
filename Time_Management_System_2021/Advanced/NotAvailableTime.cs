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

namespace Time_Management_System_2021.Advanced
{
    public partial class NotAvailableTime : Form
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



        public NotAvailableTime()
        {
            InitializeComponent();
        }


        SetNotAvailableTime snat = new SetNotAvailableTime();


        //Home button
        private void btnHomeSNAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        //Page loading method
        private void NotAvailableTime_Load(object sender, EventArgs e)
        {

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));


            //Load SetNotAvailableTime data on data gridview
            DataTable dtNAT = snat.displaySetNotAvailableTimeData();
            dgvSNAT.DataSource = dtNAT;
        }


        //Method to load the relevant data from Type combobox to Values combobox
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbType.Text;

            if (type != null || type != "" || type != " ")
            {
                if(type == "Lecturer")
                {

                    //Loading SetNotAvailableTime data
                    DataSet ds = snat.displayLecturers();
                    cmbValue.DataSource = ds.Tables[0];
                    cmbValue.DisplayMember = "LecturerName";
                    cmbValue.ValueMember = "EmployeeID";
                }

                if (type == "Session")
                {

                    //Loading SetNotAvailableTime data
                    DataSet ds = snat.displaySessions();
                    cmbValue.DataSource = ds.Tables[0];
                    cmbValue.DisplayMember = "SessionID";
                    cmbValue.ValueMember = "SessionID";
                }

                if (type == "Group")
                {

                    //Loading SetNotAvailableTime data
                    DataSet ds = snat.displayGroups();
                    cmbValue.DataSource = ds.Tables[0];
                    cmbValue.DisplayMember = "GroupID";
                    cmbValue.ValueMember = "StudentID";
                }

                if (type == "Sub-group")
                {

                    //Loading SetNotAvailableTime data
                    DataSet ds = snat.displayGroups();
                    cmbValue.DataSource = ds.Tables[0];
                    cmbValue.DisplayMember = "SubGroupID";
                    cmbValue.ValueMember = "StudentID";
                }
            }
        }


        //Insert data to SetNotAvailableTime
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cmbType.Text != string.Empty) && (cmbValue.Text != string.Empty) && (cmbDay.Text != string.Empty) && (txtStartTimeSNAT.Text != string.Empty) && (txtEndTimeSNAT.Text != string.Empty))
            {
                //Getting values from the input fields
                snat.Type = cmbType.Text;
                snat.Value = cmbValue.Text;
                snat.Day = cmbDay.Text;
                snat.StartTime = txtStartTimeSNAT.Text;
                snat.EndTime = txtEndTimeSNAT.Text;

                //Inserting data to db
                int SetNotAvailableTimeID = snat.insertNotAvailableTime(snat);

                if (SetNotAvailableTimeID > 0)
                {
                    MessageBox.Show("New Not Available Time successfully added!");

                    //calling clear TimeSlot fields method
                    clearSetNotAvailableTimeFields();

                }
                else
                {
                    MessageBox.Show("Failed to insert Not Available Time to database...");
                }

                //Load SetNotAvailableTime data on data gridview
                DataTable dtNAT = snat.displaySetNotAvailableTimeData();
                dgvSNAT.DataSource = dtNAT;


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Method to clear SetNotAvailableTime fields
        public void clearSetNotAvailableTimeFields()
        {
            cmbType.Text = "";
            cmbValue.Text = "";
            cmbDay.Text = "";
            txtStartTimeSNAT.Text = "";
            txtEndTimeSNAT.Text = "";
        }


        string NATID;

        //Retrieving data from the selected row and filled with textboxes
        private void dgvSNAT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data gridview and load it into the textboxes
            int rowIndex = e.RowIndex;
            cmbType.Text = dgvSNAT.Rows[rowIndex].Cells[1].Value.ToString();
            cmbValue.Text = dgvSNAT.Rows[rowIndex].Cells[2].Value.ToString();
            cmbDay.Text = dgvSNAT.Rows[rowIndex].Cells[3].Value.ToString();
            txtStartTimeSNAT.Text = dgvSNAT.Rows[rowIndex].Cells[4].Value.ToString();
            txtEndTimeSNAT.Text = dgvSNAT.Rows[rowIndex].Cells[5].Value.ToString();

            NATID = dgvSNAT.Rows[rowIndex].Cells[0].Value.ToString();
        }



        //Update data
        private void button3_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            snat.NATID = int.Parse(NATID);
            snat.Type = cmbType.Text;
            snat.Value = cmbValue.Text;
            snat.Day = cmbDay.Text;
            snat.StartTime = txtStartTimeSNAT.Text;
            snat.EndTime = txtEndTimeSNAT.Text;

            //Update data in db
            bool success = snat.updateNotAvailableTime(snat);

            if (success == true)
            {
                MessageBox.Show("Not Available Time successfully updated!");

                //Load SetNotAvailableTime data on data gridview
                DataTable dtNAT = snat.displaySetNotAvailableTimeData();
                dgvSNAT.DataSource = dtNAT;

                //calling clear TimeSlot fields method
                clearSetNotAvailableTimeFields();


            }
            else
            {
                MessageBox.Show("Failed to update Not Available Time...");
            }
        }


        //Reset SetNotAvailableTime data 
        private void button2_Click(object sender, EventArgs e)
        {
            //calling clear RoomNonReservableTime fields method
            clearSetNotAvailableTimeFields();
        }


        //Delete method
        private void button4_Click(object sender, EventArgs e)
        {
            snat.NATID = int.Parse(NATID);
            bool success = snat.deleteNotAvailableTime(snat);

            if (success == true)
            {
                MessageBox.Show("Not Available Time successfully deleted!");

                //Load SetNotAvailableTime data on data gridview
                DataTable dtNAT = snat.displaySetNotAvailableTimeData();
                dgvSNAT.DataSource = dtNAT;

                //calling clear TimeSlot fields method
                clearSetNotAvailableTimeFields();
            }
            else
            {
                MessageBox.Show("Failed to delete Not Available Time...");
            }
        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Search method
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NotAvailableTime WHERE Type LIKE '%"+keyword+"%' OR Value LIKE '%"+keyword+"%' OR Day LIKE '%"+keyword+"%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSNAT.DataSource = dt;
        }
    }
}

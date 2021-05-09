using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021.Working_days_and_hours
{
    public partial class ManageWDH : Form
    {

        //variables
        public string passedEmployeeID, tableEmployeeID;
        public int WorkingDaysID, WTPerDayID, TimeSlotID;



        //overloading constructor
        public ManageWDH(string EmployeeID)
        {
            InitializeComponent();
            passedEmployeeID = EmployeeID;
        }



        //Creating objects from the classes
        TimeSlot ts = new TimeSlot();
        WTPerDay wtpd = new WTPerDay();
        WorkingDays wd = new WorkingDays();
        SelectLecturerForm sl = new SelectLecturerForm();
        has_lecturer_workingDays_WTPerDay_Timeslot h = new has_lecturer_workingDays_WTPerDay_Timeslot();






        private void dgvTimeSlots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        // ------------------------ Homepage navigation -----------------------------


        private void btnHomeMWD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void btnHomeWTPerDay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void btnHomeTimeSlots_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }



        // ------------------------ Loading page data -----------------------------


        private void ManageWDH_Load(object sender, EventArgs e)
        {
            //Load time slots data on data gridview
            DataTable dtTS = ts.displayTimeSlotsData();
            dgvTimeSlots.DataSource = dtTS;

            //Load working time per day data on data gridview
            DataTable dtWTPerDay = wtpd.displayWTPerDayData();
            dgvWTPerDay.DataSource = dtWTPerDay;

            //Load working days per day data on data gridview
            DataTable dtWD = wd.displayWorkingDaysData();
            dgvMWD.DataSource = dtWD;

        }





        // ---------------------------- Time slots tab ----------------------------------


        //Insert data
        private void btnAddTimeSlots_Click(object sender, EventArgs e)
        {

            if ((txtBoxStartTime.Text != string.Empty) && (txtBoxEndTime.Text != string.Empty) && (cmbTimeSlot.Text != string.Empty))
            {
                //Getting values from the input fields
                ts.StartingTime = txtBoxStartTime.Text;
                ts.EndingTime = txtBoxEndTime.Text;
                ts.TimeSlots = cmbTimeSlot.Text;

                //Inserting data to db
                int TimeSlotID = ts.insertTimeSlots(ts);

                if (TimeSlotID > 0)
                {
                    MessageBox.Show("New time slot successfully added!");

                    //calling clear TimeSlot fields method
                    clearTimeSlotFields();

                }
                else
                {
                    MessageBox.Show("Failed to insert time slot to database...");
                }

                //Load time slots data on data gridview
                DataTable dtTS = ts.displayTimeSlotsData();
                dgvTimeSlots.DataSource = dtTS;





                // ---------------------------- Adding data to reference table ----------------------------------


                if(TSID == null || TSID == "" || TSID == " ")
                {                 
                    //inserting data
                    tableEmployeeID = passedEmployeeID;

                    h.EmployeeID = tableEmployeeID;
                    h.WDID = WorkingDaysID;
                    h.WTPDID = WTPerDayID;
                    h.TSID = TimeSlotID;

                    //Inserting data to db
                    h.insertHas_lecturer_workingDays_WTPerDay_Timeslot(h);
                }
                else
                {
                    //inserting data
                    tableEmployeeID = passedEmployeeID;
                    int tableWDID = int.Parse(WDID);
                    int tableWTPDID = int.Parse(WTPDID);
                    int tableTSID = int.Parse(TSID);

                    h.EmployeeID = tableEmployeeID;
                    h.WDID = tableWDID;
                    h.WTPDID = tableWTPDID;
                    h.TSID = tableTSID;

                    //Inserting data to db
                    h.insertHas_lecturer_workingDays_WTPerDay_Timeslot(h);
                }
                



            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgvMWD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        string TSID;

        //Retrieving data from the selected row and filled with textboxes
        private void dgvTimeSlots_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data gridview and load it into the textboxes
            int rowIndex = e.RowIndex;
            txtBoxStartTime.Text = dgvTimeSlots.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxEndTime.Text = dgvTimeSlots.Rows[rowIndex].Cells[2].Value.ToString();
            cmbTimeSlot.Text = dgvTimeSlots.Rows[rowIndex].Cells[3].Value.ToString();

            TSID = dgvTimeSlots.Rows[rowIndex].Cells[0].Value.ToString();
        }



        //Edit data
        private void btnEditTimeSlots_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            ts.TSID = int.Parse(TSID);
            ts.StartingTime = txtBoxStartTime.Text;
            ts.EndingTime = txtBoxEndTime.Text;
            ts.TimeSlots = cmbTimeSlot.Text;

            //Update data in db
            bool success = ts.updateTimeSlots(ts);

            if(success == true)
            {
                MessageBox.Show("Time slot successfully updated!");

                //Load time slots data on data gridview
                DataTable dtTS = ts.displayTimeSlotsData();
                dgvTimeSlots.DataSource = dtTS;

                //calling clear TimeSlot fields method
                clearTimeSlotFields();


            }
            else
            {
                MessageBox.Show("Failed to update time slot...");
            }
        }




        //Reset data
        private void btnResetTimeSlots_Click(object sender, EventArgs e)
        {
            //calling clear TimeSlot fields method
            clearTimeSlotFields();
        }


        //Delete data
        private void btnDeleteTimeSlots_Click(object sender, EventArgs e)
        {
            ts.TSID = int.Parse(TSID);
            bool success = ts.deleteTimeSlots(ts);

            if(success == true)
            {
                MessageBox.Show("Time slot successfully deleted!");

                //Load data on data gridview
                DataTable dt = ts.displayTimeSlotsData();
                dgvTimeSlots.DataSource = dt;

                //calling clear TimeSlot fields method
                clearTimeSlotFields();
            }
            else
            {
                MessageBox.Show("Failed to delete time slot...");
            }
        }


        //Method to clear TimeSlots fields
        public void clearTimeSlotFields()
        {
            txtBoxStartTime.Text = "";
            txtBoxEndTime.Text = "";
            cmbTimeSlot.Text = "";
        }



        

        // ------------------------ Working time per day tab -----------------------------



        //Insert data
        private void btnAddWTPerDay_Click(object sender, EventArgs e)
        {
            if ((numericUpDownHoursWTPerDay.Text != string.Empty) && (numericUpDownMinutesWTPerDay.Text != string.Empty))
            {
                //Getting values from the input fields
                wtpd.WTHours = int.Parse(numericUpDownHoursWTPerDay.Text);
                wtpd.WTMinutes = int.Parse(numericUpDownMinutesWTPerDay.Text);

                //Inserting data to db
                WTPerDayID = wtpd.insertWTPerDay(wtpd);

                if (WTPerDayID > 0)
                {
                    MessageBox.Show("New record successfully added!");

                    //calling clear WTPerDay fields method
                    clearWTPerDayFields();

                }
                else
                {
                    MessageBox.Show("Failed to insert record to database...");
                }

                //Load WTPerDay data on data gridview
                DataTable dtWTPerDay = wtpd.displayWTPerDayData();
                dgvWTPerDay.DataSource = dtWTPerDay;
            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        string WTPDID;


        //Retrieving data from the selected row and filled with numericUpAndDown
        private void dgvWTPerDay_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data gridview and load it into the textboxes
            int rowIndex = e.RowIndex;
            numericUpDownHoursWTPerDay.Text = dgvWTPerDay.Rows[rowIndex].Cells[1].Value.ToString();
            numericUpDownMinutesWTPerDay.Text = dgvWTPerDay.Rows[rowIndex].Cells[2].Value.ToString();

            WTPDID = dgvWTPerDay.Rows[rowIndex].Cells[0].Value.ToString();
        }


        //Edit data
        private void btnEditWTPerDay_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            wtpd.WTPDID = int.Parse(WTPDID);
            wtpd.WTHours = int.Parse(numericUpDownHoursWTPerDay.Text);
            wtpd.WTMinutes = int.Parse(numericUpDownMinutesWTPerDay.Text);


            //Update data in db
            bool success = wtpd.updateWTPerDay(wtpd);

            if (success == true)
            {
                MessageBox.Show("Time slot successfully updated!");

                //Load time slots data on data gridview
                DataTable dtWTPerDay = wtpd.displayWTPerDayData();
                dgvWTPerDay.DataSource = dtWTPerDay;

                //calling clear TimeSlot fields method
                clearWTPerDayFields();


            }
            else
            {
                MessageBox.Show("Failed to update time slot...");
            }
        }


        //Delete data
        private void btnDeleteWTPerDay_Click_1(object sender, EventArgs e)
        {
            wtpd.WTPDID = int.Parse(WTPDID);
            bool success = wtpd.deleteWTPerDay(wtpd);

            if (success == true)
            {
                MessageBox.Show("Time slot successfully deleted!");

                //Load data on data gridview
                DataTable dtWTPerDay = wtpd.displayWTPerDayData();
                dgvWTPerDay.DataSource = dtWTPerDay;

                //calling clear TimeSlot fields method
                clearWTPerDayFields();
            }
            else
            {
                MessageBox.Show("Failed to delete time slot...");
            }
        }


        //Reset data
        private void btnResetWTPerDay_Click_1(object sender, EventArgs e)
        {
            //calling clear TimeSlot fields method
            clearWTPerDayFields();
        }



        //Method to clear Working time per day fields
        public void clearWTPerDayFields()
        {
            numericUpDownHoursWTPerDay.Text = "";
            numericUpDownMinutesWTPerDay.Text = "";
        }





        // ---------------------------- Working days tab ----------------------------------

        

        //Insert data
        private void btnAddMWD_Click(object sender, EventArgs e)
        {
            if ((numericUpDownMWD.Text != string.Empty) && ((chkboxMonday.Checked) || (chkboxTuesday.Checked) || (chkboxWednesday.Checked) || (chkboxThursday.Checked) || (chkboxFriday.Checked) || (chkboxSaturday.Checked) || (chkboxSunday.Checked)))
            {

                string monday = "";
                string tuesday = "";
                string wednesday = "";
                string thursday = "";
                string friday = "";
                string saturday = "";
                string sunday = "";

                if (chkboxMonday.Checked)
                    monday = "Monday";
                else
                    monday = "---";

                if (chkboxTuesday.Checked)
                    tuesday = "Tuesday";
                else
                    tuesday = "---";

                if (chkboxWednesday.Checked)
                    wednesday = "Wednesday";
                else
                    wednesday = "---";

                if (chkboxThursday.Checked)
                    thursday = "Thursday";
                else
                    thursday = "---";

                if (chkboxFriday.Checked)
                    friday = "Friday";
                else
                    friday = "---";

                if (chkboxSaturday.Checked)
                    saturday = "Saturday";
                else
                    saturday = "---";

                if (chkboxSunday.Checked)
                    sunday = "Sunday";
                else
                    sunday = "---";


                //Getting values from the input fields
                wd.NumberOfWorkingDays = int.Parse(numericUpDownMWD.Text);
                wd.Day1 = monday;
                wd.Day2 = tuesday;
                wd.Day3 = wednesday;
                wd.Day4 = thursday;
                wd.Day5 = friday;
                wd.Day6 = saturday;
                wd.Day7 = sunday;

                //Inserting data to db
                WorkingDaysID = wd.insertWorkingDays(wd);

                if (WorkingDaysID > 0)
                {
                    MessageBox.Show("New record successfully added!");

                    //calling clear WTPerDay fields method
                    clearWorkingDaysFields();

                }
                else
                {
                    MessageBox.Show("Failed to insert record to database...");
                }

                //Load working days per day data on data gridview
                DataTable dtWD = wd.displayWorkingDaysData();
                dgvMWD.DataSource = dtWD;
            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        string WDID;


        //Retrieving data from the selected row and filled with checkboxes
        private void dgvMWD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data gridview and load it into the textboxes
            int rowIndex = e.RowIndex;
            numericUpDownMWD.Text = dgvMWD.Rows[rowIndex].Cells[1].Value.ToString();

            if(dgvMWD.Rows[rowIndex].Cells[2].Value.ToString() != "---")
                chkboxMonday.Checked = true;
            else
                chkboxMonday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[3].Value.ToString() != "---")
                chkboxTuesday.Checked = true;
            else
                chkboxTuesday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[4].Value.ToString() != "---")
                chkboxWednesday.Checked = true;
            else
                chkboxWednesday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[5].Value.ToString() != "---")
                chkboxThursday.Checked = true;
            else
                chkboxThursday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[6].Value.ToString() != "---")
                chkboxFriday.Checked = true;
            else
                chkboxFriday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[7].Value.ToString() != "---")
                chkboxSaturday.Checked = true;
            else
                chkboxSaturday.Checked = false;

            if (dgvMWD.Rows[rowIndex].Cells[8].Value.ToString() != "---")
                chkboxSunday.Checked = true;
            else
                chkboxSunday.Checked = false;

            WDID = dgvMWD.Rows[rowIndex].Cells[0].Value.ToString();
        }


        //Edit data
        private void btnEditMWD_Click(object sender, EventArgs e)
        {
            string monday = "";
            string tuesday = "";
            string wednesday = "";
            string thursday = "";
            string friday = "";
            string saturday = "";
            string sunday = "";

            if (chkboxMonday.Checked)
                monday = "Monday";
            else
                monday = "---";

            if (chkboxTuesday.Checked)
                tuesday = "Tuesday";
            else
                tuesday = "---";

            if (chkboxWednesday.Checked)
                wednesday = "Wednesday";
            else
                wednesday = "---";

            if (chkboxThursday.Checked)
                thursday = "Thursday";
            else
                thursday = "---";

            if (chkboxFriday.Checked)
                friday = "Friday";
            else
                friday = "---";

            if (chkboxSaturday.Checked)
                saturday = "Saturday";
            else
                saturday = "---";

            if (chkboxSunday.Checked)
                sunday = "Sunday";
            else
                sunday = "---";

            //Get data from textboxes
            wd.WDID = int.Parse(WDID);
            wd.NumberOfWorkingDays = int.Parse(numericUpDownMWD.Text);
            wd.Day1 = monday;
            wd.Day2 = tuesday;
            wd.Day3 = wednesday;
            wd.Day4 = thursday;
            wd.Day5 = friday;
            wd.Day6 = saturday;
            wd.Day7 = sunday;


            //Update data in db
            bool success = wd.updateWorkingDays(wd);

            if (success == true)
            {
                MessageBox.Show("Record successfully updated!");

                //Load working days per day data on data gridview
                DataTable dtWD = wd.displayWorkingDaysData();
                dgvMWD.DataSource = dtWD;

                //calling clear WTPerDay fields method
                clearWorkingDaysFields();


            }
            else
            {
                MessageBox.Show("Failed to update time slot...");
            }
        }


        //Delete data
        private void btnDeleteMWD_Click(object sender, EventArgs e)
        {
            wd.WDID = int.Parse(WDID);
            bool success = wd.deleteWorkingDays(wd);

            if (success == true)
            {
                MessageBox.Show("Record successfully deleted!");

                //Load working days per day data on data gridview
                DataTable dtWD = wd.displayWorkingDaysData();
                dgvMWD.DataSource = dtWD;

                //calling clear WTPerDay fields method
                clearWorkingDaysFields();
            }
            else
            {
                MessageBox.Show("Failed to delete...");
            }
        }


        //Reset data
        private void btnResetMWD_Click(object sender, EventArgs e)
        {
            //calling clear WorkingDays fields method
            clearWorkingDaysFields();
        }



        //Method to clear Working days fields
        public void clearWorkingDaysFields()
        {
            numericUpDownMWD.Text = "5";
            chkboxMonday.Checked = false;
            chkboxTuesday.Checked = false;
            chkboxWednesday.Checked = false;
            chkboxThursday.Checked = false;
            chkboxFriday.Checked = false;
            chkboxSaturday.Checked = false;
            chkboxSunday.Checked = false;
        }


    }
}

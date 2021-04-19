using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_System_2021.Working_days_and_hours
{
    class has_lecturer_workingDays_WTPerDay_Timeslot
    {
        public string EmployeeID { get; set; }
        public int WDID { get; set; }
        public int WTPDID { get; set; }
        public int TSID { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;



        //Inserting has_lecturer_workingDays_WTPerDay_Timeslot data into db
        public void insertHas_lecturer_workingDays_WTPerDay_Timeslot(has_lecturer_workingDays_WTPerDay_Timeslot h)
        {

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO has_lecturer_workingDays_WTPerDay_Timeslot (EmployeeID, WDID, WTPDID, TSID) VALUES (@EmployeeID, @WDID, @WTPDID, @TSID)";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@EmployeeID", h.EmployeeID);
                cmd.Parameters.AddWithValue("@WDID", h.WDID);
                cmd.Parameters.AddWithValue("@WTPDID", h.WTPDID);
                cmd.Parameters.AddWithValue("@TSID", h.TSID);


                //Open connection
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }

        }
    }
}

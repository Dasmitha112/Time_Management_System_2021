using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_System_2021.Working_days_and_hours
{
    class TimeSlot
    {
        public int TSID { get; set; }
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public string TimeSlots { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        public int ID;


        //Selecting TimeSlots data from database
        public DataTable displayTimeSlotsData()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT * FROM TimeSlot";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Inserting TimeSlots data into db
        public int insertTimeSlots(TimeSlot ts)
        {

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO TimeSlot (StartingTime, EndingTime, TimeSlots) VALUES (@StartingTime, @EndingTime, @TimeSlots); SELECT SCOPE_IDENTITY()";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.CommandType = CommandType.Text;


                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@StartingTime", ts.StartingTime);
                cmd.Parameters.AddWithValue("@EndingTime", ts.EndingTime);
                cmd.Parameters.AddWithValue("@TimeSlots", ts.TimeSlots);

                //Open connection
                conn.Open();
                ID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return ID;

        }


        //Updating TimeSlots data in db
        public bool updateTimeSlots(TimeSlot ts)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "UPDATE TimeSlot SET StartingTime=@StartingTime, EndingTime=@EndingTime, TimeSlots=@TimeSlots WHERE TSID=@TSID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@TSID", ts.TSID);
                cmd.Parameters.AddWithValue("@StartingTime", ts.StartingTime);
                cmd.Parameters.AddWithValue("@EndingTime", ts.EndingTime);
                cmd.Parameters.AddWithValue("@TimeSlots", ts.TimeSlots);

                //Open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }


        //Deleting TimeSlots data in db
        public bool deleteTimeSlots(TimeSlot ts)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "DELETE FROM TimeSlot WHERE TSID=@TSID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@TSID", ts.TSID);

                //Open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

    }
}

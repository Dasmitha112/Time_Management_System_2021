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
    class WorkingDays
    {
        public int WDID { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Day3 { get; set; }
        public string Day4 { get; set; }
        public string Day5 { get; set; }
        public string Day6 { get; set; }
        public string Day7 { get; set; }



        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        public int ID;


        //Selecting TimeSlots data from database
        public DataTable displayWorkingDaysData()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                //string sql = "SELECT wd.WDID, l.LecturerName, wd.NumberOfWorkingDays, wd.Day1, wd.Day2, wd.Day3, wd.Day4, wd.Day5, wd.Day6, wd.Day7 FROM WorkingDays wd, Lecturer l, has_lecturer_WorkingDays_WTPerDay_Timeslot h where h.WDID=wd.WDID AND h.EmployeeID=l.EmployeeID";
                string sql = "SELECT * FROM WorkingDays";


                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Inserting WorkingDays data into db
        public int insertWorkingDays(WorkingDays wd)
        {      

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO WorkingDays (NumberOfWorkingDays, Day1, Day2, Day3, Day4, Day5, Day6, Day7) VALUES (@NumberOfWorkingDays, @Day1, @Day2, @Day3, @Day4, @Day5, @Day6, @Day7); SELECT SCOPE_IDENTITY()";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.Text;

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", wd.NumberOfWorkingDays);
                cmd.Parameters.AddWithValue("@Day1", wd.Day1);
                cmd.Parameters.AddWithValue("@Day2", wd.Day2);
                cmd.Parameters.AddWithValue("@Day3", wd.Day3);
                cmd.Parameters.AddWithValue("@Day4", wd.Day4);
                cmd.Parameters.AddWithValue("@Day5", wd.Day5);
                cmd.Parameters.AddWithValue("@Day6", wd.Day6);
                cmd.Parameters.AddWithValue("@Day7", wd.Day7);

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




        //Updating WorkingDays data in db
        public bool updateWorkingDays(WorkingDays wd)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "UPDATE WorkingDays SET NumberOfWorkingDays=@NumberOfWorkingDays, Day1=@Day1, Day2=@Day2, Day3=@Day3, Day4=@Day4, Day5=@Day5, Day6=@Day6, Day7=@Day7 WHERE WDID=@WDID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@WDID", wd.WDID);
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", wd.NumberOfWorkingDays);
                cmd.Parameters.AddWithValue("@Day1", wd.Day1);
                cmd.Parameters.AddWithValue("@Day2", wd.Day2);
                cmd.Parameters.AddWithValue("@Day3", wd.Day3);
                cmd.Parameters.AddWithValue("@Day4", wd.Day4);
                cmd.Parameters.AddWithValue("@Day5", wd.Day5);
                cmd.Parameters.AddWithValue("@Day6", wd.Day6);
                cmd.Parameters.AddWithValue("@Day7", wd.Day7);

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


        //Deleting WorkingDays data in db
        public bool deleteWorkingDays(WorkingDays wd)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "DELETE FROM WorkingDays WHERE WDID=@WDID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@WDID", wd.WDID);

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

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
    class WTPerDay
    {
        public int WTPDID { get; set; }
        public int WTHours { get; set; }
        public int WTMinutes { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        public int ID;


        //Selecting TimeSlots data from database
        public DataTable displayWTPerDayData()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT * FROM WTPerDay";

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


        //Inserting WTPerDay data into db
        public int insertWTPerDay(WTPerDay wtpd)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO WTPerDay (WTHours, WTMinutes) VALUES (@WTHours, @WTMinutes); SELECT SCOPE_IDENTITY()";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.CommandType = CommandType.Text;


                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@WTHours", wtpd.WTHours);
                cmd.Parameters.AddWithValue("@WTMinutes", wtpd.WTMinutes);

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


        //Updating WTPerDay data in db
        public bool updateWTPerDay(WTPerDay wtpd)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "UPDATE WTPerDay SET WTHours=@WTHours, WTMinutes=@WTMinutes WHERE WTPDID=@WTPDID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@WTPDID", wtpd.WTPDID);
                cmd.Parameters.AddWithValue("@WTHours", wtpd.WTHours);
                cmd.Parameters.AddWithValue("@WTMinutes", wtpd.WTMinutes);

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


        //Deleting WTPerDay data in db
        public bool deleteWTPerDay(WTPerDay wtpd)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "DELETE FROM WTPerDay WHERE WTPDID=@WTPDID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@WTPDID", wtpd.WTPDID);

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

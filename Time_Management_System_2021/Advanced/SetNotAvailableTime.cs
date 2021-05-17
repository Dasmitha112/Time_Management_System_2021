using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_System_2021.Advanced
{
    class SetNotAvailableTime
    {

        public int NATID { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }



        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public int ID;



        // ------------------------------- Methods to retrieve specific data according to the type given ----------------------------------- 


        public DataSet displayLecturers()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet ds = new DataSet();

            try
            {
                //sql query
                string sql = "SELECT * FROM Lecturer";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(ds);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return ds;
        }


        public DataSet displaySessions()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet ds = new DataSet();

            try
            {
                //sql query
                string sql = "SELECT * FROM Sessions";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(ds);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public DataSet displayGroups()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet ds = new DataSet();

            try
            {
                //sql query
                string sql = "SELECT * FROM Student";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(ds);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return ds;
        }


        //--------------------------------- Methods ends ------------------------------------------------------------










        //Selecting SetNotAvailableTime data from database
        public DataTable displaySetNotAvailableTimeData()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT * FROM NotAvailableTime";

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


        //Inserting NotAvailableTime data into db
        public int insertNotAvailableTime(SetNotAvailableTime snat)
        {

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO NotAvailableTime (Type, Value, Day, StartTime, EndTime) VALUES (@Type, @Value, @Day, @StartTime, @EndTime); SELECT SCOPE_IDENTITY()";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.CommandType = CommandType.Text;


                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@Type", snat.Type);
                cmd.Parameters.AddWithValue("@Value", snat.Value);
                cmd.Parameters.AddWithValue("@Day", snat.Day);
                cmd.Parameters.AddWithValue("@StartTime", snat.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", snat.EndTime);

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


        //Updating NotAvailableTime data in db
        public bool updateNotAvailableTime(SetNotAvailableTime snat)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "UPDATE NotAvailableTime SET Type=@Type, Value=@Value, Day=@Day, StartTime=@StartTime, EndTime=@EndTime WHERE NATID=@NATID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@NATID", snat.NATID);
                cmd.Parameters.AddWithValue("@Type", snat.Type);
                cmd.Parameters.AddWithValue("@Value", snat.Value);
                cmd.Parameters.AddWithValue("@Day", snat.Day);
                cmd.Parameters.AddWithValue("@StartTime", snat.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", snat.EndTime);

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


        //Deleting NotAvailableTime data in db
        public bool deleteNotAvailableTime(SetNotAvailableTime snat)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "DELETE FROM NotAvailableTime WHERE NATID=@NATID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@NATID", snat.NATID);

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

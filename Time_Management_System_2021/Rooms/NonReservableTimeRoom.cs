using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_System_2021.Rooms
{
    class NonReservableTimeRoom
    {

        public int NonReservableID { get; set; }
        public string Room_name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Day { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public int ID;


        //Method to retrieve Room names from the db
        public DataSet displayRooms()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet ds = new DataSet();

            try
            {
                //sql query
                string sql = "SELECT * FROM building";

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


        //Selecting RoomNonReservableTime data from database
        public DataTable displayRoomNonReservableTimeData()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT * FROM RoomNonReservableTime";

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


        //Inserting RoomNonReservableTime data into db
        public int insertRoomNonReservableTime(NonReservableTimeRoom nrtr)
        {

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "INSERT INTO RoomNonReservableTime (Room_name, StartTime, EndTime, Day) VALUES (@Room_name, @StartTime, @EndTime, @Day); SELECT SCOPE_IDENTITY()";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.CommandType = CommandType.Text;


                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@Room_name", nrtr.Room_name);
                cmd.Parameters.AddWithValue("@StartTime", nrtr.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", nrtr.EndTime);
                cmd.Parameters.AddWithValue("@Day", nrtr.Day);

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


        //Updating RoomNonReservableTime data in db
        public bool updateRoomNonReservableTime(NonReservableTimeRoom nrtr)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "UPDATE RoomNonReservableTime SET Room_name=@Room_name, StartTime=@StartTime, EndTime=@EndTime, Day=@Day WHERE NonReservableID=@NonReservableID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@NonReservableID", nrtr.NonReservableID);
                cmd.Parameters.AddWithValue("@Room_name", nrtr.Room_name);
                cmd.Parameters.AddWithValue("@StartTime", nrtr.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", nrtr.EndTime);
                cmd.Parameters.AddWithValue("@Day", nrtr.Day);

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


        //Deleting RoomNonReservableTime data in db
        public bool deleteRoomNonReservableTime(NonReservableTimeRoom nrtr)
        {
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //sql query
                string sql = "DELETE FROM RoomNonReservableTime WHERE NonReservableID=@NonReservableID";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@NonReservableID", nrtr.NonReservableID);

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

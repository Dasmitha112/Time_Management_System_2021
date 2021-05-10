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
    class SelectLecturer
    {

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

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
    }
}

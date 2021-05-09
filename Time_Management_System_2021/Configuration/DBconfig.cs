using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Time_Management_System_2021.Configuration
{
     class DBconfig
    {
          public static SqlConnection con = new SqlConnection("Server=tcp:timemanagementsystem-server.database.windows.net,1433;Initial Catalog=TimeManagementSystem_DB;Persist Security Info=False;User ID=myadmin;Password=myServer01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        /*
       Use this as
       SqlConnection con = Config.con;
       In your class
       make sure to import SqlClient as
       using System.Data.SqlClient;
       */
    }
}

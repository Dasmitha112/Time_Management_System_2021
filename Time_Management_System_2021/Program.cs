using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Lecturers;
using Time_Management_System_2021.Sessions;
using Time_Management_System_2021.Working_days_and_hours;

namespace Time_Management_System_2021
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Generalpage());

        }
    }
}

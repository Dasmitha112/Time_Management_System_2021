﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.student;
using Time_Management_System_2021.tag;

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
       
           Application.Run(new AddStudent());
            Application.Run(new AddTag());

        }
    }
}

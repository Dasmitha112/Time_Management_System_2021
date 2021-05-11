using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Lecturers;
using Time_Management_System_2021.Working_days_and_hours;

namespace Time_Management_System_2021
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public int TimetableType;

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLecturerForm slf = new SelectLecturerForm();
            slf.ShowDialog();

        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLecturerForm alf = new AddLecturerForm();
            alf.ShowDialog();

        }
    }
}

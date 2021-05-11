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
using Time_Management_System_2021.Location;
using Time_Management_System_2021.student;
using Time_Management_System_2021.Subjects;
using Time_Management_System_2021.tag;
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

        private void btnModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjectForm asf = new AddSubjectForm();
            asf.ShowDialog();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent atf = new AddStudent();
            atf.ShowDialog();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTag agf = new AddTag();
            agf.ShowDialog();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Advanced;
using Time_Management_System_2021.Lecturers;
using Time_Management_System_2021.Location;
using Time_Management_System_2021.Rooms;
using Time_Management_System_2021.Sessions;
using Time_Management_System_2021.Statistics;
using Time_Management_System_2021.student;
using Time_Management_System_2021.Subjects;
using Time_Management_System_2021.tag;
using Time_Management_System_2021.Working_days_and_hours;

namespace Time_Management_System_2021
{
    public partial class Homepage : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthElipse,
            int nHeightElipse
        );


        public Homepage()
        {
            InitializeComponent();
        }

        public int TimetableType;

        private void Homepage_Load(object sender, EventArgs e)
        {
            btnLecturer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLecturer.Width, btnLecturer.Height, 20, 20));
            btnStudent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStudent.Width, btnStudent.Height, 20, 20));
            btnModule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModule.Width, btnModule.Height, 20, 20));
            btnTags.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTags.Width, btnTags.Height, 20, 20));
            btnLocations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLocations.Width, btnLocations.Height, 20, 20));
            btnRooms.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRooms.Width, btnRooms.Height, 20, 20));
            btnStatistics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStatistics.Width, btnStatistics.Height, 20, 20));
            btnWDH.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnWDH.Width, btnWDH.Height, 20, 20));
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

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static s = new Static();
            s.ShowDialog();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSessionForm alf = new AddSessionForm();
            alf.ShowDialog();

        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRoom rlf = new ManageRoom();
            rlf.ShowDialog();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvailableTime nat = new NotAvailableTime();
            nat.ShowDialog();
        }
    }
}

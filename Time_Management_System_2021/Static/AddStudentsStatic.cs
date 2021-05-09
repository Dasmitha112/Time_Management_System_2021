using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021.Static
{
    public partial class AddStudentsStatic : Form
    {
        public AddStudentsStatic()
        {
            InitializeComponent();
        }

        private void cha1_Click(object sender, EventArgs e)
        {
            this.chart2.Series["Students"].Points.AddXY("1 st year",1800);
            this.chart2.Series["Students"].Points.AddXY("2 st year", 1456);
            this.chart2.Series["Students"].Points.AddXY("3 st year", 1278);
            this.chart2.Series["Students"].Points.AddXY("4 st year", 988);
        }

        private void chart2_Click(object sender, EventArgs e)
        {
           /* this.chart2.Series["Subjects"].Points.AddXY("1 st year", 5);
            this.chart2.Series["Subjects"].Points.AddXY("2 st year", 4);
            this.chart2.Series["Subjects"].Points.AddXY("3 st year", 4);
            this.chart2.Series["Subjects"].Points.AddXY("4 st year", 3);*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {
           /* this.chart3.Series["Subjects"].Points.AddXY("1 st year", 5);
            this.chart3.Series["Subjects"].Points.AddXY("2 st year", 4);
            this.chart3.Series["Subjects"].Points.AddXY("3 st year", 4);
            this.chart3.Series["Subjects"].Points.AddXY("4 st year", 3);*/
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadChart_Click(object sender, EventArgs e)
        {
            this.chart3.Series["Subjects"].Points.AddXY("1 st year", 5);
            this.chart3.Series["Subjects"].Points.AddXY("2 st year", 4);
            this.chart3.Series["Subjects"].Points.AddXY("3 st year", 4);
            this.chart3.Series["Subjects"].Points.AddXY("4 st year", 3);
        }

        private void LoadChar2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Lectures"].Points.AddXY("1 st year", 25);
            this.chart1.Series["Lectures"].Points.AddXY("2 st year", 20);
            this.chart1.Series["Lectures"].Points.AddXY("3 st year", 22);
            this.chart1.Series["Lectures"].Points.AddXY("4 st year", 30);
        }
    }
}

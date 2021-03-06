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

namespace Time_Management_System_2021.Statistics
{
    public partial class Static : Form
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

        public Static()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Lecturer"].Points.AddXY("1 st year", 25);
            this.chart1.Series["Lecturer"].Points.AddXY("2 nd year", 20);
            this.chart1.Series["Lecturer"].Points.AddXY("3 rd year", 22);
            this.chart1.Series["Lecturer"].Points.AddXY("4 th year", 30);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart2.Series["Student"].Points.AddXY("1 st year", 25);
            this.chart2.Series["Student"].Points.AddXY("2 nd year", 20);
            this.chart2.Series["Student"].Points.AddXY("3 rd year", 22);
            this.chart2.Series["Student"].Points.AddXY("4 th year", 30);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Static_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
        }
    }
}

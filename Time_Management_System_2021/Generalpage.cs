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

namespace Time_Management_System_2021
{
    public partial class Generalpage : Form
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


        public Generalpage()
        {
            InitializeComponent();
        }

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void Generalpage_Load(object sender, EventArgs e)
        {

            btnGetStart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGetStart.Width, btnGetStart.Height, 20, 20));

        }
    }
}

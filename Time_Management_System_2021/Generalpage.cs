﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021
{
    public partial class Generalpage : Form
    {
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
    }
}
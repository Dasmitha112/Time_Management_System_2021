using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021.Working_days_and_hours
{
    public partial class SelectLecturerForm : Form
    {
        public SelectLecturerForm()
        {
            InitializeComponent();
        }


        SelectLecturer sl = new SelectLecturer();
        public string EmployeeID;



        //Loading page data
        private void SelectLecturerForm_Load(object sender, EventArgs e)
        {
            DataSet ds = sl.displayLecturers();
            cmbBoxSelectLecturerInForm.DataSource = ds.Tables[0];
            cmbBoxSelectLecturerInForm.DisplayMember = "LecturerName";
            cmbBoxSelectLecturerInForm.ValueMember = "EmployeeID";

            
        }


        //Select button
        private void btnSelectLecturerInForm_Click(object sender, EventArgs e)
        {

            //Retrieving user selected ID value
            EmployeeID = cmbBoxSelectLecturerInForm.SelectedValue.ToString();

            this.Hide();
            ManageWDH mwdh = new ManageWDH(EmployeeID);
            mwdh.ShowDialog();

        }


        //Cancel button
        private void btnCancelInForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }
    }
}

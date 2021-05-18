using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;

namespace Time_Management_System_2021.Location
{
    public partial class location : Form
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



        public location()
        {
            InitializeComponent();
            GetDisplay();
        }
        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;

        public int LocID;
        private bool IsValid()
        {


            if ((AddNewBuilding.Text == string.Empty) || (comboBox1.Text == string.Empty) || (AddNewRoom.Text == string.Empty) || (Capa.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
            throw new NotImplementedException();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO building(Location_name,Room_type,Room_name,Capacity) VALUES (@Location_name,@Room_type,@Room_name,@Capacity)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Location_name", AddNewBuilding.Text);
                cmd.Parameters.AddWithValue("@Room_type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Room_name", AddNewRoom.Text);

                cmd.Parameters.AddWithValue("@Capacity", Capa.Text);




                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("data insert Successfully", "Added Successful");

                GetDisplay();
                ClearFieldsAfterAdd();

            }
        }

        private void ClearFieldsAfterAdd()
        {
            AddNewBuilding.Clear();
            AddNewRoom.Clear();
            Capa.Clear();

            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;

            LocID = 0;
        }

        private void GetDisplay()
        {
            adpt = new SqlDataAdapter("select * from building ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            AddNewBuilding.Text = string.Empty;
            comboBox1.Text = string.Empty;
            AddNewRoom.Text = string.Empty;
            Capa.Text = string.Empty;

            MessageBox.Show("Reseted!");
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenManagestudentFormWithData(this.dataGridView1.CurrentRow);
        }

        private void OpenManagestudentFormWithData(DataGridViewRow DataGridViewRow)
        {
            TabPage tab = tabControl1.TabPages[2];
            tabControl1.SelectTab(tab);
            EditBuild.Text = DataGridViewRow.Cells[1].Value.ToString();
            comboBox2.Text = DataGridViewRow.Cells[2].Value.ToString();
            EditRoom.Text = DataGridViewRow.Cells[3].Value.ToString();
            textBox3.Text = DataGridViewRow.Cells[4].Value.ToString();

            this.LocID = Convert.ToInt32(DataGridViewRow.Cells[0].Value);
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (LocID > 0)
            {
                if (IsValidUpdate())
                {
                    //comment
                    SqlCommand cmd = new SqlCommand("UPDATE building SET Location_name = @Location_name, Room_type = @Room_type, Room_name =  @Room_name, Capacity = @Capacity WHERE LocID = @LocID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Location_name", EditBuild.Text);
                    cmd.Parameters.AddWithValue("@Room_type", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Room_name", EditRoom.Text);
                    cmd.Parameters.AddWithValue("@Capacity", textBox3.Text);

                    cmd.Parameters.AddWithValue("@LocID", this.LocID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Location Details Updated", "Successfully");

                    GetDisplay();

                    ClearFieldsUpdate();


                }
            }
            else
            {
                MessageBox.Show("Please Select a Location to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsValidUpdate()
        {
            if ((EditBuild.Text == string.Empty) || (comboBox2.Text == string.Empty) || (EditRoom.Text == string.Empty) || (textBox3.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearFieldsUpdate()
        {
            EditBuild.Clear();
            EditRoom.Clear();
            textBox3.Clear();

            comboBox2.ResetText();
            comboBox2.SelectedIndex = -1;

            LocID = 0;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (LocID > 0)
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Location details?", "Delete Student details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM building WHERE LocID = @LocID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@LocID", this.LocID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Location details are Deleted", "Successfully");

                    GetDisplay();

                    ClearFieldsUpdate();

                    //tabControlLecturers.SelectedTab = tabPageLecView;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Building to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search1_TextChanged(object sender, EventArgs e)
        {
            GetDisplay();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dataGridView1.DataSource;
            bs1.Filter = "Location_name Like '%" + Search1.Text + "%'";
            dataGridView1.DataSource = bs1;
        }

        private void topic_Click(object sender, EventArgs e)
        {

        }

        private void location_Load(object sender, EventArgs e)
        {
            Add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Add.Width, Add.Height, 20, 20));
            reset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, reset.Width, reset.Height, 20, 20));
            Update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Update.Width, Update.Height, 20, 20));
            Delete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Delete.Width, Delete.Height, 20, 20));
            Reset2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Reset2.Width, Reset2.Height, 20, 20));
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            EditBuild.Text = string.Empty;
            comboBox2.Text = string.Empty;
            EditRoom.Text = string.Empty;
            textBox3.Text = string.Empty;

            MessageBox.Show("Reseted!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

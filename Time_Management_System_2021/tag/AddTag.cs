using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Management_System_2021.Configuration;

namespace Time_Management_System_2021.tag
{
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
            GetDisplay();
        }
        SqlConnection con = DBconfig.con;
        SqlDataAdapter adpt;
        DataTable dt;

        public int TID;
        private bool IsValid()
        {


            if ((tagcode.Text == string.Empty) || (tagname.Text == string.Empty) || (relatedTag.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
            throw new NotImplementedException();
        }
        private void tagADD_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tag(Tag_name, Tag_code, Related_Tag) VALUES (@Tag_name, @Tag_code, @Related_Tag)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Tag_code", tagcode.Text);
                cmd.Parameters.AddWithValue("@Tag_name", tagname.Text);
                cmd.Parameters.AddWithValue("@Related_Tag", relatedTag.Text);



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
            tagcode.Clear();

            tagname.ResetText();
            tagname.SelectedIndex = -1;
            relatedTag.ResetText();
            relatedTag.SelectedIndex = -1;
            TID = 0;
        }

        private void GetDisplay()
        {
            adpt = new SqlDataAdapter("select * from Tag", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView_manageTag.DataSource = dt;
        }

        private void tagDelete_Click(object sender, EventArgs e)
        {
            if (TID > 0)
            {
                if (MessageBox.Show("Are You Sure You Want to Delete the Tag details?", "Delete Tag details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tag WHERE TID = @TID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@TID", this.TID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Tag details are Deleted", "Successfully");

                    GetDisplay();
                    ClearFieldsAfterAdd();




                }
            }
            else
            {
                MessageBox.Show("Please Select a Tag to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddClear_Click(object sender, EventArgs e)
        {
            tagname.Text = string.Empty;
            relatedTag.Text = string.Empty;
            tagcode.Text = string.Empty;
            MessageBox.Show("Cleared!");
        }

        private void AddTag_Load(object sender, EventArgs e)
        {

        }

        private void tagEdit_Click(object sender, EventArgs e)
        {
            if (TID > 0)
            {
                if (IsValidUpdate())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Tag SET Tag_name = @Tag_name, Tag_code = @Tag_code, Related_Tag =  @Related_Tag WHERE TID = @TID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Tag_name", tagname.Text);
                    cmd.Parameters.AddWithValue("@Tag_code", tagcode.Text);
                    cmd.Parameters.AddWithValue("@Related_Tag", relatedTag.Text);
                    cmd.Parameters.AddWithValue("@TID", this.TID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Tag Details Updated", "Successfully");

                    GetDisplay();

                    ClearFieldsUpdate();


                }
            }
            else
            {
                MessageBox.Show("Please Select a Tag Details to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsUpdate()
        {
            tagcode.Clear();

            tagname.ResetText();
            tagname.SelectedIndex = -1;
            relatedTag.ResetText();
            relatedTag.SelectedIndex = -1;
            TID = 0;
        }

        private bool IsValidUpdate()
        {
            if ((tagname.Text == string.Empty) || (relatedTag.Text == string.Empty) || (tagcode.Text == string.Empty))

            {
                MessageBox.Show("Fill the all fields in the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void dataGridView_manageTag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_manageTag.CurrentRow.Selected = true;
            tagname.Text = dataGridView_manageTag.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            tagcode.Text = dataGridView_manageTag.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            relatedTag.Text = dataGridView_manageTag.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            this.TID = Convert.ToInt32(dataGridView_manageTag.Rows[e.RowIndex].Cells[0].Value);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetDisplay();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dataGridView_manageTag.DataSource;
            bs1.Filter = "Tag_name Like '%" + textBox1.Text + "%'";
            dataGridView_manageTag.DataSource = bs1;
        }

        private void btnHomeMWD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.ShowDialog();
        }
    }
}


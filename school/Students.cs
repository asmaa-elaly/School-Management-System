using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace firsttry
{
    public partial class Students : Form
    {
        SqlConnection con = new SqlConnection("Integrated Security=true;Initial Catalog=School;Data Source=LOUAI;");
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        private void DisplayStudent()
        {
            con.Open();
            String Query = "Select * from students";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            key = 0;
            StNameTb.Text = "";
            StFeesTb.Text = "";
            StAddressTb.Text = "";
            StGenderCb.SelectedItem = 0;
            StClassCb.SelectedIndex = 0;
        }
        int key = 0;
        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StFeesTb.Text == "" || StAddressTb.Text == "" || StGenderCb.SelectedIndex == -1 || StClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into students(StName,StGen,StDOB,StClass,StFees,StAdd) values (@Sname,@Sgen,@SDOB,@SClass,@SFees,@SAdd)", con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@Sgen", StGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDOB", StDOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", StClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", StAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SFees", StFeesTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            StNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            StGenderCb.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            StDOBPicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            StClassCb.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            StFeesTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            StAddressTb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            if (StNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Student");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from students where StId=@Stkey", con);
                    cmd.Parameters.AddWithValue("@Stkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StFeesTb.Text == "" || StAddressTb.Text == "" || StGenderCb.SelectedIndex == -1 || StClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update students set StName=@Sname, StGen=@SGen,StDOB=@SDOB,StClass=@SClass,StFees=@SFees,StAdd=@SAdd where StId=@SID", con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDOB", StDOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", StClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", StAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SFees", StFeesTb.Text);
                    cmd.Parameters.AddWithValue("@SID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    DisplayStudent();
                    con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main_Menu obj = new Main_Menu();
            obj.Show();
            this.Hide();
        }
    }
}

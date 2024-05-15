using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SchoolManagementSystem

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-37HLN7S;Initial Catalog=SchoolDb;Integrated Security=True");

        private void DisplayStudent()
        {
            con.Open();
            String Query = "Select * from StudentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentesDGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StFeesTb.Text == "" || StAddressTb.Text == "" || StGendrCb.SelectedIndex == -1 || StClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTb1(StName,StGen,StDOB,StClass,StFees,StAdd) values (@Sname,@Sgen,@SDOB,@SClass,@SFees,@SAdd)", con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@Sgen", StGendrCb.SelectedItem.ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            key = 0;
            StNameTb.Text = "";
            StFeesTb.Text = "";
            StAddressTb.Text = "";
            StGendrCb.SelectedItem = 0;
            StClassCb.SelectedIndex = 0;
        }
        int key = 0;

        private void StudentesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentesDGV.SelectedRows[0].Cells[1].Value.ToString();
            StGendrCb.SelectedItem = StudentesDGV.SelectedRows[0].Cells[2].Value.ToString();
            StDOBPicker.Text = StudentesDGV.SelectedRows[0].Cells[3].Value.ToString();
            StClassCb.SelectedItem = StudentesDGV.SelectedRows[0].Cells[4].Value.ToString();
            StFeesTb.Text = StudentesDGV.SelectedRows[0].Cells[5].Value.ToString();
            StAddressTb.Text = StudentesDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (StNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StudentesDGV.SelectedRows[0].Cells[0].Value.ToString());
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
                    SqlCommand cmd = new SqlCommand("delete from StudentTb1 where StId=@Stkey", con);
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
            if (StNameTb.Text == "" || StFeesTb.Text == "" || StAddressTb.Text == "" || StGendrCb.SelectedIndex == -1 || StClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Uodate StudentTb1 set StName=@Sname, StGen=@SGen,StDOB=SDOB,StClass=SClass,StFees=SFees,StAdd=@SAdd", con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@Sgen", StGendrCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDOB", StDOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", StClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", StAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SFees", StFeesTb.Text);
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
           // MainMenu obj = new MainMenu();
            //obj.Show();
            // this.Hide();
        }
    }
}
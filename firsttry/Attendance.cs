using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firsttry
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudentID();

        }

        private void FillStudentID()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select StId from Students",con);
            SqlDataReader dr;
            dr  = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(dr);
            StID.ValueMember = "StId";
            StID.DataSource = dt;
            con.Close();

        }
        private void GetStudName()
        {
            con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Students where StId=@StId",con);
            Cmd.Parameters.AddWithValue("@StId",StID.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                StName.Text = dr["StName"].ToString();  
            }
            con.Close();
        }
        SqlConnection con = new SqlConnection("Integrated Security=true;Initial Catalog=School;Data Source=LOUAI;");
        private void DisplayAttendance()
        {
           con.Open();
            string query = "select * from AttendanceTb";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder c1 = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           con.Close();
        }
        private void Reset()
        {
            StStatus.SelectedIndex = -1;
            StName.Text = "";
            StID.Text = "";


        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StName.Text == "" || StStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info.");
            }
            else 
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTb(AttStID, AttStName, AttDate, AttStatus) values (@ID, @Name, @Date, @Status)", con);
                    cmd.Parameters.AddWithValue("@ID", StID.Text);
                    cmd.Parameters.AddWithValue("@Name", StName.Text);
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", StStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Taken.");

                    con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // some error 
            StID.SelectedValue = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            StName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Date.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            StStatus.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if(StName.Text=="")
            {
                key= 0; 
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StName.Text == "" || StStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Info.");

            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Update AttendanceTb set AttStID=@StID, AttStName=@StName, AttDate=@AttDate, AttStatus=@AttStatus where AttNum=@AttNum",con);
                cmd.Parameters.AddWithValue("@StID", StID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@StName", StName.Text);
                cmd.Parameters.AddWithValue("@AttDate",Date.Value.Date);
                cmd.Parameters.AddWithValue("@AttStatus",StStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@AttNum",key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance Updated.");
                con.Close();
                DisplayAttendance();
                Reset();

            }
        }
    }
}

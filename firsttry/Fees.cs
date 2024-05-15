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

namespace firsttry
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees(); 
            FillStudentID();

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Integrated Security=true;Initial Catalog=School;Data Source=LOUAI;");
        private void DisplayFees()
        {
            con.Open();
            string query = "select PayID,StName,Date,Amount from FeesTb";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder c1 = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            StID.SelectedIndex = -1;
            SName.Text = "";
            Amount.Text = "";


        }
        private void FillStudentID()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select StId from Students", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
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
            SqlCommand Cmd = new SqlCommand("select * from Students where StId=@StId", con);
            Cmd.Parameters.AddWithValue("@StId", StID.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SName.Text = dr["StName"].ToString();
            }
            con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
        
            if(SName.Text == ""|| Amount.Text == "")
            {
                MessageBox.Show("Missing Info.");
            }
            else
            {
                string paymentperiod;
                 paymentperiod = Date.Value.ToString("yyyy-MM") + "-01"; con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from FeesTb where StID = '" + StID.SelectedValue.ToString() + "' and Date = '" + paymentperiod.ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is no due for this month.");
                }
               else
                {
                    SqlCommand cmd = new SqlCommand("insert into FeesTb(StID, StName, Date, Amount) values (@ID, @Name, @Date, @Amount)", con);
                    cmd.Parameters.AddWithValue("@ID", StID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Name", SName.Text);
                    cmd.Parameters.AddWithValue("@Date", paymentperiod);
                    cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayFees();
                    MessageBox.Show("Fees successfully paid.");
                    Reset();
                }    
         
            }
        }

        private void StID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main_Menu obj = new Main_Menu();
            obj.Show();
            this.Hide();
        }
    }
}

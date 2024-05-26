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
    public partial class Teachers : Form
    {
        SqlConnection con = new SqlConnection("Integrated Security=true;Initial Catalog=School;Data Source=LOUAI;");

        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        private void DisplayTeachers()
        {
            con.Open();
            String Query = "Select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {

            TNameTb.Text = "";
            TPhoneTb.Text = "";
            TAddTb.Text = "";
            TGendrCb.SelectedItem = 0;
            SubjectCb.SelectedIndex = 0;
        }
        private void Teachers_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (TNameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGendrCb.SelectedIndex == -1 || SubjectCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(Tname,TGen,TDOB,TSub,TAdd,Tphone) values (@Tname,@Tgen,@TDOB,@TSub,@TAdd,@Tphone)", con);
                    cmd.Parameters.AddWithValue("@Tname", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGendrCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TSub", SubjectCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@Tphone", TPhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added.");
                    con.Close();

                    DisplayTeachers();
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

            if (TNameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGendrCb.SelectedIndex == -1 || SubjectCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update TeacherTbl set Tname=@Tname, TGen=@TGen,TDOB=@TDOB,TSub=@TSub,TPhone=@TPhone,TAdd=@TAdd where Id=@TeachID", con);
                    cmd.Parameters.AddWithValue("@Tname", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGendrCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TSub", SubjectCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TeachID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    con.Close();
                    DisplayTeachers();

                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            if (key == 0)
            {
                MessageBox.Show("Select Teacher");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeacherTbl where Id=@Tkey", con);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted");
                    con.Close();
                    DisplayTeachers();
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
        int key = 0;

                private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            TNameTb.Text = TeachersDGV.SelectedRows[0].Cells[1].Value.ToString();
            TGendrCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[2].Value.ToString();
            TPhoneTb.Text = TeachersDGV.SelectedRows[0].Cells[3].Value.ToString();
            SubjectCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[4].Value.ToString();
            TAddTb.Text = TeachersDGV.SelectedRows[0].Cells[5].Value.ToString();
            TDOB.Text = TeachersDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (TNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TeachersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
  }


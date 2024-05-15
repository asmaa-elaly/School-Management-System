using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firsttry
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

            //Dashboard Obj = new Dashboard();
            //Obj.Show();
            //this.Hide();

        }

        private void Attendance_Click(object sender, EventArgs e)
        {

            Attendance Obj = new Attendance();
            Obj.Show();
            this.Hide();

        }

        private void Teachers_Click(object sender, EventArgs e)
        {

            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

namespace firsttry
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Students = new System.Windows.Forms.PictureBox();
            this.Teachers = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.PictureBox();
            this.Fees = new System.Windows.Forms.PictureBox();
            this.Attendance = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.Image = ((System.Drawing.Image)(resources.GetObject("Students.Image")));
            this.Students.Location = new System.Drawing.Point(73, 49);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(189, 149);
            this.Students.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            this.Students.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Teachers
            // 
            this.Teachers.Image = ((System.Drawing.Image)(resources.GetObject("Teachers.Image")));
            this.Teachers.Location = new System.Drawing.Point(73, 286);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(180, 155);
            this.Teachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Teachers.TabIndex = 1;
            this.Teachers.TabStop = false;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.Location = new System.Drawing.Point(673, 173);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(188, 145);
            this.Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dashboard.TabIndex = 2;
            this.Dashboard.TabStop = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Fees
            // 
            this.Fees.Image = ((System.Drawing.Image)(resources.GetObject("Fees.Image")));
            this.Fees.Location = new System.Drawing.Point(408, 49);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(185, 149);
            this.Fees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fees.TabIndex = 3;
            this.Fees.TabStop = false;
            this.Fees.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Attendance
            // 
            this.Attendance.Image = ((System.Drawing.Image)(resources.GetObject("Attendance.Image")));
            this.Attendance.Location = new System.Drawing.Point(408, 286);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(199, 155);
            this.Attendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attendance.TabIndex = 4;
            this.Attendance.TabStop = false;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "STUDENTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEACHERS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "FEES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "ATTENDENCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "DASHBOARD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(891, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(964, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Students;
        private System.Windows.Forms.PictureBox Teachers;
        private System.Windows.Forms.PictureBox Dashboard;
        private System.Windows.Forms.PictureBox Fees;
        private System.Windows.Forms.PictureBox Attendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
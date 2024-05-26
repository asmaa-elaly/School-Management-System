namespace firsttry
{
    partial class Teachers
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
            this.label7 = new System.Windows.Forms.Label();
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TDOB = new System.Windows.Forms.DateTimePicker();
            this.TPhoneTb = new System.Windows.Forms.TextBox();
            this.TAddTb = new System.Windows.Forms.TextBox();
            this.TNameTb = new System.Windows.Forms.TextBox();
            this.TGendrCb = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Teachers List";
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDGV.Location = new System.Drawing.Point(35, 199);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.RowHeadersWidth = 51;
            this.TeachersDGV.RowTemplate.Height = 24;
            this.TeachersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersDGV.Size = new System.Drawing.Size(820, 271);
            this.TeachersDGV.TabIndex = 34;
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(871, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // TDOB
            // 
            this.TDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDOB.Location = new System.Drawing.Point(524, 27);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(111, 22);
            this.TDOB.TabIndex = 26;
            // 
            // TPhoneTb
            // 
            this.TPhoneTb.Location = new System.Drawing.Point(295, 88);
            this.TPhoneTb.Multiline = true;
            this.TPhoneTb.Name = "TPhoneTb";
            this.TPhoneTb.Size = new System.Drawing.Size(100, 22);
            this.TPhoneTb.TabIndex = 25;
            // 
            // TAddTb
            // 
            this.TAddTb.Location = new System.Drawing.Point(807, 52);
            this.TAddTb.Multiline = true;
            this.TAddTb.Name = "TAddTb";
            this.TAddTb.Size = new System.Drawing.Size(190, 93);
            this.TAddTb.TabIndex = 24;
            // 
            // TNameTb
            // 
            this.TNameTb.Location = new System.Drawing.Point(195, 25);
            this.TNameTb.Multiline = true;
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.Size = new System.Drawing.Size(100, 22);
            this.TNameTb.TabIndex = 23;
            // 
            // TGendrCb
            // 
            this.TGendrCb.FormattingEnabled = true;
            this.TGendrCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.TGendrCb.Location = new System.Drawing.Point(354, 25);
            this.TGendrCb.Name = "TGendrCb";
            this.TGendrCb.Size = new System.Drawing.Size(121, 24);
            this.TGendrCb.TabIndex = 22;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackBtn.Location = new System.Drawing.Point(902, 449);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(127, 44);
            this.BackBtn.TabIndex = 21;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(524, 126);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(127, 44);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditBtn.Location = new System.Drawing.Point(359, 126);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(117, 44);
            this.EditBtn.TabIndex = 19;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBtn.Location = new System.Drawing.Point(196, 126);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(127, 44);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Subject";
            // 
            // SubjectCb
            // 
            this.SubjectCb.FormattingEnabled = true;
            this.SubjectCb.Items.AddRange(new object[] {
            "Arabic",
            "Maths",
            "Science",
            "English",
            "Art",
            "Religion",
            "History & Geo"});
            this.SubjectCb.Location = new System.Drawing.Point(465, 81);
            this.SubjectCb.Name = "SubjectCb";
            this.SubjectCb.Size = new System.Drawing.Size(100, 24);
            this.SubjectCb.TabIndex = 36;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubjectCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.TPhoneTb);
            this.Controls.Add(this.TAddTb);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.TGendrCb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView TeachersDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TDOB;
        private System.Windows.Forms.TextBox TPhoneTb;
        private System.Windows.Forms.TextBox TAddTb;
        private System.Windows.Forms.TextBox TNameTb;
        private System.Windows.Forms.ComboBox TGendrCb;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SubjectCb;
    }
}
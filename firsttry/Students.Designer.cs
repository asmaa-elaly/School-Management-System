namespace firsttry
{
    partial class Students
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StGenderCb = new System.Windows.Forms.ComboBox();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.StAddressTb = new System.Windows.Forms.TextBox();
            this.StFeesTb = new System.Windows.Forms.TextBox();
            this.StDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.StClassCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBtn.Location = new System.Drawing.Point(127, 103);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(144, 44);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditBtn.Location = new System.Drawing.Point(334, 103);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(144, 44);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(536, 103);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(144, 44);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackBtn.Location = new System.Drawing.Point(902, 449);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(131, 44);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StGenderCb
            // 
            this.StGenderCb.BackColor = System.Drawing.SystemColors.Control;
            this.StGenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StGenderCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StGenderCb.FormattingEnabled = true;
            this.StGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StGenderCb.Location = new System.Drawing.Point(229, 54);
            this.StGenderCb.Name = "StGenderCb";
            this.StGenderCb.Size = new System.Drawing.Size(121, 24);
            this.StGenderCb.TabIndex = 4;
            // 
            // StNameTb
            // 
            this.StNameTb.BackColor = System.Drawing.SystemColors.Control;
            this.StNameTb.Location = new System.Drawing.Point(70, 54);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(100, 22);
            this.StNameTb.TabIndex = 5;
            // 
            // StAddressTb
            // 
            this.StAddressTb.BackColor = System.Drawing.SystemColors.Control;
            this.StAddressTb.Location = new System.Drawing.Point(851, 54);
            this.StAddressTb.Multiline = true;
            this.StAddressTb.Name = "StAddressTb";
            this.StAddressTb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.StAddressTb.Size = new System.Drawing.Size(182, 93);
            this.StAddressTb.TabIndex = 6;
            // 
            // StFeesTb
            // 
            this.StFeesTb.BackColor = System.Drawing.SystemColors.Control;
            this.StFeesTb.Location = new System.Drawing.Point(714, 55);
            this.StFeesTb.Name = "StFeesTb";
            this.StFeesTb.Size = new System.Drawing.Size(100, 22);
            this.StFeesTb.TabIndex = 7;
            // 
            // StDOBPicker
            // 
            this.StDOBPicker.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StDOBPicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.StDOBPicker.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StDOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StDOBPicker.Location = new System.Drawing.Point(399, 56);
            this.StDOBPicker.Name = "StDOBPicker";
            this.StDOBPicker.Size = new System.Drawing.Size(111, 22);
            this.StDOBPicker.TabIndex = 8;
            // 
            // StClassCb
            // 
            this.StClassCb.BackColor = System.Drawing.SystemColors.Control;
            this.StClassCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StClassCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StClassCb.FormattingEnabled = true;
            this.StClassCb.Items.AddRange(new object[] {
            "7th",
            "8th",
            "9th"});
            this.StClassCb.Location = new System.Drawing.Point(559, 52);
            this.StClassCb.Name = "StClassCb";
            this.StClassCb.Size = new System.Drawing.Size(121, 24);
            this.StClassCb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "DOB";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(592, 25);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(40, 19);
            this.Class.TabIndex = 13;
            this.Class.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(911, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 271);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Students List";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StClassCb);
            this.Controls.Add(this.StDOBPicker);
            this.Controls.Add(this.StFeesTb);
            this.Controls.Add(this.StAddressTb);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.StGenderCb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ComboBox StGenderCb;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.TextBox StAddressTb;
        private System.Windows.Forms.TextBox StFeesTb;
        private System.Windows.Forms.DateTimePicker StDOBPicker;
        private System.Windows.Forms.ComboBox StClassCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}
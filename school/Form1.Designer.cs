namespace SchoolManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            StNameTb = new TextBox();
            StFeesTb = new TextBox();
            StGendrCb = new ComboBox();
            StDOBPicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StClassCb = new ComboBox();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            StudentesDGV = new DataGridView();
            label6 = new Label();
            StAddressTb = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StudentesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // StNameTb
            // 
            StNameTb.Location = new Point(36, 77);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(100, 23);
            StNameTb.TabIndex = 1;
            // 
            // StFeesTb
            // 
            StFeesTb.Location = new Point(665, 80);
            StFeesTb.Name = "StFeesTb";
            StFeesTb.Size = new Size(100, 23);
            StFeesTb.TabIndex = 2;
            // 
            // StGendrCb
            // 
            StGendrCb.FormattingEnabled = true;
            StGendrCb.Items.AddRange(new object[] { "male", "femal" });
            StGendrCb.Location = new Point(152, 77);
            StGendrCb.Name = "StGendrCb";
            StGendrCb.Size = new Size(121, 23);
            StGendrCb.TabIndex = 3;
            // 
            // StDOBPicker
            // 
            StDOBPicker.Location = new Point(299, 77);
            StDOBPicker.Name = "StDOBPicker";
            StDOBPicker.Size = new Size(190, 23);
            StDOBPicker.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 59);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 59);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 59);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "class";
            // 
            // StClassCb
            // 
            StClassCb.FormattingEnabled = true;
            StClassCb.Items.AddRange(new object[] { "A", "B", "C", "D" });
            StClassCb.Location = new Point(507, 77);
            StClassCb.Name = "StClassCb";
            StClassCb.Size = new Size(121, 23);
            StClassCb.TabIndex = 8;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(75, 130);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 10;
            SaveBtn.Text = "Add";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(182, 130);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 11;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(323, 130);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(464, 130);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 13;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // StudentesDGV
            // 
            StudentesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentesDGV.Location = new Point(54, 180);
            StudentesDGV.Name = "StudentesDGV";
            StudentesDGV.RowTemplate.Height = 25;
            StudentesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentesDGV.Size = new Size(668, 251);
            StudentesDGV.TabIndex = 14;
            StudentesDGV.CellContentClick += StudentesDGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(800, 59);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // StAddressTb
            // 
            StAddressTb.Location = new Point(800, 80);
            StAddressTb.Name = "StAddressTb";
            StAddressTb.Size = new Size(132, 23);
            StAddressTb.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-82, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 24);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(889, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 469);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(StAddressTb);
            Controls.Add(label6);
            Controls.Add(StudentesDGV);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label5);
            Controls.Add(StClassCb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StDOBPicker);
            Controls.Add(StGendrCb);
            Controls.Add(StFeesTb);
            Controls.Add(StNameTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Students";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StNameTb;
        private TextBox StFeesTb;
        private ComboBox StGendrCb;
        private DateTimePicker StDOBPicker;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox StClassCb;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private DataGridView StudentesDGV;
        private Label label6;
        private TextBox StAddressTb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
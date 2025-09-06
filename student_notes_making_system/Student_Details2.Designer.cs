namespace student_notes_making_system
{
    partial class Student_Details2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Details2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtRollNo = new TextBox();
            txtDivision = new TextBox();
            label6 = new Label();
            btnSubmit = new Button();
            btnUpdate = new Button();
            cmbClass = new ComboBox();
            label7 = new Label();
            txtPRN = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 52);
            label1.TabIndex = 0;
            label1.Text = "Student Details";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(206, 170);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(233, 222);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Roll No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(257, 272);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "Class";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 337);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(383, 168);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(256, 27);
            txtFullName.TabIndex = 6;
            txtFullName.TextChanged += textBox3_TextChanged_1;
            // 
            // txtRollNo
            // 
            txtRollNo.Location = new Point(383, 220);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.Size = new Size(256, 27);
            txtRollNo.TabIndex = 7;
            txtRollNo.TextChanged += textBox3_TextChanged_1;
            // 
            // txtDivision
            // 
            txtDivision.Location = new Point(383, 317);
            txtDivision.Name = "txtDivision";
            txtDivision.Size = new Size(256, 27);
            txtDivision.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(233, 319);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 5;
            label6.Text = "Division";
            label6.Click += label6_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlDarkDark;
            btnSubmit.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(524, 501);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(115, 46);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlDarkDark;
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(210, 501);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 46);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "F.Y.", "S.Y.", "T.Y." });
            cmbClass.Location = new Point(383, 269);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(256, 28);
            cmbClass.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(219, 117);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 15;
            label7.Text = "PRN No.";
            label7.Click += label7_Click;
            // 
            // txtPRN
            // 
            txtPRN.Location = new Point(383, 118);
            txtPRN.Name = "txtPRN";
            txtPRN.Size = new Size(256, 27);
            txtPRN.TabIndex = 16;
            txtPRN.TextChanged += textBox3_TextChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(206, 439);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 17;
            label8.Text = "Password";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.AppWorkspace;
            label9.Location = new Point(201, 394);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 18;
            label9.Text = "Username";
            // 
            // Username
            // 
            Username.Location = new Point(383, 392);
            Username.Name = "Username";
            Username.Size = new Size(256, 27);
            Username.TabIndex = 19;
            // 
            // Password
            // 
            Password.Location = new Point(383, 437);
            Password.Name = "Password";
            Password.Size = new Size(256, 27);
            Password.TabIndex = 20;
            // 
            // Student_Details2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(885, 583);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPRN);
            Controls.Add(label7);
            Controls.Add(cmbClass);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(txtDivision);
            Controls.Add(txtRollNo);
            Controls.Add(txtFullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Details2";
            Text = "`";
            Load += Student_Details_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtRollNo;
        private TextBox txtDivision;
        private Label label6;
        private Button btnSubmit;
        private Button btnUpdate;
        private ComboBox cmbClass;
        private Label label7;
        private TextBox txtPRN;
        private Label label8;
        private Label label9;
        private TextBox Username;
        private TextBox Password;
    }
}
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_notes_making_system
{
    public partial class Student_Details2 : Form
    {
        public Student_Details2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (!InsertStudentDetailsIntoDatabase())
                {
                    MessageBox.Show("Error while creating your account. Please try again or contact the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Form Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
            {
                return;
            }

        }

        private bool InsertStudentDetailsIntoDatabase()
        {
            string conString = @"Data Source=.\sqlexpress;Initial Catalog=NewStudent;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                string insertStudentDetails = @"INSERT INTO dbo.Stud_Det 
                         (PRN_NO, FullName, RollNo, Class, Division) 
                         VALUES (@prn, @fullname, @rollno, @class, @division)";

                string insertLoginDetails = @"INSERT INTO dbo.Login_T (Username, Passwordd) VALUES (@username, @password)";

                SqlCommand cmdStudentDetails = new SqlCommand(insertStudentDetails, con);

                cmdStudentDetails.Parameters.AddWithValue("@prn", txtPRN.Text);
                cmdStudentDetails.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmdStudentDetails.Parameters.AddWithValue("@rollno", txtRollNo.Text);
                cmdStudentDetails.Parameters.AddWithValue("@class", int.Parse(cmbClass.Text));
                cmdStudentDetails.Parameters.AddWithValue("@division", txtDivision.Text);

                SqlCommand cmdLoginDetails = new SqlCommand(insertLoginDetails, con);

                cmdLoginDetails.Parameters.AddWithValue("@username", Username.Text);
                cmdLoginDetails.Parameters.AddWithValue("@password", Password.Text);

                try
                {
                    con.Open();
                    int rowsStudent = cmdStudentDetails.ExecuteNonQuery();
                    int rowsLogin = cmdLoginDetails.ExecuteNonQuery();

                    return (rowsStudent > 0 && rowsLogin > 0);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error inserting student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Details_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateUpdate())
            {
                MessageBox.Show("Form Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update student details logic
            }

            Student_Details2 main = new Student_Details2();
            main.Show();
            this.Hide();
        }
        private bool ValidateForm()
        {
            // Trim input to avoid blank spaces
            string prn = txtPRN.Text.Trim();
            string name = txtFullName.Text.Trim();
            string roll = txtRollNo.Text.Trim();
            string className = cmbClass.Text.Trim();
            string division = txtDivision.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(prn))
            {
                MessageBox.Show("Please enter PRN No.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPRN.Focus();
                return false;
            }

            if (!long.TryParse(prn, out _))  // check if PRN is numeric
            {
                MessageBox.Show("PRN No. must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPRN.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(roll))
            {
                MessageBox.Show("Please enter Roll No.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRollNo.Focus();
                return false;
            }

            if (!int.TryParse(roll, out _)) // check if Roll No is integer
            {
                MessageBox.Show("Roll No. must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRollNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please select a Class.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(division))
            {
                MessageBox.Show("Please enter Division.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDivision.Focus();
                return false;
            }
            return true; // all validations passed
        }
        private bool ValidateUpdate()
        {
            string className = cmbClass.Text.Trim();
            string division = txtDivision.Text.Trim();

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please update a Class.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(division))
            {
                MessageBox.Show("Please enter Division.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDivision.Focus();
                return false;
            }
            return true; // all validations passed
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}

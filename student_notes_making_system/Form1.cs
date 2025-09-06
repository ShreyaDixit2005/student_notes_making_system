using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace student_notes_making_system
{
    public partial class Form1 : Form
    {
        string constring= @"Data Source=.\sqlexpress;Initial Catalog = NewStudent; Integrated Security = True; Trust Server Certificate=True";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ValidateLogin())
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            notes_and_timet3 main = new notes_and_timet3();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {            
            Student_Details2 main = new Student_Details2();
            main.Show();
            this.Hide();

        }
        private bool ValidateLogin()
        {
            string conString = @"Data Source=.\sqlexpress;Initial Catalog=NewStudent;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            // con is used to open connection to the database
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Login_T WHERE Username=@username AND Passwordd=@password";
                // cmd is the final object used to fire a query into the database
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();

                con.Open();
                int result = (int)cmd.ExecuteScalar();

                return result > 0 ? true : false;
            }
        }
    }
    
}

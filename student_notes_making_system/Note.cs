using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace student_notes_making_system
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Note main = new Note();
            main.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            InsertNote();
        }
        private bool InsertNote()
        {
            string conString = @"Data Source=.\sqlexpress;Initial Catalog=NewStudent;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                string note = @"INSERT INTO dbo.New_Notes 
                         (SubjectID, Title, Content, UserID) 
                         VALUES (@subId, @noteTitle, @content, @userId)";


                SqlCommand cmdStudentDetails = new SqlCommand(note, con);

                cmdStudentDetails.Parameters.AddWithValue("@noteTitle", TitleName.Text);
                cmdStudentDetails.Parameters.AddWithValue("@content", Content.Text);
            }
        }
    }
}

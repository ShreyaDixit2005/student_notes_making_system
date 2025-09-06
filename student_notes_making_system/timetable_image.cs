using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_notes_making_system
{
    public partial class timetable_image : Form
    {
        public timetable_image()
        {
            InitializeComponent();
        }

        private void timetable_image_Load(object sender, EventArgs e)
        {
            string classValue = Properties.Settings.Default.Class;

            string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;


            if (classValue == "1")
            {
                string imagePath = Path.Combine(projectPath, "Images", "timetable-3rd.jpeg");
                Image.Image = System.Drawing.Image.FromFile(imagePath);
            }
            if (classValue == "2")
            {
                string imagePath = Path.Combine(projectPath, "Images", "timetable-3rd.jpeg");
                Image.Image = System.Drawing.Image.FromFile(imagePath);
            }
            if (classValue == "3")
            {
                string imagePath = Path.Combine(projectPath, "Images", "timetable-3rd.jpeg");
                Image.Image = System.Drawing.Image.FromFile(imagePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            notes_and_timet3 main = new notes_and_timet3();
            main.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

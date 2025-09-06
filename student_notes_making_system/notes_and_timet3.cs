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
    public partial class notes_and_timet3 : Form
    {
        public notes_and_timet3()
        {
            InitializeComponent();
        }

        private void notes_and_timet3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timetable_image main = new timetable_image();
            main.Show();
            this.Hide();






        }
    }
}

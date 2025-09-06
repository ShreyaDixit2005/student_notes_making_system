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
    public partial class Trash : Form
    {
        public Trash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create main = new create();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

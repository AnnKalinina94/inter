using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inter
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudents stud = new FormStudents();
            stud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPrepodavateli pre = new FormPrepodavateli();
            pre.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormYcheb ych = new FormYcheb();
            ych.Show();
        }
    }
}
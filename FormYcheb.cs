using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inter
{
    public partial class FormYcheb : Form
    {
        public FormYcheb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            FormYchinform inf = new FormYchinform();
            inf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPed ped = new FormPed();
            ped.Show();
        }
    }
}
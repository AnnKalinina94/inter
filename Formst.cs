using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inter
{
    public partial class Formst : Form
    {
        public Formst()
        {        
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void Formst_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lilDataSet.Groop' table. You can move, or remove it, as needed.
            this.groopTableAdapter.Fill(this.lilDataSet.Groop);
            // TODO: This line of code loads data into the 'lilDataSet.Napravlenie' table. You can move, or remove it, as needed.
            this.napravlenieTableAdapter.Fill(this.lilDataSet.Napravlenie);
            // TODO: This line of code loads data into the 'lilDataSet.Kurs' table. You can move, or remove it, as needed.
            this.kursTableAdapter.Fill(this.lilDataSet.Kurs);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
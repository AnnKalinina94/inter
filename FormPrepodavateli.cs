using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inter
{
    public partial class FormPrepodavateli : Form
    {
        public FormPrepodavateli()
        {
            InitializeComponent();
        }

        private void prepodavateliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prepodavateliBindingSource.EndEdit();
            this.prepodavateliTableAdapter.Update(this.lilDataSet.Prepodavateli);

        }

        private void FormPrepodavateli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lilDataSet.Prepodavateli' table. You can move, or remove it, as needed.
            this.prepodavateliTableAdapter.Fill(this.lilDataSet.Prepodavateli);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.prepodavateliBindingSource.AddNew();
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prepodavateliBindingSource.EndEdit();
            this.prepodavateliTableAdapter.Update(this.lilDataSet);
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.prepodavateliBindingSource.RemoveCurrent();
            
        }
    }
}

  

      
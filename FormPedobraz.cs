using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inter
{
    public partial class FormPed : Form
    {
        public FormPed()
        {
            InitializeComponent();
        }

        private void bindingSourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.ychebnii_plan_pedag_obraz__matem_TableAdapter.Update(this.lilDataSet._Ychebnii_plan_pedag_obraz__matem_);

        }

        private void FormPed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lilDataSet._Ychebnii_plan_pedag_obraz__matem_' table. You can move, or remove it, as needed.
            this.ychebnii_plan_pedag_obraz__matem_TableAdapter.Fill(this.lilDataSet._Ychebnii_plan_pedag_obraz__matem_);

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inter
{
    public partial class FormStudents : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=KATE-ПК\SQLEXPRESS;Initial Catalog=lil;Integrated Security=True");
        public FormStudents()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.lilDataSet.Student);

        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lilDataSet.Kurs' table. You can move, or remove it, as needed.
            this.kursTableAdapter.Fill(this.lilDataSet.Kurs);
            // TODO: This line of code loads data into the 'lilDataSet.Groop' table. You can move, or remove it, as needed.
            this.groopTableAdapter.Fill(this.lilDataSet.Groop);
            // TODO: This line of code loads data into the 'lilDataSet.Napravlenie' table. You can move, or remove it, as needed.
            this.napravlenieTableAdapter.Fill(this.lilDataSet.Napravlenie);
            // TODO: This line of code loads data into the 'lilDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.lilDataSet.Student);

        }

       
       

          private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formst stu = new Formst();
            stu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

       // private void button2_Click(object sender, EventArgs e)
        //{
                       
          //  this.studentBindingSource.AddNew();
       // }

//        private void button3_Click(object sender, EventArgs e)
  //      {
    //        this.Validate();
      //      this.studentBindingSource.EndEdit();
        //    this.studentTableAdapter.Update(this.lilDataSet);
            
        //}

//        private void button4_Click(object sender, EventArgs e)
  //      {
    //        this.studentBindingSource.RemoveCurrent();
    //    }

       

            // int bb = datagridvieRowIndex;
   //studentBindingSource.Filter = "Kurs = " + DataGridView[11, bb].Value;

            //выборка

          
        //List <Groop> groopList;
          //  try
           // {
        //groopList = Formst.setGroop(comboBox1.SelectedValue.ToString());
          //      if (groopList.Count >0)
            //    {
              //      Groop groop;
                //    listView1.Items.Clear();
                  //  for (int i=0; i<groopList.Count.i++)
                    //{
                      //  groop = groopList[i];
                        //listView1.Items.Add(groop.GroopID.ToString());
                        //listView1.Items[i].SubItems.Add()

     

    }
}
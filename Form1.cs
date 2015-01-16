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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KATE-ПК\SQLEXPRESS;Initial Catalog=lil;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where username = '"+ textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FormMenu mm = new FormMenu();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели не верный логин или пароль. Введите верный логин и пароль");
            }
        }

       
    }
}
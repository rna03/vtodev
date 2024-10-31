using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VThastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin.Text == "" && Password.Text == " ")
            {
                MessageBox.Show("bilgiler eksik");
            }

            else if (Admin.Text == "Admin" && Password.Text == "Password")
            {
                Home obj= new Home();
                obj.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("yanlış girdiniz");
            }

        }
    }
}

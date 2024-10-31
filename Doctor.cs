using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VThastane
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        readonly SqlConnection Con = new SqlConnection(connectionString: @"Server=DESKTOP-VHCFNJ7\\SQLEXPRESS;Database=VtHastane;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        private void DisplayDoctor()
        {
            try
            {
                Con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctor();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("eksik bilgi");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Doktor values(' " + textBox1.Text + "', ' " + textBox2.Text + "','" + comboBox1.Text + "', ' " + textBox3.Text + "', ' " + textBox4.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("record entered succesfully");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text==" ")
                {
                    MessageBox.Show("enter");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}

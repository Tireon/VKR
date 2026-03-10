using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string N = textBox1.Text + "		--- N";
            string Courant = textBox2.Text + "		--- Courant";            
            string gamma = textBox3.Text + "		--- gamma";
            string t_end = textBox4.Text + "		--- t_end";
            string dt_save = textBox5.Text + "		--- dt_save";
            string a = textBox6.Text;
            string b = textBox7.Text; 
            string rho_L = textBox8.Text + "		--- rho_L";
            string rho_R = textBox9.Text + "		--- rho_R";
            string u_L = textBox10.Text + "		--- u_L";
            string u_R = textBox11.Text + "		--- u_R";
            string p_L = textBox12.Text + "		--- p_L";
            string p_R = textBox13.Text + "		--- p_R";
            string ab = a + " " + b + "		--- a b";
            StreamWriter file1 = new StreamWriter("start1.dat");
            file1.WriteLine(N);
            file1.WriteLine(Courant);
            file1.WriteLine(gamma);
            file1.WriteLine(t_end);
            file1.WriteLine(dt_save);
            file1.WriteLine(ab);
            file1.WriteLine(rho_L);
            file1.WriteLine(rho_R);
            file1.WriteLine(u_L);
            file1.WriteLine(u_R);
            file1.WriteLine(p_L);
            file1.WriteLine(p_R);
            file1.Close();


            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

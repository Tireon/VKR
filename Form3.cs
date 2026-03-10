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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            StreamWriter file2 = new StreamWriter("start2.dat");
            file2.WriteLine(N);
            file2.WriteLine(Courant);
            file2.WriteLine(gamma);
            file2.WriteLine(t_end);
            file2.WriteLine(dt_save);
            file2.WriteLine(ab);
            file2.WriteLine(rho_L);
            file2.WriteLine(rho_R);
            file2.WriteLine(u_L);
            file2.WriteLine(u_R);
            file2.WriteLine(p_L);
            file2.WriteLine(p_R);
            file2.Close();


            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

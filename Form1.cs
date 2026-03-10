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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            for (int i = 0; i <= 11; i++)
                chart1.Series[i].IsVisibleInLegend = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 1.0;
            chart1.ChartAreas[0].AxisX.Interval = 0.100;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //string path0 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Debug\\M_0_HLLC.dat";
            string path1 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\M_1_HLLC.dat";
            string path2 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\M_2_HLLC.dat";
            string path3 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\M_3_HLLC.dat";
            string path4 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\M_4_HLLC.dat";
            string path5 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\M_5_HLLC.dat";
            string line, word; 
            string[] words;
            double X = 0; double Y = 0;

            
            if (checkBox8.Checked)
            {
                chart1.Series[6].IsVisibleInLegend = true;
                StreamReader sr1 = new StreamReader(path1);
                line = sr1.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr1.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton1.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[6].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[6].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton3.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[6].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton4.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[6].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr1.Close();
            }
            if (checkBox9.Checked)
            {
                chart1.Series[7].IsVisibleInLegend = true;
                StreamReader sr2 = new StreamReader(path2);
                line = sr2.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr2.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton1.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[7].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[7].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton3.Checked)
                    {

                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[7].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton4.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[7].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr2.Close();
            }
            if (checkBox10.Checked)
            {
                chart1.Series[8].IsVisibleInLegend = true;
                StreamReader sr3 = new StreamReader(path3);
                line = sr3.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr3.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton1.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[8].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[8].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton3.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[8].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton4.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[8].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr3.Close();
            }
            if (checkBox11.Checked)
            {
                chart1.Series[9].IsVisibleInLegend = true;
                StreamReader sr4 = new StreamReader(path4);
                line = sr4.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr4.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton1.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[9].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[9].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton3.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[9].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton4.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[9].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr4.Close();
            }
            if (checkBox12.Checked)
            {
                chart1.Series[10].IsVisibleInLegend = true;
                StreamReader sr5 = new StreamReader(path5);
                line = sr5.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr5.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton1.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[10].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[10].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton3.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[10].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton4.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[10].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr5.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "NIR4.exe";
            Proc.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 1.0;
            chart1.ChartAreas[0].AxisX.Interval = 0.100;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            string path0 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_0.dat";
            string path1 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_1.dat";
            string path2 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_2.dat";
            string path3 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_3.dat";
            string path4 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_4.dat";
            string path5 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\data_old_5.dat";
            string line, word;
            string[] words;
            double X = 0; double Y = 0;

            if (checkBox1.Checked)
            {
                chart1.Series[0].IsVisibleInLegend = true;
                StreamReader sr = new StreamReader(path0);
                line = sr.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[0].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[0].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[0].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[0].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr.Close();
            }
            if (checkBox2.Checked)
            {
                chart1.Series[1].IsVisibleInLegend = true;
                StreamReader sr1 = new StreamReader(path1);
                line = sr1.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr1.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[1].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[1].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[1].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[1].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr1.Close();
            }
            if (checkBox3.Checked)
            {
                chart1.Series[2].IsVisibleInLegend = true;
                StreamReader sr2 = new StreamReader(path2);
                line = sr2.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr2.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[2].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[2].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[2].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[2].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr2.Close();
            }
            if (checkBox4.Checked)
            {
                chart1.Series[3].IsVisibleInLegend = true;
                StreamReader sr3 = new StreamReader(path3);
                line = sr3.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr3.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[3].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[3].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[3].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[3].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr3.Close();
            }
            if (checkBox5.Checked)
            {
                chart1.Series[4].IsVisibleInLegend = true;
                StreamReader sr4 = new StreamReader(path4);
                line = sr4.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr4.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[4].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[4].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[4].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[4].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr4.Close();
            }
            if (checkBox6.Checked)
            {
                chart1.Series[5].IsVisibleInLegend = true;
                StreamReader sr5 = new StreamReader(path5);
                line = sr5.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    line = sr5.ReadLine();
                    line = line.Replace(".", ",");
                    words = line.Split(' ');
                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton5.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[5].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton6.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[5].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton7.Checked)
                    {
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[5].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                    if (radioButton8.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[5].Points.AddXY(X * Xscale, Y * Yscale);
                    }
                }
                sr5.Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
        double Ycount = 0.0; double Xcount = 0.0; double Xscale = 1.0; double Yscale = 1.0;
        private void button8_Click(object sender, EventArgs e)
        {
            Ycount = Ycount + 0.05;
            chart1.ChartAreas[0].AxisY.Minimum = (0.0 + Ycount);
            chart1.ChartAreas[0].AxisY.Maximum = (3.0 + Ycount);

        }
        private void button11_Click(object sender, EventArgs e)
        {
            Ycount = Ycount - 0.1;
            chart1.ChartAreas[0].AxisY.Minimum = (0.0 + Ycount);
            chart1.ChartAreas[0].AxisY.Maximum = (3.0 + Ycount);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Xcount = Xcount + 0.1;
            chart1.ChartAreas[0].AxisX.Minimum = (0.0 + Xcount);
            chart1.ChartAreas[0].AxisX.Maximum = (1.0 + Xcount);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Xcount = Xcount - 0.1;
            chart1.ChartAreas[0].AxisX.Minimum = (0.0 + Xcount);
            chart1.ChartAreas[0].AxisX.Maximum = (1.0 + Xcount);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Xscale = Xscale - 0.1;
            button2_Click(sender, e);
            button3_Click(sender, e);
            button15_Click(sender, e);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Xscale = Xscale + 0.1;
            button2_Click(sender, e);
            button3_Click(sender, e);
            button15_Click(sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Yscale = Yscale - 0.1;
            button2_Click(sender, e);
            button3_Click(sender, e);
            button15_Click(sender, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Yscale = Yscale + 0.1;
            button2_Click(sender, e);
            button3_Click(sender, e);
            button15_Click(sender, e);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить изображение как ...";
                sfd.Filter = "*.png|*.png;|*.bmp|*.bmp;|*.jpg|*.jpg";
                sfd.AddExtension = true;
                sfd.FileName = "graphicImage";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                        case 2: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                        case 3: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                    }
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "cSPH-TVD.exe";
            Proc.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            chart1.Series[11].IsVisibleInLegend = true;
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 1.0;
            chart1.ChartAreas[0].AxisX.Interval = 0.100;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            string path1 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\Riemann_solver1.dat";
            string path2 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\Riemann_solver2.dat";
            string path3 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\Riemann_solver3.dat";
            string path4 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\Riemann_solver4.dat";
            string path5 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Release\\Riemann_solver5.dat";
            string line, word;
            string[] words;
            double X = 0; double Y = 0;

            if (checkBox13.Checked)
            {
                StreamReader sr = new StreamReader(path1);
                for (int i = 0; i <= 399; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton12.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale  + 0.5, Y * Yscale);
                    }
                    if (radioButton11.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale  + 0.5, Y * Yscale);
                    }
                    if (radioButton10.Checked)
                    {
                        word = words[6];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale  + 0.5, Y * Yscale);
                    }
                    if (radioButton9.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[8];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale  + 0.5, Y * Yscale);
                    }
                }
                sr.Close();
            }
            if (checkBox14.Checked)
            {
                StreamReader sr = new StreamReader(path2);
                for (int i = 0; i <= 399; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton12.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton11.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton10.Checked)
                    {
                        word = words[6];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton9.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[8];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                }
                sr.Close();
            }
            if (checkBox15.Checked)
            {
                StreamReader sr = new StreamReader(path3);
                for (int i = 0; i <= 399; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton12.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton11.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton10.Checked)
                    {
                        word = words[6];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton9.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[8];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                }
                sr.Close();
            }
            if (checkBox16.Checked)
            {
                StreamReader sr = new StreamReader(path4);
                for (int i = 0; i <= 399; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton12.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton11.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton10.Checked)
                    {
                        word = words[6];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton9.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[8];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                }
                sr.Close();
            }
            if (checkBox17.Checked)
            {
                StreamReader sr = new StreamReader(path5);
                for (int i = 0; i <= 399; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];

                    if (word != null)
                    {
                        X = Convert.ToDouble(word);
                    }
                    if (radioButton12.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton11.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[4];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton10.Checked)
                    {
                        word = words[6];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                    if (radioButton9.Checked)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        word = words[8];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale + 0.5, Y * Yscale);
                    }
                }
                sr.Close();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 11; i++)
                chart1.Series[i].IsVisibleInLegend = false;
            foreach (var series in chart1.Series) {
                series.Points.Clear(); 
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            chart1.Series[11].IsVisibleInLegend = true;

            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 1.0;
            chart1.ChartAreas[0].AxisX.Interval = 0.050;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisY.Minimum = 0.0;
            chart1.ChartAreas[0].AxisY.Maximum = 3.0;
            chart1.ChartAreas[0].AxisY.Interval = 0.100;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            string path0 = "C:\\Users\\1\\Desktop\\VKR\\diplom1\\bin\\Debug\\Riemann_solver.dat";
            string line, word;
            string[] words;
            double X = 0; double Y = 0;

                StreamReader sr = new StreamReader(path0);
                for (int i = 0; i <= 398; i++)
                {
                    line = sr.ReadLine();
                    line = line.Replace(".", ",");
                    line = line.Replace("\t", " ");
                    words = line.Split(' ');

                    word = words[0];


                        X = Convert.ToDouble(word);
                    
                        word = words[1];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale, Y * Yscale);
                    
                        word = words[2];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale, Y * Yscale);
                    
                    
                        word = words[3];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale, Y * Yscale);
                    
                    
                        word = words[5];
                        if (word != null)
                        {
                            Y = Convert.ToDouble(word);
                        }
                        chart1.Series[11].Points.AddXY(X * Xscale, Y * Yscale);
                    
                }
                sr.Close();
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}

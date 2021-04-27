using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{//tyomashi
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void main_button1_Click(object sender, EventArgs e)
        {
            new lab1_Form().Show();
        }
        private void main_button2_Click(object sender, EventArgs e)
        {
            new lab2_Form().Show();
        }
        private void main_button3_Click(object sender, EventArgs e)
        {
            new lab3_Form().Show();
        }
        private void main_button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor =  Color.FromArgb(new Random().Next(0, 255), 
                new Random().Next(0, 255), 
                new Random().Next(0, 255));
        }
        private void main_exitButton_Click(object sender, EventArgs e)
        {
            Close();
            //tyomashi
        }
        private void about_pictureBox_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            new FormLab4().Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            new FormLab5old().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FormLab5new().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new FormLab6().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new FormLab7().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FormLab8().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new FormModul1().ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new FormLab9().ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new FormLab10().ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new FormLab11().ShowDialog();
        }

        private void buttonLab12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторна 10 та Лабораторна 11 використовують методи з бібліотеки.", "Info");
        }

        private void buttonLab13_Click(object sender, EventArgs e)
        {
            new FormForLab13().ShowDialog();
        }

        private void buttonLab14_Click(object sender, EventArgs e)
        {
            new FormLab14().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormLab15().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormLab16().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormLab17().ShowDialog();
        }
    }
}

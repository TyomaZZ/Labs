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

        private void lab1_Click(object sender, EventArgs e)
        {
            anim(new lab1_Form(this));
        }

        private void main_button2_Click(object sender, EventArgs e)
        {
            anim(new lab2_Form(this));
        }

        private void main_button3_Click(object sender, EventArgs e)
        {
            anim(new lab3_Form(this));
        }

        private void main_exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void about_pictureBox_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            anim(new FormLab4(this));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anim(new FormLab5old(this));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            anim(new FormLab5new(this));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            anim(new FormLab6(this));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            anim(new FormLab7(this));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            anim(new FormLab8(this));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            anim(new FormModul1(this));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            anim(new FormLab9(this));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            anim(new FormLab10(this));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            anim(new FormLab11(this));
        }

        private void buttonLab12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Усі форми та деякі лабораторні використовують бібліотеку \"MyLib\"", "Info");
        }

        private void buttonLab13_Click(object sender, EventArgs e)
        {
            anim(new FormForLab13(this));
        }

        private void buttonLab14_Click(object sender, EventArgs e)
        {
            anim(new FormLab14(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anim(new FormLab15(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anim(new FormLab16(this));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anim(new FormLab17(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anim(new FormLab18(this));
        }

        private void anim(Form sun)
        {
            sun.Show();
            this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
            this.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anim(new FormLab19(this));
        }
    }
}

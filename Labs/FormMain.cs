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
            flowLayoutPanel1.BackColor =  Color.FromArgb(new Random().Next(0, 255), 
                new Random().Next(0, 255), 
                new Random().Next(0, 255));
        }
        private void main_exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void about_pictureBox_Click(object sender, EventArgs e)
        {
            new About().Show();
        } 
    }
}

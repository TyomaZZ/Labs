﻿using System;
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
            new FormLab3().Show();
        }
        private void main_button4_Click(object sender, EventArgs e)
        {
        }
        private void main_button5_Click(object sender, EventArgs e)
        {
        }
        private void about_pictureBox_Click(object sender, EventArgs e)
        {
            new About().Show();
        } 
    }
}

using Microsoft.VisualBasic;
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
    public partial class lab1_Form : Form
    {
        readonly Form father;
        public lab1_Form(Form patric)
        { 
            InitializeComponent();
            father = patric;
        }

        private void History1_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програмування цікаве", "Історія 1", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            foreach (Control con in lab1_panel.Controls)
                con.Visible = true;
        }

        private void History2_button_Click(object sender, EventArgs e)
        { MessageBox.Show("Вивчаємо ООП", "Історія 2", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }

        private void History3_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Генеруємо числа\nБажаєте змінити дизайн?\n", "Історія 3", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
            Random rnd = new Random();
            if (result == DialogResult.Yes) 
                lab1_panel.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void History4_button_Click(object sender, EventArgs e)
        { MessageBox.Show("В прибраній кімнаті - меньше сміття\n", "Факт", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }

        private void History5_button_Click(object sender, EventArgs e)
        { MessageBox.Show("Copy-Paste - корисна річ", "Історія 5", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }

        private void Exit_button_Click(object sender, EventArgs e)
        { Close(); }

        private void Action_on_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (father != null)
            {
                father.WindowState = FormWindowState.Normal;
                father.ShowInTaskbar = true;
                father.Enabled = true;
            }
        }
    }
}

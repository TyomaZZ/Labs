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
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLab1 form1 = new FormLab1();
            
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLab2 form2 = new FormLab2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLab3 form3 = new FormLab3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}

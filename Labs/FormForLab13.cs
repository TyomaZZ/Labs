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
    public partial class FormForLab13 : FormLab13
    {
        public FormForLab13() : base()
        {
            InitializeComponent();
        }

        protected void Result()
        {
            base.Result();
            Years.Text = Yearss().ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdayDay_ValueChanged(object sender, EventArgs e)
        {
            Result();
        }
        private int Yearss()
        {
            return ((int)((DateTime.Now-BirthdayDay.Value).Days/365.25));
        }

        private void FormForLab13_Load(object sender, EventArgs e)
        {
            Result();
        }
    }
}

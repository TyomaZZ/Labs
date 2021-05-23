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
        readonly Form father;

        public FormForLab13(Form patric)
        {
            InitializeComponent();
            BirthdayDay.MaxDate = DateTime.Now;
            BirthdayDay.Format = DateTimePickerFormat.Custom;
            BirthdayDay.CustomFormat = "         ddMMMMyyyy";
            father = patric;
        }

        protected override void Result()
        {
            base.Result();
            YearCount.Text = String.Format("Вік: {0}", Yearss().ToString());
        }

        private void BirthdayDay_ValueChanged(object sender, EventArgs e)
        {
            Result();
        }
        public int Yearss()
        {
            return ((int)((DateTime.Now-BirthdayDay.Value).Days/365.25));
        }

        private void FormForLab13_Load(object sender, EventArgs e)
        {
            Result();
        }

        private void FormForLab13_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }
    }
}

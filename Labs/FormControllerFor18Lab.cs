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
    public partial class FormControllerFor18Lab : Form
    {
        public FormControllerFor18Lab()
        {
            InitializeComponent();
        }

        private void buttonCascadAll_Click(object sender, EventArgs e)
        {
            Point point;
            point = this.Location;
            point.Offset(0, this.Height + 30);
            foreach (Form f in FormLab18.listForm)
            {
                f.Location = point;
                point.Offset(10, 32);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FormLab18.maxForm = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

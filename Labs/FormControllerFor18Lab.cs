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
        FormLab18 mother;

        public FormControllerFor18Lab(FormLab18 patric)
        {
            InitializeComponent();
            mother = patric;
        }

        private void buttonCascadAll_Click(object sender, EventArgs e)
        {
            Point point;
            point = this.Location;
            point.Offset(5, this.Height + 30);
            foreach (Form f in FormLab18.listForm)
            {
                f.Location = point;
                point.Offset(20, 20);
                f.Focus();
            }
            this.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FormLab18.maxForm = (int)numericUpDown1.Value;
            mother.Counter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point;
            point = this.Location;
            point.Offset(5, this.Height + 30);
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < FormLab18.listForm.Count; i++)
                {
                    switch (j)
                    {
                        case 0:
                            if (FormLab18.listForm[i].Equals(new FormLab16t1()))
                            {
                                FormLab18.listForm[i].Location = point;
                                point.Offset(20, 20);
                                FormLab18.listForm[i].Focus();
                            }
                            break;
                        case 1:
                            if (FormLab18.listForm[i].GetType() == new FormLab16t2().GetType())
                            {
                                FormLab18.listForm[i].Location = point;
                                point.Offset(20, 20);
                                FormLab18.listForm[i].Focus();
                            }
                            break;
                        case 2:
                            if (FormLab18.listForm[i].GetType() == new FormLab16t3().GetType())
                            {
                                FormLab18.listForm[i].Location = point;
                                point.Offset(20, 20);
                                FormLab18.listForm[i].Focus();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            this.Focus();


            foreach (Form f in FormLab18.listForm)
            {
                f.Location = point;
                point.Offset(20, 20);
                f.Focus();
            }
            this.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FormLab18.maxForm = -1;
            mother.Counter();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                FormLab18.maxForm = (int)numericUpDown1.Value;
                mother.Counter();
            }
        }

        private void FormControllerFor18Lab_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.controller = null;
        }
    }
}

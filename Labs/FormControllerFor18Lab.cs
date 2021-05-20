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

            List<InterfaceLab19> newlist = new List<InterfaceLab19>();
            foreach (Form f in FormLab18.listForm)
            {
                newlist.Add((InterfaceLab19)f);
            }
            newlist.Sort(SortByTema);
            for (int i = 0; i < newlist.Count; i++)
            {
                (newlist[i] as Form).Location = point;
                point.Offset(20, 20);
                (newlist[i] as Form).Focus();
            }
           /* foreach (InterfaceLab19 f in newlist)
            {
                (f as Form).Location = point;
                point.Offset(20, 20);
                (f as Form).Focus();
            }*/
            /*
           for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < newlist.Count; i++)
                {
                    switch (j)
                    {
                        case 0:
                            if (newlist[i].GetFormType().Equals("Обробка текстових рядків у формах"))
                            {
                                FormLab18.listForm[i].Location = point;
                                point.Offset(20, 20);
                                FormLab18.listForm[i].Focus();
                            }
                            break;
                        case 1:
                            if (newlist[i].GetFormType().Equals("Підпрограми користувача"))
                            {
                                FormLab18.listForm[i].Location = point;
                                point.Offset(20, 20);
                                FormLab18.listForm[i].Focus();
                            }
                            break;
                        case 2:
                            if (newlist[i].GetFormType().Equals("Організація взаємодії елементів керування у формах"))
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
            }*/
            this.Focus();


          /*  foreach (Form f in FormLab18.listForm)
            {
                f.Location = point;
                point.Offset(20, 20);
                f.Focus();
            }*/
            this.Focus();
        }

        private int SortByTema(InterfaceLab19 f1, InterfaceLab19 f2)
        {
            if (f1 == null || f2 == null)
                throw new ArgumentException("Error");
            return String.Compare(f1.GetFormType(), f2.GetFormType());
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

        private void feature_for_lab19_Click(object sender, EventArgs e)
        {
            List<InterfaceLab19> ListAnaliz = new List<InterfaceLab19>();
            foreach (Form f in FormLab18.listForm)
                ListAnaliz.Add((InterfaceLab19)f);
            if (ListAnaliz.Count == 0)
            {
                MessageBox.Show("Форм не створено", "Статистика форм");
                return;
            }
            int countStringer = 0, countMatcher = 0, countCalc = 0;
            foreach (InterfaceLab19 inter in ListAnaliz)
            {
                if (inter.GetFormType() == "Обробка текстових рядків у формах")
                    countStringer++;
                if (inter.GetFormType() == "Підпрограми користувача")
                    countMatcher++;
                if (inter.GetFormType() == "Організація взаємодії елементів керування у формах")
                    countCalc++;
            }
            MessageBox.Show(String.Format("Обробка текстових рядків у формах: {0} форм(а);\nПідпрограми користувача: {1} форм(а)\nОрганізація взаємодії елементів керування у формах: {2} форм(а)", countStringer, countMatcher, countCalc), "Статистика форм", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

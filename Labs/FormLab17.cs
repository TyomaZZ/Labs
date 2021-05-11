using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labs
{
    public partial class FormLab17 : Form
    {
        const int maxForm = 5;
        Form[] masForm = new Form[maxForm];
        static int countForm = 0;
        Form mother;
        public FormLab17(Form patric)
        {
            InitializeComponent();
            for (int i = 0; i < maxForm; i++)
                masForm[i] = null;
            mother = patric;
        }
        private void createForm(int index)
        {
            int i = 0;
            while (i < maxForm)
                if (masForm[i] == null)
                    break;
                else
                if (masForm[i].IsDisposed)
                    break;
                else i++;
            if (i == maxForm)
            {
                if (MessageBox.Show("Більше форм створити неможливо, бажаєте очистити усі форми?", "Переповнення стеку форм", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CloseAll();
                }
                return;
            }
            switch (index)
            {
                case 1:
                    masForm[i] = new FormLab16t1();
                    break;
                case 2:
                    masForm[i] = new FormLab16t2();
                    break;
                case 3:
                    masForm[i] = new FormLab16t3();
                    break;
            }
            masForm[i].FormClosing += new FormClosingEventHandler(FormLab17_FormClosing);
            masForm[i].Show();
            countForm++;
            Counter();
        }
        private void Counter()
        {
            toolStripStatusLabel1.Text = String.Format("Форм створено: {0}/5", countForm);
        }

        private void FormLab17_FormClosing(object sender, FormClosingEventArgs e)
        {
            countForm--;
            Counter();
            if (sender == this)
            {
                mother.WindowState = FormWindowState.Normal;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Point point = default;
            bool setLoc = false;
            for (int i = 0; i < maxForm; i++)
            {
                if (masForm[i] != null && !setLoc)
                {
                    point = masForm[1].Location;
                    setLoc = true;
                }
                if (masForm[i] != null && setLoc)
                {
                    point.Offset(10, 32);
                    masForm[i].Location = point;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createForm(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createForm(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            createForm(3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void CloseAll()
        {
            foreach (Form f in masForm)
            {
                f.Close();
            }
            countForm = 0;
            Counter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masForm.Length; i++)
            {
                if (masForm[i] != null)
                {
                    if (masForm[i].GetType() == new FormLab16t1().GetType()) {
                        masForm[i].Close();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masForm.Length; i++)
            {
                if (masForm[i] != null)
                {
                    if (masForm[i].GetType() == new FormLab16t2().GetType())
                    {
                        masForm[i].Close();
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < masForm.Length; i++)
            {
                if (masForm[i] != null)
                {
                    if (masForm[i].GetType() == new FormLab16t3().GetType())
                    {
                        masForm[i].Close();
                    }
                }
            }
        }
    }
}

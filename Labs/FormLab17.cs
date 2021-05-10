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
        public FormLab17()
        {
            InitializeComponent();
            for (int i = 0; i < maxForm; i++)
                masForm[i] = null;
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
                MessageBox.Show("Більше форм створити неможливо, бажаєте очистити усі форми?", "Переповнення стеку форм", MessageBoxButtons.YesNo);
                return;
            }
            switch (index)
            {
                case 1:
                    masForm[i] = new FormLab9();
                    break;
                case 2:
                    masForm[i] = new FormLab10();
                    break;
                case 3:
                    masForm[i] = new FormLab11();
                    break;
            }
            masForm[i].FormClosing += new FormClosingEventHandler(FormLab17_FormClosing);
            masForm[i].Show();
            countForm++;
        }
        private void Counter()
        {
            toolStripStatusLabel1.Text = String.Format("Форм створено: {0}/5", countForm);
        }

        private void FormLab17_FormClosing(object sender, FormClosingEventArgs e)
        {
            countForm--;
            Counter();
        }

        public virtual void button1_Click(object sender, EventArgs e)
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
    }
}

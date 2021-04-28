using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Labs
{
    public partial class FormLab18 : Form
    {
        public static List<Form> listForm = new List<Form>();
        int countForm = 0;
        public static int maxForm = -1;
        FormControllerFor18Lab controller = null;

        private void createForm(int index)
        {
            Form f = null;
           /* if (controller != null)
            {
                if (controller.radioButton1.Checked)
                    return;
                if (controller.radioButton2.Checked)
                    if (maxForm >= listForm.LastIndexOf(listForm.Last()))
                        MessageBox.Show("Досягнуто максимуму кількості форм");
                return;
            }*/
            switch (index)
            {
                case 1:
                    f = new FormLab9();
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
                case 2:
                    f = new FormLab10();
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
                case 3:
                    f = new FormLab11();
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
            }
            listForm.Add(f);
            countForm++;
            Counter();
            f.Show();
        }

        public FormLab18()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in listForm)
                if (!f.IsDisposed)
                    f.Close();
            listForm.Clear();
            countForm = 0;
            Counter();
            if (controller != null)
                controller.Close();
            Close();
        }

        private void buttonStringer_Click(object sender, System.EventArgs e)
        {
            createForm(1);
        }

        private void buttonMatcher_Click(object sender, System.EventArgs e)
        {
            createForm(2);
        }

        private void buttonCalc_Click(object sender, System.EventArgs e)
        {
            createForm(3);
        }

        private void buttonFormCloser_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in listForm)
                if (!f.IsDisposed)
                    f.Close();
            listForm.Clear();
            countForm = 0;
            Counter();
        }

        private void FormLab18_FormClosing(object sender, FormClosingEventArgs e)
        {
            countForm--;
            Counter();
        }

        private void Counter()
        {
            char ch = '∞';
            if (maxForm != -1)
                ch = (char)maxForm;
            toolStripStatusLabel1.Text = string.Format("Форм створено: {0}/{1}", countForm, ch);
        }

        private void buttonController_Click(object sender, System.EventArgs e)
        {
            if (controller == null)
            {
                controller = new FormControllerFor18Lab();
                Point point;
                point = this.Location;
                point.Offset(this.Width, 0);
                controller.Show();
                controller.Location = point;
            }
        }

        private void FormLab18_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in listForm)
                if (!f.IsDisposed)
                    f.Close();
            listForm.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Labs
{
    public partial class FormLab18 : Form, InterfaceLab19
    {
        public static List<Form> listForm = new List<Form>();
        int countForm = 0;
        public static int maxForm = -1;
        public FormControllerFor18Lab controller = null;
        Form mother;

        public FormLab18(Form patric)
        {
            InitializeComponent();
            mother = patric;
        }

        private FormLab18()
        {
            InitializeComponent();
        }

        public string GetFormType()
        {
            return "Головне меню";
        }

        private void createForm(int index)
        {
            Form f = null;
            if (maxForm != -1)
            {
                if (controller.radioButton1.Checked) { }
                    
                if (controller.radioButton2.Checked)
                    if (listForm.Count == maxForm)
                    {
                        MessageBox.Show("Досягнуто максимуму кількості форм");
                        return;
                    }
            }
            switch (index)
            {
                case 1:
                    f = new FormLab9(this);
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
                case 2:
                    f = new FormLab10(this);
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
                case 3:
                    f = new FormLab11(this);
                    f.FormClosing += new FormClosingEventHandler(FormLab18_FormClosing);
                    break;
            }
            listForm.Add(f);
            countForm++;
            Counter();
            f.Show();
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

        public void Counter()
        {
            string ch = "∞";
            if (maxForm != -1)
            {
                ch = maxForm.ToString();
                while (Convert.ToInt32(ch) < maxForm)
                {
                    listForm[listForm.Count - 1].Close();
                    listForm.RemoveAt(listForm.Count - 1);
                }
            }
            toolStripStatusLabel1.Text = string.Format("Форм створено: {0}/{1}", countForm, ch);
        }

        private void buttonController_Click(object sender, System.EventArgs e)
        {
            if (controller == null)
            {
                controller = new FormControllerFor18Lab(this);
                Point point;
                point = this.Location;
                point.Offset(this.Width, 0);
                controller.Show();
                if (Equals(this.GetType(), new FormLab18().GetType()))
                {
                    controller.feature_for_lab19.Enabled = false;
                    controller.feature_for_lab19.Text = "Недоступно";
                }
                controller.Location = point;
            }
        }

        private void FormLab18_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.WindowState = FormWindowState.Normal;
            foreach (Form f in listForm)
                if (!f.IsDisposed)
                    f.Close();
            listForm.Clear();
            if (controller != null)
            {
                controller.Close();
            }
        }

        private void FormLab18_Move(object sender, EventArgs e)
        {
            if (controller != null)
            {
                controller.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
        }
    }
}

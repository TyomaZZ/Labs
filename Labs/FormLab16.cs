using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labs
{
    public partial class FormLab16 : Form
    {
        Form mother;
        public FormLab16(Form patric)
        {
            InitializeComponent();
            mother = patric;
        }

        Form stringer = null;
        Form matcher = null;
        Form calc = null;

        public virtual void buttonStringer_Click(object sender, EventArgs e)
        {
            builder(new FormLab16t1(this), ref stringer);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void builder(Form form, ref Form child)
        {
            if (child == null)
            {
                child = form;
                child.MinimizeBox = true;
                child.ShowInTaskbar = true;
                child.Show();
            }
            else
            {
                if (child.IsDisposed)
                {
                    child = form;
                    child.MinimizeBox = true;
                    child.ShowInTaskbar = true;
                    child.Show();
                }
                else
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;
                    else if (!child.Focused)
                        child.Focus();
                }
            }
        }

        public virtual void buttonMatcher_Click(object sender, EventArgs e)
        {
            builder(new FormLab16t2(this), ref matcher);
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        public virtual void buttonCalc_Click(object sender, EventArgs e)
        {
            builder(new FormLab16t3(this), ref calc);
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public virtual void buttonEnder_Click(object sender, EventArgs e)
        {
            if (stringer != null)
                stringer.Close();
            if (matcher != null)
                matcher.Close();
            if (calc != null)
                calc.Close();
        }

        public virtual void buttonCloser_Click(object sender, EventArgs e)
        {
            if (stringer != null)
                stringer.Close();
            if (matcher != null)
                matcher.Close();
            if (calc != null)
                calc.Close();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringer.Size = new Size(stringer.Width + 20, stringer.Height + 20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matcher.Size = new Size(matcher.Width - 20, matcher.Height - 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            matcher.Location = new Point(rnd.Next(Screen.PrimaryScreen.WorkingArea.Width - matcher.Width), rnd.Next(Screen.PrimaryScreen.WorkingArea.Height - matcher.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stringer.Size = new Size(stringer.Width - 20, stringer.Height - 20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            matcher.Location = new Point(rnd.Next(Screen.PrimaryScreen.WorkingArea.Width - stringer.Width), rnd.Next(Screen.PrimaryScreen.WorkingArea.Height - stringer.Height));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            matcher.Size = new Size(matcher.Width + 20, matcher.Height + 20);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calc.Size = new Size(calc.Width + 20, calc.Height + 20);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc.Size = new Size(calc.Width - 20, calc.Height - 20);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            calc.Location = new Point(rnd.Next(Screen.PrimaryScreen.WorkingArea.Width - calc.Width), rnd.Next(Screen.PrimaryScreen.WorkingArea.Height - calc.Height));
        }

        private void FormLab16_FormClosing(object sender, FormClosingEventArgs e)
        {
            mother.WindowState = FormWindowState.Normal;
        }
    }
    /* if (calc == null)
             {
                 calc = new FormLab11();
     calc.MinimizeBox = true;
                 calc.ShowInTaskbar = true;
                 calc.Show();
             }
             else
 {
     if (calc.IsDisposed)
     {
         calc = new FormLab11();
         calc.MinimizeBox = true;
         calc.ShowInTaskbar = true;
         calc.Show();
     }
     else
     {
         if (calc.WindowState == FormWindowState.Minimized)
             calc.WindowState = FormWindowState.Normal;
         else if (!calc.Focused)
             calc.Focus();
     }
 }
    */
}

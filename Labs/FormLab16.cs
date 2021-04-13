﻿using System;
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
    public partial class FormLab16 : Form
    {
        Form stringer = null;
        Form matcher = null;
        Form calc = null;
        public FormLab16()
        { InitializeComponent(); }

        private void buttonStringer_Click(object sender, EventArgs e)
        {
            builder(new FormLab9(), ref stringer);
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

        private void buttonMatcher_Click(object sender, EventArgs e)
        {
            builder(new FormLab10(), ref matcher);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            builder(new FormLab11(), ref calc); 
        }

        private void buttonEnder_Click(object sender, EventArgs e)
        {
            if (stringer != null)
                stringer.Close();
            if (matcher != null)
                matcher.Close();
            if (calc != null)
                calc.Close();
        }

        private void buttonCloser_Click(object sender, EventArgs e)
        {
            if (stringer != null)
                stringer.Close();
            if (matcher != null)
                matcher.Close();
            if (calc != null)
                calc.Close();
            Close();
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

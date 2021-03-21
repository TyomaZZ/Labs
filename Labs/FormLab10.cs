using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace Labs
{
    public partial class FormLab10 : Form
    {
        public FormLab10()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (Lib.ReleaseTextBox(sender).Text.Length == 0)
            {
                Lib.ReleaseTextBox(sender).Text = "0";
                Lib.ReleaseTextBox(sender).SelectAll();
            }
            if (Lib.ReleaseTextBox(sender).Text.IndexOf('-') != -1)
            {
                if (Lib.ReleaseTextBox(sender).Text.IndexOf('-') > 0)
                {
                    Lib.ReleaseTextBox(sender).Text = "-" + Lib.ReleaseTextBox(sender).Text.Replace("-", "");
                }
            }
            if (IsAllDouble())
            {
                if (radioMathWithoutF.Checked)
                {
                   textBoxResult.Text = Result();
                }
                if (radioMath.Checked)
                {
                   textBoxResult.Text = ResultF();
                }
            }
        }
        private bool IsDouble(TextBox element)
        {
            try
            {
                Convert.ToDouble(element.Text);
                element.ForeColor = Color.Black;
                return Swithcer(false, element);
            }
            catch (Exception)
            {
                element.ForeColor = Color.Red;
                return Swithcer(true, element);
            }
        }
        private bool Swithcer(bool result, TextBox element)
        {
            switch (element.Name)
            {
                case "textBoxX":
                    labelErrorX.Visible = result;
                    break;
                case "textBoxY":
                    labelErrorY.Visible = result;
                    break;
                case "textBoxZ":
                    labelErrorZ.Visible = result;
                    break;
                default:
                    break;
            }
            return !result;
        }
        private void Checker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioFormatStrong.Checked)
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }
                if (e.KeyChar == '-')
                {
                    if (Lib.ReleaseTextBox(sender).SelectionStart > 0)
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        e.Handled = false;
                        return;
                    }
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                      if ((Lib.ReleaseTextBox(sender).Text.IndexOf(',') == -1 || Lib.ReleaseTextBox(sender).SelectionLength == Lib.ReleaseTextBox(sender).Text.Length) && Lib.ReleaseTextBox(sender).SelectionStart > 0)
                      {
                          e.KeyChar = ',';
                          e.Handled = false;
                          return;
                      }
                }
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = false;
                return;
            }
            
        }
        private void radioMathWithoutF_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllDouble())
            {
                textBoxResult.Text = Result();
            }
            else
            {
                //
            }
            
        }
        private string Result()
        {
            double res = 0;
            res = (Math.Log10(Math.Abs(Math.Sin(Doubler(textBoxX.Text)) + Doubler(textBoxY.Text))) / 87)
                        + (234 / Math.Log10(Math.Abs(Math.Sin(Doubler(textBoxX.Text) * Doubler(textBoxY.Text)) + 3))
                        + Math.Log10(Math.Abs(Math.Sin(3.1) + Math.Pow(Doubler(textBoxX.Text), 2) * Doubler(textBoxY.Text))) / Doubler(textBoxZ.Text));
            return Convert.ToString(res);
        }
        private double Func(double first, double second) //lg + abs
        {
            double res = 0;
            res = Math.Log10(Math.Abs(Math.Sin(first) + second));
            return res;
        }
        private string ResultF()
        {
            double res = 0;
            res = (Func(Doubler(textBoxX.Text), Doubler(textBoxY.Text)) / 87) 
                + (234 / Func(Doubler(textBoxX.Text) * Doubler(textBoxY.Text), 3)) 
                + (Func(3.1, Math.Pow(Doubler(textBoxX.Text),2) * Doubler(textBoxY.Text)) / Doubler(textBoxZ.Text));
            return Convert.ToString(res);
        }
        public double Doubler(string converter)
        {
            return Convert.ToDouble(converter);
        }
        private bool IsAllDouble()
        {
            if (IsDouble(textBoxX) & IsDouble(textBoxY) & IsDouble(textBoxZ))
            {
                return true;
            }
            return false;
        }

        private void radioMath_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllDouble())
            {
                textBoxResult.Text = ResultF();
            }
            else
            {
                //
            }
        }
        private void FormLab10_Load(object sender, EventArgs e)
        {
            textBoxResult.Text = Result();
        }
    }
}

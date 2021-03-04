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
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).Text = "0";
                ((TextBox)sender).SelectAll();
            }
            if (IsDouble(textBoxX) & IsDouble(textBoxY) & IsDouble(textBoxZ))
            {
                if (radioButtonAction1.Checked)
                {
                    textBoxResult.Text = Convert.ToString(Result());
                }
                if (radioButtonAction2.Checked)
                {
                    textBoxResult.Text = Convert.ToString(ResultF());
                }
            }
            

        }
        private bool IsDouble(TextBox element)
        {
            try
            {
                Convert.ToDouble(element.Text);
                switch (element.Name)
                {
                    case "textBoxX":
                        labelErrorX.Visible = false;
                        break;
                    case "textBoxY":
                        labelErrorY.Visible = false;
                        break;
                    case "textBoxZ":
                        labelErrorZ.Visible = false;
                        break;
                    default:
                        break;
                }
                element.ForeColor = Color.Black;
                return true;
            }
            catch (Exception ex)
            {
                switch (element.Name)
                {
                    case "textBoxX":
                        labelErrorX.Visible = true;
                        break;
                    case "textBoxY":
                        labelErrorY.Visible = true;
                        break;
                    case "textBoxZ":
                        labelErrorZ.Visible = true;
                        break;
                    default:
                        break;
                }
                element.ForeColor = Color.Red;
                return false;
            }
        }
        private void Checker_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
           if (e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void radioButtonAction1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(Result());
        }
        private double Result()
        {
            double res = 0;
            res = ((Math.Log10(Math.Abs(Math.Sin(Convert.ToDouble(textBoxX.Text))) + Convert.ToDouble(textBoxY.Text))) / 87)
                        + (234 / (Math.Log10(Math.Abs(Math.Sin(Convert.ToDouble(textBoxX.Text) * Convert.ToDouble(textBoxY.Text) + 3))))
                        + (Math.Log10(Math.Abs(Math.Sin(3.1) + Math.Pow(Convert.ToDouble(textBoxX.Text), 2) * Convert.ToDouble(textBoxY.Text)))) / Convert.ToDouble(textBoxZ.Text));
            return res;
        }
        private double Func(double sin, double first, double second) //lg + abs
        {
            double res = 0;
            res = (Math.Log10(Math.Abs(Math.Sin(sin * first)) + second));
            return res;
        }
        private double ResultF()
        {
            double res = 0;
            res = (Func(Convert.ToDouble(textBoxX.Text), 1, Convert.ToDouble(textBoxY.Text)) / 87) 
                + (234 / Func(Convert.ToDouble(textBoxX.Text), Convert.ToDouble(textBoxY.Text), 3)) 
                + (Func(3.1, 1,Math.Pow(Convert.ToDouble(textBoxX.Text),2) * Convert.ToDouble(textBoxY.Text)) / Convert.ToDouble(textBoxZ.Text));
            return res;
        }
    }
}

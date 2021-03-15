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
{//tyomashi
    public partial class FormLab11 : Form
    {
        bool clean = false;
        double x, y, memory1;
        public FormLab11()
        {InitializeComponent();}
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.EndsWith("="))
            {
                textBoxNumbers.Text = "";
                textBoxResult.Text = "";
            }
            if (clean)
            {textBoxNumbers.Text = "";}
            textBoxNumbers.Text += ReleaseButton(sender).Text;
            clean = false;
        }
        private void buttonChar_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.IndexOf('-') == -1)
                textBoxNumbers.Text = textBoxNumbers.Text.Insert(0, "-");
            else
                textBoxNumbers.Text = textBoxNumbers.Text.Remove(0, 1);
            if (clean)
                textBoxNumbers.Text = "";
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.Length > 0)
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Remove(textBoxNumbers.Text.Length - 1);
                labelError.Visible = false;
            }
        }
        private void buttonClearE_Click(object sender, EventArgs e)
        { textBoxNumbers.Text = ""; }
        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text = "";
            textBoxResult.Text = "";
            labelError.Visible = false;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        { Close(); }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.IndexOf(',') == -1)
                textBoxNumbers.Text += ReleaseButton(sender).Text;
            if (clean)
                textBoxNumbers.Text = "";
        }
        private void textBoxNumbers_TextChanged(object sender, EventArgs e)
        {
            if (ReleaseTextBox(sender).Text == "00")
                ReleaseTextBox(sender).Text = "0";
            if (ReleaseTextBox(sender).Text == "-")
            {
                labelError.Text = "Мінус не може бути числом";
                labelError.Visible = true;
                return;
            }
            else
                labelError.Visible = false;
            if (ReleaseTextBox(sender).Text == ",")
            {
                labelError.Text = "Кома не може бути числом";
                labelError.Visible = true;
                return;
            }
            else
                labelError.Visible = false;
            
            if (ReleaseTextBox(sender).Text == "-,")
            {
                labelError.Text = "Символи не можуть бути числом";
                labelError.Visible = true;
                return;
            }
            else
                labelError.Visible = false;
        }
        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory1 = 0;
            textBoxMemory.Text = "";
        }
        private void buttonMR_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text != "")
                textBoxNumbers.Text = textBoxMemory.Text;
        }
        private void buttonMA_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
            {
                memory1 += Convert.ToDouble(textBoxNumbers.Text);
                textBoxMemory.Text = Convert.ToString(memory1);
            }
        }
        private void buttonMRe_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
            {
                memory1 -= Convert.ToDouble(textBoxNumbers.Text);
                textBoxMemory.Text = Convert.ToString(memory1);
            }  
        }
        private void buttonMT_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text != "")
                textBoxNumbers.Text += "" + Convert.ToString(memory1);
        }
        private void Operation(object element)
        {
            if (textBoxNumbers.Text == "" || textBoxNumbers.Text == "-" || textBoxNumbers.Text == "," || textBoxNumbers.Text == "-,")
                return;
            string[] chrs = new string[4] { "+", "-", "*", "/" };
            for (int i = 0; i < chrs.Length; i++)
            {
                if (textBoxResult.Text.EndsWith(chrs[i]) && !textBoxResult.Text.EndsWith(ReleaseButton(element).Text))
                {
                    if (clean)
                    {
                        textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1, 1) + ReleaseButton(element).Text;
                        return;
                    }
                    else
                    {
                        SubMath(element);
                    }
                }
            }
            if (textBoxResult.Text == "")
            {
                if (textBoxNumbers.Text != "")
                    textBoxResult.Text = textBoxNumbers.Text + " " + ReleaseButton(element).Text;
                textBoxNumbers.Text = "";
            }
            else
            {
                if (!clean)
                {
                    SubMath(element);
                }
            }
        }
        private void SubMath(object element)
        {
            if (textBoxResult.Text != "")
                x = Convert.ToDouble(textBoxResult.Text.Split(' ')[0]);
            if (textBoxNumbers.Text != "")
                y = Convert.ToDouble(textBoxNumbers.Text);
            if (Matches(x, y))
                return;
            textBoxResult.Text = textBoxNumbers.Text + " " + ReleaseButton(element).Text;
            clean = true; x = 0; y = 0;
        }
        private bool Matches(double x, double y)
        {
            if (textBoxResult.Text.EndsWith("+") && textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(x + y);
            if (textBoxResult.Text.EndsWith("-") && textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(x - y);
            if (textBoxResult.Text.EndsWith("*") && textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(x * y);
            if (textBoxResult.Text.EndsWith("/") && textBoxNumbers.Text != "")
            {
                if (y == 0)
                {
                    labelError.Visible = true;
                    labelError.Text = "Помилка при діленні на 0";
                    return true;
                }
                else
                    textBoxNumbers.Text = Convert.ToString(x / y);
            }
            return false;
        }
        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "" && textBoxNumbers.Text != "" && textBoxNumbers.Text != "-" && textBoxNumbers.Text != "," && textBoxNumbers.Text != "-," )
                textBoxResult.Text = textBoxNumbers.Text + " =";
            else
            {
                if (textBoxNumbers.Text == "" || textBoxNumbers.Text == "-" || textBoxNumbers.Text == "," || textBoxNumbers.Text == "-,")
                    return;
                if (!clean)
                {
                    if (textBoxResult.Text != "")
                        x = Convert.ToDouble(textBoxResult.Text.Split(' ')[0]);
                    if (textBoxNumbers.Text != "")
                        y = Convert.ToDouble(textBoxNumbers.Text);
                    if (Matches(x, y))
                        return;
                    if (textBoxResult.Text.EndsWith("+") && textBoxNumbers.Text != "")
                        textBoxResult.Text = Convert.ToString(x) + " + " + Convert.ToString(y) + " =";
                    if (textBoxResult.Text.EndsWith("-") && textBoxNumbers.Text != "")
                        textBoxResult.Text = Convert.ToString(x) + " - " + Convert.ToString(y) + " =";
                    if (textBoxResult.Text.EndsWith("*") && textBoxNumbers.Text != "")
                        textBoxResult.Text = Convert.ToString(x) + " * " + Convert.ToString(y) + " =";
                    if (textBoxResult.Text.EndsWith("/") && textBoxNumbers.Text != "")
                        textBoxResult.Text = Convert.ToString(x) + " / " + Convert.ToString(y) + " =";
                    clean = true; x = 0; y = 0;
                }
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        { Operation(sender);}
        private void buttonMinus_Click(object sender, EventArgs e)
        {Operation(sender);}
        private void buttonMnozh_Click(object sender, EventArgs e)
        {Operation(sender);}
        private void buttonDil_Click(object sender, EventArgs e)
        {Operation(sender);}
        private void buttonPow2_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBoxNumbers.Text), 2));
            if (textBoxResult.Text.EndsWith("="))
                textBoxResult.Text = "";
        }
        private void buttonKorin_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBoxNumbers.Text)));
            if (textBoxResult.Text.EndsWith("="))
                textBoxResult.Text = "";
        }
        private void button1dil_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
                textBoxNumbers.Text = Convert.ToString(1 / Convert.ToDouble(textBoxNumbers.Text));
            if (textBoxResult.Text.EndsWith("="))
                textBoxResult.Text = "";
        }
        private Button ReleaseButton(object element)
        { return (Button)element; }
        private TextBox ReleaseTextBox(object element)
        { return (TextBox)element; }
    }
}

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
            textBoxNumbers.Text += Lib.ReleaseButton(sender).Text;
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
                textBoxNumbers.Text += Lib.ReleaseButton(sender).Text;
            if (clean)
                textBoxNumbers.Text = "";
        }
        private void textBoxNumbers_TextChanged(object sender, EventArgs e)
        {
            if (Lib.ReleaseTextBox(sender).Text == "00")
                Lib.ReleaseTextBox(sender).Text = "0";
            if (Lib.ReleaseTextBox(sender).Text == "-")
            {
                labelError.Text = "Мінус не може бути числом";
                labelError.Visible = true;
                return;
            }
            else
             labelError.Visible = false;
            if (Lib.ReleaseTextBox(sender).Text == ",")
            {
                labelError.Text = "Кома не може бути числом";
                labelError.Visible = true;
                return;
            }
            else
             labelError.Visible = false;

            if (Lib.ReleaseTextBox(sender).Text == "-,")
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
            {
                textBoxNumbers.Text = "";
                textBoxNumbers.Text += "" + Convert.ToString(memory1);
            }  
        }
        private void Operation(object element)
        {
            string[] chrs = new string[4] { " + ", " - ", " * ", " / " };
            if (textBoxNumbers.Text == "" || textBoxNumbers.Text == "-" || textBoxNumbers.Text == "," || textBoxNumbers.Text == "-,")
                return;
            if (textBoxResult.Text.EndsWith(" + ") || textBoxResult.Text.EndsWith(" - ") || textBoxResult.Text.EndsWith(" * ") || textBoxResult.Text.EndsWith(" / "))
            {
                if (textBoxResult.Text.EndsWith(" " + Lib.ReleaseButton(element).Text + " "))
                {
                    if (textBoxNumbers.Text != "" && textBoxNumbers.Text != "-" && textBoxNumbers.Text != "," && textBoxNumbers.Text != "-,")
                    {
                        textBoxResult.Text += textBoxNumbers.Text + " " + Lib.ReleaseButton(element).Text + " ";
                        clean = true;
                    }
                }
                else
                {
                    for (int i = 0; i < chrs.Length; i++)
                    {
                        if (textBoxResult.Text.EndsWith(chrs[i]))
                        {
                            if (clean)
                            {
                                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 3, 3) + " " + Lib.ReleaseButton(element).Text + " ";
                                return;
                            }
                            else
                            {
                                if (textBoxNumbers.Text != "" && textBoxNumbers.Text != "-" && textBoxNumbers.Text != "," && textBoxNumbers.Text != "-,")
                                {
                                    textBoxResult.Text += textBoxNumbers.Text + " " + Lib.ReleaseButton(element).Text + " ";
                                    clean = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (textBoxNumbers.Text != "" && textBoxNumbers.Text != "-" && textBoxNumbers.Text != "," && textBoxNumbers.Text != "-,")
                {
                    textBoxResult.Text += textBoxNumbers.Text + " " + Lib.ReleaseButton(element).Text + " ";
                    clean = true;
                }
            }
        }
        private double SubMath()
        {
            y = 0;
            x = 0;
            string[] masiv = textBoxResult.Text.Split(' ');
            bool first = false;
            double z, c;
            string res = "";
            z = 0;
            c = 0;
            if (radioButton1.Checked)
            {
                for (int i = 0; i < masiv.Length; i++)
                {


                    if (masiv[i] == "*" || masiv[i] == "/")
                    {
                        if (masiv[i] == "*")
                        {
                            z = Convert.ToDouble(masiv[i - 1]) * Convert.ToDouble(masiv[i + 1]);
                            masiv[i - 1] = "";
                            masiv[i + 1] = Convert.ToString(z);
                            masiv[i] = "";
                        }
                        if (masiv[i] == "/")
                        {
                            if (Convert.ToDouble(masiv[i + 1]) == 0)
                            {
                                labelError.Text = "На 0 ділити не можливо";
                                labelError.Visible = true;
                                return 0;
                            }
                            z = Convert.ToDouble(masiv[i - 1]) / Convert.ToDouble(masiv[i + 1]);
                            masiv[i - 1] = "";
                            masiv[i + 1] = Convert.ToString(z);
                            masiv[i] = "";
                        }
                    }
                }
                string promezhUtok = "";
                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] != "")
                        promezhUtok += masiv[i] + " ";
                }
                masiv = promezhUtok.Split(' ');
            }
            

            for (int i = 0; i < masiv.Length; i++)
            { 
                if (masiv[i] != "+" && masiv[i] != "-" && masiv[i] != "*" && masiv[i] != "/")
                {}
                else
                {
                    if (masiv[i] == "+")
                    {
                        if (!first)
                        {
                            x = Convert.ToDouble(masiv[i - 1]) + Convert.ToDouble(masiv[i + 1]);
                            y = x;
                            first = true;
                        }
                        else
                        {
                            try
                            {
                                x = y + Convert.ToDouble(masiv[i + 1]);
                            }
                            catch
                            {
                                x = y + Convert.ToDouble(textBoxNumbers.Text);
                            }
                            y = x;
                        }
                    }
                    if (masiv[i] == "-")
                    {
                        if (!first)
                        {
                            x = Convert.ToDouble(masiv[i - 1]) - Convert.ToDouble(masiv[i + 1]);
                            y = x;
                            first = true;
                        }
                        else
                        {
                            try
                            {
                                x = y - Convert.ToDouble(masiv[i + 1]);
                            }
                            catch
                            {
                                x = y - Convert.ToDouble(textBoxNumbers.Text);
                            }
                            y = x;
                        }
                    }
                    if (masiv[i] == "*")
                    {
                        if (!first)
                        {
                            x = Convert.ToDouble(masiv[i - 1]) * Convert.ToDouble(masiv[i + 1]);
                            y = x;
                            first = true;
                        }
                        else
                        {
                            try
                            {
                                x = y * Convert.ToDouble(masiv[i + 1]);
                            }
                            catch
                            {
                                x = y * Convert.ToDouble(textBoxNumbers.Text);
                            }
                            y = x;
                        }
                    }
                    if (masiv[i] == "/")
                    {
                        if (!first)
                        {
                            x = Convert.ToDouble(masiv[i - 1]) / Convert.ToDouble(masiv[i + 1]);
                            y = x;
                            first = true;
                        }
                        else
                        {
                            try
                            {
                                x = y / Convert.ToDouble(masiv[i + 1]);
                            }
                            catch
                            {
                                x = y / Convert.ToDouble(textBoxNumbers.Text);
                            }
                            y = x;
                        }
                    }
                }
            }
            return y;
        }
        private void Matches()
        {
            if (textBoxResult.Text.EndsWith("+") || textBoxResult.Text.EndsWith("-") || textBoxResult.Text.EndsWith("*") || textBoxResult.Text.EndsWith("/"))
            {
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 3) + " =";
                textBoxNumbers.Text = Convert.ToString(SubMath());
            }
            else
            {
               
                    textBoxNumbers.Text = Convert.ToString(SubMath());
              
            }
        }
        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (!clean)
            {
                textBoxResult.Text += textBoxNumbers.Text;
                Matches();
                textBoxResult.Text += " =";
                clean = true;
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
    }
}

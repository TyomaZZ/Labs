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
        { InitializeComponent(); }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.EndsWith("="))
            {
                textBoxNowAndResult.Text = "";
                textBoxNumber.Text = "";
            }
            if (clean)
            {textBoxNowAndResult.Text = "";}
            textBoxNowAndResult.Text += Lib.ReleaseButton(sender).Text;
            clean = false;
        }
        private void buttonChar_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text.IndexOf('-') == -1)
                textBoxNowAndResult.Text = textBoxNowAndResult.Text.Insert(0, "-");
            else
                textBoxNowAndResult.Text = textBoxNowAndResult.Text.Remove(0, 1);
            if (clean)
                textBoxNowAndResult.Text = "";
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text.Length > 0)
            {
                textBoxNowAndResult.Text = textBoxNowAndResult.Text.Remove(textBoxNowAndResult.Text.Length - 1);
                labelError.Visible = false;
            }
        }
        private void buttonClearE_Click(object sender, EventArgs e)
        { textBoxNowAndResult.Text = ""; }
        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            textBoxNowAndResult.Text = "";
            textBoxNumber.Text = "";
            labelError.Visible = false;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        { Close(); }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text.IndexOf(',') == -1)
                textBoxNowAndResult.Text += Lib.ReleaseButton(sender).Text;
            if (clean)
                textBoxNowAndResult.Text = "";
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
                textBoxNowAndResult.Text = textBoxMemory.Text;
        }
        private void buttonMA_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text != "")
            {
                memory1 += Convert.ToDouble(textBoxNowAndResult.Text);
                textBoxMemory.Text = Convert.ToString(memory1);
            }
        }
        private void buttonMRe_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text != "")
            {
                memory1 -= Convert.ToDouble(textBoxNowAndResult.Text);
                textBoxMemory.Text = Convert.ToString(memory1);
            }  
        }
        private void buttonMT_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text != "")
            {
                textBoxNowAndResult.Text = "";
                textBoxNowAndResult.Text += "" + Convert.ToString(memory1);
            }  
        }
        private void Operation(object element)
        {
            string[] chrs = new string[4] { " + ", " - ", " * ", " / " };
            if (textBoxNowAndResult.Text == "" || textBoxNowAndResult.Text == "-" || textBoxNowAndResult.Text == "," || textBoxNowAndResult.Text == "-,")
                return;
            if (textBoxNumber.Text.EndsWith(" + ") || textBoxNumber.Text.EndsWith(" - ") || textBoxNumber.Text.EndsWith(" * ") || textBoxNumber.Text.EndsWith(" / "))
            {
                if (textBoxNumber.Text.EndsWith(" " + Lib.ReleaseButton(element).Text + " "))
                {
                    if (textBoxNowAndResult.Text != "" && textBoxNowAndResult.Text != "-" && textBoxNowAndResult.Text != "," && textBoxNowAndResult.Text != "-,")
                    {
                        textBoxNumber.Text += textBoxNowAndResult.Text + " " + Lib.ReleaseButton(element).Text + " ";
                        clean = true;
                    }
                }
                else
                {
                    for (int i = 0; i < chrs.Length; i++)
                    {
                        if (textBoxNumber.Text.EndsWith(chrs[i]))
                        {
                            if (clean)
                            {
                                textBoxNumber.Text = textBoxNumber.Text.Remove(textBoxNumber.Text.Length - 3, 3) + " " + Lib.ReleaseButton(element).Text + " ";
                                return;
                            }
                            else
                            {
                                if (textBoxNowAndResult.Text != "" && textBoxNowAndResult.Text != "-" && textBoxNowAndResult.Text != "," && textBoxNowAndResult.Text != "-,")
                                {
                                    textBoxNumber.Text += textBoxNowAndResult.Text + " " + Lib.ReleaseButton(element).Text + " ";
                                    clean = true;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (textBoxNowAndResult.Text != "" && textBoxNowAndResult.Text != "-" && textBoxNowAndResult.Text != "," && textBoxNowAndResult.Text != "-,")
                {
                    textBoxNumber.Text += textBoxNowAndResult.Text + " " + Lib.ReleaseButton(element).Text + " ";
                    clean = true;
                }
            }
        }
        private double SubMath()
        {
            y = 0;
            x = 0;
            string[] masiv = textBoxNumber.Text.Split(' ');
            bool first = false;
            double z;
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
                                x = y + Convert.ToDouble(textBoxNowAndResult.Text);
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
                                x = y - Convert.ToDouble(textBoxNowAndResult.Text);
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
                                x = y * Convert.ToDouble(textBoxNowAndResult.Text);
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
                                x = y / Convert.ToDouble(textBoxNowAndResult.Text);
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
            if (textBoxNumber.Text.EndsWith("+") || textBoxNumber.Text.EndsWith("-") || textBoxNumber.Text.EndsWith("*") || textBoxNumber.Text.EndsWith("/"))
            {
                textBoxNumber.Text = textBoxNumber.Text.Remove(textBoxNumber.Text.Length - 3) + " =";
                textBoxNowAndResult.Text = Convert.ToString(SubMath());
            }
            else
            {
               
                    textBoxNowAndResult.Text = Convert.ToString(SubMath());
              
            }
        }
        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (!clean)
            {
                textBoxNumber.Text += textBoxNowAndResult.Text;
                Matches();
                textBoxNumber.Text += " =";
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
            if (textBoxNowAndResult.Text != "")
                textBoxNowAndResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBoxNowAndResult.Text), 2));
            if (textBoxNumber.Text.EndsWith("="))
                textBoxNumber.Text = "";
        }
        private void buttonKorin_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text != "")
                textBoxNowAndResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBoxNowAndResult.Text)));
            if (textBoxNumber.Text.EndsWith("="))
                textBoxNumber.Text = "";
        }
        private void button1dil_Click(object sender, EventArgs e)
        {
            if (textBoxNowAndResult.Text != "")
                textBoxNowAndResult.Text = Convert.ToString(1 / Convert.ToDouble(textBoxNowAndResult.Text));
            if (textBoxNumber.Text.EndsWith("="))
                textBoxNumber.Text = "";
        }
    }
}

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
    public partial class FormLab9 : Form
    {
        public FormLab9()
        {
            InitializeComponent();
        }
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonAction1.Checked || radioButtonAction2.Checked)
            {
                if (radioButtonAction1.Checked)
                {
                    textBoxResult.Text = ReplaceK(textBoxInput.Text, textBoxCell1.Text);
                }
                if (radioButtonAction2.Checked)
                {
                    textBoxResult.Text = Doubler(textBoxInput.Text, textBoxCell2.Text);
                }
            }
            else
            {
                textBoxResult.Text = textBoxInput.Text;
            }
        }
        private void buttonCloseAction_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void radioButtonAction1_CheckedChanged(object sender, EventArgs e) 
        {
            textBoxResult.Text = ReplaceK(textBoxInput.Text, textBoxCell1.Text);
        }
        private void radioButtonAction2_CheckedChanged(object sender, EventArgs e) 
        {
            textBoxResult.Text = Doubler(textBoxInput.Text, textBoxCell2.Text);
        }
        String result = "";
        private String ReplaceK(String s, String cell)
        {
            result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!String.Equals(s[i].ToString(), cell, StringComparison.OrdinalIgnoreCase))
                {
                    result += s[i];
                }
            }
            return result;
        }
        private String Doubler(String s, String cell)
        {
            result = "";
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i];
                if (!String.Equals(s[i].ToString(), cell))
                {
                    result += s[i];
                }
            }
            return result;
        }

        private void textBoxCell1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCell1.Text.Length > 1)
            {
                textBoxCell1.Text =  textBoxCell1.Text.Remove(1);
                //textBoxCell1.SelectionStart = 1;
            }
            if (radioButtonAction1.Checked)
            {
                textBoxResult.Text = ReplaceK(textBoxInput.Text, textBoxCell1.Text);
            }
            
        }

        private void textBoxCell2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCell2.Text.Length > 1)
            {
                textBoxCell2.Text = textBoxCell2.Text.Remove(1);
                //textBoxCell1.SelectionStart = 1;
            }
            if (radioButtonAction2.Checked)
            {
                textBoxResult.Text = Doubler(textBoxInput.Text, textBoxCell2.Text);
            }
        }

        private void textBoxCell2_Click(object sender, EventArgs e)
        {
            radioButtonAction2.Checked = true;
        }

        private void textBoxCell1_Click(object sender, EventArgs e)
        {
            radioButtonAction1.Checked = true;
        }
    }
}

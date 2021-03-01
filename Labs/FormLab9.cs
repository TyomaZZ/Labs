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
                    textBoxResult.Text = ReplaceK(textBoxInput.Text);
                }
                if (radioButtonAction2.Checked)
                {
                    textBoxResult.Text = Doubler(textBoxInput.Text);
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
            textBoxResult.Text = ReplaceK(textBoxInput.Text);
        }
        private void radioButtonAction2_CheckedChanged(object sender, EventArgs e) 
        {
            textBoxResult.Text = Doubler(textBoxInput.Text);
        }
        String result = "";
        private String ReplaceK(String s)
        {
            result = "";
            result = s.Replace("к", ""); 
            result = result.Replace("К", "");
            return result;
        }
        private String Doubler(String s)
        {
            result = "";
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i];
                if (!String.Equals(s[i].ToString(), "?"))
                {
                    result += s[i];
                }
            }
            return result;
        }
    }
}

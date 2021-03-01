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
    public partial class FormLab9 : Form
    {
        public FormLab9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    String result = "";
                    result = textBox1.Text.Replace("к", ""); result = result.Replace("К", "");
                    textBox2.Text = result;
                }
                if (radioButton2.Checked)
                {
                    String s = textBox1.Text;
                    String cell = "?";
                    String result = "";
                    for (int i = 0; i < s.Length; i++)
                    {
                        result += s[i];
                        if (!String.Equals(s[i].ToString(), cell))
                        {
                     
                                result += s[i];
                           
                            
                        }
                    }
                    textBox2.Text = result;
                }
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String result = "";
            result = textBox1.Text.Replace("к", ""); result = result.Replace("К", "");
            textBox2.Text = result;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            String cell = "?";
            String result = "";
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i];
                if (!String.Equals(s[i].ToString(), cell))
                {

                    result += s[i];


                }
            }
            textBox2.Text = result;
        }
    }
}

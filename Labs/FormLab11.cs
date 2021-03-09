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
        double x, y, memory1;
        public FormLab11()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += ReleaseButton(sender).Text;
        }
        private Button ReleaseButton(object element)
        {
            return (Button)element;
        }
        private TextBox ReleaseTextBox(object element)
        {
            return (TextBox)element;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.Length > 0)
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Remove(textBoxNumbers.Text.Length - 1);
            }
        }
        private void textBoxNumbers_TextChanged(object sender, EventArgs e)
        {
            if (ReleaseTextBox(sender).Text == "0")
            {
                ReleaseTextBox(sender).Text = "";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.IndexOf(',') == -1)
            {
                textBoxNumbers.Text += ReleaseButton(sender).Text;
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory1 = 0;
            textBoxMemory.Text = "";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            if (textBoxMemory.Text != "")
            {
                textBoxNumbers.Text = textBoxMemory.Text;
            }
        }

        private void buttonMA_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text != "")
            {
                textBoxMemory.Text = textBoxNumbers.Text;
                memory1 = Convert.ToDouble(textBoxMemory.Text);
            }
        }

        private void buttonMRe_Click(object sender, EventArgs e)
        {
            memory1 = 0;
            textBoxMemory.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            ReleaseButton(sender).BackColor = Color.Red;
            ReleaseButton(sender).Enabled = false;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            textBoxNumbers.Text = x + y + "";
            buttonPlus.BackColor = Color.White;
            buttonPlus.Enabled = true;
            x = 0; y = 0;
        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.IndexOf('-') == -1)
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Insert(0, "-");
            }
            else
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Remove(0, 1);
            }
        }

        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text = "";
            x = 0; y = 0;
        }
    }
}

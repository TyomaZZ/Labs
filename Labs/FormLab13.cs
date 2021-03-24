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
    public partial class FormLab13 : Form
    {
        
        public FormLab13()
        {
            InitializeComponent();
        }

        private void FormLab13_Load(object sender, EventArgs e)
        {
            Result();
        }
        protected virtual void Result()
        {
            PIB.Text = PIBs();
            LastNameAndI.Text = LastNameAndIs();
            EName.Text = ENames();
        }
        private string PIBs()
        {
            return CorrectS(LastName.Text) + " " + CorrectS(FirstName.Text) + " " + CorrectS(FatherName.Text);
        }
        private string LastNameAndIs()
        {
            return CorrectS(LastName.Text) + " " + FirstName.Text.Substring(0, 1).ToUpper() + "." + FatherName.Text.Substring(0, 1).ToUpper() + ".";
        }
        private string ENames()
        {
            return FirstName.Text.Substring(0, 1).ToUpper() + " " + FatherName.Text.Substring(0, 1).ToUpper() + " " + LastName.Text.ToUpper();
        }
        private string CorrectS(string text)
        {
            return text.Trim().Substring(0, 1).ToUpper() + text.Trim().Substring(1, text.Trim().Length - 1).ToLower();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            if (((TextBox)sender).Text != "")
            {
                ((TextBox)sender).BackColor = Color.White;
                Result();
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

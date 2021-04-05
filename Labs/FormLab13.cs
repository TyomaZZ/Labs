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
            labelName.Text = CorrectS(FirstName.Text);
            labelLastName.Text = CorrectS(LastName.Text);
            labelFatherName.Text = CorrectS(FatherName.Text);
            Result();
        }
        protected virtual void Result()
        {
            CardPIB.Text = String.Format("ПІБ: {0}", PIBs().Trim());
            Inits.Text = String.Format("Прізвище та ініціали: {0}", LastNameAndIs().Trim());
            ENamer.Text = String.Format("Підпис: {0}", ENames().Trim());
        }
        private string PIBs()
        {
            return CorrectS(LastName.Text) + " " + CorrectS(FirstName.Text) + " " + CorrectS(FatherName.Text);
        }
        private string LastNameAndIs()
        {
            return CorrectS(LastName.Text) + " " + CorrectS(FirstName.Text).Substring(0, 1) + "." + CorrectS(FatherName.Text).Substring(0, 1) + ".";
        }
        private string ENames()
        {
            return CorrectS(FirstName.Text).Substring(0, 1) + " " + CorrectS(FatherName.Text).Substring(0, 1) + " " + CorrectS(LastName.Text).ToUpper();
        }
        public string CorrectS(string text)
        { 
           if (text != "") 
                return text.Trim().Substring(0, 1).ToUpper() + text.Trim().Substring(1, text.Trim().Length - 1).ToLower();
           else 
                return " ";
        }
        protected virtual void TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            if (((TextBox)sender).Text != "")
                ((TextBox)sender).BackColor = Color.White;
            else 
                ((TextBox)sender).BackColor = Color.Red;
            labelName.Text = String.Format("Ім'я: {0}", CorrectS(FirstName.Text));
            labelLastName.Text = String.Format("Прізвище: {0}", CorrectS(LastName.Text));
            labelFatherName.Text = String.Format("По батькові: {0}", CorrectS(FatherName.Text));
            Result();
        }
        protected virtual void buttonClose_Click(object sender, EventArgs e)
        { Close(); }
    }
}

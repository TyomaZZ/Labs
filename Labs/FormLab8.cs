using Microsoft.VisualBasic;
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
    public partial class FormLab8 : Form
    {
        public FormLab8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //tyomashi
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            string cell = "к";
            string s = Interaction.InputBox("Введіть слово, словосполучення або речення для взаємодії", "Введення", "Приклад");
            //result = s.Replace("к", ""); result = result.Replace("К", "");
            for (int i = 0; i < s.Length; i++)
            {
                if (!String.Equals(s[i].ToString(), cell, StringComparison.OrdinalIgnoreCase)) {
                    result += s[i];
                }
            }
            MessageBox.Show("Стартова строка: " + s + "\nРезультат дії: " + result, "Результат");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";
            string cell = "?";
            string s = Interaction.InputBox("Введіть слово, словосполучення або речення для взаємодії", "Введення", "Приклад?");
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i];
                if (!String.Equals(s[i].ToString(), cell))
                {
                    result += s[i];
                }
            }
            MessageBox.Show("Стартова строка: " + s + "\nРезультат дії: " + result, "Результат");
        }
    }
}

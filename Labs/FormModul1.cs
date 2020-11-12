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
    public partial class FormModul1 : Form
    {
        public FormModul1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            //tyomashi
        }

        static bool InputDouble(ref double x, string mess)
        {
            string s;

        Povtor:
            s = Interaction.InputBox(mess, "Введення", x.ToString());
            try
            {
                x = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto Povtor;
                else { return false; }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            string cell = ",";
            string s = Interaction.InputBox("Введіть слово, словосполучення або речення для взаємодії", "Введення", "Приклад,");
            //result = s.Replace(",", "??");
            for (int i = 0; i < s.Length; i++)
            {
                if (!String.Equals(s[i].ToString(), cell))
                {
                    result += s[i];
                }
                else result += "??";
            }
            MessageBox.Show("Стартова строка: " + s + "\nРезультат дії: " + result, "Результат");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string results;
            Double x = 0, y = 0, v = 350, g = 9.8, a = Math.PI / 4;
            if (!InputDouble(ref v, "Введіть початкову швидкість"))
                return;
            results = "Результат обчислення задачі: \n";
            for (int i = 0; i < 5; i++)
            {
                x = v * i * Math.Cos(a);
                y = v * i * Math.Sin(a) - ((g * Math.Pow(i, 2)) / 2);
                if (i == 1 || i == 2 || i == 4)
                  results += i + " секунда: X= " + x + ", Y= " + y + "\n" ;
            }
            MessageBox.Show("Вхідні дані:\nШвидкість - " + v + "км/год\n" + "Альфа - " + a + " градусів\n" + "Вільне падіння - " + g + "км/год\n" + results, "Результати табулювання", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
{//tyomashi
    public partial class FormLab7 : Form
    {
        Double x1 = 12.743, y1 = 0.654, z1 = 0.0208, x2 = 10, x3, dx3 = 0.2, xp3 = 1.2;
        Form father;

        public FormLab7(Form patric)
        {
            InitializeComponent();
            father = patric;
        }

        private void FormLab7_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }

        static bool InputDouble(ref double x, string mess)
        {
        Povtor:
            try
            {
                x = Convert.ToDouble(Interaction.InputBox(mess, "Введення", x.ToString()));
            }
            catch(System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto Povtor;
                else { return false; }
            }
            return true;
        }

        static bool InputInt(ref int x, string mess)
        {
        Povtor:
            try
            {
                x = Convert.ToInt32(Interaction.InputBox(mess, "Введення", x.ToString()));
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число.\nБажаєте повторити?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto Povtor;
                else { return false; }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double result;
            if (!InputDouble(ref x1, "Введіть значення x"))
                return;
            if (!InputDouble(ref y1, "Введіть значення y"))
                return;
            if (!InputDouble(ref z1, "Введіть значення z"))
                return;
            result = (x1 * y1 - 4 * z1) / (x1 + 4 * y1);
            MessageBox.Show("При:\nx= " + x1 + "\ny= " + y1 + "\nz= " + z1 + "\n\nОбчислено значення виразу: " + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double result;
            int asd;
            if (!InputDouble(ref x2, "Введіть значення x"))
                return;
            if (x2 > 1 && x2 <= 12)
            {
                result = 2 * Math.Pow(x2, 3) * Math.Sqrt(Math.Pow(x2, 2) + 5);
                asd = 1;
            }
            else
             if (x2 <= 1 && x2 > 0)
             {
                result = Math.Atan(x2);
                asd = 2;
             }
             else { result = Math.Pow(Math.E, x2 + 3); asd = 3; }
            MessageBox.Show("При x= " + x2 + "\nОбчисленно значення виразу: " + result + "\nВикористано №" + asd + " формулу", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Double result;
            String results;
            int n = 7;
            if (!InputDouble(ref xp3, "Введіть початок проміжку табулювання"))
                return;
            if (!InputDouble(ref dx3, "Введіть крок"))
                return;
            if (!InputInt(ref n, "Введіть кількість точок"))
                return;
            results = "Протабульована функція:\n  x\t  y";
            for (int i = 0; i < n; i++)
            {
                x3 = xp3 + i * dx3;
                result = (x3 + Math.Cos(2 * x3) / (3 * x3));
                results += "\n" + x3 + "\t" + result;
            }
            MessageBox.Show(results, "Результати табулювання", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class FormLab5new : Form
    {
        Kurtka k1 = null, k2 = null;
        public FormLab5new()
        { InitializeComponent();}
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            //tyomashi
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (k2 == null)
            {
                k2 = new Kurtka("невідома", "Синій", 42);
                button8.Enabled = true; button9.Enabled = true; 
                button10.Enabled = true; button11.Enabled = true;
            }
            else
            {
                MessageBox.Show("На данний момент друга куртка уже створена!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String name = k1.Name;
            name = Convert.ToString(Interaction.InputBox("Введіть нову назву для першої куртки\n", 
                "Змінюємо назву з " + name, ""));
            k1.Name = name;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            k1 = null;
            button3.Enabled = false; button4.Enabled = false; 
            button5.Enabled = false; button6.Enabled = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            k2 = null;
            button8.Enabled = false; button9.Enabled = false; 
            button10.Enabled = false; button11.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        { k1.Info(); }
        private void button4_Click(object sender, EventArgs e)
        {
            int size = k1.Size;
            size = Convert.ToInt32(Interaction.InputBox("Введіть новий розмір для першої куртки\n", 
                "Змінюємо розмір з " + k1.Size, ""));
            k1.Size = size;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            String name = k2.Name;
            name = Convert.ToString(Interaction.InputBox("Введіть нову назву для другої куртки\n", 
                "Змінюємо назву з " + name, ""));
            k2.Name = name;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int size = k2.Size;
            size = Convert.ToInt32(Interaction.InputBox("Введіть новий розмір для другої куртки\n", "Змінюємо розмір з " + k2.Size, ""));
            k2.Size = size;
        }
        private void button10_Click(object sender, EventArgs e)
        { k2.Info(); }
        private void button1_Click(object sender, EventArgs e)
        {
            if (k1 == null)
            {
                k1 = new Kurtka("Улюблена", "Зелений", 36);
                button3.Enabled = true; button4.Enabled = true; 
                button5.Enabled = true; button6.Enabled = true; 
            }
            else
            {
                MessageBox.Show("На данний момент перша куртка уже створена!");
            }
        }
    }
    public abstract class Odyag 
        {
        public static int count;
        public int nomer;
        public String color, status;
        public bool isFreak;
        public Odyag()
        {
            count++;
            nomer = count;
        }
        ~Odyag()
        {
            /*  MessageBox.Show("Знищується Верхній Одяг №" + nomer,
                  "Увага",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation); */
            count--;
            //FormLab5.asd.Text = "Кількість об'єктів: " + count;
        }
        virtual public void Info()
        {
            /* MessageBox.Show("Верхній одяг №" + nomer + " створено",
                 "Інформація",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information); */
        }
    }

    public class Kurtka : Odyag
    {
        private String name;
        private int size;
        public int Size { get { return size; } set { if (value >= 0) { size = value; return; } else { MessageBox.Show("Значення не може бути від'ємним"); return; } } }
        public String Name { get { return name; } set { if (value.Equals("")) { MessageBox.Show("Ім'я не може бути пусте!"); return; } else { name = value; }  } }
        public Kurtka(String name, String color, int size) : base()
        {
            base.Info();
            Name = name; this.color = color; Size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потаскана"))
                    return "Жахлива куртка";
                else return "Досить мила куртка...";
            else return "Класна куртка :р";
        }
        public string SizeString()
        {
            if (size > 25)
                if (size < 55)
                    return "Ця куртка навіть могла б підійти для тебе";
                else return "Ця куртка завелика для тебе!";
            else return "Ця куртка замала для тебе!";
        }
        public override void Info()
        {
            MessageBox.Show("Куртка бренду: " + Name + "\n" + color + " колiр\nРозмір: " + Size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

}

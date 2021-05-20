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
        Form father;
        public FormLab5new(Form patric)
        { 
            InitializeComponent();
            father = patric;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (k2 == null)
            {
                k2 = new Kurtka("Невідома", "Синій", 42);
                Buttons_k2(true);
            }
            else
                MessageBox.Show("На данний момент друга куртка уже створена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (k1 != null)
            {
                k1.Name = Convert.ToString(Interaction.InputBox("Введіть нову назву для першої куртки\n", "Змінюємо назву з " + k1.Name, ""));
            }
            else MessageBox.Show("Сталася помилка", "Як взагалі до цього дійшло?");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k1 = null;
            Buttons_k1(false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            k2 = null;
            Buttons_k2(false);
        }

        private void button5_Click(object sender, EventArgs e)
        { k1.Info(); }

        private void button4_Click(object sender, EventArgs e)
        {
            if (k1 != null)
            {
                k1.Size = Convert.ToInt32(Interaction.InputBox("Введіть новий розмір для першої куртки\n", "Змінюємо розмір з " + k1.Size, ""));
            }
            else MessageBox.Show("Сталася помилка", "Як взагалі до цього дійшло?");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (k2 != null)
            {
                k2.Name = Convert.ToString(Interaction.InputBox("Введіть нову назву для другої куртки\n", "Змінюємо назву з " + k2.Name, ""));
            }
            else MessageBox.Show("Сталася помилка", "Як взагалі до цього дійшло?");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (k2 != null)
            {
                k2.Size = Convert.ToInt32(Interaction.InputBox("Введіть новий розмір для другої куртки\n", "Змінюємо розмір з " + k2.Size, ""));
            }
            else MessageBox.Show("Сталася помилка", "Як взагалі до цього дійшло?");
        }

        private void button10_Click(object sender, EventArgs e)
        { k2.Info(); }

        private void button_first_object_creater_Click(object sender, EventArgs e)
        {
            if (k1 == null)
            {
                k1 = new Kurtka("Улюблена", "Зелений", 36);
                Buttons_k1(true);
            }
            else
                MessageBox.Show("На данний момент перша куртка уже створена!");
        }

        public void Buttons_k1(bool status)
        {
            button3.Enabled = status; button4.Enabled = status;
            button5.Enabled = status; button6.Enabled = status;
        }

        private void FormLab5new_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }

        public void Buttons_k2(bool status)
        {
            button8.Enabled = status; button9.Enabled = status;
            button10.Enabled = status; button11.Enabled = status;
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
            //
        }
        virtual public void Info()
        {
            //
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
            Random rnd = new Random(); if (rnd.Next(0, 2) == 0) isFreak = false; else isFreak = true;
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

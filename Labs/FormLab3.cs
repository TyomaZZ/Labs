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
    public partial class lab3_Form : Form
    {
        public static int result_lab3 = 0; //
        Form father;

        public lab3_Form(Form patric)
        {
            InitializeComponent();
            father = patric;
        }
                //Методи кнопок для лабараторної №2_________
        private void lab3_exitButton_Click(object sender, EventArgs e)  //Спільний метод для кнопки закриття лабараторної.
        {
            MessageBox.Show("Всього знищенно об'єктів лабараторної роботи №3 за весь час\nроботи додатку \"Labs\" : " + result_lab3,
                "Ваш результат: " + result_lab3);
            Close();
        }
        //_мій_варіант_№7____________________________________________________________________________________________________________________
        private void lab3_var7_button1_Click(object sender, EventArgs e)
        {
            new Outerwear_Lab3();
        }
        private void lab3_var7_button2_Click(object sender, EventArgs e)
        {
            new Blouse_Lab3();
        }
        private void lab3_var7_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для кофти\n", "Створюємо кофту", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            new Blouse_Lab3(name_cons, color_cons, size_cons);
        }
        private void lab3_var7_button3_Click(object sender, EventArgs e)
        {
            new Jacket_Lab3();
        }
        private void lab3_var7_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо куртку", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            new Jacket_Lab3(name_cons, color_cons, size_cons);
        }
        private void lab3_var7_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Outerwear_Lab3.count,
                "Але напевно що уже не " + Outerwear_Lab3.count);
        }

        private void lab3_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }
        //___________________________________________________________ _______________________________________________________________________
    }
                                  //Класи для лабараторної №3________
    //_мій_варіант_№7________________________________________________ _______________________________________________________________________
    public class Outerwear_Lab3
    {
        public String name, color, status;
        public static int count;
        public int nomer, size;
        public bool isFreak;
        public Outerwear_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Outerwear_Lab3()
        {
            MessageBox.Show("Знищується Верхній Одяг №" + nomer,
                "Увага",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Верхній одяг №" + (count + 1) + " створено",
                "Інформація",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }      //Верхній одяг         /Варіант №7
    public class Blouse_Lab3 : Outerwear_Lab3
    {
        public Blouse_Lab3()
        {
            this.name = "Abibas"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
            Info();
        }
        public Blouse_Lab3(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
            Info();
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потаскана"))
                    return "Жахлива кофта";
                else return "Досить мила кофта...";
            else return "Класна кофта :р";
        }
        public string SizeString()
        {
            if (size > 25)
                if (size < 55)
                    return "Ця кофта навіть могла б підійти для тебе";
                else return "Ця кофта завелика для тебе!";
            else return "Ця кофта замала для тебе!";
        }
        public void Info()
        {
            MessageBox.Show("Кофта бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa кофта",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Jacket_Lab3 : Outerwear_Lab3
    {
        public Jacket_Lab3()
        {
            this.name = "Пума"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
            Info();
        }
        public Jacket_Lab3(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
            Info();
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
        public void Info()
        {
            MessageBox.Show("Куртка бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa Куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    //___________________________________________________________ ____________________________________________________________________________________
}

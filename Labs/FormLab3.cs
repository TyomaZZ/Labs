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
    public partial class FormLab3 : Form
    {
        public FormLab3()
        {
            InitializeComponent();
        }
        private void button49_Click(object sender, EventArgs e)
        {
            Outerwear_Lab3 wear = new Outerwear_Lab3();
            //wear.InfoLab3();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Blouse wear2 = new Blouse();
            //wear2.InfoLab3();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Jacket wear3 = new Jacket();
            //wear3.InfoLab3();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для кофти\n", "Створюємо кофту", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            Blouse wear2 = new Blouse(name_cons, color_cons, size_cons);
            //wear2.InfoLab3();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо куртку", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            Jacket wear2 = new Jacket(name_cons, color_cons, size_cons);
            //wear2.InfoLab3();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Outerwear_Lab3.count, "Але напевно що уже не " + Outerwear_Lab3.count);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plane_Lab3 plane = new Plane_Lab3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArmyPlane plane = new ArmyPlane();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CivPlane plane = new CivPlane();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для воєнного літака\n", "Створюємо Воєнний Літак", "Бомбардувальник"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "15"));
            ArmyPlane plane2 = new ArmyPlane(name_cons, color_cons, size_cons);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для цивільного літака\n", "Створюємо Цивільний Літак", "Вантажний"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "50"));
            CivPlane plane2 = new CivPlane(name_cons, color_cons, size_cons);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Plane_Lab3.count, "Але напевно що уже не " + Plane_Lab3.count);
        }
    }
    public partial class Outerwear_Lab3
    {
        public static int count;
        int nomer;
        public Outerwear_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Outerwear_Lab3()
        {
            MessageBox.Show("Знищується Верхній Одяг №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Верхній одяг №" + (count + 1) + " створено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class Blouse : Outerwear_Lab3
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Blouse()
        {
            this.name = "Abibas"; this.color = "Зелена"; this.size = 36; this.status = "Новa"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Blouse(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потаскана"))
                    return "Жахлива кофта";
                else return "Досить мила кофта...";
            else return "Класна кофта :р";
        }
        public string isDone()
        {
            if (size > 25)
            {
                if (size < 55)
                {
                    return "Ця кофта навіть могла б підійти для тебе";
                }
                else return "Ця кофта завелика для тебе!";
            }
            else return "Ця кофта замала для тебе!";
        }
        public void Info()
        {
            MessageBox.Show("Кофта бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такa кофта",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    public partial class Jacket : Outerwear_Lab3
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Jacket()
        {
            this.name = "Пума"; this.color = "Зелена"; this.size = 36; this.status = "Новa"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Jacket(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потаскана"))
                    return "Жахлива куртка";
                else return "Досить мила куртка...";
            else return "Класна куртка :р";
        }
        public string isDone()
        {
            if (size > 25)
            {
                if (size < 55)
                {
                    return "Ця куртка навіть могла б підійти для тебе";
                }
                else return "Ця куртка завелика для тебе!";
            }
            else return "Ця куртка замала для тебе!";
        }
        public void Info()
        {
            MessageBox.Show("Куртка бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такa Куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class Plane_Lab3
    {
        public static int count;
        int nomer;
        public Plane_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Plane_Lab3()
        {
            MessageBox.Show("Знищується Літак №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Літак №" + (count + 1) + " створено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class ArmyPlane : Plane_Lab3
    {
        String name, color, status;
        int size;
        bool isFly;
        public ArmyPlane()
        {
            this.name = "Винищувач"; this.color = "Сірий"; this.size = 6; this.status = "Новий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public ArmyPlane(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public string isFlys()
        {
            if (isFly == false)
                if (status.Equals("Ветеран"))
                    return "Старий воєнний літак";
                else return "Не літає уже давно";
            else return "Готовий до бойових дій";
        }
        public string isDone()
        {
            if (size > 4)
            {
                if (size < 7)
                {
                    return "Звичайного розміру літак";
                }
                else return "Великий літак";
            }
            else return "Літачок";
        }
        public void Info()
        {
            MessageBox.Show("Воєнний літак з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFlys() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий літак",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    public partial class CivPlane : Plane_Lab3
    {
        String name, color, status;
        int size;
        bool isFly;
        public CivPlane()
        {
            this.name = "Пасажирський"; this.color = "Синій"; this.size = 35; this.status = "Новий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public CivPlane(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public string isFreaks()
        {
            if (isFly == false)
                if (status.Equals("Поганий"))
                    return "Не придатний для польотів";
                else return "Не придатний для транспортування людей";
            else return "Літак для транспорування людей";
        }
        public string isDone()
        {
            if (size > 25)
            {
                if (size < 60)
                {
                    return "Стандартний цивільний літак";
                }
                else return "Великий цивільний літак";
            }
            else return "Маленькій цивільний літак";
        }
        public void Info()
        {
            MessageBox.Show("Літак з назвою: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий Літак",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}

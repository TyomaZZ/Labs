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
    public partial class FormLab3 : Form
    {
        public static int result_lab3 = 0;
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

        private void button14_Click(object sender, EventArgs e)
        {
            Fish_Lab3 fish = new Fish_Lab3();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OceanicFish fish = new OceanicFish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для океанічної риби\n", "Створюємо Океанічну рибу", "Риба-молот"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Темно-сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            OceanicFish fish2 = new OceanicFish(name_cons, color_cons, size_cons);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClassicFish fish = new ClassicFish();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для прісноводної риби\n", "Створюємо Прісноводну рибу", "Сом"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "1"));
            ClassicFish fish2 = new ClassicFish(name_cons, color_cons, size_cons);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Fish_Lab3.count, 
                "Але напевно що уже не " + Fish_Lab3.count);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            BankCard_Lab3 card = new BankCard_Lab3();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            KDV card = new KDV();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Universal card = new Universal();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + BankCard_Lab3.count,
                "Але напевно що уже не " + BankCard_Lab3.count);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву карти для виплат\n", "Створюємо Карту для виплат", "Робоча"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "9"));
            KDV card2 = new KDV(name_cons, color_cons, size_cons);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву карти універсальної\n", "Створюємо Карту універсальну", "Для покупок"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелена"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "9"));
            Universal card2 = new Universal(name_cons, color_cons, size_cons);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Phone_Lab3 phone = new Phone_Lab3();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            OldPhone phone = new OldPhone();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MobilePhone phone = new MobilePhone();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Phone_Lab3.count,
                "Але напевно що уже не " + Phone_Lab3.count);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для стаціонарного телефона\n", "Створюємо Стаціонарний телефон", "Alcatel"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            OldPhone phone2 = new OldPhone(name_cons, color_cons, size_cons);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для мобільного телефона\n", "Створюємо Мобільний телефон", "Meizu"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            MobilePhone phone2 = new MobilePhone(name_cons, color_cons, size_cons);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            List_Lab3 list = new List_Lab3();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            PaperList list = new PaperList();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            EList list = new EList();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + List_Lab3.count,
                "Але напевно що уже не " + List_Lab3.count);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для поштового листа\n", "Створюємо Поштовий лист", "Родичам"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "4"));
            PaperList list2 = new PaperList(name_cons, color_cons, size_cons);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для електронного листа\n", "Створюємо Електронний лист", "Дружній"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Фіолетовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "150"));
            EList list2 = new EList(name_cons, color_cons, size_cons);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Auto_Lab3 auto = new Auto_Lab3();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            BigAuto auto = new BigAuto();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            LiteAuto auto = new LiteAuto();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Auto_Lab3.count,
                "Але напевно що уже не " + Auto_Lab3.count);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для вантажного автомобіля\n", "Створюємо Вантажний автомобіль", "MAN"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "15"));
            BigAuto auto2 = new BigAuto(name_cons, color_cons, size_cons);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для легкового автомобіля\n", "Створюємо Легковий автомобіль", "Nissan"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            LiteAuto auto2 = new LiteAuto(name_cons, color_cons, size_cons);
        }
        //
        private void button56_Click(object sender, EventArgs e)
        {
            new Product_Lab3();
        }
        private void button55_Click(object sender, EventArgs e)
        {
            new Vegetable();
        }
        private void button53_Click(object sender, EventArgs e)
        {
            new Fruit();
        }
        private void button51_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Product_Lab3.count,
                "Але напевно що уже не " + Product_Lab3.count);
        }
        private void lab3_exitButton_Click(object sender, EventArgs e)  //Спільний метод для кнопки закриття лабараторної.
        {
            MessageBox.Show("Всього знищенно об'єктів за час запуску лабараторної №3: " + result_lab3,
                "Ваш результат: " + result_lab3);
            Close();
        }
        private void button54_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для овоча\n", "Створюємо Овоч", "Перець"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Vegetable(name_cons, color_cons, size_cons);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для фрукта\n", "Створюємо Фрукт", "Груша"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Fruit(name_cons, color_cons, size_cons);
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

    public partial class Fish_Lab3
    {
        public static int count;
        public int nomer;
        public bool isStrong;
        public Fish_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Fish_Lab3()
        {
            MessageBox.Show("Знищується Риба №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Риба №" + (count + 1) + " створена", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class OceanicFish : Fish_Lab3
    {
        String name, color, status;
        int size;
        
        public OceanicFish()
        {
            this.name = "Акула"; this.color = "Сірий"; this.size = 4; this.status = "Жива"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public OceanicFish(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Мертва"))
                    return "Мертва";
                else return "Слабка";
            else return "Небезпечна океанічна риба!";
        }
        public string isDone()
        {
            if (size > 2)
            {
                if (size < 5)
                {
                    return "Звичайний розмір";
                }
                else return "Величезна";
            }
            else return "Мала";
        }
        public void Info()
        {
            MessageBox.Show("Океанічна риба з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + isDone() + "\n\n\n",
                "Ось така океанічна риба",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    public partial class ClassicFish : Fish_Lab3
    {
        String name, color, status;
        int size;
        public ClassicFish()
        {
            this.name = "Лин"; this.color = "Жовтий"; this.size = 1; this.status = "Жива"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public ClassicFish(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Мертва"))
                    return "Мертва";
                else return "Слабка";
            else return "Небезпечна океанічна риба!";
        }
        public string isDone()
        {
            if (size > 1)
            {
                if (size < 2)
                {
                    return "Звичайний розмір";
                }
                else return "Величезна";
            }
            else return "Мала";
        }
        public void Info()
        {
            MessageBox.Show("Прісноводна риба з назвою: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + isDone() + "\n\n\n",
                "Ось така прісноводна риба",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }


    //newStyle
    public partial class BankCard_Lab3
    {
        public static int count;
        public int nomer;
        public bool isLimit;
        public String name, color, status;
        public int size;
        public BankCard_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~BankCard_Lab3()
        {
            MessageBox.Show("Знищується Картка №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }

        public string isLimits()
        {
            if (isLimit == false)
                if (status.Equals("Зламана"))
                    return "Нею уже не розрахуєшся";
                else return "Мусиш мати свої кошти";
            else return "Можеш взяти гроші в кредит";
        }

        public string isDone()
        {
            if (size > 6)
            {
                if (size < 10)
                {
                    return "Звичайний розмір картки";
                }
                else return "Велика картка";
            }
            else return "Маленька картка";
        }

        public void InfoLab3()
        {
            MessageBox.Show("Картка №" + (count + 1) + " створена", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class KDV : BankCard_Lab3
    {
        public KDV()
        {
            this.name = "MasterCard"; this.color = "Зелений"; this.size = 8; this.status = "Ціла"; isLimit = false;
        }
        public KDV(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Ціла"; isLimit = false;
        }
        public void Info()
        {
            MessageBox.Show("Картка для виплат з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + isDone() + "\n\n\n",
                "Ось така картка для виплат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class Universal : BankCard_Lab3
    {
        public Universal()
        {
            this.name = "Visa"; this.color = "Синій"; this.size = 8; this.status = "Ціла"; isLimit = true;
        }
        public Universal(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Ціла"; isLimit = true;
        }
        public void Info()
        {
            MessageBox.Show("Картка універсальна з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + isDone() + "\n\n\n",
                "Ось така карта універсальна",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class Phone_Lab3
    {
        public static int count;
        public int nomer;
        public bool isWork;
        public String name, color, status;
        public int size;
        public Phone_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Phone_Lab3()
        {
            MessageBox.Show("Знищується Телефон №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }

        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Зламаний"))
                    return "Пошкоджений";
                else return "Не працює";
            else return "Працюючий телефон";
        }

        public string isDone()
        {
            if (size > 4)
            {
                if (size < 7)
                {
                    return "Телефон звичайного розміру";
                }
                else return "Великий телефон";
            }
            else return "Маленький телефон";
        }

        public void InfoLab3()
        {
            MessageBox.Show("Телефон №" + (count + 1) + " створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class OldPhone : Phone_Lab3
    {
        public OldPhone()
        {
            this.name = "Провідний"; this.color = "Білий"; this.size = 8; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public OldPhone(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public void Info()
        {
            MessageBox.Show("Стаціонарний телефон з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий стаціонарний телефон",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class MobilePhone : Phone_Lab3
    {
        public MobilePhone()
        {
            this.name = "OnePlus"; this.color = "Чорний аметист"; this.size = 6; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public MobilePhone(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public void Info()
        {
            MessageBox.Show("Мобільний телефон з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий мобільний телефон",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class List_Lab3
    {
        public static int count;
        public int nomer;
        public String name, color, status;
        public int size;
        public List_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~List_Lab3()
        {
            MessageBox.Show("Знищується Лист №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Лист №" + (count + 1) + " створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class PaperList : List_Lab3
    {
        public bool isDirty;
        public PaperList()
        {
            this.name = "Діловий"; this.color = "Білий"; this.size = 8; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public PaperList(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public string isDirtys()
        {
            if (isDirty == true)
                if (status.Equals("Порваний"))
                    return "М'ятий та списаний";
                else return "Брудний";
            else return "Охайний лист";
        }

        public string isDone()
        {
            if (size > 3)
            {
                if (size < 5)
                {
                    return "Розміру А4";
                }
                else return "Великий лист";
            }
            else return "Малий лист";
        }
        public void Info()
        {
            MessageBox.Show("Поштовий лист з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDirtys() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий поштовий лист",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class EList : List_Lab3
    {

        public bool isWrong;
        public EList()
        {
            this.name = "З банку"; this.color = "Червоний"; this.size = 6; this.status = "Негативний"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public EList(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public string isWrongs()
        {
            if (isWrong == false)
                if (status.Equals("Негативний"))
                    return "Схоже у когось борги";
                else return "Чому він червоний якщо новина позитивна?????";
            else return "Ми так і не дізнаємось що там";
        }

        public string isDone()
        {
            if (size > 100)
            {
                if (size < 200)
                {
                    return "Хоча він і не довгий, всеодно лінь читати";
                }
                else return "Хто пише такі довгі електронні листи?";
            }
            else return "Меньше ста символів, можна навіть і прочитати";
        }
        public void Info()
        {
            MessageBox.Show("Електронний лист: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWrongs() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий електронний лист",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    public partial class Auto_Lab3
    {
        public static int count;
        public int nomer;
        public bool isWork;
        public String name, color, status;
        public int size;
        public Auto_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Auto_Lab3()
        {
            MessageBox.Show("Знищується Автомобіль №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--;
        }

        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Поламаний"))
                    return "Пошкоджений";
                else return "Не їде";
            else return "Працюючий автомобіль";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Автомобіль №" + (count + 1) + " створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class BigAuto : Auto_Lab3
    {
        public BigAuto()
        {
            this.name = "Mercedes"; this.color = "Жовтий"; this.size = 6; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public BigAuto(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public string isDone()
        {
            if (size > 5)
            {
                if (size < 10)
                {
                    return "Вантажний автомобіль звичайного розміру";
                }
                else return "Великий вантажний автомобіль";
            }
            else return "Малий вантажний автомобіль";
        }
        public void Info()
        {
            MessageBox.Show("Вантажний автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий вантажний автомобіль",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }

    public partial class LiteAuto : Auto_Lab3
    {
        public LiteAuto()
        {
            this.name = "Opel"; this.color = "Сірий"; this.size = 6; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public LiteAuto(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public string isDone()
        {
            if (size > 2)
            {
                if (size < 4)
                {
                    return "Легковий автомобіль звичайного розміру";
                }
                else return "Великий легковий автомобіль";
            }
            else return "Малий легковий автомобіль";
        }
        public void Info()
        {
            MessageBox.Show("Легковий автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий легковий автомобіль",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
    //Продукт                                                                          /Варіант №8
    public partial class Product_Lab3
    {
        public static int count;
        public int nomer;
        public bool isDelicious;
        public String name, color, status;
        public int size;
        public Product_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Product_Lab3()
        {
            MessageBox.Show("Знищується Продукт №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--; FormLab3.result_lab3++;
        }
        public string isDeliciouss()
        {
            if (isDelicious == false)
                if (status.Equals("Пошкоджений"))
                    return "Пошкоджений";
                else return "Не смачний";
            else return "Свіжий продукт!";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Продукт №" + (count + 1) + " створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public partial class Vegetable : Product_Lab3
    {
        public Vegetable()
        {
            this.name = "Картопля"; this.color = "Коричневий"; this.size = 3; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Vegetable(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 3)
                if (size < 5)
                    return "Овоч середнього розміру";
                else return "Великий овоч";
            else return "Малий овоч";
        }
        public void Info()
        {
            MessageBox.Show("Овоч: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий овоч",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Fruit : Product_Lab3
    {
        public Fruit()
        {
            this.name = "Персик"; this.color = "Персиковий"; this.size = 3; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Fruit(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 2)
                if (size < 5)
                    return "Фрукт звичайного розміру";
                else return "Великий фрукт";
            else return "Малий фрукт";
        }
        public void Info()
        {
            MessageBox.Show("Фрукт: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий Фрукт",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //Взуття                                                                           /Варіант №9
    public partial class Shoes_Lab3
    {
        public static int count;
        public int nomer;
        public bool isDelicious;
        public String name, color, status;
        public int size;
        public Shoes_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Shoes_Lab3()
        {
            MessageBox.Show("Знищується Продукт №" + nomer, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count--; FormLab3.result_lab3++;
        }
        public string isDeliciouss()
        {
            if (isDelicious == false)
                if (status.Equals("Пошкоджений"))
                    return "Пошкоджений";
                else return "Не смачний";
            else return "Свіжий продукт!";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Продукт №" + (count + 1) + " створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public partial class Boots : Shoes_Lab3
    {
        public Boots()
        {
            this.name = "Картопля"; this.color = "Коричневий"; this.size = 3; this.status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Boots(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 3)
                if (size < 5)
                    return "Овоч середнього розміру";
                else return "Великий овоч";
            else return "Малий овоч";
        }
        public void Info()
        {
            MessageBox.Show("Овоч: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий овоч",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Shoe : Shoes_Lab3
    {
        public Shoe()
        {
            this.name = "Персик"; this.color = "Персиковий"; this.size = 3; this.status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Shoe(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 2)
                if (size < 5)
                    return "Фрукт звичайного розміру";
                else return "Великий фрукт";
            else return "Малий фрукт";
        }
        public void Info()
        {
            MessageBox.Show("Фрукт: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий Фрукт",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

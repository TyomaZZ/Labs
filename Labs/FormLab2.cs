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
using System.Windows.Forms.VisualStyles;

namespace Labs
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Outerwear_Lab2 wear = new Outerwear_Lab2();
            wear.Info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву верхнього одягу\n", "Створюємо верхній одяг", "Джампер"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            Outerwear_Lab2 wear2 = new Outerwear_Lab2(name_cons, color_cons, size_cons);
            wear2.Info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Plane_Lab2 plane = new Plane_Lab2();
            plane.Info();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для літака\n", "Створюємо Літак", "Вантажний"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Літак", "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " " + color_cons + " Літак", "42"));
            Plane_Lab2 plane2 = new Plane_Lab2(name_cons, color_cons, size_cons);
            plane2.Info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fish_Lab2 fish = new Fish_Lab2();
            fish.Info();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для риби\n", "Створюємо Рибу", "Озерська"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Риба", "Темний матовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Риба", "42"));
            Fish_Lab2 fish2 = new Fish_Lab2(name_cons, color_cons, size_cons);
            fish2.Info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BankCard_Lab2 card = new BankCard_Lab2();
            card.Info();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для карти\n", "Створюємо Карту", "Visa"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Карта", "Оранжевий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Карта", "8"));
            BankCard_Lab2 card2 = new BankCard_Lab2(name_cons, color_cons, size_cons);
            card2.Info();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Phone_Lab2 phone = new Phone_Lab2();
            phone.Info();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для телефона\n", "Створюємо Телефон", "Xiaomi"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Телефон", "Чорний матовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Телефон", "6"));
            Phone_Lab2 phone2 = new Phone_Lab2(name_cons, color_cons, size_cons);
            phone2.Info();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List_Lab2 list = new List_Lab2();
            list.Info();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для листа\n", "Створюємо Лист", "А4"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Лист", "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Лист", "4"));
            List_Lab2 list2 = new List_Lab2(name_cons, color_cons, size_cons);
            list2.Info();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Auto_Lab2 auto = new Auto_Lab2();
            auto.Info();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для автомобіля\n", "Створюємо Автомобіль", "Ferarri"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Автомобіль", "Оранжевий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Автомобіль", "2"));
            Auto_Lab2 auto2 = new Auto_Lab2(name_cons, color_cons, size_cons);
            auto2.Info();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Product_Lab2 product = new Product_Lab2();
            product.Info();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для продукта\n", "Створюємо Продукт", "Картопля"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Коричневий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            Product_Lab2 product2 = new Product_Lab2(name_cons, color_cons, size_cons);
            product2.Info();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Shoes_Lab2 shoes = new Shoes_Lab2();
            shoes.Info();
        }

        private void button26_Click(object sender, EventArgs e)
        {

            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для взуття\n", "Створюємо Взуття", "В'єтнамки"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Жовті"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "33"));
            Shoes_Lab2 shoes2 = new Shoes_Lab2(name_cons, color_cons, size_cons);
            shoes2.Info();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Candy_Lab2 candy = new Candy_Lab2();
            candy.Info();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для Цукерок\n", "Створюємо Цукерки", "Рошен"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Фіолетовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            Candy_Lab2 candy2 = new Candy_Lab2(name_cons, color_cons, size_cons);
            candy2.Info();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Animal_Lab2 animal = new Animal_Lab2();
            animal.Info();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для тварини\n", "Створюємо Тварину", "Білка"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорно-біла"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "10"));
            Animal_Lab2 animal2 = new Animal_Lab2(name_cons, color_cons, size_cons);
            animal2.Info();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Book_Lab2 book = new Book_Lab2();
            book.Info();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для книги\n", "Створюємо Книгу", "Дон Кіхот"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелена"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "700"));
            Book_Lab2 book2 = new Book_Lab2(name_cons, color_cons, size_cons);
            book2.Info();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            News_Lab2 news = new News_Lab2();
            news.Info();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для періодичного видання\n", "Створюємо Періодичне видання", "Газета"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сіра"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "8"));
            News_Lab2 news2 = new News_Lab2(name_cons, color_cons, size_cons);
            news2.Info();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Wishing_Lab2 wish = new Wishing_Lab2();
            wish.Info();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для миючого засобу\n", "Створюємо Миючий засіб", "Мило"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            Wishing_Lab2 wish2 = new Wishing_Lab2(name_cons, color_cons, size_cons);
            wish2.Info();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Clock_Lab2 clock = new Clock_Lab2();
            clock.Info();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для годинника\n", "Створюємо Годинник", "Настінний годинник"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "50"));
            Clock_Lab2 clock2 = new Clock_Lab2(name_cons, color_cons, size_cons);
            clock2.Info();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public partial class Outerwear_Lab2
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Outerwear_Lab2()
        {
            name = "Футболка"; color = "Чорний"; status = "Новий"; size = 36; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        
        public Outerwear_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFreak = false; } else isFreak = true;
        }

        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потасканий"))
                    return "Жахлива річ";
                else return "Досить мила річ...";
            else return "Класна річ :р";
        }

        public string isDone()
        {
            if (size > 25)
            {
                if (size < 55)
                {
                    return "Ця річ навіть могла б підійти для тебе";
                }
                else return "Ця річ завелика для тебе!";
            }
            else return "Ця річ замала для тебе!";
        }

        public void Info()
        {
            MessageBox.Show("Верхній одяг: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + isDone() + "\n\n\n", 
                "Ось такий верхній одяг", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }

    public partial class Plane_Lab2
    {
        String name, color, status;
        int size;
        bool isWork;
        public Plane_Lab2()
        {
            name = "Пасажирський"; color = "Білий"; status = "Новий"; size = 40; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }

        public Plane_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }

        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Потасканий"))
                    return "На ньому краще не літати";
                else return "Ще декілька перельотів переживе";
            else return "Красивий, новий літак";
        }

        public string isDone()
        {
            if (size > 30)
            {
                if (size < 105)
                {
                    return "Ідеальний по розмірах літак";
                }
                else return "Дуже великий літак!";
            }
            else return "Малий літак!";
        }

        public void Info()
        {
            MessageBox.Show("Літак: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий літак!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class Fish_Lab2
    {
        String name, color, status;
        int size;
        bool isStrong;
        public Fish_Lab2()
        {
            name = "Річкова"; color = "Срібний"; status = "Здорова"; size = 35; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }

        public Fish_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Здорова";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isStrong = false; } else isStrong = true;
        }

        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Хвора"))
                    return "Її б додому забрати, попіклуватись про неї";
                else return "Природного відбору вона не переживе";
            else return "Рибка здатна вижити в цьому світі";
        }

        public string isDone()
        {
            if (size > 30)
            {
                if (size < 45)
                {
                    return "Рибка середнього розміру";
                }
                else return "Дуже велика риба!";
            }
            else return "Маленька рибка!";
        }

        public void Info()
        {
            MessageBox.Show("Риба: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + isDone() + "\n\n\n",
                "Ось така рибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class BankCard_Lab2
    {
        String name, color, status;
        int size;
        bool isLimit;
        public BankCard_Lab2()
        {
            name = "MasterCard"; color = "Жовтий"; status = "Ціла"; size = 9; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isLimit = false; else isLimit = true;
        }

        public BankCard_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isLimit = false; } else isLimit = true;
        }

        public string isLimits()
        {
            if (isLimit == true)
                if (status.Equals("Зламана"))
                    return "Нею вже не розрахуєшся";
                else return "Багато речей нею не купиш";
            else return "Безлімітна карта, мрія будь-якої людини";
        }

        public string isDone()
        {
            if (size > 7)
            {
                if (size < 10)
                {
                    return "Стандартна картка";
                }
                else return "Дуже велика картка!";
            }
            else return "Маленька картка!";
        }

        public void Info()
        {
            MessageBox.Show("Картка: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + isDone() + "\n\n\n",
                "Ось така рибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class Phone_Lab2
    {
        String name, color, status;
        int size;
        bool isWork;
        public Phone_Lab2()
        {
            name = "OnePlus"; color = "Чорний аметист"; status = "Цілий"; size = 6; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }

        public Phone_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }

        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Розбитий"))
                    return "Не працюючий телефон";
                else return "Він не включається";
            else return "Можна навіть позвонити з нього!!";
        }

        public string isDone()
        {
            if (size > 5)
            {
                if (size < 7)
                {
                    return "Стандартний розмір телефона";
                }
                else return "Дуже великий телефон!";
            }
            else return "Маленький телефон!";
        }

        public void Info()
        {
            MessageBox.Show("Телефон: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий телефон!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class List_Lab2
    {
        String name, color, status;
        int size;
        bool notWhite;
        public List_Lab2()
        {
            name = "Паперовий"; color = "Білий"; status = "Цілий"; size = 6; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) notWhite = false; else notWhite = true;
        }

        public List_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { notWhite = false; } else notWhite = true;
        }

        public string notWhites()
        {
            if (notWhite == true)
                if (status.Equals("Зіпсований"))
                    return "Не придатний для запису";
                else return "Трішки зписаний";
            else return "Чистий охайний листок";
        }

        public string isDone()
        {
            if (size > 3)
            {
                if (size < 5)
                {
                    return "Стандартний розмір листка";
                }
                else return "Меньший ніж А4";
            }
            else return "Більший ніж А4";
        }

        public void Info()
        {
            MessageBox.Show("Лист: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + notWhites() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий лист!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class Auto_Lab2
    {
        String name, color, status;
        int size;
        bool isWorking;
        public Auto_Lab2()
        {
            name = "Mercedes"; color = "Рожевий"; status = "Відмінний"; size = 6; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWorking = false; else isWorking = true;
        }

        public Auto_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWorking = false; } else isWorking = true;
        }

        public string isWorks()
        {
            if (isWorking == false)
                if (status.Equals("Занедбаний"))
                    return "Не придатний для їзди";
                else return "Часто глохне";
            else return "Новенький автомобіль";
        }

        public string isDone()
        {
            if (size >= 2)
            {
                if (size <= 3)
                {
                    return "Звичайний автомобіль";
                }
                else return "Великий вантажний автомобіль";
            }
            else return "Маленький автомобіль на двох людей";
        }

        public void Info()
        {
            MessageBox.Show("Автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий автомобіль!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class Product_Lab2
    {
        String name, color, status;
        int size;
        bool isFresh;
        public Product_Lab2()
        {
            name = "Яблуко"; color = "Червоний"; status = "Цілий"; size = 2; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFresh = false; else isFresh = true;
        }

        public Product_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFresh = false; } else isFresh = true;
        }

        public string isWorks()
        {
            if (isFresh == false)
                if (status.Equals("Порізане"))
                    return "Нездібне";
                else return "Непоганий продукт";
            else return "Свіжий продукт";
        }

        public string isDone()
        {
            if (size > 1)
            {
                if (size < 3)
                {
                    return "Середнього розміру продукт";
                }
                else return "Великий продукт";
            }
            else return "Малий продукт, навіть ситий не будеш";
        }

        public void Info()
        {
            MessageBox.Show("Продукт: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий Продукт!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public partial class Shoes_Lab2
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Shoes_Lab2()
        {
            name = "Кросівки"; color = "Червоний"; status = "Нове"; size = 46; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }

        public Shoes_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціле";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFreak = false; } else isFreak = true;
        }

        public string isWorks()
        {
            if (isFreak == true)
                if (status.Equals("Старе"))
                    return "Жахливе взуття";
                else return "Не красиве взуття";
            else return "Чудове взуття";
        }

        public string isDone()
        {
            if (size > 36)
            {
                if (size < 44)
                {
                    return "Нормальний розмір взуття";
                }
                else return "Велике взуття";
            }
            else return "Маленьке взуття";
        }

        public void Info()
        {
            MessageBox.Show("Взуття: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось таке взуття!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Candy_Lab2
    {
        String name, color, status;
        int size;
        bool isSweety;
        public Candy_Lab2()
        {
            name = "М'ятні"; color = "Зелений"; status = "Дорогі"; size = 1; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isSweety = false; else isSweety = true;
        }

        public Candy_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціле";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isSweety = false; } else isSweety = true;
        }

        public string isSweets()
        {
            if (isSweety == false)
                if (status.Equals("Дешеві"))
                    return "Жахливі цукерки";
                else return "Не смачні цукерки";
            else return "Чудові цукерки";
        }

        public string isDone()
        {
            if (size > 1)
            {
                if (size < 3)
                {
                    return "Середнього розміру";
                }
                else return "Великі цукерки";
            }
            else return "Маленькі цукерки";
        }

        public void Info()
        {
            MessageBox.Show("Цукерки: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isSweets() + "\n\n" + isDone() + "\n\n\n",
                "Ось такі цукерки!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Animal_Lab2
    {
        String name, color, status;
        int size;
        bool isStrong;
        public Animal_Lab2()
        {
            name = "Кабан"; color = "Коричневий"; status = "Здоровий"; size = 45; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }

        public Animal_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Здоровий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isStrong = false; } else isStrong = true;
        }

        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Хворий"))
                    return "Їй не завадить стежити за своїм здоров'ям";
                else return "Природного відбору не переживе";
            else return "Тварина здатна вижити в цьому світі";
        }

        public string isDone()
        {
            if (size > 30)
            {
                if (size < 60)
                {
                    return "Тварина середнього розміру";
                }
                else return "Дуже велика тварина!";
            }
            else return "Маленька тваринка";
        }

        public void Info()
        {
            MessageBox.Show("Тварина: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + isDone() + "\n\n\n",
                "Ось така тварина!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Book_Lab2
    {
        String name, color, status;
        int size;
        bool isInteresting;
        public Book_Lab2()
        {
            name = "Тарзан"; color = "Коричневий"; status = "Ціла"; size = 350; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isInteresting = false; else isInteresting = true;
        }

        public Book_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isInteresting = false; } else isInteresting = true;
        }

        public string isInterestings()
        {
            if (isInteresting == false)
                if (status.Equals("Зіпсована"))
                    return "Стара зруйнована книга";
                else return "Не цікава книга";
            else return "Цікава, охайна книга";
        }

        public string isDone()
        {
            if (size > 100)
            {
                if (size < 400)
                {
                    return "Стандартний розмір розмір книги";
                }
                else return "Велика, товста книга";
            }
            else return "Тоненька книга";
        }

        public void Info()
        {
            MessageBox.Show("Книга: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isInterestings() + "\n\n" + isDone() + "\n\n\n",
                "Ось така книга!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class News_Lab2
    {
        String name, color, status;
        int size;
        bool isInteresting;
        public News_Lab2()
        {
            name = "Журнал"; color = "Синій"; status = "Ціле"; size = 40; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isInteresting = false; else isInteresting = true;
        }

        public News_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціле";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isInteresting = false; } else isInteresting = true;
        }

        public string isInterestings()
        {
            if (isInteresting == false)
                if (status.Equals("Зіпсоване"))
                    return "Старе зруйноване видання";
                else return "Не цікаве видання";
            else return "Цікаве, охайне видання";
        }

        public string isDone()
        {
            if (size > 10)
            {
                if (size < 30)
                {
                    return "Стандартний розмір розмір видання";
                }
                else return "Велике виданння";
            }
            else return "Мале видання";
        }

        public void Info()
        {
            MessageBox.Show("Періодичне видання: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isInterestings() + "\n\n" + isDone() + "\n\n\n",
                "Ось таке періодичне видання!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Wishing_Lab2
    {
        String name, color, status;
        int size;
        bool isResultative;
        public Wishing_Lab2()
        {
            name = "Порошок"; color = "Білий"; status = "Повний"; size = 2; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isResultative = false; else isResultative = true;
        }

        public Wishing_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Повний";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isResultative = false; } else isResultative = true;
        }

        public string isWorks()
        {
            if (isResultative == false)
                if (status.Equals("Порожній"))
                    return "Закінчився";
                else return "Недієвий";
            else return "Хороший засіб";
        }

        public string isDone()
        {
            if (size > 2)
            {
                if (size < 4)
                {
                    return "Середня упаковка засобу";
                }
                else return "Велика упаковка засобу";
            }
            else return "Маленька упаковка засобу";
        }

        public void Info()
        {
            MessageBox.Show("Миючий засіб: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий Миючий засіб!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Clock_Lab2
    {
        String name, color, status;
        int size;
        bool isWork;
        public Clock_Lab2()
        {
            name = "Наручний годинник"; color = "Срібний"; status = "Новий"; size = 15; Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }

        public Clock_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }

        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Розбитий"))
                    return "Не розбитий годинник";
                else return "Не працюючий годинник";
            else return "Показує час";
        }

        public string isDone()
        {
            if (size > 10)
            {
                if (size < 20)
                {
                    return "Середній годинник";
                }
                else return "Великий годинник";
            }
            else return "Маленький годинник";
        }

        public void Info()
        {
            MessageBox.Show("Годинник: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + isDone() + "\n\n\n",
                "Ось такий годинник!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

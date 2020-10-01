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
{//tyomashi
    public partial class lab2_Form : Form
    {
        public lab2_Form()
        {
            InitializeComponent();
            lab2_TabControl.SelectedTab = lab2_TabPage7;
        }
                //Методи кнопок для лабараторної №2________
        private void lab2_exitButton_Click(object sender, EventArgs e) //Загальний метод для кнопок закриття лабараторної.
        {
            Close();
        }
        //1
        private void lab2_var1_button1_Click(object sender, EventArgs e)
        {
            new Plane_Lab2().Info();
        }
        private void lab2_var1_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для літака\n", "Створюємо Літак", "Вантажний"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Літак", "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " " + color_cons + " Літак", "42"));
            new Plane_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //2
        private void lab2_var2_button1_Click(object sender, EventArgs e)
        {
            new Fish_Lab2().Info();
        }
        private void lab2_var2_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для риби\n", "Створюємо Рибу", "Озерська"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Риба", "Темний матовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Риба", "42"));
            new Fish_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //3
        private void lab2_var3_button1_Click(object sender, EventArgs e)
        {
            new BankCard_Lab2().Info();
        }
        private void lab2_var3_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для карти\n", "Створюємо Карту", "Visa"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Карта", "Оранжевий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Карта", "8"));
            new BankCard_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //4
        private void lab2_var4_button1_Click(object sender, EventArgs e)
        {
            new Phone_Lab2().Info();
        }
        private void lab2_var4_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для телефона\n", "Створюємо Телефон", "Xiaomi"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Телефон", "Чорний матовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Телефон", "6"));
            new Phone_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //5
        private void lab2_var5_button1_Click(object sender, EventArgs e)
        {
            new Letter_Lab2().Info();
        }
        private void lab2_var5_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для листа\n", "Створюємо Лист", "А4"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Лист", "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Лист", "4"));
            new Letter_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //6
        private void lab2_var6_button1_Click(object sender, EventArgs e)
        {
            new Car_Lab2().Info();
        }
        private void lab2_var6_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для автомобіля\n", "Створюємо Автомобіль", "Ferarri"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons + " Автомобіль", "Оранжевий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons + " Автомобіль", "2"));
            new Car_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //_мій_варіант_№7____________________________________________________________________________________________________________________
        private void lab2_var7_button1_Click(object sender, EventArgs e)
        {
            new Outerwear_Lab2().Info();
        }
        private void lab2_var7_button2_Click(object sender, EventArgs e)
        {
            new Outerwear_Lab2(Convert.ToString(Interaction.InputBox("Введіть назву верхнього одягу\n", "Створюємо верхній одяг", "Джампер")),
                 Convert.ToString(Interaction.InputBox("Введіть колір", "Створюємо верхній одяг", "Синій")),
                 Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", "Створюємо верхній одяг", "42"))).Info();
        }
        //___________________________________________________________ 
        private void lab2_var8_button1_Click(object sender, EventArgs e)
        {
            new Product_Lab2().Info();
        } //8
        private void lab2_var8_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для продукта\n", "Створюємо Продукт", "Картопля"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Коричневий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Product_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //9
        private void lab2_var9_button1_Click(object sender, EventArgs e)
        {
            new Shoes_Lab2().Info();
        }
        private void Lab2_var9_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для взуття\n", "Створюємо Взуття", "В'єтнамки"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Жовті"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "33"));
            new Shoes_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //10
        private void lab2_var10_button1_Click(object sender, EventArgs e)
        {
            new Candy_Lab2().Info();
        }
        private void lab2_var10_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для Цукерок\n", "Створюємо Цукерки", "Рошен"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Фіолетовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            new Candy_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //11
        private void lab2_var11_button1_Click(object sender, EventArgs e)
        {
            new Animal_Lab2().Info();
        }
        private void lab2_var11_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для тварини\n", "Створюємо Тварину", "Білка"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорно-біла"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "10"));
            new Animal_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //12
        private void lab2_var12_button1_Click(object sender, EventArgs e)
        {
            new Book_Lab2().Info();
        }
        private void lab2_var12_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для книги\n", "Створюємо Книгу", "Дон Кіхот"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелена"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "700"));
            new Book_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //13
        private void lab2_var13_button1_Click(object sender, EventArgs e)
        {
            new Periodical_Lab2().Info();
        }
        private void lab2_var13_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для періодичного видання\n", "Створюємо Періодичне видання", "Газета"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сіра"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "8"));
            new Periodical_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //14
        private void lab2_var14_button1_Click(object sender, EventArgs e)
        {
            new Detergent_Lab2().Info();
        }
        private void lab2_var14_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для миючого засобу\n", "Створюємо Миючий засіб", "Мило"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            new Detergent_Lab2(name_cons, color_cons, size_cons).Info();
        }
        //15
        private void lab2_var15_button1_Click(object sender, EventArgs e)
        {
            new Clock_Lab2().Info();
        }
        private void lab2_var15_button2_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для годинника\n", "Створюємо Годинник", "Настінний годинник"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "50"));
            new Clock_Lab2(name_cons, color_cons, size_cons).Info();
        }
    }
                   //Класи для лабараторної №2________
    public partial class Plane_Lab2      //Літак              /Варіант №1
    {
        String name, color, status;
        int size;
        bool isWork;
        public Plane_Lab2()
        {
            name = "Пасажирський"; color = "Білий"; status = "Новий"; size = 40; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public Plane_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }
        public string isWorking()
        {
            if (isWork == false)
                if (status.Equals("Потасканий"))
                    return "На ньому краще не літати";
                else return "Ще декілька перельотів переживе";
            else return "Красивий, новий літак";
        }
        public string SizeString()
        {
            if (size > 30)
                if (size < 105)
                    return "Ідеальний по розмірах літак";
                else return "Дуже великий літак!";
            else return "Малий літак!";
        }
        public void Info()
        {
            MessageBox.Show("Літак: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorking() + "\n\n" + SizeString() + "\n\n",
                "Ось такий літак!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Fish_Lab2       //Риба               /Варіант №2
    {
        String name, color, status;
        int size;
        bool isStrong;
        public Fish_Lab2()
        {
            name = "Річкова"; color = "Срібний"; status = "Здорова"; size = 35; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
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
        public string SizeString()
        {
            if (size > 30)
                if (size < 45)
                    return "Рибка середнього розміру";
                else return "Дуже велика риба!";
            else return "Маленька рибка!";
        }
        public void Info()
        {
            MessageBox.Show("Риба: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + SizeString() + "\n\n",
                "Ось така рибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class BankCard_Lab2   //Банківська карта   /Варіант №3
    {
        String name, color, status;
        int size;
        bool isLimit;
        public BankCard_Lab2()
        {
            name = "MasterCard"; color = "Жовтий"; status = "Ціла"; size = 9; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isLimit = false; else isLimit = true;
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
        public string SizeString()
        {
            if (size > 7)
                if (size < 10)
                    return "Стандартна картка";
                else return "Дуже велика картка!";
            else return "Маленька картка!";
        }
        public void Info()
        {
            MessageBox.Show("Картка: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така рибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Phone_Lab2      //Телефон            /Варіант №4
    {
        String name, color, status;
        int size;
        bool isWork;
        public Phone_Lab2()
        {
            name = "OnePlus"; color = "Чорний аметист"; status = "Цілий"; size = 6; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public Phone_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }
        public string isWorking()
        {
            if (isWork == false)
                if (status.Equals("Розбитий"))
                    return "Не працюючий телефон";
                else return "Він не включається";
            else return "Можна навіть позвонити з нього!!";
        }
        public string SizeString()
        {
            if (size > 5)
                if (size < 7)
                    return "Стандартний розмір телефона";
                else return "Дуже великий телефон!";
            else return "Маленький телефон!";
        }
        public void Info()
        {
            MessageBox.Show("Телефон: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorking() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий телефон!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Letter_Lab2     //Лист               /Варіант №5
    {
        String name, color, status;
        int size;
        bool isDirty;
        public Letter_Lab2()
        {
            name = "Паперовий"; color = "Білий"; status = "Цілий"; size = 6; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public Letter_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isDirty = false; } else isDirty = true;
        }
        public string isDirtys()
        {
            if (isDirty == true)
                if (status.Equals("Зіпсований"))
                    return "Не придатний для запису";
                else return "Трішки зписаний";
            else return "Чистий охайний листок";
        }
        public string SizeString()
        {
            if (size > 3)
                if (size < 5)
                    return "Стандартний розмір листка";
                else return "Меньший ніж А4";
            else return "Більший ніж А4";
        }
        public void Info()
        {
            MessageBox.Show("Лист: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDirtys() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий лист!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Car_Lab2        //Автомобіль         /Варіант №6
    {
        String name, color, status;
        int size;
        bool isWork;
        public Car_Lab2()
        {
            name = "Mercedes"; color = "Рожевий"; status = "Відмінний"; size = 6; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public Car_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціла";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }
        public string isWorking()
        {
            if (isWork == false)
                if (status.Equals("Занедбаний"))
                    return "Не придатний для їзди";
                else return "Часто глохне";
            else return "Новенький автомобіль";
        }
        public string SizeString()
        {
            if (size >= 2)
                if (size <= 3)
                    return "Звичайний автомобіль";
                else return "Великий вантажний автомобіль";
            else return "Маленький автомобіль на двох людей";
        }
        public void Info()
        {
            MessageBox.Show("Автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorking() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий автомобіль!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //_мій_варіант_№7_________________________________________________________________________________________________________________________________
    public partial class Outerwear_Lab2  //Верхній одяг       /Варіант №7
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Outerwear_Lab2()
        {
            name = "Футболка"; color = "Чорний"; status = "Новий"; size = 36;
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Outerwear_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFreak = false; } else isFreak = true;
        }
        public string isFreaking()
        {
            if (isFreak == true)
                if (status.Equals("Потасканий"))
                    return "Жахлива річ";
                else return "Досить мила річ...";
            else return "Класна річ :р";
        }
        public string SizeString()
        {
            if (size > 25)
                if (size < 55)
                    return "Ця річ навіть могла б підійти для тебе";
                else return "Ця річ завелика для тебе!";
            else return "Ця річ замала для тебе!";
        }
        public void Info()
        {
            MessageBox.Show("Верхній одяг: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaking() + "\n\n" + SizeString() + "\n\n",
                "Ось такий верхній одяг",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //___________________________________________________________ ____________________________________________________________________________________
    public partial class Product_Lab2    //Продукт            /Варіант №8
    {
        String name, color, status;
        int size;
        bool isFresh;
        public Product_Lab2()
        {
            name = "Яблуко"; color = "Червоний"; status = "Цілий"; size = 2; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFresh = false; else isFresh = true;
        }
        public Product_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Цілий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFresh = false; } else isFresh = true;
        }
        public string IsFreshs()
        {
            if (isFresh == false)
                if (status.Equals("Порізане"))
                    return "Нездібне";
                else return "Непоганий продукт";
            else return "Свіжий продукт";
        }
        public string SizeString()
        {
            if (size > 1)
                if (size < 3)
                    return "Середнього розміру продукт";
                else return "Великий продукт";
            else return "Малий продукт, навіть ситий не будеш";
        }
        public void Info()
        {
            MessageBox.Show("Продукт: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + IsFreshs() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий Продукт!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Shoes_Lab2      //Взуття             /Варіант №9
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Shoes_Lab2()
        {
            name = "Кросівки"; color = "Червоний"; status = "Нове"; size = 46; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Shoes_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціле";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isFreak = false; } else isFreak = true;
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Старе"))
                    return "Жахливе взуття";
                else return "Не красиве взуття";
            else return "Чудове взуття";
        }
        public string SizeString()
        {
            if (size > 36)
                if (size < 44)
                    return "Нормальний розмір взуття";
                else return "Велике взуття";
            else return "Маленьке взуття";
        }
        public void Info()
        {
            MessageBox.Show("Взуття: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось таке взуття!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Candy_Lab2      //Цукерки            /Варіант №10
    {
        String name, color, status;
        int size;
        bool isSweet;
        public Candy_Lab2()
        {
            name = "М'ятні"; color = "Зелений"; status = "Дорогі"; size = 1; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isSweet = false; else isSweet = true;
        }
        public Candy_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Ціле";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isSweet = false; } else isSweet = true;
        }
        public string isSweets()
        {
            if (isSweet == false)
                if (status.Equals("Дешеві"))
                    return "Жахливі цукерки";
                else return "Не смачні цукерки";
            else return "Чудові цукерки";
        }
        public string SizeString()
        {
            if (size > 1)
                if (size < 3)
                    return "Середнього розміру";
                else return "Великі цукерки";
            else return "Маленькі цукерки";
        }
        public void Info()
        {
            MessageBox.Show("Цукерки: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isSweets() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такі цукерки!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Animal_Lab2     //Тварина            /Варіант №11
    {
        String name, color, status;
        int size;
        bool isStrong;
        public Animal_Lab2()
        {
            name = "Кабан"; color = "Коричневий"; status = "Здоровий"; size = 45; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
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
        public string SizeString()
        {
            if (size > 30)
                if (size < 60)
                    return "Тварина середнього розміру";
                else return "Дуже велика тварина!";
            else return "Маленька тваринка";
        }
        public void Info()
        {
            MessageBox.Show("Тварина: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така тварина!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Book_Lab2       //Книга              /Варіант №12
    {
        String name, color, status;
        int size;
        bool isInteresting;
        public Book_Lab2()
        {
            name = "Тарзан"; color = "Коричневий"; status = "Ціла"; size = 350; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isInteresting = false; else isInteresting = true;
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
        public string SizeString()
        {
            if (size > 100)
                if (size < 400)
                    return "Стандартний розмір розмір книги";
                else return "Велика, товста книга";
            else return "Тоненька книга";
        }
        public void Info()
        {
            MessageBox.Show("Книга: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isInterestings() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така книга!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Periodical_Lab2 //Періодичне видання /Варіант №13
    {
        String name, color, status;
        int size;
        bool isInteresting;
        public Periodical_Lab2()
        {
            name = "Журнал"; color = "Синій"; status = "Ціле"; size = 40; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isInteresting = false; else isInteresting = true;
        }
        public Periodical_Lab2(String name, String color, int size)
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
        public string SizeString()
        {
            if (size > 10)
                if (size < 30)
                    return "Стандартний розмір розмір видання";
                else return "Велике виданння";
            else return "Мале видання";
        }
        public void Info()
        {
            MessageBox.Show("Періодичне видання: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isInterestings() + "\n\n" + SizeString() + "\n\n\n",
                "Ось таке періодичне видання!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Detergent_Lab2  //Миючий засіб       /Варіант №14
    {
        String name, color, status;
        int size;
        bool isResultative;
        public Detergent_Lab2()
        {
            name = "Порошок"; color = "Білий"; status = "Повний"; size = 2; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isResultative = false; else isResultative = true;
        }
        public Detergent_Lab2(String name, String color, int size)
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

        public string SizeString()
        {
            if (size > 2)
                if (size < 4)
                    return "Середня упаковка засобу";
                else return "Велика упаковка засобу";
            else return "Маленька упаковка засобу";
        }
        public void Info()
        {
            MessageBox.Show("Миючий засіб: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий Миючий засіб!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Clock_Lab2      //Годинник           /Варіант №15
    {
        String name, color, status;
        int size;
        bool isWork;
        public Clock_Lab2()
        {
            name = "Наручний годинник"; color = "Срібний"; status = "Новий"; size = 15; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public Clock_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); int asd = rnd.Next(0, 10); if (asd < 5) { isWork = false; } else isWork = true;
        }
        public string isWorking()
        {
            if (isWork == false)
                if (status.Equals("Розбитий"))
                    return "Не розбитий годинник";
                else return "Не працюючий годинник";
            else return "Показує час";
        }
        public string SizeString()
        {
            if (size > 10)
                if (size < 20)
                    return "Середній годинник";
                else return "Великий годинник";
            else return "Маленький годинник";
        }
        public void Info()
        {
            MessageBox.Show("Годинник: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorking() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий годинник!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
                   //Класи для лабараторної №2________
}



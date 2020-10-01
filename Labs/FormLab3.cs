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
        public lab3_Form()
        {
            InitializeComponent();
            lab3_tabControl.SelectedTab = lab3_tabPage7;
            lab3_tabPage14.Enabled = false;
            lab3_tabPage15.Enabled = false;
        }
                //Методи кнопок для лабараторної №2_________
        private void lab3_exitButton_Click(object sender, EventArgs e)  //Спільний метод для кнопки закриття лабараторної.
        {
            MessageBox.Show("Всього знищенно об'єктів лабараторної роботи №3 за весь час\nроботи додатку \"Labs\" : " + result_lab3,
                "Ваш результат: " + result_lab3);
            Close();
        }
        //1
        private void lab3_var1_button1_Click(object sender, EventArgs e)
        {
            new Plane_Lab3();
        }
        private void lab3_var1_button2_Click(object sender, EventArgs e)
        {
            new ArmyPlane();
        }
        private void lab3_var1_button4_Click(object sender, EventArgs e)
        {
            new CivPlane();
        }
        private void lab3_var1_button3_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для військового літака\n", "Створюємо Військовий Літак", "Бомбардувальник"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "15"));
            new ArmyPlane(name_cons, color_cons, size_cons);
        }
        private void lab3_var1_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для цивільного літака\n", "Створюємо Цивільний Літак", "Вантажний"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "50"));
            new CivPlane(name_cons, color_cons, size_cons);
        }
        private void lab3_var1_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Plane_Lab3.count, 
                "Але напевно що уже не " + Plane_Lab3.count);
        }
        //2
        private void lab3_var2_button1_Click(object sender, EventArgs e)
        {
            new Fish_Lab3();
        }
        private void lab3_var2_button2_Click(object sender, EventArgs e)
        {
            new OceanicFish();
        }
        private void lab3_var2_button4_Click(object sender, EventArgs e)
        {
            new ClassicFish();
        }
        private void lab3_var2_button3_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для океанічної риби\n", "Створюємо Океанічну рибу", "Риба-молот"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Темно-сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new OceanicFish(name_cons, color_cons, size_cons);
        }
        private void lab3_var2_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для прісноводної риби\n", "Створюємо Прісноводну рибу", "Сом"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "1"));
            new ClassicFish(name_cons, color_cons, size_cons);
        }
        private void lab3_var2_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Fish_Lab3.count, 
                "Але напевно що уже не " + Fish_Lab3.count);
        }
        //3
        private void lab3_var3_button1_Click(object sender, EventArgs e)
        {
            new BankCard_Lab3();
        }
        private void lab3_var3_button2_Click(object sender, EventArgs e)
        {
            new KDV();
        }
        private void lab3_var3_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву карти для виплат\n", "Створюємо Карту для виплат", "Робоча"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "9"));
            new KDV(name_cons, color_cons, size_cons);
        }
        private void lab3_var3_button3_Click(object sender, EventArgs e)
        {
            new Universal();
        }
        private void lab3_var3_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву карти універсальної\n", "Створюємо Карту універсальну", "Для покупок"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелена"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "9"));
            new Universal(name_cons, color_cons, size_cons);
        }
        private void lab3_var3_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + BankCard_Lab3.count,
                "Але напевно що уже не " + BankCard_Lab3.count);
        }
        //4
        private void lab3_var4_button1_Click(object sender, EventArgs e)
        {
            new Phone_Lab3();
        }
        private void lab3_var4_button2_Click(object sender, EventArgs e)
        {
            new OldPhone();
        }
        private void lab3_var4_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для стаціонарного телефона\n", "Створюємо Стаціонарний телефон", "Alcatel"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "2"));
            new OldPhone(name_cons, color_cons, size_cons);
        }
        private void lab3_var4_button3_Click(object sender, EventArgs e)
        {
            new MobilePhone();
        }
        private void lab3_var4_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для мобільного телефона\n", "Створюємо Мобільний телефон", "Meizu"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new MobilePhone(name_cons, color_cons, size_cons);
        }
        private void lab3_var4_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Phone_Lab3.count,
                "Але напевно що уже не " + Phone_Lab3.count);
        }
        //5
        private void lab3_var5_button1_Click(object sender, EventArgs e)
        {
            new List_Lab3();
        }
        private void lab3_var5_button2_Click(object sender, EventArgs e)
        {
            new PaperList();
        }
        private void lab3_var5_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для поштового листа\n", "Створюємо Поштовий лист", "Родичам"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "4"));
            new PaperList(name_cons, color_cons, size_cons);
        }
        private void lab3_var5_button3_Click(object sender, EventArgs e)
        {
            new EList();
        }
        private void lab3_var5_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для електронного листа\n", "Створюємо Електронний лист", "Дружній"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Фіолетовий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "150"));
            new EList(name_cons, color_cons, size_cons);
        }
        private void lab3_var5_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + List_Lab3.count,
                "Але напевно що уже не " + List_Lab3.count);
        }
        //6
        private void lab3_var6_button1_Click(object sender, EventArgs e)
        {
            new Auto_Lab3();
        }
        private void lab3_var6_button2_Click(object sender, EventArgs e)
        {
            new BigAuto();
        }
        private void lab3_var6_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для вантажного автомобіля\n", "Створюємо Вантажний автомобіль", "MAN"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "15"));
            new BigAuto(name_cons, color_cons, size_cons);
        }
        private void lab3_var6_button3_Click(object sender, EventArgs e)
        {
            new LiteAuto();
        }
        private void lab3_var6_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для легкового автомобіля\n", "Створюємо Легковий автомобіль", "Nissan"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new LiteAuto(name_cons, color_cons, size_cons);
        }
        private void lab3_var6_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Auto_Lab3.count,
                "Але напевно що уже не " + Auto_Lab3.count);
        }
        //7
        //_мій_варіант_№7____________________________________________________________________________________________________________________
        private void lab3_var7_button1_Click(object sender, EventArgs e)
        {
            new Outerwear_Lab3();
        }
        private void lab3_var7_button2_Click(object sender, EventArgs e)
        {
            new Blouse();
        }
        private void lab3_var7_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для кофти\n", "Створюємо кофту", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            new Blouse(name_cons, color_cons, size_cons);
        }
        private void lab3_var7_button3_Click(object sender, EventArgs e)
        {
            new Jacket();
        }
        private void lab3_var7_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо куртку", "Літня"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "42"));
            new Jacket(name_cons, color_cons, size_cons);
        }
        private void lab3_var7_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Outerwear_Lab3.count,
                "Але напевно що уже не " + Outerwear_Lab3.count);
        }
        //___________________________________________________________ _______________________________________________________________________
        //8
        private void lab3_var8_button1_Click(object sender, EventArgs e)
        {
            new Product_Lab3();
        }
        private void lab3_var8_button2_Click(object sender, EventArgs e)
        {
            new Vegetable();
        }
        private void lab3_var8_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для овоча\n", "Створюємо Овоч", "Перець"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Vegetable(name_cons, color_cons, size_cons);
        }
        private void lab3_var8_button3_Click(object sender, EventArgs e)
        {
            new Fruit();
        }
        private void lab3_var8_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для фрукта\n", "Створюємо Фрукт", "Груша"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Fruit(name_cons, color_cons, size_cons);
        }
        private void lab3_var8_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Product_Lab3.count,
                "Але напевно що уже не " + Product_Lab3.count);
        }
        //9
        private void lab3_var9_button1_Click(object sender, EventArgs e)
        {
            new Shoes_Lab3();
        }
        private void lab3_var9_button2_Click(object sender, EventArgs e)
        {
            new Boots();
        }
        private void lab3_var9_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для чоботів\n", "Створюємо Чоботи", "Начищені"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "47"));
            new Boots(name_cons, color_cons, size_cons);
        }
        private void lab3_var9_button3_Click(object sender, EventArgs e)
        {
            new Shoes();
        }
        private void lab3_var9_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для туфель\n", "Створюємо Туфлі", "Парадні"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "32"));
            new Shoes(name_cons, color_cons, size_cons);
        }
        private void lab3_var9_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Shoes_Lab3.count,
                "Але напевно що уже не " + Shoes_Lab3.count);
        }
        //10
        private void lab3_var10_button1_Click(object sender, EventArgs e)
        {
            new Candy_Lab3();
        }
        private void lab3_var10_button2_Click(object sender, EventArgs e)
        {
            new Chocolate();
        }
        private void lab3_var10_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для шоколадних цукерок\n", "Створюємо Шоколадні цукерки", "Світоч"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Червоний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "3"));
            new Chocolate(name_cons, color_cons, size_cons);
        }
        private void lab3_var10_button3_Click(object sender, EventArgs e)
        {
            new Caramel();
        }
        private void lab3_var10_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для карамельних цукерок\n", "Створюємо Карамельні цукерки", "Барбариски"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Червоний"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "1"));
            new Caramel(name_cons, color_cons, size_cons);
        }
        private void lab3_var10_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Candy_Lab3.count,
                "Але напевно що уже не " + Candy_Lab3.count);
        }
        //11
        private void lab3_var11_button1_Click(object sender, EventArgs e)
        {
            new Animal_Lab3();
        }
        private void lab3_var11_button2_Click(object sender, EventArgs e)
        {
            new DomesticAnimal();
        }
        private void lab3_var11_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для свійської тварини\n", "Створюємо Свійську тварину", "Барбос"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Чорно-білий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "6"));
            new DomesticAnimal(name_cons, color_cons, size_cons);
        }
        private void lab3_var11_button3_Click(object sender, EventArgs e)
        {
            new WildAnimal();
        }
        private void lab3_var11_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для хижої тварини\n", "Створюємо Хижу тварину", "Косолапий"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Коричневий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "20"));
            new WildAnimal(name_cons, color_cons, size_cons);
        }
        private void lab3_var11_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Animal_Lab3.count,
                "Але напевно що уже не " + Animal_Lab3.count);
        }
        //12
        private void lab3_var12_button1_Click(object sender, EventArgs e)
        {
            new Book_Lab3();
        }
        private void lab3_var12_button2_Click(object sender, EventArgs e)
        {
            new PaperBook();
        }
        private void lab3_var12_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для паперової книги\n", "Створюємо Паперову книгу", "Том Сойєр"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Синій"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "450"));
            new PaperBook(name_cons, color_cons, size_cons);
        }
        private void lab3_var12_button3_Click(object sender, EventArgs e)
        {
            new EBook();
        }
        private void lab3_var12_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для електронної книги\n", "Створюємо Електронну книгу", "Пеппі довга панчоха")); //gg
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Зелений"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "800"));
            new EBook(name_cons, color_cons, size_cons);
        }
        private void lab3_var12_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Book_Lab3.count,
                "Але напевно що уже не " + Book_Lab3.count);
        }
        //13
        private void lab3_var13_button1_Click(object sender, EventArgs e)
        {
            new Periodical_Lab3();
        }
        private void lab3_var13_button2_Click(object sender, EventArgs e)
        {
            new News();
        }
        private void lab3_var13_button4_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для газети\n", "Створюємо Газету", "ПРАВДА"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Жовтий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "12"));
            new News(name_cons, color_cons, size_cons);
        }
        private void lab3_var13_button3_Click(object sender, EventArgs e)
        {
            new Magazine();
        }
        private void lab3_var13_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для журналу\n", "Створюємо Журнал", "Лабараторій*")); 
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Прозорий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "1000"));
            new Magazine(name_cons, color_cons, size_cons);
        }
        private void lab3_var13_button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На момент виведення цього повідомлення об'єктів наразі: " + Periodical_Lab3.count,
                "Але напевно що уже не " + Periodical_Lab3.count);
        }
        //14
                //
        //15
                //
    }
                   //Класи для лабараторної №2________
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
            MessageBox.Show("Знищується Літак №" + nomer, "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Літак №" + (count + 1) + " створено", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }          //Літак                /Варіант №1
    public partial class ArmyPlane : Plane_Lab3
    {
        String name, color, status;
        int size;
        bool isFly;
        public ArmyPlane()
        {
            this.name = "Винищувач"; this.color = "Сірий"; this.size = 6; this.status = "Новий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public ArmyPlane(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public string isFlys()
        {
            if (isFly == false)
                if (status.Equals("Ветеран"))
                    return "Старий воєнний літак";
                else return "Не літає уже давно";
            else return "Готовий до бойових дій";
        }
        public string SizeString()
        {
            if (size > 4)
                if (size < 7)
                    return "Звичайного розміру літак";
                else return "Великий літак";
            else return "Літачок";
        }
        public void Info()
        {
            MessageBox.Show("Воєнний літак з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFlys() + "\n\n" + SizeString() + "\n\n\n",
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
            this.name = "Пасажирський"; this.color = "Синій"; this.size = 35; this.status = "Новий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public CivPlane(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFly = false; else isFly = true;
        }
        public string isFreaks()
        {
            if (isFly == false)
                if (status.Equals("Поганий"))
                    return "Не придатний для польотів";
                else return "Не придатний для транспортування людей";
            else return "Літак для транспорування людей";
        }
        public string SizeString()
        {
            if (size > 25)
                if (size < 60)
                    return "Стандартний цивільний літак";
                else return "Великий цивільний літак";
            else return "Маленькій цивільний літак";
        }
        public void Info()
        {
            MessageBox.Show("Літак з назвою: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий Літак",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
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
            MessageBox.Show("Знищується Риба №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Риба №" + (count + 1) + " створена", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }           //Риба                 /Варіант №2
    public partial class OceanicFish : Fish_Lab3
    {
        String name, color, status;
        int size;
        public OceanicFish()
        {
            this.name = "Акула"; this.color = "Сірий"; this.size = 4; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public OceanicFish(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
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
                if (size < 5)
                    return "Звичайний розмір";
                else return "Величезна";
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
            this.name = "Лин"; this.color = "Жовтий"; this.size = 1; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public ClassicFish(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
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
                if (size < 2)
                    return "Звичайний розмір";
                else return "Величезна";
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
    //
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
            MessageBox.Show("Знищується Картка №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public string isLimits()
        {
            if (isLimit == false)
                if (status.Equals("Зламана"))
                    return "Нею уже не розрахуєшся";
                else return "Мусиш мати свої кошти";
            else return "Можеш взяти гроші в кредит";
        }
        public string SizeString()
        {
            if (size > 6)
                if (size < 10)
                    return "Звичайний розмір картки";
                else return "Велика картка";
            else return "Маленька картка";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Картка №" + (count + 1) + " створена", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }       //Банківська карта     /Варіант №3
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
            MessageBox.Show("Картка для виплат з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + SizeString() + "\n\n\n",
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
            MessageBox.Show("Картка універсальна з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isLimits() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така карта універсальна",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
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
            count--; lab3_Form.result_lab3++;
        }
        public string isWorks()
        {
            if (isWork == false)
                if (status.Equals("Зламаний"))
                    return "Пошкоджений";
                else return "Не працює";
            else return "Працюючий телефон";
        }
        public string SizeString()
        {
            if (size > 4)
                if (size < 7)
                    return "Телефон звичайного розміру";
                else return "Великий телефон";
            else return "Маленький телефон";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Телефон №" + (count + 1) + " створений", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }          //Телефон              /Варіант №4
    public partial class OldPhone : Phone_Lab3
    {
        public OldPhone()
        {
            this.name = "Провідний"; this.color = "Білий"; this.size = 8; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public OldPhone(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public void Info()
        {
            MessageBox.Show("Стаціонарний телефон з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий стаціонарний телефон",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class MobilePhone : Phone_Lab3
    {
        public MobilePhone()
        {
            this.name = "OnePlus"; this.color = "Чорний аметист"; this.size = 6; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public MobilePhone(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public void Info()
        {
            MessageBox.Show("Мобільний телефон з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий мобільний телефон",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
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
            MessageBox.Show("Знищується Лист №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Лист №" + (count + 1) + " створений", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }           //Лист                 /Варіант №5
    public partial class PaperList : List_Lab3
    {
        public bool isDirty;
        public PaperList()
        {
            this.name = "Діловий"; this.color = "Білий"; this.size = 8; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public PaperList(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public string isDirtys()
        {
            if (isDirty == true)
                if (status.Equals("Порваний"))
                    return "М'ятий та списаний";
                else return "Брудний";
            else return "Охайний лист";
        }
        public string SizeString()
        {
            if (size > 3)
                if (size < 5)
                    return "Розміру А4";
                else return "Великий лист";
            else return "Малий лист";
        }
        public void Info()
        {
            MessageBox.Show("Поштовий лист з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDirtys() + "\n\n" + SizeString() + "\n\n\n",
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
            this.name = "З банку"; this.color = "Червоний"; this.size = 6; this.status = "Негативний"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public EList(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public string isWrongs()
        {
            if (isWrong == false)
                if (status.Equals("Негативний"))
                    return "Схоже у когось борги";
                else return "Чому він червоний якщо новина позитивна?????";
            else return "Ми так і не дізнаємось що там";
        }
        public string SizeString()
        {
            if (size > 100)
                if (size < 200)
                    return "Хоча він і не довгий, всеодно лінь читати";
                else return "Хто пише такі довгі електронні листи?";
            else return "Меньше ста символів, можна навіть і прочитати";
        }
        public void Info()
        {
            MessageBox.Show("Електронний лист: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWrongs() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий електронний лист",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
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
            MessageBox.Show("Знищується Автомобіль №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
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
            MessageBox.Show("Автомобіль №" + (count + 1) + " створений", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }           //Автомобіль           /Варіант №6
    public partial class BigAuto : Auto_Lab3
    {
        public BigAuto()
        {
            this.name = "Mercedes"; this.color = "Жовтий"; this.size = 6; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public BigAuto(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public string SizeString()
        {
            if (size > 5)
                if (size < 10)
                    return "Вантажний автомобіль звичайного розміру";
                else return "Великий вантажний автомобіль";
            else return "Малий вантажний автомобіль";
        }
        public void Info()
        {
            MessageBox.Show("Вантажний автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий вантажний автомобіль",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class LiteAuto : Auto_Lab3
    {
        public LiteAuto()
        {
            this.name = "Opel"; this.color = "Сірий"; this.size = 6; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public LiteAuto(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWork = false; else isWork = true;
        }
        public string SizeString()
        {
            if (size > 2)
                if (size < 4)
                    return "Легковий автомобіль звичайного розміру";
                else return "Великий легковий автомобіль";
            else return "Малий легковий автомобіль";
        }
        public void Info()
        {
            MessageBox.Show("Легковий автомобіль: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWorks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий легковий автомобіль",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
    //_мій_варіант_№7_________________________________________________________________________________________________________________________________
    public partial class Outerwear_Lab3
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
        virtual public void InfoLab3()
        {
            MessageBox.Show("Верхній одяг №" + (count + 1) + " створено",
                "Інформація",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }      //Верхній одяг         /Варіант №7
    public partial class Blouse : Outerwear_Lab3
    {
        public Blouse()
        {
            this.name = "Abibas"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Blouse(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
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
        public override void InfoLab3()
        {
            base.InfoLab3();
            Info();
        }
    }
    public partial class Jacket : Outerwear_Lab3
    {
        public Jacket()
        {
            this.name = "Пума"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Jacket(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Новa";
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
        public void Info()
        {
            MessageBox.Show("Куртка бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa Куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public override void InfoLab3()
        {
            base.InfoLab3();
            Info();
        }

    }
    //___________________________________________________________ ____________________________________________________________________________________
    //                                                                      
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
            MessageBox.Show("Знищується Продукт №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
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
            MessageBox.Show("Продукт №" + (count + 1) + " створений", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }        //Продукт              /Варіант №8
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
    //                                                                     
    public partial class Shoes_Lab3
    {
        public static int count;
        public int nomer;
        public bool isComfortable;
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
            MessageBox.Show("Знищуються Взуття №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public string isComfortablebl()
        {
            if (isComfortable == false)
                if (status.Equals("Пошкоджене"))
                    return "Порвані, не зручні";
                else return "Не комфортні";
            else return "Ля, зручні, красиві, нові";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Взуття №" + (count + 1) + " створене", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }          //Взуття               /Варіант №9
    public partial class Boots : Shoes_Lab3
    {
        public Boots()
        {
            this.name = "Шкари"; this.color = "Коричневий"; this.size = 42; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isComfortable = false; else isComfortable = true;
        }
        public Boots(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isComfortable = false; else isComfortable = true;
        }
        public string SizeString()
        {
            if (size > 38)
                if (size < 47)
                    return "Чоботи більш-меньш стандартного розміру";
                else return "Великі чоботи";
            else return "Малі чоботи";
        }
        public void Info()
        {
            MessageBox.Show("Чоботи: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isComfortablebl() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такі чоботи",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Shoes : Shoes_Lab3
    {
        public Shoes()
        {
            this.name = "Нарядні"; this.color = "Чорний"; this.size = 39; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isComfortable = false; else isComfortable = true;
        }
        public Shoes(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isComfortable = false; else isComfortable = true;
        }
        public string SizeString()
        {
            if (size > 36)
                if (size < 47)
                    return "Туфлі звичайного розміру";
                else return "Великі туфлі";
            else return "Малі туфлі";
        }
        public void Info()
        {
            MessageBox.Show("Туфлі: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isComfortablebl() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такі туфлі",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
    public partial class Candy_Lab3
    {
        public static int count;
        public int nomer;
        public bool isDelicious;
        public String name, color, status;
        public int size;
        public Candy_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Candy_Lab3()
        {
            MessageBox.Show("Знищуються Цукерки №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public string isDeliciouss()
        {
            if (isDelicious == false)
                if (status.Equals("Пошкоджені"))
                    return "Пошкоджені";
                else return "Не смачні, брудні";
            else return "Дуже добрі цукерки";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Цукерки №" + (count + 1) + " створені", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }          //Цукерки              /Варіант №10
    public partial class Chocolate : Candy_Lab3
    {
        public Chocolate()
        {
            this.name = "Рошен"; this.color = "Білий"; this.size = 4; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Chocolate(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 2)
                if (size < 5)
                    return "Шоколадні цукерки середнього розміру";
                else return "Великі шоколадні цукерки";
            else return "Малі шоколадні цукерки";
        }
        public void Info()
        {
            MessageBox.Show("Шоколадні цукерки: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такі шоколадні цукерки",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Caramel : Candy_Lab3
    {
        public Caramel()
        {
            this.name = "Рошен"; this.color = "Зелений"; this.size = 2; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public Caramel(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілі";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDelicious = false; else isDelicious = true;
        }
        public string SizeString()
        {
            if (size > 2)
                if (size < 5)
                    return "Карамельні цукерки звичайного розміру";
                else return "Великі карамельні цукерки";
            else return "Малі карамельні цукерки";
        }
        public void Info()
        {
            MessageBox.Show("Карамельні цукерки: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDeliciouss() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такі карамельні цукерки",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
    public partial class Animal_Lab3
    {
        public static int count;
        public int nomer;
        public bool isStrong;
        public Animal_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Animal_Lab3()
        {
            MessageBox.Show("Знищується Тварина №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Тварина №" + (count + 1) + " створена", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }         //Тварина              /Варіант №11
    public partial class DomesticAnimal : Animal_Lab3
    {
        String name, color, status, type = "Травоїдна";
        int size;
        public DomesticAnimal()
        {
            this.name = "Курка"; this.color = "Білий"; this.size = 2; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public DomesticAnimal(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Мертва"))
                    return "Мертва";
                else return "Слабка";
            else return "В цієї свійської тварини є всі шанси на життя";
        }
        public string SizeString()
        {
            if (size > 5)
                if (size < 10)
                    return "Звичайний розмір";
                else return "Величезна";
            else return "Маленька";
        }
        public void Info()
        {
            MessageBox.Show("Свійська тварина з іменем: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n" + type + "\n" + SizeString() + "\n\n\n",
                "Ось така свійська тварина",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class WildAnimal : Animal_Lab3
    {
        String name, color, status, type = "М'ясоїдна!";
        int size;
        public WildAnimal()
        {
            this.name = "Лин"; this.color = "Жовтий"; this.size = 1; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public WildAnimal(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Жива"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isStrong = false; else isStrong = true;
        }
        public string isStrongs()
        {
            if (isStrong == false)
                if (status.Equals("Мертва"))
                    return "Мертва";
                else return "Слабка";
            else return "В цієї хижої тварини є всі шанси на виживання";
        }
        public string SizeString()
        {
            if (size > 8)
                if (size < 15)
                    return "Звичайний розмір";
                else return "Величезна";
            else return "Маленька";
        }
        public void Info()
        {
            MessageBox.Show("Хижа тварина з назвою: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isStrongs() + "\n" + type + "\n" + SizeString() + "\n\n\n",
                "Ось така хижа тварина",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
    public partial class Book_Lab3
    {
        public static int count;
        public int nomer;
        public String name, color, status;
        public int size;
        public Book_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Book_Lab3()
        {
            MessageBox.Show("Знищується Книга №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public void InfoLab3()
        {
            MessageBox.Show("Книга №" + (count + 1) + " створена", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }           //Книга                /Варіант №12
    public partial class PaperBook : Book_Lab3
    {
        public bool isDirty;
        public PaperBook()
        {
            this.name = "Научно-фантастична"; this.color = "Синій"; this.size = 800; this.status = "Ціла"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public PaperBook(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Ціла"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isDirty = false; else isDirty = true;
        }
        public string isDirtys()
        {
            if (isDirty == true)
                if (status.Equals("Порвана"))
                    return "М'ята та занедбана паперова книга";
                else return "Брудна паперова книга";
            else return "Охайна паперова книга";
        }
        public string SizeString()
        {
            if (size > 100)
                if (size < 300)
                    return "Можна прочитати максимум за декілька днів";
                else return "Тиждень втомливого читання";
            else return "Більш схожа на брошуру";
        }
        public void Info()
        {
            MessageBox.Show("Паперова книга: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isDirtys() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така паперова книга",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class EBook : Book_Lab3
    {
        public bool isWrong;
        public EBook()
        {
            this.name = "З банку"; this.color = "Червоний"; this.size = 6; this.status = "Негативний"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public EBook(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; 
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isWrong = false; else isWrong = true;
        }
        public string isWrongs()
        {
            if (isWrong == false)
                if (status.Equals("Цікава"))
                    return "Дуже цікава книга";
                else return "Не дуже цікава";
            else return "Пошкоджена електронна книга";
        }
        public string SizeString()
        {
            if (size > 200)
                if (size < 500)
                    return "Хоча вона і не довга, всеодно лінь читати";
                else return "Хто пише такі довгі великі книжки?";
            else return "Меньше ста символів, можна навіть і прочитати :)";
        }
        public void Info()
        {
            MessageBox.Show("Електронна книга: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isWrongs() + "\n\n" + SizeString() + "\n\n\n",
                "Ось така електронна книга",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //
    public partial class Periodical_Lab3
    {
        public static int count;
        public int nomer;
        public bool isActual;
        public String name, color, status;
        public int size;
        public Periodical_Lab3()
        {
            InfoLab3();
            count++;
            nomer = count;
        }
        ~Periodical_Lab3()
        {
            MessageBox.Show("Знищується Періодичне видання №" + nomer, 
                "Увага", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
        }
        public string SizeString()
        {
            if (size > 12)
                if (size < 24)
                    return "Звичайний розмір видання";
                else return "Великий розмір видання";
            else return "Маленький розмір видання";
        }
        public void InfoLab3()
        {
            MessageBox.Show("Періодичне видання №" + (count + 1) + " створено", 
                "Інформація", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }     //Періодичне видання   /Варіант №13
    public partial class News : Periodical_Lab3
    {
        public News()
        {
            this.name = "Новини Рівного"; this.color = "Жовтий"; this.size = 8; this.status = "Ціла"; isActual = false;
        }
        public News(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Ціла"; isActual = false;
        }
        public void Info()
        {
            MessageBox.Show("Газета з назвою: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + "\n\n" + SizeString() + "\n\n\n",
                "Ось така газета",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public partial class Magazine : Periodical_Lab3
    {
        public Magazine()
        {
            this.name = "Рибацький"; this.color = "Синій"; this.size = 8; this.status = "Цілий"; isActual = true;
        }
        public Magazine(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; this.status = "Цілий"; isActual = true;
        }
        public void Info()
        {
            MessageBox.Show("Журнал: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + "\n\n" + SizeString() + "\n\n\n",
                "Ось такий журнал!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    //

    //

                   //Класи для лабараторної №2________
}

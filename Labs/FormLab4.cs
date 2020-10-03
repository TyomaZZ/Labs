using Microsoft.VisualBasic;
using Microsoft.Win32;
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
    public partial class FormLab4 : Form
    { 
        Button a;
        public static ToolStripStatusLabel asd;
        public FormLab4()
        {
            InitializeComponent();
            asd = toolStripStatusLabel1;
        }
        private void button_rnd(object sender, EventArgs e)
        {
            a.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (a != null)
                a.Hide();
            a = new Button();
            Random rnd = new Random();
            a.Width = 100;
            a.Height = 25;
            a.Left = rnd.Next(0, 75);
            a.Top = rnd.Next(0, 40);
            a.Text = "Знищити кнопку";
            a.Parent = panel4;
            a.Click += new System.EventHandler(this.button_rnd);
        }
        private void lab3_var7_button1_Click_1(object sender, EventArgs e)
        {
            Blouse p1 = new Blouse();
            Jacket d1 = new Jacket();
            Outerwear f;
            f = p1;
            f.InfoLab3();
            f = d1;
            f.InfoLab3();
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            foreach (Control elem in lab3_panel7.Controls)
                if (elem.Equals(panel3) || elem.Equals(panel2) || elem.Equals(button1))
                { }
                else  elem.Left += 10;
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            foreach (Control elem in lab3_panel7.Controls)
                if (elem.Equals(panel3) || elem.Equals(panel2) || elem.Equals(button1))
                { }
                else elem.Left -= 10;
        }
        private void button17_Click_1(object sender, EventArgs e)
        {
            foreach (Control elem in lab3_panel7.Controls)
                if (elem.Equals(panel3) || elem.Equals(panel2) || elem.Equals(button1))
                { }
                else elem.Top -= 10;
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            foreach (Control elem in lab3_panel7.Controls)
            {
                if (elem.Equals(panel3) || elem.Equals(panel2) || elem.Equals(button1))
                { }
                else elem.Top += 10;
            }
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }

        private void lab3_var7_button2_Click(object sender, EventArgs e)
        {
            Blouse p1 = new Blouse();
            Label l = new Label();
            l.AutoSize = true;
            l.Parent = flowLayoutPanel1;
            l.Text = "Створено Куртку: " + p1.name;
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }

        private void lab3_var7_button4_Click(object sender, EventArgs e)
        {
            Jacket p1 = new Jacket();
            Label l = new Label();
            l.AutoSize = true;
            l.Parent = flowLayoutPanel1;
            l.Text = "Створено Пальто: " + p1.name;
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }

        private void lab3_var7_button3_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо Куртку", "LeeCo"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "38"));
            Blouse blouse = new Blouse(name_cons, color_cons, size_cons);
            Label l = new Label();
            l.AutoSize = true;
            l.Parent = flowLayoutPanel1;
            l.Text = "Створено Пальто: " + blouse.name;
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }

        private void lab3_var7_button5_Click(object sender, EventArgs e)
        {
            String name_cons, color_cons; int size_cons;
            name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо Куртку", "LeeCo"));
            color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
            size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "38"));
            Jacket jacket = new Jacket(name_cons, color_cons, size_cons);
            Label l = new Label();
            l.AutoSize = true;
            l.Parent = flowLayoutPanel1;
            l.Text = "Створено Пальто: " + jacket.name;
            toolStripStatusLabel1.Text = "Кількість об'єктів: " + Outerwear.count;
        }
    }

    public abstract class Outerwear
    {
        public String name, color, status;
        public static int count;
        public int nomer, size;
        public bool isFreak;
        public Outerwear()
        { }
        ~Outerwear()
        {
            MessageBox.Show("Знищується Верхній Одяг №" + nomer,
                "Увага",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            count--; lab3_Form.result_lab3++;
           FormLab4.asd.Text = "Кількість об'єктів: " + count;
        }
        virtual public void InfoLab3()
        {
            MessageBox.Show("Верхній одяг №" + nomer + " створено",
                "Інформація",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }      //Верхній одяг         /Варіант №7
    public class Blouse : Outerwear
    {
        public Blouse()
        {
            count++;
            nomer = count;
            this.name = "Abibas"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Blouse(String name, String color, int size)
        {
            count++;
            nomer = count;
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
    public class Jacket : Outerwear
    {
        public Jacket()
        {
            count++;
            nomer = count;
            this.name = "Пума"; this.color = "Зелена"; this.size = 36; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public Jacket(String name, String color, int size)
        {
            count++;
            nomer = count;
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
}

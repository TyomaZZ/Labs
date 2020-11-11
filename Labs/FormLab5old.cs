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
    public partial class FormLab5old : Form
    {
        public FormLab5old()
        {
            InitializeComponent();
        }
        private void blouse_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                String name_cons, color_cons; int size_cons;
                name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Створюємо Куртку", "LeeCo"));
                color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Сірий"));
                size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "38"));
                new Blouse_lab5(name_cons, color_cons, size_cons).Info();
            }
            else
            {
                Blouse_lab5 b1 = new Blouse_lab5("Adidas", "Зелена", 36);
                b1.Info();
                b1.Size = -5;
                MessageBox.Show("Дані куртки після зміни розміру на -5");
                b1.Info();
                b1.Size = 46;
                MessageBox.Show("Дані куртки після зміни розміру на 46");
                b1.Info();
            }
        }
        private void jacket_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                String name_cons, color_cons; int size_cons;
                name_cons = Convert.ToString(Interaction.InputBox("Введіть назву для пальта\n", "Створюємо Пальто", "Crocco"));
                color_cons = Convert.ToString(Interaction.InputBox("Введіть колір", name_cons, "Оранжевий"));
                size_cons = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", name_cons, "32"));
                new Jacket_lab5(name_cons, color_cons, size_cons).Info();
            }
            else
            {
                Jacket_lab5 j1 = new Jacket_lab5("Puma", "Чорний", 34);
                j1.Info();
                j1.Size = -5;
                MessageBox.Show("Дані пальта після зміни розміру на -5");
                j1.Info();
                j1.Size = 39;
                MessageBox.Show("Дані пальта після зміни розміру на 39");
                j1.Info();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HotBlouse_lab5 j1 = new HotBlouse_lab5("Fabric", "Білий", 44);
            j1.Info();
            j1.Size = -5;
            MessageBox.Show("Дані теплої куртки після зміни розміру на -5");
            j1.Info();
            j1.Size = 40;
            MessageBox.Show("Дані теплої куртки після зміни розміру на 40");
            j1.Info();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sjsh = new StyleJacket_lab5("Carlic", "Жовтий", 50);
            int i = 1;
            int maxSize = 10;
            maxSize = Convert.ToInt32(Interaction.InputBox("Введіть обмеження розміру для куртки\n(Меньше стандартного розміру \"36\")", 
                "Карликове стильне пальто", "15"));
            while (sjsh[i].Size > maxSize) i++;
            MessageBox.Show("Стильне карликове пальто № " + i + " має розмір: " + sjsh[i].Size, 
                "Стильне карликове пальто", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            //tyomashi
        }
    }
    public abstract class Outerwear_lab5
    {
        public static int count;
        public int nomer;
        public String name, color, status;
        public bool isFreak;
        public Outerwear_lab5()
        {
            count++;
            nomer = count;
        }
        ~Outerwear_lab5()
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
    public class HotBlouse_lab5 : Blouse_lab5
    {
        public bool isHot;
        public HotBlouse_lab5(String name, String color, int size) : base(name, color, size)
        {
            isHot = true;
        }
        public override void Info()
        {
            MessageBox.Show("Тепла куртка бренду: " + name + "\n" + color + " колiр\nРозмір: " + Size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa тепла куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public class Blouse_lab5 : Outerwear_lab5
    {
        private int size;
        public int Size { get { return size; } set { if (value >= 0) size = value; } }
        public Blouse_lab5(String name, String color, int size) : base()
        {
            base.Info();
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
        public override void Info()
        {
            MessageBox.Show("Куртка бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось такa куртка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
    public class StyleJacket_lab5 : Jacket_lab5
    {
        public StyleJacket_lab5(String name, String color, int size) : base(name, color, size)
        { }
        public StyleJacket_lab5 this[int i]
        { get
            {
                if (i <= 0)
                    return new StyleJacket_lab5(name, color, Size);
                else
                    return new StyleJacket_lab5(name, color, (Size - i));
            }
        }
    }
    public class Jacket_lab5 : Outerwear_lab5
    {
        private int size;
        public int Size { get { return size; } set { if (value >= 0) size = value; } }
        public Jacket_lab5(String name, String color, int size) : base()
        {
            base.Info();
            this.name = name; this.color = color; this.size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public string isFreaks()
        {
            if (isFreak == true)
                if (status.Equals("Потаскане"))
                    return "Жахливе пальто";
                else return "Досить миле пальто...";
            else return "Класне пальто :р";
        }
        public string SizeString()
        {
            if (size > 25)
                if (size < 55)
                    return "Це пальто навіть могло б підійти для тебе";
                else return "Це пальто завелике для тебе!";
            else return "Це пальто замале для тебе!";
        }
        public override void Info()
        {
            MessageBox.Show("Пальто бренду: " + name + "\n" + color + " колiр\nРозмір: " + size + "\n" + isFreaks() + "\n\n" + SizeString() + "\n\n\n",
                "Ось таке Пальто",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

}

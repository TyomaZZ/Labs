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
{ //tyomashi
    public partial class FormLab6 : Form
    {
        KurtkaLab6 k1 = null, k2 = null;
        public FormLab6()
        {
            InitializeComponent();
            toolStripStatusLabel3.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            k2.Info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k1 = new KurtkaLab6("Типова", "Чорний", 36, "Нова");
            toolStripStatusLabel1.Text = "Перша куртка: створена;";
            groupBox1.Enabled = true;
            button5.Enabled = true;
            button9.Enabled = true;
            button1.Enabled = false;
            if ((Object)k2 != null)
            {
                toolStripStatusLabel3.Visible = true;
                button7.Enabled = true;
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k2 = new KurtkaLab6("Типова", "Чорний", 36, "Нова");
            toolStripStatusLabel2.Text = "Друга куртка: створена;";
            groupBox2.Enabled = true;
            button6.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = false;
            if ((Object)k1 != null)
            {
                toolStripStatusLabel3.Visible = true;
                button7.Enabled = true;
                check();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            k1.Info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (k1 == k2)
            {
                MessageBox.Show("Куртки одинакові!", "Інформація з порівняння");
            }
            else MessageBox.Show("Куртки різні!", "Інформація з порівняння");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            k1++;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k2++;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                k1.Name = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Змінюємо назву Куртки", k1.Name));
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    k1.color = Convert.ToString(Interaction.InputBox("Введіть колір куртки", "Змінюємо колір Куртки", k1.color));
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        k1.Size = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", "Змінюємо розмір Куртки", "" + k1.Size));
                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {
                            k1.status = Convert.ToString(Interaction.InputBox("Введіть стан куртки\n", "Змінюємо стан Куртки", k1.status));
                        }
                        else { MessageBox.Show("Виберіть параметр для редагування"); }
                    }
                }
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                k2.Name = Convert.ToString(Interaction.InputBox("Введіть назву для куртки\n", "Змінюємо назву Куртки", k2.Name));
            }
            else
            {
                if (radioButton7.Checked == true)
                {
                    k2.color = Convert.ToString(Interaction.InputBox("Введіть колір куртки", "Змінюємо колір Куртки", k2.color));
                }
                else
                {
                    if (radioButton6.Checked == true)
                    {
                        k2.Size = Convert.ToInt32(Interaction.InputBox("Введіть розмір\n", "Змінюємо розмір Куртки", "" + k2.Size));
                    }
                    else
                    {
                        if (radioButton5.Checked == true)
                        {
                            k2.status = Convert.ToString(Interaction.InputBox("Введіть стан куртки\n", "Змінюємо стан Куртки", k2.status));
                        }
                        else { MessageBox.Show("Виберіть параметр для редагування"); }
                    }
                }
            }
            check();
        }

        private void check()
        {
            if ((Object)k1 != null && (Object)k2 != null)
            {
                if (k1 == k2)
                { toolStripStatusLabel3.Text = "Куртки однакові;"; }
                else
                { toolStripStatusLabel3.Text = "Куртки різні;"; }
            }
        }
    }
    public abstract class OdyagLab6
    {
        public static int count;
        public int nomer;
        public String color, status;
        public bool isFreak;
        public OdyagLab6()
        {
            count++;
            nomer = count;
        }
        ~OdyagLab6()
        {
            /* 
              MessageBox.Show("Знищується Верхній Одяг №" + nomer,
                  "Увага",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation); 
            */
            count--;
        }
        virtual public void Info()
        {
            /* MessageBox.Show("Верхній одяг №" + nomer + " створено",
                 "Інформація",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information); */
        }
    }

    public class KurtkaLab6 : OdyagLab6
    {
        private String name;
        private int size;
        public int Size { get { return size; } set { if (value >= 0) { size = value; return; } else { MessageBox.Show("Значення не може бути від'ємним"); return; } } }
        public String Name { get { return name; } set { if (value.Equals("")) { MessageBox.Show("Ім'я не може бути пусте!"); return; } else { name = value; } } }
        public KurtkaLab6(String name, String color, int size) : base()
        {
            base.Info();
            Name = name; this.color = color; Size = size; this.status = "Новa";
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public KurtkaLab6(String name, String color, int size, String status) : base()
        {
            base.Info();
            Name = name; this.color = color; Size = size; this.status = status;
            Random rnd = new Random(); int asd = rnd.Next(0, 2); if (asd == 0) isFreak = false; else isFreak = true;
        }
        public static bool operator ==(KurtkaLab6 kurtka1, KurtkaLab6 kurtka2)
        {
            return (kurtka1.Name == kurtka2.Name &&
                      kurtka1.color == kurtka2.color &&
                      kurtka1.Size == kurtka2.Size &&
                      kurtka1.status == kurtka2.status); 

            

        }
         public static bool operator !=(KurtkaLab6 kurtka1, KurtkaLab6 kurtka2)
        {
             return !(kurtka1 == kurtka2);
        } 
        public static KurtkaLab6 operator ++(KurtkaLab6 kurtka)
        {
            return new KurtkaLab6(kurtka.Name, kurtka.color, kurtka.Size + 1);
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

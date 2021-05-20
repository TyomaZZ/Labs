using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Labs
{//tyomashi
    public partial class lab2_Form : Form
    {
        Form father;

        public lab2_Form(Form patric)
        {
            InitializeComponent();
            father = patric;
        }

        private void lab2_exitButton_Click(object sender, EventArgs e) 
        {
            Close();
        }

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

        private void lab2_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }
    }
    
    public class Outerwear_Lab2  //Верхній одяг       /Варіант №7
    {
        String name, color, status;
        int size;
        bool isFreak;
        public Outerwear_Lab2()
        {
            name = "Футболка"; color = "Чорний"; status = "Новий"; size = 36;
            Random rnd = new Random(); if (rnd.Next(0, 2) == 0) isFreak = false; else isFreak = true;
        }
        public Outerwear_Lab2(String name, String color, int size)
        {
            this.name = name; this.color = color; this.size = size; status = "Новий";
            Random rnd = new Random(); if (rnd.Next(0, 10) < 5) { isFreak = false; } else isFreak = true;
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
}



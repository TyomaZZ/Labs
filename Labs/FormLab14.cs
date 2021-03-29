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

namespace Labs
{//tyomashi
    public partial class FormLab14 : FormForLab13
    {
        string pathSaveDefault = @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug";
        string pathSave =        @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug\Save";
        string pathSaveBase =    @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug\Save\Base\";
        int    keySave =         245;
        public FormLab14() : base()
        {InitializeComponent();}
        private void buttonSaveDefault_Click(object sender, EventArgs e)
        {
            StreamWriter fs = File.CreateText(pathSaveDefault + "default.txt");
            fs.Close();
            WriteFile();
        }
        private void WriteFile(string filename)
        {
            string[] masStr = new string[5];
            masStr[0] = "245";
            masStr[1] = CorrectS(FirstName.Text);
            masStr[2] = CorrectS(LastName.Text);
            masStr[3] = CorrectS(FatherName.Text);
            masStr[4] = BirthdayDay.Value.ToString();
            File.WriteAllLines(filename, masStr);
        }
        private void WriteFile()
        {
            WriteFile("default.txt");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;
            sfd.Title = "Оберіть файл для збереження данних";
            sfd.InitialDirectory = pathSave;
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                WriteFile(sfd.FileName);
            }
        }
        private void buttonReadDefault_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(pathSaveDefault + "default.txt");
            if (sr.ReadLine() == "245")
            {
                FirstName.Text = sr.ReadLine();
                LastName.Text = sr.ReadLine();
                FatherName.Text = sr.ReadLine();
                BirthdayDay.Value = DateTime.Parse(sr.ReadLine());
            }
            else
            {
                MessageBox.Show("Недійсний файл", "Помилка");
            }
            sr.Close();
        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.AddExtension = true;
            ofd.Title = "Оберіть файл для зчитування";
            ofd.InitialDirectory = pathSave;
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                StreamReader sr = File.OpenText(ofd.FileName);
                if (sr.ReadLine() == "245")
                {
                    FirstName.Text = sr.ReadLine();
                    LastName.Text = sr.ReadLine();
                    FatherName.Text = sr.ReadLine();
                    BirthdayDay.Value = DateTime.Parse(sr.ReadLine());
                }
                else
                {
                    MessageBox.Show("Недійсний файл", "Помилка");
                }
                sr.Close();
            }
        }
        private void buttonSaveInBase_Click(object sender, EventArgs e)
        {
            saveFile(CorrectS(LastName.Text) + CorrectS(FirstName.Text), pathSaveBase, false, false);
        }
        private void saveFile(string name, string patch, bool saveDefault, bool rewrite)
        {
            StreamWriter sw;
            int i = 2;
            if (!rewrite)
                while (File.Exists(patch + name + ".txt"))
                {
                    name = name + i;
                    i++;
                }   
            if (saveDefault)
                sw = new StreamWriter(patch + "default.txt");
            else
                sw = new StreamWriter(patch + name + ".txt");

            Saver(sw);
            sw.Close();
        }
        private void Saver(StreamWriter sws)
        {
            sws.WriteLine(keySave);
            sws.WriteLine(FirstName.Text);
            sws.WriteLine(LastName.Text);
            sws.WriteLine(FatherName.Text);
            sws.WriteLine(BirthdayDay.Value.ToString());
        }
    }
}

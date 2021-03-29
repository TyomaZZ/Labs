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
        string pathSaveDefault = @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug\";
        string pathSave = @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug\Save\";
        string pathSaveBase = @"C:\Users\kukha\source\repos\TyomaZZ\Labs\Labs\bin\Debug\Save\Base\";
        string filterE = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        string titleESave = "Оберіть папку для збереження данних у файл";
        string titleEOpen = "Оберіть файл для зчитування";
        int keySave = 245;
        string[] dataArr = new string[5];
        public FormLab14() : base()
        { InitializeComponent(); }
        private void buttonSaveDefault_Click(object sender, EventArgs e)
        { saveFile(CorrectS(LastName.Text) + CorrectS(FirstName.Text), pathSaveDefault, true, true, false); }
        private void buttonSaveInBase_Click(object sender, EventArgs e)
        { saveFile(CorrectS(LastName.Text) + CorrectS(FirstName.Text), pathSaveBase, false, false, false); }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Title = titleESave;
            sfd.Filter = filterE;
            sfd.FileName = CorrectS(LastName.Text) + CorrectS(FirstName.Text);
            sfd.InitialDirectory = pathSave;
            if (sfd.ShowDialog() != DialogResult.Cancel)
                saveFile(sfd.FileName, pathSaveDefault, false, false, true);
        }
        private void buttonReadDefault_Click(object sender, EventArgs e)
        { openFile("default.txt"); }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Title = titleEOpen;
            ofd.Filter = filterE;
            ofd.InitialDirectory = pathSave;
            if (ofd.ShowDialog() != DialogResult.Cancel)
                openFile(ofd.FileName);
        }
        private void saveFile(string name, string patch, bool saveDefault, bool rewrite, bool onlyName)
        {
            StreamWriter sw;
            if (onlyName)
            {
                sw = new StreamWriter(name);
                Saver(sw);
                sw.Close();
                return;
            }
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
        private void openFile(string name)
        {
            StreamReader sr;
            sr = new StreamReader(name);
            Writer(sr);
            if (Convert.ToInt32(dataArr[0]) == keySave)
            {
                FirstName.Text = dataArr[1];
                LastName.Text = dataArr[2];
                FatherName.Text = dataArr[3];
                BirthdayDay.Value = DateTime.Parse(dataArr[4]);
            }
            else
                MessageBox.Show("Недійсний файл", "Помилка");
            sr.Close();
        }
        private void Writer(StreamReader srs)
        {
            for (int i = 0; i < dataArr.Length; i++)
                dataArr[i] = srs.ReadLine();
        }
        protected override void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormLab14_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosedAction();
        }
        private void ClosedAction()
        {
            saveFile("temp.txt", pathSaveDefault, false, false, true);
            string[] arrCo = new string[5];
            StreamReader reader = new StreamReader("temp.txt");
                Writer(reader);
            reader.Close();
            arrCo[0] = dataArr[0];
            arrCo[1] = dataArr[1];
            arrCo[2] = dataArr[2];
            arrCo[3] = dataArr[3];
            arrCo[4] = dataArr[4];
            // зчитування
            StreamReader sr;
            sr = new StreamReader("load.txt");
                Writer(sr);
            sr.Close();
            if (!Equals(arrCo, dataArr)) 
                saveFile("load.txt", pathSaveDefault, false, true, true);
            File.Delete("temp.txt");
        }
        private void FormLab14_Load(object sender, EventArgs e)
        {
            openFile("load.txt");
        }
    }
}

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
        string pathDefault = "";
        string pathSave = @"Save\";
        string pathBase = @"Save\Base\";
        string filterE = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        string titleESave = "Оберіть папку для збереження данних у файл";
        string titleEOpen = "Оберіть файл для зчитування";
        int keySave = 245;
        string[] dataArr = new string[5];
        public FormLab14() : base()
        { 
            InitializeComponent();
        }
        private void buttonSaveDefault_Click(object sender, EventArgs e)
        { saveFile("default.txt", pathDefault, true); }
        private void buttonSaveInBase_Click(object sender, EventArgs e)
        { saveFile(Names(), pathBase, false); }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Title = titleESave;
            sfd.Filter = filterE;
            sfd.FileName = CorrectS(LastName.Text) + CorrectS(FirstName.Text);
            sfd.InitialDirectory = pathSave;
            if (sfd.ShowDialog() != DialogResult.Cancel)
                saveFile(sfd.FileName, pathDefault, true);
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
        private void saveFile(string name, string patch, bool rewrite)
        {
            StreamWriter sw;
            int i = 0;
            if (!rewrite)
            {
                while (File.Exists(patch + name + ".txt"))
                {
                    name = name.Replace("(" + Convert.ToString(i) + ")", "");
                    i++;
                    name = name + "(" + i + ")";
                }
                sw = new StreamWriter(patch + name + ".txt");
                Saver(sw);
                sw.Close();
                return;
            }   
            sw = new StreamWriter(patch + name);
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
            StreamWriter sw = new StreamWriter(name, true);
            sw.Close(); ;
            StreamReader sr;
            sr = new StreamReader(name);
            Writer(sr);
            if (Convert.ToInt32(dataArr[0]) == keySave)
            {
                FirstName.Text = dataArr[1];
                LastName.Text = dataArr[2];
                FatherName.Text = dataArr[3];
                try
                {
                    BirthdayDay.Value = DateTime.Parse(dataArr[4]);
                }
                catch
                {
                    BirthdayDay.Value = BirthdayDay.MinDate;
                }
                
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
            saveFile("load.txt", pathDefault, true);
        }
        private void FormLab14_Load(object sender, EventArgs e)
        {
            if (!File.Exists("default.txt"))
            {
                saveFile("default.txt", pathDefault, true);
            }
            if (File.Exists("load.txt"))
            {
                openFile("load.txt");
            }
        }
        protected override void TextBox_TextChanged(object sender, EventArgs e)
        {
            base.TextBox_TextChanged(sender, e);
            if (((TextBox)sender).BackColor == Color.Red)
            {
                buttonSave.Enabled = false;
                buttonSaveDefault.Enabled = false;
                buttonSaveInBase.Enabled = false;
            }
            else
            {
                buttonRead.Enabled = true;
                buttonSave.Enabled = true;
                buttonSaveDefault.Enabled = true;
                buttonReadDefault.Enabled = true;
                buttonSaveInBase.Enabled = true;
            }
        }
        private string Names()
        {
            return CorrectS(LastName.Text) + CorrectS(FirstName.Text) + CorrectS(FatherName.Text) + YearCount.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", pathBase);
        }
    }
}

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
    public partial class FormLab15 : Form
    {
        Form father;

        public FormLab15(Form patric)
        {
            InitializeComponent();
            father = patric;
        }

        private void повідомленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker();
            FormLab15Child1 ch = new FormLab15Child1(Properties.Resources.messText, Properties.Resources.messLabel, 
                Properties.Resources.allButton, Properties.Resources.messPhoto, 600, 600);
            ch.MdiParent = this;
            ch.Show();
        }
        private void Checker()
        {
            this.WindowState = FormWindowState.Maximized;
            if (this.HasChildren)
                foreach (Form child in this.MdiChildren)
                    child.Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker();
            FormLab15Child1 ch = new FormLab15Child1(Properties.Resources.aboutUsText, Properties.Resources.aboutUsLabel,
                Properties.Resources.allButton, Properties.Resources.aboutUsPhoto, 300, 300);
            ch.MdiParent = this;
            ch.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void розробникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker();
            FormLab15Child1 ch = new FormLab15Child1(Properties.Resources.PhotoGalleryText, Properties.Resources.PhotoGallery1Label,
                Properties.Resources.allButton, Properties.Resources.PhotoGallery1Photo);
            ch.MdiParent = this;
            ch.Show();
        }

        private void середовищеРозробкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker();
            FormLab15Child1 ch = new FormLab15Child1(Properties.Resources.PhotoGalleryText, Properties.Resources.PhotoGallery2Label,
                Properties.Resources.allButton, Properties.Resources.PhotoGallery2Photo);
            ch.MdiParent = this;
            ch.Show();
        }

        private void університетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker();
            FormLab15Child1 ch = new FormLab15Child1(Properties.Resources.PhotoGalleryText, Properties.Resources.PhotoGallery3Label,
                Properties.Resources.allButton, Properties.Resources.PhotoGallery3Photo);
            ch.MdiParent = this;
            ch.Show();
        }

        private void FormLab15_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyLib.Lib.FatherController(father);
        }
    }
}

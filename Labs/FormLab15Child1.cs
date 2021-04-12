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
    public partial class FormLab15Child1 : Form
    {
        public FormLab15Child1(string  name, string text, string buttonText, string pictureName)
        {
            InitializeComponent();
            this.Text = name;
            this.label1.Text = text;
            this.buttonClose.Text = buttonText;
            try
            {
                this.pictureBox1.Load(pictureName);
            }
            catch
            {
               System.Resources.ResourceManager rm = Properties.Resources.ResourceManager;
               this.pictureBox1.Image = (Image)rm.GetObject(pictureName);
            }
        }
        public FormLab15Child1(string name, string text, string buttonText, string pictureName, int sizeX, int sizeY) 
            : this(name, text, buttonText, pictureName)
        {
            Size = new Size(sizeY, sizeX);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        { Close(); }
    }
}

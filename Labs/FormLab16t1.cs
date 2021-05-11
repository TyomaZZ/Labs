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
    public partial class FormLab16t1 : Form
    {
        FormLab16 father;
        public FormLab16t1(FormLab16 parent)
        {
            InitializeComponent();
            father = parent;
        }
        public FormLab16t1()
        {
            InitializeComponent();
        }

        private void buttonCloseAction_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLab16t1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (father != null)
            {
                father.button1.Enabled = false;
                father.button2.Enabled = false;
                father.button3.Enabled = false;
            }
        }
    }
}

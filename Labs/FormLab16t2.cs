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
    public partial class FormLab16t2 : Form
    {
        FormLab16 father;
        public FormLab16t2(FormLab16 parent)
        {
            InitializeComponent();
            father = parent;
        }
        public FormLab16t2()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLab16t2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (father != null)
            {
                father.button4.Enabled = false;
                father.button5.Enabled = false;
                father.button6.Enabled = false;
            }
        }
    }
}

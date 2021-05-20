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
    public partial class FormLab16t3 : Form, InterfaceLab19
    {
        FormLab16 father;
        public FormLab16t3(FormLab16 parent)
        {
            InitializeComponent();
            father = parent;
        }

        public string GetFormType()
        {
            return "Калькулятор";
        }

        public FormLab16t3()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLab16t3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (father != null)
            {
                father.button7.Enabled = false;
                father.button8.Enabled = false;
                father.button9.Enabled = false;
            }
        }
    }
}

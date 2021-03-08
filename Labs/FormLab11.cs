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
    public partial class FormLab11 : Form
    {
        public FormLab11()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBoxNubersKey.Text += Release(sender).Text;
        }
        private Button Release(object element)
        {
            return (Button)element;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxNubersKey.Text = "";
        }
    }
}

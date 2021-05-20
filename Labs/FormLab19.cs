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
    public partial class FormLab19 : FormLab18
    {
        Form father;

        public FormLab19(Form patric) : base(patric)
        {
            InitializeComponent();
            father = patric;
        }
    }
}

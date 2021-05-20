using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public static class Lib
    {
        public static Button ReleaseButton(object element)
        { return (Button)element; }

        public static TextBox ReleaseTextBox(object element)
        { return (TextBox)element; }

        public static double Doubler(string converter)
        {
            return Convert.ToDouble(converter);
        }

        public static void FatherController(Form patric)
        {
            if (patric != null)
            {
                patric.WindowState = FormWindowState.Normal;
                patric.Enabled = true;
                patric.ShowInTaskbar = true;
            }
        }
    }
}

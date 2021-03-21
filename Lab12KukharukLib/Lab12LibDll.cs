using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public class Lab12LibDll
    {
        public Button ReleaseButton(object element)
        { return (Button)element; }
        public TextBox ReleaseTextBox(object element)
        { return (TextBox)element; }
    }
}

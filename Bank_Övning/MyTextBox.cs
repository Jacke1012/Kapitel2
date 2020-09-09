using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace Bank_Övning
{
    public class MyTextBox : TextBox
    {
        public MyTextBox()
        {
        }

        public string description { get; private set; }
    }
}

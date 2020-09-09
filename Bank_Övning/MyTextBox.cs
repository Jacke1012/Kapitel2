using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

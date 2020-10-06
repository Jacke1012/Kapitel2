using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Bank_Övning
{
    class MyButton : Button
    {
        [Category("Data"), Description("Description"),DefaultValue("")]
        public string description { get; set; }
        
    }
}

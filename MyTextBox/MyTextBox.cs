using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTextBox
{
    public partial class MyTextBox: UserControl
    {
        [Description("Item description"), Category("Data")]
        public string description
        {
            get { return description; }
            set { description = value; }
        }
        public MyTextBox()
        {
            InitializeComponent();
        }
    }
}

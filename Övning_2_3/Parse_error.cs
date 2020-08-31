using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2_3
{
    public partial class Parse_error : Form
    {

        public Parse_error()
        {
            InitializeComponent();
        }

        double output;

        public void Start(TextBox errorTbx)
        {
            tbxBefore.Text = errorTbx.Text;
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Parse_error_Load(object sender, EventArgs e)
        {
            BtnOk.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;
        }
    }
}

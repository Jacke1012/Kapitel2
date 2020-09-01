using System;
using System.Windows.Forms;

namespace Övning_2_3
{
    public partial class Parse_error : Form
    {

        public Parse_error()
        {
            InitializeComponent();
        }

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

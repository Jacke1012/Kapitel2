using System;
using System.Windows.Forms;

namespace Parser
{
    public partial class Parse_error : Form
    {

        public Parse_error()
        {
            InitializeComponent();
        }

        public void Start(string errorTbx)
        {
            tbxAfter.Clear();
            tbxBefore.Text = errorTbx;
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

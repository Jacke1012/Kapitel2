using System;
using System.Windows.Forms;

namespace Parser
{
    public partial class TryParse : Form
    {

        public static bool Double(TextBox textBoxToParse, out double output)
        {
            double tempResult = 0f;
            if (double.TryParse(textBoxToParse.Text, out tempResult))
            {
                output = tempResult;
                return true;
            }
            else
            {
                TryParse parse_error = new TryParse();
                do
                {
                    parse_error.Start(textBoxToParse.Text);
                    if (parse_error.ShowDialog() == DialogResult.Cancel)
                    {
                        output = -1.0;
                        return false;
                    }
                    textBoxToParse = parse_error.tbxAfter;
                } while (!double.TryParse(parse_error.tbxAfter.Text, out tempResult));
                output = tempResult;
                return true;
            }
        }

        public TryParse()
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

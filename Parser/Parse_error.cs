using System;
using System.Windows.Forms;

namespace Parser
{
    /// <summary>
    /// Try parsing
    /// </summary>
    public partial class TryParse : Form
    {
        /// <summary>
        /// TryParse
        /// </summary>
        /// <param name="textBoxToParse">Textbox</param>
        /// <param name="output">output</param>
        /// <param name="itemDescription">Optional description</param>
        /// <returns></returns>
        public static bool Double(TextBox textBoxToParse, out double output, string itemDescription = "")
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
                    parse_error.Start(textBoxToParse.Text, itemDescription);
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

        public void Start(string errorTbx, string description)
        {
            tbxAfter.Clear();
            tbxBefore.Text = errorTbx;
            lblDescription1.Text = description;
            lblDescription2.Text = description;
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

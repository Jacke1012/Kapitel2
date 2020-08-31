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
    public partial class Form2_3 : Form
    {
        public Form2_3()
        {
            InitializeComponent();
        }


        TextBox[] säljareTbx;
        TextBox[] konsultTbx;
        TextBox[] kontoristTbx;
        private void BtnRegaFörsäljning_Click_1(object sender, EventArgs e)
        {
            string namn = tbx_Säljare_Namn.Text;
            double provision;
            double försäljning;

            //FindAndRemoveDuplicate(namn);

            if (Parse_and_error(tbx_Säljare_Provision, out provision)
                && Parse_and_error(tbx_Säljare_Försäljning, out försäljning))
            {
                Anställd.anställdaLista.Add(new Säljare(namn, provision, försäljning));
                ClearTextBoxes(säljareTbx);
                RefreshRegisterDisplay();
            }
            else
            {
                ParseErrorMessageBox("");
            }

        }

        void RefreshRegisterDisplay()
        {
            lstBx_Register.Items.Clear();
            lstBx_LöneUtbetalningar.Items.Clear();
            foreach (Anställd anställd in Anställd.anställdaLista)
            {
                lstBx_Register.Items.Add(anställd);

                lstBx_LöneUtbetalningar.Items.Add(
                    string.Format("{0}: {1}", anställd.ToString(), anställd.BeräknaLön().ToString()));
            }
        }

        private void FindAndRemoveDuplicate(string namn)
        {
            if (Anställd.KollaOmRedanFinns(namn))
            {
                if (EditPersonMessageBox(namn))
                {
                    Anställd.anställdaLista.RemoveAt(Anställd.anställdaLista.FindIndex(temp => temp.namn == namn));
                }
            }
        }


        void ClearTextBoxes(TextBox[] textBoxes)
        {
            foreach (TextBox tbx in textBoxes)
            {
                tbx.Clear();
            }
        }

        void ParseErrorMessageBox(string inputThatWasWrong)
        {
            DialogResult result = MessageBox.Show(string.Format("The {0} field was inputed wrong", inputThatWasWrong)
                , "Parsing Error", MessageBoxButtons.OK);
        }



        bool EditPersonMessageBox(string person)
        {
            DialogResult result = MessageBox.Show(string.Format("Personen {0} finns redan. Vill du ändra informationen på person?", person)
                , "Person finns redan", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        bool Parse_and_error(TextBox textBoxToParse, out double output)
        {
            double tempResult = 0f;
            if (double.TryParse(textBoxToParse.Text, out tempResult))
            {
                output = tempResult;
                return true;
            }
            else
            {
                Parse_error parse_error = new Parse_error();
                do
                {
                    parse_error.Start(textBoxToParse);
                } while (parse_error.ShowDialog() == DialogResult.Cancel 
                || !double.TryParse(parse_error.tbxAfter.Text, out tempResult));
                output = tempResult;
                return true;
            }
        }

        private void Form2_3_Load(object sender, EventArgs e)
        {
            säljareTbx = new TextBox[] { tbx_Säljare_Provision, tbx_Säljare_Namn, tbx_Säljare_Försäljning };
            konsultTbx = new TextBox[] { tbx_Konsult_Arbetadtid, tbx_Konsult_Namn, tbx_Konsult_Timlön };
            kontoristTbx = new TextBox[] { tbx_Kontorist_Månadslön, tbx_Kontorist_Namn };
        }
    }
}

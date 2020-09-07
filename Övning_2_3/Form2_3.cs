using System;
using System.Windows.Forms;
using Parser;

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

            if (!FindAndRemoveDuplicate(namn))
            {
                return;
            }

            if (Parse_and_error(tbx_Säljare_Provision, out provision)
                && Parse_and_error(tbx_Säljare_Försäljning, out försäljning))
            {
                Anställd.anställdaLista.Add(new Säljare(namn, provision, försäljning));
                ClearTextBoxes(säljareTbx);
                RefreshRegisterDisplay();
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

        private bool FindAndRemoveDuplicate(string namn)
        {
            if (Anställd.KollaOmRedanFinns(namn))
            {
                if (EditPersonMessageBox(namn))
                {
                    Anställd.anställdaLista.RemoveAt(Anställd.anställdaLista.FindIndex(temp => temp.namn == namn));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }


        void ClearTextBoxes(TextBox[] textBoxes)
        {
            foreach (TextBox tbx in textBoxes)
            {
                tbx.Clear();
            }
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

        private void Form2_3_Load(object sender, EventArgs e)
        {
            säljareTbx = new TextBox[] { tbx_Säljare_Provision, tbx_Säljare_Namn, tbx_Säljare_Försäljning };
            konsultTbx = new TextBox[] { tbx_Konsult_Arbetadtid, tbx_Konsult_Namn, tbx_Konsult_Timlön };
            kontoristTbx = new TextBox[] { tbx_Kontorist_Månadslön, tbx_Kontorist_Namn };
        }

        private void BtnRegArbetspass_Click(object sender, EventArgs e)
        {
            string namn = tbx_Konsult_Namn.Text;
            double arbetadTid;
            double timLön;

            if (!FindAndRemoveDuplicate(namn))
            {
                return;
            }

            if (Parse_and_error(tbx_Konsult_Arbetadtid, out arbetadTid)
                && Parse_and_error(tbx_Konsult_Timlön, out timLön))
            {
                Anställd.anställdaLista.Add(new Konsult(namn, timLön, arbetadTid));
                ClearTextBoxes(konsultTbx);
                RefreshRegisterDisplay();
            }
        }

        private void BtnRegMånadsLön_Click(object sender, EventArgs e)
        {
            string namn = tbx_Kontorist_Namn.Text;
            double månadsLön;

            if (!FindAndRemoveDuplicate(namn))
            {
                return;
            }

            if (Parse_and_error(tbx_Kontorist_Månadslön, out månadsLön))
            {
                Anställd.anställdaLista.Add(new Kontorist(namn, månadsLön));
                ClearTextBoxes(kontoristTbx);
                RefreshRegisterDisplay();
            }
        }

        private void Btn_BeräknaLöner_Click(object sender, EventArgs e)
        {
            double totalLön = 0;
            foreach (Anställd anställd in Anställd.anställdaLista)
            {
                totalLön += anställd.BeräknaLön();
            }
            tbxLönekostnad.Text = totalLön.ToString();
        }
    }
}

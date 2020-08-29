using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox[] säljareTbx;
        TextBox[] konsultTbx;
        TextBox[] kontoristTbx;
        private void Form1_Load(object sender, EventArgs e)
        {
            säljareTbx = new TextBox[] { tbx_Säljare_Provision, tbx_Säljare_Namn, tbx_Säljare_Försäljning };
            konsultTbx = new TextBox[] { tbx_Konsult_Arbetadtid, tbx_Konsult_Namn, tbx_Konsult_Timlön };
            kontoristTbx = new TextBox[] { tbx_Kontorist_Månadslön, tbx_Kontorist_Namn};
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

        private void BtnRegaFörsäljning_Click(object sender, EventArgs e)
        {
            string namn = tbx_Säljare_Namn.Text;
            double provision;
            double försäljning;

            FindAndRemoveDuplicate(namn);

            if (double.TryParse(tbx_Säljare_Provision.Text, out provision)
                && double.TryParse(tbx_Säljare_Försäljning.Text, out försäljning))
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

        private void BtnRegArbetspass_Click(object sender, EventArgs e)
        {
            string namn = tbx_Konsult_Namn.Text;
            double timmLön;
            double arbetadTid;

            FindAndRemoveDuplicate(namn);

            if (double.TryParse(tbx_Konsult_Timlön.Text, out timmLön)
                    && double.TryParse(tbx_Konsult_Arbetadtid.Text, out arbetadTid))
            {
                Anställd.anställdaLista.Add(new Konsult(namn, timmLön, arbetadTid));
                ClearTextBoxes(konsultTbx);
                RefreshRegisterDisplay();
            }
        }

        private void BtnRegMånadsLön_Click(object sender, EventArgs e)
        {
            string namn = tbx_Kontorist_Namn.Text;
            double månadsLön;

            FindAndRemoveDuplicate(namn);

            if (double.TryParse(tbx_Kontorist_Månadslön.Text, out månadsLön))
            {
                Anställd.anställdaLista.Add(new Kontorist(namn, månadsLön));
                ClearTextBoxes(kontoristTbx);
                RefreshRegisterDisplay();
            }
        }

        private void Btn_BeräknaLöner_Click(object sender, EventArgs e)
        {
            double totalLön = 0;

            foreach (Anställd anstäld in Anställd.anställdaLista)
            {
                totalLön += anstäld.BeräknaLön();
            }

            tbxLönekostnad.Text = totalLön.ToString();
        }

        private void AddNew()
        {

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

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser;

namespace Bank_Övning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            lblKredit.Visible = false;
            tbxKredit.Visible = false;


            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(tbxRänesats, "I procent");
            toolTip1.SetToolTip(lblRänte, "I procent");
        }

        private void BtnRegestrera_Click(object sender, EventArgs e)
        {
            double ränte = 0;
            double kredit = 0;
            if (checkKredit.Checked)
            {
                if (TryParse.Double(tbxRänesats, out ränte)
                    && TryParse.Double(tbxKredit, out kredit))
                {
                    Bank.bankKonton.Add(new LåneKonto(tbxPersonNr.Text, ränte/100, kredit));
                }
            }
            else
            {
                if (TryParse.Double(tbxRänesats, out ränte))
                {
                    Bank.bankKonton.Add(new SparKonto(tbxPersonNr.Text, ränte));
                }
            }
            RefreshListBox();
            tbxKredit.Text = "";
            tbxRänesats.Text = "";
            tbxPersonNr.Text = "";
        }

        private void RefreshListBox()
        {
            lbxKonton.Items.Clear();
            lbxKonton.Items.AddRange(Bank.bankKonton.ToArray());
        }

        private void checkKredit_CheckedChanged(object sender, EventArgs e)
        {
            lblKredit.Visible = checkKredit.Checked;
            tbxKredit.Visible = checkKredit.Checked;
        }

        private void BtnInsättning_Click(object sender, EventArgs e)
        {
            if (lbxKonton.SelectedIndex == -1)
            {
                MessageBox.Show("Du har inga konton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double belopp;
            if (TryParse.Double(tbxBelopp, out belopp))
            {
                Bank.bankKonton[lbxKonton.SelectedIndex].Insättning(belopp);
            }

            tbxBelopp.Clear();
            RefreshListBox();
        }

        private void BtnUttag_Click(object sender, EventArgs e)
        {
            if (lbxKonton.SelectedIndex == -1)
            {
                MessageBox.Show("Du har inga konton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double belopp;
            if (TryParse.Double(tbxBelopp, out belopp))
            {
                Bank.bankKonton[lbxKonton.SelectedIndex].Uttag(belopp);
            }
            tbxBelopp.Clear();
            RefreshListBox();
        }

        private void BtnUpdatera_Click(object sender, EventArgs e)
        {
            Bank.UpdateraMedÅrsränta();
            RefreshListBox();
        }
    }
}

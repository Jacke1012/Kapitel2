using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Configuration;


//Sid 50 i boken
namespace Övning2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RefreshBibliotek()
        {
            tbxBibliotek.Clear();

            foreach (Media media in Media.bibliotek)
            {
                tbxBibliotek.AppendText(media.ToString() + "\r\n");
            }
        }


        private void BtnRegestreraBok_Click(object sender, EventArgs e)
        {
            Media.bibliotek.Add(new Bok(tbxBokTitel.Text, Parser.Parse<int>(tbxBokAntalSidor.Text)));
            tbxBokTitel.Clear();
            tbxBokAntalSidor.Clear();
            RefreshBibliotek();
        }

        private void BtnRegestreraLjud_Click(object sender, EventArgs e)
        {
            Media.bibliotek.Add(new LjudSpår(tbxLjudTitel.Text, Parser.Parse<float>(tbxLjudSpeltid.Text)));
            tbxLjudTitel.Clear();
            tbxLjudSpeltid.Clear();
            RefreshBibliotek();
        }

        private void BtnRegestreraFilm_Click(object sender, EventArgs e)
        {
            Media.bibliotek.Add(new Film(tbxFilmTitel.Text, Parser.Parse<float>(tbxFilmSpeltid.Text), tbxUpplösning.Text));
            tbxFilmSpeltid.Clear();
            tbxFilmTitel.Clear();
            tbxUpplösning.Clear();
            RefreshBibliotek();
        }

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Media.Save();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (Media.LoadData())
            {
                RefreshBibliotek();
            }
        }
    }
}

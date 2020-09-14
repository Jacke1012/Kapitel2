using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;

namespace Interface_Figurer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void lbxFigurer_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMått figur = (IMått)lbxFigurer.SelectedItem;
            BytMått(figur.Mått());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] temp = new object[3] { new Triangel(1, 1), new Cirkel(1), new Linje(1) };

            lbxFigurer.Items.AddRange(temp);

            måttTbx = new TextBox[2] { tbxBredd, tbxHöjd };
            måttLbl = new Label[2] { lblMått1, lblMått2 };
        }

        TextBox[] måttTbx = new TextBox[2];
        Label[] måttLbl = new Label[2];

        void BytMått(string[] mått)
        {
            for (int i = 0; i < måttTbx.Length; i++)
            {
                måttTbx[i].Visible = false;
                måttLbl[i].Visible = false;
            }

            for (int i = 0; i < mått.Length; i++)
            {
                måttLbl[i].Visible = true;
                måttTbx[i].Visible = true;
                måttLbl[i].Text= mått[i];
            }
        }

        private void BtnSkapa_Click(object sender, EventArgs e)
        {
            List<double> parametors = new List<double>();
            for (int i = 0; i < ((IMått)lbxFigurer.SelectedItem).Mått().Length; i++)
            {
                parametors.Add(double.Parse(måttTbx[i].Text));
            }

            Object[] objParam = new Object[parametors.Count];
            
            for (int i = 0; i < objParam.Length ; i++)
            {
                objParam[i] = parametors[i];
            }
            IArea instance = (IArea)Activator.CreateInstance(lbxFigurer.SelectedItem.GetType(), objParam);
            
            tbxDisplay.AppendText($"{instance}, Area: {instance.BeräknaArea()}");
        }
    }
}

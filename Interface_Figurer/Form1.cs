using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Figur instance = (Figur)Activator.CreateInstance(lbxFigurer.SelectedItem.GetType(), objParam);

            if (instance is IArea)
            {
                tbxDisplay.AppendText($"{instance}, Area: {((IArea)instance).BeräknaArea()}\r\n");
            }
            else
            {
                tbxDisplay.AppendText($"{instance}, Längd: {instance.höjd}\r\n");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Figurer
{
    class Cirkel : Figur, IArea, IMått
    {
        protected double radie;
        public Cirkel(double diameter) : base(diameter, diameter)
        {
            radie = höjd / 2;
        }
        

        public double BeräknaArea()
        {
            return radie * radie * Math.PI;
        }

        public string[] Mått()
        {
            return new string[1] { "Radie" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Figurer
{
    class Triangel : Figur, IArea, IMått
    {
        public Triangel(double bas, double höjd) : base(bas, höjd)
        {
            
        }

        public double BeräknaArea()
        {
            return höjd * bredd;
        }

        public string[] Mått()
        {
            return new string[2] { "Bas", "Höjd" };
        }
    }
}

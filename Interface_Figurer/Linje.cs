using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Figurer
{
    class Linje : Figur, IMått
    {
        public Linje(double höjd) : base(höjd, 0)
        {

        }

        public string[] Mått()
        {
            return new string[1] { "Längd" }; 
        }
    }
}

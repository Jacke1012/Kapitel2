using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Figurer
{
    public abstract class Figur
    {
        protected double höjd, bredd;

        public Figur(double höjd, double bredd)
        {
            this.höjd = höjd;
            this.bredd = bredd;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}

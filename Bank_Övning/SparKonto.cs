using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    class SparKonto : BankKonto
    {
        public SparKonto(string personNummer, double ränteSats) : base(personNummer, ränteSats)
        {

        }

        public override bool Uttag(double belopp)
        {
            if (behållning > belopp)
            {
                behållning -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double BeräknaRänta()
        {
            return behållning += behållning * ränteSats;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    class BankKonto
    {
        protected string personNummer;
        protected double behållning;
        protected double ränteSats;

        double Behållning()
        {
            return behållning;
        }
        
        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public bool Uttag(double belopp)
        {
            if (behållning - belopp > 0)
            {
                behållning -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double BeräknaRänta()
        {
            return behållning * ränteSats;
        }

        public override string ToString()
        {
            return ($"{GetType().Name} {personNummer}: {behållning}kr");
        }
    }
}

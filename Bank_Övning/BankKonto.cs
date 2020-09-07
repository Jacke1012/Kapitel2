using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    abstract class BankKonto
    {
        protected string personNummer;
        protected double behållning;
        protected double ränteSats;

        protected BankKonto(string personNummer, double ränteSats)
        {
            this.personNummer = personNummer;
            this.ränteSats = ränteSats;
        }

        double Behållning()
        {
            return behållning;
        }
        
        public void Insättning(double belopp)
        {
            behållning += belopp;
        }

        public abstract bool Uttag(double belopp);

        public abstract double BeräknaRänta();

        public override string ToString()
        {
            return ($"{GetType().Name} {personNummer}: {behållning}kr");
        }
    }
}

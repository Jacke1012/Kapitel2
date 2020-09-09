using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    [DataContract]
    [KnownType(typeof(LåneKonto))]
    [KnownType(typeof(SparKonto))]
    abstract class BankKonto
    {
        [DataMember]
        protected string personNummer;
        [DataMember]
        protected double behållning;
        [DataMember]
        protected double ränteSats;

        protected BankKonto(string personNummer, double ränteSats)
        {
            this.personNummer = personNummer;
            this.ränteSats = ränteSats / 100;
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

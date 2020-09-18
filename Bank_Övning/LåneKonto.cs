using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    [DataContract]
    class LåneKonto : BankKonto
    {


        [DataMember]
        double kreditGräns = 0;

        public LåneKonto(string personNr, double ränte, double kreditGräns) : base(personNr, ränte)
        {
            this.kreditGräns = kreditGräns;
        }

        public override double BeräknaRänta()
        {
            behållning += behållning * ränteSats; //plus minus
            return behållning;
        }

        public override bool Uttag(double belopp)
        {
            if (behållning - belopp > kreditGräns * -1)
            {
                behållning -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

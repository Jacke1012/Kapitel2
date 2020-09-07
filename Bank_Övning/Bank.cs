using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Övning
{
    static class Bank
    {
        public static List<BankKonto> bankKonton = new List<BankKonto>();

        public static void UpdateraMedÅrsränta()
        {
            foreach (BankKonto konto in bankKonton)
            {
                konto.BeräknaRänta();
            }
        }
    }
}

using System;
using System.Collections.Generic;

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

using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_2_3
{
    abstract class Anställd
    {
        public string namn = "";
        public Anställd(string n) { namn = n; }
        public abstract double BeräknaLön();

        public override string ToString()
        {
            return $"{namn} ({GetType().Name})";
        }


        public static List<Anställd> anställdaLista = new List<Anställd>();

        public static bool KollaOmRedanFinns(string namn)
        {
            if (Anställd.anställdaLista.Any(tempObj => tempObj.namn == namn))
            {
                Anställd tempAnställd = Anställd.anställdaLista.Find(tempObj => tempObj.namn == namn);

                Console.WriteLine(string.Format("{0} finns redan i registret", tempAnställd.ToString()));
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Säljare : Anställd
    {
        double försäljning = 0;
        double provision = 0;
        public Säljare(string n, double f, double p) : base(n)
        {
            försäljning = f; provision = p;
        }
        public override double BeräknaLön()
        {
            return försäljning * provision / 100;
        }
    }

    class Konsult : Anställd
    {
        double timLön;
        double arbetadeTimmar;

        public Konsult(string namn, double timLön, double arbetadeTimmar) : base(namn)
        {
            this.timLön = timLön;
            this.arbetadeTimmar = arbetadeTimmar;
        }

        public override double BeräknaLön()
        {
            return timLön * arbetadeTimmar;
        }
    }

    class Kontorist : Anställd
    {
        double månadsLön;

        public Kontorist(string namn , double månadsLön) : base(namn)
        {
            this.månadsLön = månadsLön;
        }

        public override double BeräknaLön()
        {
            return månadsLön;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2_2
{
    class Anställd
    {
        public static List<Anställd> anställdaLista = new List<Anställd>();


        public string namn { protected set; get; }

        public Anställd(string namn)
        {
            this.namn = namn;
        }

        public virtual double BeräknaLön()
        {
            return default;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", namn, GetType().Name); // Vet ej om den fungera med GetType osv
        }

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
        double provision;
        double försäljning;
        public Säljare(string namn, double provision, double försäljning) : base(namn)
        {
            this.provision = provision;
            this.försäljning = försäljning;
        }

        public override double BeräknaLön()
        {
            return försäljning * (provision /100.0);
        }
    }

    class Konsult : Anställd
    {
        double timmLön;
        double arbetadTid;

        public Konsult(string namn, double timmLön, double arbetadTid) : base(namn)
        {
            this.timmLön = timmLön;
            this.arbetadTid = arbetadTid;
        }

        public override double BeräknaLön()
        {
            return timmLön * arbetadTid;
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

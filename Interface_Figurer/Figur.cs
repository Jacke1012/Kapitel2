

namespace Interface_Figurer
{
    public abstract class Figur
    {
        public double höjd { get; protected set; }
        public double bredd { get; protected set; }

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

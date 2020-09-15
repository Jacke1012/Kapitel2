

namespace Interface_Figurer
{
    public abstract class Figur
    {
        protected double höjd, bredd;

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

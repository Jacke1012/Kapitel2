
namespace MinLista
{
    public class Samling<T>
    {
        protected int buffert;
        protected T[] lista;
        protected int längd;
        protected int antal;

        public Samling()
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expandera (int storlek)
        {
            if (storlek < 1)
            {
                return;
            }

            T[] temp = new T[längd + storlek];

            for (int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }
            lista = temp;
            längd += storlek;
        }

        protected void Reducera()
        {
            T[] temp = new T[antal];

            for (int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }

            lista = temp;
            längd = antal;

        }

        public void LäggTill(T e)
        {
            if (antal + 1 > längd)
            {
                Expandera(1 + buffert);
            }

            lista[antal++] = e;
        }

        public T TaBort(int index)
        {
            T temp = lista[index];

            for (int i = index; i < antal-i; i++)
            {
                lista[i] = lista[i + 1];
            }
            antal--;

            if (längd - antal > buffert)
            {
                Reducera();
            }
            return temp;
        }
    }
}
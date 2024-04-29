using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CConjunto : IColeccionable, IIterable
    {
        List<IComparable> elementos;

        public CConjunto()
        {
            elementos = new List<IComparable>();
        }

        public int cuantos()
        {
            return elementos.Count;
        }
        public IComparable minimo()
        {
            IComparable min = elementos.First();

            for (int i = 1; i <= elementos.Count - 1; i++)
            {
                if (elementos[i].sosMenor(min))
                {
                    min = elementos[i];
                }
            }
            return min;
        }
        public IComparable maximo()
        {
            IComparable max = elementos.First();

            for (int i = 1; i <= elementos.Count - 1; i++)
            {
                if (elementos[i].sosMayor(max))
                {
                    max = elementos[i];
                }
            }
            return max;
        }
        public void agregar(IComparable c)
        {
            if (! pertenece(c))
            {
                elementos.Add(c);
            }
        }
        public bool contiene(IComparable c)
        {
            return this.pertenece(c);
        }

        public List<IComparable> getElementos()
        {
            return elementos;
        }

        public bool pertenece(IComparable c)
        {
            return elementos.Contains(c);
        }

        public IIterador crearIterador()
        {
            return new CIteradorLista(elementos);
        }
    }
}

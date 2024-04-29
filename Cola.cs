using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class Cola : IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Cola() 
        {
            elementos = new List<IComparable>();
        }

        public void enqueue(IComparable e) 
        {
            elementos.Add(e);
        }

        public IComparable dequeue()
        {
            IComparable elemento = elementos.First();
            elementos.Remove(elemento);
            return elemento; 
        }

        public int cuantos()
        {
            return elementos.Count;
        }
        public IComparable minimo()
        {
            IComparable min = elementos.First();
            for (int i = 1; i <= elementos.Count -1; i++)
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
            enqueue(c);
        }
        public bool contiene(IComparable c)
        {    
            foreach (IComparable e in this.elementos)
            {
                if (e.sosIgual(c)) return true;
            }
            return false;
        }

        public List<IComparable> getElementos()
        {
            return elementos;
        }

        public IIterador crearIterador()
        {
            return new CIteradorLista(elementos);
        }
    }
}

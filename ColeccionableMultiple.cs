using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EJERCICIO 8
namespace Practica1Metodologias
{
    public class ColeccionableMultiple : IColeccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionableMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;   
            this.cola = cola;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable minimo()
        {
            IComparable minPila = pila.minimo();    
            IComparable minCola = cola.minimo();
            if (minPila.sosMenor(minCola)) return minPila;
            return minCola;
        }

        public IComparable maximo()
        {
            IComparable maxPila = pila.maximo();
            IComparable maxCola = cola.maximo();
            if (maxPila.sosMayor(maxCola)) return maxPila;
            return maxCola;
        }

        public void agregar(IComparable c) { }

        public bool contiene(IComparable c)
        {
            foreach(IComparable elementoPila in pila.getElementos())
            {
                if(elementoPila.sosIgual(c)) return true;
                else
                {
                    foreach(IComparable elementoCola in cola.getElementos())
                    {
                        if (elementoCola.sosIgual(c)) return true;
                    }
                }
            }
            return false;
        }

        public IColeccionable getPila()
        {
            return pila;
        }

        public IColeccionable getCola()
        {
            return cola;
        }
    }
}

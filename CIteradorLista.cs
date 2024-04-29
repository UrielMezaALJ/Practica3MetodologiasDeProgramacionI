using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    //Funciona para Pila, Cola y Conjunto ya que todas estas clases almacenan los datos en listas.
    public class CIteradorLista : IIterador
    {
        int indice;
        List<IComparable> lista;

        public CIteradorLista(List<IComparable> lista)
        {
            this.lista = lista;
        }

        public void primero()
        {
            indice = 0;
        }

        public void segundo()
        {
            indice++;
        }

        public bool fin()
        {
            return indice >= lista.Count - 1;   
        }

        public IComparable actual()
        {
            return lista[indice];
        }
    }
}

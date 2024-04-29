using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CIteradorDiccionario : IIterador
    {
        int indice;
        List<ClaveValor> lista; 

        public CIteradorDiccionario(List<ClaveValor> lista)
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
            ClaveValor valor = lista[indice];
            IComparable comparable = valor.getValor();
            return comparable;
        }

        
    }
}

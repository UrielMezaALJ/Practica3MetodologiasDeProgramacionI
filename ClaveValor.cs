using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class ClaveValor
    {
        Numero clave;
        IComparable valor;
        public ClaveValor(Numero clave, IComparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public Numero getClave() { return clave; }
        public IComparable getValor() {  return valor; }

        
    }

}

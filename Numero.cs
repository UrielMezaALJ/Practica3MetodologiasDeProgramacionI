using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return valor;
        }

        public void setValor(int v)
        {
            this.valor = v; 
        }

        public bool sosIgual(IComparable c)
        {
            return this.getValor() == ((Numero)c).getValor();
        }
        public bool sosMenor(IComparable c)
        {
            return this.getValor() < ((Numero)c).getValor();
        }
        public bool sosMayor(IComparable c)
        {
            return this.getValor() > ((Numero)c).getValor();
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}

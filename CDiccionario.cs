using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CDiccionario : IColeccionable, IIterable
    {
        List<ClaveValor> listaElementos;
        public CDiccionario(Numero num, IComparable con)
        {
            listaElementos = new List<ClaveValor>();
        }

        public void agregar(IComparable c)
        {
            int indice = listaElementos.Count;
            Numero clave = new Numero(indice);
            ClaveValor cv = new ClaveValor(clave, c);
            listaElementos.Add(cv);
        }

        public int cuantos()
        {
            return listaElementos.Count;
        }

        public IComparable maximo()
        {
            int indice = 1;
            IComparable max = listaElementos[0].getValor();
            
            while(listaElementos.Count - 1 <= indice)
            {
                if (listaElementos[indice].getValor().sosMayor(max))
                {
                    max = listaElementos[indice].getValor();
                }

                indice++;
            }return max;
        }

        public IComparable minimo()
        {
            int indice = 1;
            IComparable min = listaElementos[0].getValor();

            while (listaElementos.Count - 1 <= indice)
            {
                if (listaElementos[indice].getValor().sosMenor(min))
                {
                    min = listaElementos[indice].getValor();
                }

                indice++;
            }
            return min;
        }

        public bool contiene(IComparable c)
        {
            return true; //seguir desarrollando
        }

        public IIterador crearIterador()
        {
            return new CIteradorDiccionario(this.listaElementos);
        }

        public List<ClaveValor> getElementos()
        {
            return listaElementos;
        }

        public override string ToString()
        {
            string cadena = "";
            foreach(ClaveValor cv in this.getElementos())
            {
               cadena = cv.getValor().ToString();
            } return cadena;
        }
    }
}

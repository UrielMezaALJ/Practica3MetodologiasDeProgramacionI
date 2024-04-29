using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CGeneradorDeDatosAleatorios
    {
        public int numeroAleatorio(int max)
        {
            Random random = new Random();
            return random.Next(0, max);
        }

        public string stringAleatorio(int cant)
        {
            return new string('x', cant);
        }
    }
}

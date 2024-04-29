using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CLectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        public string stringPorTeclado()
        {
            string texto = Console.ReadLine();
            return texto;
        }
    }
}

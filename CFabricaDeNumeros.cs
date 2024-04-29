using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CFabricaDeNumeros : CAFabricaDeComparables
    {
        CGeneradorDeDatosAleatorios dato_aleatorio;
        public override IComparable crearAleatorio(int max)
        {
            dato_aleatorio = new CGeneradorDeDatosAleatorios();

            return new Numero(dato_aleatorio.numeroAleatorio(max));
        }

        public override IComparable crearPorTeclado(int opcion)
        {
            Console.WriteLine("Ingresa el valor del número: ");
            int valor = int.Parse(Console.ReadLine());
            return new Numero(valor);
        }
    }
}

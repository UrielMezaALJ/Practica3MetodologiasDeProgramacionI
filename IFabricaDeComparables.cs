using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    interface IFabricaDeComparables
    {
        IComparable crearAleatorio(int opcion);
        IComparable crearPorTeclado(int opcion);
    }
}

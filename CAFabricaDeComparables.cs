using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CAFabricaDeComparables : IFabricaDeComparables
    {
        public virtual IComparable crearAleatorio(int opcion)
        {
            IFabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1: fabrica = new CFabricaDeNumeros(); break;

                case 2: fabrica = new CFabricaDeAlumnos(); break;

                case 3: fabrica = new CFabricaDeProfesores(); break;
            }

            return fabrica.crearAleatorio(5);
        }

        public virtual IComparable crearPorTeclado(int opcion)
        {
            IFabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1: fabrica = new CFabricaDeNumeros(); break;

                case 2: fabrica = new CFabricaDeAlumnos(); break;

                case 3: fabrica = new CFabricaDeProfesores(); break;
            }

            return fabrica.crearPorTeclado(5);
        }
    }
}

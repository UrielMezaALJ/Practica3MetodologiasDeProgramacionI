using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    class CEstrategiaNombre : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre() == ((Alumno)a1).getNombre();
        }
        public bool sosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre().Length > ((Alumno)a1).getNombre().Length;
        }
        public bool sosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre().Length < ((Alumno)a1).getNombre().Length;
        }
    }
}

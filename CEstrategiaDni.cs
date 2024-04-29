using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    class CEstrategiaDni : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getDni() == ((Alumno)a1).getDni();
        }
        public bool sosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getDni() < ((Alumno)a1).getDni();
        }
        public bool sosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getDni() > ((Alumno)a1).getDni();
        }
    }
}

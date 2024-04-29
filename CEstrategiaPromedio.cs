using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    class CEstrategiaPromedio : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getPromedio() == ((Alumno)a1).getPromedio();
        }
        public bool sosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getPromedio() > ((Alumno)a1).getPromedio();
        }
        public bool sosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getPromedio() < ((Alumno)a1).getPromedio();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    class CEstrategiaLegajo : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getLegajo() == ((Alumno)a1).getLegajo();
        }
        public bool sosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getLegajo() < ((Alumno)a1).getLegajo();
        }
        public bool sosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getLegajo() > ((Alumno)a1).getLegajo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CEstrategiaAntiguedad : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable p1, IComparable p2)
        {
            return ((CProfesor)p1).getAntiguedad() == ((CProfesor)p1).getAntiguedad();
        }
        public bool sosMayor(IComparable p1, IComparable p2)
        {
            return ((CProfesor)p1).getAntiguedad() > ((CProfesor)p1).getAntiguedad();
        }
        public bool sosMenor(IComparable p1, IComparable p2)
        {
            return ((CProfesor)p1).getAntiguedad() < ((CProfesor)p1).getAntiguedad();
        }
    }
}

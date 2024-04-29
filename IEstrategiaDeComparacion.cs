using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public interface IEstrategiaDeComparacion
    {
        bool sosIgual(IComparable p1, IComparable p2);
        bool sosMayor(IComparable p1, IComparable p2);
        bool sosMenor(IComparable p1, IComparable p2);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public interface IObservador
    {
        void actualizar(IObservado o);
    }
}

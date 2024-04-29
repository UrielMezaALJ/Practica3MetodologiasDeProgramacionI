using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Metodologias
{
    public interface IObservado
    {
        void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
    }
}

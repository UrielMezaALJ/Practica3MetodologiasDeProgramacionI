using P3Metodologias;
using Practica1Metodologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CProfesor : Persona , IComparable , IObservado
    {
        int antiguedad;
        IEstrategiaDeComparacion estrategia;
        string accion;

        List<IObservador> observadores = new List<IObservador>();

        public CProfesor(int antiguedad, string nombre, int dni) : base (nombre, dni)
        {
            this.antiguedad = antiguedad;
            estrategia = new CEstrategiaAntiguedad();
        }

        public string getAccion()
        {
            return accion;
        }
        public void hablarALaClase()
        {
            
            
            Console.WriteLine("\nEL PROFESOR ESTÁ HABLANDO SOBRE ALGÚN TEMA");
            accion = "hablando";
            this.notificar();
        }

        public void escribirElPizarron()
        {
           
            Console.WriteLine("\nEL PROFESOR ESTÁ ESCRIBIENDO EN EL PIZARRÓN");
            accion = "escribiendo";
            this.notificar();
        }

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }
        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }
        public void notificar()
        {
            foreach(IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public override bool sosIgual(IComparable c)
        {
            return estrategia.sosIgual(this, (CProfesor)c);
        }
        public override bool sosMenor(IComparable c)
        {
            return estrategia.sosMenor(this, (CProfesor)c);
        }
        public override bool sosMayor(IComparable c)
        {
            return estrategia.sosMayor(this, (CProfesor)c);
        }

        public override string ToString()
        {
            return this.getNombre() + " | " + this.getDni() + " | " + getAntiguedad() + " | " + this.getEstrategia();
        }

        public string getEstrategia()
        {
            return estrategia.ToString();
        }
    }
}

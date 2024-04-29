using P3Metodologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class Alumno : Persona, IComparable, IObservador
    {
        int legajo;
        double promedio;
        IEstrategiaDeComparacion estrategia;
        
        public Alumno(int l, double p, string n, int d) : base(n, d)   
        {
            this.legajo = l;
            this.promedio = p;
            estrategia = new CEstrategiaLegajo();
        }

        public void actualizar(IObservado o)
        {
            if(((CProfesor)o).getAccion() == "hablando")
            {
                this.prestarAtencion(); //Acá podría referenciar a alguna variable y luego actuar dependiendo el valor de la misma.
            }

            if (((CProfesor)o).getAccion() == "escribiendo")
            {
                this.distraerse();
            }

           
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio() 
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable c)
        {
            return estrategia.sosIgual(this, (Alumno)c);
        }
        public override bool sosMenor(IComparable c)
        {
            return estrategia.sosMenor(this, (Alumno)c);
        }
        public override bool sosMayor(IComparable c)
        {
            return estrategia.sosMayor(this, (Alumno)c);
        }

        public override string ToString()
        {
            return this.getNombre() + " | " + this.getLegajo() + " | " + this.getDni() + " | " + this.getPromedio()  + " | " + this.getEstrategia();
        }

        public string getEstrategia()
        {
            return estrategia.ToString();
        }

        public void prestarAtencion()
        {
            Console.WriteLine("El alumno está prestando atención");
        }

        public void distraerse()
        {
            // Array de frases para distraerse
            string[] frases = 
            {
            "El alumno está mirando el celular",
            "El alumno está dibujando en el margen de la carpeta",
            "El alumno está tirando aviones de papel"
            };
            Random random = new Random();
            int indice = random.Next(0, frases.Length);
            Console.WriteLine(frases[indice]);
        }
    }
}

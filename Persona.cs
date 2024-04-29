using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class Persona : IComparable
    {
        private string nombre;
        private int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }
        //Hice los métodos vituales para poder sobreescribirlos en la clase Alumno.
        public virtual bool sosIgual(IComparable c)
        {
            return this.dni == ((Persona)c).getDni();
        }
        public virtual bool sosMenor(IComparable c)
        {
            return dni > ((Persona)c).getDni();
        }
        public virtual bool sosMayor(IComparable c)
        {
            return this.dni < ((Persona)c).getDni();
        }

        public override string ToString()
        {
            return this.nombre + " " + this.dni.ToString();
        }
    }
}

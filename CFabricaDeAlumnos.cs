using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public class CFabricaDeAlumnos : IFabricaDeComparables
    {
        public IComparable crearAleatorio(int opcion)
        {
            int legajo = new CGeneradorDeDatosAleatorios().numeroAleatorio(opcion);
            double promedio = new CGeneradorDeDatosAleatorios().numeroAleatorio(10);
            string nombre = new CGeneradorDeDatosAleatorios().stringAleatorio(5);
            int dni = new CGeneradorDeDatosAleatorios().numeroAleatorio(50000000);
            return new Alumno(legajo, promedio, nombre, dni);
        }

        public IComparable crearPorTeclado(int opcion)
        {
            Console.WriteLine("Legajo:");
            int legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Promedio:");
            double promedio = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("DNI:");
            int dni = int.Parse(Console.ReadLine());
            return new Alumno(legajo, promedio, nombre, dni);
        }
    }
}

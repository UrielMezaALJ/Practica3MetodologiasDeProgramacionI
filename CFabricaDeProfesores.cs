using Practica1Metodologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    //FALTA EL CAMPO DE ANTIGUEDAD
    public class CFabricaDeProfesores : IFabricaDeComparables
    {
        public IComparable crearAleatorio(int opcion)
        {
            int antiguedad = new CGeneradorDeDatosAleatorios().numeroAleatorio(opcion);
            string nombre = new CGeneradorDeDatosAleatorios().stringAleatorio(5);
            int dni = new CGeneradorDeDatosAleatorios().numeroAleatorio(30000000);
            return new CProfesor(antiguedad, nombre, dni);
        }

        public IComparable crearPorTeclado(int opcion)
        {
            Console.WriteLine("Antigüedad:");
            int antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("DNI:");
            int dni = int.Parse(Console.ReadLine());
            return new CProfesor(antiguedad, nombre, dni);
        }
    }
}

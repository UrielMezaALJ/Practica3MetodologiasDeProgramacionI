using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Practica1Metodologias
{
    //10: Tuve que agregar un getElementos de la lista en las clases Pila y Cola para poder usarlas en el método "contiene" de la clase ColeccionMultiple.

    //17: Funciona porque Alumno se compara igual que su clase padre Persona, es decir por DNI. No tiene que implementar la interface IComparable, porque ya es "hijo" de un comparable por lo que también es IComparable.

    //19: Considero que si se podría haber echo sin usar interfaces pero esto supondría de más tiempo y recursos. Además, ´no sería flexible en caso de querer comparar otro tipo de objetos.
    public class Program
    {
        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            Cola cola1 = new Cola();
            CConjunto conjunto1 = new CConjunto();
            CDiccionario diccionario1 = new CDiccionario(new Numero(2), new Alumno(23,321,"ds", 44430));
            diccionario1.agregar(new Alumno(13, 221, "ddss", 55430));


            //Console.WriteLine("1. LLENAR CON NÚMEROS");
            //Console.WriteLine("2. LLENAR CON ALUMNOS");
            //Console.WriteLine("3. LLENAR CON PROFESORES");
            //int opcion = int.Parse(Console.ReadLine());
            //llenar(pila1, opcion);

            //Console.WriteLine("\n1. BUSCAR NÚMEROS");
            //Console.WriteLine("2. BUSCAR ALUMNOS");
            //Console.WriteLine("3. BUSCAR PROFESORES");
            //int opcion2 = int.Parse(Console.ReadLine());
            //informar(pila1, opcion2);

            CProfesor p1 = new CProfesor(7, "Raul", 28000980);
            dictadoDeClases(p1);

            CFabricaDeAlumnos a = new CFabricaDeAlumnos();

            for (int i = 0; i < 20; i++)
            {
                p1.agregarObservador((Alumno)a.crearAleatorio(20));
            }

            dictadoDeClases(p1);

        }

        public static void dictadoDeClases(CProfesor p)
        {
            for(int i = 0; i < 5; i++)
            {           
                p.hablarALaClase();
 
                p.escribirElPizarron();
            }
        }

        //EJERCICIO 7 Practica2
        public static void imprimirElementos(IColeccionable c)
        {
            IIterador ite = ((IIterable)c).crearIterador();
            ite.primero();
            while(!ite.fin())
            {
                
                //IComparable actual = ite.actual();
                Console.WriteLine(ite.actual().ToString());
                ite.segundo();
            }
        }

        //EJERCICIO 9 Practica2

        public static void cambiarEstrategia(IColeccionable col, IEstrategiaDeComparacion est)
        {

            IIterable colIterable = (IIterable)col;
            IIterador colIterador = colIterable.crearIterador();
            while (!colIterador.fin())
            {
                ((Alumno)colIterador.actual()).setEstrategia(est);
                colIterador.segundo();
            }

        }


        public static void llenar(IColeccionable c, int opcion)
        {
            for(int i = 0; i < 20; i++)
            {
                IComparable com = new CAFabricaDeComparables().crearAleatorio(opcion);

                c.agregar(com);
            }
        }

        //EJERCICIO 5
        public static void llenar(IColeccionable c)
        {
            Random r = new Random();
        
            for (int i = 1; i<=20; i++)
            {
                c.agregar(new Numero(r.Next(1, 50)));
            }
        }

        //EJERCICIO 6

        
        public static void informar(IColeccionable c)
        {
            Console.WriteLine($"El coleccionable contiene {c.cuantos()} alumnos.");
            Console.WriteLine($"El elemento más grande es: {c.maximo()}");
            Console.WriteLine($"El elemento más chico es: {c.minimo()}");
            Console.WriteLine("1. Buscar Alumno (a).\n2. Buscar numero (n)");
            string opcion = Console.ReadLine();

            if(opcion == "a")
            {
                Console.WriteLine("legajo:");
                int legajo = int.Parse(Console.ReadLine());
                Alumno pBuscada = new Alumno(legajo, 0, "", 0);
                
                if (c.contiene(pBuscada))
                {
                    Console.WriteLine($"La persona de Legajo ({legajo}) está.");
                }

                else Console.WriteLine($"La persona de legajo ({legajo}) no está.");
            }

            else if (opcion == "n")
            {
                Console.WriteLine("Número:");    
                Numero buscado = new Numero(int.Parse(Console.ReadLine()));
                if (c.contiene(buscado))
                {
                    Console.WriteLine($"El elemento ({buscado.ToString()}) está en la colección.");
                }

                else Console.WriteLine($"El elemento ({buscado.ToString()}) no está en la colección.");
            }
            
        }

        public static void informar(IColeccionable c, int opcion)
        {
            Console.WriteLine($"El coleccionable contiene {c.cuantos()} elementos.");
            Console.WriteLine($"El elemento más grande es: {c.maximo()}");
            Console.WriteLine($"El elemento más chico es: {c.minimo()}");
            IComparable comparable = new CAFabricaDeComparables().crearPorTeclado(opcion);
            if (c.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
            

        }

        public static void llenarPersonas(IColeccionable c)
        {
            Random r = new Random();
            List<string> nombres = new List<string> { "Juan", "Ana", "Carlos", "Maria", "Pedro", "Lucia" };

            for(int i = 1; i<=7; i++)
            {
                Persona p = new Persona(nombres[r.Next(nombres.Count)], r.Next(40000000, 45000000));
                c.agregar(p);
            }
        }

        public static void llenarAlumnos(IColeccionable c)
        {
            Random r = new Random();
            List<string> nombres = new List<string> { "Pepe", "Azul", "Uriel", "Marta", "Juliana", "Lucia", "Nahuel", "Nicolas", "Matias", "Mara", "Sofia", "Marina", "Yanina", "Marcela", "Adrian", "Antonela", "Hector", "Lucas", "Santiago", "Alejandro" };

            for (int i = 1; i <= 20; i++)
            {
                IComparable a = new Alumno(r.Next(70000, 75000), r.NextDouble() * 10, nombres[r.Next(nombres.Count)], r.Next(40000000, 45000000));             
                c.agregar(a);
            }

        }
        
    }
}

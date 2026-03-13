using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Program
    {
        private static List<IPrestable> MaterialesPrestable = new List<IPrestable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA DIGITAL ===");

            InicializarMaterialesEjemplo();

            int opcion;

            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);

        }


        private static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ DE LA BIBLIOTECA ===");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar AudioLibro");
            Console.WriteLine("3. Agregar Revista");
            Console.WriteLine("4. Mostrar Todos los Materiales ");
            Console.WriteLine("5. Procesar Prestamo");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private static void InicializarMaterialesEjemplo() 
        {
            var libro1 = new Libro(siguienteId++, "El Quijote", "Miguel de Cervantes", 1605,
                                  TipoCategoria.CienciaFiccion, 863, "978-84-376-0494-7");

            var Revista1 = new Revista(siguienteId++, "National Geographic", "National Geographic Society", 2023,
                                    TipoCategoria.Historia, 120, "Vol. 150, No. 3");

            var audio1 = new AudioLibro(siguienteId++, "1984", "George Orwell", 1949,
                                      TipoCategoria.Historia, new TimeSpan(11, 30, 0), "Simon Prebble");

            MaterialesPrestable.Add(libro1);
            MaterialesPrestable.Add(Revista1);
            MaterialesPrestable.Add(audio1);
        }
    }
    
}

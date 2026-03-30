using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }

        public static void Ejecutar() 
        {
            Console.WriteLine("Bienvenido al Gestor de Cumpleaños");
            Console.WriteLine("Ingrese el nombre del amigo 1");
            string nombre1 = Console.ReadLine(); 
            Console.WriteLine("Ingrese su fecha de nacimiento 1");
            DateTime fechaNacimiento1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del amigo 2");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento 2");
            DateTime fechaNacimiento2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del amigo 3");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento 3");
            DateTime fechaNacimiento3 = DateTime.Parse(Console.ReadLine());

            DateTime
        }
    }
}

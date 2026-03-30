using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            String Contenido;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Bienvenido a tu Diario Personal");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-Ingrese su nombre");
            Nombre= Console.ReadLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-Ingrese el contenido de su diario");
            Contenido= Console.ReadLine();
            File.WriteAllText("Usuario.txt", Contenido);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    internal class Ejercicio_4
    {
        //Generador de Correos Corporativos: Pide al usuario su nombre y apellido.
        //El programa debe generar un correo con el formato nombre.apellido@empresa.com
        //(todo en minúsculas).
        public void Ejercicio4() 
        {
            String DireccionCorreo = "@empresa.com";
            String nombre;
            String apellido;

            Console.WriteLine("----------Registro de la empresa----------");
            Console.WriteLine();    
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("----------Bienvenido a la empresa----------");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine();
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine();
            Console.WriteLine($"Su correo corporativo es: {nombre}.{apellido}{DireccionCorreo}");


        }
    }
}

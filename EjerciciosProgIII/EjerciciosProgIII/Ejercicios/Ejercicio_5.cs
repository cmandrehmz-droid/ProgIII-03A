using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    //Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color actual del semáforo(Verde, Amarillo, Rojo)
    //. Si es verde, imprime "Sigue adelante";
    //si es amarillo, "Prepárate para frenar"; y si es rojo, "¡Detente!".
    internal class Ejercicio_5
    {
        public void Ejercicio5()
        {
            String colorSemaforo;
            Console.WriteLine("Bienvenido al Simulador de Semáforo Inteligente");
            Console.WriteLine();
            Console.WriteLine("Ingrese el color actual del semáforo (Verde, Amarillo, Rojo):");
            colorSemaforo = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (colorSemaforo == "verde")
            {
                Console.WriteLine("Sigue adelante");
            }
            else if (colorSemaforo == "amarillo")
            {
                Console.WriteLine("Prepárate para frenar");
            }
            else if (colorSemaforo == "rojo")
            {
                Console.WriteLine("¡Detente!");
            }
            else
            {
                Console.WriteLine("Color de semáforo no válido. Por favor, ingrese Verde, Amarillo o Rojo.");
            }
        }
    }
}

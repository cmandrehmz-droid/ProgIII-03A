using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace EjerciciosProgIII.Ejercicios
{
    internal class Ejercicio_6
    {
        //Sistema de Mascotas Virtuales: Crea una clase base Mascota con un nombre y un método HacerTruco().
        //Crea clases derivadas como Loro(que repita una frase) y Gato(que amase pan). 
        //Usa una lista para que el usuario elija qué mascota quiere ver actuar.

        public void Ejercicio6()
        {
            int Entrada;
            List<String> Mascotas = new List<String>();
            Mascotas.Add("Loro");
            Mascotas.Add("Gato");

            Console.WriteLine("Bienvenido al Sistema de Mascotas Virtuales");
            Console.WriteLine();
            Console.WriteLine("Elige una mascota para ver su truco:");
            Console.WriteLine();
            for (int i = 0; i < Mascotas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Mascotas[i]}");
            }
            Console.WriteLine();
            Entrada = int.Parse(Console.ReadLine());
            Console.Clear();
            if (Entrada == 1)
            {
                var loro = new Loro();
                loro.HacerTruco();
            }
            if (Entrada == 2) 
            {
                var gato = new Gato();
                gato.HacerTruco();
            }
        }
    }
}

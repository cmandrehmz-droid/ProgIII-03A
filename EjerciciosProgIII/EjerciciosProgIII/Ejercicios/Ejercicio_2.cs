using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    //Calculadora de Propina Solidaria: Pide el total de una cuenta en un restaurante.
    //Pregunta qué porcentaje de propina desea dejar(10%, 15% o 20%).
    //Si el total con propina supera los $100.000, \
    //muestra un mensaje agradeciendo su generosidad.
    internal class Ejercicio_2
    {
        public void Ejercicio2()
        {
            int totalCuenta;
            int Entrada;
            String Mensaje;
            int TOTAL = 0;

            Console.WriteLine("Bienvenido al Cajero");
            Console.WriteLine();
            Console.WriteLine("Ingrese el total de su cuenta");
            Console.WriteLine();
            totalCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Que porcentaje de propina desea dejar");
            Console.WriteLine("1.10%");
            Console.WriteLine();
            Console.WriteLine("2.15%");
            Console.WriteLine();
            Console.WriteLine("3.20%");
            Console.WriteLine();
            Entrada = int.Parse(Console.ReadLine());

            if (Entrada == 1)
            {
                TOTAL = totalCuenta + (totalCuenta * 10 / 100);
            }
            if (Entrada == 2)
            {
                TOTAL = totalCuenta + (totalCuenta * 15 / 100);
            }
            if (Entrada == 3)
            {
                TOTAL = totalCuenta + (totalCuenta * 20 / 100);
            }

            if (TOTAL > 100000)
            {
                Mensaje = "Gracias por su generosidad";
            }
            else
            {
                Mensaje = "Gracias por su visita";
            }

            Console.WriteLine("----------Recibo----------");
            Console.WriteLine();
            Console.WriteLine($"Total de la cuenta: {totalCuenta}");
            Console.WriteLine();
            Console.WriteLine($"Porcentaje de propina: {Entrada}");
            Console.WriteLine();
            Console.WriteLine($"Total a pagar: {TOTAL}");
            Console.WriteLine();
            Console.WriteLine(Mensaje);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    internal class Ejercicio_1
    {
        //Perfil de Usuario Gamer: Crea un programa que pida al usuario su Nickname,
        //nivel de experiencia (1-100) y si tiene suscripción Premium (booleano).
        //Al final, muestra un mensaje personalizado que le dé la bienvenida a su nivel correspondiente.
        public void Ejercicio1()
        {
            String nickname;
            String nivelExperiencia;
            Boolean suscripcionPremium;
            Console.WriteLine("----------Bienvenido al Inicio de sesion---------");
            Console.WriteLine();
            Console.WriteLine("Ingrese su Nickname:");
            Console.WriteLine();
            nickname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese su Nivel de experiencia, Recuerda que es (1-100):");
            Console.WriteLine();
            nivelExperiencia = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("¿Tiene suscripción Premium? (Si/No):");
            String Entrada = Console.ReadLine().ToLower();
            if (Entrada == "si")
            {
                suscripcionPremium = true;
                Entrada = "Premium";
            }
            else
            {
                suscripcionPremium = false;
                Entrada = "No premium";
            }

            Console.WriteLine("----------Bienvenido----------");
            Console.WriteLine();
            Console.WriteLine($"Nombre del jugador: {nickname}");
            Console.WriteLine();
            Console.WriteLine($"Nivel de experiencia: {nivelExperiencia}");
            Console.WriteLine();
            Console.WriteLine($"Usuario: {Entrada}");
            Console.WriteLine();
            Console.WriteLine("------------------------------");


        }
    }
}

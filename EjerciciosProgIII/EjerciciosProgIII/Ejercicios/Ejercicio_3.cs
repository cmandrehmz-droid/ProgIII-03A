using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    //Control de Aforo en Eventos: Una discoteca tiene un aforo máximo de 50 personas.
    //Crea un programa que pregunte cuántas personas quieren entrar.
    //Si hay cupo, dales la bienvenida; si no, indícales cuántas personas deben salir para que ellos puedan entrar.
    internal class Ejercicio_3
    {
        int NumeroPersonas; 
        int AforoMaximo = 50;
        
        public void Ejercicio3()
        {
            Console.WriteLine("Bienvenido a la discoteca");
            Console.WriteLine();
            Console.WriteLine("Cuantas personas quieren entrar? Recuerda que el espacio maximo solo esta para 50 personas");
            Console.WriteLine();
            NumeroPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (NumeroPersonas <= AforoMaximo)
            {
                Console.WriteLine("Bienvenidos a la discoteca");
            }
            else
            {
                int PersonasSalientes = NumeroPersonas - AforoMaximo;
                Console.WriteLine($"Lo sentimos, el aforo máximo es de {AforoMaximo} personas. Por favor, {PersonasSalientes} personas deben salir para que puedan entrar.");
            }
        }

    }
}

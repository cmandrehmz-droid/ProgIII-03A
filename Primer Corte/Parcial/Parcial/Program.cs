using Parcial.Enum;
using Parcial.Interface;
using Parcial.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string ruta = "Pacientes.csv";

            bool salir = true;

            while (salir)
            {
                
                Console.WriteLine("----------Bienvenido a Veterinaria Pets----------");
                Console.WriteLine("Ingrese alguna de las opciones siguientes");
                Console.WriteLine();
                Console.WriteLine("1.........Crear");
                Console.WriteLine("2.........Listar");
                Console.WriteLine("3.........Modificar");
                Console.WriteLine("4.........Eliminar");
                Console.WriteLine("0.........Salir");
                int Opcion1 = int.Parse(Console.ReadLine());
                switch (Opcion1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre");
                        string nombre = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese la edad");
                        int edad= int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Ingrese el id");
                        int id = int.Parse(Console.ReadLine());
                        Especie especie1 = Consultar();
                        Console.Clear();
                        Paciente paciente = new Paciente(id, nombre, edad, especie1);
                        File.AppendAllText(ruta, paciente.ToCSV()+Environment.NewLine);
                        Console.WriteLine("[SUCESS] guardado en Pacientes.csv");
                        break;
                    case 2:
                        string[] lineas = File.ReadAllLines(ruta);
                        Console.WriteLine("Id/Nombre/Edad/Especie");
                        foreach (string line in lineas)
                        {
                            Console.WriteLine(line);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el id el cual desea modificar");
                        

                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar el programa");
                        break;
                    case -1:
                        Console.WriteLine("Dato Ingresado No valido");
                        break;
                }
            }
        }
        public static Especie Consultar()
        {
            Console.WriteLine("Ingrese la Especie de su mascota");
            Console.WriteLine("1-Perro");
            Console.WriteLine("2-Gato");
            Console.WriteLine("3-Ave");
            int Opcion2 = int.Parse(Console.ReadLine());

            switch (Opcion2) 
            {
                case 1: Console.Clear();
                    Console.WriteLine("Tipo de espcie Ingresado: Perro");
                    return Especie.Perro;
                    break;
                case 2: Console.Clear();
                    Console.WriteLine("Tipo de espcie Ingresado: Gato");
                    return Especie.Gato;
                    break;
                case 3: Console.Clear();
                    Console.WriteLine("Tipo de espcie Ingresado: Ave");
                    return Especie.Ave;
                    break;
                default: Console.WriteLine("Esa opcion no corresponde a ninguna especie del menu");
                    return Especie.Desconocido;
                    break;
            }
        }
        

    }
}

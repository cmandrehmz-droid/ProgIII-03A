using Parcial.Enum;
using Parcial.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Modelos
{
    internal class Paciente
    {
        int Id { get; set; }
        string Nombre { get; set; }
        int Edad {  get; set; }

        Especie Especie { get; set; }
        public string ToCSV() => $"{Id};{Nombre};{Edad};{Especie}";

        

        public Paciente(int id, string nombre, int edad, Especie especie)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }
    }
}

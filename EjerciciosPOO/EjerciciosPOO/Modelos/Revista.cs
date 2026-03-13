using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Revista: MaterialBiblioteca, IPrestable
    {
        public String Periodicidad { get; set; }
        public int NumeroEdicion { get; set; }

        public Revista(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                       int numeroEdicion, string periodicidad)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Número de Edición: {NumeroEdicion}");
            Console.WriteLine("Tipo: Revista");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("=== COMPROBANTE DE PRÉSTAMO - REVISTA ===");
            Console.WriteLine($"Revista: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
            Console.WriteLine("=========================================");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.30m;
        }
    }
}

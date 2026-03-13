using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class AudioLibro: MaterialBiblioteca, IPrestable
    {
        public String Narrador { get; set; }
        public TimeSpan Duracion { get; set; }

        public AudioLibro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                          TimeSpan duracion, string narrador)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Duración: {Duracion}");
            Console.WriteLine("Tipo: Audiolibro");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(14);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("=== COMPROBANTE DE PRÉSTAMO - AUDIOLIBRO ===");
            Console.WriteLine($"AudioLibro: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Duración: {Duracion.Hours:D2}:{Duracion.Minutes:D2}:{Duracion.Seconds:D2}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
            Console.WriteLine("===========================================");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.75m;
        }

    }
}

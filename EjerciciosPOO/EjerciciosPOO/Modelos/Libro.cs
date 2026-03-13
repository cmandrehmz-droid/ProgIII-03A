using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Libro: MaterialBiblioteca, IPrestable
    {
        public String ISBN { get; set; }
        public String NumeroPaginas { get; set; }

        public Libro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria,
                     int numeroPaginas, string isbn)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroPaginas = NumeroPaginas;
            ISBN = isbn;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            Console.WriteLine("Tipo: Libro");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(14); 
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Comprobante de Préstamo:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion().ToShortDateString()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.50m;
        }
    }
}

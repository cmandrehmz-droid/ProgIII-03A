using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal abstract class MaterialBiblioteca
    {
        public string autor { get; set; }
        public int id { get; set; }
        public int AñodePublicacion { get; set; }
        public TipoCategoria Categoria { get; set; }
        public String titulo { get; set; }

        protected MaterialBiblioteca(int id, string titulo, string autor, int AñoPublicacion, TipoCategoria Categoria)
        {
            id = id;
            titulo = titulo;
            autor = autor;
            AñoPublicacion = AñoPublicacion;
            Categoria = Categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Año de Publicación: {AñodePublicacion}");
            Console.WriteLine($"Categoría: {Categoria}");
        }
    }
}

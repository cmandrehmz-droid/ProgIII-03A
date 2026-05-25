using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Individual_MZ.Formularios
{
    internal class Producto
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public int Precio { get; set; }

        public Producto(int id, String nombre, int precio)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
}

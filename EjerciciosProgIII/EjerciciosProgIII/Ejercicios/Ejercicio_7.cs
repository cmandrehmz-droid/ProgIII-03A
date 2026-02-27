using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    internal class Ejercicio_7
    {
        //Gestión de Inventario de Tienda: Define una clase Producto con nombre,
        //precio y stock.Crea un método que permita "vender" el producto,
        //restando del stock y mostrando el total de la venta.
        //Si no hay stock, debe avisar al usuario.

        public void Ejercicio7() 
        {
            var producto = new Producto();
            producto.VenderProducto();
        }
    }
}

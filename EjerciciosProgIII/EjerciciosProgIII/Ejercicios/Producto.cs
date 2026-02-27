using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgIII.Ejercicios
{
    internal class Producto
    {
        String nombre;
        double precio;
        int stock;
        int CantidadVendida;
        int StockDisponible;

        public void VenderProducto() {             
            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto:");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el stock disponible del producto:");
            stock = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Cuanto quieres vender del producto");
            CantidadVendida = int.Parse(Console.ReadLine());
            Console.Clear();
            StockDisponible = stock - CantidadVendida;
            if (StockDisponible == 0)
            {
                Console.WriteLine("Inventario de Tienda");
                Console.WriteLine();
                Console.WriteLine($"Producto: {nombre}");
                Console.WriteLine();
                Console.WriteLine($"Precio: {precio}");
                Console.WriteLine();
                Console.WriteLine($"Cantidad Vendida: {CantidadVendida}");
                Console.WriteLine();
                Console.WriteLine($"Total de la venta: {CantidadVendida * precio}");
                Console.WriteLine();
                Console.WriteLine("No hay stock disponible");
            }
            else 
            {
                Console.WriteLine("Inventario de Tienda");
                Console.WriteLine();
                Console.WriteLine($"Producto: {nombre}");
                Console.WriteLine();
                Console.WriteLine($"Precio: {precio}");
                Console.WriteLine();
                Console.WriteLine($"Stock Disponible: {StockDisponible}");
                Console.WriteLine();
                Console.WriteLine($"Cantidad Vendida: {CantidadVendida}");
                Console.WriteLine();
                Console.WriteLine($"Total de la venta: {CantidadVendida * precio}");
            }
        }
    }
}

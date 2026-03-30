using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    internal class Camion : Vehiculo, IVendible
    {
        decimal CapacidadCarga { get; set; }
        int NumeroEjes { get; set; }

        public Camion(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado, decimal capacidadcarga, int numeroejes) : base(id, marca, modelo, year, preciobase, combustible, estado)
        {
            this.CapacidadCarga = capacidadcarga;
            this.NumeroEjes = numeroejes;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal PrecioFinal = PrecioBase;
            return PrecioFinal + (CapacidadCarga * 500);
        }

        public void GenerarFacturaVenta()
        {
            MostrarInformacion();

            Console.WriteLine($"Capacidad de carga: {CapacidadCarga}");
            Console.WriteLine($"Numero de ejes: {NumeroEjes}");
            Console.WriteLine($"Precio final {CalcularPrecioFinal()}");
            Console.WriteLine($"Comision del vendedor {CalcularComisionVendedor()}");

        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
        }
    }
}

using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    internal class Auto:Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado, int numeropuertas, bool tieneaireacondicionado) : base(id, marca, modelo, year, preciobase, combustible, estado)
        {
            this.NumeroPuertas = numeropuertas;
            this.TieneAireAcondicionado = tieneaireacondicionado;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal PrecioFinal = PrecioBase;
            if (TieneAireAcondicionado)
            {
                PrecioFinal += 2000;
            }
            return PrecioFinal;

        }

        public void GenerarFacturaVenta()
        {

            MostrarInformacion();

            if (TieneAireAcondicionado)
            {
                Console.WriteLine("El auto tiene incluido aire acondicionado");
            }
            Console.WriteLine($"Numero de puertas {NumeroPuertas}");

            Console.WriteLine($"Precio Final {CalcularPrecioFinal()}");

            Console.WriteLine($"Comision del vendedor {CalcularComisionVendedor()}");
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Modelos
{
    internal class Amigo
    {
        String Nombre { get; set; }
        DateTime FechaNacimiento { get; set; }

        public Amigo(string Nombre, DateTime FechaNacimiento) 
        {
            Nombre = Nombre;
            FechaNacimiento = FechaNacimiento;
        }

        

    }

    
}

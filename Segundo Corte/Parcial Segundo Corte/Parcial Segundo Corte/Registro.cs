using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Segundo_Corte
{
    internal class Registro
    {
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ndocumento { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        

        public Registro(int iD, string nombre, string apellido, int ndocumento,  string cargo, int salario)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            Ndocumento = ndocumento;
            Cargo = cargo;
            Salario = salario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
  class Ingeniero : Trabajador
  {  
        public Ingeniero(string clave, string nombre, int salario, string puesto, Image foto)
            : base(clave, nombre, salario, foto)
        {
            Puesto = "Ingeniero";
        }
        public override string mostrarDatos()
        {
            return "Ingeniero";
        }
  }
}

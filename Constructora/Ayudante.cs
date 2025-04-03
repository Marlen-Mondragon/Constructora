using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
    class Ayudante : Trabajador
    {
        public Ayudante(string clave, string nombre, int salario, string puesto, Image foto)
            : base(clave, nombre, salario, foto)
        {
            Puesto = "Ayudante";
        }      
        public override string mostrarDatos()
        {
            return "ayudante";
        }
    }
}

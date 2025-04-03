using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
    class MaestroObra : Trabajador
    {
        public MaestroObra(string clave, string nombre, int salario, string puesto, Image foto)
            : base(clave, nombre, salario, foto)
        {
            Puesto = "Maestro de Obra";
        }
        public override string mostrarDatos()
        {
            return "maestro de obra";

        }

    }
}

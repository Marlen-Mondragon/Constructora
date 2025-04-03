using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
    internal class Prestaciones
    {
        private string clavePrestacion;

        public string ClavePrestacion { get => clavePrestacion; set => clavePrestacion = value; }

        public virtual string agregarPrestacion() 
        {
            return "Prestaciones";
         }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
   class Trabajador
    {
        private string clave;
        private string nombre;
        private string puesto;
        private Prestaciones prestaciones;
        private int salario;
        private Image foto;
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int Salario { get => salario; set => salario = value; }
        public Image Foto { get => foto; set => foto = value; }
        internal Prestaciones Prestaciones { get => prestaciones; set => prestaciones = value; }

        public Trabajador(string clave, string nombre, int salario, Image foto)
        {
            Clave = clave;
            Nombre = nombre;
            Salario = salario;
            Foto = foto;
        }
        public virtual string mostrarDatos()
        {
            return "trabajador";
        }
    }
}

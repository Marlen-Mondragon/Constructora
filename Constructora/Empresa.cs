using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
    class Empresa
    {
        private string nombreEmpresa;
        private Trabajador Trabajador;
        private ArrayList Trabajadores = new ArrayList();

        public void agregaTrabajador(Trabajador trabajador)
        {
            Trabajadores.Add(trabajador);
        }
        public ArrayList mostarTodos()
        {
            ArrayList lista = new ArrayList();
            foreach (Trabajador trabajador in Trabajadores)
            {
                lista.Add(trabajador.mostrarDatos());
            }
            return lista;
        }
    }
}

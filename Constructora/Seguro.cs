﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructora
{
    internal class Seguro : Prestaciones
    {
        public override string agregarPrestacion()
        {
            return "Seguro";
        }
    }
}

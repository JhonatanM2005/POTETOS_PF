﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Models
{
    public class Mesa
    {
        public int IdMesa { get; set; }
        public int NumeroMesa { get; set; }
        public string Estado { get; set; } // "Libre", "Ocupada", "Atendida"
    }
}

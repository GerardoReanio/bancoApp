﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApp.Models
{
    public class BancoModel
    {
        public int IdBanco { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; }

    }
}

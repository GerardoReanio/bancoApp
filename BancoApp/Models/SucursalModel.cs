using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApp.Models
{
    public class SucursalModel
    {
        public int IdSucursal { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [ForeignKey("BancoModel")]
        public int IdBanco { get; set; }

        public virtual BancoModel Banco { get; set; }

    }
       
}

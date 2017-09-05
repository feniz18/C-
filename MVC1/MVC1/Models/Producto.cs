using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal precio{ get; set; }
        public DateTime ultimaCompra { get; set; }
        public float stock { get; set; }

    }
}
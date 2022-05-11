using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepasoParcial2
{
    public class Electrónico : Producto
    {
        public int voltage { get; set; }
        public DateTime WarrantyTime { get; set; } 
    }
}
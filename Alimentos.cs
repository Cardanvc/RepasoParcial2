using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepasoParcial2 
{
    public class Alimento : Producto
    {
        public string UnitExtent { get; set; }
        public DateTime DueDate { get; set; }
    }
}
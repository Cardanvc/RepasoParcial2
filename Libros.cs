using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepasoParcial2
{
    public class Libro : Producto 
    {
        public string Editorial { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
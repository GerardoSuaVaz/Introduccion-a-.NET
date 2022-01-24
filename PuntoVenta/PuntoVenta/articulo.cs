using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class articulo
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public tipoArticulo tipo { get; set; }
    }
}

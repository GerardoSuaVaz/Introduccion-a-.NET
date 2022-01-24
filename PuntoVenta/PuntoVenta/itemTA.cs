using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class itemTA : itemBase
    {
        public string telefono { get; set; }
        public string compañia { get; set; }
        public decimal comision { get; set; }
        public override decimal total()
        {
            return base.subTotal() + this.comision;
        }
        public override void imprimir()
        {
            Console.WriteLine($"{id} {nombre} {precio}{cantidad}{subTotal()}");
            Console.WriteLine($"Telefono: {telefono}  Compañia: {compañia} Comision: {comision} Total:  {total()}");          
        }
    }
}

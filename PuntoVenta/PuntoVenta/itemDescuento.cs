using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public  class itemDescuento : itemBase
    {
        public decimal descuento { get; set; }
        public decimal impDescuento
        {
            get
            {
                return (precio * cantidad )* descuento / 100;
            }
        }
        public override decimal total()
        {
            return base.subTotal() - this.impDescuento;

        }
        public override void imprimir()
        {
            Console.WriteLine($"{id} {nombre} {precio} {cantidad}, {subTotal()}");
            Console.WriteLine($"Descuento : {descuento} Importe: {impDescuento} Total: {total()} ");
        }
    }
}

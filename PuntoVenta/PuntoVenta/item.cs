using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class item : itemBase
    {
        public override void imprimir()
        {
            Console.WriteLine($"{id} {nombre} {precio} {cantidad}, {subTotal()}");
            Console.WriteLine($"Total: {total()} ");
        }
    }
}

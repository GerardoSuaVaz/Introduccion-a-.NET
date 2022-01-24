using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ventas inicio = new ventas();
            inicio.iniciar();
            inicio.Ventas();    
            inicio.corteCaja(); 
        }
    }
}

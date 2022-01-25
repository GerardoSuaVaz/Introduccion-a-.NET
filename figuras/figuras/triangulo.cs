using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class triangulo : IFigura
    {
        public decimal lado { get; set; }
        public decimal altura { get; set; }

        public decimal area()
        {
            return lado * altura / 2;
        }

        public decimal perimetro()
        {
            return lado * 3;
        }
    }
}

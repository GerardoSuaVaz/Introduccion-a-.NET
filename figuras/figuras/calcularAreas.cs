using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{

    internal class calcularAreas
    {
        public void main()
        { 
         IFigura[] figuras = { new cuadrado { lado = 5 }, new triangulo { lado = 5 , altura = 5 } };
         foreach(var figura in figuras)
            {
                Console.WriteLine($"Figura:  {figuras.ToString()}," +
                    $"Area: {figura.area()}," +  
                    $"Perimetro: {figura.perimetro()}");
            }
        }
    }
     
}


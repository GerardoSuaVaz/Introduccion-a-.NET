using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    
    public class NEstado
    {
        DEstado destado = new DEstado();
        public List<Estado> Consultar()
        {
            return destado.Consultar();
        }
    }
}

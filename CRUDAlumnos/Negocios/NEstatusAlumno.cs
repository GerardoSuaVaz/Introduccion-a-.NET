using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class NEstatusAlumno
    {
        DEstatusAlumno destalum = new DEstatusAlumno();
        public List<EstatusAlumno> Consultar()
        {
            return destalum.Consultar();
        }

    }
}

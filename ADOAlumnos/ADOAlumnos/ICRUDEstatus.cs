using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOAlumnos
{
    internal interface ICRUDEstatus
    {
        List<estatus> Consultar();
        estatus Consultar(int id);
        int Agregar(estatus estatus);
        void Actualizar(estatus estatus);
        void Eliminar(int id);


    }
}

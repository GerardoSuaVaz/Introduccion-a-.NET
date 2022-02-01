using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{

    public class NAlumno
    {
        DAlumno dalumno = new DAlumno();
       
        public List<Alumno> Consultar()
        {
            return dalumno.Consultar();
        }
        public Alumno Consultar(int Id)
        {
            return dalumno.Consultar(Id);
        }
        public void Agregar(Alumno Alum)
        {
            dalumno.Agregar(Alum);
        }
        public void Actualizacion(Alumno Alum)
        {
             dalumno.Actualizacion(Alum);
        }
        public void Eliminar(int id)
        {
            dalumno.Eliminar(id);
        }
    }
}


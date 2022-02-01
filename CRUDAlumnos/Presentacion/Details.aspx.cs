using Datos;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Presentacion
{
    public partial class Details : System.Web.UI.Page
    {
        DAlumno dalumno = new DAlumno();
        NAlumno nalumno = new NAlumno();
        NEstado NEstado = new NEstado();
        NEstatusAlumno NEstatus = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Alumno Alumno = nalumno.Consultar(id);
                List<Alumno> alumnos = nalumno.Consultar();
                List<Estado> estados = new List<Estado>();
                List<EstatusAlumno> estatus = new List<EstatusAlumno>();
                estados = NEstado.Consultar();
                estatus = NEstatus.Consultar();
                var elementos = from alum in alumnos
                                join estate in estados on alum.idEstadoOrigen equals estate.idEstadoOrigen
                                join status in estatus on alum.idEstatus equals status.idEstatus
                                where alum.idAlumno == id
                                select new { nomestado = estate.Nombre, nomstatus = status.Nombre };
                foreach (var el in elementos)
                {
                    lblNombre.Text = Alumno.nombre.ToString();
                    lblPApellido.Text = Alumno.primerApellido.ToString();
                    lblSApellido.Text = Alumno.segundoApellido.ToString();
                    lblFNacimiento.Text = Convert.ToDateTime(Alumno.fechaNacimiento).ToString();
                    lblCurp.Text = Alumno.curp.ToString();
                    lblCorreo.Text = Alumno.correo.ToString();
                    lblTelefono.Text = Alumno.telefono.ToString();
                    lblEstado.Text = el.nomestado.ToString();
                    lblEstatus.Text = el.nomstatus.ToString();
                }             
             }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
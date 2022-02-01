using Datos;
using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Create : System.Web.UI.Page
    {
        DAlumno dalumno = new DAlumno();
        NAlumno nalumno = new NAlumno();
        NEstado NEstado = new NEstado();
        NEstatusAlumno nestatus = new NEstatusAlumno();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Estado> estado = NEstado.Consultar();
            List<EstatusAlumno> estatus = nestatus.Consultar();
            ddlEstado.DataSource = estado;
            ddlEstado.DataTextField = "Nombre";
            ddlEstado.DataValueField = "idEstadoOrigen";
            ddlEstado.DataBind();

            ddlEstatus.DataSource = estatus;
            ddlEstatus.DataTextField = "Nombre";
            ddlEstatus.DataValueField = "idEstatus";
            ddlEstatus.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(ddlEstado.SelectedValue);
            int idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue);
            Alumno alumno = new Alumno
            {
                nombre = txtNombre.Text,
                primerApellido = txtPApellido.Text,
                segundoApellido = txtSApellido.Text,
                fechaNacimiento = Convert.ToDateTime(txtFNacimiento.Text),
                curp = txtCurp.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                idEstadoOrigen = idEstado,
                idEstatus = idEstatus
            };
           
            dalumno.Agregar(alumno);
            Response.Redirect("Index.aspx");
        }
    }
}
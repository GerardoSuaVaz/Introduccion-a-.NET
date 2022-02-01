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
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno nalumno = new NAlumno();
        DAlumno dalumno = new DAlumno();
        NEstado NEstado = new NEstado();
        NEstatusAlumno nestatus = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
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

                string id = Request.QueryString["id"];
                id = id == null ? "46" : id;
                Alumno alum = nalumno.Consultar(Convert.ToInt32(id));

                int idEstado = Convert.ToInt32(ddlEstado.SelectedValue);
                int idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue);

                txtId.Text = alum.idAlumno.ToString();
                txtNombre.Text = alum.nombre.ToString();
                txtPApellido.Text = alum.primerApellido.ToString();
                txtSApellido.Text = alum.segundoApellido.ToString();
                txtFNacimiento.Text = alum.fechaNacimiento.ToString("yyyy-MM-dd");
                txtCurp.Text = alum.curp.ToString();
                txtCorreo.Text = alum.correo.ToString();
                txtTelefono.Text = alum.telefono.ToString();
                ddlEstado.SelectedValue = idEstado.ToString();
                ddlEstatus.SelectedValue = idEstatus.ToString();
                //nalumno.Actualizacion(alum);
                //Response.Redirect("Index.aspx");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Alumno edialumno = new Alumno
            {
                idAlumno = Convert.ToInt32(txtId.Text),
                nombre = txtNombre.Text,
                primerApellido = txtPApellido.Text,
                segundoApellido = txtSApellido.Text,
                fechaNacimiento = Convert.ToDateTime(txtFNacimiento.Text),
                curp = txtCurp.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                idEstadoOrigen = Convert.ToInt32(ddlEstado.SelectedValue),
                idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue)
            };
            nalumno.Actualizacion(edialumno);
            Response.Redirect("Index.aspx");
        }

     
    }
}
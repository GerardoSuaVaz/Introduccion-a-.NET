using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebEstatusAlumnos
{
    public partial class Index : System.Web.UI.Page
    {
        ADOEstatus adoEstatus = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Estatus> estatuses = new List<Estatus>();
                estatuses = adoEstatus.Consultar();
                ddlEstatus.DataSource = estatuses;
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "idEstatus";
                ddlEstatus.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (btnActualizar.Enabled == false)
            //{
            //    string nombreE = txtNombre.Text;
            //    string abrevE = txtClave.Text;
            //    Estatus estatus = new Estatus { Nombre = nombreE, Clave = abrevE };
            //    adoEstatus.Agregar(estatus);
            //    txtNombre.Controls.Clear();
            //    txtClave.Controls.Clear();
            //    lblNombre.Visible = true;
            //    lblClave.Visible = true;
            //    txtNombre.Visible = true;
            //    txtClave.Visible = true;
            //    btnGuardar.Visible = true;
            //    btnCancelar.Visible = true;

            //}
            //else if (btnActualizar.Enabled == true)
            //{
            //    string Nombre = txtNombre.Text;
            //    string Clave = txtClave.Text;
            //    var idNombre = (Int32)ddlEstatus.SelectedValue();
            //    Estatus estatusAc = new Estatus { idEstatus = idNombre, Nombre = Nombre, Clave = Clave };
            //    ddlEstatus.Actualizacion(estatusAc);
            //    WebMsgBox.Show("El Registro se actualizo correctamente...");
            //    txtClave.Controls.Clear();
            //    txtNombre.Controls.Clear();
            //}
        }

        protected void ddlEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Actualizar.aspx?id={id}";
            Response.Redirect(url, true);
            //Response.Redirect("Actualizar.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Consultar.aspx?idEstatus={id}";
            Response.Redirect(url, true);
            //Response.Redirect("Consultar.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            string url = $"Eliminar.aspx?idEstatus={id}";
            Response.Redirect(url, true);
            //Response.Redirect("Eliminar.aspx");
        }
    }
}
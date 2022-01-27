using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEstatusAlumnos
{
    public partial class Consultar : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["idEstatus"]);
            Estatus item = ado.Consultar(id);
            txtId.Text = Request.QueryString["idEstatus"];
            txtNombre.Text = item.Nombre;
            txtClave.Text = item.Clave;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Index.aspx");
        }
    }
}
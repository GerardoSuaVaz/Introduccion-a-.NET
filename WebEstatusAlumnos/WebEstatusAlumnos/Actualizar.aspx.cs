using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEstatusAlumnos
{
    public partial class Actualizar : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["idEstatus"]);
                List<Estatus> item = ado.Consultar();
                txtId.Text = Request.QueryString["id"];
            }
            
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string nom = txtNombre.Text;
            string clav = txtClave.Text;
            Estatus Nestatus = new Estatus { idEstatus = id, Nombre = nom, Clave = clav };
            ado.Actualizacion(Nestatus);
            
            Response.Redirect("Index.aspx");
        }
    }
}
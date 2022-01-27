using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEstatusAlumnos
{
    public partial class Agregar : System.Web.UI.Page
    {
        ADOEstatus adoEstatus = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreE = txtNombre.Text;
            string abrevE = txtClave.Text;
            Estatus estatus = new Estatus { Nombre = nombreE, Clave = abrevE };
            adoEstatus.Agregar(estatus);
            txtNombre.Controls.Clear();
            txtClave.Controls.Clear();
           
            Response.Redirect("Index.aspx");
        }
    }
}
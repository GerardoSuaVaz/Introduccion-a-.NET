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
    public partial class Index : System.Web.UI.Page
    {
        NAlumno nalumno = new NAlumno();
       // DAlumno dalumno = new DAlumno();
        NEstado NEstado = new NEstado();
        NEstatusAlumno NEstatus = new NEstatusAlumno();
        List<Alumno> listAlumno = new List<Alumno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //Response.Redirect($"Create.aspx?idAlumno=46", true);
                //Response.Redirect($"Details.aspx?id=24", true);
                //Response.Redirect($"Edit.aspx?id=46",true);
                //Response.Redirect($"Delete.aspx?id=33", true);
      
                LLenarGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }

        protected void gvEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        protected void gvEstatus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEstatus.PageIndex = e.NewPageIndex;
            LLenarGrid();
        }

        private void LLenarGrid()
        {
            if (!IsPostBack)
            {
                List<Alumno> alumnos = nalumno.Consultar();
                List<Estado> estados = NEstado.Consultar();
                List<EstatusAlumno> estatus = NEstatus.Consultar();
                var elementos = from alum in alumnos
                                join estate in estados on alum.idEstadoOrigen equals estate.idEstadoOrigen
                                join status in estatus on alum.idEstatus equals status.idEstatus
                                //where alum.idAlumno == id
                                select new {idAlumno = alum.idAlumno, 
                                            nombre = alum.nombre , 
                                            pApellido = alum.primerApellido, 
                                            sApellido = alum.segundoApellido, 
                                            correo = alum.correo, 
                                            telefono = alum.telefono, 
                                            estado = estate.Nombre , 
                                            estatus = status.Nombre};
              gvEstatus.DataSource = elementos.ToList();
              gvEstatus.DataBind();
            }
        }

        protected void gvEstatus_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Page") return;
                int iren = Convert.ToInt32(e.CommandArgument);
                GridViewRow ren = gvEstatus.Rows[iren];
                TableCell celda = ren.Cells[0];
                string id = celda.Text;
                switch (e.CommandName)
                {
                    case "Detalles":
                        Response.Redirect($"Details.aspx?id={id}", true);
                        break;
                    case "Editar":
                        Response.Redirect($"Edit.aspx?id={id}", true);
                        break;
                    case "Eliminar":
                        Response.Redirect($"Delete.aspx?id={id}", true);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
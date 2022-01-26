using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEstatusAlumnos
{
    
    public partial class Form1 : Form
    {
        ADOEstatus adoEstatus = new ADOEstatus();
        
        public Form1()
        {
            InitializeComponent();
        }

        ///                               ///
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Estatus> estatuslist = new List<Estatus>();
            estatuslist = adoEstatus.Consultar();
            cmbEstados.DataSource = estatuslist;
            cmbEstados.DisplayMember = "Nombre";
            cmbEstados.ValueMember = "idEstatus";

            dgvEstatus.DataSource = estatuslist;
            panel1.Visible = false;
        }
        ///                                ///
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnClickThisBotonAgregar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnModificar.Enabled = false;


        }

        private void btnClickThisBotonModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            panel1.Visible=true;
            int idE = (Int32)cmbEstados.SelectedValue;
            Estatus item = adoEstatus.Consultar(idE);
            txtNombre.Text = item.Nombre;
            txtAbreviatura.Text = item.Clave;

        }

        private void btnClickThisBotonEliminar_Click(object sender, EventArgs e)
        {
            var idElim =(Int32) cmbEstados.SelectedValue;
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                adoEstatus.Eliminar(idElim);
                MessageBox.Show("Registro eliminado Exitosamente.");
            }


        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonGuradar_Click(object sender, EventArgs e)
        {
            if(btnModificar.Enabled == false)
            {
                string nombreE = txtNombre.Text;
                string abrevE = txtAbreviatura.Text;
                Estatus estatus = new Estatus { Nombre = nombreE, Clave = abrevE };
                adoEstatus.Agregar(estatus);
                txtNombre.Clear();
                txtAbreviatura.Clear();
                panel1.Visible = false;
            } else if (btnModificar.Enabled == true)
            {
                string nom = txtNombre.Text;
                string abreviatura = txtAbreviatura.Text;
                var idN = (Int32)cmbEstados.SelectedValue;
                Estatus estatusAc = new Estatus { idEstatus= idN, Nombre= nom, Clave= abreviatura };
                adoEstatus.Actualizacion(estatusAc);
                MessageBox.Show("El Registro se actualizo correctamente...");
                txtAbreviatura.Clear();
                txtNombre.Clear();
            }
            
        }

        private void BotonNombre_Click(object sender, EventArgs e)
        {

        }

        ///                          ///
    }
}
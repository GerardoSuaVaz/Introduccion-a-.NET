using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOAlumnos
{
 
    internal class ADOEstatus : ICRUDEstatus
    {
        string cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        //using (SqlConnection con = new SqlConnection(cnnString))
        List<estatus> listaEstatus = new List<estatus>();
        string query;
        string nombreEstatus;
        SqlCommand comando;
        private string conection;

        public void Actualizar(estatus estatus)
        {
            string query = $"update EstatusAlumnos set Nombre ='{estatus.Nombre}' where idEstatus={estatus.idEstatus}";

            using (SqlConnection conn = new SqlConnection(cnnString))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }

        public int Agregar(estatus estatus)
        {
            int idEstatus;
            query = $"insert into EstatusAlumnos(Clave,Nombre) values(@Clave, @Nombre)";
            using (SqlConnection con = new SqlConnection(cnnString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Clave", estatus.Clave);
                comando.Parameters.AddWithValue("@Nombre", estatus.Nombre);
                con.Open();
                idEstatus = Convert.ToInt32(comando.ExecuteScalar());
                con.Close();

            }
            return idEstatus;
        }

        public List<estatus> Consultar()
        {
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(cnnString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaEstatus.Add(
                       new estatus()
                       {
                           idEstatus = Convert.ToInt32(reader["idEstatus"]),
                           Clave = reader["Clave"].ToString(),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return listaEstatus;
        }

        public estatus Consultar(int id)
        {
            estatus estatusUno = new estatus();
            query = $"select * from EstatusAlumnos where idEstatus ={id}";
            using (SqlConnection con = new SqlConnection(cnnString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //listEstatus.Add(
                    //   new Estatus()
                    //   {
                    //       Id = Convert.ToInt32(reader["idEstatus"]),
                    //       Clave = reader["clave"].ToString(),
                    //       Nombre = reader["nombreEstatus"].ToString()
                    //   }
                    //   );
                    estatusUno = new estatus { idEstatus = Convert.ToInt32(reader["idEstatus"]), Clave = reader["Clave"].ToString(), Nombre = reader["Nombre"].ToString() };
                }
                con.Close();
            }
            return estatusUno;
        }

        public void Eliminar(int id)
        {
            query = $"delete EstatusAlumnos where idEstatus={id}";
            using (SqlConnection con = new SqlConnection(cnnString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

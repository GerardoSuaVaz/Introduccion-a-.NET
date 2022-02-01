using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class DEstado
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estado> listEstado = new List<Estado>();
        string query;
        SqlCommand comando;
        public List<Estado> Consultar()
        {
            query = "consultarEstado";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstado", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEstado.Add(
                       new Estado()
                       {
                           idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                           Nombre = reader["Nombre"].ToString(),
                       }
                       );
                }
                con.Close();
            }
            return listEstado;
        }
    }
}

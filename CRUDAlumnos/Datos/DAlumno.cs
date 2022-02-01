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
    public class DAlumno
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> listAlumno = new List<Alumno>();
        string query;
        SqlCommand comando;
        public List<Alumno> Consultar()
        {
            query = "consultarEAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listAlumno.Add(
                       new Alumno()
                       {
                           idAlumno = Convert.ToInt32(reader["id"].ToString()),
                           nombre = reader["nombre"].ToString(),
                           primerApellido = reader["primerApellido"].ToString(),
                           segundoApellido = reader["segundoApelllido"].ToString(),
                           correo = reader["correo"].ToString(),
                           telefono = reader["telefono"].ToString(),
                           fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                           curp = reader["curp"].ToString(),
                           idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                           idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())
                       }
                       );
                }
                con.Close();
            }
            return listAlumno;
        }
        public Alumno Consultar(int Id)
        {
            Alumno alumno = new Alumno();
            query = "consultarEAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", Id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alumno = new Alumno
                    {
                        idAlumno = Convert.ToInt32(reader["id"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        primerApellido = reader["primerApellido"].ToString(),
                        segundoApellido = reader["segundoApelllido"].ToString(),
                        correo = reader["correo"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                        curp = reader["curp"].ToString(),
                        idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                        idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())
                    };
                }
                con.Close();
            }
            return alumno;
        }
        public void Agregar(Alumno Alum)
        {

            query = "agregarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.AddWithValue("@idAlumno", Alum.idAlumno);
                comando.Parameters.AddWithValue("@NOMBRE", Alum.nombre);
                comando.Parameters.AddWithValue("@primerApellido", Alum.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", Alum.segundoApellido);
                comando.Parameters.AddWithValue("@correo", Alum.correo);
                comando.Parameters.AddWithValue("@telefono", Alum.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", Alum.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", Alum.curp);
                comando.Parameters.AddWithValue("@sueldo", Alum.sueldo);
                comando.Parameters.AddWithValue("@idEstadoOrigen", Alum.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", Alum.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }
        public void Actualizacion(Alumno Alum)
        {
            string query = "actualizarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", Alum.idAlumno);
                comando.Parameters.AddWithValue("@NOMBRE", Alum.nombre);
                comando.Parameters.AddWithValue("@primerApellido", Alum.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", Alum.segundoApellido);
                comando.Parameters.AddWithValue("@correo", Alum.correo);
                comando.Parameters.AddWithValue("@telefono", Alum.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", Alum.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", Alum.curp);
                comando.Parameters.AddWithValue("@sueldo", Alum.sueldo);
                comando.Parameters.AddWithValue("@idestadoOrigen", Alum.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", Alum.idEstatus);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }

        public void Eliminar(int id)
        {
            query = "eliminarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

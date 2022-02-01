using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cnnString))
            { 
             con.Open();
                Console.WriteLine("Conectado a BD InstitutoTich");
            }

            bool salir = false;
            string opc, menu;

            menu = "\n1. Consultar todos\n2. Consultar solo uno\n3. Agregar\n4. Actualizar\n" +
                   "5. Eliminar\n6. Terminar\n\nElija una opción:";
            while (!salir)
            {
                Console.WriteLine(menu);
                opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.WriteLine("Consultar Todas");
                    ADOEstatus consularTodas = new ADOEstatus();
                    //consularTodas.Consultar();
                    foreach (var i in consularTodas.Consultar())
                    {
                        Console.WriteLine($"id: {i.idEstatus}, clave: {i.Clave}, nombre: {i.Nombre}");
                    }
                    Console.ReadKey();

                }
                else if (opc == "2")
                {
                    Console.WriteLine("Consultar Uno");
                    ADOEstatus consultarUno = new ADOEstatus();
                    //consultarUno.Consultar();
                    Console.WriteLine("Ingresar ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var item = consultarUno.Consultar(id);
                    Console.WriteLine($"idEstatus: {item.idEstatus}, Clave: {item.Clave}, Nombre: {item.Nombre}");                  
                    Console.ReadKey();
                }

                else if (opc == "3")
                {
                
                    Console.WriteLine("Agregar"); 
                    ADOEstatus add = new ADOEstatus();
                    //add.Agregar(estatus estatus);
                    Console.WriteLine("Ingresar Clave:");
                    string Clave = Console.ReadLine();
                    Console.WriteLine("Ingresar Nombre o Descripcion de Estatus:");
                    string Nombre = Console.ReadLine();
                    estatus estatus = new estatus {Clave = Clave , Nombre = Nombre};
                    Console.WriteLine("Registro Agregado");
                    add.Agregar(estatus);
                    Console.ReadKey();
                }
                else if (opc == "4")
                {
                    Console.WriteLine("Actualizar");
                    ADOEstatus upgrade = new ADOEstatus();
                    Console.WriteLine("Ingresar ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresar Nueva Clave:");
                    string nclave = Console.ReadLine();
                    Console.WriteLine("Ingresar Nueva Descripcion:");
                    string nnombre = Console.ReadLine();
                    estatus estatus = new estatus { idEstatus = id, Clave = nclave, Nombre = nnombre };
                    upgrade.Actualizar(estatus);
                    Console.ReadKey();
                }
                else if (opc == "5")
                {
                    Console.WriteLine("Eliminar");
                    ADOEstatus eliminar = new ADOEstatus();
                    Console.WriteLine("Ingresar ID a Eliminar:");
                    int id = int.Parse(Console.ReadLine());
                    eliminar.Eliminar(id);
                    Console.WriteLine("Estatus Eliminado");
                    Console.ReadKey();
                }
            }
        }
    }
}

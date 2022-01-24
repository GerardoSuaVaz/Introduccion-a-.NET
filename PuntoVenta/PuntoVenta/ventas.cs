using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PuntoVenta
{
    internal class ventas
    {

        private List<articulo> listaArticulos = new List<articulo>();
        private List<itemBase> listaTicket = new List<itemBase>();
     
        string continuar;
        decimal totalVentas, totalVendido, totalDescuento, totalComisiones, totalGeneral;
        public void iniciar()
        {
            StreamReader articulojson = new StreamReader(@"C:\Users\Tichs\Documents\Gerardo\Desarrollador NET\Introduccion NET y C#\PuntoVenta\Articulos.json");
            string Articulos = articulojson.ReadToEnd();
            articulojson.Close();
            listaArticulos = JsonConvert.DeserializeObject<List<articulo>>(Articulos);
        }
        public void Ventas()
        {
            //bool ven = false;
            //while (!ven)
            //{
            //    Console.WriteLine("Iniciar nueva venta? s/n");
            //    string opc = Console.ReadLine();
            //    if (opc == "n")
            //        Environment.Exit(-1);
            //    bool art = false;
            //    while (!art)
            //    { 
            //    Console.WriteLine("Ingrese el ID del Articulo");
            //        int idArticulo = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese Cantidad");
            //        int catidad = int.Parse(Console.ReadLine());
            //        var vender = from articulo in listaArticulos
            //                     where articulo.id == idArticulo
            //                     select articulo;
            //    }

            do
            {
                Venta();
                Console.WriteLine("Desea realizar otra venta?");
                continuar = Console.ReadLine();
           
            } while (continuar.ToUpper() == "SI");
        }
        public void Venta()
        {
            string agregar;
            do
            {
                
                Console.WriteLine("Desea agregar otro articulo?");
                agregar = Console.ReadLine();
                agregarArticulo();
            } while (agregar.ToUpper() == "SI");
            totalVentas ++ ;
            imprimirTicket();


        }
        private void agregarArticulo()
        {
           
            Console.WriteLine("Ingrese el ID del Articulo");
                   int idArticulo = int.Parse(Console.ReadLine());
                   Console.WriteLine("Ingrese Cantidad");
                   decimal cantidad = decimal.Parse(Console.ReadLine());
                   //var buscar = from articulo in listaArticulos
                   //             where articulo.id == idArticulo
                   //             select articulo;

            articulo articulo = listaArticulos.Find(x => x.id == idArticulo);
           
            switch (articulo.tipo)
            {
                case tipoArticulo.normal:
                    articuloNormal(articulo, cantidad);
                    break;
                case tipoArticulo.precioDescuento:
                    articuloDescuento(articulo, cantidad);
                    break;
                case tipoArticulo.tiempoAire:
                    articuloTiempoAire(articulo, cantidad);
                    break;


            }
        }
        private void articuloNormal(articulo articulo, decimal cantidad)
        { 
         item articuloNormal = new item();
            articuloNormal.id = articulo.id;
            articuloNormal.nombre = articulo.nombre;
            articuloNormal.precio = articulo.precio;
            articuloNormal.cantidad = cantidad;
            listaTicket.Add(articuloNormal);
        }
        public void articuloDescuento(articulo articulo, decimal cantidad)
        {
            Console.WriteLine("Ingresar descuento");
            decimal descuento = decimal.Parse(Console.ReadLine());
            itemDescuento articuloDescuento = new itemDescuento();
            articuloDescuento.id = articulo.id;
            articuloDescuento.nombre = articulo.nombre;
            articuloDescuento.precio = articulo.precio;
            articuloDescuento.cantidad = cantidad;
            articuloDescuento.descuento = descuento;
            _ = articuloDescuento.impDescuento;
            listaTicket.Add(articuloDescuento);
        }

        public void articuloTiempoAire (articulo articulo, decimal cantidad)
        {
            Console.WriteLine("Ingresar Telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingresar compañia Telefonica");
            string compañia = Console.ReadLine();
            Console.WriteLine("Ingresar comision");
            decimal comision = decimal.Parse(Console.ReadLine());
            itemTA articuloTA = new itemTA();
            articuloTA.id = articulo.id;
            articuloTA.nombre = articulo.nombre;
            articuloTA.precio = articulo.precio;
            articuloTA.cantidad = cantidad;
            articuloTA.telefono = telefono;
            articuloTA.compañia = compañia;
            articuloTA.comision = comision;
            listaTicket.Add(articuloTA);
        }
        private void imprimirTicket()
        {
            Console.WriteLine("TICH - TI CAPITAL HUMANO");
            Console.WriteLine("Fecha y hora: " + DateTime.Now);
            foreach (var art in listaTicket)
            {
                art.imprimir();
            }
            Console.WriteLine("Total de articulos: " + listaTicket.Count());
            Console.WriteLine("Total a pagar: " + listaTicket.Sum(suma => suma.precio));
            totalVendido += listaTicket.Sum(suma => suma.precio);
        }

        public void corteCaja()
        {
            Console.WriteLine("Corte caja");
            Console.WriteLine($"Total de ventas: " + totalVentas);
            Console.WriteLine($"Total Vendido: " + totalVendido);
            Console.WriteLine($"Total Descuentos: " + totalDescuento);
            Console.WriteLine($"Total comisiones: " + totalComisiones);
            Console.WriteLine($"Total en caja: " + totalGeneral);
            Console.ReadKey();
        }
    }
}

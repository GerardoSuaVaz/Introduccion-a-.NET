namespace PuntoVenta
{
    public abstract class itemBase
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }
        public virtual decimal subTotal() => precio * cantidad;

        public virtual decimal total() => precio* cantidad;

        public abstract void imprimir();
    }
}

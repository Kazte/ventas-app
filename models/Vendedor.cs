namespace tienda_mayorista_app
{
    public class Vendedor
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string CodigoVendedor { get; private set; }
        public Tienda Tienda { get; private set; }
        
        public Vendedor(int id, string nombre, string apellido, string codigoVendedor, Tienda tienda)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = codigoVendedor;
            Tienda = tienda;
        }
    }
}
namespace tienda_mayorista_app
{
    public class Pantalon:Prenda
    {
        public Pantalon(int identificador, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(identificador, calidad, precioUnitario, cantidadStock)
        {
        }

        public Pantalon(int identificador, Calidad calidad) : base(identificador, calidad)
        {
        }

        public override string ToString()
        {
            return $"Pantalon Normal - {Calidad}";
        }
    }
}
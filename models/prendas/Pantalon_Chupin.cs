namespace tienda_mayorista_app
{
    public class Pantalon_Chupin : Pantalon
    {
        public Pantalon_Chupin(int identificador, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(identificador, calidad, precioUnitario,
            cantidadStock)
        {
        }

        public Pantalon_Chupin(int identificador, Calidad calidad) : base(identificador, calidad)
        {
        }

        public override decimal ObtenerPrecio()
        {
            var precioBase = base.ObtenerPrecio();

            return precioBase - precioBase * (decimal)0.12f;
        }

        public override string ToString()
        {
            return $"Pantalon Chupin - {Calidad}";
        }
    }
}
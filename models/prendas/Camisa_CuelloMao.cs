namespace tienda_mayorista_app
{
    public class Camisa_CuelloMao : Camisa
    {
        public Camisa_CuelloMao(int identificador, Calidad calidad, decimal precioUnitario, int cantidadStock, TipoManga tipoManga) : base(identificador,
            calidad, precioUnitario, cantidadStock, tipoManga)
        {
        }

        public Camisa_CuelloMao(int identificador, Calidad calidad, TipoManga tipoManga) : base(identificador,
            calidad, tipoManga)
        {
        }        

        public override decimal ObtenerPrecio()
        {
            var precioBase = base.ObtenerPrecio();

            return (decimal)(precioBase + precioBase * (decimal)0.03f);
        }

        public override string ToString()
        {
            return $"Camisa Cuello Mao - {TipoManga} - {Calidad}";
        }
    }
}
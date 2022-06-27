namespace tienda_mayorista_app
{
    public enum TipoManga
    {
        Corta,
        Larga
    }
    public class Camisa : Prenda
    {
        protected TipoManga TipoManga;

        public Camisa(int identificador, Calidad calidad, decimal precioUnitario, int cantidadStock, TipoManga tipoManga) : base(identificador, calidad, precioUnitario, cantidadStock)
        {
            TipoManga = tipoManga;
        }

        public Camisa(int identificador, Calidad calidad, TipoManga tipoManga) : base(identificador, calidad)
        {
            TipoManga = tipoManga;
        }

        public override decimal ObtenerPrecio()
        {
            var precioBase = base.ObtenerPrecio();
            return TipoManga == TipoManga.Corta ? precioBase - precioBase * (decimal)0.1f : precioBase;
        }

        public override string ToString()
        {
            return $"Camisa Normal - {TipoManga} - {Calidad}";
        }

    }
}
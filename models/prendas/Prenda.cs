namespace tienda_mayorista_app
{
    public enum Calidad
    {
        Standard,
        Premium
    }

    public abstract class Prenda
    {
        public int Identificador { get; private set; }
        protected Calidad Calidad;
        protected decimal PrecioUnitario;
        protected int CantidadStock;

        protected Prenda(int identificador,  Calidad calidad, decimal precioUnitario, int cantidadStock)
        {
            Identificador = identificador;
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            CantidadStock = cantidadStock;
        }

        protected Prenda(int identificador, Calidad calidad)
        {
            Identificador = identificador;
            Calidad = calidad;
        }

        public virtual decimal ObtenerPrecio()
        {
            switch (Calidad)
            {
                case Calidad.Standard:
                    return PrecioUnitario;
                case Calidad.Premium:
                    return PrecioUnitario + PrecioUnitario * 0.3m;
                default:
                    return 0;
            }
        }
    }
}
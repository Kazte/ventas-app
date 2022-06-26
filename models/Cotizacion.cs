using System;

namespace tienda_mayorista_app
{
    public class Cotizacion
    {
        public string Identificador { get; private set; }
        public DateTime FechaCotizacion { get; private set; }
        public string CodigoVendedor { get; private set; }
        public Prenda Prenda { get; private set; }
        public int CantidadCotizada { get; private set; }
        public decimal CalculoCotizacion { get; private set; }

        public Cotizacion(string identificador, DateTime fechaCotizacion, string codigoVendedor, Prenda prenda, int cantidadCotizada, decimal calculoCotizacion)
        {
            Identificador = identificador;
            FechaCotizacion = fechaCotizacion;
            CodigoVendedor = codigoVendedor;
            Prenda = prenda;
            CantidadCotizada = cantidadCotizada;
            CalculoCotizacion = calculoCotizacion;
        }
    }
}
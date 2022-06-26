using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace tienda_mayorista_app.controllers
{
    public class Controlador
    {

        private ControladorDB controladorDB;

        public Controlador()
        {
            controladorDB = new ControladorDB();
        }

        private Prenda CrearPrenda(int id, string tipoPrenda, Calidad calidad, int cantidad, decimal precio)
        {
            if (tipoPrenda.Contains("Camisa"))
            {
                var tipoManga = tipoPrenda.Contains("Manga Larga") ? TipoManga.Larga : TipoManga.Corta;

                return tipoPrenda.Contains("Cuello Mao") ?
                    new Camisa_CuelloMao(id, calidad, precio, cantidad, tipoManga) :
                    new Camisa(id, calidad, precio, cantidad, tipoManga);
            }
            else if (tipoPrenda.Contains("Pantalon"))
            {
                return tipoPrenda.Contains("Chupin") ?
                    new Pantalon_Chupin(id, calidad, precio, cantidad) :
                    new Pantalon(id, calidad, precio, cantidad);
            }

            return null;
        }

        public decimal GenerarCotizacion(string tipoPrenda, Vendedor vendedor, Calidad calidad, int cantidad, decimal precio)
        {
            if (!controladorDB.HayStock(tipoPrenda, calidad, cantidad, out var id)) return -1;
            
            var prenda = CrearPrenda(id, tipoPrenda, calidad, cantidad, precio);

            var precioTotal = prenda.ObtenerPrecio() * cantidad;

            var g = Guid.NewGuid();

            var cotizacion = new Cotizacion(g.ToString(), DateTime.Now, vendedor.CodigoVendedor, prenda, cantidad, precioTotal);

            GuardarCotizacion(cotizacion);

            return precioTotal;

        }

        public List<Tienda> ObtenerTiendas()
        {
            return controladorDB.ObtenerTiendas();
        }

        public Tienda ObtenerTienda(string nombreTienda)
        {
            return controladorDB.ObtenerTienda(nombreTienda);
        }

        public List<Vendedor> ObtenerVendedores(Tienda tienda)
        {
            return controladorDB.ObtenerVendedoresPorTienda(tienda);
        }

        public Vendedor ObtenerVendedor(string codigoVendedor, Tienda tienda)
        {
            return controladorDB.ObtenerVendedor(codigoVendedor, tienda);
        }


        public void GuardarCotizacion(Cotizacion cotizacion)
        {
            controladorDB.GuardarCotizacion(cotizacion);
        }

        public List<Cotizacion> ObtenerCotizaciones(string codigoVendedor)
        {
            return controladorDB.ObtenerCotizaciones(codigoVendedor);
        }
    }
}
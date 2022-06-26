using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_mayorista_app.controllers
{
    public class ControladorDB
    {
        private string stringConnection = "server=DESKTOP-4M4T4KV; database=ventas-app; integrated security=true;MultipleActiveResultSets=True";

        private SqlConnection conexion;
        public ControladorDB()
        {

        }

        private SqlDataReader ObtenerPrendasPorCalidad(string prenda, Calidad calidad)
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            var splitPrenda = prenda.Split(' ');

            var tipoString = "";

            foreach (var item in splitPrenda)
            {
                tipoString += $" AND TipoPrenda LIKE '%{item}%'";
            }

            string query = "SELECT * FROM uvw_Prendas WHERE CalidadPrenda LIKE @calidad " + tipoString ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@calidad", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@calidad"].Value = calidad.ToString();

            return cmd.ExecuteReader();
        }

        public bool HayStock(string prenda, Calidad calidad, int cantidad, out int id)
        {

            var registros = ObtenerPrendasPorCalidad(prenda, calidad);

            int stockActual = 0;
            int idPrenda = 0;

            if (registros.Read())
            {
                stockActual = int.Parse(registros["Stock"].ToString());
                idPrenda = int.Parse(registros["idPrenda"].ToString());
            }

            conexion.Close();

            id = idPrenda;

            return stockActual >= cantidad ? true : false;
        }

        public int ObtenerStock(string prenda, Calidad calidad)
        {
            var registros = ObtenerPrendasPorCalidad(prenda, calidad);

            if (registros.Read())
                return int.Parse(registros["Stock"].ToString());

            return -1;
        }

        public List<Tienda> ObtenerTiendas()
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            string query = "SELECT * FROM Tiendas";
            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataReader registros = cmd.ExecuteReader();
            List<Tienda> tiendas = new List<Tienda>();
            while (registros.Read())
            {
                tiendas.Add(new Tienda((int)registros["idTienda"], registros["NombreTienda"].ToString(), registros["Direccion"].ToString()));
            }
            conexion.Close();

            return tiendas;
        }

        public Tienda ObtenerTienda(string nombreTienda)
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            string query = "SELECT * FROM Tiendas WHERE NombreTienda = @nombreTienda";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@nombreTienda", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@nombreTienda"].Value = nombreTienda;

            SqlDataReader registros = cmd.ExecuteReader();
            Tienda tienda = null;
            if (registros.Read())
            {
                tienda = new Tienda((int)registros["idTienda"], registros["NombreTienda"].ToString(), registros["Direccion"].ToString());
            }
            conexion.Close();
            return tienda;
        }

        public List<Vendedor> ObtenerVendedoresPorTienda(Tienda tienda)
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            string query = "SELECT * FROM Vendedores V INNER JOIN Tiendas T ON V.idTienda = T.idTienda WHERE T.idTienda = @idTienda";

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@idTienda", System.Data.SqlDbType.Int);
            cmd.Parameters["@idTienda"].Value = tienda.Id;

            SqlDataReader registros = cmd.ExecuteReader();
            List<Vendedor> vendedores = new List<Vendedor>();

            while (registros.Read())
            {

                vendedores.Add(new Vendedor(
                    (int)registros["idVendedor"], 
                    registros["NombreVendedor"].ToString(), 
                    registros["ApellidoVendedor"].ToString(), 
                    registros["CodigoVendedor"].ToString(),
                    tienda
                    ));
            }

            conexion.Close();

            return vendedores;
        }

        public Vendedor ObtenerVendedor(string codigoVendedor, Tienda tienda)
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            string query = "SELECT * FROM Vendedores WHERE CodigoVendedor = @codigoVendedor";

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@codigoVendedor", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@codigoVendedor"].Value = codigoVendedor;

            SqlDataReader registros = cmd.ExecuteReader();
            Vendedor vendedor = null;
            if (registros.Read())
            {
                vendedor = new Vendedor(
                    (int)registros["idVendedor"], 
                    registros["NombreVendedor"].ToString(), 
                    registros["ApellidoVendedor"].ToString(), 
                    registros["CodigoVendedor"].ToString(),
                    tienda
                    );
            }
            conexion.Close();

            return vendedor;
        }

        public void GuardarCotizacion(Cotizacion cotizacion)
        {
            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            // Obtener el id del Vendedor por su CodigoVendedor
            string query = "SELECT * FROM Vendedores WHERE CodigoVendedor = @codigoVendedor";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@codigoVendedor", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@codigoVendedor"].Value = cotizacion.CodigoVendedor;

            SqlDataReader registros = cmd.ExecuteReader();
            var idVendedor = 0;

            if (registros.Read())
            {
                idVendedor = int.Parse(registros["idVendedor"].ToString());
            }


            //Obtener el idPrenda por su identificador
            query = "SELECT * FROM Prendas WHERE idPrenda = @idPrenda";

            cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add("@idPrenda", System.Data.SqlDbType.Int);
            cmd.Parameters["@idPrenda"].Value = cotizacion.Prenda.Identificador;

            registros = cmd.ExecuteReader();

            var idPrenda = 0;

            if (registros.Read())
            {
                idPrenda = int.Parse(registros["idPrenda"].ToString());
            }

            // Guardar la cotizacion en la base de datos
            query = "INSERT INTO Cotizaciones (Identificador, idVendedor, FechaCotizacion, Cotizacion, CantidadCotizada, idPrenda) VALUES (@identificador, @idVendedor, @fecha, @total, @cantidadCotizada, @idPrenda)";
            cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@idVendedor", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime);
            cmd.Parameters.Add("@total", System.Data.SqlDbType.Decimal);
            cmd.Parameters.Add("@cantidadCotizada", System.Data.SqlDbType.Decimal);
            cmd.Parameters.Add("@idPrenda", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@identificador", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@idVendedor"].Value = idVendedor;
            cmd.Parameters["@fecha"].Value = cotizacion.FechaCotizacion;
            cmd.Parameters["@total"].Value = cotizacion.CalculoCotizacion;
            cmd.Parameters["@cantidadCotizada"].Value = cotizacion.CantidadCotizada;
            cmd.Parameters["@idPrenda"].Value = idPrenda;
            cmd.Parameters["@identificador"].Value = cotizacion.Identificador;

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public List<Cotizacion> ObtenerCotizaciones(string codigoVendedor)
        {
            List<Cotizacion> cotizaciones = new List<Cotizacion>();

            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            string query = @"   
                                SELECT		*
                                FROM		uvw_Cotizaciones
                                WHERE		CodigoVendedor = @codigoVendedor";

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add("@codigoVendedor", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@codigoVendedor"].Value = codigoVendedor;

            SqlDataReader registros = cmd.ExecuteReader();

            while (registros.Read())
            {

                var prenda = CrearPrenda(
                    (int)registros["idPrenda"],
                    registros["TipoPrenda"].ToString(),
                    registros["CalidadPrenda"].ToString() == "Standard" ? Calidad.Standard : Calidad.Premium
                    );

                var cotizacion =
                    new Cotizacion(
                        registros["Identificador"].ToString(),
                        DateTime.Parse(registros["FechaCotizacion"].ToString()),
                        registros["CodigoVendedor"].ToString(),
                        prenda,
                        (int)registros["CantidadCotizada"],
                        decimal.Parse(registros["Cotizacion"].ToString())
                        );

                cotizaciones.Add(cotizacion);

            }

            conexion.Close();

            return cotizaciones;
        }

        private Prenda CrearPrenda(int id, string tipoPrenda, Calidad calidad)
        {            
            if (tipoPrenda.Contains("Camisa"))
            {
                var tipoManga = tipoPrenda.Contains("Manga Larga") ? TipoManga.Larga : TipoManga.Corta;

                return tipoPrenda.Contains("Cuello Mao") ?
                    new Camisa_CuelloMao(id, calidad, tipoManga) :
                    new Camisa(id, calidad, tipoManga);
            }
            else if (tipoPrenda.Contains("Pantalon"))
            {
                return tipoPrenda.Contains("Chupin") ?
                    new Pantalon_Chupin(id, calidad) :
                    new Pantalon(id, calidad);
            }

            return null;
        }
    }
}

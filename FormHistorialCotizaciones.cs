using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda_mayorista_app.controllers;

namespace tienda_mayorista_app
{
    public partial class FormHistorialCotizaciones : Form
    {
        private Controlador controlador;

        private Vendedor vendedor;

        public FormHistorialCotizaciones(Controlador controlador, Vendedor vendedor)
        {
            InitializeComponent();

            this.controlador = controlador;
            this.vendedor = vendedor;

            // Cambiar titulo del formulario
            this.Text = $"Historial de cotizaciones - {vendedor.Nombre} {vendedor.Apellido} ({vendedor.CodigoVendedor})";

            CargarHistorial();
        }

        private void CargarHistorial()
        {
            var cotizaciones = controlador.ObtenerCotizaciones(vendedor.CodigoVendedor);

            dgvCotizaciones.DataSource = cotizaciones;

        }
    }
}

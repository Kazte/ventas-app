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
    public partial class FormPrincipal : Form
    {
        private Controlador controlador;

        private Vendedor vendedorActual;

        private Tienda tiendaActual;

        private Calidad calidad;

        private string prendaString;

        public FormPrincipal()
        {
            InitializeComponent();

            controlador = new Controlador();

            CargarComboBoxTiendas();

            CargarComboBoxVendedores();

            radioBtnCamisa.Checked = true;

            rbStandard.Checked = true;
        }

        private void CargarComboBoxTiendas()
        {
            var tiendas = controlador.ObtenerTiendas();

            cbbNombreTienda.DataSource = tiendas.Select(t => t.Nombre).ToList();

            tiendaActual = tiendas[0];
        }

        private void CargarComboBoxVendedores()
        {
            var vendedores = controlador.ObtenerVendedores(tiendaActual);

            cbbNombreVendedor.DataSource = vendedores.Select(v => v.Nombre + " " + v.Apellido + " " + v.CodigoVendedor).ToList();

            vendedorActual = vendedores[0];
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            var calidad = this.calidad;

            int cantidad = int.Parse(nbCantidad.Value.ToString());

            decimal precio = decimal.Parse(nbPrecio.Value.ToString("##.00"));

            var precioTotal = controlador.GenerarCotizacion(prendaString, vendedorActual, calidad, cantidad, precio);

            if (precioTotal == -1)
            {
                MessageBox.Show(
                    "No hay suficiente Stock para hacer la cotización",
                    "Error Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                lbPrecioFinal.Text = "$ " + precioTotal.ToString("##.00");
            }
        }

        private void llbHistorialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formHistorialCotizaciones = new FormHistorialCotizaciones(controlador, vendedorActual);

            formHistorialCotizaciones.ShowDialog();
        }

        private void cbbNombreTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tiendaSeleccionada = controlador.ObtenerTienda(cbbNombreTienda.SelectedItem.ToString());

            lbDireccionTienda.Text = "Direccion: " + tiendaSeleccionada.Direccion;

            tiendaActual = tiendaSeleccionada;

            CargarComboBoxVendedores();
        }

        private void cbbNombreVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] separado = cbbNombreVendedor.SelectedItem.ToString().Split(' ');

            string nombre = separado[0];
            string apellido = separado[1];
            string codigoVendedor = separado[2];

            var vendedorSeleccionado = controlador.ObtenerVendedor(codigoVendedor, tiendaActual);

            vendedorActual = vendedorSeleccionado;

            lbCodigoVendedor.Text = "Codigo Vendedor: " + vendedorActual.CodigoVendedor;
        }

        private void radioBtnCamisa_CheckedChanged(object sender, EventArgs e)
        {

            prendaString = "Camisa";

            prendaString += cbCuelloMao.Checked ? " Cuello Mao" : " Cuello Normal";

            prendaString += cbMangaCorta.Checked ? " Manga Corta" : " Manga Larga";

            cbMangaCorta.Enabled = true;
            cbCuelloMao.Enabled = true;


            cbChupin.Checked = false;
            cbChupin.Enabled = false;
        }

        private void radioBtnPantalon_CheckedChanged(object sender, EventArgs e)
        {

            prendaString = "Pantalon";

            prendaString += cbChupin.Checked ? " Chupin" : " Normal";

            cbCuelloMao.Checked = false;
            cbCuelloMao.Enabled = false;


            cbMangaCorta.Checked = false;
            cbMangaCorta.Enabled = false;


            cbChupin.Enabled = true;

        }

        private void rbStandard_CheckedChanged(object sender, EventArgs e)
        {
            calidad = Calidad.Standard;
        }

        private void rbPremium_CheckedChanged(object sender, EventArgs e)
        {
            calidad = Calidad.Premium;
        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnCamisa.Checked) return;

            if (cbCuelloMao.Checked)
            {
                prendaString = prendaString.Replace(" Cuello Normal", "");
                prendaString += " Cuello Mao";
            }
            else
            {
                prendaString = prendaString.Replace(" Cuello Mao", "");
                prendaString += " Cuello Normal";
            }
        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {

            if (!radioBtnCamisa.Checked) return;

            if (cbMangaCorta.Checked)
            {
                prendaString = prendaString.Replace(" Manga Larga", "");
                prendaString += " Manga Corta";
            }
            else
            {

                prendaString = prendaString.Replace(" Manga Corta", "");
                prendaString += " Manga Larga";
            }
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnPantalon.Checked) return;


            if (cbChupin.Checked)
            {
                prendaString = prendaString.Replace(" Normal", "");
                prendaString += " Chupin";
            }
            else
            {
                prendaString = prendaString.Replace(" Chupin", "");
                prendaString += " Normal";
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win.proyecto
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Formlogin = new formlogin();
            Formlogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario:"
                + Program.UsuarioLogueado.Nombre;

                
            }
        }

        private void inicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formalogin = new formlogin();
            formalogin.ShowDialog();
          
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproducto = new formproductos();
            formproducto.MdiParent = this;
            formproducto.Show();

        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formanten = new Formant();
            formanten.MdiParent = this;
            formanten.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void transaccionesDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtrandiass = new Formtrandia();
            formtrandiass.MdiParent = this;
            formtrandiass.Show();
        }

        private void reportesContabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcontabilidad = new Formconta();
            formcontabilidad.MdiParent = this;
            formcontabilidad.Show();
        }

        private void reportesDePlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formplan = new Formplanilla();
            formplan.MdiParent = this;
            formplan.Show();
        }

        private void reportesProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormClientes = new FormClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormFactura = new FormFactura();
            FormFactura.MdiParent = this;
            FormFactura.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();

        }

        private void reporteDeVentaPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteVentasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteVentasTotales = new FormVentasTotales();
            formReporteVentasTotales.MdiParent = this;
            formReporteVentasTotales.Show();

        }
    }
}

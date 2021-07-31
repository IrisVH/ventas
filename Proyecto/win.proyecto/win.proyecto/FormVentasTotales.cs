using BL.proyecto;
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
    public partial class FormVentasTotales : Form
    {
        public FormVentasTotales()
        {

            InitializeComponent();
            var _facturasBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturasBL.ObtenerFacturas();

            var reporte = new ReporteVentasTotales();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}

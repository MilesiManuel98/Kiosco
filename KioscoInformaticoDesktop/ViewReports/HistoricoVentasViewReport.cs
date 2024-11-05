using KioscoInformaticoServices.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class HistoricoVentasViewReport : Form
    {
        ReportViewer reporte;
        private List<Venta> listaVentas;
        private string TituloReporte;
        public HistoricoVentasViewReport(List<Venta>ventas, string TituloReporte)
        {
            InitializeComponent();
            listaVentas = ventas;
            this.TituloReporte = TituloReporte;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistoricoVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.HistoricoVentasReport.rdlc";

            var ventas = listaVentas
                .OrderBy(venta => venta.FormaPago)
                .Select(venta => new { Id = venta.Id, Fecha = venta.Fecha, ClienteNombre = venta.Cliente.Nombre, Total = venta.Total, Iva = venta.Iva, FormaDePago = venta.FormaPago.ToString() }).ToList();

            reporte.LocalReport.SetParameters(new ReportParameter("TituloReporte", TituloReporte));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}

using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
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
    public partial class FacturaVentaViewReport : Form
    {
        ReportViewer reporte = new ReportViewer();
        public FacturaVentaViewReport()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        public FacturaVentaViewReport(Venta? nuevaVenta)
        {
            this.nuevaVenta = nuevaVenta;
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        public Venta? nuevaVenta { get; }

        private void FacturaVentaViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";
            var ventas = new List<object> { new { Id = nuevaVenta.Id, Fecha = nuevaVenta.Fecha, ClienteNombre = nuevaVenta.Cliente.Nombre, Total = nuevaVenta.Total, Iva = nuevaVenta.Iva } };
            var detalleVentas = nuevaVenta.DetallesVenta.Select(dv => new { ProductoNombre = dv.Producto.Nombre, PrecioUnitario = dv.PrecioUnitario, Cantidad = dv.Cantidad, SubTotal = dv.Subtotal }).ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detalleVentas));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}

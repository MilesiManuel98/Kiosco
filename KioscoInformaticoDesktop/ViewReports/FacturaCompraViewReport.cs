using KioscoInformaticoServices.Enums;
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
    public partial class FacturaCompraViewReport : Form
    {
        ReportViewer reporte = new ReportViewer();

        public FacturaCompraViewReport()
        {
            
            reporte.Dock = DockStyle.Fill;
            InitializeComponent();
            Controls.Add(reporte);
        }

        public FacturaCompraViewReport(Compra? nuevaCompra)
        {
            this.nuevaCompra = nuevaCompra;
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        public Compra? nuevaCompra { get; }

        private void FacturaCompraViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaCompraReport.rdlc";
            var compras = new List<object> { new { Id = nuevaCompra.Id, Fecha = nuevaCompra.Fecha, ClienteNombre = nuevaCompra.Proveedor.Nombre, Total = nuevaCompra.Total, Iva = nuevaCompra.Iva, FormaDePago = nuevaCompra.FormaDePago.ToString() } };
            var detalleCompras = nuevaCompra.DetallesCompra.Select(dv => new { ProductoNombre = dv.Producto.Nombre, PrecioUnitario = dv.PrecioUnitario, Cantidad = dv.Cantidad, SubTotal = dv.Subtotal }).ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompras", compras));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesCompra", detalleCompras));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}

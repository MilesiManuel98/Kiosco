using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class VentasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        GenericService<Venta> ventaService = new GenericService<Venta>();
        Venta venta = new Venta();
        public VentasView()
        {
            InitializeComponent();
            AjustePantalla();

        }

        private async void AjustePantalla()
        {
            await Task.WhenAll(
                Task.Run(async () => comboBoxClientes.DataSource = await clienteService.GetAllAsync()),
                Task.Run(async () => comboBoxProductos.DataSource = await productoService.GetAllAsync())
            );

            comboBoxClientes.DisplayMember = "Nombre";
            comboBoxClientes.ValueMember = "Id";

            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Id";
            comboBoxProductos.SelectedIndex = -1;

            comboBoxFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            gridDetallesVenta.OcultarColumnas(new string[] { "Id", "VentaId", "ProductoId", "Eliminado", "Venta" });
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboBoxProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboBoxProductos.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new DetalleVenta
            {
                Producto = (Producto)comboBoxProductos.SelectedItem,
                ProductoId = (int)comboBoxProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };

            venta.DetallesVenta.Add(detalleVenta);
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            comboBoxProductos.SelectedIndex = -1;
            comboBoxProductos.Focus();
            ActualizarTotalFctura();
        }

        private void ActualizarTotalFctura()
        {
            numericTotal.Value = venta.DetallesVenta.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetallesVenta.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var detalleVenta = (DetalleVenta)gridDetallesVenta.CurrentRow.DataBoundItem;
            venta.DetallesVenta.Remove(detalleVenta);
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            ActualizarTotalFctura();
        }

        private void gridDetallesVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetallesVenta.OcultarColumnas(new string[] { "Id", "VentaId", "ProductoId", "Eliminado", "Venta" });
            btnQuitar.Enabled = gridDetallesVenta.RowCount > 0;
        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            venta.ClienteId = (int)comboBoxClientes.SelectedValue;
            venta.FormaPago = (FormaDePagoEnum)comboBoxFormasDePago.SelectedValue;
            venta.Fecha = DateTime.Now;
            venta.Iva = venta.Total * 0.21m;
            venta.Total = numericTotal.Value;
            venta.Cliente = null;
            venta.DetallesVenta.ToList().ForEach(dv => dv.Producto = null);
            venta.DetallesVenta.ToList().ForEach(dv => dv.Venta = null);
            await ventaService.AddAsync(venta);
        }
    }
}

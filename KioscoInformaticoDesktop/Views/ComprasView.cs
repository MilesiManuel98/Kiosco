using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
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
    public partial class ComprasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        GenericService<Compra> compraService = new GenericService<Compra>();
        Compra compra = new Compra();
        public ComprasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            await Task.WhenAll(
                Task.Run(async () => comboBoxProveedores.DataSource = await clienteService.GetAllAsync()),
                Task.Run(async () => comboBoxProductos.DataSource = await productoService.GetAllAsync())
            );

            comboBoxProveedores.DisplayMember = "Nombre";
            comboBoxProveedores.ValueMember = "Id"; 
            comboBoxProveedores.SelectedIndex = -1;
            comboBoxProveedores.Text = "Seleccione un cliente";

            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Id";
            comboBoxProductos.SelectedIndex = -1;
            comboBoxProductos.Text = "Seleccione un producto";

            comboBoxFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            comboBoxFormasDePago.SelectedIndex = -1;
            comboBoxFormasDePago.Text = "Seleccione una forma de pago";

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
            gridDetallesCompra.OcultarColumnas(new string[] { "Id", "CompraId", "ProductoId", "Eliminado", "Compra" });
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
            var detalleCompra = new DetalleCompra
            {
                Producto = (Producto)comboBoxProductos.SelectedItem,
                ProductoId = (int)comboBoxProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };

            compra.DetallesCompra.Add(detalleCompra);
            gridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
            comboBoxProductos.SelectedIndex = -1;
            comboBoxProductos.Text = "Seleccione un producto";
            comboBoxProductos.Focus();
            ActualizarTotalFctura();
        }

        private void ActualizarTotalFctura()
        {
            numericTotal.Value = compra.DetallesCompra.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetallesCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var detalleCompra = (DetalleCompra)gridDetallesCompra.CurrentRow.DataBoundItem;
            compra.DetallesCompra.Remove(detalleCompra);
            gridDetallesCompra.DataSource = compra.DetallesCompra.ToList();
            ActualizarTotalFctura();
        }

        private void gridDetallesCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetallesCompra.OcultarColumnas(new string[] { "Id", "CompraId", "ProductoId", "Eliminado", "Compra" });
            btnQuitar.Enabled = gridDetallesCompra.RowCount > 0;
        }

        private async void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            
            compra.ProveedorID = (int)comboBoxProveedores.SelectedValue;
            compra.Proveedor = (Proveedor)comboBoxProveedores.SelectedItem;
            compra.FormaDePago = (FormaDePagoEnum)comboBoxFormasDePago.SelectedValue;
            compra.Fecha = DateTime.Now;
            compra.Iva = compra.Total * 0.21m;
            compra.Total = numericTotal.Value;
            var nuevaCompra = await compraService.AddAsync(compra);
            var facturaCompra = new FacturaCompraViewReport(nuevaCompra);
            facturaCompra.ShowDialog();
        }
    }
}

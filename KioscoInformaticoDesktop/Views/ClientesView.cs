using KioscoInformaticoDesktop.DataContext;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClientesView : Form
    {
        IClienteService clienteService = new ClienteService();
        BindingSource ListClientes = new BindingSource();
        Cliente clienteCurrent;

        public ClientesView()
        {
            InitializeComponent();
            dataGridClientesView.DataSource = ListClientes;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync();
        }

        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void iconButtonEditar_Click_1(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            txtDireccion.Text = clienteCurrent.Direccion;
            txtTelefono.Text = clienteCurrent.Telefonos;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                clienteCurrent.Direccion = txtDireccion.Text;
                clienteCurrent.Telefonos = txtTelefono.Text;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {

                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text
                };
                await clienteService.AddAsync(clienteCurrent);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteCurrent = ListClientes.Current as Cliente;
                if (clienteCurrent != null)
                {
                    await clienteService.DeleteAsync(clienteCurrent.Id);
                    await CargarGrilla();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private async void FiltrarProductos()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync(txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

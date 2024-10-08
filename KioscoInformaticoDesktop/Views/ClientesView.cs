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
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListClientes = new BindingSource();
        Cliente clienteCurrent;

        public ClientesView()
        {
            InitializeComponent();
            dataGridClientesView.DataSource = ListClientes;
            CargarGrilla();
            CarnarCombo();
        }

        private async Task CarnarCombo()
        {
            comboLocalidades.DataSource = await localidadService.GetAllAsync();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";
            comboLocalidades.SelectedIndex = 0;
        }

        private async Task CargarGrilla()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync();
            dataGridClientesView.Columns["LocalidadId"].Visible = false;
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
            comboLocalidades.SelectedValue = clienteCurrent.LocalidadId;
            dateTimeFechaDeNacimiento.Value = clienteCurrent.FechaNacimiento;
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
                clienteCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
                clienteCurrent.FechaNacimiento = dateTimeFechaDeNacimiento.Value;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {

                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)comboLocalidades.SelectedValue,
                    FechaNacimiento = dateTimeFechaDeNacimiento.Value

                };
                await clienteService.AddAsync(cliente);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            comboLocalidades.SelectedIndex = 0;
            tabControl.SelectTab(tabPageLista);

        }
        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;

            if (clienteCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var result = MessageBox.Show($"¿Está seguro que desea eliminar al cliente {clienteCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteCurrent = (Cliente)ListClientes.Current;
                await clienteService.DeleteAsync(clienteCurrent.Id);
                await CargarGrilla();
            }
            clienteCurrent = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarClientes();
        }
        private async void FiltrarClientes()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync(txtFiltro.Text);
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

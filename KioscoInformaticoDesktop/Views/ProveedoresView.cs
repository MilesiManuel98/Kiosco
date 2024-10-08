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
    public partial class ProveedoresView : Form
    {
        IProveedorService proveedorService = new ProveedorService();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListProveedores = new BindingSource();
        Proveedor proveedorCurrent;

        public ProveedoresView()
        {
            InitializeComponent();
            dataGridProveedoresView.DataSource = ListProveedores;
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
            ListProveedores.DataSource = await proveedorService.GetAllAsync();
            dataGridProveedoresView.Columns["LocalidadId"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)ListProveedores.Current;
            txtNombre.Text = proveedorCurrent.Nombre;
            txtDireccion.Text = proveedorCurrent.Direccion;
            txtTelefono.Text = proveedorCurrent.Telefonos;
            txtCbu.Text = proveedorCurrent.Cbu;
            comboLocalidades.SelectedValue = proveedorCurrent.LocalidadId;
            tabControl.SelectTab(tabPageAgregarEditar);
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del proveedore es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (proveedorCurrent != null)
            {
                proveedorCurrent.Nombre = txtNombre.Text;
                proveedorCurrent.Direccion = txtDireccion.Text;
                proveedorCurrent.Telefonos = txtTelefono.Text;
                proveedorCurrent.Cbu = txtCbu.Text;
                proveedorCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
                await proveedorService.UpdateAsync(proveedorCurrent);
                proveedorCurrent = null;
            }
            else
            {

                var proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    Cbu = txtCbu.Text,
                    LocalidadId = (int)comboLocalidades.SelectedValue,
                };
                await proveedorService.AddAsync(proveedor);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCbu.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCbu.Text = string.Empty;
            comboLocalidades.SelectedIndex = 0;
            tabControl.SelectTab(tabPageLista);

        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)ListProveedores.Current;

            if (proveedorCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var result = MessageBox.Show($"¿Está seguro que desea eliminar al proveedor {proveedorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                proveedorCurrent = (Proveedor)ListProveedores.Current;
                await proveedorService.DeleteAsync(proveedorCurrent.Id);
                await CargarGrilla();
            }
            proveedorCurrent = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }
        private async void FiltrarProveedores()
        {
            ListProveedores.DataSource = await proveedorService.GetAllAsync(txtFiltro.Text);
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

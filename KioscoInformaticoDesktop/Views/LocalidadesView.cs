using KioscoInformaticoDesktop.DataContext;
using KioscoInformaticoServices.Interfaces;
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
    public partial class LocalidadesView : Form
    {
        IGenericService<Localidad> localidadService = new GenericService<Localidad>();
        BindingSource ListLocalidades = new BindingSource();
        List<Localidad> ListaFiltrada = new List<Localidad>();
        Localidad localidadCurrent;
        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidadesView.DataSource = ListLocalidades;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ListLocalidades.DataSource = await localidadService.GetAllAsync();
            ListaFiltrada = (List<Localidad>)ListLocalidades.DataSource;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                await localidadService.UpdateAsync(localidadCurrent);
                localidadCurrent = null;
            }
            else
            {
                var localidad = new Localidad
                {
                    Nombre = txtNombre.Text
                };
                await localidadService.AddAsync(localidadCurrent);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)ListLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);

        }



        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private void FiltrarLocalidades()
        {
            var localidadesFiltradas = ListaFiltrada.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text)).ToList();
            ListLocalidades.DataSource = localidadesFiltradas;
        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void iconButtonEliminar_ClickAsync(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad {localidadCurrent.Nombre} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                localidadCurrent = (Localidad)ListLocalidades.Current;
                await localidadService.DeleteAsync(localidadCurrent.Id);
                await CargarGrilla();
            }
            localidadCurrent = null;
        }
    }
}

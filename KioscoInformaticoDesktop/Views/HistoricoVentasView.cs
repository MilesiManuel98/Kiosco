﻿using KioscoInformaticoDesktop.ExtensionMethods;
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
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class HistoricoVentasView : Form
    {
        GenericService<Venta> ventaService = new GenericService<Venta>();
        List<Venta> ventas = new List<Venta>();
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            ventas = await ventaService.GetAllAsync();
            DisplayDataGridFilter();
            CalculeTotal();
        }

        private void CalculeTotal()
        {
            if (checkFiltrado.Checked)
                numericTotalFacturado.Value = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value && venta.Fecha <= dateTimeHasta.Value).Sum(venta => venta.Total);
            else
                numericTotalFacturado.Value = ventas.Sum(venta => venta.Total);
        }

        private void DisplayDataGrid()
        {
            dataGridVentas.DataSource = ventas;
            dataGridVentas.OcultarColumnas(new string[] { "Id", "ClienteId", "Eliminado","DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
        }
        private void checkFiltrado_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Visible = checkFiltrado.Checked;
            if (checkFiltrado.Checked)
            {
                dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimeHasta.Value = DateTime.Now;
                DisplayDataGridFilter();
                CalculeTotal();
            }
            else
            {
                DisplayDataGrid();
                CalculeTotal();
            }
        }

        private void DisplayDataGridFilter()
        {
            
            dataGridVentas.DataSource = ventas.Where(venta=>venta.Fecha>=dateTimeDesde.Value && venta.Fecha<= dateTimeHasta.Value).ToList();
            dataGridVentas.OcultarColumnas(new string[] { "Id", "ClienteId", "Eliminado", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            DisplayDataGridFilter();
            CalculeTotal();
        }
    }
}

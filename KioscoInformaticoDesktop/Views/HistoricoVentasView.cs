using KioscoInformaticoDesktop.ExtensionMethods;
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
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            dataGridVentas.DataSource = await ventaService.GetAllAsync();
            dataGridVentas.OcultarColumnas(new string[] { "Id", "ClienteId", "Eliminado" });
        }
    }
}

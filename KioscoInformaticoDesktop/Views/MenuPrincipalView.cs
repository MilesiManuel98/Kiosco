using KioscoInformaticoDesktop.ViewReport;
using KioscoInformaticoDesktop.Views;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void MenuItemSalirDelSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir del sistema?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void MenuItemProductos_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void MenuItemProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.ShowDialog();
        }

        private void MenuItemListadoLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesViewReport localidadesViewReport = new LocalidadesViewReport();
            localidadesViewReport.ShowDialog();
        }
    }
}

namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuItemPrincipal = new FontAwesome.Sharp.IconMenuItem();
            MenuItemVentas = new FontAwesome.Sharp.IconMenuItem();
            MenuItemBases = new FontAwesome.Sharp.IconMenuItem();
            MenuItemLocalidades = new FontAwesome.Sharp.IconMenuItem();
            MenuItemProductos = new FontAwesome.Sharp.IconMenuItem();
            MenuItemClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuItemProveedores = new FontAwesome.Sharp.IconMenuItem();
            MenuItemSalir = new FontAwesome.Sharp.IconMenuItem();
            MenuItemSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListados = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListadoLocalidades = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListadoClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListadoVentas = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolHistoricoVentas = new FontAwesome.Sharp.IconToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemPrincipal, MenuItemBases, MenuItemSalir, MenuItemListados });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemPrincipal
            // 
            MenuItemPrincipal.DropDownItems.AddRange(new ToolStripItem[] { MenuItemVentas });
            MenuItemPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuItemPrincipal.IconColor = Color.Black;
            MenuItemPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemPrincipal.Name = "MenuItemPrincipal";
            MenuItemPrincipal.Size = new Size(128, 52);
            MenuItemPrincipal.Text = "Principal";
            // 
            // MenuItemVentas
            // 
            MenuItemVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            MenuItemVentas.IconColor = Color.Black;
            MenuItemVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemVentas.IconSize = 28;
            MenuItemVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemVentas.Name = "MenuItemVentas";
            MenuItemVentas.Size = new Size(143, 34);
            MenuItemVentas.Text = "Ventas";
            MenuItemVentas.Click += MenuItemVentas_Click;
            // 
            // MenuItemBases
            // 
            MenuItemBases.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLocalidades, MenuItemProductos, MenuItemClientes, MenuItemProveedores });
            MenuItemBases.IconChar = FontAwesome.Sharp.IconChar.Database;
            MenuItemBases.IconColor = Color.Black;
            MenuItemBases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemBases.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemBases.Name = "MenuItemBases";
            MenuItemBases.Size = new Size(108, 52);
            MenuItemBases.Text = "Bases";
            // 
            // MenuItemLocalidades
            // 
            MenuItemLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            MenuItemLocalidades.IconColor = Color.Black;
            MenuItemLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemLocalidades.IconSize = 28;
            MenuItemLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemLocalidades.Name = "MenuItemLocalidades";
            MenuItemLocalidades.Size = new Size(182, 34);
            MenuItemLocalidades.Text = "Localidades";
            MenuItemLocalidades.Click += MenuItemLocalidades_Click;
            // 
            // MenuItemProductos
            // 
            MenuItemProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            MenuItemProductos.IconColor = Color.Black;
            MenuItemProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemProductos.IconSize = 28;
            MenuItemProductos.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemProductos.Name = "MenuItemProductos";
            MenuItemProductos.Size = new Size(182, 34);
            MenuItemProductos.Text = "Productos";
            MenuItemProductos.Click += MenuItemProductos_Click;
            // 
            // MenuItemClientes
            // 
            MenuItemClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            MenuItemClientes.IconColor = Color.Black;
            MenuItemClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemClientes.IconSize = 28;
            MenuItemClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemClientes.Name = "MenuItemClientes";
            MenuItemClientes.Size = new Size(182, 34);
            MenuItemClientes.Text = "Clientes";
            MenuItemClientes.Click += clientesToolStripMenuItem_Click;
            // 
            // MenuItemProveedores
            // 
            MenuItemProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            MenuItemProveedores.IconColor = Color.Black;
            MenuItemProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemProveedores.IconSize = 28;
            MenuItemProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemProveedores.Name = "MenuItemProveedores";
            MenuItemProveedores.Size = new Size(182, 34);
            MenuItemProveedores.Text = "Proveedores";
            MenuItemProveedores.Click += MenuItemProveedores_Click;
            // 
            // MenuItemSalir
            // 
            MenuItemSalir.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalirDelSistema });
            MenuItemSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            MenuItemSalir.IconColor = Color.Black;
            MenuItemSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemSalir.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemSalir.Name = "MenuItemSalir";
            MenuItemSalir.Size = new Size(100, 52);
            MenuItemSalir.Text = "Salir";
            // 
            // MenuItemSalirDelSistema
            // 
            MenuItemSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            MenuItemSalirDelSistema.IconColor = Color.Black;
            MenuItemSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemSalirDelSistema.IconSize = 32;
            MenuItemSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemSalirDelSistema.Name = "MenuItemSalirDelSistema";
            MenuItemSalirDelSistema.Size = new Size(214, 38);
            MenuItemSalirDelSistema.Text = "Salir del Sistema";
            MenuItemSalirDelSistema.Click += MenuItemSalirDelSistema_Click;
            // 
            // MenuItemListados
            // 
            MenuItemListados.DropDownItems.AddRange(new ToolStripItem[] { MenuItemListadoLocalidades, MenuItemListadoClientes, MenuItemListadoVentas });
            MenuItemListados.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            MenuItemListados.IconColor = Color.Black;
            MenuItemListados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListados.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListados.Name = "MenuItemListados";
            MenuItemListados.Size = new Size(125, 52);
            MenuItemListados.Text = "Listados";
            // 
            // MenuItemListadoLocalidades
            // 
            MenuItemListadoLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            MenuItemListadoLocalidades.IconColor = Color.Black;
            MenuItemListadoLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListadoLocalidades.IconSize = 28;
            MenuItemListadoLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListadoLocalidades.Name = "MenuItemListadoLocalidades";
            MenuItemListadoLocalidades.Size = new Size(179, 34);
            MenuItemListadoLocalidades.Text = "Localidades";
            MenuItemListadoLocalidades.Click += MenuItemListadoLocalidades_Click;
            // 
            // MenuItemListadoClientes
            // 
            MenuItemListadoClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            MenuItemListadoClientes.IconColor = Color.Black;
            MenuItemListadoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListadoClientes.IconSize = 28;
            MenuItemListadoClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListadoClientes.Name = "MenuItemListadoClientes";
            MenuItemListadoClientes.Size = new Size(179, 34);
            MenuItemListadoClientes.Text = "Clientes";
            MenuItemListadoClientes.Click += MenuItemListadoClientes_Click;
            // 
            // MenuItemListadoVentas
            // 
            MenuItemListadoVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            MenuItemListadoVentas.IconColor = Color.Black;
            MenuItemListadoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListadoVentas.IconSize = 28;
            MenuItemListadoVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListadoVentas.Name = "MenuItemListadoVentas";
            MenuItemListadoVentas.Size = new Size(179, 34);
            MenuItemListadoVentas.Text = "Ventas";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolHistoricoVentas });
            toolStrip1.Location = new Point(0, 58);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolHistoricoVentas
            // 
            iconToolHistoricoVentas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolHistoricoVentas.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconToolHistoricoVentas.IconColor = Color.Black;
            iconToolHistoricoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolHistoricoVentas.ImageScaling = ToolStripItemImageScaling.None;
            iconToolHistoricoVentas.ImageTransparentColor = Color.Magenta;
            iconToolHistoricoVentas.Name = "iconToolHistoricoVentas";
            iconToolHistoricoVentas.Size = new Size(52, 52);
            iconToolHistoricoVentas.Text = "Historico Ventas";
            iconToolHistoricoVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolHistoricoVentas.Click += iconToolHistoricoVentas_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informatico Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuItemPrincipal;
        private FontAwesome.Sharp.IconMenuItem MenuItemSalir;
        private FontAwesome.Sharp.IconMenuItem MenuItemBases;
        private FontAwesome.Sharp.IconMenuItem MenuItemSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem MenuItemLocalidades;
        private FontAwesome.Sharp.IconMenuItem MenuItemProductos;
        private FontAwesome.Sharp.IconMenuItem MenuItemClientes;
        private FontAwesome.Sharp.IconMenuItem MenuItemProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuItemListados;
        private FontAwesome.Sharp.IconMenuItem MenuItemListadoClientes;
        private FontAwesome.Sharp.IconMenuItem MenuItemListadoLocalidades;
        private FontAwesome.Sharp.IconMenuItem MenuItemVentas;
        private FontAwesome.Sharp.IconMenuItem MenuItemListadoVentas;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolHistoricoVentas;
    }
}

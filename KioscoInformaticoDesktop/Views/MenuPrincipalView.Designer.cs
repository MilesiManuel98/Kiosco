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
            MenuItemBases = new FontAwesome.Sharp.IconMenuItem();
            MenuItemLocalidades = new FontAwesome.Sharp.IconMenuItem();
            MenuItemProductos = new FontAwesome.Sharp.IconMenuItem();
            MenuItemClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuItemProveedores = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuItemSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListadoClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuItemListadoLocalidades = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemPrincipal, MenuItemBases, iconMenuItem2, iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemPrincipal
            // 
            MenuItemPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuItemPrincipal.IconColor = Color.Black;
            MenuItemPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemPrincipal.Name = "MenuItemPrincipal";
            MenuItemPrincipal.Size = new Size(128, 52);
            MenuItemPrincipal.Text = "Principal";
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
            MenuItemLocalidades.Size = new Size(232, 34);
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
            MenuItemProductos.Size = new Size(232, 34);
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
            MenuItemClientes.Size = new Size(232, 34);
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
            MenuItemProveedores.Size = new Size(232, 34);
            MenuItemProveedores.Text = "Proveedores";
            MenuItemProveedores.Click += MenuItemProveedores_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(100, 52);
            iconMenuItem2.Text = "Salir";
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
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { MenuItemListadoLocalidades, MenuItemListadoClientes });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(97, 52);
            iconMenuItem1.Text = "Listados";
            // 
            // MenuItemListadoClientes
            // 
            MenuItemListadoClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            MenuItemListadoClientes.IconColor = Color.Black;
            MenuItemListadoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListadoClientes.IconSize = 28;
            MenuItemListadoClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListadoClientes.Name = "MenuItemListadoClientes";
            MenuItemListadoClientes.Size = new Size(232, 34);
            MenuItemListadoClientes.Text = "Clientes";
            MenuItemListadoClientes.Click += MenuItemListadoClientes_Click;
            // 
            // MenuItemListadoLocalidades
            // 
            MenuItemListadoLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            MenuItemListadoLocalidades.IconColor = Color.Black;
            MenuItemListadoLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemListadoLocalidades.IconSize = 28;
            MenuItemListadoLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemListadoLocalidades.Name = "MenuItemListadoLocalidades";
            MenuItemListadoLocalidades.Size = new Size(232, 34);
            MenuItemListadoLocalidades.Text = "Localidades";
            MenuItemListadoLocalidades.Click += MenuItemListadoLocalidades_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuItemPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem MenuItemBases;
        private FontAwesome.Sharp.IconMenuItem MenuItemSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem MenuItemLocalidades;
        private FontAwesome.Sharp.IconMenuItem MenuItemProductos;
        private FontAwesome.Sharp.IconMenuItem MenuItemClientes;
        private FontAwesome.Sharp.IconMenuItem MenuItemProveedores;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MenuItemListadoClientes;
        private FontAwesome.Sharp.IconMenuItem MenuItemListadoLocalidades;
    }
}

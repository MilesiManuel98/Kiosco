namespace KioscoInformaticoDesktop.Views
{
    partial class ClientesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            dataGridClientesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            txtPrecio = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 69);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(231, 41);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(0, 77);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1029, 589);
            tabControl.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnSalir);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(iconButtonEliminar);
            tabPageLista.Controls.Add(iconButtonEditar);
            tabPageLista.Controls.Add(iconButtonAgregar);
            tabPageLista.Controls.Add(dataGridClientesView);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Margin = new Padding(3, 4, 3, 4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3, 4, 3, 4);
            tabPageLista.Size = new Size(1021, 556);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.Black;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(888, 473);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 75);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.White;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.TopCenter;
            btnBuscar.Location = new Point(888, 21);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 75);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 21);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 8;
            label3.Text = "Buscar Producto";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(8, 44);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(836, 27);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEliminar.BackColor = Color.White;
            iconButtonEliminar.ForeColor = Color.Black;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButtonEliminar.IconColor = Color.Black;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.IconSize = 44;
            iconButtonEliminar.ImageAlign = ContentAlignment.TopCenter;
            iconButtonEliminar.Location = new Point(888, 357);
            iconButtonEliminar.Margin = new Padding(3, 4, 3, 4);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(86, 75);
            iconButtonEliminar.TabIndex = 6;
            iconButtonEliminar.Text = "Eli&minar";
            iconButtonEliminar.TextAlign = ContentAlignment.BottomCenter;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEditar.BackColor = Color.White;
            iconButtonEditar.ForeColor = Color.Black;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButtonEditar.IconColor = Color.Black;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.IconSize = 45;
            iconButtonEditar.ImageAlign = ContentAlignment.TopCenter;
            iconButtonEditar.Location = new Point(888, 242);
            iconButtonEditar.Margin = new Padding(3, 4, 3, 4);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(86, 75);
            iconButtonEditar.TabIndex = 5;
            iconButtonEditar.Text = "&Editar";
            iconButtonEditar.TextAlign = ContentAlignment.BottomCenter;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click_1;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonAgregar.BackColor = Color.White;
            iconButtonAgregar.ForeColor = Color.Black;
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.Black;
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.ImageAlign = ContentAlignment.TopCenter;
            iconButtonAgregar.Location = new Point(888, 125);
            iconButtonAgregar.Margin = new Padding(3, 4, 3, 4);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(86, 75);
            iconButtonAgregar.TabIndex = 4;
            iconButtonAgregar.Text = "&Agregar";
            iconButtonAgregar.TextAlign = ContentAlignment.BottomCenter;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // dataGridClientesView
            // 
            dataGridClientesView.AllowUserToAddRows = false;
            dataGridClientesView.AllowUserToDeleteRows = false;
            dataGridClientesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientesView.Location = new Point(3, 101);
            dataGridClientesView.Margin = new Padding(3, 4, 3, 4);
            dataGridClientesView.Name = "dataGridClientesView";
            dataGridClientesView.ReadOnly = true;
            dataGridClientesView.RowHeadersWidth = 51;
            dataGridClientesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientesView.Size = new Size(841, 451);
            dataGridClientesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtTelefono);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Margin = new Padding(3, 4, 3, 4);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3, 4, 3, 4);
            tabPageAgregarEditar.Size = new Size(1021, 556);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(445, 248);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(225, 27);
            txtTelefono.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 251);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(445, 163);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(225, 27);
            txtDireccion.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Location = new Point(339, 166);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(75, 20);
            txtPrecio.TabIndex = 12;
            txtPrecio.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(587, 367);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 80);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(317, 367);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 80);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(445, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 669);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientesView";
            Text = "ClientesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridClientesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private Label txtPrecio;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label3;
        private TextBox txtFiltro;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDireccion;
    }
}
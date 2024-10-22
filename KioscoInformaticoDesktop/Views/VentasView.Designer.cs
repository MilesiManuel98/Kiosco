namespace KioscoInformaticoDesktop.Views
{
    partial class VentasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimeFecha = new DateTimePicker();
            label1 = new Label();
            comboBoxFormasDePago = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            label4 = new Label();
            comboBoxProductos = new ComboBox();
            panel1 = new Panel();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            numericCantidad = new NumericUpDown();
            label5 = new Label();
            numericPrecio = new NumericUpDown();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            gridDetallesVenta = new DataGridView();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(764, 26);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(102, 27);
            dateTimeFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(708, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // comboBoxFormasDePago
            // 
            comboBoxFormasDePago.FormattingEnabled = true;
            comboBoxFormasDePago.Location = new Point(12, 42);
            comboBoxFormasDePago.Name = "comboBoxFormasDePago";
            comboBoxFormasDePago.Size = new Size(197, 28);
            comboBoxFormasDePago.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 17);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(252, 42);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(294, 28);
            comboBoxClientes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(3, 39);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(271, 28);
            comboBoxProductos.TabIndex = 6;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericPrecio);
            panel1.Controls.Add(comboBoxProductos);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 102);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(597, 16);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 13;
            label7.Text = "Subtotal:";
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(597, 40);
            numericSubtotal.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(121, 27);
            numericSubtotal.TabIndex = 12;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 16);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(459, 40);
            numericCantidad.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(121, 27);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 16);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Precio:";
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(321, 40);
            numericPrecio.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(121, 27);
            numericPrecio.TabIndex = 8;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 50;
            btnAgregar.ImageAlign = ContentAlignment.TopCenter;
            btnAgregar.Location = new Point(764, 192);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 75);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gridDetallesVenta
            // 
            gridDetallesVenta.AllowUserToAddRows = false;
            gridDetallesVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            gridDetallesVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridDetallesVenta.DefaultCellStyle = dataGridViewCellStyle2;
            gridDetallesVenta.Location = new Point(12, 191);
            gridDetallesVenta.Name = "gridDetallesVenta";
            gridDetallesVenta.ReadOnly = true;
            gridDetallesVenta.RowHeadersWidth = 51;
            gridDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetallesVenta.Size = new Size(746, 233);
            gridDetallesVenta.TabIndex = 9;
            gridDetallesVenta.DataBindingComplete += gridDetallesVenta_DataBindingComplete;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitar.BackColor = Color.White;
            btnQuitar.ForeColor = Color.Black;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 44;
            btnQuitar.ImageAlign = ContentAlignment.TopCenter;
            btnQuitar.Location = new Point(764, 315);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(102, 75);
            btnQuitar.TabIndex = 15;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextAlign = ContentAlignment.BottomCenter;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 447);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 15;
            label8.Text = "Total Factura:";
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(557, 471);
            numericTotal.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(121, 27);
            numericTotal.TabIndex = 14;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizarVenta.IconColor = Color.Black;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.IconSize = 50;
            btnFinalizarVenta.ImageAlign = ContentAlignment.TopCenter;
            btnFinalizarVenta.Location = new Point(708, 436);
            btnFinalizarVenta.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(158, 75);
            btnFinalizarVenta.TabIndex = 16;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.BottomCenter;
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 524);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label8);
            Controls.Add(btnAgregar);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(gridDetallesVenta);
            Controls.Add(label3);
            Controls.Add(comboBoxClientes);
            Controls.Add(label2);
            Controls.Add(comboBoxFormasDePago);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Name = "VentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFecha;
        private Label label1;
        private ComboBox comboBoxFormasDePago;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Label label4;
        private ComboBox comboBoxProductos;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericPrecio;
        private Label label6;
        private NumericUpDown numericCantidad;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView gridDetallesVenta;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
    }
}
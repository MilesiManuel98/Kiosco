namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            dataGridVentas = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            checkFiltrado = new CheckBox();
            panelFiltrado = new Panel();
            label3 = new Label();
            dateTimeHasta = new DateTimePicker();
            label2 = new Label();
            dateTimeDesde = new DateTimePicker();
            btnFiltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panel1.SuspendLayout();
            panelFiltrado.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVentas.Location = new Point(0, 132);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersWidth = 51;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(799, 234);
            dataGridVentas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 69);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(439, 41);
            label1.TabIndex = 0;
            label1.Text = "Historico Ventas";
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Location = new Point(11, 84);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(115, 24);
            checkFiltrado.TabIndex = 3;
            checkFiltrado.Text = "Activar Filtro";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltrado_CheckedChanged;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BackColor = SystemColors.ButtonFace;
            panelFiltrado.BorderStyle = BorderStyle.FixedSingle;
            panelFiltrado.Controls.Add(btnFiltar);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Location = new Point(127, 76);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(661, 38);
            panelFiltrado.TabIndex = 9;
            panelFiltrado.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 8);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Hasta:";
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Enabled = false;
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(296, 3);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(102, 27);
            dateTimeHasta.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 8);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Desde:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Enabled = false;
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(89, 3);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(102, 27);
            dateTimeDesde.TabIndex = 2;
            // 
            // btnFiltar
            // 
            btnFiltar.Location = new Point(491, 3);
            btnFiltar.Name = "btnFiltar";
            btnFiltar.Size = new Size(94, 29);
            btnFiltar.TabIndex = 10;
            btnFiltar.Text = "Filtrar";
            btnFiltar.UseVisualStyleBackColor = true;
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFiltrado);
            Controls.Add(checkFiltrado);
            Controls.Add(panel1);
            Controls.Add(dataGridVentas);
            Name = "HistoricoVentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HistorialVentasView";
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridVentas;
        private Panel panel1;
        private Label label1;
        private CheckBox checkFiltrado;
        private Panel panelFiltrado;
        private Label label2;
        private DateTimePicker dateTimeDesde;
        private Label label3;
        private DateTimePicker dateTimeHasta;
        private Button btnFiltar;
    }
}
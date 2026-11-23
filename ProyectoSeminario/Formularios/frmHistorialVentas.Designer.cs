namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmHistorialVentas
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
            lblDesde = new Label();
            lblHasta = new Label();
            lblTitulo = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnFiltrar = new Button();
            btnMostrarTodas = new Button();
            dgvVentas = new DataGridView();
            btnVerDetalle = new Button();
            btnAnularVenta = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(17, 74);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(285, 74);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(17, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Historial de Ventas";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(17, 92);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(285, 92);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(315, 134);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnMostrarTodas
            // 
            btnMostrarTodas.Location = new Point(396, 134);
            btnMostrarTodas.Name = "btnMostrarTodas";
            btnMostrarTodas.Size = new Size(89, 23);
            btnMostrarTodas.TabIndex = 6;
            btnMostrarTodas.Text = "Mostrar todas";
            btnMostrarTodas.UseVisualStyleBackColor = true;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(17, 163);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(950, 300);
            dgvVentas.TabIndex = 7;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(559, 469);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(75, 23);
            btnVerDetalle.TabIndex = 8;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnAnularVenta
            // 
            btnAnularVenta.Location = new Point(640, 469);
            btnAnularVenta.Name = "btnAnularVenta";
            btnAnularVenta.Size = new Size(88, 23);
            btnAnularVenta.TabIndex = 9;
            btnAnularVenta.Text = "Anular venta";
            btnAnularVenta.UseVisualStyleBackColor = true;
            btnAnularVenta.Click += btnAnularVenta_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(734, 469);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1034, 611);
            Controls.Add(btnActualizar);
            Controls.Add(btnAnularVenta);
            Controls.Add(btnVerDetalle);
            Controls.Add(dgvVentas);
            Controls.Add(btnMostrarTodas);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblTitulo);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Name = "frmHistorialVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historial de Ventas";
            Load += frmHistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesde;
        private Label lblHasta;
        private Label lblTitulo;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnFiltrar;
        private Button btnMostrarTodas;
        private DataGridView dgvVentas;
        private Button btnVerDetalle;
        private Button btnAnularVenta;
        private Button btnActualizar;
    }
}
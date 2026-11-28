namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmHistorialVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelEncabezado = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnFiltrar = new Button();
            btnMostrarTodas = new Button();
            lblSeccion = new Label();
            dgvVentas = new DataGridView();
            btnVerDetalle = new Button();
            btnAnularVenta = new Button();
            btnActualizar = new Button();
            panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            //
            // panelEncabezado
            //
            panelEncabezado.BackColor = Color.FromArgb(36, 37, 42);
            panelEncabezado.Controls.Add(lblSubtitulo);
            panelEncabezado.Controls.Add(lblTitulo);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1048, 82);
            panelEncabezado.TabIndex = 0;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(237, 146, 81);
            lblSubtitulo.Location = new Point(32, 51);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(244, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "HAMBURGUESERÍA  |  PROYECTO SEMINARIO";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de ventas";
            //
            // lblDesde
            //
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.FromArgb(45, 40, 38);
            lblDesde.Location = new Point(30, 112);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(54, 19);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde";
            //
            // lblHasta
            //
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.FromArgb(45, 40, 38);
            lblHasta.Location = new Point(286, 112);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(49, 19);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta";
            //
            // dtpDesde
            //
            dtpDesde.Font = new Font("Segoe UI", 10F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(32, 136);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(225, 25);
            dtpDesde.TabIndex = 3;
            //
            // dtpHasta
            //
            dtpHasta.Font = new Font("Segoe UI", 10F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(288, 136);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(225, 25);
            dtpHasta.TabIndex = 4;
            //
            // btnFiltrar
            //
            btnFiltrar.BackColor = Color.FromArgb(151, 40, 36);
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(541, 129);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(135, 38);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            //
            // btnMostrarTodas
            //
            btnMostrarTodas.BackColor = Color.FromArgb(226, 219, 213);
            btnMostrarTodas.Cursor = Cursors.Hand;
            btnMostrarTodas.FlatAppearance.BorderSize = 0;
            btnMostrarTodas.FlatStyle = FlatStyle.Flat;
            btnMostrarTodas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMostrarTodas.ForeColor = Color.FromArgb(54, 41, 37);
            btnMostrarTodas.Location = new Point(690, 129);
            btnMostrarTodas.Name = "btnMostrarTodas";
            btnMostrarTodas.Size = new Size(160, 38);
            btnMostrarTodas.TabIndex = 6;
            btnMostrarTodas.Text = "Mostrar todas";
            btnMostrarTodas.UseVisualStyleBackColor = false;
            btnMostrarTodas.Click += btnMostrarTodas_Click;
            //
            // lblSeccion
            //
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSeccion.ForeColor = Color.FromArgb(46, 39, 36);
            lblSeccion.Location = new Point(29, 194);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(173, 25);
            lblSeccion.TabIndex = 7;
            lblSeccion.Text = "Ventas registradas";
            //
            // dgvVentas
            //
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVentas.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(136, 39, 35),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(136, 39, 35),
                SelectionForeColor = Color.White,
                WrapMode = DataGridViewTriState.False
            };
            dgvVentas.ColumnHeadersHeight = 42;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(48, 43, 42),
                Font = new Font("Segoe UI", 10F),
                SelectionBackColor = Color.FromArgb(248, 222, 211),
                SelectionForeColor = Color.FromArgb(55, 33, 29),
                Padding = new Padding(5, 0, 5, 0)
            };
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(238, 232, 228);
            dgvVentas.Location = new Point(32, 231);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowTemplate.Height = 34;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(982, 345);
            dgvVentas.TabIndex = 8;
            //
            // btnVerDetalle
            //
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerDetalle.BackColor = Color.FromArgb(226, 219, 213);
            btnVerDetalle.Cursor = Cursors.Hand;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerDetalle.ForeColor = Color.FromArgb(54, 41, 37);
            btnVerDetalle.Location = new Point(544, 602);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(145, 42);
            btnVerDetalle.TabIndex = 9;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            //
            // btnAnularVenta
            //
            btnAnularVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnularVenta.BackColor = Color.FromArgb(151, 40, 36);
            btnAnularVenta.Cursor = Cursors.Hand;
            btnAnularVenta.FlatAppearance.BorderSize = 0;
            btnAnularVenta.FlatStyle = FlatStyle.Flat;
            btnAnularVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnularVenta.ForeColor = Color.White;
            btnAnularVenta.Location = new Point(704, 602);
            btnAnularVenta.Name = "btnAnularVenta";
            btnAnularVenta.Size = new Size(145, 42);
            btnAnularVenta.TabIndex = 10;
            btnAnularVenta.Text = "Anular venta";
            btnAnularVenta.UseVisualStyleBackColor = false;
            btnAnularVenta.Click += btnAnularVenta_Click;
            //
            // btnActualizar
            //
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(193, 69, 43);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(864, 602);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 42);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            //
            // frmHistorialVentas
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = false;
            BackColor = Color.FromArgb(246, 243, 238);
            ClientSize = new Size(1048, 679);
            Controls.Add(btnActualizar);
            Controls.Add(btnAnularVenta);
            Controls.Add(btnVerDetalle);
            Controls.Add(dgvVentas);
            Controls.Add(lblSeccion);
            Controls.Add(btnMostrarTodas);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(panelEncabezado);
            MinimumSize = new Size(880, 600);
            Name = "frmHistorialVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historial de Ventas";
            Load += frmHistorialVentas_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEncabezado;
        private Label lblSubtitulo;
        private Label lblSeccion;
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

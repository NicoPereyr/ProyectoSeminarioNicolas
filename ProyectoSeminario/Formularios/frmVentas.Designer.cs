namespace ProyectoSeminario.Windows
{
    partial class frmVentas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelCabecera = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnVerHistorial = new Button();
            lblSeccion = new Label();
            lblEmpleado = new Label();
            cboEmpleados = new ComboBox();
            lblFecha = new Label();
            dtpFechaVenta = new DateTimePicker();
            lblProducto = new Label();
            lblCantidad = new Label();
            cboProductos = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            dgvDetalleVenta = new DataGridView();
            colProductoId = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            lblTotalTexto = new Label();
            lblTotal = new Label();
            btnQuitarProducto = new Button();
            btnGuardarVenta = new Button();
            btnCancelar = new Button();
            panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // panelCabecera
            // 
            panelCabecera.BackColor = Color.FromArgb(36, 37, 42);
            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);
            panelCabecera.Controls.Add(btnVerHistorial);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(884, 80);
            panelCabecera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(26, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar nueva venta";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(237, 146, 81);
            lblSubtitulo.Location = new Point(29, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(440, 22);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "HAMBURGUESERÍA  |  PROYECTO SEMINARIO";
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerHistorial.BackColor = Color.FromArgb(139, 43, 39);
            btnVerHistorial.Cursor = Cursors.Hand;
            btnVerHistorial.FlatAppearance.BorderSize = 0;
            btnVerHistorial.FlatStyle = FlatStyle.Flat;
            btnVerHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerHistorial.ForeColor = Color.White;
            btnVerHistorial.Location = new Point(675, 23);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(178, 36);
            btnVerHistorial.TabIndex = 1;
            btnVerHistorial.Text = "Ver historial";
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeccion.ForeColor = Color.FromArgb(45, 43, 42);
            lblSeccion.Location = new Point(28, 258);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(153, 21);
            lblSeccion.TabIndex = 11;
            lblSeccion.Text = "Detalle de la venta";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmpleado.ForeColor = Color.FromArgb(54, 50, 48);
            lblEmpleado.Location = new Point(28, 106);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(76, 19);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado";
            // 
            // cboEmpleados
            // 
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.Font = new Font("Segoe UI", 11F);
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(28, 132);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(350, 28);
            cboEmpleados.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(54, 50, 48);
            lblFecha.Location = new Point(408, 106);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(109, 19);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha de venta";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaVenta.Enabled = false;
            dtpFechaVenta.Font = new Font("Segoe UI", 11F);
            dtpFechaVenta.Format = DateTimePickerFormat.Custom;
            dtpFechaVenta.Location = new Point(408, 132);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(204, 27);
            dtpFechaVenta.TabIndex = 5;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(54, 50, 48);
            lblProducto.Location = new Point(28, 181);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(71, 19);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(54, 50, 48);
            lblCantidad.Location = new Point(408, 181);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 19);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.Font = new Font("Segoe UI", 11F);
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(28, 206);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(350, 28);
            cboProductos.TabIndex = 7;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 11F);
            nudCantidad.Location = new Point(408, 206);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(96, 27);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(190, 68, 44);
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(546, 201);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(218, 37);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "+ Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 247, 244);
            dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVenta.BackgroundColor = Color.White;
            dgvDetalleVenta.BorderStyle = BorderStyle.None;
            dgvDetalleVenta.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetalleVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 43, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleVenta.ColumnHeadersHeight = 38;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { colProductoId, colProducto, colCantidad, colPrecioUnitario, colSubtotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 227, 213);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(50, 40, 35);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleVenta.EnableHeadersVisualStyles = false;
            dgvDetalleVenta.GridColor = Color.FromArgb(234, 227, 221);
            dgvDetalleVenta.Location = new Point(28, 294);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersVisible = false;
            dgvDetalleVenta.RowTemplate.Height = 32;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(736, 196);
            dgvDetalleVenta.TabIndex = 12;
            // 
            // colProductoId
            // 
            colProductoId.HeaderText = "ID";
            colProductoId.Name = "colProductoId";
            colProductoId.ReadOnly = true;
            colProductoId.Visible = false;
            // 
            // colProducto
            // 
            colProducto.FillWeight = 180F;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.FillWeight = 72F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.FillWeight = 120F;
            colPrecioUnitario.HeaderText = "Precio unitario";
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.FillWeight = 110F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(100, 90, 85);
            lblTotalTexto.Location = new Point(28, 513);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(140, 19);
            lblTotalTexto.TabIndex = 13;
            lblTotalTexto.Text = "TOTAL DE LA VENTA";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(139, 43, 39);
            lblTotal.Location = new Point(26, 535);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(98, 42);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "$0,00";
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuitarProducto.BackColor = Color.FromArgb(232, 225, 219);
            btnQuitarProducto.Cursor = Cursors.Hand;
            btnQuitarProducto.FlatAppearance.BorderSize = 0;
            btnQuitarProducto.FlatStyle = FlatStyle.Flat;
            btnQuitarProducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnQuitarProducto.ForeColor = Color.FromArgb(65, 55, 50);
            btnQuitarProducto.Location = new Point(350, 541);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(140, 40);
            btnQuitarProducto.TabIndex = 15;
            btnQuitarProducto.Text = "Quitar producto";
            btnQuitarProducto.UseVisualStyleBackColor = false;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarVenta.BackColor = Color.FromArgb(139, 43, 39);
            btnGuardarVenta.Cursor = Cursors.Hand;
            btnGuardarVenta.FlatAppearance.BorderSize = 0;
            btnGuardarVenta.FlatStyle = FlatStyle.Flat;
            btnGuardarVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarVenta.ForeColor = Color.White;
            btnGuardarVenta.Location = new Point(631, 541);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(155, 40);
            btnGuardarVenta.TabIndex = 17;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = false;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(232, 225, 219);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(65, 55, 50);
            btnCancelar.Location = new Point(499, 541);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 40);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 238);
            ClientSize = new Size(884, 610);
            Controls.Add(panelCabecera);
            Controls.Add(lblEmpleado);
            Controls.Add(cboEmpleados);
            Controls.Add(lblFecha);
            Controls.Add(dtpFechaVenta);
            Controls.Add(lblProducto);
            Controls.Add(cboProductos);
            Controls.Add(lblCantidad);
            Controls.Add(nudCantidad);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblSeccion);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblTotal);
            Controls.Add(btnQuitarProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarVenta);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(790, 600);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas - Hamburguesería";
            Load += frmVentas_Load;
            panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCabecera;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblEmpleado;
        private ComboBox cboEmpleados;
        private Label lblFecha;
        private DateTimePicker dtpFechaVenta;
        private Label lblTitulo;
        private Label lblProducto;
        private Label lblCantidad;
        private ComboBox cboProductos;
        private NumericUpDown nudCantidad;
        private Button btnAgregarProducto;
        private DataGridView dgvDetalleVenta;
        private DataGridViewTextBoxColumn colProductoId;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colSubtotal;
        private Label lblTotalTexto;
        private Label lblTotal;
        private Button btnQuitarProducto;
        private Button btnGuardarVenta;
        private Button btnCancelar;
        private Button btnVerHistorial;
    }
}
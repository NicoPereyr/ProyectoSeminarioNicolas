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
            lblEmpleado = new Label();
            cboEmpleados = new ComboBox();
            lblFecha = new Label();
            dtpFechaVenta = new DateTimePicker();
            lblTitulo = new Label();
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
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(33, 55);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(63, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(33, 73);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(250, 23);
            cboEmpleados.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(328, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaVenta.Enabled = false;
            dtpFechaVenta.Format = DateTimePickerFormat.Custom;
            dtpFechaVenta.Location = new Point(328, 73);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(180, 23);
            dtpFechaVenta.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(33, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 30);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registrar venta";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(37, 106);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(32, 157);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad:";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(33, 124);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(280, 23);
            cboProductos.TabIndex = 8;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(32, 175);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 23);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(204, 167);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(150, 35);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { colProductoId, colProducto, colCantidad, colPrecioUnitario, colSubtotal });
            dgvDetalleVenta.Location = new Point(14, 208);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersVisible = false;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(600, 180);
            dgvDetalleVenta.TabIndex = 11;
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
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio unitario";
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Location = new Point(14, 422);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(96, 15);
            lblTotalTexto.TabIndex = 12;
            lblTotalTexto.Text = "Total de la venta:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F);
            lblTotal.Location = new Point(14, 449);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 30);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "$0,00";
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Location = new Point(474, 402);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(140, 35);
            btnQuitarProducto.TabIndex = 14;
            btnQuitarProducto.Text = "Quitar producto";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(474, 451);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(140, 35);
            btnGuardarVenta.TabIndex = 15;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(474, 503);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarVenta);
            Controls.Add(btnQuitarProducto);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTexto);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(nudCantidad);
            Controls.Add(cboProductos);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblTitulo);
            Controls.Add(dtpFechaVenta);
            Controls.Add(lblFecha);
            Controls.Add(cboEmpleados);
            Controls.Add(lblEmpleado);
            MaximumSize = new Size(900, 600);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}
namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmProductos
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
            lblTituloProductos = new Label();
            lblSubtituloProductos = new Label();
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbRefrescar = new ToolStripButton();
            panelContenidoProductos = new Panel();
            dgvDatos = new DataGridView();
            colProductos = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewCheckBoxColumn();
            panelNavegacion = new Panel();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            txtCantidadPaginas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboPaginas = new ComboBox();
            panelEncabezado.SuspendLayout();
            topTS.SuspendLayout();
            panelContenidoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelNavegacion.SuspendLayout();
            SuspendLayout();

            // Encabezado oscuro, acorde al menú principal.
            panelEncabezado.BackColor = Color.FromArgb(36, 37, 42);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Height = 115;
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Controls.Add(lblTituloProductos);
            panelEncabezado.Controls.Add(lblSubtituloProductos);

            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloProductos.ForeColor = Color.White;
            lblTituloProductos.Location = new Point(30, 20);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Text = "Gestión de productos";

            lblSubtituloProductos.AutoSize = true;
            lblSubtituloProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtituloProductos.ForeColor = Color.FromArgb(237, 146, 81);
            lblSubtituloProductos.Location = new Point(33, 72);
            lblSubtituloProductos.Name = "lblSubtituloProductos";
            lblSubtituloProductos.Text = "HAMBURGUESERÍA | PROYECTO SEMINARIO";

            // Barra de acciones. Se conservan todos los nombres y eventos.
            topTS.BackColor = Color.FromArgb(246, 243, 238);
            topTS.Dock = DockStyle.Top;
            topTS.GripStyle = ToolStripGripStyle.Hidden;
            topTS.ImageScalingSize = new Size(20, 20);
            topTS.Padding = new Padding(25, 6, 0, 6);
            topTS.AutoSize = false;
            topTS.Height = 64;
            topTS.Name = "topTS";
            topTS.RenderMode = ToolStripRenderMode.System;
            topTS.Items.AddRange(new ToolStripItem[] {
                tsbAgregar, tsbEditar, tsbBorrar, tsbActivar,
                tsbBuscar, tsbRefrescar, tsbFiltrar
            });

            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Text = "Agregar";
            tsbAgregar.ToolTipText = "Agregar";
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAgregar.AutoSize = false;
            tsbAgregar.Size = new Size(94, 38);
            tsbAgregar.Margin = new Padding(3, 0, 5, 0);
            tsbAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbAgregar.ForeColor = Color.White;
            tsbAgregar.BackColor = Color.FromArgb(154, 41, 38);
            tsbAgregar.Click += tsbAgregar_Click;

            tsbEditar.Name = "tsbEditar";
            tsbEditar.Text = "Editar";
            tsbEditar.ToolTipText = "Editar";
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditar.AutoSize = false;
            tsbEditar.Size = new Size(94, 38);
            tsbEditar.Margin = new Padding(3, 0, 5, 0);
            tsbEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbEditar.ForeColor = Color.White;
            tsbEditar.BackColor = Color.FromArgb(154, 41, 38);
            tsbEditar.Click += tsbEditar_Click;

            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Text = "Desactivar";
            tsbBorrar.ToolTipText = "Desactivar";
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbBorrar.AutoSize = false;
            tsbBorrar.Size = new Size(110, 38);
            tsbBorrar.Margin = new Padding(3, 0, 5, 0);
            tsbBorrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbBorrar.ForeColor = Color.White;
            tsbBorrar.BackColor = Color.FromArgb(154, 41, 38);
            tsbBorrar.Click += tsbDesactivar_Click;

            tsbActivar.Name = "tsbActivar";
            tsbActivar.Text = "Activar";
            tsbActivar.ToolTipText = "Activar";
            tsbActivar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbActivar.AutoSize = false;
            tsbActivar.Size = new Size(94, 38);
            tsbActivar.Margin = new Padding(3, 0, 5, 0);
            tsbActivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbActivar.ForeColor = Color.White;
            tsbActivar.BackColor = Color.FromArgb(154, 41, 38);
            tsbActivar.Click += tsbActivar_Click;

            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Text = "Buscar";
            tsbBuscar.ToolTipText = "Buscar";
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbBuscar.AutoSize = false;
            tsbBuscar.Size = new Size(94, 38);
            tsbBuscar.Margin = new Padding(3, 0, 5, 0);
            tsbBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbBuscar.ForeColor = Color.White;
            tsbBuscar.BackColor = Color.FromArgb(190, 72, 46);
            tsbBuscar.Click += tsbBuscar_Click;

            tsbRefrescar.Name = "tsbRefrescar";
            tsbRefrescar.Text = "Actualizar";
            tsbRefrescar.ToolTipText = "Actualizar";
            tsbRefrescar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRefrescar.AutoSize = false;
            tsbRefrescar.Size = new Size(110, 38);
            tsbRefrescar.Margin = new Padding(3, 0, 5, 0);
            tsbRefrescar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbRefrescar.ForeColor = Color.White;
            tsbRefrescar.BackColor = Color.FromArgb(190, 72, 46);
            tsbRefrescar.Click += tsbRefrescar_Click;

            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.ToolTipText = "Filtrar";
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbFiltrar.AutoSize = false;
            tsbFiltrar.Size = new Size(94, 38);
            tsbFiltrar.Margin = new Padding(3, 0, 5, 0);
            tsbFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbFiltrar.ForeColor = Color.White;
            tsbFiltrar.BackColor = Color.FromArgb(119, 119, 119);
            // Aún no tiene evento Click en el formulario original.
            tsbFiltrar.Enabled = false;
            tsbFiltrar.ToolTipText = "Filtro pendiente de implementar";

            // Área de tabla: ocupa automáticamente el espacio disponible.
            panelContenidoProductos.Dock = DockStyle.Fill;
            panelContenidoProductos.Name = "panelContenidoProductos";
            panelContenidoProductos.BackColor = Color.FromArgb(246, 243, 238);
            panelContenidoProductos.Padding = new Padding(26, 15, 26, 16);
            panelContenidoProductos.Controls.Add(dgvDatos);

            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.MultiSelect = false;
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.ColumnHeadersHeight = 45;
            dgvDatos.RowTemplate.Height = 36;
            dgvDatos.GridColor = Color.FromArgb(231, 226, 222);
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 43, 39);
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(139, 43, 39);
            dgvDatos.DefaultCellStyle.BackColor = Color.White;
            dgvDatos.DefaultCellStyle.ForeColor = Color.FromArgb(45, 43, 42);
            dgvDatos.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvDatos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 217, 210);
            dgvDatos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(60, 35, 32);
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(251, 248, 245);
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] {
                colProductos, colCategoria, colPrecio, colActiva
            });

            colProductos.Name = "colProductos";
            colProductos.HeaderText = "Producto";
            colProductos.ReadOnly = true;
            colProductos.SortMode = DataGridViewColumnSortMode.NotSortable;
            colProductos.FillWeight = 170F;

            colCategoria.Name = "colCategoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.ReadOnly = true;
            colCategoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCategoria.FillWeight = 100F;

            colPrecio.Name = "colPrecio";
            colPrecio.HeaderText = "Precio";
            colPrecio.ReadOnly = true;
            colPrecio.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPrecio.FillWeight = 65F;

            colActiva.Name = "colActiva";
            colActiva.HeaderText = "Activo";
            colActiva.ReadOnly = true;
            colActiva.FillWeight = 45F;

            // Pie: paginación.
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Height = 84;
            panelNavegacion.BackColor = Color.FromArgb(235, 230, 225);
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(cboPaginas);

            label1.Name = "label1";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 50, 47);
            label1.Location = new Point(30, 31);
            label1.Text = "Página";

            cboPaginas.Name = "cboPaginas";
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.Font = new Font("Segoe UI", 10F);
            cboPaginas.Location = new Point(92, 27);
            cboPaginas.Size = new Size(76, 28);
            // Su evento se conecta en frmProductos.cs al cargar las páginas.

            label2.Name = "label2";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(182, 31);
            label2.Text = "de";

            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Enabled = false;
            txtCantidadPaginas.Font = new Font("Segoe UI", 10F);
            txtCantidadPaginas.Location = new Point(215, 27);
            txtCantidadPaginas.Size = new Size(72, 28);

            btnPrimero.Name = "btnPrimero";
            btnPrimero.Text = "|<";
            btnPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrimero.BackColor = Color.White;
            btnPrimero.ForeColor = Color.FromArgb(139, 43, 39);
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.Cursor = Cursors.Hand;
            btnPrimero.Location = new Point(390, 20);
            btnPrimero.Size = new Size(72, 42);
            btnPrimero.Click += btnPrimero_Click;

            btnAnterior.Name = "btnAnterior";
            btnAnterior.Text = "<";
            btnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAnterior.BackColor = Color.White;
            btnAnterior.ForeColor = Color.FromArgb(139, 43, 39);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Location = new Point(472, 20);
            btnAnterior.Size = new Size(72, 42);
            btnAnterior.Click += btnAnterior_Click;

            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Text = ">";
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.ForeColor = Color.FromArgb(139, 43, 39);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Location = new Point(554, 20);
            btnSiguiente.Size = new Size(72, 42);
            btnSiguiente.Click += btnSiguiente_Click;

            btnUltimo.Name = "btnUltimo";
            btnUltimo.Text = ">|";
            btnUltimo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUltimo.BackColor = Color.White;
            btnUltimo.ForeColor = Color.FromArgb(139, 43, 39);
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.Cursor = Cursors.Hand;
            btnUltimo.Location = new Point(636, 20);
            btnUltimo.Size = new Size(72, 42);
            btnUltimo.Click += btnUltimo_Click;

            // Formulario.
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = false;
            BackColor = Color.FromArgb(246, 243, 238);
            ClientSize = new Size(1040, 720);
            Name = "frmProductos";
            Text = "Gestión de productos";
            // Orden de Dock: encabezado, acciones, paginación y grilla.
            Controls.Add(panelContenidoProductos);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Controls.Add(panelEncabezado);
            Load += frmProductos_Load;

            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelContenidoProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private Panel panelNavegacion;
        private DataGridView dgvDatos;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private Label label2;
        private Label label1;
        private ComboBox cboPaginas;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActivar;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbRefrescar;
        private DataGridViewTextBoxColumn colProductos;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewCheckBoxColumn colActiva;
        private Panel panelEncabezado;
        private Label lblTituloProductos;
        private Label lblSubtituloProductos;
        private Panel panelContenidoProductos;
    }
}

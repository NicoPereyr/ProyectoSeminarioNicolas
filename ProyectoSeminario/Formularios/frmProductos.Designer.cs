namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            panelNavegacion = new Panel();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            txtCantidadPaginas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboPaginas = new ComboBox();
            dgvDatos = new DataGridView();
            colProductos = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewTextBoxColumn();
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // topTS
            // 
            topTS.BackColor = Color.PaleTurquoise;
            topTS.ImageScalingSize = new Size(32, 32);
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbFiltrar, tsbBorrar, tsbActivar, tsbBuscar });
            topTS.Location = new Point(0, 0);
            topTS.Name = "topTS";
            topTS.Size = new Size(800, 39);
            topTS.TabIndex = 1;
            topTS.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAgregar.Image = Properties.Resources.icons8_plus___96px;
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(36, 36);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = Properties.Resources.icons8_pencil_96px;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(36, 36);
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFiltrar.Image = Properties.Resources.icons8_menu_96px;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(36, 36);
            tsbFiltrar.Text = "Filtrar";
            // 
            // tsbBorrar
            // 
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBorrar.Image = Properties.Resources.icons8_cancel_96px;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(36, 36);
            tsbBorrar.Text = "Desactivar";
            tsbBorrar.Click += tsbDesactivar_Click;
            // 
            // tsbActivar
            // 
            tsbActivar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbActivar.Image = Properties.Resources.icons8_checked_96px;
            tsbActivar.ImageTransparentColor = Color.Magenta;
            tsbActivar.Name = "tsbActivar";
            tsbActivar.Size = new Size(36, 36);
            tsbActivar.Text = "Activar";
            tsbActivar.Click += tsbActivar_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = Properties.Resources.icons8_search_96px;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(36, 36);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // panelNavegacion
            // 
            panelNavegacion.BackColor = Color.PaleTurquoise;
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(cboPaginas);
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 367);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(800, 83);
            panelNavegacion.TabIndex = 2;
            // 
            // btnUltimo
            // 
            btnUltimo.Image = (Image)resources.GetObject("btnUltimo.Image");
            btnUltimo.Location = new Point(640, 18);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(65, 45);
            btnUltimo.TabIndex = 4;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Image = Properties.Resources.icons8_fast_forward_48px;
            btnSiguiente.Location = new Point(560, 18);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(65, 45);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.icons8_rewind_48px;
            btnAnterior.Location = new Point(479, 18);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(65, 45);
            btnAnterior.TabIndex = 4;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Image = (Image)resources.GetObject("btnPrimero.Image");
            btnPrimero.Location = new Point(396, 18);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(65, 45);
            btnPrimero.TabIndex = 4;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(184, 35);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.Size = new Size(62, 23);
            txtCantidadPaginas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 38);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Página";
            // 
            // cboPaginas
            // 
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(82, 35);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(72, 23);
            cboPaginas.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.Anchor = AnchorStyles.Left;
            dgvDatos.BackgroundColor = Color.PaleTurquoise;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colProductos, colCategoria, colPrecio, colActiva });
            dgvDatos.Location = new Point(0, 42);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 325);
            dgvDatos.TabIndex = 3;
            // 
            // colProductos
            // 
            colProductos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductos.FillWeight = 159.390884F;
            colProductos.HeaderText = "Producto";
            colProductos.Name = "colProductos";
            colProductos.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 65;
            // 
            // colActiva
            // 
            colActiva.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colActiva.FillWeight = 40.6091423F;
            colActiva.HeaderText = "Activo";
            colActiva.Name = "colActiva";
            colActiva.ReadOnly = true;
            colActiva.Width = 66;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private Panel panelNavegacion;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colProductos;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colActiva;
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
    }
}
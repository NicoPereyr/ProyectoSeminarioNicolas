namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmCategorias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbDesactivar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbRefrescar = new ToolStripButton();
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
            colCategorias = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewCheckBoxColumn();
            panelEncabezado = new Panel();
            lblTituloModerno = new Label();
            lblSubtituloModerno = new Label();
            panelGrilla = new Panel();
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelEncabezado.SuspendLayout();
            panelGrilla.SuspendLayout();
            SuspendLayout();
            //
            // panelEncabezado
            //
            panelEncabezado.BackColor = Color.FromArgb(36, 37, 42);
            panelEncabezado.Controls.Add(lblTituloModerno);
            panelEncabezado.Controls.Add(lblSubtituloModerno);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1050, 118);
            panelEncabezado.TabIndex = 0;
            //
            // lblTituloModerno
            //
            lblTituloModerno.AutoSize = true;
            lblTituloModerno.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloModerno.ForeColor = Color.White;
            lblTituloModerno.Location = new Point(32, 27);
            lblTituloModerno.Name = "lblTituloModerno";
            lblTituloModerno.Text = "Gestión de categorías";
            //
            // lblSubtituloModerno
            //
            lblSubtituloModerno.AutoSize = true;
            lblSubtituloModerno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtituloModerno.ForeColor = Color.FromArgb(240, 151, 81);
            lblSubtituloModerno.Location = new Point(34, 74);
            lblSubtituloModerno.Name = "lblSubtituloModerno";
            lblSubtituloModerno.Text = "HAMBURGUESERÍA | PROYECTO SEMINARIO";
            //
            // topTS
            //
            topTS.BackColor = Color.FromArgb(246, 243, 238);
            topTS.Dock = DockStyle.Top;
            topTS.GripStyle = ToolStripGripStyle.Hidden;
            topTS.ImageScalingSize = new Size(20, 20);
            topTS.Padding = new Padding(25, 7, 5, 7);
            topTS.AutoSize = false;
            topTS.Size = new Size(1050, 64);
            topTS.Name = "topTS";
            topTS.TabIndex = 1;
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbDesactivar, tsbActivar, tsbBuscar, tsbRefrescar, tsbFiltrar });
            //
            // tsbAgregar
            //
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAgregar.BackColor = Color.FromArgb(145, 39, 34);
            tsbAgregar.ForeColor = Color.White;
            tsbAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbAgregar.Margin = new Padding(4, 2, 8, 2);
            tsbAgregar.AutoSize = false;
            tsbAgregar.Size = new Size(94, 34);
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Text = "Agregar";
            tsbAgregar.Click += tsbAgregar_Click;
            //
            // tsbEditar
            //
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditar.BackColor = Color.FromArgb(145, 39, 34);
            tsbEditar.ForeColor = Color.White;
            tsbEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbEditar.Margin = new Padding(0, 2, 8, 2);
            tsbEditar.AutoSize = false;
            tsbEditar.Size = new Size(94, 34);
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            //
            // tsbDesactivar
            //
            tsbDesactivar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDesactivar.BackColor = Color.FromArgb(145, 39, 34);
            tsbDesactivar.ForeColor = Color.White;
            tsbDesactivar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbDesactivar.Margin = new Padding(0, 2, 8, 2);
            tsbDesactivar.AutoSize = false;
            tsbDesactivar.Size = new Size(112, 34);
            tsbDesactivar.Name = "tsbDesactivar";
            tsbDesactivar.Text = "Desactivar";
            tsbDesactivar.Click += tsbDesactivar_Click;
            //
            // tsbActivar
            //
            tsbActivar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbActivar.BackColor = Color.FromArgb(145, 39, 34);
            tsbActivar.ForeColor = Color.White;
            tsbActivar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbActivar.Margin = new Padding(0, 2, 8, 2);
            tsbActivar.AutoSize = false;
            tsbActivar.Size = new Size(94, 34);
            tsbActivar.Name = "tsbActivar";
            tsbActivar.Text = "Activar";
            tsbActivar.Click += tsbActivar_Click;
            //
            // tsbBuscar
            //
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbBuscar.BackColor = Color.FromArgb(190, 68, 44);
            tsbBuscar.ForeColor = Color.White;
            tsbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbBuscar.Margin = new Padding(0, 2, 8, 2);
            tsbBuscar.AutoSize = false;
            tsbBuscar.Size = new Size(94, 34);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            //
            // tsbRefrescar
            //
            tsbRefrescar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRefrescar.BackColor = Color.FromArgb(190, 68, 44);
            tsbRefrescar.ForeColor = Color.White;
            tsbRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbRefrescar.Margin = new Padding(0, 2, 8, 2);
            tsbRefrescar.AutoSize = false;
            tsbRefrescar.Size = new Size(104, 34);
            tsbRefrescar.Name = "tsbRefrescar";
            tsbRefrescar.Text = "Actualizar";
            tsbRefrescar.Click += tsbRefrescar_Click;
            //
            // tsbFiltrar
            //
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbFiltrar.BackColor = Color.FromArgb(220, 215, 210);
            tsbFiltrar.ForeColor = Color.FromArgb(75, 75, 75);
            tsbFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbFiltrar.Margin = new Padding(0, 2, 0, 2);
            tsbFiltrar.AutoSize = false;
            tsbFiltrar.Size = new Size(94, 34);
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.Enabled = false; // La función original aún está vacía.
            tsbFiltrar.Click += tsbFiltrar_Click;
            //
            // panelNavegacion
            //
            panelNavegacion.BackColor = Color.FromArgb(235, 230, 225);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(cboPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(1050, 82);
            panelNavegacion.TabIndex = 2;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Text = "Página";
            //
            // cboPaginas
            //
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.Location = new Point(91, 27);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(76, 23);
            cboPaginas.TabIndex = 0;
            // El evento de páginas se conecta desde LoadData(), como en el formulario original.
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(186, 31);
            label2.Name = "label2";
            label2.Text = "de";
            //
            // txtCantidadPaginas
            //
            txtCantidadPaginas.BackColor = Color.FromArgb(246, 243, 238);
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Location = new Point(219, 27);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.Size = new Size(70, 23);
            txtCantidadPaginas.TabIndex = 1;
            //
            // btnPrimero
            //
            btnPrimero.Location = new Point(397, 20);
            btnPrimero.Size = new Size(75, 42);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Text = "|<";
            btnPrimero.BackColor = Color.White;
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.Click += btnPrimero_Click;
            //
            // btnAnterior
            //
            btnAnterior.Location = new Point(480, 20);
            btnAnterior.Size = new Size(75, 42);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Text = "<";
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.Click += btnAnterior_Click;
            //
            // btnSiguiente
            //
            btnSiguiente.Location = new Point(563, 20);
            btnSiguiente.Size = new Size(75, 42);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Text = ">";
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.Click += btnSiguiente_Click;
            //
            // btnUltimo
            //
            btnUltimo.Location = new Point(646, 20);
            btnUltimo.Size = new Size(75, 42);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Text = ">|";
            btnUltimo.BackColor = Color.White;
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.Click += btnUltimo_Click;
            //
            // panelGrilla
            //
            panelGrilla.BackColor = Color.FromArgb(246, 243, 238);
            panelGrilla.Padding = new Padding(25, 12, 25, 18);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Controls.Add(dgvDatos);
            //
            // dgvDatos
            //
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 43, 39);
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(139, 43, 39);
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.ColumnHeadersHeight = 44;
            dgvDatos.DefaultCellStyle.BackColor = Color.White;
            dgvDatos.DefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
            dgvDatos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 213, 203);
            dgvDatos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(251, 247, 244);
            dgvDatos.GridColor = Color.FromArgb(236, 230, 225);
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCategorias, colActiva });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowTemplate.Height = 32;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.TabIndex = 3;
            //
            // colCategorias
            //
            colCategorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategorias.FillWeight = 80F;
            colCategorias.HeaderText = "Categorías";
            colCategorias.Name = "colCategorias";
            colCategorias.ReadOnly = true;
            colCategorias.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // colActiva
            //
            colActiva.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActiva.FillWeight = 20F;
            colActiva.HeaderText = "Activa";
            colActiva.Name = "colActiva";
            colActiva.ReadOnly = true;
            //
            // frmCategorias
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = false;
            BackColor = Color.FromArgb(246, 243, 238);
            ClientSize = new Size(1050, 728);
            Controls.Add(panelGrilla);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Controls.Add(panelEncabezado);
            Name = "frmCategorias";
            Text = "Gestión de categorías";
            Load += frmCategorias_Load;
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbDesactivar;
        private ToolStripButton tsbActivar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbRefrescar;
        private Panel panelNavegacion;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private Label label2;
        private Label label1;
        private ComboBox cboPaginas;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colCategorias;
        private DataGridViewCheckBoxColumn colActiva;
        private Panel panelEncabezado;
        private Label lblTituloModerno;
        private Label lblSubtituloModerno;
        private Panel panelGrilla;
    }
}

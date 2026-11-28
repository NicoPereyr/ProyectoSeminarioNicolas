namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmEmpleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            ColPorcentajeComision = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewCheckBoxColumn();
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbDesactivar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
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
            panelEncabezado = new Panel();
            lblTituloModernizado = new Label();
            lblSubtituloModernizado = new Label();
            panelFondoGrilla = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            panelEncabezado.SuspendLayout();
            panelFondoGrilla.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 246, 242);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(137, 40, 36);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(139, 43, 39);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeight = 44;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellido, colSexo, colDocumento, ColPorcentajeComision, colActivo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(139, 43, 39);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.Location = new Point(25, 14);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowTemplate.Height = 30;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1000, 433);
            dgvDatos.TabIndex = 2;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.FillWeight = 120F;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colApellido
            // 
            colApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colApellido.FillWeight = 120F;
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            colApellido.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colSexo
            // 
            colSexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSexo.FillWeight = 75F;
            colSexo.HeaderText = "Sexo";
            colSexo.MaxInputLength = 15;
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            colSexo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDocumento
            // 
            colDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDocumento.FillWeight = 110F;
            colDocumento.HeaderText = "Documento";
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            colDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPorcentajeComision
            // 
            ColPorcentajeComision.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPorcentajeComision.FillWeight = 95F;
            ColPorcentajeComision.HeaderText = "% Comisión";
            ColPorcentajeComision.Name = "ColPorcentajeComision";
            ColPorcentajeComision.ReadOnly = true;
            ColPorcentajeComision.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 65F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // topTS
            // 
            topTS.AutoSize = false;
            topTS.BackColor = Color.FromArgb(246, 243, 238);
            topTS.GripStyle = ToolStripGripStyle.Hidden;
            topTS.ImageScalingSize = new Size(20, 20);
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbDesactivar, tsbActivar, tsbFiltrar, tsbRefrescar });
            topTS.Location = new Point(0, 118);
            topTS.Name = "topTS";
            topTS.Padding = new Padding(24, 10, 8, 10);
            topTS.Size = new Size(1050, 65);
            topTS.TabIndex = 1;
            // 
            // tsbAgregar
            // 
            tsbAgregar.AutoSize = false;
            tsbAgregar.BackColor = Color.FromArgb(143, 39, 36);
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbAgregar.ForeColor = Color.White;
            tsbAgregar.Margin = new Padding(4, 0, 8, 0);
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(116, 39);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.AutoSize = false;
            tsbEditar.BackColor = Color.FromArgb(143, 39, 36);
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbEditar.ForeColor = Color.White;
            tsbEditar.Margin = new Padding(0, 0, 8, 0);
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(108, 39);
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbDesactivar
            // 
            tsbDesactivar.AutoSize = false;
            tsbDesactivar.BackColor = Color.FromArgb(143, 39, 36);
            tsbDesactivar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDesactivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbDesactivar.ForeColor = Color.White;
            tsbDesactivar.Margin = new Padding(0, 0, 8, 0);
            tsbDesactivar.Name = "tsbDesactivar";
            tsbDesactivar.Size = new Size(122, 39);
            tsbDesactivar.Text = "Desactivar";
            tsbDesactivar.Click += tsbDesactivar_Click;
            // 
            // tsbActivar
            // 
            tsbActivar.AutoSize = false;
            tsbActivar.BackColor = Color.FromArgb(143, 39, 36);
            tsbActivar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbActivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbActivar.ForeColor = Color.White;
            tsbActivar.Margin = new Padding(0, 0, 8, 0);
            tsbActivar.Name = "tsbActivar";
            tsbActivar.Size = new Size(108, 39);
            tsbActivar.Text = "Activar";
            tsbActivar.Click += tsbActivar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.AutoSize = false;
            tsbFiltrar.BackColor = Color.FromArgb(194, 69, 45);
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbFiltrar.ForeColor = Color.White;
            tsbFiltrar.Margin = new Padding(0, 0, 8, 0);
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(108, 39);
            tsbFiltrar.Text = "Buscar";
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbRefrescar
            // 
            tsbRefrescar.AutoSize = false;
            tsbRefrescar.BackColor = Color.FromArgb(194, 69, 45);
            tsbRefrescar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRefrescar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tsbRefrescar.ForeColor = Color.White;
            tsbRefrescar.Name = "tsbRefrescar";
            tsbRefrescar.Size = new Size(118, 39);
            tsbRefrescar.Text = "Actualizar";
            tsbRefrescar.Click += tsbRefrescar_Click;
            // 
            // panelNavegacion
            // 
            panelNavegacion.BackColor = Color.FromArgb(234, 228, 223);
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(cboPaginas);
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 648);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(1050, 82);
            panelNavegacion.TabIndex = 4;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUltimo.BackColor = Color.White;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUltimo.Location = new Point(881, 20);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(68, 42);
            btnUltimo.TabIndex = 12;
            btnUltimo.Text = ">|";
            btnUltimo.UseVisualStyleBackColor = false;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSiguiente.Location = new Point(804, 20);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(68, 42);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAnterior.Location = new Point(727, 20);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(68, 42);
            btnAnterior.TabIndex = 10;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrimero.BackColor = Color.White;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrimero.Location = new Point(650, 20);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(68, 42);
            btnPrimero.TabIndex = 9;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = false;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(220, 29);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(68, 23);
            txtCantidadPaginas.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(190, 31);
            label2.Name = "label2";
            label2.Size = new Size(24, 19);
            label2.TabIndex = 13;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(42, 39, 39);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 14;
            label1.Text = "Página";
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(97, 29);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(76, 23);
            cboPaginas.TabIndex = 5;
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.FromArgb(36, 37, 42);
            panelEncabezado.Controls.Add(lblTituloModernizado);
            panelEncabezado.Controls.Add(lblSubtituloModernizado);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1050, 118);
            panelEncabezado.TabIndex = 0;
            // 
            // lblTituloModernizado
            // 
            lblTituloModernizado.AutoSize = true;
            lblTituloModernizado.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloModernizado.ForeColor = Color.White;
            lblTituloModernizado.Location = new Point(34, 26);
            lblTituloModernizado.Name = "lblTituloModernizado";
            lblTituloModernizado.Size = new Size(302, 37);
            lblTituloModernizado.TabIndex = 0;
            lblTituloModernizado.Text = "Gestión de empleados";
            // 
            // lblSubtituloModernizado
            // 
            lblSubtituloModernizado.AutoSize = true;
            lblSubtituloModernizado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtituloModernizado.ForeColor = Color.FromArgb(240, 150, 87);
            lblSubtituloModernizado.Location = new Point(36, 79);
            lblSubtituloModernizado.Name = "lblSubtituloModernizado";
            lblSubtituloModernizado.Size = new Size(256, 15);
            lblSubtituloModernizado.TabIndex = 1;
            lblSubtituloModernizado.Text = "HAMBURGUESERÍA | PROYECTO SEMINARIO";
            // 
            // panelFondoGrilla
            // 
            panelFondoGrilla.BackColor = Color.FromArgb(246, 243, 238);
            panelFondoGrilla.Controls.Add(dgvDatos);
            panelFondoGrilla.Dock = DockStyle.Fill;
            panelFondoGrilla.Location = new Point(0, 183);
            panelFondoGrilla.Name = "panelFondoGrilla";
            panelFondoGrilla.Padding = new Padding(25, 14, 25, 18);
            panelFondoGrilla.Size = new Size(1050, 465);
            panelFondoGrilla.TabIndex = 3;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 238);
            ClientSize = new Size(1050, 730);
            Controls.Add(panelFondoGrilla);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Controls.Add(panelEncabezado);
            MinimumSize = new Size(780, 560);
            Name = "frmEmpleados";
            Text = "Gestión de empleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelFondoGrilla.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private DataGridView dgvDatos;
        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbDesactivar;
        private ToolStripButton tsbActivar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private Panel panelNavegacion;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private Label label2;
        private Label label1;
        private ComboBox cboPaginas;
        private ToolStripButton tsbRefrescar;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn ColPorcentajeComision;
        private DataGridViewCheckBoxColumn colActivo;
        private Panel panelEncabezado;
        private Label lblTituloModernizado;
        private Label lblSubtituloModernizado;
        private Panel panelFondoGrilla;
    }
}

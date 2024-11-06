namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmCategorias
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
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbDesactivar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
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
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // topTS
            // 
            topTS.BackColor = Color.PaleTurquoise;
            topTS.ImageScalingSize = new Size(32, 32);
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbDesactivar, tsbActivar, tsbEditar, tsbFiltrar });
            topTS.Location = new Point(0, 0);
            topTS.Name = "topTS";
            topTS.Size = new Size(800, 39);
            topTS.TabIndex = 0;
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
            // tsbDesactivar
            // 
            tsbDesactivar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDesactivar.Image = Properties.Resources.icons8_cancel_96px;
            tsbDesactivar.ImageTransparentColor = Color.Magenta;
            tsbDesactivar.Name = "tsbDesactivar";
            tsbDesactivar.Size = new Size(36, 36);
            tsbDesactivar.Text = "Desactivar";
            tsbDesactivar.Click += tsbDesactivar_Click;
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
            tsbFiltrar.Click += tsbFiltrar_Click;
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
            panelNavegacion.TabIndex = 1;
            // 
            // btnUltimo
            // 
            btnUltimo.Image = Properties.Resources.icons8_end_96px;
            btnUltimo.Location = new Point(630, 20);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(65, 45);
            btnUltimo.TabIndex = 9;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Image = Properties.Resources.icons8_fast_forward_48px;
            btnSiguiente.Location = new Point(553, 21);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(65, 45);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.icons8_rewind_48px;
            btnAnterior.Location = new Point(477, 21);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(65, 45);
            btnAnterior.TabIndex = 11;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Image = Properties.Resources.icons8_skip_to_start_96px;
            btnPrimero.Location = new Point(401, 21);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(65, 45);
            btnPrimero.TabIndex = 12;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(188, 34);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.Size = new Size(62, 23);
            txtCantidadPaginas.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 37);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 7;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Página";
            // 
            // cboPaginas
            // 
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(86, 34);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(72, 23);
            cboPaginas.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.BackgroundColor = Color.PaleTurquoise;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCategorias, colActiva });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 39);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 328);
            dgvDatos.TabIndex = 2;
            // 
            // colCategorias
            // 
            colCategorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategorias.FillWeight = 159.390884F;
            colCategorias.HeaderText = "Categorías";
            colCategorias.Name = "colCategorias";
            colCategorias.ReadOnly = true;
            // 
            // colActiva
            // 
            colActiva.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActiva.FillWeight = 40.6091423F;
            colActiva.HeaderText = "Activa";
            colActiva.Name = "colActiva";
            colActiva.ReadOnly = true;
            colActiva.Resizable = DataGridViewTriState.True;
            colActiva.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
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
        private ToolStripButton tsbDesactivar;
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
        private DataGridViewTextBoxColumn colCategorias;
        private DataGridViewCheckBoxColumn colActiva;
    }
}
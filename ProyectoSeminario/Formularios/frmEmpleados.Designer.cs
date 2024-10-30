namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmEmpleados
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
            dgvDatos = new DataGridView();
            colEmpleados = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.BackgroundColor = Color.PaleTurquoise;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colEmpleados, colActivo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.ImeMode = ImeMode.NoControl;
            dgvDatos.Location = new Point(0, 39);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 411);
            dgvDatos.TabIndex = 4;
            // 
            // colEmpleados
            // 
            colEmpleados.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmpleados.FillWeight = 159.390884F;
            colEmpleados.HeaderText = "Empleados";
            colEmpleados.Name = "colEmpleados";
            colEmpleados.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 40.6091423F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // topTS
            // 
            topTS.BackColor = Color.PaleTurquoise;
            topTS.ImageScalingSize = new Size(32, 32);
            topTS.ImeMode = ImeMode.NoControl;
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbDesactivar, tsbActivar, tsbEditar, tsbFiltrar });
            topTS.Location = new Point(0, 0);
            topTS.Name = "topTS";
            topTS.Size = new Size(800, 39);
            topTS.TabIndex = 3;
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
            // 
            // tsbDesactivar
            // 
            tsbDesactivar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDesactivar.Image = Properties.Resources.icons8_cancel_96px;
            tsbDesactivar.ImageTransparentColor = Color.Magenta;
            tsbDesactivar.Name = "tsbDesactivar";
            tsbDesactivar.Size = new Size(36, 36);
            tsbDesactivar.Text = "Desactivar";
            // 
            // tsbActivar
            // 
            tsbActivar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbActivar.Image = Properties.Resources.icons8_checked_96px;
            tsbActivar.ImageTransparentColor = Color.Magenta;
            tsbActivar.Name = "tsbActivar";
            tsbActivar.Size = new Size(36, 36);
            tsbActivar.Text = "Activar";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = Properties.Resources.icons8_pencil_96px;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(36, 36);
            tsbEditar.Text = "Editar";
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
            panelNavegacion.TabIndex = 5;
            // 
            // btnUltimo
            // 
            btnUltimo.Image = Properties.Resources.icons8_end_96px;
            btnUltimo.Location = new Point(630, 20);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(65, 45);
            btnUltimo.TabIndex = 9;
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Image = Properties.Resources.icons8_fast_forward_48px;
            btnSiguiente.Location = new Point(553, 21);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(65, 45);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.icons8_rewind_48px;
            btnAnterior.Location = new Point(477, 21);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(65, 45);
            btnAnterior.TabIndex = 11;
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.Image = Properties.Resources.icons8_skip_to_start_96px;
            btnPrimero.Location = new Point(401, 21);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(65, 45);
            btnPrimero.TabIndex = 12;
            btnPrimero.UseVisualStyleBackColor = true;
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
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelNavegacion);
            Controls.Add(dgvDatos);
            Controls.Add(topTS);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbDesactivar;
        private ToolStripButton tsbActivar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private DataGridViewTextBoxColumn colEmpleados;
        private DataGridViewTextBoxColumn colActivo;
        private Panel panelNavegacion;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private Label label2;
        private Label label1;
        private ComboBox cboPaginas;
    }
}
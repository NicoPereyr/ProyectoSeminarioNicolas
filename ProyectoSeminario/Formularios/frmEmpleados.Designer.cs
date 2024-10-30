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
            topTS = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbDesactivar = new ToolStripButton();
            tsbActivar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            colEmpleados = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            topTS.SuspendLayout();
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
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(topTS);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
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
    }
}
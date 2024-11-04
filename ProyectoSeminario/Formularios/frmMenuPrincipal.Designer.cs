namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmMenuPrincipal
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
            btnProductos = new Button();
            btnCombos = new Button();
            btnOrdenes = new Button();
            btnCategorias = new Button();
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnEmpleados = new Button();
            barraTitulo = new Panel();
            panelContenedorPrincipal = new Panel();
            panelFormHijo = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            barraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnProductos.Image = Properties.Resources.productos;
            btnProductos.ImageAlign = ContentAlignment.BottomCenter;
            btnProductos.Location = new Point(0, 145);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(136, 90);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.BottomCenter;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCombos
            // 
            btnCombos.Cursor = Cursors.Hand;
            btnCombos.FlatAppearance.BorderSize = 0;
            btnCombos.FlatStyle = FlatStyle.Flat;
            btnCombos.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnCombos.Image = Properties.Resources.papas;
            btnCombos.ImageAlign = ContentAlignment.BottomCenter;
            btnCombos.Location = new Point(0, 241);
            btnCombos.Name = "btnCombos";
            btnCombos.Size = new Size(136, 90);
            btnCombos.TabIndex = 0;
            btnCombos.Text = "Combos";
            btnCombos.TextAlign = ContentAlignment.BottomCenter;
            btnCombos.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            btnOrdenes.BackgroundImageLayout = ImageLayout.Center;
            btnOrdenes.Cursor = Cursors.Hand;
            btnOrdenes.FlatAppearance.BorderSize = 0;
            btnOrdenes.FlatStyle = FlatStyle.Flat;
            btnOrdenes.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenes.ForeColor = SystemColors.ControlText;
            btnOrdenes.Image = Properties.Resources.ordenes;
            btnOrdenes.ImageAlign = ContentAlignment.BottomCenter;
            btnOrdenes.Location = new Point(0, 46);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(136, 90);
            btnOrdenes.TabIndex = 0;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.TextAlign = ContentAlignment.BottomCenter;
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.Image = Properties.Resources.comidas;
            btnCategorias.ImageAlign = ContentAlignment.BottomCenter;
            btnCategorias.Location = new Point(0, 337);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(136, 90);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.BottomCenter;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCombos);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnEmpleados);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnOrdenes);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 627);
            panel1.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.DarkSlateGray;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.minimizar;
            btnMinimizar.Location = new Point(33, 598);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackColor = Color.DarkSlateGray;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.restaurar;
            btnRestaurar.Location = new Point(33, 555);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnRestaurar.TabIndex = 0;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.DarkSlateGray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(78, 598);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.DarkSlateGray;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximizar;
            btnMaximizar.Location = new Point(78, 555);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMaximizar.TabIndex = 0;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Image = Properties.Resources.icons8_user_96px;
            btnEmpleados.ImageAlign = ContentAlignment.BottomCenter;
            btnEmpleados.Location = new Point(0, 433);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(136, 90);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.BottomCenter;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(4, 50, 68);
            barraTitulo.Controls.Add(panelContenedorPrincipal);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1000, 29);
            barraTitulo.TabIndex = 2;
            barraTitulo.MouseMove += barraTitulo_MouseMove;
            // 
            // panelContenedorPrincipal
            // 
            panelContenedorPrincipal.BackColor = Color.Teal;
            panelContenedorPrincipal.Dock = DockStyle.Fill;
            panelContenedorPrincipal.Enabled = false;
            panelContenedorPrincipal.Location = new Point(0, 0);
            panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            panelContenedorPrincipal.Size = new Size(1000, 29);
            panelContenedorPrincipal.TabIndex = 1;
            // 
            // panelFormHijo
            // 
            panelFormHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFormHijo.AutoSize = true;
            panelFormHijo.Location = new Point(134, 28);
            panelFormHijo.Name = "panelFormHijo";
            panelFormHijo.Size = new Size(866, 599);
            panelFormHijo.TabIndex = 3;
            panelFormHijo.Visible = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.logopan;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1000, 627);
            Controls.Add(panelFormHijo);
            Controls.Add(barraTitulo);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 600);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carlos Food Truck";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            barraTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btnCombos;
        private Button btnOrdenes;
        private Button btnCategorias;
        private Panel panel1;
        private Panel barraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel panelContenedorPrincipal;
        private Panel panelFormHijo;
        private Button btnEmpleados;
    }
}
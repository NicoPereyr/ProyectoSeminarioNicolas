namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmProductosAE
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            cboCategorias = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            picImagen = new PictureBox();
            btnBuscarImagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(270, 235);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 44);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(107, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 172);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 71);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 26);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(107, 164);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 65);
            txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 68);
            txtPrecio.MaxLength = 10;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(87, 23);
            txtPrecio.TabIndex = 5;
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(107, 111);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(121, 23);
            cboCategorias.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 119);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Categoría";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picImagen);
            groupBox1.Location = new Point(306, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 110);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(0, 14);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(143, 83);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(337, 119);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(75, 39);
            btnBuscarImagen.TabIndex = 8;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProductosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(500, 300);
            Controls.Add(btnBuscarImagen);
            Controls.Add(groupBox1);
            Controls.Add(cboCategorias);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "frmProductosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label label1;
        private ComboBox cboCategorias;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private GroupBox groupBox1;
        private PictureBox picImagen;
        private Button btnBuscarImagen;
        private OpenFileDialog openFileDialog1;
    }
}
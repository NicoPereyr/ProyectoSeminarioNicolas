﻿namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmEmpleadosAE
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
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            txtDocumento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtPorcentajeComision = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(192, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(29, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 44);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(159, 247);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 44);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(192, 132);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(156, 23);
            txtDocumento.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(192, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(156, 23);
            txtApellido.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 178);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 16;
            label4.Text = "Porcentaje Comisión";
            // 
            // txtPorcentajeComision
            // 
            txtPorcentajeComision.Location = new Point(192, 175);
            txtPorcentajeComision.Name = "txtPorcentajeComision";
            txtPorcentajeComision.Size = new Size(156, 23);
            txtPorcentajeComision.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 388);
            Controls.Add(label4);
            Controls.Add(txtPorcentajeComision);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Name = "frmEmpleadosAE";
            Text = "frmEmpleadosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
        private TextBox txtDocumento;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtPorcentajeComision;
        private ErrorProvider errorProvider1;
    }
}
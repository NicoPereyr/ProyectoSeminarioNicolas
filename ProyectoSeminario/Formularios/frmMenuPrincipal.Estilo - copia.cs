using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Formularios
{
    // Diseño visual separado del Designer: permite volver atrás sin perder controles ni eventos.
    public partial class frmMenuPrincipal
    {
        private Button? btnInicioModerno;
        private Panel? panelInicioModerno;

        private void AplicarEstiloModerno()
        {
            SuspendLayout();
            ClientSize = new Size(1280, 780);
            MinimumSize = new Size(1050, 690);
            BackColor = Color.FromArgb(246, 243, 238);
            BackgroundImage = null;
            Text = "Hamburguesería - Proyecto Seminario";

            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(25, 26, 30);
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(230, ClientSize.Height);

            barraTitulo.Dock = DockStyle.None;
            barraTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            barraTitulo.BackColor = Color.FromArgb(36, 37, 42);
            barraTitulo.Location = new Point(230, 0);
            barraTitulo.Size = new Size(ClientSize.Width - 230, 52);
            panelContenedorPrincipal.Visible = false;

            // Conservamos los controles y sus eventos originales, pero los reubicamos.
            ConfigurarBotonMenu(btnOrdenes, "Nueva venta", 176);
            ConfigurarBotonMenu(btnHistorialVentas, "Historial de ventas", 232);
            ConfigurarBotonMenu(btnProductos, "Productos", 288);
            ConfigurarBotonMenu(btnCategorias, "Categorías", 344);
            ConfigurarBotonMenu(btnEmpleados, "Empleados", 400);
            // Combos no tenía evento Click en el Designer recibido.
            btnCombos.Visible = false;

            var marca = new Label
            {
                Name = "lblMarcaModerna",
                Text = "HAMBURGUESERÍA",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                Location = new Point(17, 29),
                Size = new Size(205, 38),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var subtitulo = new Label
            {
                Name = "lblSubtituloModerno",
                Text = "PROYECTO SEMINARIO",
                ForeColor = Color.FromArgb(237, 146, 81),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = new Point(19, 70),
                Size = new Size(200, 26)
            };
            panel1.Controls.Add(marca);
            panel1.Controls.Add(subtitulo);

            btnInicioModerno = new Button();
            ConfigurarBotonMenu(btnInicioModerno, "Inicio", 120);
            btnInicioModerno.Name = "btnInicioModerno";
            btnInicioModerno.Click += (_, _) => MostrarInicioModerno();
            panel1.Controls.Add(btnInicioModerno);

            // Los controles de ventana originales conservan sus eventos Click.
            foreach (var picture in new[] { btnMinimizar, btnMaximizar, btnRestaurar, btnCerrar })
            {
                picture.Parent = barraTitulo;
                picture.BackColor = Color.Transparent;
                picture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                picture.Size = new Size(25, 25);
                picture.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            btnMinimizar.Location = new Point(barraTitulo.Width - 137, 13);
            btnMaximizar.Location = new Point(barraTitulo.Width - 102, 13);
            btnRestaurar.Location = btnMaximizar.Location;
            btnCerrar.Location = new Point(barraTitulo.Width - 47, 13);
            btnRestaurar.Visible = false;

            var tituloBarra = new Label
            {
                Text = "Panel de gestión",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(22, 11),
                Size = new Size(260, 28)
            };
            barraTitulo.Controls.Add(tituloBarra);

            panelFormHijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFormHijo.AutoSize = false;
            panelFormHijo.Location = new Point(230, 52);
            panelFormHijo.Size = new Size(ClientSize.Width - 230, ClientSize.Height - 52);
            panelFormHijo.BackColor = Color.FromArgb(246, 243, 238);
            panelFormHijo.Visible = true;

            Resize += (_, _) =>
            {
                panel1.Height = ClientSize.Height;
                barraTitulo.Width = Math.Max(0, ClientSize.Width - 230);
                panelFormHijo.Size = new Size(Math.Max(0, ClientSize.Width - 230), Math.Max(0, ClientSize.Height - 52));
            };

            ResumeLayout(true);
            MostrarInicioModerno();
        }

        private void ConfigurarBotonMenu(Button boton, string texto, int y)
        {
            boton.Parent = panel1;
            boton.Location = new Point(10, y);
            boton.Size = new Size(210, 48);
            boton.Text = "   " + texto;
            boton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            boton.ForeColor = Color.FromArgb(238, 238, 238);
            boton.BackColor = Color.FromArgb(36, 37, 42);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 43, 39);
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(104, 32, 30);
            boton.Image = null; // Los iconos antiguos eran grandes y cortaban el texto.
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
        }

        private void MostrarInicioModerno()
        {
            // AbrirFormularioEnPanel() elimina el primer control, por eso
            // la portada debe estar dentro de un ÚNICO panel contenedor.
            while (panelFormHijo.Controls.Count > 0)
                panelFormHijo.Controls[0].Dispose();

            panelInicioModerno = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(246, 243, 238)
            };

            var bienvenida = new Label
            {
                Text = "Bienvenido a Hamburguesería",
                Location = new Point(35, 29),
                Size = new Size(850, 50),
                Font = new Font("Segoe UI", 23F, FontStyle.Bold),
                ForeColor = Color.FromArgb(38, 37, 37)
            };
            panelInicioModerno.Controls.Add(bienvenida);

            var descripcion = new Label
            {
                Text = "Gestioná las ventas, los productos y tu equipo desde un solo lugar.",
                Location = new Point(38, 83),
                Size = new Size(850, 30),
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(98, 95, 92)
            };
            panelInicioModerno.Controls.Add(descripcion);

            AgregarTarjeta(panelInicioModerno, "VENTAS DEL DÍA", "Pendiente de conectar", 36, 148);
            AgregarTarjeta(panelInicioModerno, "VENTAS REGISTRADAS", "Pendiente de conectar", 320, 148);
            AgregarTarjeta(panelInicioModerno, "PRODUCTOS ACTIVOS", "Pendiente de conectar", 604, 148);

            var banner = new Panel
            {
                Location = new Point(36, 296),
                Size = new Size(835, 170),
                BackColor = Color.FromArgb(125, 35, 30),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            banner.Controls.Add(new Label
            {
                Text = "¡Bienvenido a tu hamburguesería!",
                Font = new Font("Segoe UI", 21F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(25, 28),
                Size = new Size(760, 54)
            });
            banner.Controls.Add(new Label
            {
                Text = "Las estadísticas reales y la foto de la smash burger se agregan en el próximo paso.",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(255, 228, 210),
                Location = new Point(27, 90),
                Size = new Size(760, 45)
            });
            panelInicioModerno.Controls.Add(banner);

            var botonNuevaVenta = new Button
            {
                Text = "Nueva venta",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(190, 68, 44),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Location = new Point(36, 495),
                Size = new Size(195, 48)
            };
            botonNuevaVenta.FlatAppearance.BorderSize = 0;
            botonNuevaVenta.Click += btnOrdenes_Click;
            panelInicioModerno.Controls.Add(botonNuevaVenta);

            panelFormHijo.Controls.Add(panelInicioModerno);
            panelFormHijo.Visible = true;
        }

        private static void AgregarTarjeta(Panel parent, string titulo, string valor, int x, int y)
        {
            var tarjeta = new Panel
            {
                BackColor = Color.White,
                Location = new Point(x, y),
                Size = new Size(268, 112)
            };
            tarjeta.Controls.Add(new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(125, 43, 38),
                Location = new Point(17, 15),
                Size = new Size(240, 27)
            });
            tarjeta.Controls.Add(new Label
            {
                Text = valor,
                Font = new Font("Segoe UI", 13F),
                ForeColor = Color.FromArgb(83, 80, 79),
                Location = new Point(17, 52),
                Size = new Size(246, 38)
            });
            parent.Controls.Add(tarjeta);
        }
    }
}

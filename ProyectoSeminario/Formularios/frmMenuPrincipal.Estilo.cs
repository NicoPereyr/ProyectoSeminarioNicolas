using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Servicios.Interfaces;
using System.Globalization;

using FormsPlot = ScottPlot.WinForms.FormsPlot;


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
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(10, 29),
                Size = new Size(220, 38),
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

            // Estadísticas reales. Las ventas anuladas no suman ni al importe ni a la cantidad.
            string ventasHoyTexto = "No disponible";
            string cantidadVentasTexto = "No disponible";
            string productosActivosTexto = "No disponible";

            try
            {
                var servicioVentas = _serviceProvider!.GetRequiredService<IServiciosVentas>();
                var servicioProductos = _serviceProvider.GetRequiredService<IServiciosProductos>();
                var ventasActivas = servicioVentas.GetLista().Where(v => !v.Anulada).ToList();

                decimal ventasHoy = ventasActivas
                    .Where(v => v.FechaVenta.Date == DateTime.Today)
                    .Sum(v => v.Total);

                ventasHoyTexto = ventasHoy.ToString("C2", CultureInfo.GetCultureInfo("es-AR"));
                cantidadVentasTexto = ventasActivas.Count.ToString("N0", CultureInfo.GetCultureInfo("es-AR"));

                // GetLista pagina de a 1000 productos: suficiente para el catálogo actual.
                productosActivosTexto = servicioProductos
                    .GetLista(1, 1000, p => p.Activo)
                    .Count.ToString("N0", CultureInfo.GetCultureInfo("es-AR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar las estadísticas del inicio:\n{ex.Message}",
                    "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AgregarTarjeta(panelInicioModerno, "VENTAS DEL DÍA", ventasHoyTexto, 36, 148);
            AgregarTarjeta(panelInicioModerno, "VENTAS REGISTRADAS", cantidadVentasTexto, 320, 148);
            AgregarTarjeta(panelInicioModerno, "PRODUCTOS ACTIVOS", productosActivosTexto, 604, 148);



            var banner = new Panel
            {
                Name = "panelBanner",
                Location = new Point(36, 650),
                Size = new Size(835, 280),
                BackColor = Color.FromArgb(40, 20, 20),
                BackgroundImage = Image.FromFile(
                    Path.Combine(
                        AppContext.BaseDirectory,
                        "LogoHamburgueseria.png")),
                BackgroundImageLayout = ImageLayout.Stretch,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            panelInicioModerno.Controls.Add(banner);

            var botonNuevaVenta = new Button
            {
                Text = "Nueva venta",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(190, 68, 44),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Location = new Point(36, 950),
                Size = new Size(195, 48)
            };
            botonNuevaVenta.FlatAppearance.BorderSize = 0;
            botonNuevaVenta.Click += btnOrdenes_Click;
            panelInicioModerno.Controls.Add(botonNuevaVenta);

            AgregarGraficoVentas(panelInicioModerno);
            AgregarRankingProductos(panelInicioModerno);

            panelFormHijo.Controls.Add(panelInicioModerno);
            panelFormHijo.Visible = true;
        }


        private void AgregarGraficoVentas(Panel contenedor)
        {
            // Obtener las ventas registradas
            var servicioVentas = _serviceProvider!
                .GetRequiredService<IServiciosVentas>();

            var ventas = servicioVentas.GetLista()
                .Where(v => !v.Anulada)
                .ToList();

            // Obtener el lunes de la semana actual
            DateTime hoy = DateTime.Today;

            int diasDesdeLunes =
                ((int)hoy.DayOfWeek + 6) % 7;

            DateTime lunes = hoy.AddDays(-diasDesdeLunes);

            string[] dias =
            {
        "Lun", "Mar", "Mié", "Jue",
        "Vie", "Sáb", "Dom"
    };

            double[] importes = new double[7];

            // Calcular ventas de cada día
            for (int i = 0; i < 7; i++)
            {
                DateTime fecha = lunes.AddDays(i);

                importes[i] = (double)ventas
                    .Where(v => v.FechaVenta.Date == fecha.Date)
                    .Sum(v => v.Total);
            }

            // Título
            var titulo = new System.Windows.Forms.Label
            {
                Text = "Ventas de la semana",
                Font = new System.Drawing.Font(
                    "Segoe UI", 16F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(38, 37, 37),
                Location = new Point(36, 296),
                Size = new Size(485, 35)
            };

            contenedor.Controls.Add(titulo);

            // Crear gráfico
            var grafico = new FormsPlot
            {
                Location = new Point(36, 340),
                Size = new Size(485, 265),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            // Dibujar las siete barras
            grafico.Plot.Add.Bars(importes);

            // Etiquetas de los días
            ScottPlot.Tick[] etiquetas = new ScottPlot.Tick[7];

            for (int i = 0; i < 7; i++)
            {
                etiquetas[i] = new ScottPlot.Tick(i, dias[i]);
            }

            grafico.Plot.Axes.Bottom.TickGenerator =
                new ScottPlot.TickGenerators.NumericManual(etiquetas);

            grafico.Plot.Axes.Margins(bottom: 0);

            grafico.Refresh();

            contenedor.Controls.Add(grafico);
        }


        private void AgregarRankingProductos(Panel contenedor)
        {
            var titulo = new Label
            {
                Text = "Productos más vendidos",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(38, 37, 37),
                Location = new Point(540, 296),
                Size = new Size(330, 40)
            };

            contenedor.Controls.Add(titulo);

            var panelRanking = new Panel
            {
                Location = new Point(540, 340),
                Size = new Size(331, 265),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            var servicioVentas = _serviceProvider!
                .GetRequiredService<IServiciosVentas>();

            var ranking = servicioVentas.GetLista()
                .Where(v => !v.Anulada)
                .SelectMany(v => v.Detalles)
                .GroupBy(d => d.ProductoId)
                .Select(g => new
                {
                    Producto = g.First().Producto?.Nombre ?? "Producto sin nombre",
                    Cantidad = g.Sum(d => d.Cantidad)
                })
                .OrderByDescending(x => x.Cantidad)
                .ThenBy(x => x.Producto)
                .Take(5)
                .ToList();

            if (ranking.Count == 0)
            {
                panelRanking.Controls.Add(new Label
                {
                    Text = "Todavía no hay productos vendidos.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    Location = new Point(20, 25),
                    AutoSize = true
                });
            }
            else
            {
                int y = 20;

                for (int i = 0; i < ranking.Count; i++)
                {
                    var producto = ranking[i];

                    var etiqueta = new Label
                    {
                        Text = $"{i + 1}. {producto.Producto}",
                        Font = new Font("Segoe UI", 10F),
                        ForeColor = Color.FromArgb(50, 50, 50),
                        Location = new Point(15, y),
                        Size = new Size(230, 30)
                    };

                    var cantidad = new Label
                    {
                        Text = $"{producto.Cantidad} uds.",
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(145, 39, 34),
                        Location = new Point(245, y),
                        Size = new Size(72, 30),
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    panelRanking.Controls.Add(etiqueta);
                    panelRanking.Controls.Add(cantidad);

                    y += 45;
                }
            }

            contenedor.Controls.Add(panelRanking);
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

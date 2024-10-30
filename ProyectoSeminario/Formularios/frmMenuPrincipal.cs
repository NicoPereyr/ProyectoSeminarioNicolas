using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        public frmMenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _serviceProvider = serviceProvider;
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelFormHijo.Controls.Count > 0)
            {
                // Cierra cualquier formulario que esté previamente abierto en el panel
                this.panelFormHijo.Controls[0].Dispose();
            }

            formHijo.TopLevel = false;  // Indica que este formulario no es de nivel superior
            formHijo.FormBorderStyle = FormBorderStyle.None;  // Sin borde
            formHijo.Dock = DockStyle.Fill;  // Hace que el formulario ocupe todo el panel

            this.panelFormHijo.Controls.Add(formHijo);  // Añade el formulario al panel
            this.panelFormHijo.Tag = formHijo;  // Asigna el formulario al Tag del panel
            formHijo.BringToFront();  // Trae el formulario al frente
            formHijo.Show();  // Muestra el formulario
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(14, 30, 54));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }



        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos(_serviceProvider);
            AbrirFormularioEnPanel(frm);
            panelFormHijo.Visible = true;
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias(_serviceProvider);
            AbrirFormularioEnPanel(frm);
            panelFormHijo.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            {
                frmEmpleados frm = new frmEmpleados(_serviceProvider);
                AbrirFormularioEnPanel(frm);
                panelFormHijo.Visible = true;
            }

        }
    }
}

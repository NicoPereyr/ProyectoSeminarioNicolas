namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmFiltroTexto : Form
    {
        public frmFiltroTexto()
        {
            InitializeComponent();
        }

        private string textoBusqueda = string.Empty;
        public string GetTexto() => textoBusqueda;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltrarTexto.Text.Trim()))
            {
                textoBusqueda = txtFiltrarTexto.Text.Trim();
            }
            DialogResult = DialogResult.OK;
        }
    }
}

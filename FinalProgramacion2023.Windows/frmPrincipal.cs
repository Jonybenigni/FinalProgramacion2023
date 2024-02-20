using FinalProgramacion2023.Entidades;

namespace FinalProgramacion2023.Windows
{
    public partial class frmPrincipal : Form
    {
        private List<Triangulo> triangulos;

        public frmPrincipal()
        {
            InitializeComponent();

            triangulos = new List<Triangulo>();
            ActualizarCantidadRegistros();
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmTrianguloAE frm = new frmTrianguloAE() { Text = "Agregar Triángulo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Triangulo triangulo = frm.GetTriangulo();
            if (!triangulos.Contains(triangulo))
            {
                triangulos.Add(triangulo);
                ActualizarCantidadRegistros();

                DataGridViewRow r = ConstruirFila();
                SetearFila(r, triangulo);
                AgregarFila(r);

                MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Registro existente", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void SetearFila(DataGridViewRow r, Triangulo triangulo)
        {
            r.Cells[colLado.Index].Value = triangulo.LadoA;
            r.Cells[colBorde.Index].Value = triangulo.TipoDeBorde;
            r.Cells[colRelleno.Index].Value = triangulo.ColorRelleno;
            r.Cells[colArea.Index].Value = triangulo.GetArea;
            r.Cells[colPerimetro.Index].Value = triangulo.GetPerimetro;
            r.Cells[colTipoTriangulo.Index].Value = triangulo.TipoTriangulo;

            r.Tag = triangulo;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void ActualizarCantidadRegistros()
        {
            txtCantidad.Text = triangulos.Count.ToString();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }
        private void tsbActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

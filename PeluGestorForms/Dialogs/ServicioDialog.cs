using System;
using System.Windows.Forms;

namespace PeluGestor.Dialogs
{
    public partial class ServicioDialog : Form
    {
        public string Nombre;
        public string Descripcion;
        public decimal Precio;
        public int DuracionMin;

        public ServicioDialog()
        {
            InitializeComponent();

            TxtPrecio.Text = "0";
            TxtDuracion.Text = "30";
        }

        public void CargarParaEditar(string nombre, string descripcion, decimal precio, int duracionMin)
        {
            TxtNombre.Text = nombre;
            TxtDescripcion.Text = descripcion;
            TxtPrecio.Text = precio.ToString();
            TxtDuracion.Text = duracionMin.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show(
                    "El nombre es obligatorio.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                TxtNombre.Focus();
                return;
            }

            decimal precio = decimal.Parse(TxtPrecio.Text.Trim());

            if (precio < 0)
            {
                MessageBox.Show(
                    "Precio invalido. Usa formato 10.50",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                TxtPrecio.Focus();
                return;
            }

            int dur = int.Parse(TxtDuracion.Text.Trim());

            if (dur <= 0)
            {
                MessageBox.Show(
                    "Duracion invalida. Debe ser mayor que 0.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                TxtDuracion.Focus();
                return;
            }

            Nombre = nombre;

            if (TxtDescripcion.Text == null || TxtDescripcion.Text.Trim() == "")
                Descripcion = null;
            else
                Descripcion = TxtDescripcion.Text.Trim();

            Precio = precio;
            DuracionMin = dur;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

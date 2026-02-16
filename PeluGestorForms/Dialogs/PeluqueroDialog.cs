using System;
using System.Windows.Forms;

namespace PeluGestor.Dialogs
{
    public partial class PeluqueroDialog : Form
    {
        public string Nombre;
        public bool Activo;

        public PeluqueroDialog()
        {
            InitializeComponent();
            ChkActivo.Checked = true;
            Activo = true;
        }

        public void CargarParaEditar(string nombre, bool activo)
        {
            TxtNombre.Text = nombre;
            ChkActivo.Checked = activo;
            Activo = activo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show(
                    "El nombre del peluquero es obligatorio.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                TxtNombre.Focus();
                return;
            }

            Nombre = nombre;
            Activo = ChkActivo.Checked;

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

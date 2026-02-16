using PeluGestor.Data;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PeluGestor.Dialogs
{
    public partial class ReservaDialog : Form
    {
        public string NombreCliente;
        public string Telefono;
        public DateTime Fecha;
        public TimeSpan Hora;
        public int ServicioId;
        public int PeluqueroId;

        private int peluqueriaId;

        public ReservaDialog(int peluqueriaId)
        {
            InitializeComponent();
            this.peluqueriaId = peluqueriaId;

            CargarCombos();

            DpFecha.Value = DateTime.Today;
            TxtHora.Text = "10:00";
        }

        public void CargarParaEditar(string cliente, string telefono, DateTime fecha, TimeSpan hora, int servicioId, int peluqueroId)
        {
            TxtCliente.Text = cliente;
            TxtTelefono.Text = telefono;
            DpFecha.Value = fecha.Date;
            TxtHora.Text = hora.ToString(@"hh\:mm");

            CmbServicio.SelectedValue = servicioId;
            CmbPeluquero.SelectedValue = peluqueroId;
        }

        private void CargarCombos()
        {
            DataTable dtServicios = ServiciosDao.ObtenerPorPeluqueria(peluqueriaId);
            CmbServicio.DataSource = dtServicios;
            CmbServicio.DisplayMember = "Nombre";
            CmbServicio.ValueMember = "Id";
            if (dtServicios.Rows.Count > 0)
                CmbServicio.SelectedIndex = 0;

            DataTable dtPeluqueros = PeluquerosDao.ObtenerPorPeluqueria(peluqueriaId);
            DataView dv = dtPeluqueros.DefaultView;
            dv.RowFilter = "Activo = true";

            CmbPeluquero.DataSource = dv;
            CmbPeluquero.DisplayMember = "Nombre";
            CmbPeluquero.ValueMember = "Id";
            if (dv.Count > 0)
                CmbPeluquero.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cliente = TxtCliente.Text == null ? "" : TxtCliente.Text.Trim();
            string tel = TxtTelefono.Text == null ? "" : TxtTelefono.Text.Trim();

            if (cliente == "")
            {
                MessageBox.Show("Cliente obligatorio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCliente.Focus();
                return;
            }

            if (tel == "")
            {
                MessageBox.Show("Telefono obligatorio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTelefono.Focus();
                return;
            }

            if (tel.Length != 9 || !long.TryParse(tel, out _))
            {
                MessageBox.Show(
                    "El telefono debe tener 9 digitos y contener solo numeros.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                TxtTelefono.Focus();
                return;
            }

            DateTime dt = DpFecha.Value.Date;

            TimeSpan hora;
            if (!TimeSpan.TryParseExact(
                TxtHora.Text == null ? "" : TxtHora.Text.Trim(),
                "hh\\:mm",
                CultureInfo.InvariantCulture,
                out hora))
            {
                MessageBox.Show(
                    "Hora invalida. Formato HH:MM (ej 10:30).",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                TxtHora.Focus();
                return;
            }

            if (CmbServicio.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un servicio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbPeluquero.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un peluquero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NombreCliente = cliente;
            Telefono = tel;
            Fecha = dt;
            Hora = hora;
            ServicioId = (int)CmbServicio.SelectedValue;
            PeluqueroId = (int)CmbPeluquero.SelectedValue;

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

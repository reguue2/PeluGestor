using PeluGestor.Data;
using PeluGestor.Dialogs;
using System;
using System.Data;
using System.Windows.Forms;

namespace PeluGestor.Views
{
    public partial class ReservasView : UserControl
    {
        private DataTable dt = new DataTable();

        public ReservasView()
        {
            InitializeComponent();
            try
            {
                CargarPeluquerias();
                CmbPeluqueria.SelectedValue = 0;
                DpFecha.Value = DateTime.Today;
                DpFecha.Checked = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las reservas.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarPeluquerias()
        {
            DataTable dtPelus = PeluqueriasDao.ObtenerTodo();

            DataRow filaTodas = dtPelus.NewRow();
            filaTodas["Id"] = 0;
            filaTodas["Nombre"] = "Todas";
            dtPelus.Rows.InsertAt(filaTodas, 0);

            CmbPeluqueria.DataSource = dtPelus;
            CmbPeluqueria.DisplayMember = "Nombre";
            CmbPeluqueria.ValueMember = "Id";
        }

        private int PeluqueriaId()
        {
            if (CmbPeluqueria.SelectedItem == null)
                return 0;

            DataRowView drv = CmbPeluqueria.SelectedItem as DataRowView;

            if (drv == null)
                return 0;

            return Convert.ToInt32(drv["Id"]);
        }

        private DateTime? FechaSeleccionada()
        {
            if (!DpFecha.Checked)
                return null;

            return DpFecha.Value.Date;
        }

        private string EstadoSeleccionado()
        {
            if (CmbEstado.SelectedItem == null)
                return "";

            string txt = CmbEstado.SelectedItem.ToString();
            if (txt == "Todos") return "";
            return txt;
        }

        private void CargarDatos()
        {
            int pid = PeluqueriaId();
            DateTime? fecha = FechaSeleccionada();
            string estado = EstadoSeleccionado();

            dt = ReservasDao.Filtrar(pid, fecha, estado);
            Grid.DataSource = dt;
        }

        private DataRowView FilaSeleccionada()
        {
            if (Grid.CurrentRow == null) return null;
            return Grid.CurrentRow.DataBoundItem as DataRowView;
        }

        private void CmbPeluqueria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void DpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            int pid = PeluqueriaId();

            if (pid == 0)
            {
                MessageBox.Show(
                    "Seleccione una peluqueria concreta para crear una reserva.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ReservaDialog dlg = new ReservaDialog(pid);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Fecha.Date < DateTime.Today)
                {
                    MessageBox.Show(
                        "No se pueden crear reservas en fechas pasadas.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int res = ReservasDao.Insertar(
                    pid,
                    dlg.ServicioId,
                    dlg.PeluqueroId,
                    dlg.NombreCliente,
                    dlg.Telefono,
                    dlg.Fecha,
                    dlg.Hora
                );

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo insertar la reserva.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataRowView row = FilaSeleccionada();
            if (row == null)
            {
                MessageBox.Show(
                    "Seleccione una reserva para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (row["Estado"].ToString() == "cancelada")
            {
                MessageBox.Show(
                    "No se puede editar una reserva que esta cancelada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToDateTime(row["Fecha"]).Date < DateTime.Today)
            {
                MessageBox.Show(
                    "No se pueden editar reservas de fechas pasadas.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);
            int pid = Convert.ToInt32(row["PeluqueriaId"]);

            ReservaDialog dlg = new ReservaDialog(pid);
            dlg.CargarParaEditar(
                row["NombreCliente"].ToString(),
                row["Telefono"].ToString(),
                Convert.ToDateTime(row["Fecha"]),
                (TimeSpan)row["Hora"],
                Convert.ToInt32(row["ServicioId"]),
                Convert.ToInt32(row["PeluqueroId"])
            );

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Fecha.Date < DateTime.Today)
                {
                    MessageBox.Show(
                        "No se pueden editar reservas en fechas pasadas.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int res = ReservasDao.Update(
                    id,
                    dlg.ServicioId,
                    dlg.PeluqueroId,
                    dlg.NombreCliente,
                    dlg.Telefono,
                    dlg.Fecha,
                    dlg.Hora
                );

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo actualizar la reserva.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                CargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DataRowView row = FilaSeleccionada();
            if (row == null)
            {
                MessageBox.Show(
                    "Seleccione una reserva para cancelar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (row["Estado"].ToString() == "cancelada")
            {
                MessageBox.Show(
                    "La reserva ya esta cancelada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToDateTime(row["Fecha"]).Date < DateTime.Today)
            {
                MessageBox.Show(
                    "No se puede cancelar una reserva de una fecha pasada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DialogResult res = MessageBox.Show(
                "Desea cancelar esta reserva?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;

            ReservasDao.Cancelar(Convert.ToInt32(row["Id"]));
            CargarDatos();
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] ocultas = { "Id", "PeluqueriaId", "ServicioId", "PeluqueroId" };
            foreach (var col in ocultas)
                if (Grid.Columns.Contains(col))
                    Grid.Columns[col].Visible = false;

            if (Grid.Columns.Contains("Fecha"))
            {
                Grid.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (Grid.Columns.Contains("Hora"))
            {
                Grid.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNueva_Click(sender, e);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
        }
    }
}

using PeluGestor.Data;
using PeluGestor.Dialogs;
using System;
using System.Data;
using System.Windows.Forms;

namespace PeluGestor.Views
{
    public partial class ServiciosView : UserControl
    {
        private DataTable dt = new DataTable();

        public ServiciosView()
        {
            InitializeComponent();
            try
            {
                CargarPeluqueria();
                CmbPeluqueria.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las peluquerias.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarPeluqueria()
        {
            DataTable dtPelus = PeluqueriasDao.ObtenerTodo();

            DataRow filaTodas = dtPelus.NewRow();
            filaTodas["Id"] = 0;
            filaTodas["Nombre"] = "Todas";
            dtPelus.Rows.InsertAt(filaTodas, 0);

            CmbPeluqueria.DataSource = null;

            CmbPeluqueria.DisplayMember = "Nombre";
            CmbPeluqueria.ValueMember = "Id";
            CmbPeluqueria.DataSource = dtPelus;
        }


        private int PeluqueriaId()
        {
            if (CmbPeluqueria.SelectedValue == null)
                return -1;

            return Convert.ToInt32(CmbPeluqueria.SelectedValue);
        }

        private void CargarDatos()
        {
            int pid = PeluqueriaId();

            if (pid == 0)
                dt = ServiciosDao.ObtenerTodos();
            else
                dt = ServiciosDao.ObtenerPorPeluqueria(pid);

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

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            int pid = PeluqueriaId();
            if (pid < 0) return;

            string q = TxtBuscar.Text.Trim();

            if (q == "")
            {
                CargarDatos();
                return;
            }

            if (pid == 0)
                dt = ServiciosDao.BuscarTodos(q);
            else
                dt = ServiciosDao.Buscar(pid, q);

            Grid.DataSource = dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int pid = PeluqueriaId();

            if (pid <= 0)
            {
                MessageBox.Show(
                    "Seleccione una peluqueria primero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ServicioDialog dlg = new ServicioDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = ServiciosDao.Insertar(
                    pid,
                    dlg.Nombre,
                    dlg.Descripcion,
                    dlg.Precio,
                    dlg.DuracionMin
                );

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo insertar el servicio.",
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
                    "Seleccione un servicio para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);
            string nombre = row["Nombre"].ToString();
            string desc = row["Descripcion"].ToString();
            decimal precio = Convert.ToDecimal(row["Precio"]);
            int dur = Convert.ToInt32(row["Duracion"]);

            ServicioDialog dlg = new ServicioDialog();
            dlg.CargarParaEditar(nombre, desc, precio, dur);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = ServiciosDao.Update(
                    id,
                    dlg.Nombre,
                    dlg.Descripcion,
                    dlg.Precio,
                    dlg.DuracionMin
                );

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo actualizar el servicio.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView row = FilaSeleccionada();

            if (row == null)
            {
                MessageBox.Show(
                    "Seleccione un servicio para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);

            if (ServiciosDao.TieneReservasFuturas(id))
            {
                MessageBox.Show(
                    "No se puede eliminar el servicio porque tiene reservas futuras.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show(
                "Eliminar servicio?\nSe eliminarán también sus reservas pasadas.",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;

            ServiciosDao.QuitarReservasPasadas(id);

            int r = ServiciosDao.Delete(id);

            if (r <= 0)
            {
                MessageBox.Show(
                    "No se pudo eliminar el servicio.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CargarDatos();
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Grid.Columns.Contains("Id"))
                Grid.Columns["Id"].Visible = false;

            if (Grid.Columns.Contains("PeluqueriaId"))
                Grid.Columns["PeluqueriaId"].Visible = false;

            if (Grid.Columns.Contains("Precio"))
            {
                Grid.Columns["Precio"].DefaultCellStyle.Format = "0.00 €";
            }

            if (Grid.Columns.Contains("DuracionMin"))
            {
                Grid.Columns["DuracionMin"].DefaultCellStyle.Format = "0 'min'";
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNuevo_Click(sender, e);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e);
        }
    }
}

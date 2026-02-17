using PeluGestor.Data;
using PeluGestor.Dialogs;
using System;
using System.Data;
using System.Windows.Forms;

namespace PeluGestor.Views
{
    public partial class PeluquerosView : UserControl
    {
        private DataTable dt = new DataTable();

        public PeluquerosView()
        {
            InitializeComponent();
            try
            {
                CargarPeluquerias();
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
                return -1;

            DataRowView row = CmbPeluqueria.SelectedItem as DataRowView;

            if (row == null)
                return -1;

            return Convert.ToInt32(row["Id"]);
        }

        private void CargarDatos()
        {
            int pid = PeluqueriaId();

            if (pid == 0)
                dt = PeluquerosDao.ObtenerTodos();
            else
                dt = PeluquerosDao.ObtenerPorPeluqueria(pid);

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
                dt = PeluquerosDao.BuscarTodos(q);
            else
                dt = PeluquerosDao.Buscar(pid, q);

            Grid.DataSource = dt;
        }

        private void btnNueva_Click(object sender, EventArgs e)
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

            PeluqueroDialog dlg = new PeluqueroDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = PeluquerosDao.Insertar(pid, dlg.Nombre, dlg.Activo);

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo insertar el peluquero.",
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
                    "Seleccione un peluquero para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);
            string nombre = row["Nombre"].ToString();
            bool activo = Convert.ToBoolean(row["Activo"]);

            PeluqueroDialog dlg = new PeluqueroDialog();
            dlg.CargarParaEditar(nombre, activo);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = PeluquerosDao.Update(id, dlg.Nombre, dlg.Activo);

                if (res <= 0)
                {
                    MessageBox.Show(
                        "No se pudo actualizar el peluquero.",
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
                    "Seleccione un peluquero para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);

            if (PeluquerosDao.TieneReservasFuturas(id))
            {
                MessageBox.Show(
                    "No se puede eliminar porque tiene reservas futuras.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show(
                "Eliminar peluquero?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;

            PeluquerosDao.QuitarDeReservasPasadas(id);

            int r = PeluquerosDao.Delete(id);

            if (r <= 0)
            {
                MessageBox.Show(
                    "No se pudo eliminar el peluquero.",
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

            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNueva_Click(sender, e);
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

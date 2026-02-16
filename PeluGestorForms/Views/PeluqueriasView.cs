using PeluGestor.Data;
using PeluGestor.Dialogs;
using System;
using System.Data;
using System.Windows.Forms;

namespace PeluGestor.Views
{
    public partial class PeluqueriasView : UserControl
    {
        private DataTable dt = new DataTable();

        public PeluqueriasView()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dt = PeluqueriasDao.ObtenerTodo();
            Grid.DataSource = dt;
        }

        private DataRowView FilaSeleccionada()
        {
            if (Grid.CurrentRow == null) return null;
            return Grid.CurrentRow.DataBoundItem as DataRowView;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            PeluqueriaDialog dlg = new PeluqueriaDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = PeluqueriasDao.Insertar(
                    dlg.Nombre,
                    dlg.Direccion,
                    dlg.Telefono,
                    dlg.Horario,
                    dlg.DiasCerrados
                );

                if (res <= 0)
                {
                    MessageBox.Show("No se pudo insertar la peluqueria.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una peluqueria para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);
            string nombre = row["Nombre"].ToString();
            string direccion = row["Direccion"].ToString();
            string telefono = row["Telefono"].ToString();
            string horario = row["Horario"].ToString();
            string dias = row["DiasCerrados"].ToString();

            PeluqueriaDialog dlg = new PeluqueriaDialog();
            dlg.CargarParaEditar(id, nombre, direccion, telefono, horario, dias);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int res = PeluqueriasDao.Update(
                    id,
                    dlg.Nombre,
                    dlg.Direccion,
                    dlg.Telefono,
                    dlg.Horario,
                    dlg.DiasCerrados
                );

                if (res <= 0)
                {
                    MessageBox.Show("No se pudo actualizar la peluqueria.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una peluqueria para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(row["Id"]);
            string nombre = row["Nombre"].ToString();

            DialogResult confirm = MessageBox.Show(
                "Eliminar la peluqueria '" + nombre + "'?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            int res = PeluqueriasDao.Delete(id);

            if (res <= 0)
            {
                MessageBox.Show("No se pudo eliminar la peluqueria.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarDatos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string q = TxtBuscar.Text.Trim();

            if (q == "")
            {
                CargarDatos();
                return;
            }

            dt = PeluqueriasDao.BuscarPorNombre(q);
            Grid.DataSource = dt;
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Grid.Columns.Contains("Id"))
                Grid.Columns["Id"].Visible = false;

            if (Grid.Columns.Contains("Nombre"))
                Grid.Columns["Nombre"].Width = 200;

            if (Grid.Columns.Contains("Direccion"))
                Grid.Columns["Direccion"].Width = 260;

            if (Grid.Columns.Contains("Telefono"))
                Grid.Columns["Telefono"].Width = 120;

            if (Grid.Columns.Contains("Horario"))
                Grid.Columns["Horario"].Width = 160;

            if (Grid.Columns.Contains("DiasCerrados"))
                Grid.Columns["DiasCerrados"].Width = 160;
        }
    }
}

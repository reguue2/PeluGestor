using PeluGestor.Views;
using System;
using System.Windows.Forms;

namespace PeluGestor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CargarVista(new InicioView());
        }

        private void CargarVista(UserControl vista)
        {
            MainContentPanel.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            MainContentPanel.Controls.Add(vista);
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            CargarVista(new InicioView());
        }

        private void Peluquerias_Click(object sender, EventArgs e)
        {
            CargarVista(new PeluqueriasView());
        }

        private void Peluqueros_Click(object sender, EventArgs e)
        {
            CargarVista(new PeluquerosView());
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            CargarVista(new ServiciosView());
        }

        private void Reservas_Click(object sender, EventArgs e)
        {
            CargarVista(new ReservasView());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PeluGestor\nAplicacion de gestion de peluquerias\n\nProyecto de Desarrollo de Interfaces",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace PeluGestor.Views
{
    partial class InicioView
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblDescripcion;

        private GroupBox grpFunciones;
        private Label lblF1;
        private Label lblF2;
        private Label lblF3;
        private Label lblF4;

        private GroupBox grpFlujo;
        private Label lblFlujo1;
        private Label lblFlujo2;
        private Label lblFlujo3;
        private Label lblFlujo4;
        private Label lblFlujo5;

        private GroupBox grpInformes;
        private Label lblI1;
        private Label lblI2;
        private Label lblI3;

        private GroupBox grpConsejos;
        private Label lblC1;
        private Label lblC2;
        private Label lblC3;
        private Label lblC4;

        private Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BackColor = Color.WhiteSmoke;

            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblDescripcion = new Label();
            lblFooter = new Label();

            grpFunciones = new GroupBox();
            grpFlujo = new GroupBox();
            grpInformes = new GroupBox();
            grpConsejos = new GroupBox();

            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 70;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(28, 30, 69);
            lblTitulo.Text = "Bienvenido a Integrow";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Height = 30;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Text = "Sistema de Gestión de Peluquerías";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;

            lblDescripcion.Dock = DockStyle.Top;
            lblDescripcion.Height = 35;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.Gray;
            lblDescripcion.Text = "Control centralizado de negocios, empleados y reservas";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;

            grpFunciones.Text = "Funciones del sistema";
            grpFunciones.Dock = DockStyle.Fill;
            grpFunciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFunciones.BackColor = Color.White;
            grpFunciones.Padding = new Padding(20);

            lblF1 = CrearItem("• Gestionar peluquerías, empleados y servicios");
            lblF2 = CrearItem("• Crear y administrar reservas de clientes");
            lblF3 = CrearItem("• Controlar horarios, precios y disponibilidad");
            lblF4 = CrearItem("• Visualizar la información de forma clara");

            grpFunciones.Controls.Add(lblF4);
            grpFunciones.Controls.Add(lblF3);
            grpFunciones.Controls.Add(lblF2);
            grpFunciones.Controls.Add(lblF1);

            grpFlujo.Text = "Flujo de trabajo recomendado";
            grpFlujo.Dock = DockStyle.Fill;
            grpFlujo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFlujo.BackColor = Color.White;
            grpFlujo.Padding = new Padding(20);

            lblFlujo1 = CrearItem("1. Registrar una peluquería con su horario.");
            lblFlujo2 = CrearItem("2. Añadir peluqueros a cada peluquería.");
            lblFlujo3 = CrearItem("3. Configurar servicios con precio y duración.");
            lblFlujo4 = CrearItem("4. Crear reservas para los clientes.");
            lblFlujo5 = CrearItem("5. Analizar la carga de trabajo mediante informes.");

            grpFlujo.Controls.Add(lblFlujo5);
            grpFlujo.Controls.Add(lblFlujo4);
            grpFlujo.Controls.Add(lblFlujo3);
            grpFlujo.Controls.Add(lblFlujo2);
            grpFlujo.Controls.Add(lblFlujo1);

            grpInformes.Text = "Informes disponibles";
            grpInformes.Dock = DockStyle.Fill;
            grpInformes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInformes.BackColor = Color.White;
            grpInformes.Padding = new Padding(20);

            lblI1 = CrearItem("• Minutos trabajados por peluquero.");
            lblI2 = CrearItem("• Número de reservas por fecha.");
            lblI3 = CrearItem("• Servicios más utilizados por peluquería.");

            grpInformes.Controls.Add(lblI3);
            grpInformes.Controls.Add(lblI2);
            grpInformes.Controls.Add(lblI1);

            grpConsejos.Text = "Consejos de uso";
            grpConsejos.Dock = DockStyle.Fill;
            grpConsejos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpConsejos.BackColor = Color.White;
            grpConsejos.Padding = new Padding(20);

            lblC1 = CrearItem("• Revise periódicamente las reservas futuras.");
            lblC2 = CrearItem("• Mantenga actualizada la duración de servicios.");
            lblC3 = CrearItem("• Utilice los informes para optimizar recursos.");
            lblC4 = CrearItem("• Controle la disponibilidad del personal.");

            grpConsejos.Controls.Add(lblC4);
            grpConsejos.Controls.Add(lblC3);
            grpConsejos.Controls.Add(lblC2);
            grpConsejos.Controls.Add(lblC1);

            TableLayoutPanel panelDashboard = new TableLayoutPanel();
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.ColumnCount = 2;
            panelDashboard.RowCount = 2;
            panelDashboard.Padding = new Padding(40, 20, 40, 20);
            panelDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            panelDashboard.Controls.Add(grpFunciones, 0, 0);
            panelDashboard.Controls.Add(grpFlujo, 1, 0);
            panelDashboard.Controls.Add(grpInformes, 0, 1);
            panelDashboard.Controls.Add(grpConsejos, 1, 1);

            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Height = 30;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Text = "Proyecto desarrollado por Diego Regueira · Desarrollo de Interfaces";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(panelDashboard);
            this.Controls.Add(lblFooter);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(lblSubtitulo);
            this.Controls.Add(lblTitulo);

            this.Size = new Size(1347, 718);
        }

        private Label CrearItem(string texto)
        {
            return new Label()
            {
                Dock = DockStyle.Top,
                Height = 25,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                Text = texto
            };
        }
    }
}

using System.Windows.Forms;

namespace PeluGestor.Views
{
    partial class InicioView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox grpFunciones;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Label lblF4;
        private System.Windows.Forms.GroupBox grpRecomendacion;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grpFunciones = new System.Windows.Forms.GroupBox();
            this.lblF4 = new System.Windows.Forms.Label();
            this.lblF3 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblF1 = new System.Windows.Forms.Label();
            this.grpRecomendacion = new System.Windows.Forms.GroupBox();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.grpFunciones.SuspendLayout();
            this.grpRecomendacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1347, 60);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Bienvenido a Integrow";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(1347, 30);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Aplicacion de gestion de peluquerias";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.Location = new System.Drawing.Point(0, 90);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1347, 30);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Control centralizado de negocios, empleados y reservas";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFunciones
            // 
            this.grpFunciones.Controls.Add(this.lblF4);
            this.grpFunciones.Controls.Add(this.lblF3);
            this.grpFunciones.Controls.Add(this.lblF2);
            this.grpFunciones.Controls.Add(this.lblF1);
            this.grpFunciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFunciones.Location = new System.Drawing.Point(0, 120);
            this.grpFunciones.Name = "grpFunciones";
            this.grpFunciones.Padding = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.grpFunciones.Size = new System.Drawing.Size(1347, 189);
            this.grpFunciones.TabIndex = 2;
            this.grpFunciones.TabStop = false;
            this.grpFunciones.Text = "¿Que puedes hacer desde aqui?";
            // 
            // lblF4
            // 
            this.lblF4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblF4.Location = new System.Drawing.Point(30, 92);
            this.lblF4.Name = "lblF4";
            this.lblF4.Size = new System.Drawing.Size(1314, 23);
            this.lblF4.TabIndex = 0;
            this.lblF4.Text = "• Visualizar la informacion de forma clara y ordenada";
            // 
            // lblF3
            // 
            this.lblF3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblF3.Location = new System.Drawing.Point(30, 69);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(1314, 23);
            this.lblF3.TabIndex = 1;
            this.lblF3.Text = "• Controlar horarios, precios y disponibilidad";
            // 
            // lblF2
            // 
            this.lblF2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblF2.Location = new System.Drawing.Point(30, 46);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(1314, 23);
            this.lblF2.TabIndex = 2;
            this.lblF2.Text = "• Crear y administrar reservas de clientes";
            // 
            // lblF1
            // 
            this.lblF1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblF1.Location = new System.Drawing.Point(30, 23);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(1314, 23);
            this.lblF1.TabIndex = 3;
            this.lblF1.Text = "• Gestionar peluquerias, empleados y servicios";
            // 
            // grpRecomendacion
            // 
            this.grpRecomendacion.Controls.Add(this.lblR3);
            this.grpRecomendacion.Controls.Add(this.lblR2);
            this.grpRecomendacion.Controls.Add(this.lblR1);
            this.grpRecomendacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRecomendacion.Location = new System.Drawing.Point(0, 309);
            this.grpRecomendacion.Name = "grpRecomendacion";
            this.grpRecomendacion.Padding = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.grpRecomendacion.Size = new System.Drawing.Size(1347, 120);
            this.grpRecomendacion.TabIndex = 1;
            this.grpRecomendacion.TabStop = false;
            this.grpRecomendacion.Text = "Recomendacion de uso";
            // 
            // lblR3
            // 
            this.lblR3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblR3.Location = new System.Drawing.Point(30, 69);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(1314, 23);
            this.lblR3.TabIndex = 0;
            this.lblR3.Text = "3. Comienza a gestionar reservas de clientes";
            // 
            // lblR2
            // 
            this.lblR2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblR2.Location = new System.Drawing.Point(30, 46);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(1314, 23);
            this.lblR2.TabIndex = 1;
            this.lblR2.Text = "2. Da de alta peluqueros y servicios";
            // 
            // lblR1
            // 
            this.lblR1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblR1.Location = new System.Drawing.Point(30, 23);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(1314, 23);
            this.lblR1.TabIndex = 2;
            this.lblR1.Text = "1. Crea o revisa las peluquerias registradas";
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 688);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1347, 30);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Proyecto desarrollado por Diego Regueira · Desarrollo de Interfaces";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InicioView
            // 
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.grpRecomendacion);
            this.Controls.Add(this.grpFunciones);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "InicioView";
            this.Size = new System.Drawing.Size(1347, 718);
            this.grpFunciones.ResumeLayout(false);
            this.grpRecomendacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

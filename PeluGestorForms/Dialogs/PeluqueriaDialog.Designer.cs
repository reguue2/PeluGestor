namespace PeluGestor.Dialogs
{
    partial class PeluqueriaDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtHorario;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtHorario = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 20;
            int textX = 160;
            int y = 20;
            int spacing = 40;

            // Nombre
            lblNombre.Text = "Nombre:";
            lblNombre.Left = labelX;
            lblNombre.Top = y;
            TxtNombre.Left = textX;
            TxtNombre.Top = y;
            TxtNombre.Width = 280;
            TxtNombre.MaxLength = 100;

            y += spacing;

            // Dirección
            lblDireccion.Text = "Direccion:";
            lblDireccion.Left = labelX;
            lblDireccion.Top = y;
            TxtDireccion.Left = textX;
            TxtDireccion.Top = y;
            TxtDireccion.Width = 280;

            y += spacing;

            // Teléfono
            lblTelefono.Text = "Telefono:";
            lblTelefono.Left = labelX;
            lblTelefono.Top = y;
            TxtTelefono.Left = textX;
            TxtTelefono.Top = y;
            TxtTelefono.Width = 280;

            y += spacing;

            // Horario
            lblHorario.Text = "Horario:";
            lblHorario.Left = labelX;
            lblHorario.Top = y;
            TxtHorario.Left = textX;
            TxtHorario.Top = y;
            TxtHorario.Width = 280;

            y += spacing;

            // Días
            lblDias.Text = "Dias cerrados:";
            lblDias.Left = labelX;
            lblDias.Top = y;
            TxtDias.Left = textX;
            TxtDias.Top = y;
            TxtDias.Width = 280;

            y += spacing + 10;

            // Guardar
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Left = 240;
            BtnGuardar.Top = y;
            BtnGuardar.Width = 100;
            BtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Cancelar
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Left = 350;
            BtnCancelar.Top = y;
            BtnCancelar.Width = 100;
            BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Form
            this.Text = "Peluqueria";
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.Controls.Add(lblNombre);
            this.Controls.Add(TxtNombre);
            this.Controls.Add(lblDireccion);
            this.Controls.Add(TxtDireccion);
            this.Controls.Add(lblTelefono);
            this.Controls.Add(TxtTelefono);
            this.Controls.Add(lblHorario);
            this.Controls.Add(TxtHorario);
            this.Controls.Add(lblDias);
            this.Controls.Add(TxtDias);
            this.Controls.Add(BtnGuardar);
            this.Controls.Add(BtnCancelar);

            this.ResumeLayout(false);
        }
    }
}

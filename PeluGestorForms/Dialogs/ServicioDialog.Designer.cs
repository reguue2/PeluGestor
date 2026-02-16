namespace PeluGestor.Dialogs
{
    partial class ServicioDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtDuracion;
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 20;
            int textX = 180;
            int y = 20;
            int spacing = 40;

            lblNombre.Text = "Nombre:";
            lblNombre.Left = labelX;
            lblNombre.Top = y;
            TxtNombre.Left = textX;
            TxtNombre.Top = y;
            TxtNombre.Width = 300;
            TxtNombre.MaxLength = 100;

            y += spacing;

            lblDescripcion.Text = "Descripcion:";
            lblDescripcion.Left = labelX;
            lblDescripcion.Top = y;
            TxtDescripcion.Left = textX;
            TxtDescripcion.Top = y;
            TxtDescripcion.Width = 300;
            TxtDescripcion.MaxLength = 255;

            y += spacing;

            lblPrecio.Text = "Precio:";
            lblPrecio.Left = labelX;
            lblPrecio.Top = y;
            TxtPrecio.Left = textX;
            TxtPrecio.Top = y;
            TxtPrecio.Width = 120;
            TxtPrecio.MaxLength = 10;

            y += spacing;

            lblDuracion.Text = "Duracion (min):";
            lblDuracion.Left = labelX;
            lblDuracion.Top = y;
            TxtDuracion.Left = textX;
            TxtDuracion.Top = y;
            TxtDuracion.Width = 120;
            TxtDuracion.MaxLength = 4;

            y += spacing + 10;

            BtnGuardar.Text = "Guardar";
            BtnGuardar.Left = 260;
            BtnGuardar.Top = y;
            BtnGuardar.Width = 100;
            BtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Left = 370;
            BtnCancelar.Top = y;
            BtnCancelar.Width = 100;
            BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.Text = "Servicio";
            this.ClientSize = new System.Drawing.Size(520, 260);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Controls.Add(lblNombre);
            this.Controls.Add(TxtNombre);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(TxtDescripcion);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(TxtPrecio);
            this.Controls.Add(lblDuracion);
            this.Controls.Add(TxtDuracion);
            this.Controls.Add(BtnGuardar);
            this.Controls.Add(BtnCancelar);

            this.ResumeLayout(false);
        }
    }
}

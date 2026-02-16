namespace PeluGestor.Dialogs
{
    partial class PeluqueroDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox ChkActivo;
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 20;
            int textX = 140;
            int y = 20;
            int spacing = 40;

            // Nombre
            lblNombre.Text = "Nombre:";
            lblNombre.Left = labelX;
            lblNombre.Top = y;

            TxtNombre.Left = textX;
            TxtNombre.Top = y;
            TxtNombre.Width = 200;
            TxtNombre.MaxLength = 100;

            y += spacing;

            // Activo
            lblActivo.Text = "Activo:";
            lblActivo.Left = labelX;
            lblActivo.Top = y;

            ChkActivo.Left = textX;
            ChkActivo.Top = y;

            y += spacing + 10;

            // Guardar
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Left = 140;
            BtnGuardar.Top = y;
            BtnGuardar.Width = 100;
            BtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Cancelar
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Left = 250;
            BtnCancelar.Top = y;
            BtnCancelar.Width = 100;
            BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Form
            this.Text = "Peluquero";
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Controls.Add(lblNombre);
            this.Controls.Add(TxtNombre);
            this.Controls.Add(lblActivo);
            this.Controls.Add(ChkActivo);
            this.Controls.Add(BtnGuardar);
            this.Controls.Add(BtnCancelar);

            this.ResumeLayout(false);
        }
    }
}

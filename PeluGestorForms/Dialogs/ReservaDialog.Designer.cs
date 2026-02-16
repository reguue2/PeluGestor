using System.Windows.Forms;

namespace PeluGestor.Dialogs
{
    partial class ReservaDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.DateTimePicker DpFecha;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.ComboBox CmbServicio;
        private System.Windows.Forms.ComboBox CmbPeluquero;
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
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.DpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.CmbServicio = new System.Windows.Forms.ComboBox();
            this.CmbPeluquero = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();

            int labelX = 20;
            int textX = 200;
            int y = 20;
            int spacing = 40;

            this.Controls.Add(new Label() { Text = "Cliente:", Left = labelX, Top = y });
            TxtCliente.Left = textX; TxtCliente.Top = y; TxtCliente.Width = 250;
            this.Controls.Add(TxtCliente);

            y += spacing;

            this.Controls.Add(new Label() { Text = "Telefono:", Left = labelX, Top = y });
            TxtTelefono.Left = textX; TxtTelefono.Top = y; TxtTelefono.Width = 250;
            this.Controls.Add(TxtTelefono);

            y += spacing;

            this.Controls.Add(new Label() { Text = "Fecha:", Left = labelX, Top = y });
            DpFecha.Left = textX; DpFecha.Top = y;
            DpFecha.Format = DateTimePickerFormat.Short;
            this.Controls.Add(DpFecha);

            y += spacing;

            this.Controls.Add(new Label() { Text = "Hora (HH:MM):", Left = labelX, Top = y });
            TxtHora.Left = textX; TxtHora.Top = y; TxtHora.Width = 100;
            this.Controls.Add(TxtHora);

            y += spacing;

            this.Controls.Add(new Label() { Text = "Servicio:", Left = labelX, Top = y });
            CmbServicio.Left = textX; CmbServicio.Top = y; CmbServicio.Width = 250;
            this.Controls.Add(CmbServicio);

            y += spacing;

            this.Controls.Add(new Label() { Text = "Peluquero:", Left = labelX, Top = y });
            CmbPeluquero.Left = textX; CmbPeluquero.Top = y; CmbPeluquero.Width = 250;
            this.Controls.Add(CmbPeluquero);

            y += spacing + 10;

            BtnGuardar.Text = "Guardar";
            BtnGuardar.Left = 260; BtnGuardar.Top = y;
            BtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.Controls.Add(BtnGuardar);

            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Left = 370; BtnCancelar.Top = y;
            BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(BtnCancelar);

            this.Text = "Reserva";
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}

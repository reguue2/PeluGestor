using System.Windows.Forms;

namespace PeluGestor.Views
{
    partial class ReservasView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox CmbPeluqueria;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.DateTimePicker DpFecha;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblPeluqueria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblPeluqueria = new System.Windows.Forms.Label();
            this.CmbPeluqueria = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.DpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblPeluqueria);
            this.topPanel.Controls.Add(this.CmbPeluqueria);
            this.topPanel.Controls.Add(this.lblFecha);
            this.topPanel.Controls.Add(this.DpFecha);
            this.topPanel.Controls.Add(this.lblEstado);
            this.topPanel.Controls.Add(this.CmbEstado);
            this.topPanel.Controls.Add(this.btnNueva);
            this.topPanel.Controls.Add(this.btnEditar);
            this.topPanel.Controls.Add(this.btnCancelar);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(659, 40);
            this.topPanel.TabIndex = 1;
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.Location = new System.Drawing.Point(0, 10);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(100, 23);
            this.lblPeluqueria.TabIndex = 0;
            this.lblPeluqueria.Text = "Peluqueria:";
            // 
            // CmbPeluqueria
            // 
            this.CmbPeluqueria.Location = new System.Drawing.Point(90, 0);
            this.CmbPeluqueria.Name = "CmbPeluqueria";
            this.CmbPeluqueria.Size = new System.Drawing.Size(260, 21);
            this.CmbPeluqueria.TabIndex = 1;
            this.CmbPeluqueria.SelectedIndexChanged += new System.EventHandler(this.CmbPeluqueria_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(360, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // DpFecha
            // 
            this.DpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpFecha.Location = new System.Drawing.Point(420, 0);
            this.DpFecha.Name = "DpFecha";
            this.DpFecha.ShowCheckBox = true;
            this.DpFecha.Size = new System.Drawing.Size(120, 20);
            this.DpFecha.TabIndex = 3;
            this.DpFecha.ValueChanged += new System.EventHandler(this.DpFecha_ValueChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(550, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 23);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.Items.AddRange(new object[] {
            "Todos",
            "confirmada",
            "cancelada"});
            this.CmbEstado.Location = new System.Drawing.Point(610, 0);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(140, 21);
            this.CmbEstado.TabIndex = 5;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(760, 0);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 6;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(870, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(980, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 40);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(659, 676);
            this.Grid.TabIndex = 0;
            this.Grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Grid_DataBindingComplete);
            // 
            // ReservasView
            // 
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.topPanel);
            this.Name = "ReservasView";
            this.Size = new System.Drawing.Size(659, 716);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

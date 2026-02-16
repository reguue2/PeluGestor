using System.Windows.Forms;

namespace PeluGestor
{
    partial class SplashForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTexto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTexto = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.BackColor = System.Drawing.Color.FromArgb(28, 30, 69);

            pictureBox1.Image = System.Drawing.Image.FromFile("Recursos\\Logo Integrow.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = 689;
            pictureBox1.Height = 390;
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2 - 80;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Width = 320;
            progressBar1.Height = 12;
            progressBar1.Left = (this.ClientSize.Width - progressBar1.Width) / 2;
            progressBar1.Top = this.ClientSize.Height - 180;

            lblTexto.Text = "Cargando aplicacion...";
            lblTexto.ForeColor = System.Drawing.Color.LightGray;
            lblTexto.AutoSize = true;
            lblTexto.Left = (this.ClientSize.Width - 150) / 2;
            lblTexto.Top = progressBar1.Top + 30;

            this.Controls.Add(pictureBox1);
            this.Controls.Add(progressBar1);
            this.Controls.Add(lblTexto);

            this.Shown += new System.EventHandler(this.SplashForm_Shown);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

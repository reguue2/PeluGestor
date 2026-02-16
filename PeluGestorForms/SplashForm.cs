using System;
using System.Windows.Forms;

namespace PeluGestor
{
    public partial class SplashForm : Form
    {
        private Timer timer;
        private int progreso = 0;

        public SplashForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progreso++;

            if (progreso <= 100)
            {
                progressBar1.Value = progreso;
            }

            if (progreso >= 100)
            {
                timer.Stop();

                MainForm main = new MainForm();
                main.Show();

                this.Hide();
            }
        }
    }
}

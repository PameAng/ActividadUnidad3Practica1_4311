using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        int tiempoTotal; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmin.Text))
            {
                MessageBox.Show("Por favor, introduce los minutos");
                txtmin.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtseg.Text))
            {
                MessageBox.Show("Por favor, introduce los segundos");
                txtseg.Focus();
                return;

            }

            int min = int.Parse(txtmin.Text);
            int sec = int.Parse(txtseg.Text);
            tiempoTotal = min * 60 + sec;

            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0) 
            {
                tiempoTotal--;
                int min = tiempoTotal / 60;
                int sec = tiempoTotal % 60;
                lbltiempo.Text = $"{min:D2}:{sec:D2}";
            }
            else 
            {
                timer1.Stop();
                MessageBox.Show("Tiempo terminado");
                
            }
        }
    }
}

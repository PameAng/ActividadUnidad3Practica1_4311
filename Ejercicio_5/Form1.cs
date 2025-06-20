using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string entrada = maskedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(entrada))
            {
                MessageBox.Show("Ingresa un número");
                return;
            }
            if (!int.TryParse(entrada, out int numero))
            {
                MessageBox.Show("El valor ingresado no es un número válido");
                return;
            }

            if (EsPrimo(numero))
            {
                MessageBox.Show($"El número {numero} es primo");
            }
            else
            {
                MessageBox.Show($"El número {numero} no es primo");
            }
        }

        private bool EsPrimo(int n)
        {
            if (n < 2) return false;

            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
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
            if (EsPerfecto(numero))
            {
                MessageBox.Show($"El número {numero} es un número perfecto");
            }
            else
            {
                MessageBox.Show($"El número {numero} no es un número perfecto");
            }
        }

        private bool EsPerfecto(int n)
        {
            if (n <= 1) return false;

            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    suma += i;
                }
            }
            return suma == n;
        }
    }
}

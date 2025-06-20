using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ","").Trim();

            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInvertida = new string(caracteres);

            if (palabra == palabraInvertida)
            {
                MessageBox.Show("Es una palabra palindroma");
            }
            else
            {
                MessageBox.Show("No es una palabra palindroma"); 
            }
        }
    }
}

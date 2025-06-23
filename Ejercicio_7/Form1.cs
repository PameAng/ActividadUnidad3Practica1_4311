using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(txtInicio.Text.Trim(), out int inicio))
            {
                MessageBox.Show("Ingresa un número válido para el inicio");
                return;
            }
            if (!int.TryParse(txtFin.Text.Trim(), out int fin))
                {
                MessageBox.Show("El número de inicio debe ser menor o igual al de fin");
            }
            for (int i = inicio; i < fin; i++)
            {
                if (EsPrimo(i))
                { listBox1.Items.Add(i);
                }
            }
            if (listBox1.Items.Count == 0)

            {
                listBox1.Items.Add("No hay números primos");
        
    }
        }
        private bool EsPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

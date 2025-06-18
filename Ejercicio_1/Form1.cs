using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbtabla.Items.Clear();
            if(string.IsNullOrEmpty(txtnumero.Text))
                    {
                MessageBox.Show("Debe introducir un número","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero = int.Parse(txtnumero.Text);

            for (int i = 1; i <= 12; i++)
            {
                lbtabla.Items.Add($"{numero}*{i}={i * numero}");
            }
        }

        private void lbtabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

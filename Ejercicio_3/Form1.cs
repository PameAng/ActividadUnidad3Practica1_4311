using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorConvertido = 0;
            double valor = double.Parse(txtvalor.Text);

            if (cmbde.SelectedItem.ToString() == "Centimetro")
            {
                switch (cmbpara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        valorConvertido = valor;
                        break;
                    case "Metro":
                        valorConvertido = valor /100 ;
                        break;
                    case "Pulgada":
                        valorConvertido = valor / 2.54;
                        break;
                }

            }

            if (cmbde.SelectedItem.ToString() == "Metro")
            {
                switch (cmbpara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        valorConvertido = valor * 100;
                        break;
                    case "Metro":
                        valorConvertido = valor;
                        break;
                    case "Pulgada":
                        valorConvertido = valor * 39.37;
                        break;
                }
            }
                        if (cmbde.SelectedItem.ToString() == "Pulgada")
            {
                switch (cmbpara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        valorConvertido = valor * 2.54;
                        break;
                    case "Metro":
                        valorConvertido = valor / 39.37;
                        break;
                    case "Pulgada":
                        valorConvertido = valor;
                        break;
                }
            }

                        MessageBox.Show($"El valor convertido es {valorConvertido}"); 
        }

        private void cmbde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

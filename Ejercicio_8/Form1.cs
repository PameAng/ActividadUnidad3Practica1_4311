using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracion = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(oracion))
            {
                label1.Text = "La oración esta vacía";
                return;
            }

            string[] palabras = oracion.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            label1.Text = $"La oración contiene {palabras.Length} palabras(s)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

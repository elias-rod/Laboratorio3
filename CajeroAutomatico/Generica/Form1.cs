using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAceptar.Click += Calcular;
        }
        
        private void Calcular(object sender, EventArgs e)
        {
            int residuo = int.Parse(textBoxRetirar.Text);
            textBox6.Text = (residuo / 100).ToString();
            residuo %= 100;
            textBox5.Text = (residuo / 50).ToString();
            residuo %= 50;
            textBox4.Text = (residuo / 20).ToString();
            residuo %= 20;
            textBox3.Text = (residuo / 10).ToString();
            residuo %= 10;
            textBox2.Text = (residuo / 5).ToString();
            residuo %= 5;
            textBox1.Text = (residuo / 2).ToString();
            residuo %= 2;
            if (residuo == 1)
            {
                MessageBox.Show("Le queda $1 peso de vuelto.", "Vuelto");
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Click -= Calcular;
            buttonLimpiar.Click += Limpiar;
            buttonAceptar.Click += Informar;
        }

        private void Limpiar(object sender, EventArgs e)
        {
            textBoxRetirar.Clear();
            foreach (Control item in groupBoxBilletes.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void Informar (object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Click -= Informar;
            buttonLimpiar.Click -= Limpiar;
            buttonAceptar.Click += Calcular;
        }
    }
}

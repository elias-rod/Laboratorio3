using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3
{
    public partial class FormManejo : Form
    {
        public FormManejo()
        {
            InitializeComponent();
        }
        private string Invertir(string cadena)
        {
            char[] array = cadena.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        private string Ordenar(string cadena)
        {
            char[] array = cadena.ToLower().ToCharArray();
            Array.Sort(array);
            return new String(array);
        }
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            this.textInvertida.Text = Invertir(this.textIngrese.Text);
            this.textOrden.Text = Ordenar(this.textIngrese.Text);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

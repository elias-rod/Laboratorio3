using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lstTabla.Items.Add(this.txtNumero.Text + " * " + i + " = " + int.Parse(this.txtNumero.Text) * i);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.lstTabla.Items.Clear();
            this.txtNumero.Clear();
        }
    }
}

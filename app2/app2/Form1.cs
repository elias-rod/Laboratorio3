using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2
{
    public partial class foDescuento : Form
    {
        public foDescuento()
        {
            InitializeComponent();
        }

        private void boAceptar_Click(object sender, EventArgs e)
        {
            double total = double.Parse(teIngrese.Text);
            double descuento = 0;
            if (total >= 30 && total <= 50)
            {
                descuento = 0.10;
                teDescuento.Text = "10%";
            }
            else if (total > 50)
            {
                descuento = 0.20;
                teDescuento.Text = "20%";
            }
            else
            {
                descuento = 0;
                teDescuento.Text = "0%";
            }
            teTotal.Text = (total * (1 - descuento)).ToString();
        }

        private void boLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in gbInformación.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void boSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

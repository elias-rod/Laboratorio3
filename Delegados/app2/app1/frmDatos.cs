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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }
        public void ActualizarNombre(string cadena)
        {
            this.label1.Text = cadena;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            ((Form1)this.Owner).miDelegado += this.ActualizarNombre;
            ((Form1)this.Owner).miDelegado += this.ActualizarFoto;
        }

        public void ActualizarFoto(string cadena)
        {
            this.pictureBox1.ImageLocation = cadena;
        }

        private void frmDatos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

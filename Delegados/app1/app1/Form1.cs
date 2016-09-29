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
        frmTestDelegados miFrmTestDelegado;
        frmDatos miFrmDatos;

        public actualizarNombrePorDelegado miDelegado;

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (miFrmDatos != null)
            {
                miFrmTestDelegado = new frmTestDelegados();
                miFrmTestDelegado.Show(this);
            }
                
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFrmDatos = new frmDatos();
            miFrmDatos.Show(this);            
        }
    }
}

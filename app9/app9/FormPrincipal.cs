using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app9
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            
            InitializeComponent();
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox miAB = new AboutBox();
            miAB.ShowDialog();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionAutomovil miFrmGesAut = new FrmGestionAutomovil();
            miFrmGesAut.MdiParent = this;
            miFrmGesAut.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

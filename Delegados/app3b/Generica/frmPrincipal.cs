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
    public partial class frmPrincipal : Form
    {
        private frmDatosAlumno miFrmDatosAlumno;
        private frmAltaAlumno miFrmAltaAlumno;
        public delegadoPrincipal MostrarAlumnoPorDelegado;
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFrmDatosAlumno = new frmDatosAlumno();
            miFrmDatosAlumno.MdiParent = this;
            miFrmDatosAlumno.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFrmAltaAlumno = new frmAltaAlumno();
            miFrmAltaAlumno.Show(this);
        }
    }
}

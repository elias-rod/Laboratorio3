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
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();

            base.Load += new EventHandler(load_form);
            
        }

        private void load_form(object e , EventArgs a) {
            ((frmPrincipal)base.MdiParent).MostrarAlumnoPorDelegado += ActualizarAlumno;
        }

        public void ActualizarAlumno(Entidades.Alumno alumno, EventArgs e)
        {
            this.textBox1Apellido.Text = alumno.Apellido;
            this.textBox2Nombre.Text = alumno.Nombre;
            this.textBox4Dni.Text = alumno.Dni.ToString();
            this.textBox3Foto.Text = alumno.FotoAlumno;
            this.pictureBox1.ImageLocation = alumno.FotoAlumno;
        }
    }
}

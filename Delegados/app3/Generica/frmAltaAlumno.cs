using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Generica
{
    public partial class frmAltaAlumno : Form
    {
        private Alumno nuevoAlumno;
        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            nuevoAlumno = new Alumno(textBox2Nombre.Text, textBox1Apellido.Text, int.Parse(textBox4Dni.Text), textBox3Foto.Text);
            ((frmPrincipal)this.Owner).MostrarAlumnoPorDelegado(nuevoAlumno, new EventArgs());
            this.Close();
        }

        private void textBox3Foto_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            textBox3Foto.Text = openFileDialog1.FileName;
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

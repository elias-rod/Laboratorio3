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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private string ruta;

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).miDelegado(this.textBoxActualizar.Text);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ruta = openFileDialog1.FileName;
            ((Form1)this.Owner).miDelegado(this.ruta);
        }
    }
}

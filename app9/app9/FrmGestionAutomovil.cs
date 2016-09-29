using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace app9
{
    public partial class FrmGestionAutomovil : Form
    {
        //FIELDS
        private List<Vehiculo> _listaVehiculos;
        //PROPERTIES
        public List<Vehiculo> ListaDeVehiculos
        {
            get
            {
                return _listaVehiculos;
            }
            set
            {
                _listaVehiculos = value;
            }
        }
        //METHODS
        public FrmGestionAutomovil()
        {
            _listaVehiculos = new List<Vehiculo>();
            InitializeComponent();
        }
        private void salirDelAdministradorDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nuevoAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuto miFrmAuto = new FrmAuto();
            miFrmAuto.ShowDialog();
            if (miFrmAuto.DialogResult == DialogResult.OK)
            {
                _listaVehiculos.Add(miFrmAuto.AutoDelFormulario);
            }
        }
        private void nuevaMotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMoto miFrmMoto = new FrmMoto();
            miFrmMoto.ShowDialog();
            if (miFrmMoto.DialogResult == DialogResult.OK)
            {
                _listaVehiculos.Add(miFrmMoto.MotoDelFormulario);
            }
        }
        private void nuevaCamionetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCamioneta miFrmCamioneta = new FrmCamioneta();
            miFrmCamioneta.ShowDialog();
            if (miFrmCamioneta.DialogResult == DialogResult.OK)
            {
                _listaVehiculos.Add(miFrmCamioneta.CamionetaDelFormulario);
            }
        }

        private void borrarVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrar miFrmBorrar = new FrmBorrar(_listaVehiculos);
            miFrmBorrar.ShowDialog();
        }

        private void modificarVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar miFrmModificar = new FrmModificar(_listaVehiculos);
            miFrmModificar.ShowDialog();
        }
    }
}

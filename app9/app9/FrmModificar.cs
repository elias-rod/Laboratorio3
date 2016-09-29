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
    public partial class FrmModificar : Form
    {
        private List<Vehiculo> _listaVehiculos;
        public FrmModificar(List<Vehiculo> listaVehiculos)
        {
            InitializeComponent();
            _listaVehiculos = listaVehiculos;
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            this.listBoxModificar.DataSource = _listaVehiculos;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (listBoxModificar.SelectedItem is Auto)
            {
                FrmAuto miFrmAuto = new FrmAuto();
                miFrmAuto.ShowDialog();
                if (miFrmAuto.DialogResult == DialogResult.OK)
                {
                    _listaVehiculos[listBoxModificar.SelectedIndex] = miFrmAuto.AutoDelFormulario;
                }
            }
            this.listBoxModificar.DataSource = null;
            this.listBoxModificar.DataSource = _listaVehiculos;
        }
        
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

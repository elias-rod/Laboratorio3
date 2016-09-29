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
    public partial class FrmBorrar : Form
    {
        private List<Vehiculo> _listaVehiculos;
        public FrmBorrar(List<Vehiculo> listaVehiculos)
        {
            InitializeComponent();
            _listaVehiculos = listaVehiculos;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBorrar_Load(object sender, EventArgs e)
        {
            this.listBoxBorrar.DataSource = _listaVehiculos;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            _listaVehiculos.Remove((Vehiculo)this.listBoxBorrar.SelectedItem);
            this.listBoxBorrar.DataSource = null;
            this.listBoxBorrar.DataSource = _listaVehiculos;
        }
    }
}

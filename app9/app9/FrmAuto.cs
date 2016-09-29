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
    public partial class FrmAuto : FrmVehiculo
    {
        //FIELDS
        private Auto _autoDelFormulario;
        //PROPERTIES
        public Auto AutoDelFormulario
        {
            get
            {
                return _autoDelFormulario;
            }
            set
            {
                _autoDelFormulario = value;
            }
        }
        //METHODS
        public FrmAuto()
        {
            InitializeComponent();
        }

        protected override void buttonAceptar_Click(object sender, EventArgs e)
        {
            _autoDelFormulario = new Auto(this.textBoxPatente.Text, this.textBoxMarca.Text, (eColores)Enum.Parse(typeof(eColores), this.comboBoxColor.SelectedItem.ToString()), int.Parse(this.textBoxCantidad.Text));
            base.buttonAceptar_Click(sender, e);
        }

        protected override void buttonCancelar_Click(object sender, EventArgs e)
        {
            base.buttonCancelar_Click(sender, e);
            this.Close();
        }
    }
}

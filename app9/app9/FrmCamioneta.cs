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
    public partial class FrmCamioneta : FrmVehiculo
    {
        //FIELDS
        private Camioneta _camionetaDelFormulario;
        //PROPERTIES
        public Camioneta CamionetaDelFormulario
        {
            get
            {
                return _camionetaDelFormulario;
            }
            set
            {
                _camionetaDelFormulario = value;
            }
        }
        //METHODS
        public FrmCamioneta()
        {
            InitializeComponent();
        }

        protected override void buttonAceptar_Click(object sender, EventArgs e)
        {
            _camionetaDelFormulario = new Camioneta(this.textBoxPatente.Text, this.textBoxMarca.Text, (eColores)Enum.Parse(typeof(eColores), this.comboBoxColor.SelectedItem.ToString()), double.Parse(this.textBoxAltura.Text));
            base.buttonAceptar_Click(sender, e);
        }

        protected override void buttonCancelar_Click(object sender, EventArgs e)
        {
            base.buttonCancelar_Click(sender, e);
            this.Close();
        }
    }
}

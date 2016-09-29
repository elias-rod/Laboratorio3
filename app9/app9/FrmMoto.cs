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
    public partial class FrmMoto : FrmVehiculo
    {
        //FIELDS
        private Moto _motoDelFormulario;
        //PROPERTIES
        public Moto MotoDelFormulario
        {
            get
            {
                return _motoDelFormulario;
            }
            set
            {
                _motoDelFormulario = value;
            }
        }
        //METHODS
        public FrmMoto()
        {
            InitializeComponent();
        }

        protected override void buttonAceptar_Click(object sender, EventArgs e)
        {
            _motoDelFormulario = new Moto(this.textBoxPatente.Text, this.textBoxMarca.Text, (eColores)Enum.Parse(typeof(eColores), this.comboBoxColor.SelectedItem.ToString()), Single.Parse(this.textBoxCilindrada.Text));
            base.buttonAceptar_Click(sender, e);
        }

        protected override void buttonCancelar_Click(object sender, EventArgs e)
        {
            base.buttonCancelar_Click(sender, e);
            this.Close();
        }
    }
}

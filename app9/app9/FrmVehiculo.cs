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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }
        
        protected void FrmVehiculo_Load(object sender, EventArgs e)
        {
            foreach (eColores color in Enum.GetValues(typeof(eColores)))
            {
                this.comboBoxColor.Items.Add(color);
            }
        }
        protected virtual void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        protected virtual void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

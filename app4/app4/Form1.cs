using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lista = new List<int>();
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.lista.Add(int.Parse(this.textBoxIngresar.Text));
            this.listBoxLista.DataSource = null;
            this.listBoxLista.DataSource = lista;
            //this.listBoxLista.Items.Add(int.Parse(this.textBoxIngresar.Text));
            this.textBoxIngresar.Clear();
        }
        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            if (this.radioButtonAscendente.Checked)
            {
                lista.Sort();
                this.listBoxLista.DataSource = null;
                this.listBoxLista.DataSource = lista;
            }
            else
            {
                lista.Sort();
                lista.Reverse();
                this.listBoxLista.DataSource = null;
                this.listBoxLista.DataSource = lista;

            }
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

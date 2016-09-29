using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace app5
{
    public partial class Form1 : Form
    {
        CajaDeFunciones miCaja = new CajaDeFunciones();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNumero.Text != "")
            {
                textBoxCantidadCifras.Text = miCaja.CalcularCantidadCifras(int.Parse(this.textBoxNumero.Text)).ToString();
                textBoxSumaCifrasPares.Text = miCaja.CalcularSumaCifrasPares(int.Parse(this.textBoxNumero.Text)).ToString();
                textBoxSumaCifrasImpares.Text = miCaja.CalcularSumaCifrasImpares(int.Parse(this.textBoxNumero.Text)).ToString();
                textBoxSumaTotal.Text = miCaja.CalcularSumaTotal(int.Parse(this.textBoxNumero.Text)).ToString();
                textBoxCifraMayor.Text = miCaja.CalcularCifraMayor(int.Parse(this.textBoxNumero.Text)).ToString();
                textBoxCifraMenor.Text = miCaja.CalcularCifraMenor(int.Parse(this.textBoxNumero.Text)).ToString();
                listBoxDivisores.Items.Clear();
                foreach (int divisor in miCaja.CalcularDivisores(int.Parse(this.textBoxNumero.Text)))
                {
                    listBoxDivisores.Items.Add(divisor);
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox)
                    {
                        foreach (Control subcontrol in control.Controls)
                        {
                            if (subcontrol is TextBox)
                            {
                                ((TextBox)subcontrol).Clear();
                            }
                        }
                    }
                }
                listBoxDivisores.Items.Clear();
            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control subcontrol in control.Controls)
                    {
                        if (subcontrol is TextBox)
                        {
                            ((TextBox)subcontrol).Clear();
                        }
                    }
                }
            }
            listBoxDivisores.Items.Clear();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea guardar en el escritorio los resultados?","Guardar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(resultado == DialogResult.Yes)
            {
                StreamWriter miStream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//archivo.txt");
                StringBuilder miSB = new StringBuilder();
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox)
                    {
                        foreach (Control subcontrol in control.Controls)
                        {
                            if (subcontrol is TextBox)
                            {
                                miSB.AppendLine(((TextBox)subcontrol).Name.ToString() + " : " + ((TextBox)subcontrol).Text.ToString());
                            }
                        }
                    }
                }
                miSB.AppendLine(listBoxDivisores.Name.ToString() + " : ");
                foreach (var item in listBoxDivisores.Items)
                {
                    miSB.AppendLine(item.ToString());
                }
                miStream.WriteLine(miSB.ToString());
                miStream.Close();
                this.Close();
            }
            else if(resultado == DialogResult.No)
            {
                this.Close();
            }
        }
    }
    class CajaDeFunciones
    {
        public int CalcularCantidadCifras(int numero)
        {
            int contador = 0;
            while (numero > 0)
            {
                numero /= 10;
                contador++;
            }
            return contador;
        }
        public int CalcularSumaCifrasPares(int numero)
        {
            int digito = 0;
            int suma = 0;
            while (numero > 0)
            {
                digito = numero % 10;
                numero /= 10;
                if (digito % 2 == 0)
                    suma += digito;
            }
            return suma;
        }
        public int CalcularSumaCifrasImpares(int numero)
        {
            int digito = 0;
            int suma = 0;
            while (numero > 0)
            {
                digito = numero % 10;
                numero /= 10;
                if (digito % 2 != 0)
                    suma += digito;
            }
            return suma;
        }
        public int CalcularSumaTotal(int numero)
        {
            return CalcularSumaCifrasPares(numero) + CalcularSumaCifrasImpares(numero);
        }
        public int CalcularCifraMayor(int numero)
        {
            int mayor = 0;
            while (numero > 0)
            {
                if (numero % 10 > mayor)
                    mayor = numero % 10;
                numero /= 10;
            }
            return mayor;
        }
        public int CalcularCifraMenor(int numero)
        {
            int menor = 10;
            while (numero > 0)
            {
                if (numero % 10 < menor)
                    menor = numero % 10;
                numero /= 10;
            }
            return menor;
        }
        public List<int> CalcularDivisores(int numero)
        {
            List<int> lista = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    lista.Add(i);
                }
            }
            return lista;
        }
    }
}

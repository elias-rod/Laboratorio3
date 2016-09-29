using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int numero1;
        private int numero2;
        private string operacion;
        private bool primerNumeroUsado;

        private double Calcular(int numero1, int numero2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    return (double)numero1 / (double)numero2;
            }
            return 0;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button0":
                    if (primerNumeroUsado)
                    {
                        numero2 = 0;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 0;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "0";
                    break;
                case "button1":
                    if (primerNumeroUsado)
                    {
                        numero2 = 1;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 1;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "1";
                    break;
                case "button2":
                    if (primerNumeroUsado)
                    {
                        numero2 = 2;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 2;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "2";
                    break;
                case "button3":
                    if (primerNumeroUsado)
                    {
                        numero2 = 3;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 3;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "3";
                    break;
                case "button4":
                    if (primerNumeroUsado)
                    {
                        numero2 = 4;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 4;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "4";
                    break;
                case "button5":
                    if (primerNumeroUsado)
                    {
                        numero2 = 5;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 5;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "5";
                    break;
                case "button6":
                    if (primerNumeroUsado)
                    {
                        numero2 = 6;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 6;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "6";
                    break;
                case "button7":
                    if (primerNumeroUsado)
                    {
                        numero2 = 7;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 7;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "7";
                    break;
                case "button8":
                    if (primerNumeroUsado)
                    {
                        numero2 = 8;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 8;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "8";
                    break;
                case "button9":
                    if (primerNumeroUsado)
                    {
                        numero2 = 9;
                        buttonIgual.Click += ManejadorCentral;
                    }
                    else
                    {
                        numero1 = 9;
                        primerNumeroUsado = true;
                        buttonSumar.Click += ManejadorCentral;
                        buttonRestar.Click += ManejadorCentral;
                        buttonMultiplicar.Click += ManejadorCentral;
                        buttonDividir.Click += ManejadorCentral;
                    }
                    textBox1.Text = "9";
                    break;
                case "buttonSumar":
                    textBox1.Text = "";
                    operacion = "+";
                    buttonSumar.Click -= ManejadorCentral;
                    buttonRestar.Click -= ManejadorCentral;
                    buttonMultiplicar.Click -= ManejadorCentral;
                    buttonDividir.Click -= ManejadorCentral;
                    break;
                case "buttonRestar":
                    textBox1.Text = "";
                    operacion = "-";
                    buttonSumar.Click -= ManejadorCentral;
                    buttonRestar.Click -= ManejadorCentral;
                    buttonMultiplicar.Click -= ManejadorCentral;
                    buttonDividir.Click -= ManejadorCentral;
                    break;
                case "buttonMultiplicar":
                    textBox1.Text = "";
                    operacion = "*";
                    buttonSumar.Click -= ManejadorCentral;
                    buttonRestar.Click -= ManejadorCentral;
                    buttonMultiplicar.Click -= ManejadorCentral;
                    buttonDividir.Click -= ManejadorCentral;
                    break;
                case "buttonDividir":
                    textBox1.Text = "";
                    operacion = "/";
                    buttonSumar.Click -= ManejadorCentral;
                    buttonRestar.Click -= ManejadorCentral;
                    buttonMultiplicar.Click -= ManejadorCentral;
                    buttonDividir.Click -= ManejadorCentral;
                    break;
                case "buttonIgual":
                    buttonIgual.Click -= ManejadorCentral;
                    textBox1.Text = Calcular(numero1, numero2, operacion).ToString();
                    primerNumeroUsado = false;
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        bool flagBinario = false;
        bool flagDecimal = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
            flagBinario = false;
            flagDecimal = false;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char auxOperador = operador[0];

            return Calculadora.Operar(num1, num2, auxOperador);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double num1;
            double num2;

            if (!(String.IsNullOrEmpty(txtNumero1.Text)) &&
                !(String.IsNullOrEmpty(txtNumero2.Text)) &&
                !(String.IsNullOrEmpty(cmbOperador.Text)))
            {
                if (double.TryParse(txtNumero1.Text, out num1) &&
                   double.TryParse(txtNumero2.Text, out num2))
                {
                    resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

                    if (resultado == double.MinValue)
                    {
                        lblResultado.Text = "No es posible la division por 0";
                    }
                    else
                    {
                        lblResultado.Text = resultado.ToString();
                        flagBinario = false;
                        flagDecimal = false;
                        lstOperaciones.Items.Add($"{num1} {cmbOperador.SelectedItem.ToString()} {num2} = {resultado.ToString()}\n ");
                    }
                }
                else
                {
                    lblResultado.Text = "Formato invalido de los operandos";
                }

            }
            else
            {
                lblResultado.Text = "Faltan datos para operar";
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando num = new Operando();
            if (!flagBinario && !(String.IsNullOrEmpty(lblResultado.Text)))
            {
                lblResultado.Text = num.DecimalBinario(lblResultado.Text);
                flagBinario = true;
                flagDecimal = false;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando num = new Operando();
            if (!flagDecimal && !(String.IsNullOrEmpty(lblResultado.Text)))
            {
                lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
                flagBinario = false;
                flagDecimal = true;
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
            }
            else
            { 
                e.Cancel = true;
            }
        }
    }
}

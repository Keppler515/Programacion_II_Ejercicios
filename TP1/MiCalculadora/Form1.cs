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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            this.lstOperaciones.Items.Add($"{txtNumero1.Text} {(this.cmbOperador.Text == ""?this.cmbOperador.Text = "+": this.cmbOperador.Text)} {txtNumero2.Text} = {resultado}");
            this.lblResultado.Text = Operar(this.txtNumero1.Text,this.txtNumero2.Text,this.cmbOperador.Text).ToString();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add('+');
            this.cmbOperador.Items.Add('-');
            this.cmbOperador.Items.Add('*');
            this.cmbOperador.Items.Add('/');
            this.cmbOperador.Items.Add("");

            Limpiar();

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            double resultado = Calculadora.Operar(operando1, operando2, operador);
            return resultado;
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir?", "Cerrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }


        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando binario = new Operando();

            this.lblResultado.Text = binario.DecimalBinario(txtNumero1.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando dDecimal = new Operando();

            this.lblResultado.Text = dDecimal.BinarioDecimal(txtNumero1.Text);
        }
    }
}

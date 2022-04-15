using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevoFormulario_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo!");

            Form2 otroFormulario = new Form2();
            otroFormulario.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar el formulario?", "Cierre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (resultado != DialogResult.Yes)
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Capturar usuario
            string usuario = this.txtUsuario.Text.ToLower();

            //TODO : 2 - Capturar contraseña
            string contra = this.txtPass.Text;

            if (usuario != "pepe" || contra != "Pepito22")
            {
                MessageBox.Show("Los datos son incorrectos");
                this.BackColor = Color.Red;
            }
            else
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                menuPrincipal.Show();
                this.Hide();
            }

        }

        private void btnLlamadaMenu_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "pepe";
            this.txtPass.Text = "Pepito22";
        }
    }
}

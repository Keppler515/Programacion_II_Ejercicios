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

        private string userNombre;
        private string userApellido;
        private string userMateria;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userNombre = this.txtbxNombre.Text;
            userApellido = this.txtbxApellido.Text;
            userMateria = (string)this.cmbxMaterias.SelectedItem;

            if (string.IsNullOrWhiteSpace(userNombre) || string.IsNullOrWhiteSpace(userApellido))
            {
                if (string.IsNullOrWhiteSpace(userNombre) && string.IsNullOrWhiteSpace(userApellido))
                {
                    MessageBox.Show($"Se deben completar los siguientes campos:\nNombre\nApellido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(userNombre))
                {
                    MessageBox.Show($"Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Saludo saludo = new Saludo(userNombre, userApellido, userMateria);
                saludo.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbxMaterias.Items.Add("Laboratorio I");
            this.cmbxMaterias.Items.Add("Laboratorio II");
            this.cmbxMaterias.Items.Add("Programacion I");
            this.cmbxMaterias.Items.Add("Programacion II");
            this.cmbxMaterias.SelectedIndex = 0;
        }

    }
}

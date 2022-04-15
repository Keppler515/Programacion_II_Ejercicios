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
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        }

        public Saludo(string nombre, string apellido):this()
        {
            this.lblHola.Text = "¡Hola, Windows Forms!";
            this.lblSoy.Text = $"Soy {nombre} {apellido}";
        }

        public Saludo(string nombre, string apellido, string materia) : this(nombre, apellido)
        {
            this.lblSoy.Text += $" y mi materia favorita es {materia}";
        }
    }
}

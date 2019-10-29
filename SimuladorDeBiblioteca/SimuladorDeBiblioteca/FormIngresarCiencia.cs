using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimuladorDeBiblioteca
{
    public partial class FormIngresarCiencia : Form
    {
        public FormIngresarCiencia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Ciencia = File.AppendText("Ciencia.txt");

            String[] Datos = new String[]
            {
                txtCienciaCodigoIngresar.Text, txtCienciaNombreIngresar.Text, txtCienciaAutorIngresar.Text,
                txtCienciaYearIngresar.Text, txtCienciaPaginaIngresar.Text
            };

            Ciencia.WriteLine(Datos[0] + "," + Datos[1] + "," + Datos[2] + "," + Datos[3] + "," + Datos[4]);
            Ciencia.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCienciaCodigoIngresar.Text = "";
            txtCienciaNombreIngresar.Text = "";
            txtCienciaAutorIngresar.Text = "";
            txtCienciaYearIngresar.Text = "";
            txtCienciaPaginaIngresar.Text = "";
        }
    }
}

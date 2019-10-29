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
    public partial class FormIngresarAnimacion : Form
    {
        public FormIngresarAnimacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Animacion = File.AppendText("Animacion.txt");

            String[] Datos = new String[]
            {
                txtAnimacionCodigoIngresar.Text, txtAnimacionNombreIngresar.Text, txtAnimacionAutorIngresar.Text,
                txtAnimacionYearIngresar.Text, txtAnimacionPaginaIngresar.Text
            };

            Animacion.WriteLine(Datos[0] + "," + Datos[1] + "," + Datos[2] + "," + Datos[3] + "," + Datos[4]);
            Animacion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAnimacionCodigoIngresar.Text = "";
            txtAnimacionNombreIngresar.Text = "";
            txtAnimacionAutorIngresar.Text = "";
            txtAnimacionYearIngresar.Text = "";
            txtAnimacionPaginaIngresar.Text = "";
        }
    }
}

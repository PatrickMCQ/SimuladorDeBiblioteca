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
    public partial class FormIngresarHistoria : Form
    {
        public FormIngresarHistoria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Historia = File.AppendText("Historia.txt");

            String[] Datos = new String[]
            {
                txtHistoriaCodigoIngresar.Text, txtHistoriaNombreIngresar.Text, txtHistoriaAutorIngresar.Text,
                txtHistoriaYearIngresar.Text, txtHistoriaPaginaIngresar.Text
            };

            Historia.WriteLine(Datos[0] + "," + Datos[1] + "," + Datos[2] + "," + Datos[3] + "," + Datos[4]);
            Historia.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHistoriaCodigoIngresar.Text = "";
            txtHistoriaNombreIngresar.Text = "";
            txtHistoriaAutorIngresar.Text = "";
            txtHistoriaYearIngresar.Text = "";
            txtHistoriaPaginaIngresar.Text = "";
        }
    }
}

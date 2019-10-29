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
    public partial class FormIngresarEspirirual : Form
    {
        public FormIngresarEspirirual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Espiritual = File.AppendText("Espiritual.txt");

            String[] Datos = new String[]
            {
                txtEspiritualCodigoIngresar.Text, txtEspiritualNombreIngresar.Text, txtEspiritualAutorIngresar.Text,
                txtEspiritualYearIngresar.Text, txtEspiritualPaginaIngresar.Text
            };

            Espiritual.WriteLine(Datos[0] + "," + Datos[1] + "," + Datos[2] + "," + Datos[3] + "," + Datos[4]);
            Espiritual.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEspiritualCodigoIngresar.Text = "";
            txtEspiritualNombreIngresar.Text = "";
            txtEspiritualAutorIngresar.Text = "";
            txtEspiritualYearIngresar.Text = "";
            txtEspiritualPaginaIngresar.Text = "";
        }
    }
}

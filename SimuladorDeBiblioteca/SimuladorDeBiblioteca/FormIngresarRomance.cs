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
    public partial class FormIngresarRomance : Form
    {
        public FormIngresarRomance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Romance = File.AppendText("Romance.txt");

            String[] Datos = new String[]
            {
                txtRomanceCodigoIngresar.Text, txtRomanceNombreIngresar.Text, txtRomanceAutorIngresar.Text,
                txtRomanceYearIngresar.Text, txtRomancePaginaIngresar.Text
            };

            Romance.WriteLine(Datos[0] + "," + Datos[1] + "," + Datos[2] + "," + Datos[3] + "," + Datos[4]);
            Romance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRomanceCodigoIngresar.Text = "";
            txtRomanceNombreIngresar.Text = "";
            txtRomanceAutorIngresar.Text = "";
            txtRomanceYearIngresar.Text = "";
            txtRomancePaginaIngresar.Text = "";
        }
    }
}

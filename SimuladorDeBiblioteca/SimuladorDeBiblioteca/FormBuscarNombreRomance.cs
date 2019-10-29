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
    public partial class FormBuscarNombreRomance : Form
    {
        public FormBuscarNombreRomance()
        {
            InitializeComponent();
            panelContenedorBNombreRomance.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Romance.txt");
                libro = txtBuscarNombre.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtRomanceCodigo.Text = campo[0];
                        txtRomanceNombre.Text = campo[1];
                        txtRomanceAutor.Text = campo[2];
                        txtRomanceYear.Text = campo[3];
                        txtRomancePagina.Text = campo[4];
                        labelMensaje.Visible = false;
                        panelContenedorBNombreRomance.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();

                    }
                }

                if (encontrado == false)
                {
                    labelMensaje.Text = "No existe el libro en nuestra libreria";
                }
                Lectura.Close();
            }
            catch (FileNotFoundException fe)
            {
                labelMensaje.Text = ("¡ERROR!" + fe.Message);
            }
        }
    }
}

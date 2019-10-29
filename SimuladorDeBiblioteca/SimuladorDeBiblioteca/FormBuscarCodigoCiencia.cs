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
    public partial class FormBuscarCodigoCiencia : Form
    {
        public FormBuscarCodigoCiencia()
        {
            InitializeComponent();
            panelContenedorBCodigoCiencia.Visible = false;
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
                Lectura = File.OpenText("Ciencia.txt");
                libro = txtBuscarCodigo.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[0].Trim().Equals(libro))
                    {
                        txtCienciaCodigo.Text = campo[0];
                        txtCienciaNombre.Text = campo[1];
                        txtCienciaAutor.Text = campo[2];
                        txtCienciaYear.Text = campo[3];
                        txtCienciaPagina.Text = campo[4];
                        labelMensaje.Visible = false;
                        panelContenedorBCodigoCiencia.Visible = true;
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
